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
namespace texts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string CopyText = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string textCopy = textbox1.Text;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text = textbox1.Text + CopyText;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CopyText = textbox1.Text;
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            // Create a string array with the lines of text
            string lines =textbox1.Text;

            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "TaskText.txt")))
            {
                
                    outputFile.WriteLine(lines);
            }
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textbox1.Text = textbox2.Text;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            string lines = textbox1.Text;

            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "TaskText.txt")))
            {

                outputFile.WriteLine(lines);
            }
        }
    }
}
