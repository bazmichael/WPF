using System;
using System.Windows;


namespace WPF1
{
 


    public partial class MainWindow : Window
    {
        Values values = new Values();
        Operations operations = new Operations();
        Checks checks = new Checks();
        
        
        public void WriteNumber(int number)
        {
            
            if (operations.operationIsEmpty())
            {
                values.NumberOne  += number.ToString();
                display.Text = values.NumberOne;
            }
            else
            {
                values.NumberTwo +=  number.ToString();
                display.Text = values.NumberTwo;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            WriteNumber(1);

        }



        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (checks.PlusClickedCheck)
            {
                if (values.NumberOne != "")
                {
                    display.Text = values.Accumulator = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberOne = display.Text;
                    values.NumberTwo = "";
                }
            }
            else
            {
                display.Text = "0";
                operations.setOperation("adding");
                checks.PlusClickedCheck = true;
            }
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {

            if (operations.operationIsEmpty())
            {
                if (!checks.EqualsCheck)
                    display.Text = values.NumberOne;
                else
                    display.Text = values.Result;
            }
            else
            {
                values.Result = values.Accumulator =  operations.operate(values.NumberOne, values.NumberTwo).ToString();
                display.Text = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                operations.clearOperation();
                checks.EqualsCheck = true;
                
            }
        }

        private void buttonSubstract_Click(object sender, RoutedEventArgs e)
        {
            if (checks.MinusClickedCheck)
            {
                if (values.NumberOne != "")
                {
                    display.Text = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberOne = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberTwo = "";
                }
                
            }
    

            else
            {
                if (values.NumberOne == "")
                {
                    display.Text = "-";
                    values.NumberOne = "-";
                }
                else
                {
                    display.Text = "0";
                    operations.setOperation("subtracting");
                    checks.MinusClickedCheck = true;
                }
            }
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (checks.MultiplyClickedCheck)
            {
                if (values.NumberOne != "")
                {
                    display.Text = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberOne = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberTwo = "";
                }
            }
            else {
                display.Text = "0";
                operations.setOperation("multiplication");
                checks.MultiplyClickedCheck = true;
            }
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (checks.DivideClickedCheck)
            {
                if (values.NumberOne != "")
                {
                    display.Text = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberOne = operations.operate(values.NumberOne, values.NumberTwo).ToString();
                    values.NumberTwo = "";
                }
            }
            else
            {
                display.Text = "0";
                operations.setOperation("dividing");
                checks.DivideClickedCheck = true;
            }
        }

        private void buttonClearEntry_Click(object sender, RoutedEventArgs e)
        {

            if (operations.operationIsEmpty())
                values.NumberOne = "";
            else
                values.NumberTwo = "";

            display.Text = "0";
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            operations.clearOperation();
            checks.ResetChecks();
            values.SetZero();
            display.Text = "0";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(2);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(3);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(4);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(5);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(6);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(7);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(8);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            WriteNumber(9);
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e)
        {
            if (operations.operationIsEmpty())
            {
                if(values.NumberOne != "0")
                    values.NumberOne += "0";
                display.Text = values.NumberOne;
            }
            else
            {
                values.NumberTwo += "0";
                display.Text = values.NumberTwo;
            }
        }

        private void buttonBackspace_Click(object sender, RoutedEventArgs e)
        {
           
            if (operations.operationIsEmpty())
            {
                if(values.NumberOne.Length >= 1) 
                    values.NumberOne = values.NumberOne.Remove(values.NumberOne.Length - 1);
                display.Text = values.NumberOne;
                
            }
            else
            {
                if (values.NumberTwo.Length >= 1)
                    values.NumberTwo = values.NumberOne.Remove(values.NumberTwo.Length - 1);
                display.Text = values.NumberTwo;
            }
        }

        private void buttonPositivity_Click(object sender, RoutedEventArgs e)
        {
            if (operations.operationIsEmpty())
            {
                if (values.NumberOne.Length >= 1)
                {
                    values.NumberOne = (Convert.ToDouble(values.NumberOne) * -1).ToString();
                    display.Text = values.NumberOne;
                } 
            }
            else
            {
                if (values.NumberTwo.Length >= 1)
                    values.NumberTwo = (Convert.ToDouble(values.NumberTwo) * -1).ToString();
                display.Text = values.NumberTwo;
            }
        }
        
        private void buttonFloat_Click(object sender, RoutedEventArgs e)
        {
            if (operations.operationIsEmpty())
            {
                if(!values.NumberOne.Contains("."))
                    values.NumberOne += ".";
                display.Text = values.NumberOne;
            } 
            else
            {
                if (!values.NumberTwo.Contains("."))
                    values.NumberTwo += ".";
                display.Text = values.NumberTwo;
            }
        }
    }
}
