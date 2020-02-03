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

namespace WpfApp1.FilesandFormatting
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

        private void BtnPride_Click(object sender, RoutedEventArgs e)
        {


            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run text = new Run();

            var book = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            text.Text = book;
            text.Foreground = Brushes.DarkBlue;
            text.Background = Brushes.Yellow; 
            

            p.Inlines.Add(text);
            fd.Blocks.Add(p);
            rtbPride.Document = fd;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string path = @"‪C:\Users\brya1364\Downloads\SalesJan2009.csv";
            

            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads/SalesJan2009.csv";
            
            var lines = File.ReadAllLines(path);



            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];


                lstCSV.Items.Add(line);

                var pieces = line.Split(',');

                lstCSV.Items.Add(pieces[4] + "\t" + pieces[5]);
            }




            foreach (var line in lines)
            {

            }

            MessageBox.Show("Read it in successfully!");
        }
    }
}
