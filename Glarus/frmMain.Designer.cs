namespace WindowsFormsApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacient = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBatchSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fillLoadOptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missingMappingActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missingSchemaActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пациент";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPacient
            // 
            this.txtPacient.Location = new System.Drawing.Point(75, 33);
            this.txtPacient.Name = "txtPacient";
            this.txtPacient.Size = new System.Drawing.Size(465, 20);
            this.txtPacient.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(546, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 21);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(546, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 21);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Создать";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCommandDataGridViewTextBoxColumn,
            this.insertCommandDataGridViewTextBoxColumn,
            this.selectCommandDataGridViewTextBoxColumn,
            this.updateCommandDataGridViewTextBoxColumn,
            this.updateBatchSizeDataGridViewTextBoxColumn,
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn,
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn,
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn,
            this.fillLoadOptionDataGridViewTextBoxColumn,
            this.missingMappingActionDataGridViewTextBoxColumn,
            this.missingSchemaActionDataGridViewTextBoxColumn,
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(75, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 149);
            this.dataGridView1.TabIndex = 4;
            // 
            // deleteCommandDataGridViewTextBoxColumn
            // 
            this.deleteCommandDataGridViewTextBoxColumn.DataPropertyName = "DeleteCommand";
            this.deleteCommandDataGridViewTextBoxColumn.HeaderText = "DeleteCommand";
            this.deleteCommandDataGridViewTextBoxColumn.Name = "deleteCommandDataGridViewTextBoxColumn";
            this.deleteCommandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insertCommandDataGridViewTextBoxColumn
            // 
            this.insertCommandDataGridViewTextBoxColumn.DataPropertyName = "InsertCommand";
            this.insertCommandDataGridViewTextBoxColumn.HeaderText = "InsertCommand";
            this.insertCommandDataGridViewTextBoxColumn.Name = "insertCommandDataGridViewTextBoxColumn";
            this.insertCommandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectCommandDataGridViewTextBoxColumn
            // 
            this.selectCommandDataGridViewTextBoxColumn.DataPropertyName = "SelectCommand";
            this.selectCommandDataGridViewTextBoxColumn.HeaderText = "SelectCommand";
            this.selectCommandDataGridViewTextBoxColumn.Name = "selectCommandDataGridViewTextBoxColumn";
            this.selectCommandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateCommandDataGridViewTextBoxColumn
            // 
            this.updateCommandDataGridViewTextBoxColumn.DataPropertyName = "UpdateCommand";
            this.updateCommandDataGridViewTextBoxColumn.HeaderText = "UpdateCommand";
            this.updateCommandDataGridViewTextBoxColumn.Name = "updateCommandDataGridViewTextBoxColumn";
            this.updateCommandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateBatchSizeDataGridViewTextBoxColumn
            // 
            this.updateBatchSizeDataGridViewTextBoxColumn.DataPropertyName = "UpdateBatchSize";
            this.updateBatchSizeDataGridViewTextBoxColumn.HeaderText = "UpdateBatchSize";
            this.updateBatchSizeDataGridViewTextBoxColumn.Name = "updateBatchSizeDataGridViewTextBoxColumn";
            this.updateBatchSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acceptChangesDuringFillDataGridViewCheckBoxColumn
            // 
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.DataPropertyName = "AcceptChangesDuringFill";
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.HeaderText = "AcceptChangesDuringFill";
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.Name = "acceptChangesDuringFillDataGridViewCheckBoxColumn";
            this.acceptChangesDuringFillDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // acceptChangesDuringUpdateDataGridViewCheckBoxColumn
            // 
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.DataPropertyName = "AcceptChangesDuringUpdate";
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.HeaderText = "AcceptChangesDuringUpdate";
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.Name = "acceptChangesDuringUpdateDataGridViewCheckBoxColumn";
            this.acceptChangesDuringUpdateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // continueUpdateOnErrorDataGridViewCheckBoxColumn
            // 
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.DataPropertyName = "ContinueUpdateOnError";
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.HeaderText = "ContinueUpdateOnError";
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.Name = "continueUpdateOnErrorDataGridViewCheckBoxColumn";
            this.continueUpdateOnErrorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fillLoadOptionDataGridViewTextBoxColumn
            // 
            this.fillLoadOptionDataGridViewTextBoxColumn.DataPropertyName = "FillLoadOption";
            this.fillLoadOptionDataGridViewTextBoxColumn.HeaderText = "FillLoadOption";
            this.fillLoadOptionDataGridViewTextBoxColumn.Name = "fillLoadOptionDataGridViewTextBoxColumn";
            this.fillLoadOptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // missingMappingActionDataGridViewTextBoxColumn
            // 
            this.missingMappingActionDataGridViewTextBoxColumn.DataPropertyName = "MissingMappingAction";
            this.missingMappingActionDataGridViewTextBoxColumn.HeaderText = "MissingMappingAction";
            this.missingMappingActionDataGridViewTextBoxColumn.Name = "missingMappingActionDataGridViewTextBoxColumn";
            this.missingMappingActionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // missingSchemaActionDataGridViewTextBoxColumn
            // 
            this.missingSchemaActionDataGridViewTextBoxColumn.DataPropertyName = "MissingSchemaAction";
            this.missingSchemaActionDataGridViewTextBoxColumn.HeaderText = "MissingSchemaAction";
            this.missingSchemaActionDataGridViewTextBoxColumn.Name = "missingSchemaActionDataGridViewTextBoxColumn";
            this.missingSchemaActionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnProviderSpecificTypesDataGridViewCheckBoxColumn
            // 
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.DataPropertyName = "ReturnProviderSpecificTypes";
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.HeaderText = "ReturnProviderSpecificTypes";
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.Name = "returnProviderSpecificTypesDataGridViewCheckBoxColumn";
            this.returnProviderSpecificTypesDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MySql.Data.MySqlClient.MySqlDataAdapter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 266);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPacient);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "ПО Гинекологического кабинета \"Гларус\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateBatchSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptChangesDuringFillDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptChangesDuringUpdateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn continueUpdateOnErrorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fillLoadOptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missingMappingActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missingSchemaActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn returnProviderSpecificTypesDataGridViewCheckBoxColumn;
    }
}