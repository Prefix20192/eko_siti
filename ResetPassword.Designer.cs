﻿
namespace ООО__ЭКО_Сити_
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.reset_password = new System.Windows.Forms.Button();
            this.now_password = new System.Windows.Forms.TextBox();
            this.new_password = new System.Windows.Forms.TextBox();
            this.new_password_confiurm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(477, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Личный кабинет абонента";
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(276, 84);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Peru;
            this.linkLabel1.Location = new System.Drawing.Point(399, 110);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< В личный кабинет";
            // 
            // reset_password
            // 
            this.reset_password.Location = new System.Drawing.Point(413, 282);
            this.reset_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset_password.Name = "reset_password";
            this.reset_password.Size = new System.Drawing.Size(211, 41);
            this.reset_password.TabIndex = 7;
            this.reset_password.Text = "Сохранить";
            this.reset_password.UseVisualStyleBackColor = true;
            this.reset_password.Click += new System.EventHandler(this.reset_password_Click);
            // 
            // now_password
            // 
            this.now_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.now_password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.now_password.Location = new System.Drawing.Point(339, 153);
            this.now_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.now_password.Name = "now_password";
            this.now_password.Size = new System.Drawing.Size(357, 26);
            this.now_password.TabIndex = 8;
            this.now_password.Text = "Текущий пароль";
            this.now_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.now_password_MouseClick);
            // 
            // new_password
            // 
            this.new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.new_password.Location = new System.Drawing.Point(339, 192);
            this.new_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(357, 26);
            this.new_password.TabIndex = 9;
            this.new_password.Text = "Новый пароль";
            this.new_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.new_password_MouseClick);
            // 
            // new_password_confiurm
            // 
            this.new_password_confiurm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_password_confiurm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.new_password_confiurm.Location = new System.Drawing.Point(339, 231);
            this.new_password_confiurm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_password_confiurm.Name = "new_password_confiurm";
            this.new_password_confiurm.Size = new System.Drawing.Size(357, 26);
            this.new_password_confiurm.TabIndex = 10;
            this.new_password_confiurm.Text = "Подтверждение нового пароля";
            this.new_password_confiurm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.new_password_confiurm_MouseClick);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 348);
            this.Controls.Add(this.new_password_confiurm);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.now_password);
            this.Controls.Add(this.reset_password);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPassword";
            this.Text = "Смена пароля";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button reset_password;
        private System.Windows.Forms.TextBox now_password;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.TextBox new_password_confiurm;
    }
}