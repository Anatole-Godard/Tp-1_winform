﻿
namespace Tp_1
{
    partial class userActions
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
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(12, 260);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(336, 41);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "prendre ticket";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.tiquet_click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 134);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(336, 41);
            this.Button4.TabIndex = 11;
            this.Button4.Text = "prendre pistolet";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.pistol_click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(12, 195);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(336, 41);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "poser pistolet";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.pistol_click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(12, 74);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(336, 41);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "retirer carte";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.card_click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(336, 41);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "inserer carte";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.card_click);
            // 
            // userActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 314);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "userActions";
            this.Text = "userActions";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
    }
}