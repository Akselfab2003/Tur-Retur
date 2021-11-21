namespace Tur_Retur_kørselslogbog
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textOpretNavn = new System.Windows.Forms.TextBox();
            this.textOpretDato = new System.Windows.Forms.TextBox();
            this.textOpretNrPlade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textRedigerStamDataNrplade = new System.Windows.Forms.TextBox();
            this.textRedigerStamDataDato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OkOpdaterRedigerStamdata = new System.Windows.Forms.Button();
            this.CancelResetFelterOpret = new System.Windows.Forms.Button();
            this.CancelResetFelterRediger = new System.Windows.Forms.Button();
            this.CancelResetFelterSlet = new System.Windows.Forms.Button();
            this.OkSletStamdata = new System.Windows.Forms.Button();
            this.NavnComboBoxRediger = new System.Windows.Forms.ComboBox();
            this.NavnComboBoxSlet = new System.Windows.Forms.ComboBox();
            this.OpretKørselslogDataGridView = new System.Windows.Forms.DataGridView();
            this.OpretKørselslogNavn = new System.Windows.Forms.ComboBox();
            this.OpretKørselslogCancel = new System.Windows.Forms.Button();
            this.OpretKørselslogOk = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.OpretKørselslogNrplade = new System.Windows.Forms.TextBox();
            this.OpretKørselslogDato = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.opgaveLabel = new System.Windows.Forms.Label();
            this.OpretKørselslogOpgave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpretKørselslogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(101, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret stamdata:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textOpretNavn
            // 
            this.textOpretNavn.Location = new System.Drawing.Point(104, 112);
            this.textOpretNavn.Name = "textOpretNavn";
            this.textOpretNavn.Size = new System.Drawing.Size(100, 20);
            this.textOpretNavn.TabIndex = 1;
            this.textOpretNavn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textOpretDato
            // 
            this.textOpretDato.Location = new System.Drawing.Point(104, 138);
            this.textOpretDato.Name = "textOpretDato";
            this.textOpretDato.Size = new System.Drawing.Size(100, 20);
            this.textOpretDato.TabIndex = 2;
            // 
            // textOpretNrPlade
            // 
            this.textOpretNrPlade.Location = new System.Drawing.Point(104, 164);
            this.textOpretNrPlade.Name = "textOpretNrPlade";
            this.textOpretNrPlade.Size = new System.Drawing.Size(100, 20);
            this.textOpretNrPlade.TabIndex = 3;
            this.textOpretNrPlade.TextChanged += new System.EventHandler(this.textOpretNrPlade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Navn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nr.plade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nr.plade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Navn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textRedigerStamDataNrplade
            // 
            this.textRedigerStamDataNrplade.Location = new System.Drawing.Point(300, 164);
            this.textRedigerStamDataNrplade.Name = "textRedigerStamDataNrplade";
            this.textRedigerStamDataNrplade.Size = new System.Drawing.Size(100, 20);
            this.textRedigerStamDataNrplade.TabIndex = 10;
            // 
            // textRedigerStamDataDato
            // 
            this.textRedigerStamDataDato.Location = new System.Drawing.Point(300, 138);
            this.textRedigerStamDataDato.Name = "textRedigerStamDataDato";
            this.textRedigerStamDataDato.Size = new System.Drawing.Size(100, 20);
            this.textRedigerStamDataDato.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(299, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rediger stamdata:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Navn";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(543, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "Slet stamdata:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 225);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(135, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 31);
            this.label17.TabIndex = 29;
            this.label17.Text = "Personale data";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OkOpdaterRedigerStamdata
            // 
            this.OkOpdaterRedigerStamdata.Location = new System.Drawing.Point(361, 190);
            this.OkOpdaterRedigerStamdata.Name = "OkOpdaterRedigerStamdata";
            this.OkOpdaterRedigerStamdata.Size = new System.Drawing.Size(70, 20);
            this.OkOpdaterRedigerStamdata.TabIndex = 31;
            this.OkOpdaterRedigerStamdata.Text = "Ok";
            this.OkOpdaterRedigerStamdata.UseVisualStyleBackColor = true;
            this.OkOpdaterRedigerStamdata.Click += new System.EventHandler(this.OkOpdaterRedigerStamdata_Click);
            // 
            // CancelResetFelterOpret
            // 
            this.CancelResetFelterOpret.Location = new System.Drawing.Point(77, 190);
            this.CancelResetFelterOpret.Name = "CancelResetFelterOpret";
            this.CancelResetFelterOpret.Size = new System.Drawing.Size(70, 20);
            this.CancelResetFelterOpret.TabIndex = 32;
            this.CancelResetFelterOpret.Text = "Cancel";
            this.CancelResetFelterOpret.UseVisualStyleBackColor = true;
            this.CancelResetFelterOpret.Click += new System.EventHandler(this.button3_Click);
            // 
            // CancelResetFelterRediger
            // 
            this.CancelResetFelterRediger.Location = new System.Drawing.Point(286, 190);
            this.CancelResetFelterRediger.Name = "CancelResetFelterRediger";
            this.CancelResetFelterRediger.Size = new System.Drawing.Size(70, 20);
            this.CancelResetFelterRediger.TabIndex = 33;
            this.CancelResetFelterRediger.Text = "Cancel";
            this.CancelResetFelterRediger.UseVisualStyleBackColor = true;
            this.CancelResetFelterRediger.Click += new System.EventHandler(this.CancelResetFelterRediger_Click);
            // 
            // CancelResetFelterSlet
            // 
            this.CancelResetFelterSlet.Location = new System.Drawing.Point(529, 135);
            this.CancelResetFelterSlet.Name = "CancelResetFelterSlet";
            this.CancelResetFelterSlet.Size = new System.Drawing.Size(70, 20);
            this.CancelResetFelterSlet.TabIndex = 35;
            this.CancelResetFelterSlet.Text = "Cancel";
            this.CancelResetFelterSlet.UseVisualStyleBackColor = true;
            this.CancelResetFelterSlet.Click += new System.EventHandler(this.CancelResetFelterSlet_Click);
            // 
            // OkSletStamdata
            // 
            this.OkSletStamdata.Location = new System.Drawing.Point(605, 135);
            this.OkSletStamdata.Name = "OkSletStamdata";
            this.OkSletStamdata.Size = new System.Drawing.Size(70, 20);
            this.OkSletStamdata.TabIndex = 34;
            this.OkSletStamdata.Text = "Ok";
            this.OkSletStamdata.UseVisualStyleBackColor = true;
            this.OkSletStamdata.Click += new System.EventHandler(this.OkSletStamdata_Click);
            // 
            // NavnComboBoxRediger
            // 
            this.NavnComboBoxRediger.FormattingEnabled = true;
            this.NavnComboBoxRediger.Location = new System.Drawing.Point(300, 110);
            this.NavnComboBoxRediger.Name = "NavnComboBoxRediger";
            this.NavnComboBoxRediger.Size = new System.Drawing.Size(100, 21);
            this.NavnComboBoxRediger.TabIndex = 37;
            this.NavnComboBoxRediger.SelectedIndexChanged += new System.EventHandler(this.NavnComboBoxRediger_SelectedIndexChanged);
            // 
            // NavnComboBoxSlet
            // 
            this.NavnComboBoxSlet.FormattingEnabled = true;
            this.NavnComboBoxSlet.Location = new System.Drawing.Point(544, 110);
            this.NavnComboBoxSlet.Name = "NavnComboBoxSlet";
            this.NavnComboBoxSlet.Size = new System.Drawing.Size(100, 21);
            this.NavnComboBoxSlet.TabIndex = 38;
            this.NavnComboBoxSlet.SelectedIndexChanged += new System.EventHandler(this.NavnComboBoxSlet_SelectedIndexChanged);
            // 
            // OpretKørselslogDataGridView
            // 
            this.OpretKørselslogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpretKørselslogDataGridView.Location = new System.Drawing.Point(853, 256);
            this.OpretKørselslogDataGridView.Name = "OpretKørselslogDataGridView";
            this.OpretKørselslogDataGridView.Size = new System.Drawing.Size(434, 225);
            this.OpretKørselslogDataGridView.TabIndex = 48;
            // 
            // OpretKørselslogNavn
            // 
            this.OpretKørselslogNavn.FormattingEnabled = true;
            this.OpretKørselslogNavn.Location = new System.Drawing.Point(1047, 83);
            this.OpretKørselslogNavn.Name = "OpretKørselslogNavn";
            this.OpretKørselslogNavn.Size = new System.Drawing.Size(100, 21);
            this.OpretKørselslogNavn.TabIndex = 59;
            // 
            // OpretKørselslogCancel
            // 
            this.OpretKørselslogCancel.Location = new System.Drawing.Point(1002, 193);
            this.OpretKørselslogCancel.Name = "OpretKørselslogCancel";
            this.OpretKørselslogCancel.Size = new System.Drawing.Size(70, 20);
            this.OpretKørselslogCancel.TabIndex = 58;
            this.OpretKørselslogCancel.Text = "Cancel";
            this.OpretKørselslogCancel.UseVisualStyleBackColor = true;
            this.OpretKørselslogCancel.Click += new System.EventHandler(this.OpretKørselslogCancel_Click);
            // 
            // OpretKørselslogOk
            // 
            this.OpretKørselslogOk.Location = new System.Drawing.Point(1077, 193);
            this.OpretKørselslogOk.Name = "OpretKørselslogOk";
            this.OpretKørselslogOk.Size = new System.Drawing.Size(70, 20);
            this.OpretKørselslogOk.TabIndex = 57;
            this.OpretKørselslogOk.Text = "Ok";
            this.OpretKørselslogOk.UseVisualStyleBackColor = true;
            this.OpretKørselslogOk.Click += new System.EventHandler(this.OpretKørselslogOk_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(996, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Nr.plade";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1008, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Dato";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1008, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "Navn";
            // 
            // OpretKørselslogNrplade
            // 
            this.OpretKørselslogNrplade.Location = new System.Drawing.Point(1047, 137);
            this.OpretKørselslogNrplade.Name = "OpretKørselslogNrplade";
            this.OpretKørselslogNrplade.Size = new System.Drawing.Size(100, 20);
            this.OpretKørselslogNrplade.TabIndex = 51;
            // 
            // OpretKørselslogDato
            // 
            this.OpretKørselslogDato.Location = new System.Drawing.Point(1047, 111);
            this.OpretKørselslogDato.Name = "OpretKørselslogDato";
            this.OpretKørselslogDato.Size = new System.Drawing.Size(100, 20);
            this.OpretKørselslogDato.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(1046, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 30);
            this.label23.TabIndex = 49;
            this.label23.Text = "Opret kørsels log:";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // opgaveLabel
            // 
            this.opgaveLabel.AutoSize = true;
            this.opgaveLabel.Location = new System.Drawing.Point(996, 167);
            this.opgaveLabel.Name = "opgaveLabel";
            this.opgaveLabel.Size = new System.Drawing.Size(48, 13);
            this.opgaveLabel.TabIndex = 61;
            this.opgaveLabel.Text = "Opgave:";
            this.opgaveLabel.Click += new System.EventHandler(this.label24_Click);
            // 
            // OpretKørselslogOpgave
            // 
            this.OpretKørselslogOpgave.Location = new System.Drawing.Point(1047, 164);
            this.OpretKørselslogOpgave.Name = "OpretKørselslogOpgave";
            this.OpretKørselslogOpgave.Size = new System.Drawing.Size(100, 20);
            this.OpretKørselslogOpgave.TabIndex = 60;
            this.OpretKørselslogOpgave.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 237);
            this.Controls.Add(this.opgaveLabel);
            this.Controls.Add(this.OpretKørselslogOpgave);
            this.Controls.Add(this.OpretKørselslogNavn);
            this.Controls.Add(this.OpretKørselslogCancel);
            this.Controls.Add(this.OpretKørselslogOk);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.OpretKørselslogNrplade);
            this.Controls.Add(this.OpretKørselslogDato);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.OpretKørselslogDataGridView);
            this.Controls.Add(this.NavnComboBoxSlet);
            this.Controls.Add(this.NavnComboBoxRediger);
            this.Controls.Add(this.CancelResetFelterSlet);
            this.Controls.Add(this.OkSletStamdata);
            this.Controls.Add(this.CancelResetFelterRediger);
            this.Controls.Add(this.CancelResetFelterOpret);
            this.Controls.Add(this.OkOpdaterRedigerStamdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textRedigerStamDataNrplade);
            this.Controls.Add(this.textRedigerStamDataDato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOpretNrPlade);
            this.Controls.Add(this.textOpretDato);
            this.Controls.Add(this.textOpretNavn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpretKørselslogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOpretNavn;
        private System.Windows.Forms.TextBox textOpretDato;
        private System.Windows.Forms.TextBox textOpretNrPlade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textRedigerStamDataNrplade;
        private System.Windows.Forms.TextBox textRedigerStamDataDato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OkOpdaterRedigerStamdata;
        private System.Windows.Forms.Button CancelResetFelterOpret;
        private System.Windows.Forms.Button CancelResetFelterRediger;
        private System.Windows.Forms.Button CancelResetFelterSlet;
        private System.Windows.Forms.Button OkSletStamdata;
        private System.Windows.Forms.ComboBox NavnComboBoxRediger;
        private System.Windows.Forms.ComboBox NavnComboBoxSlet;
        private System.Windows.Forms.DataGridView OpretKørselslogDataGridView;
        private System.Windows.Forms.ComboBox OpretKørselslogNavn;
        private System.Windows.Forms.Button OpretKørselslogCancel;
        private System.Windows.Forms.Button OpretKørselslogOk;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox OpretKørselslogNrplade;
        private System.Windows.Forms.TextBox OpretKørselslogDato;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label opgaveLabel;
        private System.Windows.Forms.TextBox OpretKørselslogOpgave;
    }
}

