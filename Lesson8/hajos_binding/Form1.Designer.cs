namespace hajos_binding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.szamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerdesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyesValaszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizsgaKérdésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szamDataGridViewTextBoxColumn,
            this.kerdesDataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.v2DataGridViewTextBoxColumn,
            this.v3DataGridViewTextBoxColumn,
            this.kepDataGridViewTextBoxColumn,
            this.helyesValaszDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vizsgaKérdésBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(387, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            this.szamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            this.szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            this.szamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            this.szamDataGridViewTextBoxColumn.Width = 74;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            this.kerdesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            this.kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            this.kerdesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            this.v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            this.v1DataGridViewTextBoxColumn.HeaderText = "V1";
            this.v1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            this.v1DataGridViewTextBoxColumn.Visible = false;
            this.v1DataGridViewTextBoxColumn.Width = 125;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            this.v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            this.v2DataGridViewTextBoxColumn.HeaderText = "V2";
            this.v2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            this.v2DataGridViewTextBoxColumn.Visible = false;
            this.v2DataGridViewTextBoxColumn.Width = 125;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            this.v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            this.v3DataGridViewTextBoxColumn.HeaderText = "V3";
            this.v3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            this.v3DataGridViewTextBoxColumn.Visible = false;
            this.v3DataGridViewTextBoxColumn.Width = 125;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            this.kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            this.kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            this.kepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            this.kepDataGridViewTextBoxColumn.Visible = false;
            this.kepDataGridViewTextBoxColumn.Width = 125;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            this.helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            this.helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            this.helyesValaszDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            this.helyesValaszDataGridViewTextBoxColumn.Visible = false;
            this.helyesValaszDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizsgaKérdésBindingSource
            // 
            this.vizsgaKérdésBindingSource.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(669, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(119, 50);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Megnyitás";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(544, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 50);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource, "Kerdes", true));
            this.textBox1.Location = new System.Drawing.Point(432, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 60);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource, "V1", true));
            this.textBox2.Location = new System.Drawing.Point(432, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 60);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource, "V2", true));
            this.textBox3.Location = new System.Drawing.Point(432, 263);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 60);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource, "V3", true));
            this.textBox4.Location = new System.Drawing.Point(432, 348);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(356, 60);
            this.textBox4.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 394);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 50);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNew.Location = new System.Drawing.Point(146, 394);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(119, 50);
            this.buttonAddNew.TabIndex = 8;
            this.buttonAddNew.Text = "Új";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(280, 394);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(119, 50);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Szerkesztés";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonSave;
        private BindingSource vizsgaKérdésBindingSource;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonDelete;
        private Button buttonAddNew;
        private Button buttonEdit;
    }
}