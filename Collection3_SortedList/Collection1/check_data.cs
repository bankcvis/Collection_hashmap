using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Collection1
{
    class check_data
    {
        public bool chk_values(string type ,string key)
        {
            if (key == "")
            {
                MessageBox.Show("Plase input values "+ type);
                return false;
            }
            return true;
        }

    }
}
