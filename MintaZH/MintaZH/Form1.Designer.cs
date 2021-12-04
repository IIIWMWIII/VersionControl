
namespace MintaZH
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
            this.cbEv = new System.Windows.Forms.ComboBox();
            this.Excelbe_ment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEv
            // 
            this.cbEv.FormattingEnabled = true;
            this.cbEv.Location = new System.Drawing.Point(256, 47);
            this.cbEv.Name = "cbEv";
            this.cbEv.Size = new System.Drawing.Size(121, 21);
            this.cbEv.TabIndex = 0;
            // 
            // Excelbe_ment
            // 
            this.Excelbe_ment.Location = new System.Drawing.Point(548, 47);
            this.Excelbe_ment.Name = "Excelbe_ment";
            this.Excelbe_ment.Size = new System.Drawing.Size(75, 23);
            this.Excelbe_ment.TabIndex = 1;
            this.Excelbe_ment.Text = "button1";
            this.Excelbe_ment.UseVisualStyleBackColor = true;
            this.Excelbe_ment.Click += new System.EventHandler(this.Excelbe_ment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excelbe_ment);
            this.Controls.Add(this.cbEv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEv;
        private System.Windows.Forms.Button Excelbe_ment;
    }
}

