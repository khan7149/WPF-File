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

namespace Wpf_File
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string book;
        private string path;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run text = new Run();
            File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            text.Text = book;


            p.Inlines.Add(text);
            fd.Blocks.Add(p);
            rbtPride.Document = fd;
        }

        private void BtnPride_Copy_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\SalesJan2009.csv";

            var lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                1stCSV.item.Add(line);
            }
            //Splits CSV file on commas
            var pieces = line.Split(',');

            1stCSV.Items.Add(pieces[4] + "\t" + pieces[5]);


            //foreach (var item in collection)
            //{
            //    1stCSV.item.Add(line);
            //}

            //MessageBox
        }
    }
}
