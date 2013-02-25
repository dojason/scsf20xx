'===============================================================================
' Microsoft patterns & practices
' CompositeUI Application Block
'===============================================================================
' Copyright � Microsoft Corporation.  All rights reserved.
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
' FITNESS FOR A PARTICULAR PURPOSE.
'===============================================================================

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.26
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

' 
' This source code was auto-generated by xsd, Version=2.0.50727.26.
' 

Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Namespace Configuration.Xsd


	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.26"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="http://schemas.microsoft.com/pag/cab-profile"), System.Xml.Serialization.XmlRootAttribute("SolutionProfile", Namespace:="http://schemas.microsoft.com/pag/cab-profile", IsNullable:=False)> _
	Partial Public Class SolutionProfileElement

		Private modulesField As ModuleInfoElement()

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute("ModuleInfo", IsNullable:=False)> _
		Public Property Modules() As ModuleInfoElement()
			Get
				Return Me.modulesField
			End Get
			Set(ByVal value As ModuleInfoElement())
				Me.modulesField = value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.26"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="http://schemas.microsoft.com/pag/cab-profile")> _
	Partial Public Class ModuleInfoElement

		Private rolesField As RoleElement()

		Private assemblyFileField As String

		Private updateLocationField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlArrayItemAttribute("Role", IsNullable:=False)> _
		Public Property Roles() As RoleElement()
			Get
				Return Me.rolesField
			End Get
			Set(ByVal value As RoleElement())
				Me.rolesField = Value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()> _
		Public Property AssemblyFile() As String
			Get
				Return Me.assemblyFileField
			End Get
			Set(ByVal value As String)
				Me.assemblyFileField = Value
			End Set
		End Property

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute(DataType:="anyURI")> _
		Public Property UpdateLocation() As String
			Get
				Return Me.updateLocationField
			End Get
			Set(ByVal value As String)
				Me.updateLocationField = Value
			End Set
		End Property
	End Class

	''' <remarks/>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.26"), System.SerializableAttribute(), System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Xml.Serialization.XmlTypeAttribute(Namespace:="http://schemas.microsoft.com/pag/cab-profile")> _
	Partial Public Class RoleElement

		Private allowField As String

		''' <remarks/>
		<System.Xml.Serialization.XmlAttributeAttribute()> _
		Public Property Allow() As String
			Get
				Return Me.allowField
			End Get
			Set(ByVal value As String)
				Me.allowField = Value
			End Set
		End Property
	End Class
End Namespace
