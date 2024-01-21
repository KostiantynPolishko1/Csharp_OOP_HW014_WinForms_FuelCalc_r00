using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace C__OOP_HW014_WinForms_FuelCalc_r00
{
    public class FuelCost
    {
        public float Distance { get; set; }
        public float Consumption { get; set; }
        public float Price { get; set; }

        public static string[] Message;

        static FuelCost()
        {
            Message = new string[] { "Distance", "Consumption", "Price" };
        }
        public FuelCost() { }

        public static (bool, float) IsValue(in string inputValue)
        {
            float treatValue;

            return (float.TryParse(inputValue, out treatValue), Math.Abs(treatValue));
        }
    }
}
