namespace menu
{
    partial class ViewKørselslog
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
            this.opgaveLabel = new System.Windows.Forms.Label();
            this.OpretKørselslogOpgave = new System.Windows.Forms.TextBox();
            this.OpretKørselslogNavn = new System.Windows.Forms.ComboBox();
            this.OpretKørselslogCancel = new System.Windows.Forms.Button();
            this.OpretKørselslogOk = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.OpretKørselslogNrplade = new System.Windows.Forms.TextBox();
            this.OpretKørselslogDato = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opgaveLabel
            // 
            this.opgaveLabel.AutoSize = true;
            this.opgaveLabel.Location = new System.Drawing.Point(301, 189);
            this.opgaveLabel.Name = "opgaveLabel";
            this.opgaveLabel.Size = new System.Drawing.Size(48, 13);
            this.opgaveLabel.TabIndex = 73;
            this.opgaveLabel.Text = "Opgave:";
            // 
            // OpretKørselslogOpgave
            // 
            this.OpretKørselslogOpgave.Location = new System.Drawing.Point(352, 186);
            this.OpretKørselslogOpgave.Name = "OpretKørselslogOpgave";
            this.OpretKørselslogOpgave.Size = new System.Drawing.Size(100, 20);
            this.OpretKørselslogOpgave.TabIndex = 72;
            // 
            // OpretKørselslogNavn
            // 
            this.OpretKørselslogNavn.FormattingEnabled = true;
            this.OpretKørselslogNavn.Location = new System.Drawing.Point(352, 105);
            this.OpretKørselslogNavn.Name = "OpretKørselslogNavn";
            this.OpretKørselslogNavn.Size = new System.Drawing.Size(100, 21);
            this.OpretKørselslogNavn.TabIndex = 71;
            this.OpretKørselslogNavn.SelectedIndexChanged += new System.EventHandler(this.OpretKørselslogNavn_SelectedIndexChanged);
            // 
            // OpretKørselslogCancel
            // 
            this.OpretKørselslogCancel.Location = new System.Drawing.Point(307, 215);
            this.OpretKørselslogCancel.Name = "OpretKørselslogCancel";
            this.OpretKørselslogCancel.Size = new System.Drawing.Size(70, 20);
            this.OpretKørselslogCancel.TabIndex = 70;
            this.OpretKørselslogCancel.Text = "Cancel";
            this.OpretKørselslogCancel.UseVisualStyleBackColor = true;
            // 
            // OpretKørselslogOk
            // 
            this.OpretKørselslogOk.Location = new System.Drawing.Point(382, 215);
            this.OpretKørselslogOk.Name = "OpretKørselslogOk";
            this.OpretKørselslogOk.Size = new System.Drawing.Size(70, 20);
            this.OpretKørselslogOk.TabIndex = 69;
            this.OpretKørselslogOk.Text = "Ok";
            this.OpretKørselslogOk.UseVisualStyleBackColor = true;
            this.OpretKørselslogOk.Click += new System.EventHandler(this.OpretKørselslogOk_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(301, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 68;
            this.label20.Text = "Nr.plade";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(313, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 67;
            this.label21.Text = "Dato";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(313, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 66;
            this.label22.Text = "Navn";
            // 
            // OpretKørselslogNrplade
            // 
            this.OpretKørselslogNrplade.Location = new System.Drawing.Point(352, 159);
            this.OpretKørselslogNrplade.Name = "OpretKørselslogNrplade";
            this.OpretKørselslogNrplade.Size = new System.Drawing.Size(100, 20);
            this.OpretKørselslogNrplade.TabIndex = 65;
            // 
            // OpretKørselslogDato
            // 
            this.OpretKørselslogDato.Location = new System.Drawing.Point(352, 133);
            this.OpretKørselslogDato.Name = "OpretKørselslogDato";
            this.OpretKørselslogDato.Size = new System.Drawing.Size(100, 20);
            this.OpretKørselslogDato.TabIndex = 64;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(351, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 30);
            this.label23.TabIndex = 63;
            this.label23.Text = "Opret kørsels log:";
            // 
            // ViewKørselslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "ViewKørselslog";
            this.Text = "OpretKørselslog";
            this.Load += new System.EventHandler(this.ViewKørselslog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opgaveLabel;
        private System.Windows.Forms.TextBox OpretKørselslogOpgave;
        private System.Windows.Forms.ComboBox OpretKørselslogNavn;
        private System.Windows.Forms.Button OpretKørselslogCancel;
        private System.Windows.Forms.Button OpretKørselslogOk;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox OpretKørselslogNrplade;
        private System.Windows.Forms.TextBox OpretKørselslogDato;
        private System.Windows.Forms.Label label23;
    }
}