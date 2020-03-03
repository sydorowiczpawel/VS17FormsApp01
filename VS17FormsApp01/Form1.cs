using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VS17FormsApp01
{
    public partial class _mainForm : Form
    {
        public _mainForm()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void _showSoldiers_Click(object sender, EventArgs e)
        {
            _soldiersForm showSoldiers = new _soldiersForm(this);
            showSoldiers.ShowDialog();
        }
        public List<Soldier> soldiersList = new List<Soldier>();

        public void addSoldierToBase()
        {
            Soldier soldier = new Soldier();

            soldier.Name = _soldierNameBox.Text;
            soldier.Surname = _soldierSurnameBox.Text;
            soldier.Fathers_name = _fatherNameBox.Text;
            soldier.Rank = (_rankComboBox.SelectedItem).ToString();
            soldier.Position = (_positionComboBox.SelectedItem).ToString();
            soldier.Platoon = (_platoonComboBox.SelectedItem).ToString();
            soldier.Born = _birthBox.Text;
            soldier.Serve_since = _serviceBox.Text;

            soldiersList.Add(new Soldier()
            {
                Name = _soldierNameBox.Text,
                Surname = _soldierSurnameBox.Text,
                Fathers_name = _fatherNameBox.Text,
                Rank = (_rankComboBox.SelectedItem).ToString(),
                Position = (_positionComboBox.SelectedItem).ToString(),
                Platoon = (_platoonComboBox.SelectedItem).ToString(),
                Born = _birthBox.Text,
                Serve_since = _serviceBox.Text
            });

            // Serialize the object data to a file
            Stream str = File.Open("soldier.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            // Send the object data to the file
            bf.Serialize(str, soldier);
            str.Close();

            XmlSerializer srl = new XmlSerializer(typeof(Soldier));
            using (TextWriter tw = new StreamWriter("soldier.xml"))
            {
                srl.Serialize(tw, soldier);
            }

            XmlSerializer srl2 = new XmlSerializer(typeof(List<Soldier>));
            using (FileStream fs = new FileStream("soldiers.xml", FileMode.Open, FileAccess.Write))
            {
                srl2.Serialize(fs, soldiersList);
            }
            
            
            soldier = null;
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {

        }

        private void _showTanks_Click(object sender, EventArgs e)
        {
            _tanksForm _tanks = new _tanksForm(this);
            _tanks.ShowDialog();
        }

        public List<Tank> tanksList = new List<Tank>();

        public void addTankToBase()
        {

            tanksList.Add(new Tank()
            {
                model = _tankTypeCbox.Text,
                number = _tankNumberCbox.Text
            }
            );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _addTankButton_Click(object sender, EventArgs e)
        {
            if (_tankTypeCbox.SelectedIndex == -1)
                MessageBox.Show("Wybierz model!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_tankNumberCbox.TextLength == 0)
                MessageBox.Show("Wpisz numer czołgu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                addTankToBase();
                MessageBox.Show("Tank successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public List<Docs> docsList = new List<Docs>();

        public void addDocToBase()
        {
            docsList.Add(new Docs()
            {
                serial = (_docSerialCbox.SelectedItem).ToString(),
                number = _docNumberBox.Text,
                km = _docKmBox.Text,
                mtgOg = _docMtgOgBox.Text,
                mtgObc = _docMtgObcBox.Text
            });
        }

        private void _addDocumentButton_Click(object sender, EventArgs e)
        {
            if (_docSerialCbox.SelectedIndex == -1)
                MessageBox.Show("Musisz wybrać serię dokumentu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_docNumberBox.TextLength == 0)
                MessageBox.Show("Podaj numer rozkazu", "Error wchuj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (_docKmBox.TextLength == 0)
                MessageBox.Show("Podaj stan licznika kilometrów", "Error wchuj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (_docMtgOgBox.TextLength == 0)
                MessageBox.Show("Podaj stan licznika motogodzin ogólnych", "Error wchuj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (_docMtgObcBox.TextLength == 0)
                MessageBox.Show("Podaj stan licznika motogodzin obciążonych", "Error wchuj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                addDocToBase();
                MessageBox.Show("Document successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void _addSoldier_Click(object sender, EventArgs e)
        {
            if (_soldierNameBox.TextLength == 0)
                MessageBox.Show("Wypełnij pole 'name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_soldierSurnameBox.TextLength == 0)
            {
                MessageBox.Show("Wypełnij pole 'surname'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_fatherNameBox.TextLength == 0)
            {
                MessageBox.Show("Wypełnij pole 'Fathers name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_rankComboBox.SelectedIndex == -1)
                MessageBox.Show("Musisz wybrać stopień wojskowy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_positionComboBox.SelectedIndex == -1)
                MessageBox.Show("Musisz wybrać stanowisko", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_platoonComboBox.SelectedIndex == -1)
                MessageBox.Show("Musisz wybrać pluton", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_birthBox.TextLength == 0)
            {
                MessageBox.Show("Podaj datę urodzenia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_serviceBox.TextLength == 0)
            {
                MessageBox.Show("Podaj datę początku służby", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addSoldierToBase();
                MessageBox.Show("Soldier successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void _showDocButton_Click(object sender, EventArgs e)
        {
            _docsForm docs = new _docsForm(this);
            docs.ShowDialog();
        }
    }
}
