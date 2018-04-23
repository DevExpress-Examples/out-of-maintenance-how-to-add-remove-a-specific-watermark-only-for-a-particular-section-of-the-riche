Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditWatermark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditControl1.Text = StringSample.SampleText
			richEditControl1.ActiveView.ZoomFactor =.5f
		End Sub


		Public Sub RemoveImageWatermark(ByVal sender As Object, ByVal e As EventArgs)
			Dim currentSection As Section = GetCurrentSection()
			Dim subDocument As SubDocument = currentSection.BeginUpdateHeader()
			subDocument.Delete(subDocument.Range)
			currentSection.EndUpdateHeader(subDocument)
		End Sub

		Public Function GetCurrentSection() As Section
			Return richEditControl1.Document.GetSection(richEditControl1.Document.CaretPosition)
		End Function

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
			Dim shape As Shape = subDocument.InsertPicture(subDocument.Range.Start, watermarkImage)

			shape.RotationAngle = -45
            shape.Offset = New PointF(CLng(currentSection.Page.Width) \ 2 - CLng(shape.Size.Width) \ 2, CLng(currentSection.Page.Height) \ 2 - CLng(shape.Size.Height) \ 2)
			currentSection.EndUpdateHeader(subDocument)
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			richEditControl1.Document.AppendSection()
			richEditControl1.Document.InsertText(richEditControl1.Document.Range.End, StringSample.SampleText)
		End Sub

		Private Sub richEditControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles richEditControl1.PopupMenuShowing
			e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Add watermark", New EventHandler(AddressOf AddImageWatermark)))
			e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Remove watermark", New EventHandler(AddressOf RemoveImageWatermark)))
		End Sub
	End Class
End Namespace