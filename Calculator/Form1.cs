using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Oprator Oprator { get; set; }
        public decimal? OprandOne { get; set; } = null;
        public decimal? OprandTwo { get; set; } = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox.AppendText("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox.AppendText("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBox.AppendText("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textBox.AppendText("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBox.AppendText("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBox.AppendText("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBox.AppendText("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox.AppendText("7");
        }

        private void btnEghit_Click(object sender, EventArgs e)
        {
            textBox.AppendText("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBox.AppendText("9");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Oprator = Oprator.Division;
            decimal number;
            try
            {
                number = Convert.ToDecimal(textBox.Text);
                ManageOprand(number);
            }
            catch (Exception)
            {

            }
            finally
            {
                tbHistory.Text = OprandOne + "÷";
                textBox.Clear();
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Oprator = Oprator.Multi;
            decimal number;
            try
            {
                number = Convert.ToDecimal(textBox.Text);
                ManageOprand(number);
            }
            catch (Exception)
            {

            }
            finally
            {
                tbHistory.Text = OprandOne + "×";
                textBox.Clear();
            }
        }


        private void btnMines_Click(object sender, EventArgs e)
        {
            Oprator = Oprator.Sub;
            decimal number;
            try
            {
                number = Convert.ToDecimal(textBox.Text);
                ManageOprand(number);
            }
            catch (Exception)
            {

            }
            finally
            {
                tbHistory.Text = OprandOne + "-";
                textBox.Clear();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Oprator = Oprator.Sum;
            decimal number;
            try
            {
                number = Convert.ToDecimal(textBox.Text);
                ManageOprand(number);
            }
            catch (Exception)
            {

            }
            finally
            {
                tbHistory.Text = OprandOne + "+";
                textBox.Clear();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (OprandOne != null)
            {

                decimal percent = 0, number;
                try
                {
                    number = Convert.ToDecimal(textBox.Text);
                    percent = (decimal)(OprandOne * (number / 100));
                    OprandTwo = percent;
                }
                catch (Exception)
                {

                }
                finally
                {
                    tbHistory.Text = tbHistory.Text + percent.ToString();
                    textBox.Clear();
                }
            }

        }

        private void ManageOprand(decimal number)
        {
            if (OprandOne == null)
            {
                OprandOne = number;
            }
            else
            {
                OprandTwo = number;
            }
        }

        private void btnEqule_Click(object sender, EventArgs e)
        {
            if (OprandOne == null)
            {
                ClearAll();
                return;
            }
            if (OprandTwo == null)
            {
                decimal number;
                try
                {
                    number = Convert.ToDecimal(textBox.Text);
                    ManageOprand(number);
                }
                catch (Exception)
                {
                    throw;
                }

            }

            if (OprandOne != null && OprandTwo != null && Oprator != null)
            {
                string history;
                switch (Oprator)
                {
                    case Oprator.Division:
                        history = $"{OprandOne} ÷ {OprandTwo} =";
                        tbHistory.Text = history;
                        textBox.Text = ((decimal)OprandOne / (decimal)OprandTwo).ToString();
                        break;

                    case Oprator.Multi:
                        history = $"{OprandOne} × {OprandTwo} =";
                        tbHistory.Text = history;
                        textBox.Text = (OprandOne * OprandTwo).ToString();
                        break;

                    case Oprator.Sub:
                        history = $"{OprandOne} - {OprandTwo} =";
                        tbHistory.Text = history;
                        textBox.Text = (OprandOne - OprandTwo).ToString();
                        break;

                    case Oprator.Sum:
                        history = $"{OprandOne} + {OprandTwo} =";
                        tbHistory.Text = history;
                        textBox.Text = ((decimal)OprandOne + (decimal)OprandTwo).ToString();
                        break;

                    case Oprator.Percent:
                        break;

                    case Oprator.Sin:
                        break;

                    default:
                        break;
                }
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double number = 0;
            try
            {
                number = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                tbHistory.Text = $"Sin({number}) = {Math.Sin(number).ToString()}";
                textBox.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        private void ClearAll()
        {
            OprandOne = null;
            OprandTwo = null;
            tbHistory.Clear();
            textBox.Clear();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {

            decimal number = 0;
            try
            {
                number = Convert.ToDecimal(textBox.Text);

            }
            catch (Exception)
            {

            }
            finally
            {
                tbHistory.Text = $"√({number}) = {Math.Sqrt((double)number)}";
                textBox.Clear();
            }

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            decimal number = 0;
            try
            {
                number = Convert.ToDecimal(textBox.Text);

            }
            catch (Exception)
            {

            }
            finally
            {
                tbHistory.Text = $"log({number}) = {Math.Log10((double)number)}";
                textBox.Clear();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double number = 0;
            try
            {
                number = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                tbHistory.Text = $"Cos({number}) = {Math.Cos(number).ToString()}";
                textBox.Clear();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double number = 0;
            try
            {
                number = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                tbHistory.Text = $"Tan({number}) = {Math.Tan(number).ToString()}";
                textBox.Clear();
            }
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            double number = 0;
            try
            {
                number = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                tbHistory.Text = $"Cot({number}) = {Math.Atan(1 / (number))}";
                textBox.Clear();
            }
        }
    }
}
