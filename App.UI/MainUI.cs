using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App.Layer;

namespace App.UI
{
    public partial class MainUI : Form
    {
        private SimpleClass class1;
        public MainUI()
        {
            InitializeComponent();
            class1 = new SimpleClass();
            class1.simpleAction = SimpleAction;
        }

        private void SimpleAction(int i, string s)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                ListViewItem item1 = new ListViewItem();

                item1.Text = i.ToString();
                item1.SubItems.Add(s);
                listView.Items.Add(item1);
                this.Controls.Add(listView);
                countText.Text = string.Format("Count: {0}", listView.Items.Count);
            }));

        }

        private void testCall_Click(object sender, EventArgs e)
        {
            class1.TestAction();
        }
    }
}
