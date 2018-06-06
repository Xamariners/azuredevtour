using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace PhotoTour.Core.Converters
{
    public class AvatarConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value == null ? null : ImageSource.FromUri(new Uri($"https://ui-avatars.com/api/?rounded=true&background=005c90&color=fff&name=" + System.Web.HttpUtility.UrlEncode((string)value)));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
