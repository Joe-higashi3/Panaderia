
namespace WindowsFormsApp2.forms
{
    partial class frmtipomov
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidtm = new System.Windows.Forms.TextBox();
            this.dgvtm = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txttm = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dstipomov = new WindowsFormsApp2.dstipomov();
            this.tIPOMOVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_MOVTableAdapter = new WindowsFormsApp2.dstipomovTableAdapters.TIPO_MOVTableAdapter();
            this.tmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstipomov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOMOVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(549, 135);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtidtm
            // 
            this.txtidtm.Enabled = false;
            this.txtidtm.Location = new System.Drawing.Point(72, 51);
            this.txtidtm.Name = "txtidtm";
            this.txtidtm.Size = new System.Drawing.Size(100, 20);
            this.txtidtm.TabIndex = 2;
            // 
            // dgvtm
            // 
            this.dgvtm.AutoGenerateColumns = false;
            this.dgvtm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tmidDataGridViewTextBoxColumn,
            this.tmtipoDataGridViewTextBoxColumn});
            this.dgvtm.DataSource = this.tIPOMOVBindingSource;
            this.dgvtm.Location = new System.Drawing.Point(23, 192);
            this.dgvtm.Name = "dgvtm";
            this.dgvtm.Size = new System.Drawing.Size(718, 209);
            this.dgvtm.TabIndex = 3;
            this.dgvtm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtm_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // txttm
            // 
            this.txttm.Location = new System.Drawing.Point(72, 103);
            this.txttm.Name = "txttm";
            this.txttm.Size = new System.Drawing.Size(112, 20);
            this.txttm.TabIndex = 5;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(666, 135);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dstipomov
            // 
            this.dstipomov.DataSetName = "dstipomov";
            this.dstipomov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOMOVBindingSource
            // 
            this.tIPOMOVBindingSource.DataMember = "TIPO_MOV";
            this.tIPOMOVBindingSource.DataSource = this.dstipomov;
            // 
            // tIPO_MOVTableAdapter
            // 
            this.tIPO_MOVTableAdapter.ClearBeforeFill = true;
            // 
            // tmidDataGridViewTextBoxColumn
            // 
            this.tmidDataGridViewTextBoxColumn.DataPropertyName = "tm_id";
            this.tmidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.tmidDataGridViewTextBoxColumn.Name = "tmidDataGridViewTextBoxColumn";
            // 
            // tmtipoDataGridViewTextBoxColumn
            // 
            this.tmtipoDataGridViewTextBoxColumn.DataPropertyName = "tm_tipo";
            this.tmtipoDataGridViewTextBoxColumn.HeaderText = "TIPO DE MOVIMIENTO";
            this.tmtipoDataGridViewTextBoxColumn.Name = "tmtipoDataGridViewTextBoxColumn";
            // 
            // frmtipomov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txttm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvtm);
            this.Controls.Add(this.txtidtm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Name = "frmtipomov";
            this.Text = "frmtipomov";
            this.Load += new System.EventHandler(this.frmtipomov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstipomov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOMOVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidtm;
        private System.Windows.Forms.DataGridView dgvtm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttm;
        private System.Windows.Forms.Button btncancelar;
        private dstipomov dstipomov;
        private System.Windows.Forms.BindingSource tIPOMOVBindingSource;
        private dstipomovTableAdapters.TIPO_MOVTableAdapter tIPO_MOVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmtipoDataGridViewTextBoxColumn;
    }
}