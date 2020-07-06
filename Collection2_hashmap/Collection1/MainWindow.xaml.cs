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
        Hashtable hashtable1;
        public MainWindow()
        {
            InitializeComponent();
            hashtable1 = new Hashtable();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection icolletion = hashtable1.Keys;
            foreach (string key in icolletion)
            {
                MessageBox.Show(hashtable1[key].ToString() );
            }
            intitialValuse();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string key = txtKey.Text;
            string context = txtInput.Text;

            check_data chk_Data = new check_data();

            bool chkKey =  chk_Data.chk_values("KEY",key);
            if (chkKey == true)
            {
                bool chkText = chk_Data.chk_values("TEXT", context);
                if (chkText == true)
                {
                    hashtable1.Add(key, context);
                    intitialValuse();
                }
            }
            //hashtable1.Add("Rockman","X");
            //hashtable1.Add("Cat","OnThRoof");
            //hashtable1.Add("Dog", "OnThRock");
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            string key = txtKey.Text;
            check_data chk_Data = new check_data();

            bool chkKey = chk_Data.chk_values("KEY", key);
            if (chkKey == true)
            {
                hashtable1.Remove(key);
                intitialValuse();
            }
            
        }

        private void intitialValuse()
        {
            txtInput.Clear();
            txtKey.Clear();
        }
    }
}
