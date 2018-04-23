Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            richEditControl1.Text = StringSample.SampleText
            richEditControl1.ActiveView.ZoomFactor =.5F
        End Sub

        Private Sub richEditControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.PopupMenuShowingEventArgs) Handles richEditControl1.PopupMenuShowing
            e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Add watermark", AddressOf AddImageWatermark))
            e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Remove watermark", AddressOf RemoveImageWatermark))

        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            richEditControl1.Document.AppendSection()
            richEditControl1.Document.InsertText(richEditControl1.Document.Range.End, StringSample.SampleText)
        End Sub

        Public Sub AddImageWatermark(ByVal sender As Object, ByVal e As EventArgs)
            Dim watermarkImage As Image = Nothing

            Dim dlg As New OpenFileDialog()

            dlg.Title = "Select Image"
            dlg.Filter = "image files (*.png)|*.png"

            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                watermarkImage = Image.FromFile(dlg.FileName)
            End If
            dlg.Dispose()
            If watermarkImage Is Nothing Then
                Return
            End If

            Dim currentSection As Section = GetCurrentSection()
            Dim subDocument As SubDocument = currentSection.BeginUpdateHeader()
            subDocument.Delete(subDocument.Range)
            Dim shape As Shape = subDocument.Shapes.InsertPicture(subDocument.Range.Start, watermarkImage)

            shape.RotationAngle = -45
            shape.Offset = New PointF(Convert.ToInt64(currentSection.Page.Width) \ 2 - Convert.ToInt64(shape.Size.Width) \ 2, Convert.ToInt64(currentSection.Page.Height) \ 2 - Convert.ToInt64(shape.Size.Height) \ 2)
            currentSection.EndUpdateHeader(subDocument)
        End Sub

        Public Function GetCurrentSection() As Section
            Return richEditControl1.Document.GetSection(richEditControl1.Document.CaretPosition)
        End Function

        Public Sub RemoveImageWatermark(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentSection As Section = GetCurrentSection()
            Dim subDocument As SubDocument = currentSection.BeginUpdateHeader()
            subDocument.Delete(subDocument.Range)
            currentSection.EndUpdateHeader(subDocument)
        End Sub
    End Class
End Namespace
