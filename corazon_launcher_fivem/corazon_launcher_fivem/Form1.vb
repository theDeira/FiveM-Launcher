Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32
Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Net.WebClient
Imports System.Net


Public Class Form1

    Private Sub SetA3Directory()
        FolderBrowserDialog1.ShowDialog()
        directory = FolderBrowserDialog1.SelectedPath

        If directory.Equals("") Then
            SetA3Directory()
            Exit Sub
        End If

        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherDoublox")
        My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherDoublox\directory.a3", directory, False)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
