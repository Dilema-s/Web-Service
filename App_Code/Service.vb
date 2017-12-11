Imports System.Data
Imports System.Data.SqlClient

Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports Negocio_logica

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function altaPersona(ByVal nombreApellido As String, ByVal fechaNacimiento As DateTime, ByVal edad As Integer, ByVal sexo As Integer) As Boolean

        Dim Persona As Persona = New Persona(nombreApellido, fechaNacimiento, edad, sexo, 0)
        If Persona.altaPersona() Then
            Return True
        Else
            Return False
        End If

    End Function

    <WebMethod()> _
    Public Function bajaPersona(ByVal id_persona As Integer) As Boolean

        Dim blanquito As Persona = New Persona()
        If blanquito.bajaPersona(id_persona) Then

            Return True
        Else
            Return False
        End If

        Return True
    End Function

    <WebMethod()> _
    Public Function getAll() As List(Of String)

        Dim lista As List(Of String) = New List(Of String)

        Dim blan As Persona = New Persona

        For i As Integer = 0 To blan.getAll.Count - 1
            lista.Add(blan.getAll.Item(i).getId_persona)
            lista.Add(blan.getAll.Item(i).getNombreApellido)
            lista.Add(blan.getAll.Item(i).getFechaNacimiento)
            lista.Add(blan.getAll.Item(i).getEdad)
            lista.Add(blan.getAll.Item(i).getSexo)
            lista.Add(blan.getAll.Item(i).getBaja)
        Next

        Return lista

    End Function

    <WebMethod()> _
    Public Function modificarPersona(ByVal id_persona As Integer, ByVal nombreApellido As String, ByVal fechaNacimiento As DateTime, ByVal edad As Integer, ByVal sexo As Integer) As Boolean

        Dim blanquito As Persona = New Persona()
        If blanquito.modificarPersona(id_persona, nombreApellido, fechaNacimiento, edad, sexo) Then

            Return True
        Else
            Return False
        End If

        Return True


    End Function


End Class