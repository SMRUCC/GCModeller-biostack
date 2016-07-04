﻿Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CommandLine
Imports SMRUCC.HTTPInternal
Imports SMRUCC.HTTPInternal.Platform

''' <summary>
''' 在这里执行WebApp的初始化工作
''' </summary>
Public Module WebApp

    Public ReadOnly Property Config As Configs =
        Configs.Load

    Sub Main(engine As PlatformEngine)
        Call engine.SetGetRequest(
            AddressOf New __mapHelper With {
                .engine = engine
            }.__requestStream
        )
        Call engine.AddMappings(App.LocalDataTemp, "/data-store/")

        engine.BufferSize = 1024 * 128
    End Sub

    Public ReadOnly Template As String = My.Resources.index

    ''' <summary>
    ''' 需要下载的数据文件都保存在<see cref="App.LocalDataTemp"/>之中
    ''' </summary>
    ''' <param name="app"></param>
    ''' <param name="CLI"></param>
    ''' <returns></returns>
    Public Function Invoke(app As String, CLI As String) As Integer
        Dim run As New IORedirectFile(Config.bin & "/" & app & ".exe", CLI)
        Return run.Run
    End Function

    Private Structure __mapHelper

        Public engine As PlatformEngine

        Public Function __requestStream(ByRef res As String) As Byte()
            If Regex.Match(res, "\.html?$", RegexICMul).Success Then
                Dim url As String = engine.MapPath(res)
                Dim page As HtmlPage = HtmlPage.LoadPage(url, engine.HOME.FullName)
                Dim html As String = page.BuildPage(WebApp.Template)
                Dim bufs As Byte() = Encoding.UTF8.GetBytes(html)

                Return bufs
            Else
                Return engine.GetResource(res)
            End If
        End Function
    End Structure
End Module
