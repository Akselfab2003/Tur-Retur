namespace menu
{
    partial class ViewUdførteKørslerForm
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
            this.ViewUdførteKørsler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUdførteKørsler)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewUdførteKørsler
            // 
            this.ViewUdførteKørsler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUdførteKørsler.Location = new System.Drawing.Point(32, 52);
            this.ViewUdførteKørsler.Name = "ViewUdførteKørsler";
            this.ViewUdførteKørsler.Size = new System.Drawing.Size(737, 346);
            this.ViewUdførteKørsler.TabIndex = 1;
            this.ViewUdførteKørsler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewUdførteKørsler_CellContentClick);
            // 
            // ViewUdførteKørslerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewUdførteKørsler);
            this.Name = "ViewUdførteKørslerForm";
            this.Text = "ViewUdførteKørslerForm";
            this.Load += new System.EventHandler(this.ViewUdførteKørslerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewUdførteKørsler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewUdførteKørsler;
    }
}