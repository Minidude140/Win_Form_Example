﻿'Zachary Christensen
'RCET 2265
'Fall 2023
'Windows Form in Class example
'https://github.com/Minidude140/Win_Form_Example.git


Option Explicit On
Option Strict On
Public Class WinFormExampleForm
    Dim fruits As New List(Of String)
    'Custom methods
    ''' <summary>
    ''' Clear the list of fruits and return to a know default state
    ''' </summary>
    Private Sub SetListDefaults()
        Me.fruits.Clear()
        Me.fruits.Add("Apple")
        Me.fruits.Add("Grape")
        Me.fruits.Add("Banana")
        Me.fruits.Add("Lemon")
        Me.fruits.Add("Orange")
    End Sub

    ''' <summary>
    ''' Update all list controls with the current fruits
    ''' </summary>
    Private Sub DisplayList()
        ExampleListBox.Items.Clear()
        ExampleComboBox.Items.Clear()
        For Each fruit As String In Me.fruits
            ExampleListBox.Items.Add(fruit)
            ExampleComboBox.Items.Add(fruit)
        Next
    End Sub

    ''' <summary>
    ''' <list>
    ''' <item><description> Adds contents of the text box to the fruits list</description></item>
    ''' <item><description> Avoid adding empty items</description></item>
    ''' <item><description> Avoid adding duplicate items</description></item>
    ''' </list>
    ''' </summary>
    Sub AddItem()
        If ExampleTextBox.Text <> "" _
            And Not ExampleListBox.Items.Contains(ExampleTextBox.Text) _
            And Not ExampleComboBox.Items.Contains(ExampleTextBox.Text) Then

            fruits.Add(ExampleTextBox.Text)
        End If
    End Sub


    'Event Handlers
    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sets the default list of fruits
        SetListDefaults()
        'adds default list of fruits to combo box and list box
        DisplayList()

        ExampleComboBox.SelectedIndex = 0

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        Me.Text = ExampleTextBox.Text
        'reverse only if Reverse Check box is checked
        If StringReverseCheckBox.Checked Then
            ExampleTextBox.Text = StrReverse(ExampleTextBox.Text)
        End If
        DisplayList()
        AddItem()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Try
            ExampleListBox.Items.RemoveAt(ExampleListBox.SelectedIndex)
            ExampleComboBox.Items.RemoveAt(ExampleComboBox.SelectedIndex)
        Catch ex As Exception
            MsgBox("Please select an Item to remove.")
        End Try
    End Sub

    Private Sub StringReverseCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StringReverseCheckBox.CheckedChanged

    End Sub

    Private Sub ExampleListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExampleListBox.SelectedIndexChanged
        Try
            'set the text box to the selected item
            If ExampleListBox.SelectedIndex >= 0 Then
                Me.Text = ExampleListBox.SelectedItem.ToString()
                ExampleTextBox.Text = ExampleListBox.SelectedItem.ToString()
                ExampleComboBox.SelectedIndex = ExampleListBox.SelectedIndex
            End If

        Catch oops As System.NullReferenceException
            'do nothing
        Catch ex As Exception
            'do nothing
            MsgBox(ExampleListBox.SelectedIndex)
        End Try
    End Sub

    Private Sub ExampleComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExampleComboBox.SelectedIndexChanged
        Try
            'set the text box to the selected item
            If ExampleComboBox.SelectedIndex >= 0 Then
                Me.Text = ExampleComboBox.SelectedItem.ToString()
                ExampleComboBox.Text = ExampleComboBox.SelectedItem.ToString()
                ExampleListBox.SelectedIndex = ExampleComboBox.SelectedIndex
            End If

        Catch oops As System.NullReferenceException
            'do nothing
        Catch ex As Exception
            'do nothing
            MsgBox(ExampleComboBox.SelectedIndex)
        End Try
    End Sub

End Class
