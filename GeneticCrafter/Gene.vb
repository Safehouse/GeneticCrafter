Namespace ch.Morrolan.Minecraft.GeneticCrafter

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

        Private Property byte1 As Byte

            Get
                Return _byte1
            End Get

            Set(value As Byte)
                _byte1 = value
            End Set

        End Property
        Private _byte1 As Byte

        Private Property byte2 As Byte

            Get
                Return _byte2
            End Get

            Set(value As Byte)
                _byte2 = value
            End Set

        End Property
        Private _byte2 As Byte

#End Region

    End Class

End Namespace