﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.312
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.Xml.Serialization

Namespace SolutionProfileV2

    '
    'This source code was auto-generated by xsd, Version=2.0.50727.42.
    '

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/pag/cab-profile/2.0"), _
     System.Xml.Serialization.XmlRootAttribute("SolutionProfile", [Namespace]:="http://schemas.microsoft.com/pag/cab-profile/2.0", IsNullable:=False)> _
    Partial Public Class SolutionProfileElement

        Private sectionField() As SectionElement

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("Section")> _
        Public Property Section() As SectionElement()
            Get
                Return Me.sectionField
            End Get
            Set(ByVal value As SectionElement())
                Me.sectionField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/pag/cab-profile/2.0")> _
    Partial Public Class SectionElement

        Private dependenciesField() As DependencyElement

        Private modulesField() As ModuleInfoElement

        Private nameField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Dependency", IsNullable:=False)> _
        Public Property Dependencies() As DependencyElement()
            Get
                Return Me.dependenciesField
            End Get
            Set(ByVal value As DependencyElement())
                Me.dependenciesField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("ModuleInfo", IsNullable:=False)> _
        Public Property Modules() As ModuleInfoElement()
            Get
                Return Me.modulesField
            End Get
            Set(ByVal value As ModuleInfoElement())
                Me.modulesField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/pag/cab-profile/2.0")> _
    Partial Public Class DependencyElement

        Private nameField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/pag/cab-profile/2.0")> _
    Partial Public Class RoleElement

        Private allowField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property Allow() As String
            Get
                Return Me.allowField
            End Get
            Set(ByVal value As String)
                Me.allowField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://schemas.microsoft.com/pag/cab-profile/2.0")> _
    Partial Public Class ModuleInfoElement

        Private dependenciesField() As DependencyElement

        Private rolesField() As RoleElement

        Private assemblyFileField As String

        Private nameField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Dependency", IsNullable:=False)> _
        Public Property Dependencies() As DependencyElement()
            Get
                Return Me.dependenciesField
            End Get
            Set(ByVal value As DependencyElement())
                Me.dependenciesField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute("Role", IsNullable:=False)> _
        Public Property Roles() As RoleElement()
            Get
                Return Me.rolesField
            End Get
            Set(ByVal value As RoleElement())
                Me.rolesField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property AssemblyFile() As String
            Get
                Return Me.assemblyFileField
            End Get
            Set(ByVal value As String)
                Me.assemblyFileField = value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(ByVal value As String)
                Me.nameField = value
            End Set
        End Property
    End Class
End Namespace