﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("ae2ec656-a83c-427b-ab91-a7adc3a9952c")>
#Region "Contextos"

''' <summary>
''' No hay documentación de metadatos disponible.
''' </summary>
Public Partial Class Model1Container
    Inherits ObjectContext

    #Region "Constructores"

    ''' <summary>
    ''' Inicializa un nuevo objeto Model1Container usando la cadena de conexión encontrada en la sección 'Model1Container' del archivo de configuración de la aplicación.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=Model1Container", "Model1Container")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Inicializar un nuevo objeto Model1Container.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "Model1Container")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Inicializar un nuevo objeto Model1Container.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "Model1Container")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Métodos parciales"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

End Class

#End Region

