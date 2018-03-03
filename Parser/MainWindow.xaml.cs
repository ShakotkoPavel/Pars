using Parser.Main;
using Parser.Main.Habr;
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

namespace Parser
{
    public partial class MainWindow : Window
    {
        ParserWorker<string[]> parser;

        public MainWindow()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new Main.Habr.Parser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            foreach (var item in arg2)
            {
                listBox.Items.Add(item);
            }
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Completed!");
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            parser.ParserSettings = new Settings(this.myUpDownControl1.Value ?? default(int), this.myUpDownControl2.Value ?? default(int));
            parser.Start();
        }

        private void buttonAbort_Click(object sender, RoutedEventArgs e)
        {
            parser.Abort();
        }
    }
}
