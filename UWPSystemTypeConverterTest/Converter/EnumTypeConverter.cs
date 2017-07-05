using System;
using Windows.UI.Xaml.Data;

namespace UWPSystemTypeConverterTest.Converter
{
    internal class EnumTypeConverter : IValueConverter
    {
        public Type TypeToDisplay { get; set; }

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