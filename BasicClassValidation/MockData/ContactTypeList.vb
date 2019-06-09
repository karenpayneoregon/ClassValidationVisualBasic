Imports BasicClassValidation.Classes
Namespace MockData
    ''' <summary>
    ''' Contact types are a mock for reading from a database then after
    ''' the mock read add a "Select" option to the top of the list for
    ''' use with a ComboBox.
    ''' </summary>
    Public Class ContactTypeList
        Public Function List() As List(Of ContactType)

            Dim contactItems =
                    (
                        From line In IO.File.ReadAllLines("ContactTypes.txt")
                        Where line.Length > 0
                        Let items = line.Split(","c)
                        Select New ContactType With {.ContactTypeIdentifier = CInt(items(0)), .ContactTitle = items(1)}
                    ).ToList

            contactItems.Insert(0, New ContactType() With {.ContactTypeIdentifier = 0, .ContactTitle = "Select"})

            Return contactItems
        End Function
    End Class
End Namespace