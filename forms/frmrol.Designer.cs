namespace WindowsFormsApp2.forms
{
    partial class frmrol
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvrol = new System.Windows.Forms.DataGridView();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRol = new WindowsFormsApp2.DSRol();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rOLTableAdapter = new WindowsFormsApp2.DSRolTableAdapters.ROLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(236, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(63, 30);
            this.txtid.TabIndex = 46;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(236, 77);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(337, 30);
            this.txttipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo De Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID:";
            // 
            // dgvrol
            // 
            this.dgvrol.AllowUserToAddRows = false;
            this.dgvrol.AllowUserToDeleteRows = false;
            this.dgvrol.AutoGenerateColumns = false;
            this.dgvrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.rtipoDataGridViewTextBoxColumn});
            this.dgvrol.DataSource = this.rOLBindingSource;
            this.dgvrol.Location = new System.Drawing.Point(96, 200);
            this.dgvrol.Name = "dgvrol";
            this.dgvrol.ReadOnly = true;
            this.dgvrol.RowTemplate.Height = 24;
            this.dgvrol.Size = new System.Drawing.Size(642, 198);
            this.dgvrol.TabIndex = 47;
            this.dgvrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrol_CellContentClick);
            this.dgvrol.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrol_CellContentClick);
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "r_id";
            this.ridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            this.ridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtipoDataGridViewTextBoxColumn
            // 
            this.rtipoDataGridViewTextBoxColumn.DataPropertyName = "r_tipo";
            this.rtipoDataGridViewTextBoxColumn.HeaderText = "TIPO DE ROL";
            this.rtipoDataGridViewTextBoxColumn.Name = "rtipoDataGridViewTextBoxColumn";
            this.rtipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rtipoDataGridViewTextBoxColumn.Width = 500;
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.dSRol;
            // 
            // dSRol
            // 
            this.dSRol.DataSetName = "DSRol";
            this.dSRol.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(584, 145);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(154, 39);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(407, 145);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(154, 39);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // frmrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvrol);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmrol";
            this.Text = "frmrolcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmrolcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvrol;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private DSRol dSRol;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private DSRolTableAdapters.ROLTableAdapter rOLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtipoDataGridViewTextBoxColumn;
    }
}