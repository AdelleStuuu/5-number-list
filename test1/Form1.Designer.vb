<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Number1 = New NumericUpDown()
        Label1 = New Label()
        NumberList = New ListBox()
        EnterNumber = New Button()
        Button2 = New Button()
        CType(Number1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Number1
        ' 
        Number1.Location = New Point(109, 215)
        Number1.Name = "Number1"
        Number1.Size = New Size(150, 27)
        Number1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 1
        Label1.Text = "Number"
        ' 
        ' NumberList
        ' 
        NumberList.FormattingEnabled = True
        NumberList.Location = New Point(109, 65)
        NumberList.Name = "NumberList"
        NumberList.Size = New Size(150, 144)
        NumberList.TabIndex = 2
        ' 
        ' EnterNumber
        ' 
        EnterNumber.Location = New Point(109, 248)
        EnterNumber.Name = "EnterNumber"
        EnterNumber.Size = New Size(150, 29)
        EnterNumber.TabIndex = 3
        EnterNumber.Text = "Add Number"
        EnterNumber.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(109, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 29)
        Button2.TabIndex = 4
        Button2.Text = "Show Numbers"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(366, 380)
        Controls.Add(Button2)
        Controls.Add(EnterNumber)
        Controls.Add(NumberList)
        Controls.Add(Label1)
        Controls.Add(Number1)
        Name = "Form1"
        Text = "Form1"
        CType(Number1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Number1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NumberList As ListBox
    Friend WithEvents EnterNumber As Button
    Friend WithEvents Button2 As Button

End Class
