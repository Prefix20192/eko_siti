
namespace ООО__ЭКО_Сити_
{
    partial class reg_from
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_from));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_send = new System.Windows.Forms.Button();
            this.sing_in = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.password_confiurm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(800, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Всегда актуальная информация\r\nо вашем лицевом счете\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(577, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Личный кабинет абонента";
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(4, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(276, 84);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(404, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "РЕГИСТРАЦИЯ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(312, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "На указанный в форме e-mail придет запрос на \r\n                 подтверждение рег" +
    "истрации.";
            // 
            // register_send
            // 
            this.register_send.Location = new System.Drawing.Point(435, 409);
            this.register_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_send.Name = "register_send";
            this.register_send.Size = new System.Drawing.Size(260, 63);
            this.register_send.TabIndex = 9;
            this.register_send.Text = "Зарегистрироватсья";
            this.register_send.UseVisualStyleBackColor = true;
            this.register_send.Click += new System.EventHandler(this.register_send_Click);
            // 
            // sing_in
            // 
            this.sing_in.Location = new System.Drawing.Point(472, 497);
            this.sing_in.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sing_in.Name = "sing_in";
            this.sing_in.Size = new System.Drawing.Size(183, 64);
            this.sing_in.TabIndex = 10;
            this.sing_in.Text = "У меня уже есть аккаунт!";
            this.sing_in.UseVisualStyleBackColor = true;
            this.sing_in.Click += new System.EventHandler(this.sing_in_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.email.Location = new System.Drawing.Point(412, 286);
            this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(308, 26);
            this.email.TabIndex = 11;
            this.email.Text = "Введите email";
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(412, 325);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(308, 26);
            this.password.TabIndex = 12;
            this.password.Text = "Введите пароль";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // password_confiurm
            // 
            this.password_confiurm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_confiurm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password_confiurm.Location = new System.Drawing.Point(412, 364);
            this.password_confiurm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_confiurm.Name = "password_confiurm";
            this.password_confiurm.Size = new System.Drawing.Size(308, 26);
            this.password_confiurm.TabIndex = 13;
            this.password_confiurm.Text = "Повторите пароль";
            this.password_confiurm.Enter += new System.EventHandler(this.password_confiurm_Enter);
            this.password_confiurm.Leave += new System.EventHandler(this.password_confiurm_Leave);
            // 
            // reg_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1152, 663);
            this.Controls.Add(this.password_confiurm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sing_in);
            this.Controls.Add(this.register_send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "reg_from";
            this.Text = "Форма регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_send;
        private System.Windows.Forms.Button sing_in;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox password_confiurm;
    }
}