
namespace ООО__ЭКО_Сити_
{
    partial class Export_to_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_to_excel));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.face_contracts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personal_account_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_contracts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.face_contracts,
            this.personal_account_number,
            this.surname,
            this.number_contracts,
            this.inn,
            this.kpp,
            this.user_email});
            this.dataGridView.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(842, 545);
            this.dataGridView.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 550);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(121, 31);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "&Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Номер договора";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // face_contracts
            // 
            this.face_contracts.DataPropertyName = "face_contracts";
            this.face_contracts.HeaderText = "Тип договора";
            this.face_contracts.Name = "face_contracts";
            this.face_contracts.ReadOnly = true;
            // 
            // personal_account_number
            // 
            this.personal_account_number.DataPropertyName = "personal_account_number";
            this.personal_account_number.HeaderText = "Лицевой счет";
            this.personal_account_number.Name = "personal_account_number";
            this.personal_account_number.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Фамилия ";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // number_contracts
            // 
            this.number_contracts.DataPropertyName = "number_contracts";
            this.number_contracts.HeaderText = "Номер договора";
            this.number_contracts.Name = "number_contracts";
            this.number_contracts.ReadOnly = true;
            // 
            // inn
            // 
            this.inn.DataPropertyName = "inn";
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // kpp
            // 
            this.kpp.DataPropertyName = "kpp";
            this.kpp.HeaderText = "КПП";
            this.kpp.Name = "kpp";
            this.kpp.ReadOnly = true;
            // 
            // user_email
            // 
            this.user_email.DataPropertyName = "user_email";
            this.user_email.HeaderText = "Адрес электронный почты пользователя";
            this.user_email.Name = "user_email";
            this.user_email.ReadOnly = true;
            // 
            // Export_to_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(841, 583);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Export_to_excel";
            this.Text = "Экспорт данных в Excel";
            this.Load += new System.EventHandler(this.Export_to_excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn face_contracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn personal_account_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_contracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_email;
    }
}