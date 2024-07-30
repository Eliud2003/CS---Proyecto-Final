using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto___CS.View
{
    internal class ValidateInputData
    {
        internal static bool OnlyNumber(KeyPressEventArgs e, TextBox txtnum)
        {
            if (char.IsNumber(e.KeyChar) && txtnum.Text.Length < 10)
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public static bool Onlyletters(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public static bool TxtEmpty(TextBox txt)
        {
            if (txt.Text == string.Empty)
            {
                txt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
