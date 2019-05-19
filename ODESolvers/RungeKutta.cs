using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODESolvers
{
    public static class RungeKutta
    {
        /// <summary>
        /// Rk4 method for solving system of two ODEs
        /// </summary>
        /// <param name="f1">First equation</param>
        /// <param name="f2">Second equation</param>
        /// <param name="preyPop">Initial prey population</param>
        /// <param name="predPop">Initial predator population</param>
        /// <param name="timeSpan">Solution time span</param>
        /// <param name="step">Calculation step size</param>
        /// <returns>Solution for predator and prey for time span</returns>
        public static double[,] Rk4(Func<double, double, double> f1, Func<double, double, double> f2,
            double preyPop, double predPop, int timeSpan, double step)
        {
            int temp = (int)Math.Floor(timeSpan / step);
            double[,] sol = new double[3, temp];

            // Initial data
            sol[0, 0] = preyPop;
            sol[1, 0] = predPop;
            sol[2, 0] = 0;

            double k1, k2, k3, k4;
            double q1, q2, q3, q4;

            for (int i = 0; i < temp - 1; i++)
            {
                k1 = step * f1(sol[0, i], sol[1, i]);
                q1 = step * f2(sol[0, i], sol[1, i]);

                k2 = step * f1(sol[0, i] + k1 * step / 2.0, sol[1, i] + q1 * step / 2.0);
                q2 = step * f2(sol[0, i] + k1 * step / 2.0, sol[1, i] + q1 * step / 2.0);

                k3 = step * f1(sol[0, i] + k2 * step / 2.0, sol[1, i] + q2 * step / 2.0);
                q3 = step * f2(sol[0, i] + k2 * step / 2.0, sol[1, i] + q2 * step / 2.0);

                k4 = step * f1(sol[0, i] + k3 * step, sol[1, i] + q3 * step);
                q4 = step * f2(sol[0, i] + k3 * step, sol[1, i] + q3 * step);

                // Solution for prey population
                sol[0, i + 1] = sol[0, i] + (k1 + 2 * k2 + 2 * k3 + k4) * step / 6;

                // Solution for predator population
                sol[1, i + 1] = sol[1, i] + (q1 + 2 * q2 + 2 * q3 + q4) * step / 6;

                // If solution became too large throw an exception
                if (double.IsInfinity(sol[0, i + 1]) || double.IsInfinity(sol[1, i + 1]))
                {
                    throw new ArgumentException("Too large coefficients, an overflow has occurred.");
                }

                // Particular point in time
                sol[2, i + 1] = i + 1;
            }

            return sol;
        }

        /// <summary>
        /// Rkf45 method with step optimization for solving system of two ODEs
        /// </summary>
        /// <param name="f1">First equation</param>
        /// <param name="f2">Second equation</param>
        /// <param name="preyPop">Initial prey population</param>
        /// <param name="predPop">Initial predator population</param>
        /// <param name="timeSpan">Solution time span</param>
        /// <param name="step">Calculation step</param>
        /// <returns>Solution for predator and prey for time span</returns>
        public static double[,] Rkf45(Func<double, double, double> f1, Func<double, double, double> f2,
            double preyPop, double predPop, int timeSpan, double step)
        {
            double[,] coef = new double[,] {
                 { 1932 / 2197.0, -7200 / 2197.0, 7296 / 2197.0, 0},
                 { 439 / 216.0, -8, 3680 / 513.0, -845 / 4104.0},
                 { 2, -3544 / 2565.0, 1859 / 4104.0, -11 / 40.0} };

            // Fallability limit before changing step size
            const double eps = 0.0005;

            int temp = timeSpan * 300;
            double[,] sol = new double[3, temp];

            // Initial data
            sol[0, 0] = preyPop;
            sol[1, 0] = predPop;
            sol[2, 0] = 0;

            double[] k = new double[6];
            double[] q = new double[6];
            double x1, x2, y1, y2;

            for (int i = 0; i < temp - 1; i++)
            {
                k[0] = step * f1(sol[0, i], sol[1, i]);
                q[0] = step * f2(sol[0, i], sol[1, i]);

                k[1] = step * f1(sol[0, i] + 0.25 * k[0], sol[1, i] + 0.25 * k[0]);
                q[1] = step * f2(sol[0, i] + 0.25 * q[0], sol[1, i] + 0.25 * q[0]);

                k[2] = step * f1(sol[0, i] + 3 * k[0] / 32.0 + 9 * k[1] / 32.0,
                                 sol[1, i] + 3 * k[0] / 32.0 + 9 * k[1] / 32.0);
                q[2] = step * f2(sol[0, i] + 3 * q[0] / 32.0 + 9 * q[1] / 32.0,
                                 sol[1, i] + 3 * q[0] / 32.0 + 9 * q[1] / 32.0);

                k[3] = step * f1(sol[0, i] + coef[0, 0] * k[0] + coef[0, 1] * k[1] + coef[0, 2] * k[2],
                                 sol[1, i] + coef[0, 0] * k[0] + coef[0, 1] * k[1] + coef[0, 2] * k[2]);
                q[3] = step * f2(sol[0, i] + coef[0, 0] * q[0] + coef[0, 1] * q[1] + coef[0, 2] * q[2],
                                 sol[1, i] + coef[0, 0] * q[0] + coef[0, 1] * q[1] + coef[0, 2] * q[2]);

                k[4] = step * f1(sol[0, i] + coef[1, 0] * k[0] + coef[1, 1] * k[1] + coef[1, 2] * k[2] + coef[1, 3] * k[3],
                                 sol[1, i] + coef[1, 0] * k[0] + coef[1, 1] * k[1] + coef[1, 2] * k[2] + coef[1, 3] * k[3]);
                q[4] = step * f2(sol[0, i] + coef[1, 0] * q[0] + coef[1, 1] * q[1] + coef[1, 2] * q[2] + coef[1, 3] * q[3],
                                 sol[1, i] + coef[1, 0] * q[0] + coef[1, 1] * q[1] + coef[1, 2] * q[2] + coef[1, 3] * q[3]);

                k[5] = step * f1(sol[0, i] - 8 * k[0] / 27.0 + 2 * k[1] + coef[2, 1]
                                 * k[2] + coef[2, 2] * k[3] + coef[2, 3] * k[4],
                                 sol[1, i] - 8 * k[0] / 27.0 + 2 * k[1] + coef[2, 1]
                                 * k[2] + coef[2, 2] * k[3] + coef[2, 3] * k[4]);
                q[5] = step * f2(sol[0, i] - 8 * q[0] / 27.0 + 2 * q[1] + coef[2, 1]
                                 * q[2] + coef[2, 2] * q[3] + coef[2, 3] * q[4],
                                 sol[1, i] - 8 * q[0] / 27.0 + 2 * q[1] + coef[2, 1]
                                 * q[2] + coef[2, 2] * q[3] + coef[2, 3] * q[4]);

                // 4th order solution for prey population
                x1 = sol[0, i] + 25 * k[0] / 216.0 + 1408 * k[2] / 2565.0 + 2197 * k[3] / 4101.0 - 0.2 * k[4];

                // 5th order solution for prey population
                x2 = sol[0, i] + 16 * k[0] / 135.0 + 6656 * k[2] / 12825.0 + 28561
                    * k[3] / 56430.0 - 9 * k[4] / 50.0 + 2 * k[5] / 55.0;

                // 4th order solution for predator population
                y1 = sol[1, i] + 25 * q[0] / 216.0 + 1408 * q[2] / 2565.0 + 2197 * q[3] / 4101.0 - 0.2 * q[4];

                // 5th order solution for predator population
                y2 = sol[1, i] + 16 * q[0] / 135.0 + 6656 * q[2] / 12825.0 + 28561
                    * q[3] / 56430.0 - 9 * q[4] / 50.0 + 2 * q[5] / 55.0;


                sol[0, i + 1] = x2;
                sol[1, i + 1] = y2;

                // Particular point in time
                sol[2, i + 1] = sol[2, i] + step;

                double xdel = Math.Abs(x1 - x2);
                double ydel = Math.Abs(y1 - y2);

                // If fallibility limit exceeded
                if (xdel > eps)
                {
                    OptimizeStep(ref step, xdel);
                }
                else 
                if (ydel > eps)
                {
                    OptimizeStep(ref step, ydel);
                }          
            }

            return sol;
        }

        /// <summary>
        /// Optimizes step size
        /// </summary>
        /// <param name="step">Calculation step size</param>
        /// <param name="delta">Difference between 4th and 5th order solutions</param>
        private static void OptimizeStep(ref double step, double delta)
        {
            // Tolerance fallibility
            const double tol = 0.0001;

            step *= Math.Pow(tol * step / (2 * delta), 0.25);
        }
    }
}
