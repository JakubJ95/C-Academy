using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Media;

namespace WpfApplication3
{
    class BackgroundColor
    {
        public static void setSelectedBackground()
        {
            System.Diagnostics.Debug.WriteLine((string)App.Current.Properties["kolorTla"]);
            if ((string)App.Current.Properties["kolorTla"] == "Biały") App.Current.Properties["kolorTlaBruses"] = Brushes.White;
            if ((string)App.Current.Properties["kolorTla"] == "Żółty") App.Current.Properties["kolorTlaBrushes"] = Brushes.Yellow;
            if ((string)App.Current.Properties["kolorTla"] == "Niebieski") App.Current.Properties["kolorTlaBrushes"] = Brushes.Blue;
            if ((string)App.Current.Properties["kolorTla"] == "Zielony") App.Current.Properties["kolorTlaBrushes"] = Brushes.Green;
            if ((string)App.Current.Properties["kolorTla"] == "Różowy") App.Current.Properties["kolorTlaBrushes"] = Brushes.Violet;
        }
    }
    
}
