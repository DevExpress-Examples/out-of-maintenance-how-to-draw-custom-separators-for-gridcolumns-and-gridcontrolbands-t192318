# How to draw custom separators for GridColumns and GridControlBands


<p>This example demonstrates how to draw custom separators for GridColumns and GridControlBands.</p>
<p>To accomplish this task, override GridColumnHeader's ControlTemplate and add an additional border. Then, create a custom class with two attached properties and two converters. In the first converter, return a new Thickness value. In the second converter, return a Boolean value depending on the incoming value type: true if it is GridColumn or GridControlBand, and false in other cases.  <br />After that, bind a border's BorderBrush and BorderThickness properties to these attached properties using the first converter for the BorderThickness property and add an additional DataTrigger to ControlTemplate to change the border visibility using the second converter.</p>

<br/>


