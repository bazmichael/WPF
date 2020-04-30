using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1
{
    public partial class Values
    {
        private string numberOne="";
        private string numberTwo="";
        private string accumulator = "";
        private string result;
        
        public string NumberOne
        {
            get => numberOne;
            set => numberOne = value;
        }

        public string NumberTwo
        {
            get => numberTwo;
            set => numberTwo = value;
        }

        public string Accumulator
        {
            get => accumulator;
            set => accumulator = value;
        }

        public string Result
        {
            get => result;
            set => result = value;
        }

        
        public void SetZero()
        {
            numberOne = numberTwo = "";
        }

        public Values() { }

    };
}
