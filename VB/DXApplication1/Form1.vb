Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private dataStore As DataItemCollection
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.dataStore = LoadData()
			InitializeGallery(Me.dataStore)
		End Sub
		Private Function LoadData() As DataItemCollection
            Return New DataItemCollection() From {
                New DataItem(True),
                New DataItem(False),
                New DataItem(True),
                New DataItem(False)
            }
        End Function
        Private Sub InitializeGallery(ByVal dataStore As DataItemCollection)
            For Each item In dataStore
                galleryControl1.Gallery.Groups(0).Items.Add(New GalleryItem() With {.Tag = item, .Image = My.Resources.Image1})
            Next item
        End Sub
        Private Sub galleryControl1_Gallery_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs) Handles galleryControl1.Gallery.ContextButtonClick
            Dim check As CheckContextButton = TryCast(e.Item, CheckContextButton)
            If check Is Nothing Then
                Return
            End If
            Dim galleryItem As GalleryItem = TryCast(e.DataItem, GalleryItem)
            Dim data As DataItem = DirectCast(galleryItem.Tag, DataItem)
            data.IsChecked = check.Checked
        End Sub
        Private Sub galleryControl1_Gallery_ContextButtonCustomize(ByVal sender As Object, ByVal e As GalleryContextButtonCustomizeEventArgs) Handles galleryControl1.Gallery.ContextButtonCustomize
            Dim check As CheckContextButton = TryCast(e.Item, CheckContextButton)
            If check Is Nothing Then
                Return
            End If
            Dim data As DataItem = CType(e.GalleryItem.Tag, DataItem)
            check.Checked = data.IsChecked
        End Sub
    End Class
	Public Class DataItem
		Public Sub New(ByVal isChecked As Boolean)
			Me.IsChecked = isChecked
		End Sub
		Public Property IsChecked() As Boolean
	End Class
	Public Class DataItemCollection
		Inherits List(Of DataItem)

	End Class
End Namespace
