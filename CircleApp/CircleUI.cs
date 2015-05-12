using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class CircleUI : Form
    {
        public CircleUI()
        {
            InitializeComponent();
        }

        Circle aCircle = new Circle();
        private void diametreButton_Click(object sender, EventArgs e)
        {
            aCircle.radius = Convert.ToDouble(radiusTextBox.Text);

            reslutLabel.Text = "Diametre";

            resultTextBox.Text=aCircle.CalculateDiametre().ToString();
        }

        private void perimetreButton_Click(object sender, EventArgs e)
        {
            aCircle.radius = Convert.ToDouble(radiusTextBox.Text);

            reslutLabel.Text = "Perimetre";

            resultTextBox.Text = aCircle.CalculatePerimetre().ToString();
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            aCircle.radius = Convert.ToDouble(radiusTextBox.Text);

            reslutLabel.Text = "Area";

            resultTextBox.Text = aCircle.CalculateArea().ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            radiusTextBox.Clear();
            resultTextBox.Clear();
            reslutLabel.Text = "Result";
        }
    }
}
