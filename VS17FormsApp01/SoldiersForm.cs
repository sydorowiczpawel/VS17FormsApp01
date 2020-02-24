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
    public partial class _soldiersForm : Form
    {
        public _mainForm form1;
        public _soldiersForm(_mainForm form1)
        {
            this.form1 = form1;
            InitializeComponent();

            foreach(Soldier item in form1.soldiersList)
            {
                ListViewItem lvi = new ListViewItem((item.id).ToString());

                lvi.SubItems.Add(item.rank);
                lvi.SubItems.Add(item.name);
                lvi.SubItems.Add(item.surname);
                lvi.SubItems.Add(item.position);
                lvi.SubItems.Add(item.platoon);
                lvi.SubItems.Add(item.born);
                lvi.SubItems.Add(item.serve_since);
                lvi.SubItems.Add(item.fathers_name);


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

                for (int i = 0; i < form1.soldiersList.Count; i++)
                {
                    if (form1.soldiersList[i].id == delete)
                        form1.soldiersList.Remove(form1.soldiersList[i]);
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

                    for (int i = 0; i < form1.soldiersList.Count; i++)
                    {
                        if (form1.soldiersList[i].id == delete)
                            form1.soldiersList.Remove(form1.soldiersList[i]);
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
