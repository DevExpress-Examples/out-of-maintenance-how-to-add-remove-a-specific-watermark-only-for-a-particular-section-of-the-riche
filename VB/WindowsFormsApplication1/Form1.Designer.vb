Namespace WindowsFormsApplication1
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
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.richEditControl1.Location = New System.Drawing.Point(11, 10)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.richEditControl1.Options.MailMerge.KeepLastParagraph = False
            Me.richEditControl1.Size = New System.Drawing.Size(980, 559)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.simpleButton1.Location = New System.Drawing.Point(641, 575)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(125, 27)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Insert section"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1004, 622)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.richEditControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

