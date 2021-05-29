using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace lab8_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> logsIn = new List<string>();
        List<(string, string)> logsOut = new List<(string, string)>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void setProperties()
        {
            foreach (var elem in logsIn)
            {
                switch (elem.Split(':')[0])
                {
                    case "textBox":
                        textBox.Text = elem.Split(':')[1];
                        break;
                    case "checkBox1":
                        checkBox1.IsChecked = bool.Parse(elem.Split(':')[1]);
                        break;
                    case "checkBox2":
                        checkBox2.IsChecked = bool.Parse(elem.Split(':')[1]);
                        break;
                    case "Height":
                        this.Height = Int32.Parse(elem.Split(':')[1]);
                        break;
                    case "Width":
                            this.Width = Int32.Parse(elem.Split(':')[1]);
                        break;
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream(@"./logFile.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string str = "";

                    while ((str = sr.ReadLine()) != null)
                    {
                        logsIn.Add(str);
                    }
                }
            }

            setProperties();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            logsOut.Add((textBox.Name, textBox.Text));
            logsOut.Add((checkBox1.Name, checkBox1.IsChecked.ToString()));
            logsOut.Add((checkBox2.Name, checkBox2.IsChecked.ToString()));
            logsOut.Add(("Height", this.Height.ToString()));
            logsOut.Add(("Width", this.Width.ToString()));

            using (FileStream fs = new FileStream(@"./logFile.txt", FileMode.Open))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var elem in logsOut)
                    {
                        sw.WriteLine($"{elem.Item1}: {elem.Item2}");
                    }
                }
            }
        }
    }
}
