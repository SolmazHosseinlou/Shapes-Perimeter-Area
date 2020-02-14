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
            number1 = (double)txtLength.Value;
            number2 = (double)txtWidth.Value;
            if (Validation())
            {
                double thePerimeter = myrectangle.GetPerimeter(number1, number2);
                MessageBox.Show("محیط مستطیل مورد نظر شما = " + thePerimeter);
            }
        }


        bool Validation()
        {
            bool itsValid = true;
            if (number1 <= 0)
            {
                itsValid = false;
                MessageBox.Show("مقادیر، نمی توانند صفر یا عددی منفی باشند!");
            }
            else
            {
                if (number2 <= 0)
                {
                    itsValid = false;
                    MessageBox.Show("مقادیر، نمی توانند صفر یا عددی منفی باشند!");
                }
            }
            return itsValid;
        }

        private void BtnAreaR_Click(object sender, EventArgs e)
        {
            number1 = (double)txtLength.Value;
            number2 = (double)txtWidth.Value;
            if (Validation())
            {
                double theArea = myrectangle.GetArea(number1, number2);
                MessageBox.Show("مساحت مستطیل مورد نظر شما = " + theArea);
            }
            
        }

        private void BtnPerimeterS_Click(object sender, EventArgs e)
        {
            number1 = number2 = (double)txtSide.Value;
            if (Validation())
            {
                double thePerimeter = myrectangle.GetPerimeter(number1,number2);
                MessageBox.Show("محیط مربع مورد نظر شما = " + thePerimeter);
            }
        }

        private void BtnAreaS_Click(object sender, EventArgs e)
        {
            number1 = number2 = (double)txtSide.Value;
            if(Validation())
            {
                double theArea = myrectangle.GetArea(number1, number2);
                MessageBox.Show("مساحت مربع مورد نظر شما = " + theArea);
            }
            
        }

        private void BtnPerimeterC_Click(object sender, EventArgs e)
        {
            number1 = 1;
            number2 = (double)txtRadius.Value;
            if(Validation())
            {
                double thePerimeter = mycircle.GetPerimeter(number1, number2);
                MessageBox.Show("محیط دایره ی مورد نظر شما = " + thePerimeter);
            }
            


        }

        private void BtnAreaC_Click(object sender, EventArgs e)
        {
            number1 = 1;
            number2 = (double)txtRadius.Value;
            if(Validation())
            {
                double theArea = mycircle.GetArea(number1, number2);
                MessageBox.Show("مساحت دایره ی مورد نظر شما = " + theArea);
            }
        }

        private void BtnPerimeterT_Click(object sender, EventArgs e)
        {
            number1 = (double)txtBase.Value;
            number2 = (double)txtHeight.Value;
            if(Validation())
            {
                double thePerimeter = mytriangle.GetPerimeter(number1, number2);
                MessageBox.Show("محیط مثلث قایم الزاویه ی مورد نظر شما = " + thePerimeter);
            }
        }

        private void BtnAreaT_Click(object sender, EventArgs e)
        {
            number1 = (double)txtBase.Value;
            number2 = (double)txtHeight.Value;
            if(Validation())
            {
                double theArea = mytriangle.GetArea(number1, number2);
                MessageBox.Show("مساحت مثلث قایم الزاویه ی مورد نظر شما = " + theArea);
            }
        }
    }
}
