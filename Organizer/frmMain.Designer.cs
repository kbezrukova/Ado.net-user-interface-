
namespace Organizer
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSelectColumns = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbThemeID = new System.Windows.Forms.ComboBox();
            this.btnStoredProcedure = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEventFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(0, 135);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1037, 518);
            this.dgvData.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAdd.Location = new System.Drawing.Point(14, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить заметку";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnEdit.Location = new System.Drawing.Point(158, 67);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать заметку";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDelete.Location = new System.Drawing.Point(309, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbSelectColumns);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbThemeID);
            this.panel1.Controls.Add(this.btnStoredProcedure);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbEventFilter);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 137);
            this.panel1.TabIndex = 4;
            // 
            // cbSelectColumns
            // 
            this.cbSelectColumns.BackColor = System.Drawing.Color.FloralWhite;
            this.cbSelectColumns.FormattingEnabled = true;
            this.cbSelectColumns.Items.AddRange(new object[] {
            "Тема",
            "Событие",
            "Примечание",
            "Ссылка",
            "Текст"});
            this.cbSelectColumns.Location = new System.Drawing.Point(370, 29);
            this.cbSelectColumns.Name = "cbSelectColumns";
            this.cbSelectColumns.Size = new System.Drawing.Size(121, 24);
            this.cbSelectColumns.TabIndex = 14;
            this.cbSelectColumns.SelectedIndexChanged += new System.EventHandler(this.cbSelectColumns_SelectedIndexChanged);
            this.cbSelectColumns.SelectionChangeCommitted += new System.EventHandler(this.cbSelectColumns_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Органайзер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите тему";
            // 
            // cbThemeID
            // 
            this.cbThemeID.BackColor = System.Drawing.Color.FloralWhite;
            this.cbThemeID.FormattingEnabled = true;
            this.cbThemeID.Location = new System.Drawing.Point(763, 31);
            this.cbThemeID.Name = "cbThemeID";
            this.cbThemeID.Size = new System.Drawing.Size(182, 24);
            this.cbThemeID.TabIndex = 11;
            this.cbThemeID.SelectionChangeCommitted += new System.EventHandler(this.cbThemeID_SelectionChangeCommitted);
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.BackColor = System.Drawing.Color.FloralWhite;
            this.btnStoredProcedure.Location = new System.Drawing.Point(788, 67);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(141, 46);
            this.btnStoredProcedure.TabIndex = 9;
            this.btnStoredProcedure.Text = "Найти количество заметок по теме";
            this.btnStoredProcedure.UseVisualStyleBackColor = false;
            this.btnStoredProcedure.Click += new System.EventHandler(this.btnStoredProcedure_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUpdate.Location = new System.Drawing.Point(546, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите название слов для поиска";
            // 
            // tbEventFilter
            // 
            this.tbEventFilter.BackColor = System.Drawing.Color.FloralWhite;
            this.tbEventFilter.Location = new System.Drawing.Point(546, 31);
            this.tbEventFilter.Name = "tbEventFilter";
            this.tbEventFilter.Size = new System.Drawing.Size(154, 22);
            this.tbEventFilter.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выберите название столбца для поиска";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEventFilter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStoredProcedure;
        private System.Windows.Forms.ComboBox cbThemeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectColumns;
        private System.Windows.Forms.Label label4;
    }
}

