Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Media

Namespace WpfApplication48
	Public Class VerticalLineHelper
		Public Shared Function GetLineThickness(ByVal obj As DependencyObject) As Double
			Return DirectCast(obj.GetValue(LineThicknessProperty), Double)
		End Function
		Public Shared Sub SetLineThickness(ByVal obj As DependencyObject, ByVal value As Double)
			obj.SetValue(LineThicknessProperty, value)
		End Sub
		Public Shared Function GetLineColor(ByVal obj As DependencyObject) As Brush
			Return DirectCast(obj.GetValue(LineColorProperty), Brush)
		End Function
		Public Shared Sub SetLineColor(ByVal obj As DependencyObject, ByVal value As Brush)
			obj.SetValue(LineColorProperty, value)
		End Sub
		Public Shared ReadOnly LineThicknessProperty As DependencyProperty = DependencyProperty.RegisterAttached("LineThickness", GetType(Double), GetType(VerticalLineHelper), New PropertyMetadata(0.0))
		Public Shared ReadOnly LineColorProperty As DependencyProperty = DependencyProperty.RegisterAttached("LineColor", GetType(Brush), GetType(VerticalLineHelper), New PropertyMetadata(Brushes.Black))
	End Class

	Public Class VerticalLineThicknessConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return New Thickness(0, 0, DirectCast(value, Double), 0)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class

	Public Class VerticalLineVisibilityConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return (value IsNot Nothing) AndAlso (TypeOf value Is GridColumn OrElse TypeOf value Is GridControlBand)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class


End Namespace
