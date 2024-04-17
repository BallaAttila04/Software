namespace hajos_binding
{
    partial class FormEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vizsgaKérdésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vizsgaKérdésBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vizsgaKérdésBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vizsgaKérdésBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vizsgaKérdésBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.vizsgaKérdésBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.vizsgaKérdésBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(694, 387);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Ok";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sorszám";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource1, "Szam", true));
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource2, "Kerdes", true));
            this.textBox2.Location = new System.Drawing.Point(12, 106);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(776, 64);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kérdés";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource3, "V1", true));
            this.textBox3.Location = new System.Drawing.Point(12, 217);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(362, 61);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource4, "V2", true));
            this.textBox4.Location = new System.Drawing.Point(391, 217);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(397, 61);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource5, "V3", true));
            this.textBox5.Location = new System.Drawing.Point(12, 309);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(362, 60);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizsgaKérdésBindingSource6, "HelyesValasz", true));
            this.textBox6.Location = new System.Drawing.Point(12, 410);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // vizsgaKérdésBindingSource
            // 
            this.vizsgaKérdésBindingSource.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // vizsgaKérdésBindingSource1
            // 
            this.vizsgaKérdésBindingSource1.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // vizsgaKérdésBindingSource2
            // 
            this.vizsgaKérdésBindingSource2.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // vizsgaKérdésBindingSource3
            // 
            this.vizsgaKérdésBindingSource3.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // vizsgaKérdésBindingSource4
            // 
            this.vizsgaKérdésBindingSource4.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // vizsgaKérdésBindingSource5
            // 
            this.vizsgaKérdésBindingSource5.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // vizsgaKérdésBindingSource6
            // 
            this.vizsgaKérdésBindingSource6.DataSource = typeof(hajos_binding.VizsgaKérdés);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizsgaKérdésBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonClose;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private BindingSource vizsgaKérdésBindingSource;
        private BindingSource vizsgaKérdésBindingSource1;
        private BindingSource vizsgaKérdésBindingSource2;
        private BindingSource vizsgaKérdésBindingSource3;
        private BindingSource vizsgaKérdésBindingSource4;
        private BindingSource vizsgaKérdésBindingSource5;
        private BindingSource vizsgaKérdésBindingSource6;
    }
}