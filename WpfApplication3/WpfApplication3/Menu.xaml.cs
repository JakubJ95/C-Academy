using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
           // App.Current.Properties["efekty"] = true;
            ImageBrush i = new ImageBrush();
            i.ImageSource = new BitmapImage(new Uri("pack://application:,,,/WpfApplication3;component/Pictures/memory.jpg", UriKind.Absolute));
            this.Background = i;
            InitializeComponent();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            SoundOnClick.PlaySound("button");
            Close();
        }

        private void oneplayer_Click(object sender, RoutedEventArgs e)
        {
            SoundOnClick.PlaySound("button");
            Hide();
            DifficultyLevelWindow window = new DifficultyLevelWindow("Jeden Gracz");
            window.Show();
        }

        private void twoplayers_Click(object sender, RoutedEventArgs e)
        {
            SoundOnClick.PlaySound("button");
            Hide();
            DifficultyLevelWindow window = new DifficultyLevelWindow("Dwóch Graczy");
            window.Show();
        }

        private void options_Click(object sender, RoutedEventArgs e)
        {
            SoundOnClick.PlaySound("button");
            Hide();
            OptionsWindow window = new OptionsWindow();
            window.Show();
        }
    }
}
