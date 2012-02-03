Namespace ch.Morrolan.Minecraft.GeneticCrafter

    ''' <summary>
    ''' A class which represents the whole genome of a being. Offers methods to add and remove single genes.
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class Genome

#Region "Properties"

        Public Property Name As String

            Get
                Return _Name
            End Get

            Set(value As String)
                _Name = value
            End Set

        End Property
        Private _Name As String

#End Region

#Region "Constructors"

        ''' <summary>
        ''' Creates a new instance of the Genome class.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
        End Sub

        Public Sub New(ByVal _Name As String)

            _Name = Name

        End Sub

#End Region

#Region "Initialization"

#End Region

#Region "Overrides"

        ''' <summary>
        ''' Returns a representation of the object as a string.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overrides Function ToString() As String

            Dim x As New System.Text.StringBuilder

            x.AppendLine("Genome")
            x.AppendLine("Name: " & _Name)

            Return x.ToString

        End Function

#End Region

    End Class

End Namespace

