using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1
{
    class Checks
    {
        private bool equalsCheck = false;
        private bool plusClickedCheck = false;
        private bool minusClickedCheck = false;
        private bool multiplyClickedCheck = false;
        private bool divideClickedCheck = false;

        public bool EqualsCheck
        {
            get => equalsCheck;
            set => equalsCheck = value;
        }

        public bool PlusClickedCheck
        {
            get => plusClickedCheck;
            set => plusClickedCheck = value;
        }

        public bool MinusClickedCheck
        {
            get => minusClickedCheck;
            set => minusClickedCheck = value;
        }

        public bool MultiplyClickedCheck
        {
            get => multiplyClickedCheck;
            set => multiplyClickedCheck = value;
        }

        public bool DivideClickedCheck
        {
            get => divideClickedCheck;
            set => divideClickedCheck = value;
        }

        public void ResetChecks()
        {
            equalsCheck = plusClickedCheck = minusClickedCheck = divideClickedCheck =  multiplyClickedCheck = false;
        }

    }
}
