using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Drawing;
using System.Media;
using Microsoft.Win32;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Memo : Window
    {
        private static int LICZBA_WIERSZY { get; set; }
        private static int LICZBA_KOLUMN { get; set; }
        private string TrybGry { get; set; }
        private string imiePierwszegoGracza { get; set; }
        private string imieDrugiegoGracza { get; set; }
        private int firstElementName { get; set; }
        private int secondElementName { get; set; }
        private int numberOfTries { get; set; }
        private int numberOfPairs { get; set; }
        private int numberOfTriesDrugiegoGracza { get; set; }
        private int numberOfPairsDrugiegoGracza { get; set; }
        private int time { get; set; }
        private int time2 { get; set; }
        private int tura { get; set; }
        private int checkedFields { get; set; }

        private Button[] buttons;
        private DispatcherTimer timer;
        private DispatcherTimer timer2;
        private List<Image> images;
        private Image firstElementImage;
        private Image secondElementImage;

        public Memo(int LICZBA_WIERSZY, int LICZBA_KOLUMN, string TrybGry, string imiePierwszegoGracza, string imieDrugiegoGracza)
        {
            timer = new DispatcherTimer();
            timer2 = new DispatcherTimer();
            checkedFields = 0;
            firstElementImage = new Image();
            secondElementImage = new Image();
            firstElementName = 0;
            secondElementName = 0;
            numberOfTries = 0;
            numberOfPairs = 0;
            numberOfTriesDrugiegoGracza = 0;
            numberOfPairsDrugiegoGracza = 0;
            time = 0;
            time2 = 0;
            tura = 1;
            
            Memo.LICZBA_WIERSZY = LICZBA_WIERSZY;
            Memo.LICZBA_KOLUMN = LICZBA_KOLUMN;
            this.imiePierwszegoGracza = imiePierwszegoGracza;
            this.imieDrugiegoGracza = imieDrugiegoGracza;
            buttons = new Button[LICZBA_KOLUMN * LICZBA_WIERSZY];
            images = new List<Image>(LICZBA_WIERSZY * LICZBA_KOLUMN);
            this.TrybGry = TrybGry;
            InitializeComponent();
            BackgroundColor.setSelectedBackground();
            this.Background = (Brush)App.Current.Properties["kolorTlaBrushes"];
            ImiePierwszegoGracza.Content = this.imiePierwszegoGracza;
            ImieDrugiegoGracza.Content = this.imieDrugiegoGracza;
            Czas.Background = Brushes.Green;
            Ruchy.Background = Brushes.Green;
            RuchyDrugiegoGracza.Background = Brushes.Red;
            CzasDrugiegoGracza.Background = Brushes.Red;
            if (TrybGry == "Jeden Gracz")
            {
                CzasDrugiegoGracza.Visibility = Visibility.Hidden;
                RuchyDrugiegoGracza.Visibility = Visibility.Hidden;
                CzasLabelDrugiegoGracza.Visibility = Visibility.Hidden;
                RuchyLabelDrugiegoGracza.Visibility = Visibility.Hidden;
                ImieDrugiegoGracza.Visibility = Visibility.Hidden;
                RuchyLabel.Content = "Liczba prób";
            }
            this.FillArrayWithIcons();
            this.ShuffleImages();
            Ruchy.Text = ""+ 0;
            int button_counter = 0;
            for(int i = 0; i < LICZBA_KOLUMN; i++)
            {
                for(int j = 0; j < LICZBA_WIERSZY; j++)
                {
                    buttons[button_counter] = new Button();
                    buttons[button_counter].Name = "button" + button_counter;
                    buttons[button_counter].Click += sprawdz;
                    Przyciski.Children.Add(buttons[button_counter]);
                    Grid.SetRow(buttons[button_counter], j);
                    Grid.SetColumn(buttons[button_counter], i);
                    button_counter++;
                }
            }
            timer.Tick += new EventHandler(timer_tick);
            timer2.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer2.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        public void FillArrayWithIcons()
        {
            string[] options = new string[20] { "Apple", "Avocado", "Banan", "Banana", "Carrot", "Cherry", "Chili", "Coconut", "Drink", "Grape", "Grapes", "Grenade", "Kiwi", "Lemon", "Mango", "Peach", "Pear", "Pepper", "Pineapple", "Plum"};
            for(int i = 0; i < LICZBA_WIERSZY * LICZBA_KOLUMN / 2; i++)
            {
                Image first_element_of_pair = new Image();
                first_element_of_pair.Source = new BitmapImage(new Uri("Pictures/" + options[i] + ".png", UriKind.Relative));
                images.Add(first_element_of_pair);
                Image second_element_of_pair = new Image();
                second_element_of_pair.Source = new BitmapImage(new Uri("Pictures/" + options[i] + ".png", UriKind.Relative));
                images.Add(second_element_of_pair);

            }
        }

        public void ShuffleImages()
        {
            Random rand = new Random();
            images = images.OrderBy(c => rand.Next()).ToList();
        }

        private string convert_time(int time)
        {
            int minutes, hours, seconds;
            string minutesString, hoursString, secondsString;
            hours = time / 3600;
            minutes = time / 60 - hours * 60;
            seconds = time - minutes * 60 - hours * 3600;
            secondsString = (seconds < 10) ? "0" + seconds : "" + seconds;
            minutesString = (minutes < 10) ? "0" + minutes : "" + minutes;
            hoursString = (hours < 10) ? "0" + hours : "" + hours;
            String output = hoursString + ":" + minutesString + ":" + secondsString;
            return output;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (sender.Equals(timer))
            {
                time++;
                Czas.Text = convert_time(this.time);
            }
            if (sender.Equals(timer2))
            {
                time2++;
                CzasDrugiegoGracza.Text = convert_time(this.time2);
            }
        }

        private void sprawdz(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (checkedFields == 0)
            {
                clickedButton.Content = images.ElementAt(Int32.Parse(clickedButton.Name.Substring(6)));
                firstElementImage = images.ElementAt(Int32.Parse(clickedButton.Name.Substring(6)));
                firstElementName = Int32.Parse(clickedButton.Name.Substring(6));
                checkedFields++;
                clickedButton.IsEnabled = false;
            }
            else if (checkedFields == 1)
            {
                clickedButton.Content = images.ElementAt(Int32.Parse(clickedButton.Name.Substring(6)));
                secondElementImage = images.ElementAt(Int32.Parse(clickedButton.Name.Substring(6)));
                secondElementName = Int32.Parse(clickedButton.Name.Substring(6));
                if (firstElementImage.Source.ToString().Contains(secondElementImage.Source.ToString()) == true && firstElementName != secondElementName)
                {
                    SoundOnClick.PlaySound("yes");
                }
                else
                {
                    SoundOnClick.PlaySound("no");
                }
                    checkedFields++;
                foreach (Button b in buttons)
                {
                    b.IsEnabled = false;
                    b.Focus();
                }
                timer.Stop();
                timer2.Stop();
                Ruchy.Background = Brushes.Red;
                Czas.Background = Brushes.Red;
                RuchyDrugiegoGracza.Background = Brushes.Red;
                CzasDrugiegoGracza.Background = Brushes.Red;
            }
                       
                       
        }

        private void Window_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           if (checkedFields == 2)
            {
                foreach (Button b in buttons)
                {
                    b.IsEnabled = true;
                }
                if(TrybGry == "Jeden Gracz")
                {
                    timer.Start();
                    Czas.Background = Brushes.Green;
                    Ruchy.Background = Brushes.Green;
                }
                if (TrybGry == "Dwóch Graczy")
                {
                    if (tura % 2 != 0)
                    {
                        timer2.Start();
                        Ruchy.Background = Brushes.Red;
                        Czas.Background = Brushes.Red;
                        RuchyDrugiegoGracza.Background = Brushes.Green;
                        CzasDrugiegoGracza.Background = Brushes.Green;
                    }
                    if (tura % 2 == 0)
                    {
                        timer.Start();
                        Ruchy.Background = Brushes.Green;
                        Czas.Background = Brushes.Green;
                        RuchyDrugiegoGracza.Background = Brushes.Red;
                        CzasDrugiegoGracza.Background = Brushes.Red;
                    }
                }
                checkedFields = 0;
                if (firstElementImage.Source.ToString().Equals(secondElementImage.Source.ToString()) && firstElementName != secondElementName)
                {
                    buttons[firstElementName].Visibility = Visibility.Hidden;
                    buttons[secondElementName].Visibility = Visibility.Hidden;
                    if (TrybGry == "Dwóch Graczy")
                    {
                        if (tura % 2 != 0)
                            numberOfPairs++;
                        else numberOfPairsDrugiegoGracza++;
                    }
                    else numberOfPairs++;
                }
                else
                {

                    buttons[firstElementName].Content = "";
                    buttons[secondElementName].Content = "";
                    buttons[firstElementName].IsEnabled = true;

                }
                if (TrybGry == "Dwóch Graczy")
                {
                    if (tura % 2 != 0)
                        numberOfTries++;
                    else numberOfTriesDrugiegoGracza++;
                    Ruchy.Text = "" + numberOfPairs;
                    RuchyDrugiegoGracza.Text = "" + numberOfPairsDrugiegoGracza;
                    tura++;
                }
                if (TrybGry == "Jeden Gracz")
                {
                    numberOfTries++;
                    Ruchy.Text = "" + numberOfTries;
                }
                if (numberOfPairs + numberOfPairsDrugiegoGracza == LICZBA_KOLUMN * LICZBA_WIERSZY / 2)
                {
                    timer.Stop();
                    timer2.Stop();
                    string komunikat = "";
                    if (TrybGry == "Jeden Gracz") komunikat = imiePierwszegoGracza + "! Udało ci się ukończyć grę w czasie " + Czas.Text + " przy " + numberOfTries + " ruchach. Czy chcesz zagrać ponownie?";
                    if (TrybGry == "Dwóch Graczy")
                    {
                        string zwyciezca;
                        if (numberOfPairs > numberOfPairsDrugiegoGracza) zwyciezca = imiePierwszegoGracza;
                        else if (numberOfPairs < numberOfPairsDrugiegoGracza) zwyciezca = imieDrugiegoGracza;
                        else
                        {
                            if (time < time2) zwyciezca = imiePierwszegoGracza;
                            else if (time > time2) zwyciezca = imieDrugiegoGracza;
                            else zwyciezca = "Remis";
                        }
                        komunikat = imiePierwszegoGracza + " zdobył " + numberOfPairs + " par w czasie " + Czas.Text + "\n" + imieDrugiegoGracza + " zdobył " + numberOfPairsDrugiegoGracza + " par w czasie " + CzasDrugiegoGracza.Text + "\nZwycięzcą rozgrywki jest " + zwyciezca + "\nPowtórzyć gre?";
                    }
                    MessageBoxResult result = MessageBox.Show(komunikat, "Koniec gry", MessageBoxButton.YesNo, MessageBoxImage.Question);


                    if (result == MessageBoxResult.Yes)
                    {
                        foreach (Button b in buttons)
                        {
                            b.Visibility = Visibility.Visible;
                            b.Content = "";
                            b.IsEnabled = true;
                        }
                        this.ShuffleImages();
                        CzasDrugiegoGracza.Text = "00:00:00";
                        Ruchy.Text = "" + 0;
                        RuchyDrugiegoGracza.Text = "" + 0;
                        this.time2 = 0;
                        this.time = 0;
                        numberOfPairsDrugiegoGracza = 0;
                        numberOfTriesDrugiegoGracza = 0;
                        numberOfPairs = 0;
                        numberOfTries = 0;
                        timer.Start();

                    }
                    if (result == MessageBoxResult.No)
                    {
                        Hide();
                        Menu window = new Menu();
                        window.Show();
                    }

                }
            }
        }
    }
}
