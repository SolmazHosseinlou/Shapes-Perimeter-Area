using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class frmShape : Form
    {
        double number1;
        double number2;

        IShape myrectangle;
        IShape mycircle;
        IShape mytriangle;

        public frmShape()
        {
            InitializeComponent();
            myrectangle = new Rectangle();
            mycircle = new Circle();
            mytriangle = new RightAngledTriangle();
        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void NumericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnPerimeterR_Click(object sender, EventArgs e)
        {

        }


        bool Validation()
        {
            bool itsValid = true;
            while (number1 <= 0)
            {
                itsValid = false;
                MessageBox.Show("مقادیر، نمی توانند صفر یا عددی منفی باشند!");
            }
            while (number2 <= 0)
            {
                itsValid = false;
                MessageBox.Show("مقادیر، نمی توانند صفر یا عددی منفی باشند!");
            }
            return itsValid;
        }
    }
}
