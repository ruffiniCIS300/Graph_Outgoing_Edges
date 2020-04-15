namespace Ksu.Cis300.MaximumOutgoingSum
{
    partial class Lab32Form
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
            this.uxButton = new System.Windows.Forms.Button();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxButton
            // 
            this.uxButton.Location = new System.Drawing.Point(46, 84);
            this.uxButton.Name = "uxButton";
            this.uxButton.Size = new System.Drawing.Size(187, 66);
            this.uxButton.TabIndex = 0;
            this.uxButton.Text = "Read a Graph";
            this.uxButton.UseVisualStyleBackColor = true;
            this.uxButton.Click += new System.EventHandler(this.uxButton_Click);
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // Lab32Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Controls.Add(this.uxButton);
            this.Name = "Lab32Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButton;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
    }
}

