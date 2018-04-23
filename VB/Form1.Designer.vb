Imports Microsoft.VisualBasic
Imports System
Namespace RichEditWatermark
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.button3 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'richEditControl1
            '
            Me.richEditControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richEditControl1.Location = New System.Drawing.Point(9, 10)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.richEditControl1.Options.MailMerge.KeepLastParagraph = False
            Me.richEditControl1.Size = New System.Drawing.Size(924, 581)
            Me.richEditControl1.TabIndex = 0
            '
            'button3
            '
            Me.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button3.Location = New System.Drawing.Point(577, 595)
            Me.button3.Margin = New System.Windows.Forms.Padding(2)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(100, 25)
            Me.button3.TabIndex = 2
            Me.button3.Text = "Insert section"
            Me.button3.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(942, 631)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.richEditControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents button3 As System.Windows.Forms.Button
	End Class
End Namespace

