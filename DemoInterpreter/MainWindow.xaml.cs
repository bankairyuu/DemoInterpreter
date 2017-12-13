using Microsoft.Win32;
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

namespace DemoInterpreter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool egtOpenSuccess = false;
        bool existingReduction = false;
        object reductionValue = null;
        GOLD_Logic.MyParserClass parser = new GOLD_Logic.MyParserClass();

        public MainWindow()
        {
            InitializeComponent();

            Button_RunReduction.IsEnabled = false;
            Button_ShowReductionTree.IsEnabled = false;
            TextBox_Input.IsEnabled = false;

            TextBox_Output.Text = "Open the grammar file to start your tasks...";
            TextBox_Output.IsReadOnly = true;
        }

        public void EventLogger(string p)
        {
            LeftFooterLabel.Content = p;
        }

        private void OpenGrammar_Click(object sender, RoutedEventArgs e)
        {
            egtOpenSuccess = false;
            Button_RunReduction.IsEnabled = false;
            Button_ShowReductionTree.IsEnabled = false;
            TextBox_Input.IsEnabled = false;

            EventLogger("Opening Grammar file...");
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Grammar files (.egt)|*.egt|All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = false
            };
            openFileDialog.ShowDialog();

            if (parser.Setup(openFileDialog.FileName))
            {
                LeftFooterLabel.Content = "Grammar file successfully opened";
                egtOpenSuccess = true;
                Button_RunReduction.IsEnabled = true;
                TextBox_Input.IsEnabled = true;
                TextBox_Output.Text = "";
                TextBox_Input.Text = "Add some instructions to reduction";
            }
            else
            {
                LeftFooterLabel.Content = "Error in opening of grammar file";
                egtOpenSuccess = false;
                Button_RunReduction.IsEnabled = false;
                Button_ShowReductionTree.IsEnabled = false;
                TextBox_Input.IsEnabled = false;
            }
        }

        private void RunReduction_Click(object sender, RoutedEventArgs e)
        {
            existingReduction = false;

            EventLogger("Starting reduction...");
            TextReader tr = new StringReader(TextBox_Input.Text);
            if (parser.Parse(tr))
            {
                EventLogger("Reduction successfully ended!");
                Button_ShowReductionTree.IsEnabled = true;

                reductionValue = new GOLD_Logic.Reduction().ReductionValue(parser.Root);
                ShowReductionValue();
            }
            else
            {
                EventLogger(parser.FailMessage);
            }
        }

        private void ShowReduction_Click(object sender, RoutedEventArgs e)
        {
            EventLogger("Showing reduction tree...");
            TextBox_Output.Text = parser.ShowReductionMap();
        }

        private void ShowReturnValue_Click(object sender, RoutedEventArgs e)
        {
            ShowReductionValue();
        }

        private void ShowReductionValue()
        {
            TextBox_Output.Text = reductionValue.ToString();
        }
    }
}
