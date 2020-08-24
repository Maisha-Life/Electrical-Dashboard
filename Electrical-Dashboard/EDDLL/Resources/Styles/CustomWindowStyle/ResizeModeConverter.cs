using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfStyleableWindow.StyleableWindow
{
    class ResizeModeConverter : IValueConverter
    {
        // Summary:
        //     Modifies the source data before passing it to the target for display in the
        //     UI.
        //
        // Parameters:
        //   value:
        //     The source data being passed to the target.
        //
        //   targetType:
        //     The System.Type of data expected by the target dependency property.
        //
        //   parameter:
        //     An optional parameter to be used in the converter logic.
        //
        //   culture:
        //     The culture of the conversion.
        //
        // Returns:
        //     The value to be passed to the target dependency property.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var canResize = value.ToString();

            if (canResize == "NoResize")
                return Visibility.Collapsed;
            else
                return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var canResize = value.ToString();

            if (canResize == "NoResize")
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

    }
}
