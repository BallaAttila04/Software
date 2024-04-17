namespace FutoversenyzokMintaZH
{
    partial class formAddNew
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.futóBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.futóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.futóBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.futóBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.futóBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.futóBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.futóBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.futóBindingSource3, "VersenyzoID", true));
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 27);
            this.textBox1.TabIndex = 0;
            // 
            // futóBindingSource1
            // 
            this.futóBindingSource1.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.futóBindingSource2, "Nev", true));
            this.textBox2.Location = new System.Drawing.Point(12, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(358, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.futóBindingSource4, "Nemzetiseg", true));
            this.textBox3.Location = new System.Drawing.Point(12, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(358, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.futóBindingSource5, "EredmenyPerc", true));
            this.textBox4.Location = new System.Drawing.Point(12, 316);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(358, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.futóBindingSource6, "Kategoria", true));
            this.textBox5.Location = new System.Drawing.Point(12, 411);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(358, 27);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Versenyző Azonosítója";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nemzetiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eredmény";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kategória";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(602, 243);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 29);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // futóBindingSource
            // 
            this.futóBindingSource.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // futóBindingSource2
            // 
            this.futóBindingSource2.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // futóBindingSource3
            // 
            this.futóBindingSource3.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // futóBindingSource4
            // 
            this.futóBindingSource4.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // futóBindingSource5
            // 
            this.futóBindingSource5.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // futóBindingSource6
            // 
            this.futóBindingSource6.DataSource = typeof(FutoversenyzokMintaZH.Futó);
            // 
            // formAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "formAddNew";
            this.Text = "formAddNew";
            this.Load += new System.EventHandler(this.formAddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futóBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonOk;
        private BindingSource futóBindingSource;
        private BindingSource futóBindingSource1;
        private BindingSource futóBindingSource3;
        private BindingSource futóBindingSource2;
        private BindingSource futóBindingSource4;
        private BindingSource futóBindingSource5;
        private BindingSource futóBindingSource6;
    }
}