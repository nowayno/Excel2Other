using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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

namespace Excel2Ohter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i.ToString());
            }
            dic["1"] = list;
            dic["2"] = "hhhhh";
            dic["3"] = "xxxxx";
            dic["4"] = "ccccc";

            Dictionary<string, object> dic1 = new Dictionary<string, object>();
            dic1["1"] = list;
            dic1["2"] = "hhhhh";
            dic1["3"] = "xxxxx";
            dic1["4"] = "ccccc";

            dic["5"] = dic1;
            textBox1.Text = JsonConvert.SerializeObject(dic);
        }
    }
}
