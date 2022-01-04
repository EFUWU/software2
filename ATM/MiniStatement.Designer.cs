
namespace ATM
{
    partial class MiniStatement
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Backbtn = new ePOSOne.btnProduct.Button_WOC();
            this.resulttime_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.NameShowlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.ministatementTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ministatementTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMDATADataSet = new ATM.ATMDATADataSet();
            this.ministatementTableTableAdapter = new ATM.ATMDATADataSetTableAdapters.ministatementTableTableAdapter();
            this.tableAdapterManager = new ATM.ATMDATADataSetTableAdapters.TableAdapterManager();
            this.atmdataTableAdapter1 = new ATM.ATMDATADataSetTableAdapters.atmdataTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ministatementTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministatementTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Backbtn);
            this.groupBox1.Controls.Add(this.resulttime_label);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Controls.Add(this.NameShowlabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Controls.Add(this.ministatementTableDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 584);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Transparent;
            this.Backbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Backbtn.ButtonColor = System.Drawing.Color.Firebrick;
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Location = new System.Drawing.Point(259, 524);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.Backbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Backbtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.Backbtn.Size = new System.Drawing.Size(251, 50);
            this.Backbtn.TabIndex = 29;
            this.Backbtn.Text = "Back";
            this.Backbtn.TextColor = System.Drawing.Color.White;
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // resulttime_label
            // 
            this.resulttime_label.AutoSize = true;
            this.resulttime_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttime_label.Location = new System.Drawing.Point(519, 43);
            this.resulttime_label.Name = "resulttime_label";
            this.resulttime_label.Size = new System.Drawing.Size(0, 24);
            this.resulttime_label.TabIndex = 28;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(450, 43);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(63, 24);
            this.time_label.TabIndex = 27;
            this.time_label.Text = "Time:";
            // 
            // NameShowlabel
            // 
            this.NameShowlabel.AutoSize = true;
            this.NameShowlabel.Location = new System.Drawing.Point(110, 39);
            this.NameShowlabel.Name = "NameShowlabel";
            this.NameShowlabel.Size = new System.Drawing.Size(0, 28);
            this.NameShowlabel.TabIndex = 4;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(24, 39);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(87, 28);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Name :";
            // 
            // ministatementTableDataGridView
            // 
            this.ministatementTableDataGridView.AllowUserToAddRows = false;
            this.ministatementTableDataGridView.AllowUserToDeleteRows = false;
            this.ministatementTableDataGridView.AutoGenerateColumns = false;
            this.ministatementTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ministatementTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ministatementTableDataGridView.DataSource = this.ministatementTableBindingSource;
            this.ministatementTableDataGridView.Location = new System.Drawing.Point(0, 176);
            this.ministatementTableDataGridView.Name = "ministatementTableDataGridView";
            this.ministatementTableDataGridView.ReadOnly = true;
            this.ministatementTableDataGridView.Size = new System.Drawing.Size(869, 325);
            this.ministatementTableDataGridView.TabIndex = 0;
            this.ministatementTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ministatementTableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "accountnum";
            this.dataGridViewTextBoxColumn2.HeaderText = "AccountNum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "operationtype";
            this.dataGridViewTextBoxColumn3.HeaderText = "OperationType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "balance";
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "operationtime";
            this.dataGridViewTextBoxColumn6.HeaderText = "OperationTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ministatementTableBindingSource
            // 
            this.ministatementTableBindingSource.DataMember = "ministatementTable";
            this.ministatementTableBindingSource.DataSource = this.aTMDATADataSet;
            // 
            // aTMDATADataSet
            // 
            this.aTMDATADataSet.DataSetName = "ATMDATADataSet";
            this.aTMDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ministatementTableTableAdapter
            // 
            this.ministatementTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atmdataTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ministatementTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ATM.ATMDATADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // atmdataTableAdapter1
            // 
            this.atmdataTableAdapter1.ClearBeforeFill = true;
            // 
            // MiniStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MiniStatement";
            this.Load += new System.EventHandler(this.MiniStatement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ministatementTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministatementTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDATADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ATMDATADataSet aTMDATADataSet;
        private System.Windows.Forms.BindingSource ministatementTableBindingSource;
        private ATMDATADataSetTableAdapters.ministatementTableTableAdapter ministatementTableTableAdapter;
        private ATMDATADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ministatementTableDataGridView;
        private System.Windows.Forms.Label NameShowlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label resulttime_label;
        private System.Windows.Forms.Label time_label;
        private ePOSOne.btnProduct.Button_WOC Backbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ATMDATADataSetTableAdapters.atmdataTableAdapter atmdataTableAdapter1;
    }
}