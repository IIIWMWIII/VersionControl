
namespace Progterv
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
            this.components = new System.ComponentModel.Container();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.createtimer = new System.Windows.Forms.Timer(this.components);
            this.conveyortimer = new System.Windows.Forms.Timer(this.components);
            this.Ballbutton = new System.Windows.Forms.Button();
            this.Carbutton = new System.Windows.Forms.Button();
            this.ComingNext = new System.Windows.Forms.Label();
            this.Ballcolorbutton = new System.Windows.Forms.Button();
            this.presentbutton = new System.Windows.Forms.Button();
            this.boxcolorbutton = new System.Windows.Forms.Button();
            this.ribboncolorbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.Location = new System.Drawing.Point(12, 256);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(776, 182);
            this.Mainpanel.TabIndex = 0;
            // 
            // createtimer
            // 
            this.createtimer.Enabled = true;
            this.createtimer.Interval = 3000;
            this.createtimer.Tick += new System.EventHandler(this.createtimer_Tick);
            // 
            // conveyortimer
            // 
            this.conveyortimer.Enabled = true;
            this.conveyortimer.Interval = 10;
            this.conveyortimer.Tick += new System.EventHandler(this.conveyortimer_Tick);
            // 
            // Ballbutton
            // 
            this.Ballbutton.Location = new System.Drawing.Point(12, 12);
            this.Ballbutton.Name = "Ballbutton";
            this.Ballbutton.Size = new System.Drawing.Size(75, 23);
            this.Ballbutton.TabIndex = 1;
            this.Ballbutton.Text = "Ball";
            this.Ballbutton.UseVisualStyleBackColor = true;
            this.Ballbutton.Click += new System.EventHandler(this.Ballbutton_Click);
            // 
            // Carbutton
            // 
            this.Carbutton.Location = new System.Drawing.Point(93, 12);
            this.Carbutton.Name = "Carbutton";
            this.Carbutton.Size = new System.Drawing.Size(75, 23);
            this.Carbutton.TabIndex = 2;
            this.Carbutton.Text = "Car";
            this.Carbutton.UseVisualStyleBackColor = true;
            this.Carbutton.Click += new System.EventHandler(this.Carbutton_Click);
            // 
            // ComingNext
            // 
            this.ComingNext.AutoSize = true;
            this.ComingNext.Location = new System.Drawing.Point(12, 114);
            this.ComingNext.Name = "ComingNext";
            this.ComingNext.Size = new System.Drawing.Size(67, 13);
            this.ComingNext.TabIndex = 3;
            this.ComingNext.Text = "Coming Next";
            // 
            // Ballcolorbutton
            // 
            this.Ballcolorbutton.BackColor = System.Drawing.Color.Red;
            this.Ballcolorbutton.Location = new System.Drawing.Point(12, 41);
            this.Ballcolorbutton.Name = "Ballcolorbutton";
            this.Ballcolorbutton.Size = new System.Drawing.Size(75, 23);
            this.Ballcolorbutton.TabIndex = 4;
            this.Ballcolorbutton.UseVisualStyleBackColor = false;
            this.Ballcolorbutton.Click += new System.EventHandler(this.Ballcolorbutton_Click);
            // 
            // presentbutton
            // 
            this.presentbutton.Location = new System.Drawing.Point(175, 13);
            this.presentbutton.Name = "presentbutton";
            this.presentbutton.Size = new System.Drawing.Size(75, 23);
            this.presentbutton.TabIndex = 5;
            this.presentbutton.Text = "Present";
            this.presentbutton.UseVisualStyleBackColor = true;
            this.presentbutton.Click += new System.EventHandler(this.presentbutton_Click);
            // 
            // boxcolorbutton
            // 
            this.boxcolorbutton.BackColor = System.Drawing.Color.Blue;
            this.boxcolorbutton.Location = new System.Drawing.Point(175, 42);
            this.boxcolorbutton.Name = "boxcolorbutton";
            this.boxcolorbutton.Size = new System.Drawing.Size(75, 23);
            this.boxcolorbutton.TabIndex = 6;
            this.boxcolorbutton.UseVisualStyleBackColor = false;
            this.boxcolorbutton.Click += new System.EventHandler(this.boxcolorbutton_Click);
            // 
            // ribboncolorbutton
            // 
            this.ribboncolorbutton.BackColor = System.Drawing.Color.Yellow;
            this.ribboncolorbutton.Location = new System.Drawing.Point(175, 72);
            this.ribboncolorbutton.Name = "ribboncolorbutton";
            this.ribboncolorbutton.Size = new System.Drawing.Size(75, 23);
            this.ribboncolorbutton.TabIndex = 7;
            this.ribboncolorbutton.UseVisualStyleBackColor = false;
            this.ribboncolorbutton.Click += new System.EventHandler(this.ribboncolorbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribboncolorbutton);
            this.Controls.Add(this.boxcolorbutton);
            this.Controls.Add(this.presentbutton);
            this.Controls.Add(this.Ballcolorbutton);
            this.Controls.Add(this.ComingNext);
            this.Controls.Add(this.Carbutton);
            this.Controls.Add(this.Ballbutton);
            this.Controls.Add(this.Mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Timer createtimer;
        private System.Windows.Forms.Timer conveyortimer;
        private System.Windows.Forms.Button Ballbutton;
        private System.Windows.Forms.Button Carbutton;
        private System.Windows.Forms.Label ComingNext;
        private System.Windows.Forms.Button Ballcolorbutton;
        private System.Windows.Forms.Button presentbutton;
        private System.Windows.Forms.Button boxcolorbutton;
        private System.Windows.Forms.Button ribboncolorbutton;
    }
}

