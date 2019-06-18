﻿Namespace My
    Partial Friend Class MyApplication
        ''' <summary>
        ''' Determines if the a form is open
        ''' </summary>
        ''' <param name="sender">Name of form</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsFormOpen(sender As String) As Boolean
            Return ((From f In Application.OpenForms.Cast(Of Form)() Where f.Name.Equals(sender) Select f.Name).ToList.Count > 0)
        End Function
    End Class
End Namespace


