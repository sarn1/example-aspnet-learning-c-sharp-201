namespace Lesson15
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
            this.btnLegacy = new System.Windows.Forms.Button();
            this.btnNewAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLegacy
            // 
            this.btnLegacy.Location = new System.Drawing.Point(12, 12);
            this.btnLegacy.Name = "btnLegacy";
            this.btnLegacy.Size = new System.Drawing.Size(97, 23);
            this.btnLegacy.TabIndex = 0;
            this.btnLegacy.Text = "Legacy Async";
            this.btnLegacy.UseVisualStyleBackColor = true;
            this.btnLegacy.Click += new System.EventHandler(this.btnLegacy_Click);
            // 
            // btnNewAsync
            // 
            this.btnNewAsync.Location = new System.Drawing.Point(115, 12);
            this.btnNewAsync.Name = "btnNewAsync";
            this.btnNewAsync.Size = new System.Drawing.Size(75, 23);
            this.btnNewAsync.TabIndex = 1;
            this.btnNewAsync.Text = "New Async";
            this.btnNewAsync.UseVisualStyleBackColor = true;
            this.btnNewAsync.Click += new System.EventHandler(this.btnNewAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 52);
            this.Controls.Add(this.btnNewAsync);
            this.Controls.Add(this.btnLegacy);
            this.Name = "Form1";
            this.Text = "Lesson15";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLegacy;
        private System.Windows.Forms.Button btnNewAsync;
    }
}

