Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OfficeOpenXml

Public Class Form1

	Public Sub New()
		InitializeComponent()
		lstvproducts.FullRowSelect = True

	End Sub
	Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
		If clbproducts.CheckedItems.Count = 0 Then
			Return
		End If
		Dim randomPrice As New Random()
		Dim objproduct1 As Product
		For Each selectedItem As Object In clbproducts.CheckedItems
			Dim productName As String = selectedItem.ToString()
			Dim productPrice As Decimal = Math.Round(randomPrice.NextDouble() * 80, 2)
			objproduct1 = New Product()
			objproduct1.NameProduct = productName
			objproduct1.Price = productPrice
			Dim row As New ListViewItem(productName)
			row.SubItems.Add(productPrice.ToString())
			lstvproducts.Items.Add(row)
		Next
		lblquantityproducts.Text = lstvproducts.Items.Count
		UpdateTotal()

		Dim saveFileDialog As New SaveFileDialog()
		saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
		saveFileDialog.FilterIndex = 2
		saveFileDialog.RestoreDirectory = True
		If saveFileDialog.ShowDialog() <> DialogResult.OK Then
			Return
		End If
		Dim Path As String = saveFileDialog.FileName
		Using package As New ExcelPackage(New FileInfo(Path))
			Dim worksheet = package.Workbook.Worksheets.Add("ShoppingList")
			worksheet.Cells(1, 1).Value = "Product name"
			worksheet.Cells(1, 2).Value = "Price "
			Dim row As Integer = 2
			For Each item As ListViewItem In lstvproducts.Items
				worksheet.Cells(row, 1).Value = item.SubItems(0).Text
				worksheet.Cells(row, 2).Value = item.SubItems(1).Text
				row += 1
			Next
			package.Save()
		End Using

	End Sub
	Sub UpdateLabel()
		lblquantityproducts.Text = lstvproducts.Items.Count
	End Sub
	Sub UpdateTotal()
		Dim Total As Decimal = 0
		For Each item As ListViewItem In lstvproducts.Items
			Total += Decimal.Parse(item.SubItems(1).Text)
		Next
		lbltotalprice.Text = Total
	End Sub

	Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

		clbproducts.ClearSelected()
		lbltotalprice.Text = ""
		lblquantityproducts.Text = ""

	End Sub


End Class
