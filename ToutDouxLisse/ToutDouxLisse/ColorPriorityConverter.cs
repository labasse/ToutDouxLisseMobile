using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ToutDouxLisse
{

    public class ColorPriorityConverter : IValueConverter
    { 
        public Color High { get; set; }
        public Color Medium { get; set; }
        public Color Low { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           switch((int)value)
            {
                case 0: case 1: case 2: return High;
                case 3: case 4: return Medium;
                default: return Low;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
