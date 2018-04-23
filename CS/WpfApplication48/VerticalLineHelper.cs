using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication48
{
    public class VerticalLineHelper
    {
        public static double GetLineThickness(DependencyObject obj)
        {
            return (double)obj.GetValue(LineThicknessProperty);
        }
        public static void SetLineThickness(DependencyObject obj, double value)
        {
            obj.SetValue(LineThicknessProperty, value);
        }
        public static Brush GetLineColor(DependencyObject obj)
        {
            return (Brush)obj.GetValue(LineColorProperty);
        }
        public static void SetLineColor(DependencyObject obj, Brush value)
        {
            obj.SetValue(LineColorProperty, value);
        }
        public static readonly DependencyProperty LineThicknessProperty =
            DependencyProperty.RegisterAttached("LineThickness", typeof(double), typeof(VerticalLineHelper), new PropertyMetadata(0.0));
        public static readonly DependencyProperty LineColorProperty =
            DependencyProperty.RegisterAttached("LineColor", typeof(Brush), typeof(VerticalLineHelper), new PropertyMetadata(Brushes.Black));
    }

    public class VerticalLineThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return new Thickness(0, 0, (double)value, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class VerticalLineVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value != null) && (value is GridColumn || value is GridControlBand);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
