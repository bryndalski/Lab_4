using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private int minValue=1;
        private int maxValue=5;
        public Chart epicChart;
        public Calculator calculate;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            epicChart = new Chart(g);
            epicChart.buildVerticalLines(1f, minValue, maxValue);
            epicChart.drawChartTitle("y=-1x+3");
            epicChart.buildHorizontalLines(1f, minValue, maxValue);
            calculate = new Calculator(minValue, maxValue);
            epicChart.drawPoint(calculate.calculate());

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
       
            this.Refresh();
        }


        private void Range_x2_TextChanged_1(object sender, EventArgs e)
        {

            if (int.TryParse(Range_x2.Text, out int value))
            {

                maxValue = value;
            }
        }

        private void Range_x1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Range_x1.Text, out int value))
            {

                minValue = value;
            }
        }


        private void Range_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateOnRangeKeyPres(sender, e, Range_x1);
        }

        private void Range_x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateOnRangeKeyPres(sender, e, Range_x2);
        }

        private void ValidateOnRangeKeyPres(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            string currentText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());
            string pattern = @"^-?\d*\.?\d*$"; // Regex pattern for allowing -5, 5.4, etc.

            if (!Regex.IsMatch(currentText, pattern) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent input that doesn't match the regex pattern
            }
        }
    }
}
