namespace EDDiscovery.Trilateration2
{
    partial class AlienBaseHunt
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
            this.trilaterationControl21 = new EDDiscovery.TrilaterationControl2();
            this.SuspendLayout();
            // 
            // trilaterationControl21
            // 
            this.trilaterationControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trilaterationControl21.Location = new System.Drawing.Point(0, 0);
            this.trilaterationControl21.Name = "trilaterationControl21";
            this.trilaterationControl21.Size = new System.Drawing.Size(876, 426);
            this.trilaterationControl21.TabIndex = 0;
            // 
            // AlienBaseHunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 426);
            this.Controls.Add(this.trilaterationControl21);
            this.Name = "AlienBaseHunt";
            this.Text = "AlienBaseHunt";
            this.ResumeLayout(false);

        }

        #endregion

        public TrilaterationControl2 trilaterationControl21;
    }
}