﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class Settings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()),Settings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As Settings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property FlexUserDirectory() As String
        Get
            Return CType(Me("FlexUserDirectory"),String)
        End Get
        Set
            Me("FlexUserDirectory") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Strength,Dexerity,Stamina,Charisma,Perception,Intelligent,Level,HP,Humanity,Score"& _ 
        ",hp of doctor matt,Body infection,Head infection,Skin infection,Tail infection,G"& _ 
        "enital Infection,SatisfiedTanuki,hospquest,Cocks (Number of cocks),Breasts (Numb"& _ 
        "er of breast),Cunts (Number of cunts),Breast Size,Cock Length,Cock Width (Also a"& _ 
        "ffects cum and ball size),Cunt Length,Cunt Width,Equipped Weapon,franksex,frankm"& _ 
        "alesex,Snow special (annote),REMOVED (value always 0),Coleen special (annote),co"& _ 
        "leentalk,coleenfound,coleencollared,coleenalpha,coleenslut,coleenspray,hp of doc"& _ 
        "tor mouse,coonstatus,featunlock,butterflymagic? wth is this,catnum,mateable,gryp"& _ 
        "honcomforted,shiftable,medeaget,mtp,hyg,nes,mtrp,boristalk,borisquest,progress o"& _ 
        "f alex,angiehappy,angietalk,deerconsent,hp  of Susan,mattcollection")>  _
    Public Property Annotation1() As String
        Get
            Return CType(Me("Annotation1"),String)
        End Get
        Set
            Me("Annotation1") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property RawEditsEnable() As Boolean
        Get
            Return CType(Me("RawEditsEnable"),Boolean)
        End Get
        Set
            Me("RawEditsEnable") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.FlexEdit.Settings
            Get
                Return Global.FlexEdit.Settings.Default
            End Get
        End Property
    End Module
End Namespace
