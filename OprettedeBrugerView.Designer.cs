namespace menu
{
    partial class OprettedeBrugerView
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
            this.OprettedeBrugerMedData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OprettedeBrugerMedData)).BeginInit();
            this.SuspendLayout();
            // 
            // OprettedeBrugerMedData
            // 
            this.OprettedeBrugerMedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OprettedeBrugerMedData.Location = new System.Drawing.Point(30, 48);
            this.OprettedeBrugerMedData.Name = "OprettedeBrugerMedData";
            this.OprettedeBrugerMedData.Size = new System.Drawing.Size(737, 346);
            this.OprettedeBrugerMedData.TabIndex = 0;
            this.OprettedeBrugerMedData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OprettedeBrugerMedData_CellContentClick);
            // 
            // OprettedeBrugerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.OprettedeBrugerMedData);
            this.Name = "OprettedeBrugerView";
            this.Text = "OprettedeBrugerView";
            ((System.ComponentModel.ISupportInitialize)(this.OprettedeBrugerMedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OprettedeBrugerMedData;
    }
}