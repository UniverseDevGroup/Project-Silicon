﻿namespace Project_Ports
{
    partial class Crash
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
            this.txtCrash = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCrash
            // 
            this.txtCrash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrash.BackColor = System.Drawing.Color.Black;
            this.txtCrash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCrash.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrash.ForeColor = System.Drawing.Color.Red;
            this.txtCrash.Location = new System.Drawing.Point(12, 12);
            this.txtCrash.MaxLength = 32767;
            this.txtCrash.Name = "txtCrash";
            this.txtCrash.ReadOnly = true;
            this.txtCrash.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCrash.Size = new System.Drawing.Size(693, 441);
            this.txtCrash.TabIndex = 0;
            this.txtCrash.Text = "PortOS.GUI has crashed...\nSYSTEM ERROR: CRASHED\nRebooting PortOS....";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(553, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close (This will be removed)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCrash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crash";
            this.Text = "Crash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Crash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCrash;
        private System.Windows.Forms.Button button1;
    }
}