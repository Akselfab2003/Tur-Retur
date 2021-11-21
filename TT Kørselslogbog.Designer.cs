namespace menu
{
    partial class Form1
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
            this.ViewOprettedeBruger = new System.Windows.Forms.Button();
            this.ViewUdførterKørsler = new System.Windows.Forms.Button();
            this.BrugerAdministationen = new System.Windows.Forms.Button();
            this.Opret_kørselslog_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewOprettedeBruger
            // 
            this.ViewOprettedeBruger.Location = new System.Drawing.Point(47, 52);
            this.ViewOprettedeBruger.Name = "ViewOprettedeBruger";
            this.ViewOprettedeBruger.Size = new System.Drawing.Size(351, 284);
            this.ViewOprettedeBruger.TabIndex = 0;
            this.ViewOprettedeBruger.Text = "View med de oprettede brugere\r\n";
            this.ViewOprettedeBruger.UseVisualStyleBackColor = true;
            this.ViewOprettedeBruger.Click += new System.EventHandler(this.ViewOprettedeBruger_Click);
            // 
            // ViewUdførterKørsler
            // 
            this.ViewUdførterKørsler.Location = new System.Drawing.Point(455, 52);
            this.ViewUdførterKørsler.Name = "ViewUdførterKørsler";
            this.ViewUdførterKørsler.Size = new System.Drawing.Size(351, 284);
            this.ViewUdførterKørsler.TabIndex = 1;
            this.ViewUdførterKørsler.Text = "View med de udførte kørsler";
            this.ViewUdførterKørsler.UseVisualStyleBackColor = true;
            this.ViewUdførterKørsler.Click += new System.EventHandler(this.ViewUdførterKørsler_Click);
            // 
            // BrugerAdministationen
            // 
            this.BrugerAdministationen.Location = new System.Drawing.Point(47, 371);
            this.BrugerAdministationen.Name = "BrugerAdministationen";
            this.BrugerAdministationen.Size = new System.Drawing.Size(153, 33);
            this.BrugerAdministationen.TabIndex = 2;
            this.BrugerAdministationen.Text = "Opret ny bruger";
            this.BrugerAdministationen.UseVisualStyleBackColor = true;
            this.BrugerAdministationen.Click += new System.EventHandler(this.button3_Click);
            // 
            // Opret_kørselslog_button
            // 
            this.Opret_kørselslog_button.Location = new System.Drawing.Point(229, 371);
            this.Opret_kørselslog_button.Name = "Opret_kørselslog_button";
            this.Opret_kørselslog_button.Size = new System.Drawing.Size(153, 33);
            this.Opret_kørselslog_button.TabIndex = 3;
            this.Opret_kørselslog_button.Text = "Opret kørselslog";
            this.Opret_kørselslog_button.UseVisualStyleBackColor = true;
            this.Opret_kørselslog_button.Click += new System.EventHandler(this.Opret_kørselslog_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 426);
            this.Controls.Add(this.Opret_kørselslog_button);
            this.Controls.Add(this.BrugerAdministationen);
            this.Controls.Add(this.ViewUdførterKørsler);
            this.Controls.Add(this.ViewOprettedeBruger);
            this.Name = "Form1";
            this.Text = "TT Kørselslogbog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewOprettedeBruger;
        private System.Windows.Forms.Button ViewUdførterKørsler;
        private System.Windows.Forms.Button BrugerAdministationen;
        private System.Windows.Forms.Button Opret_kørselslog_button;
    }
}

