//Muzyka_Milena_PD-22
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace test_wpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            foreach (UIElement el in mainRoot.Children) {
                if(el is Button)
                    (el as Button).Click += button_Click;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
                textBox.Text = "";
            else if(str == "=") {
                string value = new DataTable().Compute(textBox.Text, null).ToString();
                textBox.Text = value;
            }
            else
                textBox.Text += str;
        }
    }
}