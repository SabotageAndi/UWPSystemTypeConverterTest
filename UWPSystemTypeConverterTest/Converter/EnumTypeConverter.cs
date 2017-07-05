using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPSystemTypeConverterTest.Converter
{
    class EnumTypeConverter : IValueConverter
    {
        public Type TypeToDisplay { get; set; }

        public EnumTypeConverter()
        {
            System.Diagnostics.Debug.Write("");
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return TypeToDisplay?.FullName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
