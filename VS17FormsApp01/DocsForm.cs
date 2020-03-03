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
    public partial class _docsForm : Form
    {
        public _mainForm form3;
        public _docsForm(_mainForm form3)
        {
            this.form3 = form3;
            InitializeComponent();

            foreach(Docs item in form3.docsList)
            {
                ListViewItem lvi = new ListViewItem((item.id).ToString());

                lvi.SubItems.Add(item.serial);
                lvi.SubItems.Add(item.number);
                lvi.SubItems.Add(item.km);
                lvi.SubItems.Add(item.mtgOg);
                lvi.SubItems.Add(item.mtgObc);
                
                listView1.Items.Add(lvi);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ListViewItem foundItem = listView1.FindItemWithText(_searchSoldierBox.Text.ToLower());
                if (foundItem != null)
                {
                    foreach (ListViewItem lvi in listView1.Items)
                    {


                        lvi.BackColor = Color.White;

                    }
                    foundItem.Focused = true;
                    foundItem.EnsureVisible();
                    foundItem.BackColor = Color.Yellow;
                }
                else
                    MessageBox.Show("Nie znaleziono wyników", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _searchSoldierBox.Text = "";
            }
        }

        private void _kadraUsun_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                int delete = Int32.Parse(listView1.SelectedItems[0].Text);
                listView1.Items.Remove(lvi);

                for (int i = 0; i < form3.docsList.Count; i++)
                {
                    if (form3.docsList[i].id == delete)
                        form3.docsList.Remove(form3.docsList[i]);
                }


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

                    for (int i = 0; i < form3.docsList.Count; i++)
                    {
                        if (form3.docsList[i].id == delete)
                            form3.docsList.Remove(form3.docsList[i]);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _oknoSold_Load(object sender, EventArgs e)
        {

        }
    }
}
