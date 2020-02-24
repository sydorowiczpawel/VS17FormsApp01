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

            soldiersList.Add(new Soldier()
            {
                name = _soldierNameBox.Text,
                surname = _soldierSurnameBox.Text,
                fathers_name = _fatherNameBox.Text,
                rank = (_rankComboBox.SelectedItem).ToString(),
                position = (_positionComboBox.SelectedItem).ToString(),
                platoon = (_platoonComboBox.SelectedItem).ToString(),
                born = _birthBox.Text,
                serve_since = _serviceBox.Text
            }
            );
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
                serial  =   (_docSerialCbox.SelectedItem).ToString(),
                number  =   _docNumberBox.Text,
                km      =   _docKmBox.Text,
                mtgOg   =   _docMtgOgBox.Text,
                mtgObc  =   _docMtgObcBox.Text
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
