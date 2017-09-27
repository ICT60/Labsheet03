using System;
using System.Windows.Forms;

namespace Labsheet03
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStringConcat_Click(object sender, EventArgs e)
        {
            var result = String.Format("{0}{1}", txtInputA.Text, txtInputB.Text);
            txtResult.Text = result;
        }

        private void btnMultipleStringConcat_Click(object sender, EventArgs e)
        {
            var result = String.Format("{0}{1}", txtInputA.Text, txtInputB.Text);
            txtResult.Text += result;
        }

        void _ClearResultTextBox(ref TextBox textboxObject)
        {
            textboxObject.Text = String.Empty;
        }

        void btnPlus_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA = 0;
            decimal numB = 0;

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                _ShowCalculateResult('+', numA, numB, ref txtResult);
            }
            else
            {
                var alert = "Please enter validate number";
                MessageBox.Show(alert, "Error");
            }
        }

        void btnMinus_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA = 0;
            decimal numB = 0;

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                _ShowCalculateResult('-', numA, numB, ref txtResult);
            }
            else
            {
                var alert = "Please enter validate number";
                MessageBox.Show(alert, "Error");
            }
        }

        void btnMultiply_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA; 
            decimal numB; 

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                _ShowCalculateResult('*', numA, numB, ref txtResult);
            }
            else
            {
                var alert = "Please enter validate number";
                MessageBox.Show(alert, "Error");
            }
        }

        void btnDivide_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA; 
            decimal numB; 

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                if (numB != 0)
                {
                    _ShowCalculateResult('/', numA, numB, ref txtResult);
                }
                else
                {
                    var alert = "Can't divide a number by zero.";
                    MessageBox.Show(alert, "Error");
                }
            }
            else
            {
                var alert = "Please enter validate number.";
                MessageBox.Show(alert, "Error");
            }
        }

        void btnMod_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA; 
            decimal numB; 

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                if (numB != 0)
                {
                    _ShowCalculateResult('%', numA, numB, ref txtResult);
                }
                else
                {
                    var alert = "Can't divide a number by zero.";
                    MessageBox.Show(alert, "Error");
                }
            }
            else
            {
                var alert = "Please enter validate number.";
                MessageBox.Show(alert, "Error");
            }
        }

        void btnLessThan_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA; 
            decimal numB; 

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                _ShowCalculateResult('<', numA, numB, ref txtResult);
            }
        }

        void btnGreatherThan_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA; 
            decimal numB; 

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                _ShowCalculateResult('>', numA, numB, ref txtResult);
            }
        }

        void btnEqual_Click(object sender, EventArgs e)
        {
            var isCanParseA = false;
            var isCanParseB = false;

            decimal numA; 
            decimal numB; 

            isCanParseA = decimal.TryParse(txtInputA.Text, out numA);
            isCanParseB = decimal.TryParse(txtInputB.Text, out numB);

            if (isCanParseA && isCanParseB)
            {
                _ShowCalculateResult('=', numA, numB, ref txtResult);
            }
        }

        void _On_AnyButton_Pressed(object sender, EventArgs e)
        {
            _ClearResultTextBox(ref txtResult);
        }

        void _ShowCalculateResult(char operatorChar, decimal valueA, decimal valueB, ref TextBox txtResult)
        {
            var result = String.Empty;

            switch (operatorChar)
            {
                case '+':
                    result = (valueA + valueB).ToString();
                    break;

                case '-':
                    result = (valueA - valueB).ToString();
                    break;

                case '*':
                    result = (valueA * valueB).ToString();
                    break;

                case '/':
                    if (valueB != 0)
                    {
                        result = (valueA / valueB).ToString();
                    }
                    break;

                case '%':
                    result = (valueA % valueB).ToString();
                    break;

                case '<':
                    result = (valueA < valueB).ToString();
                    break;

                case '>':
                    result = (valueA > valueB).ToString();
                    break;

                case '=':
                    result = (valueA == valueB).ToString();
                    break;
            }

            txtResult.Text = result;
        }
    }
}
