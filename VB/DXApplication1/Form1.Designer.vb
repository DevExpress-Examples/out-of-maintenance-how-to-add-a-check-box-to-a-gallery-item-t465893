Namespace DXApplication1
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
			Me.components = New System.ComponentModel.Container()
			Dim checkContextButton1 As New DevExpress.Utils.CheckContextButton()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim checkContextButton2 As New DevExpress.Utils.CheckContextButton()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Me.galleryDropDown1 = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			DirectCast(Me.galleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' galleryDropDown1
			' 
			' 
			' 
			' 
			checkContextButton1.Checked = True
			checkContextButton1.Id = New System.Guid("c849249b-dc14-40ad-8a7e-fe13cf7990c8")
			checkContextButton1.Name = "CheckContextButton"
			checkContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
			Me.galleryDropDown1.Gallery.ContextButtons.Add(checkContextButton1)
			galleryItemGroup1.Caption = "Group1"
			galleryItem1.Caption = "Item1"
			galleryItem1.Checked = True
			galleryItem1.Image = (DirectCast(resources.GetObject("galleryItem1.Image"), System.Drawing.Image))
			galleryItem1.Value = 0
			galleryItem2.Caption = "Item2"
			galleryItem2.Checked = True
			galleryItem2.Image = (DirectCast(resources.GetObject("galleryItem2.Image"), System.Drawing.Image))
			galleryItem2.Value = 1
			galleryItem3.Caption = "Item3"
			galleryItem3.Image = (DirectCast(resources.GetObject("galleryItem3.Image"), System.Drawing.Image))
			galleryItem3.Value = 2
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3})
			Me.galleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(90, 120)
			Me.galleryDropDown1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
			Me.galleryDropDown1.Gallery.ShowItemText = True
			Me.galleryDropDown1.Manager = Me.barManager1
			Me.galleryDropDown1.Name = "galleryDropDown1"
			Me.galleryDropDown1.ShowCaption = True
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2})
			Me.barManager1.MaxItemId = 2
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            'Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(374, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 406)
            '	Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(374, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            '	Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 406)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(374, 0)
            '	Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 406)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' galleryControl1
			' 
			Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.galleryControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.galleryControl1.DesignGalleryGroupIndex = 0
			Me.galleryControl1.DesignGalleryItemIndex = 0
			Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' 
			' 
			checkContextButton2.Id = New System.Guid("1976cde2-0fca-4666-b1fc-7a8d4762b2e3")
			checkContextButton2.Name = "CheckContextButton"
			checkContextButton2.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
			Me.galleryControl1.Gallery.ContextButtons.Add(checkContextButton2)
			galleryItemGroup2.Caption = "Group2"
			Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(120, 90)
			Me.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
			Me.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
			Me.galleryControl1.Gallery.ItemSize = New System.Drawing.Size(50, 50)
'			Me.galleryControl1.Gallery.ContextButtonCustomize += New DevExpress.XtraBars.Ribbon.Gallery.GalleryContextButtonCustomizeEventHandler(Me.galleryControl1_Gallery_ContextButtonCustomize)
'			Me.galleryControl1.Gallery.ContextButtonClick += New DevExpress.Utils.ContextItemClickEventHandler(Me.galleryControl1_Gallery_ContextButtonClick)
			Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
			Me.galleryControl1.Name = "galleryControl1"
			Me.galleryControl1.Size = New System.Drawing.Size(374, 406)
			Me.galleryControl1.TabIndex = 4
			Me.galleryControl1.Text = "galleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.galleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient1.Size = New System.Drawing.Size(353, 402)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(374, 406)
			Me.Controls.Add(Me.galleryControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.galleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private galleryDropDown1 As DevExpress.XtraBars.Ribbon.GalleryDropDown
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient

	End Class
End Namespace

