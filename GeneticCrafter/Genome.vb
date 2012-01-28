Namespace ch.Morrolan.Minecraft.GeneticCrafter

    ''' <summary>
    ''' A class which represents the whole genome of a being. Offers methods to add and remove single genes.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Genome

#Region "Properties"

        Public ReadOnly Property ListOfGenes As List(Of Gene)

            Get
                Return _ListOfGenes
            End Get

        End Property
        Private _ListOfGenes As List(Of Gene)

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
            InitializeObjects()
        End Sub

        Public Sub New(ByVal _Name As String)

            InitializeObjects()
            _Name = Name

        End Sub

#End Region

#Region "Initialization"

        Private Sub InitializeObjects()

            _ListOfGenes = New List(Of Gene)

        End Sub

#End Region

#Region "Gene management"

        ''' <summary>
        ''' Returns the gene with the specified name.
        ''' </summary>
        ''' <param name="Name">The name of the gene to return.</param>
        ''' <returns>Gene with the specified name.</returns>
        ''' <remarks></remarks>
        Public Function GetGene(ByVal Name As String) As Gene

            For Each x As Gene In _ListOfGenes
                If x.Name = Name Then
                    Return x
                End If
            Next

            ' If the function arrives here no gene with the specified name has been found, therefore it'll throw an exception.
            Throw New Exception("No Gene with such a name found")

        End Function


        ''' <summary>
        ''' Adds the given gene to the list of genes of the genome.
        ''' </summary>
        ''' <param name="Gene">The gene to add.</param>
        ''' <remarks></remarks>
        Public Sub AddGene(ByVal Gene As Gene)

            _ListOfGenes.Add(Gene)

        End Sub


        ''' <summary>
        ''' Removes every gene with the specified name and returns the amount of genes which were removed.
        ''' </summary>
        ''' <param name="Name">The name of the genes which should be deleted.</param>
        ''' <returns>Amount of removed genes.</returns>
        ''' <remarks></remarks>
        Public Overloads Function RemoveGene(ByVal Name As String) As Integer

            Dim Affected As Integer = 0

            For Each x As Gene In _ListOfGenes
                If x.Name = Name Then
                    _ListOfGenes.Remove(x)
                    Affected += 1
                End If
            Next

            Return Affected

        End Function

        ''' <summary>
        ''' Removes the specified gene.
        ''' </summary>
        ''' <param name="Gene">The gene to remove.</param>
        ''' <remarks></remarks>
        Public Overloads Sub RemoveGene(ByVal Gene As Gene)

            If _ListOfGenes.Contains(Gene) = False Then
                Throw New Exception("No such gene was found inside the list of genes of the genome.")
            End If

            ' Provided the list contains the gene which ought to get removed it gets actually removed now.
            _ListOfGenes.Remove(Gene)

        End Sub

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
            x.AppendLine("Genes:")

            For Each y As Gene In _ListOfGenes
                x.AppendLine(y.ToString)
            Next

            Return x.ToString

        End Function

#End Region

    End Class

End Namespace

