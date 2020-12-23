using System;
using System.Collections.Generic;
using System.IO;
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

namespace corona
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

        private void btnBusca_Click(object sender, RoutedEventArgs e)
        {


            List<string> lstExt = txtbusca.Text.Split(',').ToList();
            DirectoryInfo dirBusca = new DirectoryInfo(txtcaminho.Text);

            string lstarq = "";

            foreach (string v in lstExt)
            {
                foreach (FileInfo f in dirBusca.GetFiles(v, SearchOption.AllDirectories))
                {
                    lstarq += f.FullName + "\r\n";
                }
            }

            File.WriteAllText("D:\\Temp\\corona.txt", lstarq);
        }
    }
}
