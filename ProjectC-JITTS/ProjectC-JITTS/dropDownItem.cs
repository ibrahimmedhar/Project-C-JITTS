using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS
{
    /// <summary>
    /// add a new object which acts like a ComboBoxItem but wth an hidden item (for instance an ID)
    /// </summary>
    class dropDownItem
    {
        string displayValue;
        string hiddenValue;

        //Constructor
        public dropDownItem(string d, string h)
        {
            displayValue = d;
            hiddenValue = h;
        }

        //Accessor
        public string HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return displayValue;
        }
    }
}

