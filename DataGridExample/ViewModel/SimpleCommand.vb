Namespace ViewModel

    Public Class SimpleCommand
        Implements ICommand

        Private _execute As Action(Of Object)
        Private _canExecute As Predicate(Of Object)

        Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

        Public Sub New(exec As Action(Of Object))
            _execute = exec
        End Sub


        Public Sub Execute(parameter As Object) Implements ICommand.Execute
            _execute(parameter)
        End Sub

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return True
        End Function

        Private Shared Function DefaultCanExecute(ByVal param As Object) As Boolean
            Return True
        End Function

    End Class

End Namespace

