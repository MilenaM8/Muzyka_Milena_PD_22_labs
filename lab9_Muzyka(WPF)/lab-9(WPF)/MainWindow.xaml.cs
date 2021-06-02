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

namespace lab_9_WPF_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            fileDialog.DefaultExt = ".txt";
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            var result = fileDialog.ShowDialog();

            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    TxtFile.Content = file;

                    using (FileStream fs = new FileStream(fileDialog.FileName, FileMode.Open))
                    {
                        using (TextReader sr = new StreamReader(fs, Encoding.Default))
                        {
                            try
                            {
                                if (decryptRadio.IsChecked == true)
                                {
                                    textArea.Text = CaesarCipher.Decrypt(sr.ReadToEnd(), Int32.Parse(slideValue.Text));
                                }
                                else
                                {
                                    textArea.Text = CaesarCipher.Encrypt(sr.ReadToEnd(), Int32.Parse(slideValue.Text));
                                }
                            }
                            catch 
                            {
                                MessageBox.Show("Проверь все ли поля заполнени", "Ейй");
                            }
                        }
                    }
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    TxtFile.Content = "";
                    break;
            }
        }
    }
}
