using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace Lab_4
{
    public class Calculator
    {

        private float xMin, xMax;

        private float mathFunction(float x) {
            return (float)Math.Cos(x) + .2f * x;
        }

        public Calculator(float xMin,float xMax) {
            this.xMin = xMin;
            this.xMax = xMax;
        }

        public List<float[]> calculate()
        {
            List<float[]> points = new List<float[]>();

            for (float i = xMin; i < xMax; i += 0.001f)
            {
                float[] item = new float[2];
                item[0] = i;
                item[1] = mathFunction(i);
                points.Add(item); // Add the point (float array) to the list
            }

            return points;
        }

        public static float CalculateDerivative(Func<float, float> function, float x, float h = 0.0001f)
        {
            // Using the formula: derivative ≈ (f(x + h) - f(x)) / h
            float xPlusH = x + h;
            float fx = function(x);
            float fxPlusH = function(xPlusH);
            return (fxPlusH - fx) / h;
        }
    }
}
