namespace VS17FormsApp01
{
    partial class _tanksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /*private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._findTankBox = new System.Windows.Forms.TextBox();
            this._deleteTank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Type,
            this.Number});
            this.listView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1287, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // ID
            // 
            this.id.Text = "ID";
            this.id.Width = 29;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 283;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 154;
            // 
            // _findTankBox
            // 
            this._findTankBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._findTankBox.Location = new System.Drawing.Point(12, 409);
            this._findTankBox.Name = "_searchSoldierBox";
            this._findTankBox.Size = new System.Drawing.Size(175, 26);
            this._findTankBox.TabIndex = 1;
            this._findTankBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this._findTankBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // _deleteTank
            // 
            this._deleteTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._deleteTank.Location = new System.Drawing.Point(334, 409);
            this._deleteTank.Name = "_deleteTankBox";
            this._deleteTank.Size = new System.Drawing.Size(184, 33);
            this._deleteTank.TabIndex = 2;
            this._deleteTank.Text = "Delete";
            this._deleteTank.UseVisualStyleBackColor = true;
            this._deleteTank.Click += new System.EventHandler(this._deleteTank_Click);
            // 
            // _searchSoldier
            // 
            /*this._findTankBox.AutoSize = true;
            this._searchSoldier.Location = new System.Drawing.Point(12, 438);
            this._searchSoldier.Name = "_label1";
            this._searchSoldier.Size = new System.Drawing.Size(41, 13);
            this._searchSoldier.TabIndex = 4;
            this._searchSoldier.Text = "Search";
            // 
            // _oknoSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 467);
            this.Controls.Add(this._findTankBox);
            this.Controls.Add(this._deleteTank);
            //this.Controls.Add(this._searchSoldierBox);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "_tanksForm";
            this.Text = "Tanks LIst";
            this.Load += new System.EventHandler(this._tanksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        */
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilometers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtgOg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtgObc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._findTankBox = new System.Windows.Forms.TextBox();
            this._deleteTank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Type,
            this.Number,
            this.Kilometers,
            this.mtgOg,
            this.mtgObc});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1287, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 30;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 70;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 70;
            // 
            // Kilometers
            // 
            this.Kilometers.Text = "Kilometers";
            this.Kilometers.Width = 90;
            // 
            // mtgOg
            // 
            this.mtgOg.Text = "mtgOg";
            this.mtgOg.Width = 90;
            // 
            // mtgObc
            // 
            this.mtgObc.Text = "mtgObc";
            this.mtgObc.Width = 90;
            // 
            // _findTankBox
            // 
            this._findTankBox.Location = new System.Drawing.Point(12, 415);
            this._findTankBox.Name = "_findTankBox";
            this._findTankBox.Size = new System.Drawing.Size(175, 20);
            this._findTankBox.TabIndex = 1;
            this._findTankBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this._findTankBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // _deleteTank
            // 
            this._deleteTank.Location = new System.Drawing.Point(331, 415);
            this._deleteTank.Name = "_deleteTank";
            this._deleteTank.Size = new System.Drawing.Size(184, 33);
            this._deleteTank.TabIndex = 2;
            this._deleteTank.Text = "Delete";
            this._deleteTank.UseVisualStyleBackColor = true;
            this._deleteTank.Click += new System.EventHandler(this._deleteTank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // _tanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._deleteTank);
            this.Controls.Add(this._findTankBox);
            this.Controls.Add(this.listView1);
            this.Name = "_tanksForm";
            this.Text = "Tanks List";
            this.Load += new System.EventHandler(this._tanksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox _findTankBox;
        private System.Windows.Forms.Button _deleteTank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Kilometers;
        private System.Windows.Forms.ColumnHeader mtgOg;
        private System.Windows.Forms.ColumnHeader mtgObc;
    }
}