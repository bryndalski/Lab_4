using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace Lab_4
{

    public class CalculationResult
    {
        public List<float[]> Points { get; set; }
        public float[] Max { get; set; }
        public float[] Min { get; set; }
    }

    public class Calculator
    {

        private float xMin, xMax;

        private float mathFunction(float x) {
            return ((float)Math.Cos(x) + (.2f * x));
        }

        public Calculator(float xMin,float xMax) {
            this.xMin = xMin;
            this.xMax = xMax;
        }

        public CalculationResult Calculate()
        {
            List<float[]> points = new List<float[]>();
            float[] maxPoint = new float[3] { float.MinValue, float.MinValue, float.MinValue};
            float[] minPoint = new float[3] { float.MaxValue, float.MaxValue, float.MinValue };

            for (float i = xMin; i < xMax; i += 0.001f)
            {
                float[] item = new float[2];
                item[0] = i;
                item[1] = mathFunction(i);
                points.Add(item);

                // Update max and min points
                if (item[1] > maxPoint[1])
                {
                    maxPoint[0] = item[0];
                    maxPoint[1] = item[1];
                    maxPoint[2] = i;
                }
                if (item[1] < minPoint[1]) {
                    minPoint[0] = item[0];
                    minPoint[1] = item[1];
                    minPoint[2] = i;
                }
            }

            CalculationResult result = new CalculationResult
            {
                Points = points,
                Max = maxPoint,
                Min = minPoint
            };

            return result;
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
