﻿namespace GRPlatForm
{
    partial class ServerSetForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtZJPlat = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "总局平台：";
            // 
            // txtZJPlat
            // 
            this.txtZJPlat.Location = new System.Drawing.Point(140, 74);
            this.txtZJPlat.Name = "txtZJPlat";
            this.txtZJPlat.Size = new System.Drawing.Size(303, 21);
            this.txtZJPlat.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(349, 135);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(94, 33);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // ServerSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 235);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtZJPlat);
            this.Controls.Add(this.label2);
            this.Name = "ServerSetForm";
            this.Text = "服务反馈地址地址设置";
            this.Load += new System.EventHandler(this.ServerSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZJPlat;
        private System.Windows.Forms.Button btnSet;
    }
}