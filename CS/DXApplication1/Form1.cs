using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        DataItemCollection dataStore;
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.dataStore = LoadData();
            InitializeGallery(this.dataStore);
        }
        private DataItemCollection LoadData() {
            return new DataItemCollection() { new DataItem(true), new DataItem(false), new DataItem(true), new DataItem(false)};
        }
        void InitializeGallery(DataItemCollection dataStore) {
            foreach(var item in dataStore)
                galleryControl1.Gallery.Groups[0].Items.Add(new GalleryItem() { Tag = item, Image = DXApplication1.Properties.Resources.Image1 });
        }
        private void galleryControl1_Gallery_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            CheckContextButton check = e.Item as CheckContextButton;
            if(check == null) return;
            GalleryItem galleryItem = e.DataItem as GalleryItem;
            DataItem data = (DataItem)galleryItem.Tag;
            data.IsChecked = check.Checked;
        }
        private void galleryControl1_Gallery_ContextButtonCustomize(object sender, GalleryContextButtonCustomizeEventArgs e) {
            CheckContextButton check = e.Item as CheckContextButton;
            if(check == null) return;
            DataItem data = (DataItem)e.GalleryItem.Tag;
            check.Checked = data.IsChecked;
        }
    }
    public class DataItem {
        public DataItem(bool isChecked) {
            IsChecked = isChecked;
        }
        public bool IsChecked { get; set; }
    }
    public class DataItemCollection : List<DataItem> {
    }
}
