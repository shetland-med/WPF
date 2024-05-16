using Microsoft.Win32;
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
using System.Diagnostics; // 追加

namespace WpfApp1
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

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FileNameTextBox.Text = openFileDialog.FileName;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = FileNameTextBox.Text;
            if (!string.IsNullOrEmpty(fileName))
            {
                Debug.WriteLine("Selected File: " + fileName);
            }
            else
            {
                MessageBox.Show("Please select a file first.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
