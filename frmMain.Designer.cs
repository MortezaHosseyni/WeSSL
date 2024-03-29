﻿namespace WeSLL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Morteza = new System.Windows.Forms.Label();
            this.lbl_Des = new System.Windows.Forms.Label();
            this.btn_Capture = new System.Windows.Forms.Button();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.btn_SaveLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Des
            // 
            this.txt_Des.Location = new System.Drawing.Point(269, 129);
            this.txt_Des.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.Size = new System.Drawing.Size(315, 29);
            this.txt_Des.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Title.Location = new System.Drawing.Point(315, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(105, 31);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "WeSSL";
            // 
            // lbl_Morteza
            // 
            this.lbl_Morteza.AutoSize = true;
            this.lbl_Morteza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Morteza.Location = new System.Drawing.Point(368, 59);
            this.lbl_Morteza.Name = "lbl_Morteza";
            this.lbl_Morteza.Size = new System.Drawing.Size(125, 18);
            this.lbl_Morteza.TabIndex = 1;
            this.lbl_Morteza.Text = "Morteza Hosseini";
            // 
            // lbl_Des
            // 
            this.lbl_Des.AutoSize = true;
            this.lbl_Des.Location = new System.Drawing.Point(158, 132);
            this.lbl_Des.Name = "lbl_Des";
            this.lbl_Des.Size = new System.Drawing.Size(102, 24);
            this.lbl_Des.TabIndex = 2;
            this.lbl_Des.Text = "Destination";
            // 
            // btn_Capture
            // 
            this.btn_Capture.Location = new System.Drawing.Point(162, 203);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(301, 33);
            this.btn_Capture.TabIndex = 3;
            this.btn_Capture.Text = "Capture SSL Certificate";
            this.btn_Capture.UseVisualStyleBackColor = true;
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // rtb_Log
            // 
            this.rtb_Log.Location = new System.Drawing.Point(12, 272);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(769, 350);
            this.rtb_Log.TabIndex = 4;
            this.rtb_Log.Text = "";
            // 
            // btn_SaveLog
            // 
            this.btn_SaveLog.Location = new System.Drawing.Point(469, 203);
            this.btn_SaveLog.Name = "btn_SaveLog";
            this.btn_SaveLog.Size = new System.Drawing.Size(115, 33);
            this.btn_SaveLog.TabIndex = 3;
            this.btn_SaveLog.Text = "Save Log";
            this.btn_SaveLog.UseVisualStyleBackColor = true;
            this.btn_SaveLog.Click += new System.EventHandler(this.btn_SaveLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 634);
            this.Controls.Add(this.rtb_Log);
            this.Controls.Add(this.btn_SaveLog);
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.lbl_Des);
            this.Controls.Add(this.lbl_Morteza);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Des);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(809, 673);
            this.MinimumSize = new System.Drawing.Size(809, 673);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeSLL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Des;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Morteza;
        private System.Windows.Forms.Label lbl_Des;
        private System.Windows.Forms.Button btn_Capture;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Button btn_SaveLog;
    }
}

