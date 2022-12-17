<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650144/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T192318)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomColumnHeaderTemplate.xaml](./CS/WpfApplication48/CustomColumnHeaderTemplate.xaml) (VB: [CustomColumnHeaderTemplate.xaml](./VB/WpfApplication48/CustomColumnHeaderTemplate.xaml))
* [MainWindow.xaml](./CS/WpfApplication48/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication48/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication48/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication48/MainWindow.xaml.vb))
* [VerticalLineHelper.cs](./CS/WpfApplication48/VerticalLineHelper.cs) (VB: [VerticalLineHelper.vb](./VB/WpfApplication48/VerticalLineHelper.vb))
* [ViewModel.cs](./CS/WpfApplication48/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApplication48/ViewModel.vb))
<!-- default file list end -->
# How to draw custom separators for GridColumns and GridControlBands


<p>This example demonstrates how to draw custom separators for GridColumns and GridControlBands.</p>
<p>To accomplish this task, override GridColumnHeader's ControlTemplate and add an additional border. Then, create a custom class with two attached properties and two converters. In the first converter, return a new Thickness value. In the second converter, return a Boolean value depending on the incoming value type: true if it is GridColumn or GridControlBand, and false in other cases.  <br />After that, bind a border's BorderBrush and BorderThickness properties to these attached properties using the first converter for the BorderThickness property and add an additional DataTrigger to ControlTemplate to change the border visibility using the second converter.</p>

<br/>


