namespace WindowsFormsApp2.forms
{
    partial class frmunidad
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
            this.dgvunidad = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidunidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescunidad = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dsUnidadp = new WindowsFormsApp2.dsUnidadp();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uNIDADTableAdapter = new WindowsFormsApp2.dsUnidadpTableAdapters.UNIDADTableAdapter();
            this.unidunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidadp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvunidad
            // 
            this.dgvunidad.AutoGenerateColumns = false;
            this.dgvunidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unidunidadDataGridViewTextBoxColumn,
            this.undescripcionDataGridViewTextBoxColumn});
            this.dgvunidad.DataSource = this.uNIDADBindingSource;
            this.dgvunidad.Location = new System.Drawing.Point(5, 248);
            this.dgvunidad.Name = "dgvunidad";
            this.dgvunidad.Size = new System.Drawing.Size(791, 199);
            this.dgvunidad.TabIndex = 0;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(496, 189);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(96, 32);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txtidunidad
            // 
            this.txtidunidad.Enabled = false;
            this.txtidunidad.Location = new System.Drawing.Point(98, 50);
            this.txtidunidad.Name = "txtidunidad";
            this.txtidunidad.Size = new System.Drawing.Size(100, 20);
            this.txtidunidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unidad:";
            // 
            // txtdescunidad
            // 
            this.txtdescunidad.Location = new System.Drawing.Point(98, 122);
            this.txtdescunidad.Name = "txtdescunidad";
            this.txtdescunidad.Size = new System.Drawing.Size(100, 20);
            this.txtdescunidad.TabIndex = 5;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(636, 189);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(93, 32);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dsUnidadp
            // 
            this.dsUnidadp.DataSetName = "dsUnidadp";
            this.dsUnidadp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.dsUnidadp;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // unidunidadDataGridViewTextBoxColumn
            // 
            this.unidunidadDataGridViewTextBoxColumn.DataPropertyName = "un_id_unidad";
            this.unidunidadDataGridViewTextBoxColumn.HeaderText = "ID";
            this.unidunidadDataGridViewTextBoxColumn.Name = "unidunidadDataGridViewTextBoxColumn";
            // 
            // undescripcionDataGridViewTextBoxColumn
            // 
            this.undescripcionDataGridViewTextBoxColumn.DataPropertyName = "un_descripcion";
            this.undescripcionDataGridViewTextBoxColumn.HeaderText = "UNIDAD";
            this.undescripcionDataGridViewTextBoxColumn.Name = "undescripcionDataGridViewTextBoxColumn";
            // 
            // frmunidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtdescunidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidunidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvunidad);
            this.Name = "frmunidad";
            this.Text = "frmunidad";
            this.Load += new System.EventHandler(this.frmunidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidadp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvunidad;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidunidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescunidad;
        private System.Windows.Forms.Button btncancelar;
        private dsUnidadp dsUnidadp;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private dsUnidadpTableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn undescripcionDataGridViewTextBoxColumn;
    }
}