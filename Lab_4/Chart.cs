using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_4
{
    public class Chart
    {
        private System.Drawing.Graphics systemGraphics;
        private int ChartTopX = 290;
        private int ChartTopY = 50;
        private int chartWidth = 300;
        private int chartHeight = 300;
        private int spaceBetweenChartDescriptoion = 20; //Gap between lines
        private Font drawFont = new Font("Arial", 16);
        private Pen bpen = new Pen(Color.Black,5); // Creating a black pen (you can change the color)


        public Chart(System.Drawing.Graphics systemGraphics)
        {
            this.systemGraphics = systemGraphics;
            //this.drawChartBox();
            //draw chart X
            this.drawVerticalText("OŚ Y", ChartTopX- spaceBetweenChartDescriptoion*3, ChartTopY,true); // Change the coordinates as needed
            //Draw chart y
            this.drawVerticalText("OŚ X", ChartTopX, ChartTopY+chartHeight+ spaceBetweenChartDescriptoion*3, false); // Change the coordinates as needed 
        }

        public void buildHorizontalLines(float precision, int minimumX, int maximumX)
        {
            int lineNumbers = (int)Math.Ceiling((maximumX - minimumX) / precision)-1;
            float lineGap = chartHeight / (float)lineNumbers; // Calculate gap as a float value

            float yPosition = ChartTopY;
            float currentDisplayedScaleNumber = maximumX;
            StringFormat formatString = new StringFormat();
            formatString.Alignment = StringAlignment.Center;
            using (Font font = new Font("Arial", 12))
            { // Font creation moved outside the loop
                for (int i = 0; i <= lineNumbers; i++)
                {
                    Rectangle rect = new Rectangle(ChartTopX- spaceBetweenChartDescriptoion-15, (int)yPosition-10, 30, 30);
                    this.systemGraphics.DrawString(currentDisplayedScaleNumber.ToString(), font, Brushes.Black, rect, formatString);
                    //Draw line
                    Pen greyPen = new Pen(Color.Gray, 2f);
                    this.systemGraphics.DrawLine(greyPen, ChartTopX  , yPosition, ChartTopX + chartWidth, yPosition);


                    yPosition += lineGap; // Calculate x position based on line gap
                    currentDisplayedScaleNumber -= precision;
                }
            }
        }

        /**
         * Builds vertival lines
         */
        public void buildVerticalLines(float precision, int minimumX, int maximumX)
        {
            int lineNumbers = (int)Math.Ceiling((maximumX - minimumX) / precision);
            //Line numbers must be between <4,9>
            float lineGap = chartWidth / (float)lineNumbers; // Calculate gap as a float value
            
            float xPosition = ChartTopX;
            float currentDisplayedScaleNumber = minimumX;
            StringFormat formatString = new StringFormat();
            formatString.Alignment = StringAlignment.Center;
            using (Font font = new Font("Arial", 12))

            { // Font creation moved outside the loop
                for (int i = 0; i <= lineNumbers; i++)
                { 
                    Rectangle rect = new Rectangle((int)xPosition-15, ChartTopY + chartHeight+ spaceBetweenChartDescriptoion,30,30);
                    this.systemGraphics.DrawString(currentDisplayedScaleNumber.ToString(), font, Brushes.Black, rect, formatString);
                    //Draw line
                    Pen greyPen = new Pen(Color.Gray, .2f);
                    this.systemGraphics.DrawLine(greyPen, (int)xPosition, ChartTopY, xPosition, ChartTopY + chartHeight);

                    
                    xPosition += lineGap; // Calculate x position based on line gap
                    currentDisplayedScaleNumber += precision;
                }
            }
        }

        public void drawChartTitle(string title)
        {
            //Draw chart TITLE 
           drawVerticalText($"Wykres funkcji\n${title}", ChartTopX, 10, false); // Change the coordinates as needed
        }


        public void drawPoint(List<float[]> pointsLits)
        {

            //calcualte estimated distance between points
            float distanceX = chartWidth / (float)pointsLits.LongCount();
            float distanceY = chartHeight / (float)pointsLits.LongCount();
            const float pointDiameter = 5.0f;
            int count = 0;
            //float[] point = pointsLits[0];
            pointsLits.ForEach(point =>
            {
//                PointF point1 = //new PointF(ChartTopX - point[0], ChartTopY + chartHeight -pointDiameter/2 - (float)point[1]);
 //               PointF point2 = //new PointF(point1.X + pointDiameter, point1.Y);
                this.systemGraphics.FillEllipse(Brushes.Red, ChartTopX +count*(distanceX) -pointDiameter/2 + point[0], ChartTopY + chartHeight - pointDiameter / 2 - (float)point[1] * count * (distanceY), pointDiameter,pointDiameter);
                count++;

            });

        }

        private void drawChartBox()
        {
            Pen blackPen = new Pen(Color.Black, 4);
            systemGraphics.DrawRectangle(blackPen, ChartTopX, ChartTopY, chartHeight, chartWidth);
        }

       

        /**
         * Draws axcle for chart
         * @private
         */
        private void drawVerticalText(string text, int x, int y, bool isVertical)
        {
            StringFormat verticalFormat = new StringFormat();
            if(isVertical) 
                verticalFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            verticalFormat.Alignment = StringAlignment.Center;

            using (Font font = new Font("Arial", 12)) // Change the font and size as desired
            {
                Rectangle rect;

                if (isVertical) //Dull height 30 width
                    rect = new Rectangle(x, y, spaceBetweenChartDescriptoion, chartHeight); // Adjust the rectangle size and position
                else //Full width, 30 heith
                    rect = new Rectangle(x, y, chartWidth, ChartTopY);
                systemGraphics.DrawString(text, font, Brushes.Black, rect, verticalFormat);
  
            }
        }
    }

    
    
}
