using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS17FormsApp01
{
    public partial class _tanksForm : Form
    {
        public _mainForm form2;
        public _tanksForm(_mainForm form2)
        {
            this.form2 = form2;
            InitializeComponent();

            foreach(Tank item in form2.tanksList)
            {
                ListViewItem lvi = new ListViewItem((item.id).ToString());

                lvi.SubItems.Add(item.model);
                lvi.SubItems.Add(item.number);

                listView1.Items.Add(lvi);
            }
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                foreach (ListViewItem lvi in listView1.SelectedItems)
                {
                    int delete = Int32.Parse(listView1.SelectedItems[0].Text);
                    listView1.Items.Remove(lvi);

                    for (int i = 0; i < form2.tanksList.Count; i++)
                    {
                        if (form2.tanksList[i].id == delete)
                            form2.tanksList.Remove(form2.tanksList[i]);
                    }
                }
            }
        }
        private void _deleteTank_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                int delete = Int32.Parse(listView1.SelectedItems[0].Text);
                listView1.Items.Remove(lvi);

                for (int i = 0; i < form2.tanksList.Count; i++)
                {
                    if (form2.tanksList[i].id == delete)
                        form2.tanksList.Remove(form2.tanksList[i]);
                }
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                int delete = Int32.Parse(listView1.SelectedItems[0].Text);
                listView1.Items.Remove(lvi);

                for (int i = 0; i < form2.tanksList.Count; i++)
                {
                    if (form2.tanksList[i].id == delete)
                        form2.tanksList.Remove(form2.tanksList[i]);
                }


            }
        }
        private void _tanksForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


