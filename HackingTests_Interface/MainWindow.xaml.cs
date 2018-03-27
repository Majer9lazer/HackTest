using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Microsoft.Win32;

namespace HackingTests_Interface
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

        private string _executionFileName;
        private string _testFileName;
        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog injectorFileDialog = new OpenFileDialog
            {
                Title = "Выберите файл",
                Filter = "exe файлы|*.exe"
            };
            bool? showDialog = injectorFileDialog.ShowDialog();
            if (showDialog != null && (bool)showDialog)
            {
                _executionFileName = injectorFileDialog.FileName;
                MessageTextBlock.Text += "1) Инжекторный файл был успешно добавлен!\n";
            }
        }

        private void SearchFile_OnClick(object sender, RoutedEventArgs e)
        {
            switch (string.IsNullOrEmpty(_executionFileName) && string.IsNullOrEmpty(_testFileName))
            {
                case false:
                    {
                        try
                        {
                            StartHacking(_executionFileName, _testFileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorOrSuccesTextBlock.Text += ex;
                        }
                        break;
                    }
            }
        }


        private void StartHacking(string injectionFilename, string sourceFileName)
        {
            ProcessStartInfo process = new ProcessStartInfo(injectionFilename)
            { Arguments = sourceFileName };
            Process s = Process.Start(process);
            Console.WriteLine(s != null && s.Start());
        }
        private void SourceMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog sourceDialog = new OpenFileDialog()
            {
                Title = "Выберите файл",
                Filter = "Файлы формата mtx|*.mtx"
            };
            bool? showDialog = sourceDialog.ShowDialog();
            if (showDialog != null && (bool)showDialog)
            {
                _testFileName = sourceDialog.FileName;
                MessageTextBlock.Text += "2) Исходный файл был успешно добавлен!";
            }
        }
    }
}
