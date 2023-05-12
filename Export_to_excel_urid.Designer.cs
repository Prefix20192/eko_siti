
namespace ООО__ЭКО_Сити_
{
    partial class Export_to_excel_urid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_to_excel_urid));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.face_contracts = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.face_contracts,
            this.number_contracts,
            this.inn,
            this.kpp,
            this.user_email});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(647, 418);
            this.dataGridView.TabIndex = 0;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(0, 424);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(92, 23);
            this.export.TabIndex = 1;
            this.export.Text = "&Export to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // face_contracts
            // 
            this.face_contracts.DataPropertyName = "face_contracts";
            this.face_contracts.HeaderText = "Тип договора";
            this.face_contracts.Name = "face_contracts";
            this.face_contracts.ReadOnly = true;
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
            // Export_to_excel_urid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 455);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Export_to_excel_urid";
            this.Text = "Юридические договоры";
            this.Load += new System.EventHandler(this.Export_to_excel_urid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn face_contracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_contracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_email;
    }
}