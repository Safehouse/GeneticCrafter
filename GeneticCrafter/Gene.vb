Namespace ch.Morrolan.Minecraft.GeneticCrafter

    ''' <summary>
    ''' A class which represents a single Gene of a diploid creature, therefore consisting of two Alleles..
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Gene

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

        Public Property Allele1 As Byte

            Get
                Return _Allele1
            End Get

            Set(value As Byte)
                Select Case value
                    Case 0
                        _Allele1 = 0
                    Case 1
                        _Allele1 = 1
                    Case Else
                        Throw New ArgumentOutOfRangeException("Allele1", value, "Value needs to be either 0 or 1.")
                End Select
            End Set

        End Property
        Private _Allele1 As Byte

        Public Property Allele2 As Byte

            Get
                Return _Allele2
            End Get

            Set(value As Byte)
                Select Case value
                    Case 0
                        _Allele2 = 0
                    Case 1
                        _Allele2 = 1
                    Case Else
                        Throw New ArgumentOutOfRangeException("Allele2", value, "Value needs to be either 0 or 1")
                End Select
            End Set

        End Property
        Private _Allele2 As Byte

#End Region

#Region "Constructors"

        Public Sub New()

        End Sub

        Public Sub New(ByVal Name As String)

            _Name = Name

        End Sub

        Public Sub New(ByVal Allele1 As Byte, ByVal Allele2 As Byte)

            Me.Allele1 = Allele1
            Me.Allele2 = Allele2

        End Sub

        Public Sub New(ByVal Name As String, ByVal Allele1 As Byte, ByVal Allele2 As Byte)

            _Name = Name
            Me.Allele1 = Allele1
            Me.Allele2 = Allele2

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

            x.AppendLine("Gene")
            x.AppendLine("Name: " & _Name)
            x.AppendLine("Allele1: " & _Allele1.ToString)
            x.AppendLine("Allele2: " & _Allele2.ToString)

            Return x.ToString

        End Function

#End Region

    End Class

End Namespace