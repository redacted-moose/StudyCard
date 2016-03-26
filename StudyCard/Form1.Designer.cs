namespace StudyCard
{
    partial class StudyCard
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
            this.newDeckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newDeckButton
            // 
            this.newDeckButton.Location = new System.Drawing.Point(163, 458);
            this.newDeckButton.Name = "newDeckButton";
            this.newDeckButton.Size = new System.Drawing.Size(145, 53);
            this.newDeckButton.TabIndex = 0;
            this.newDeckButton.Text = "New Deck";
            this.newDeckButton.UseVisualStyleBackColor = true;
            this.newDeckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.newDeckButton);
            this.Name = "StudyCard";
            this.Text = "StudyCard";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newDeckButton;
    }
}

