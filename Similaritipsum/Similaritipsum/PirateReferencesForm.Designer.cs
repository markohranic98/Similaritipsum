namespace Similaritipsum
{
    partial class PirateReferencesForm
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
            this.pirateDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pirateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pirateDataGridView
            // 
            this.pirateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pirateDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pirateDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pirateDataGridView.Name = "pirateDataGridView";
            this.pirateDataGridView.Size = new System.Drawing.Size(1063, 348);
            this.pirateDataGridView.TabIndex = 0;
            // 
            // PirateReferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 348);
            this.Controls.Add(this.pirateDataGridView);
            this.Name = "PirateReferencesForm";
            this.Text = "Pirate references";
            this.Load += new System.EventHandler(this.PirateReferencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pirateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pirateDataGridView;
    }
}