using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEntryApp.UseCaseDemos.Basic
{

    public partial class ObjectInspectorControl : UserControl
    {

        public Func<IEnumerable> GetListFunc { get; set; }

        private IEnumerable items;

        [CategoryAttribute("Configuration"), DescriptionAttribute("Control Title")]
        public string Title { get; set; }

        [CategoryAttribute("Configuration"), DescriptionAttribute("List Display Member")]
        public string ListDisplayMember { get; set; }



        public object SelectedItem { get { return this.itemsListBox.SelectedItem; } }



        public ObjectInspectorControl()
        {
            InitializeComponent();

            //this.DataBindings.Add("Title", this.topLabel, "Text");
            this.topLabel.DataBindings.Add("Text", this, "Title");
            this.itemsListBox.DataBindings.Add("DisplayMember", this, "ListDisplayMember");
        }

        public void ObjectInspectorControl_Load(object sender, EventArgs e)
        {

            if (this.GetListFunc != null)
            {
                this.itemsListBox.DataSource = this.GetListFunc();
            }
        }

        private void itemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            TypeDescriptor.AddAttributes(itemsListBox.SelectedItem, new Attribute[] { new ReadOnlyAttribute(true) });
            propertyGrid.SelectedObject = itemsListBox.SelectedItem;
        }
    }
}
