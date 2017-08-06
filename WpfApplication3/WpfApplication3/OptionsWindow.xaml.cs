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
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true) App.Current.Properties["efekty"] = true;
            else App.Current.Properties["efekty"] = false;

            App.Current.Properties["kolorTla"] = comboBox.SelectedValue.ToString();

            SoundOnClick.PlaySound("button");
            Hide();
            Menu window = new Menu();
            window.Show();
        }
    }
}
