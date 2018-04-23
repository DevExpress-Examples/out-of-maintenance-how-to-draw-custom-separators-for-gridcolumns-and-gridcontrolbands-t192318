Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WpfApplication48
	Public Class ViewModel

		Private _List As ObservableCollection(Of Task)
		Public ReadOnly Property List() As ObservableCollection(Of Task)
			Get
				_List = New ObservableCollection(Of Task)()
				For i As Integer = 0 To 19
					_List.Add(New Task() With {.Name = "Task " & i, .FirstValue = i, .SecondValue = i * i, .IsCompleted = i Mod 2 <> 0})
				Next i
				Return _List
			End Get
		End Property

		Public Class Task
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property
			Private privateFirstValue As Integer
			Public Property FirstValue() As Integer
				Get
					Return privateFirstValue
				End Get
				Set(ByVal value As Integer)
					privateFirstValue = value
				End Set
			End Property
			Private privateSecondValue As Integer
			Public Property SecondValue() As Integer
				Get
					Return privateSecondValue
				End Get
				Set(ByVal value As Integer)
					privateSecondValue = value
				End Set
			End Property
			Private privateIsCompleted As Boolean
			Public Property IsCompleted() As Boolean
				Get
					Return privateIsCompleted
				End Get
				Set(ByVal value As Boolean)
					privateIsCompleted = value
				End Set
			End Property
		End Class
	End Class
End Namespace
