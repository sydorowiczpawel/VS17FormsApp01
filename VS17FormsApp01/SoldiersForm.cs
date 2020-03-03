using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;


namespace VS17FormsApp01
{
    public partial class _soldiersForm : Form
    {
        public _mainForm form1;
        public _soldiersForm(_mainForm form1)
        {
            this.form1 = form1;
            InitializeComponent();

            List<Soldier> sld = new List<Soldier>();


            void show()
            {
                XmlSerializer srl = new XmlSerializer(typeof(List<Soldier>));
                FileStream fs = new FileStream("soldiers.xml", FileMode.Open, FileAccess.Read);
                
                sld = srl.Deserialize(fs) as List<Soldier>;
                
             
            }

            foreach (Soldier item in form1.soldiersList)
            {
        
            ListViewItem lvi = new ListViewItem();

            lvi.SubItems.Add(item.Rank);
            lvi.SubItems.Add(item.Name);
            lvi.SubItems.Add(item.Surname);
            lvi.SubItems.Add(item.Position);
            lvi.SubItems.Add(item.Platoon);
            lvi.SubItems.Add(item.Born);
            lvi.SubItems.Add(item.Serve_since);
            lvi.SubItems.Add(item.Fathers_name);


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

