using Parser.Main;
using Parser.Main.Habr;
using System.Windows;

namespace Parser
{
    public partial class MainWindow : Window
    {
        ParserWorker<string[]> parser;

        public MainWindow()
        {
            InitializeComponent();
            //parser = new ParserWorker<string[]>(new Main.Habr.Parser());
            parser = new ParserWorker<string[]>(new ParserRozetka());
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
            //parser.ParserSettings = new Settings(this.startPage.Value ?? default(int), this.endPage.Value ?? default(int));
            parser.ParserSettings = new RozetkaSettings(this.startPage.Value ?? default(int), this.endPage.Value ?? default(int));
            parser.Start();
        }

        private void buttonAbort_Click(object sender, RoutedEventArgs e)
        {
            parser.Abort();
        }
    }
}
