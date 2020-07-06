using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Collection1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList1;
        public MainWindow()
        {
            InitializeComponent();
            sortedList1 = new SortedList();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string key = txtKey.Text;
            string context = txtInput.Text;
            string data = "";

            check_data chk_Data = new check_data();

            bool chkKey =  chk_Data.chk_values("KEY",key);
            if (chkKey == true)
            {
                bool chkText = chk_Data.chk_values("TEXT", context);
                if (chkText == true)
                {
                    sortedList1.Add(int.Parse(key), context);
                    intitialValuse();

                    ICollection collection1  = sortedList1.Keys;
                    foreach (int cntkey in collection1)
                    {
                        data = data + sortedList1[cntkey].ToString() + " \n";
                    }

                    MessageBox.Show(data);
                    //MessageBox.Show(sortedList1[cntkey].ToString());
                }
            }
        }

        private void intitialValuse()
        {
            txtInput.Clear();
            txtKey.Clear();
        }
    }
}
