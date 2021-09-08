Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace ViewModel


    Public Class MainWindowViewModel
        Implements INotifyPropertyChanged

#Region "INotifyPropertyChanged"

        ''' <summary>
        ''' PropertyChanged Event implements the <see cref="INotifyPropertyChanged"/> Interface
        ''' </summary>
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        ''' <summary>
        ''' OnPropertyChanged raise the <see cref="INotifyPropertyChanged.PropertyChanged"/> event for the Property specified by the propertyName parameters
        ''' </summary>
        ''' <param name="propertyName">Name of the Property</param>
        Protected Sub OnPropertyChanged(<CallerMemberNameAttribute> Optional propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#End Region

#Region "Private variables"

        Private _title As String

#End Region

        Public Property MainTitle As String
            Get
                Return _title
            End Get
            Set(value As String)
                _title = value
                OnPropertyChanged()
            End Set
        End Property


        Public Property LibrariesList As New ObservableCollection(Of LibItem) From {
            New LibItem("CommonServiceLocator", "2.0.6.0"), New LibItem("GalaSoftMvvmLight", "5.4.1.0"), New LibItem("GalaSoftMvvmLight.Extras", "5.4.1.0"), New LibItem("GalaSoftMvvmLight.Platform", "5.4.1.0"),
            New LibItem("GalaSoftMvvmLight.Extras", "5.4.1.0"), New LibItem("GalaSoftMvvmLight.Platform", "5.4.1.0")
        }

        Public ReadOnly Property ShowWindow As New SimpleCommand(
          Async Sub()
              Dim view As New AboutWindow
              Await MaterialDesignThemes.Wpf.DialogHost.Show(view)
          End Sub)


        Public Sub New()

            MainTitle = "DataGrid Example"

        End Sub

    End Class

End Namespace

