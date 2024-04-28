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
		clbproducts = New CheckedListBox()
		lstvproducts = New ListView()
		ColumnProduct = New ColumnHeader()
		ColumnPrice = New ColumnHeader()
		Label1 = New Label()
		Label2 = New Label()
		lblquantityproducts = New Label()
		Label4 = New Label()
		Label5 = New Label()
		lbltotalprice = New Label()
		btnsave = New Button()
		btnclear = New Button()
		SuspendLayout()
		' 
		' clbproducts
		' 
		clbproducts.BackColor = Color.White
		clbproducts.CheckOnClick = True
		clbproducts.Font = New Font("Franklin Gothic Book", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		clbproducts.ForeColor = Color.OrangeRed
		clbproducts.FormattingEnabled = True
		clbproducts.Items.AddRange(New Object() {"Tomato", "Beans", "Milk", "Apples", "Salmon", "Chicken", "Spaguetti", "Potato chips", "Olive oil", "Shampoo", "Toilet paper", "Dog food"})
		clbproducts.Location = New Point(81, 92)
		clbproducts.Margin = New Padding(3, 4, 3, 4)
		clbproducts.Name = "clbproducts"
		clbproducts.Size = New Size(163, 412)
		clbproducts.TabIndex = 0
		' 
		' lstvproducts
		' 
		lstvproducts.BackColor = SystemColors.ButtonFace
		lstvproducts.BorderStyle = BorderStyle.FixedSingle
		lstvproducts.Columns.AddRange(New ColumnHeader() {ColumnProduct, ColumnPrice})
		lstvproducts.Font = New Font("Franklin Gothic Book", 12F)
		lstvproducts.Location = New Point(302, 79)
		lstvproducts.Margin = New Padding(3, 4, 3, 4)
		lstvproducts.Name = "lstvproducts"
		lstvproducts.Size = New Size(313, 433)
		lstvproducts.TabIndex = 1
		lstvproducts.UseCompatibleStateImageBehavior = False
		lstvproducts.View = View.Details
		' 
		' ColumnProduct
		' 
		ColumnProduct.Text = "Product"
		ColumnProduct.Width = 150
		' 
		' ColumnPrice
		' 
		ColumnPrice.Text = "Price"
		ColumnPrice.Width = 100
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Franklin Gothic Book", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.Location = New Point(229, 12)
		Label1.Name = "Label1"
		Label1.Size = New Size(181, 34)
		Label1.TabIndex = 2
		Label1.Text = "Shopping List"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
		Label2.Location = New Point(156, 545)
		Label2.Name = "Label2"
		Label2.Size = New Size(241, 21)
		Label2.TabIndex = 3
		Label2.Text = "Quantity of selected products:"
		' 
		' lblquantityproducts
		' 
		lblquantityproducts.AutoSize = True
		lblquantityproducts.Font = New Font("Franklin Gothic Book", 12F)
		lblquantityproducts.Location = New Point(417, 545)
		lblquantityproducts.Name = "lblquantityproducts"
		lblquantityproducts.Size = New Size(0, 21)
		lblquantityproducts.TabIndex = 4
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Franklin Gothic Book", 12F)
		Label4.Location = New Point(1213, 575)
		Label4.Name = "Label4"
		Label4.Size = New Size(64, 21)
		Label4.TabIndex = 5
		Label4.Text = "Total:  $"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
		Label5.Location = New Point(279, 573)
		Label5.Name = "Label5"
		Label5.Size = New Size(68, 21)
		Label5.TabIndex = 6
		Label5.Text = "Total: $"
		' 
		' lbltotalprice
		' 
		lbltotalprice.AutoSize = True
		lbltotalprice.Font = New Font("Franklin Gothic Book", 12F)
		lbltotalprice.Location = New Point(354, 573)
		lbltotalprice.Name = "lbltotalprice"
		lbltotalprice.Size = New Size(0, 21)
		lbltotalprice.TabIndex = 7
		' 
		' btnsave
		' 
		btnsave.BackColor = Color.OliveDrab
		btnsave.FlatStyle = FlatStyle.Flat
		btnsave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnsave.ForeColor = Color.LightYellow
		btnsave.Location = New Point(107, 625)
		btnsave.Margin = New Padding(3, 4, 3, 4)
		btnsave.Name = "btnsave"
		btnsave.Size = New Size(208, 52)
		btnsave.TabIndex = 8
		btnsave.Text = "Save "
		btnsave.UseVisualStyleBackColor = False
		' 
		' btnclear
		' 
		btnclear.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnclear.Location = New Point(354, 625)
		btnclear.Margin = New Padding(3, 4, 3, 4)
		btnclear.Name = "btnclear"
		btnclear.Size = New Size(208, 52)
		btnclear.TabIndex = 9
		btnclear.Text = "Clear"
		btnclear.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(686, 693)
		Controls.Add(btnclear)
		Controls.Add(btnsave)
		Controls.Add(lbltotalprice)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(lblquantityproducts)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(lstvproducts)
		Controls.Add(clbproducts)
		Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ForeColor = Color.DarkOliveGreen
		Margin = New Padding(3, 4, 3, 4)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents clbproducts As CheckedListBox
	Friend WithEvents lstvproducts As ListView
	Friend WithEvents ColumnProduct As ColumnHeader
	Friend WithEvents ColumnPrice As ColumnHeader
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lblquantityproducts As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lbltotalprice As Label
	Friend WithEvents btnsave As Button
	Friend WithEvents btnclear As Button

End Class
