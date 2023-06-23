namespace MainApp.Forms
{
    partial class SuggestionForm
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
            this.figureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // figureLabel
            // 
            this.figureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figureLabel.ForeColor = System.Drawing.Color.Blue;
            this.figureLabel.Location = new System.Drawing.Point(0, 0);
            this.figureLabel.Name = "figureLabel";
            this.figureLabel.Size = new System.Drawing.Size(800, 450);
            this.figureLabel.TabIndex = 0;
            this.figureLabel.Text = "123.456";
            this.figureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuggestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.figureLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuggestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SuggestionForm";
            this.Activated += new System.EventHandler(this.SuggestionForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label figureLabel;
    }
}