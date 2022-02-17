Public Class Persona

    Private _nombre As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _tipoIdentificacion As Integer
    Private _identificacion As String
    Private _fechaNacimiento As Date
    Private _estadoCivil As String
    Private _genero As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return _apellido1
        End Get
        Set(value As String)
            _apellido1 = value
        End Set
    End Property

    Public Property Apellido2 As String
        Get
            Return _apellido2
        End Get
        Set(value As String)
            _apellido2 = value
        End Set
    End Property

    Public Property TipoIdentificacion As Integer
        Get
            Return _tipoIdentificacion
        End Get
        Set(value As Integer)
            _tipoIdentificacion = value
        End Set
    End Property

    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property EstadoCivil As String
        Get
            Return _estadoCivil
        End Get
        Set(value As String)
            _estadoCivil = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property
End Class
