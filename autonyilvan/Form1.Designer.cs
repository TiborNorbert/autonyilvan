namespace autonyilvan
{
    partial class Nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nyito));
            this.autoklista = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.rendszamtxt = new System.Windows.Forms.TextBox();
            this.evnum = new System.Windows.Forms.NumericUpDown();
            this.szintxt = new System.Windows.Forms.TextBox();
            this.ujautofel = new System.Windows.Forms.Button();
            this.modosito = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evnum)).BeginInit();
            this.SuspendLayout();
            // 
            // autoklista
            // 
            this.autoklista.Dock = System.Windows.Forms.DockStyle.Left;
            this.autoklista.FormattingEnabled = true;
            this.autoklista.Location = new System.Drawing.Point(0, 0);
            this.autoklista.Name = "autoklista";
            this.autoklista.Size = new System.Drawing.Size(174, 450);
            this.autoklista.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.modosito);
            this.groupBox1.Controls.Add(this.ujautofel);
            this.groupBox1.Controls.Add(this.szintxt);
            this.groupBox1.Controls.Add(this.evnum);
            this.groupBox1.Controls.Add(this.rendszamtxt);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(174, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott Autók Adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Évjárat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "szín";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(113, 29);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(126, 20);
            this.idtxt.TabIndex = 4;
            // 
            // rendszamtxt
            // 
            this.rendszamtxt.Location = new System.Drawing.Point(113, 71);
            this.rendszamtxt.Name = "rendszamtxt";
            this.rendszamtxt.Size = new System.Drawing.Size(124, 20);
            this.rendszamtxt.TabIndex = 5;
            // 
            // evnum
            // 
            this.evnum.Location = new System.Drawing.Point(113, 114);
            this.evnum.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.evnum.Minimum = new decimal(new int[] {
            1916,
            0,
            0,
            0});
            this.evnum.Name = "evnum";
            this.evnum.Size = new System.Drawing.Size(80, 20);
            this.evnum.TabIndex = 6;
            this.evnum.Value = new decimal(new int[] {
            1916,
            0,
            0,
            0});
            // 
            // szintxt
            // 
            this.szintxt.Location = new System.Drawing.Point(113, 150);
            this.szintxt.Name = "szintxt";
            this.szintxt.Size = new System.Drawing.Size(139, 20);
            this.szintxt.TabIndex = 7;
            // 
            // ujautofel
            // 
            this.ujautofel.Location = new System.Drawing.Point(44, 188);
            this.ujautofel.Name = "ujautofel";
            this.ujautofel.Size = new System.Drawing.Size(149, 30);
            this.ujautofel.TabIndex = 8;
            this.ujautofel.Text = "Új autó";
            this.ujautofel.UseVisualStyleBackColor = true;
            this.ujautofel.Click += new System.EventHandler(this.ujautofel_Click);
            // 
            // modosito
            // 
            this.modosito.Location = new System.Drawing.Point(41, 247);
            this.modosito.Name = "modosito";
            this.modosito.Size = new System.Drawing.Size(151, 36);
            this.modosito.TabIndex = 9;
            this.modosito.Text = "Modosito";
            this.modosito.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(260, 188);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(130, 30);
            this.delete.TabIndex = 10;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autoklista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nyito";
            this.Text = "Autók Nyilvántartása";
            this.Load += new System.EventHandler(this.Nyito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox autoklista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button modosito;
        private System.Windows.Forms.Button ujautofel;
        private System.Windows.Forms.TextBox szintxt;
        private System.Windows.Forms.NumericUpDown evnum;
        private System.Windows.Forms.TextBox rendszamtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

