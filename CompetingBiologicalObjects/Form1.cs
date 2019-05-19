using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using ODESolvers;

namespace CompetingBiologicalObjects
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Pane for adding and managing curves
        /// </summary>
        private static GraphPane pane;
        
        public Form1()
        {
            InitializeComponent();

            // Setting graph description
            pane = GraphControl.GraphPane;
            pane.Title = "";
            pane.XAxis.Title = "Time";
            pane.YAxis.Title = "Number of species";
        }

        /// <summary>
        /// Plot solution
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void PlotButton_Click(object sender, EventArgs e)
        {
            pane.CurveList.Clear();
            
            // Prey population equation
            Func<double, double, double> preyPop = (x, y) =>
            x * ((double)PreyBirthRate.Value - (double)PreyDeathRate.Value * y);

            // Predator population equation
            Func<double, double, double> predatorPop = (x, y) =>
            y * ((double)PredatorBirthRate.Value * x - (double)PredatorDeathRate.Value);

            // Solution for predator and prey
            double[,] preyAndPredatorCurves;

            try
            {
                // checking what algorith to use
                if (RKF45.Checked)
                {
                    preyAndPredatorCurves = RungeKutta.Rkf45(preyPop, predatorPop, (double)PreyPopulation.Value,
                        (double)PredatorPopulation.Value, (int)TimeSpan.Value, 0.01);
                }
                else
                {
                    preyAndPredatorCurves = RungeKutta.Rk4(preyPop, predatorPop, (double)PreyPopulation.Value,
                        (double)PredatorPopulation.Value, (int)TimeSpan.Value, (double)StepSize.Value);
                }

                PointPairList preySolution = new PointPairList();

                for (int i = 0; i <= preyAndPredatorCurves.GetUpperBound(1); i++)
                {
                    preySolution.Add(preyAndPredatorCurves[2, i], preyAndPredatorCurves[0, i]);
                }

                PointPairList predatorSolution = new PointPairList();

                for (int i = 0; i <= preyAndPredatorCurves.GetUpperBound(1); i++)
                {
                    predatorSolution.Add(preyAndPredatorCurves[2, i], preyAndPredatorCurves[1, i]);
                }

                // Adding prey population curve
                LineItem preyCurve = pane.AddCurve("Prey population",
                    preySolution, Color.Green, SymbolType.None);
                preyCurve.Line.Width = 2;
                preyCurve.Line.IsSmooth = true;

                // Adding predator population curve
                LineItem predatorCurve = pane.AddCurve("Predator population",
                    predatorSolution, Color.Red, SymbolType.None);
                predatorCurve.Line.Width = 2;
                predatorCurve.Line.IsSmooth = true;
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + "\nPlease enter smaller parameters", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                  
            // Changing axis to fit the curves
            GraphControl.AxisChange();
            GraphControl.Invalidate();
        }

        /// <summary>
        /// Save graph as
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveGraphDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveGraphDialog.OpenFile();

                Bitmap bt = new Bitmap(GraphControl.Width, GraphControl.Height);
                GraphControl.DrawToBitmap(bt, new Rectangle(0, 0, bt.Width, bt.Height));

                bt.Save(fs, ImageFormat.Png);
                fs.Dispose();
            }
        }

        /// <summary>
        /// About program window
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program is designed to simulate interraction\n" +
                "between two populations using Lotka-Volterra model",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Change current algorithm
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void RKF45_CheckedChanged(object sender, EventArgs e)
        {
            StepSize.Enabled = !StepSize.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            // Setting popup tips
            toolTip.SetToolTip(this.RKF45, "Slower, more precise");

            toolTip.SetToolTip(this.PredPreyTabControl, "Initial data");

            toolTip.SetToolTip(this.PlotButton, "Plot population graph");
        }
    }
}
