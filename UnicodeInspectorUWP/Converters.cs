using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UnicodeInspectorUWP
{
    public class StringToHexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string s = value as string;
            string hexCodes = "";

            foreach(char c in s)
            {
                int charint = (int)c;

                hexCodes += "\\u" + charint.ToString("X4");
            }
            return hexCodes;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return !((bool)value);
        }
    }

    public class StringToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string s = value as string;
            string intCodes = "";

            foreach (char c in s)
            {
                int charint = (int)c;

                intCodes += charint + " ";
            }
            return intCodes;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return !((bool)value);
        }
    }
}
