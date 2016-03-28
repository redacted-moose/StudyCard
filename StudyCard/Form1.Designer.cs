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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.newDeckButton.UseWaitCursor = true;
            this.newDeckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(163, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            // 
            // StudyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.newDeckButton);
            this.Name = "StudyCard";
            this.Text = "StudyCard";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.StudyCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newDeckButton;
        private System.Windows.Forms.ListView listView1;
    }
}

