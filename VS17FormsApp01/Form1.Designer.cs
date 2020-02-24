using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VS17FormsApp01
{
    public partial class _mainForm : Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_mainForm));
            this._showSoldiersB = new System.Windows.Forms.Button();
            this._addSoldierB = new System.Windows.Forms.Button();
            this._showTanksB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._addTankB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._showDocB = new System.Windows.Forms.Button();
            this._addDocB = new System.Windows.Forms.Button();
            this._soldierNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this._soldierSurnameBox = new System.Windows.Forms.TextBox();
            this._fatherNameBox = new System.Windows.Forms.TextBox();
            this._rankComboBox = new System.Windows.Forms.ComboBox();
            this._positionComboBox = new System.Windows.Forms.ComboBox();
            this._platoonComboBox = new System.Windows.Forms.ComboBox();
            this._birthBox = new System.Windows.Forms.TextBox();
            this._serviceBox = new System.Windows.Forms.TextBox();
            this._tankTypeCbox = new System.Windows.Forms.ComboBox();
            this._tankNumberCbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this._docSerialCbox = new System.Windows.Forms.ComboBox();
            this._docNumberBox = new System.Windows.Forms.TextBox();
            this._docMtgOgBox = new System.Windows.Forms.TextBox();
            this._docMtgObcBox = new System.Windows.Forms.TextBox();
            this._docKmBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _showSoldiersB
            // 
            resources.ApplyResources(this._showSoldiersB, "_showSoldiersB");
            this._showSoldiersB.Name = "_showSoldiersB";
            this._showSoldiersB.UseVisualStyleBackColor = true;
            this._showSoldiersB.Click += new System.EventHandler(this._showSoldiers_Click);
            // 
            // _addSoldierB
            // 
            resources.ApplyResources(this._addSoldierB, "_addSoldierB");
            this._addSoldierB.Name = "_addSoldierB";
            this._addSoldierB.UseVisualStyleBackColor = true;
            this._addSoldierB.Click += new System.EventHandler(this._addSoldier_Click);
            // 
            // _showTanksB
            // 
            resources.ApplyResources(this._showTanksB, "_showTanksB");
            this._showTanksB.Name = "_showTanksB";
            this._showTanksB.UseVisualStyleBackColor = true;
            this._showTanksB.Click += new System.EventHandler(this._showTanks_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // _addTankB
            // 
            resources.ApplyResources(this._addTankB, "_addTankB");
            this._addTankB.Name = "_addTankB";
            this._addTankB.UseVisualStyleBackColor = true;
            this._addTankB.Click += new System.EventHandler(this._addTankButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // _showDocB
            // 
            resources.ApplyResources(this._showDocB, "_showDocB");
            this._showDocB.Name = "_showDocB";
            this._showDocB.UseVisualStyleBackColor = true;
            this._showDocB.Click += new System.EventHandler(this._showDocButton_Click);
            // 
            // _addDocB
            // 
            resources.ApplyResources(this._addDocB, "_addDocB");
            this._addDocB.Name = "_addDocB";
            this._addDocB.UseVisualStyleBackColor = true;
            this._addDocB.Click += new System.EventHandler(this._addDocumentButton_Click);
            // 
            // _soldierNameBox
            // 
            resources.ApplyResources(this._soldierNameBox, "_soldierNameBox");
            this._soldierNameBox.Name = "_soldierNameBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // _soldierSurnameBox
            // 
            resources.ApplyResources(this._soldierSurnameBox, "_soldierSurnameBox");
            this._soldierSurnameBox.Name = "_soldierSurnameBox";
            // 
            // _fatherNameBox
            // 
            resources.ApplyResources(this._fatherNameBox, "_fatherNameBox");
            this._fatherNameBox.Name = "_fatherNameBox";
            // 
            // _rankComboBox
            // 
            this._rankComboBox.FormattingEnabled = true;
            this._rankComboBox.Items.AddRange(new object[] {
            resources.GetString("_rankComboBox.Items"),
            resources.GetString("_rankComboBox.Items1"),
            resources.GetString("_rankComboBox.Items2"),
            resources.GetString("_rankComboBox.Items3"),
            resources.GetString("_rankComboBox.Items4"),
            resources.GetString("_rankComboBox.Items5"),
            resources.GetString("_rankComboBox.Items6"),
            resources.GetString("_rankComboBox.Items7"),
            resources.GetString("_rankComboBox.Items8"),
            resources.GetString("_rankComboBox.Items9"),
            resources.GetString("_rankComboBox.Items10"),
            resources.GetString("_rankComboBox.Items11"),
            resources.GetString("_rankComboBox.Items12"),
            resources.GetString("_rankComboBox.Items13"),
            resources.GetString("_rankComboBox.Items14"),
            resources.GetString("_rankComboBox.Items15"),
            resources.GetString("_rankComboBox.Items16"),
            resources.GetString("_rankComboBox.Items17"),
            resources.GetString("_rankComboBox.Items18"),
            resources.GetString("_rankComboBox.Items19"),
            resources.GetString("_rankComboBox.Items20")});
            resources.ApplyResources(this._rankComboBox, "_rankComboBox");
            this._rankComboBox.Name = "_rankComboBox";
            // 
            // _positionComboBox
            // 
            this._positionComboBox.FormattingEnabled = true;
            this._positionComboBox.Items.AddRange(new object[] {
            resources.GetString("_positionComboBox.Items"),
            resources.GetString("_positionComboBox.Items1"),
            resources.GetString("_positionComboBox.Items2"),
            resources.GetString("_positionComboBox.Items3"),
            resources.GetString("_positionComboBox.Items4"),
            resources.GetString("_positionComboBox.Items5"),
            resources.GetString("_positionComboBox.Items6")});
            resources.ApplyResources(this._positionComboBox, "_positionComboBox");
            this._positionComboBox.Name = "_positionComboBox";
            // 
            // _platoonComboBox
            // 
            this._platoonComboBox.FormattingEnabled = true;
            this._platoonComboBox.Items.AddRange(new object[] {
            resources.GetString("_platoonComboBox.Items"),
            resources.GetString("_platoonComboBox.Items1"),
            resources.GetString("_platoonComboBox.Items2"),
            resources.GetString("_platoonComboBox.Items3")});
            resources.ApplyResources(this._platoonComboBox, "_platoonComboBox");
            this._platoonComboBox.Name = "_platoonComboBox";
            // 
            // _birthBox
            // 
            resources.ApplyResources(this._birthBox, "_birthBox");
            this._birthBox.Name = "_birthBox";
            // 
            // _serviceBox
            // 
            resources.ApplyResources(this._serviceBox, "_serviceBox");
            this._serviceBox.Name = "_serviceBox";
            // 
            // _tankTypeCbox
            // 
            this._tankTypeCbox.FormattingEnabled = true;
            this._tankTypeCbox.Items.AddRange(new object[] {
            resources.GetString("_tankTypeCbox.Items"),
            resources.GetString("_tankTypeCbox.Items1")});
            resources.ApplyResources(this._tankTypeCbox, "_tankTypeCbox");
            this._tankTypeCbox.Name = "_tankTypeCbox";
            // 
            // _tankNumberCbox
            // 
            resources.ApplyResources(this._tankNumberCbox, "_tankNumberCbox");
            this._tankNumberCbox.Name = "_tankNumberCbox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // _docSerialCbox
            // 
            this._docSerialCbox.FormattingEnabled = true;
            this._docSerialCbox.Items.AddRange(new object[] {
            resources.GetString("_docSerialCbox.Items"),
            resources.GetString("_docSerialCbox.Items1"),
            resources.GetString("_docSerialCbox.Items2"),
            resources.GetString("_docSerialCbox.Items3"),
            resources.GetString("_docSerialCbox.Items4"),
            resources.GetString("_docSerialCbox.Items5"),
            resources.GetString("_docSerialCbox.Items6"),
            resources.GetString("_docSerialCbox.Items7"),
            resources.GetString("_docSerialCbox.Items8"),
            resources.GetString("_docSerialCbox.Items9"),
            resources.GetString("_docSerialCbox.Items10"),
            resources.GetString("_docSerialCbox.Items11"),
            resources.GetString("_docSerialCbox.Items12"),
            resources.GetString("_docSerialCbox.Items13"),
            resources.GetString("_docSerialCbox.Items14"),
            resources.GetString("_docSerialCbox.Items15"),
            resources.GetString("_docSerialCbox.Items16"),
            resources.GetString("_docSerialCbox.Items17"),
            resources.GetString("_docSerialCbox.Items18"),
            resources.GetString("_docSerialCbox.Items19"),
            resources.GetString("_docSerialCbox.Items20"),
            resources.GetString("_docSerialCbox.Items21"),
            resources.GetString("_docSerialCbox.Items22"),
            resources.GetString("_docSerialCbox.Items23"),
            resources.GetString("_docSerialCbox.Items24")});
            resources.ApplyResources(this._docSerialCbox, "_docSerialCbox");
            this._docSerialCbox.Name = "_docSerialCbox";
            // 
            // _docNumberBox
            // 
            resources.ApplyResources(this._docNumberBox, "_docNumberBox");
            this._docNumberBox.Name = "_docNumberBox";
            // 
            // _docMtgOgBox
            // 
            resources.ApplyResources(this._docMtgOgBox, "_docMtgOgBox");
            this._docMtgOgBox.Name = "_docMtgOgBox";
            // 
            // _docMtgObcBox
            // 
            resources.ApplyResources(this._docMtgObcBox, "_docMtgObcBox");
            this._docMtgObcBox.Name = "_docMtgObcBox";
            // 
            // _docKmBox
            // 
            resources.ApplyResources(this._docKmBox, "_docKmBox");
            this._docKmBox.Name = "_docKmBox";
            // 
            // _mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._docKmBox);
            this.Controls.Add(this._docMtgObcBox);
            this.Controls.Add(this._docMtgOgBox);
            this.Controls.Add(this._docNumberBox);
            this.Controls.Add(this._docSerialCbox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._tankNumberCbox);
            this.Controls.Add(this._tankTypeCbox);
            this.Controls.Add(this._serviceBox);
            this.Controls.Add(this._birthBox);
            this.Controls.Add(this._platoonComboBox);
            this.Controls.Add(this._positionComboBox);
            this.Controls.Add(this._rankComboBox);
            this.Controls.Add(this._fatherNameBox);
            this.Controls.Add(this._soldierSurnameBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._soldierNameBox);
            this.Controls.Add(this._addDocB);
            this.Controls.Add(this._showDocB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._addTankB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._showTanksB);
            this.Controls.Add(this._addSoldierB);
            this.Controls.Add(this._showSoldiersB);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "_mainForm";
            this.Load += new System.EventHandler(this._mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _showSoldiersB;
        private System.Windows.Forms.Button _addSoldierB;
        private System.Windows.Forms.Button _showTanksB;
        private System.Windows.Forms.Label label1;
        private Button _addTankB;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button _showDocB;
        private Button _addDocB;
        private TextBox _soldierNameBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox _soldierSurnameBox;
        private TextBox _fatherNameBox;
        private ComboBox _rankComboBox;
        private ComboBox _positionComboBox;
        private ComboBox _platoonComboBox;
        private TextBox _birthBox;
        private TextBox _serviceBox;
        private ComboBox _tankTypeCbox;
        private TextBox _tankNumberCbox;
        private Label label5;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private ComboBox _docSerialCbox;
        private TextBox _docNumberBox;
        private TextBox _docMtgOgBox;
        private TextBox _docMtgObcBox;
        private TextBox _docKmBox;
    }
}

