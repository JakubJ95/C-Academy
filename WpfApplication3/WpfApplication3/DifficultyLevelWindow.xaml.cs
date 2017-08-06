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
    /// Interaction logic for DifficultyLevelWindow.xaml
    /// </summary>
    public partial class DifficultyLevelWindow : Window
    {
        string TrybGry = "";
        public DifficultyLevelWindow(string tryb)
        {
            InitializeComponent();
            this.TrybGry = tryb;
            if(TrybGry == "Jeden Gracz")
            {
                play.Width = 170;
                tekstDrugiegoGracza.Visibility = Visibility.Hidden;
                imieDrugiegoGracza.Visibility = Visibility.Hidden;
                tekstPierwszegoGracza.Text = "Wpisz swoje imie";
            }
        }

        public bool DifficultyLevelIsSelected()
        {
            if (latwy.IsChecked == false && trudny.IsChecked == false) return false;
            else return true;
        }

        public bool NameIsGiven(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            else return true;
        }

        public bool NameIsTooLong(string name)
        {
            if (name.Length > 10) return true;
            else return false;
        }

        public bool AllDataIsSet(string name, TextBox t)
        {
            System.Diagnostics.Debug.WriteLine(NameIsGiven(name));
            if (DifficultyLevelIsSelected() && !NameIsTooLong(name) && NameIsGiven(name)) return true;
            else
            {
                if (!DifficultyLevelIsSelected() && !NameIsGiven(name)) t.Text = "Wybierz któryś z poziomów trudności i wpisz swoje imie!";
                if (!DifficultyLevelIsSelected() && NameIsTooLong(name)) t.Text = "Wybierz któryś z poziomów trudności. Podane przez Ciebie imie jest za długie! (max 10 znaków)";
                if (DifficultyLevelIsSelected() && !NameIsGiven(name)) t.Text = "Wpisz swoje imie!";
                if (!DifficultyLevelIsSelected() && NameIsGiven(name) && !NameIsTooLong(name)) t.Text = "Wybierz któryś z poziomów trudności";
                if (DifficultyLevelIsSelected() && NameIsTooLong(name) && NameIsGiven(name)) t.Text = "Podane przez Ciebie imie jest za długie! (max 10 znaków)";
                return false;
            }
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            warning.Text = "";
            warningGraczaDrugiego.Text = "";
            bool EverythingIsReady = false;
            if (TrybGry == "Jeden Gracz") EverythingIsReady = AllDataIsSet(imie.Text, warning);
            if (TrybGry == "Dwóch Graczy")
            {
                bool gracz1 = AllDataIsSet(imie.Text, warning);
                bool gracz2 = AllDataIsSet(imieDrugiegoGracza.Text, warningGraczaDrugiego);
                EverythingIsReady = gracz1 == true && gracz2 == true;
            }
            if (EverythingIsReady)
            {
                SoundOnClick.PlaySound("button");
                if (latwy.IsChecked == true)
                {
                    Hide();
                    Memo window = null;
                    if (TrybGry == "Jeden Gracz") window = new Memo(4,5, TrybGry, imie.Text, null);
                    if (TrybGry == "Dwóch Graczy") window = new Memo(4, 5, TrybGry, imie.Text, imieDrugiegoGracza.Text);
                    window.Show();
                }
                if (trudny.IsChecked == true)
                {
                    Hide();
                    Memo window2 = null;
                    if (TrybGry == "Jeden Gracz") window2 = new Memo(4, 10, TrybGry, imie.Text, null);
                    if (TrybGry == "Dwóch Graczy") window2 = new Memo(4, 10, TrybGry, imie.Text, imieDrugiegoGracza.Text);
                    window2.Show();
                }
            }
        }
    }
}
