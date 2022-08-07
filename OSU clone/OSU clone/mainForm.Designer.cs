namespace OSU_clone
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.renderRing = new System.Windows.Forms.Timer(this.components);
            this.moveRing = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // renderRing
            // 
            this.renderRing.Enabled = true;
            this.renderRing.Interval = 25;
            this.renderRing.Tick += new System.EventHandler(this.renderRing_Tick);
            // 
            // moveRing
            // 
            this.moveRing.Enabled = true;
            this.moveRing.Tick += new System.EventHandler(this.moveRing_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(590, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(140, 48);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "Счет: 0";
            // 
            // mainForm
            // 
            this.BackgroundImage = global::OSU_clone.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 434);
            this.Controls.Add(this.scoreText);
            this.MaximumSize = new System.Drawing.Size(843, 490);
            this.MinimumSize = new System.Drawing.Size(843, 490);
            this.Name = "mainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer renderRing;
        private System.Windows.Forms.Timer moveRing;
        private Label scoreText;
    }
}