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
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Futa_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XmlSerializer xs;
        List<StudentClass> ls;
        public MainWindow()
        {
            InitializeComponent();

            ls = new List<StudentClass>();
            xs = new XmlSerializer(typeof(List<StudentClass>));
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Collada files (*.dae)|*.dae";
            openFileDialog.Title = "Select a Model File to convert...";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if(fLarge.IsChecked == true)
            {
                FileStream
            }

            else if(fMedium.IsChecked == true)
            {
                //Futa Medium Stuff Here
            }

            else if(fSmall.IsChecked == true)
            {
                //Futa Small Stuff Here
            }

            else if(hLarge.IsChecked == true)
            {
                //Herma Large Stuff Here
            }

            else if(hMedium.IsChecked == true)
            {
                //Herma Medium Stuff Here
            }

            else if(hSmall.IsChecked == true)
            {
                //Herma Small Stuff Here
            }

        }

    }
}
