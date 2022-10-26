
namespace WindowsFormsApp2.forms
{
    partial class frminsumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbxunidad = new System.Windows.Forms.ComboBox();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsunidadp = new WindowsFormsApp2.dsunidadp();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxistatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvinsumos = new System.Windows.Forms.DataGridView();
            this.inidinsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsinsumop = new WindowsFormsApp2.dsinsumop();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iNSUMOTableAdapter = new WindowsFormsApp2.dsinsumopTableAdapters.INSUMOTableAdapter();
            this.uNIDADTableAdapter = new WindowsFormsApp2.dsunidadpTableAdapters.UNIDADTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsunidadp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsinsumop)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxunidad
            // 
            this.cmbxunidad.DataSource = this.uNIDADBindingSource;
            this.cmbxunidad.DisplayMember = "un_descripcion";
            this.cmbxunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxunidad.FormattingEnabled = true;
            this.cmbxunidad.Location = new System.Drawing.Point(351, 93);
            this.cmbxunidad.Name = "cmbxunidad";
            this.cmbxunidad.Size = new System.Drawing.Size(121, 21);
            this.cmbxunidad.TabIndex = 3;
            this.cmbxunidad.ValueMember = "un_id_unidad";
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.dsunidadp;
            // 
            // dsunidadp
            // 
            this.dsunidadp.DataSetName = "dsunidadp";
            this.dsunidadp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Unidad:";
            // 
            // cmbxistatus
            // 
            this.cmbxistatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxistatus.FormattingEnabled = true;
            this.cmbxistatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cmbxistatus.Location = new System.Drawing.Point(597, 28);
            this.cmbxistatus.Name = "cmbxistatus";
            this.cmbxistatus.Size = new System.Drawing.Size(121, 21);
            this.cmbxistatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Status:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(643, 152);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 27);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(497, 152);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 27);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // dgvinsumos
            // 
            this.dgvinsumos.AllowUserToAddRows = false;
            this.dgvinsumos.AllowUserToDeleteRows = false;
            this.dgvinsumos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inidinsumoDataGridViewTextBoxColumn,
            this.innombreDataGridViewTextBoxColumn,
            this.incostoDataGridViewTextBoxColumn,
            this.un_descripcion,
            this.instatusDataGridViewTextBoxColumn});
            this.dgvinsumos.DataSource = this.iNSUMOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvinsumos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinsumos.Location = new System.Drawing.Point(12, 197);
            this.dgvinsumos.Name = "dgvinsumos";
            this.dgvinsumos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvinsumos.Size = new System.Drawing.Size(776, 226);
            this.dgvinsumos.TabIndex = 24;
            // 
            // inidinsumoDataGridViewTextBoxColumn
            // 
            this.inidinsumoDataGridViewTextBoxColumn.DataPropertyName = "in_id_insumo";
            this.inidinsumoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.inidinsumoDataGridViewTextBoxColumn.Name = "inidinsumoDataGridViewTextBoxColumn";
            this.inidinsumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innombreDataGridViewTextBoxColumn
            // 
            this.innombreDataGridViewTextBoxColumn.DataPropertyName = "in_nombre";
            this.innombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.innombreDataGridViewTextBoxColumn.Name = "innombreDataGridViewTextBoxColumn";
            this.innombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incostoDataGridViewTextBoxColumn
            // 
            this.incostoDataGridViewTextBoxColumn.DataPropertyName = "in_costo";
            this.incostoDataGridViewTextBoxColumn.HeaderText = "COSTO";
            this.incostoDataGridViewTextBoxColumn.Name = "incostoDataGridViewTextBoxColumn";
            this.incostoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // un_descripcion
            // 
            this.un_descripcion.DataPropertyName = "un_descripcion";
            this.un_descripcion.HeaderText = "UNIDAD";
            this.un_descripcion.Name = "un_descripcion";
            this.un_descripcion.ReadOnly = true;
            // 
            // instatusDataGridViewTextBoxColumn
            // 
            this.instatusDataGridViewTextBoxColumn.DataPropertyName = "in_status";
            this.instatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.instatusDataGridViewTextBoxColumn.Name = "instatusDataGridViewTextBoxColumn";
            this.instatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSUMOBindingSource
            // 
            this.iNSUMOBindingSource.DataMember = "INSUMO";
            this.iNSUMOBindingSource.DataSource = this.dsinsumop;
            // 
            // dsinsumop
            // 
            this.dsinsumop.DataSetName = "dsinsumop";
            this.dsinsumop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(354, 28);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 20);
            this.txtcosto.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(80, 89);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(117, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(80, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id:";
            // 
            // iNSUMOTableAdapter
            // 
            this.iNSUMOTableAdapter.ClearBeforeFill = true;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // frminsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbxunidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxistatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvinsumos);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frminsumo";
            this.Text = "INSUMOS";
            this.Load += new System.EventHandler(this.frminsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsunidadp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsinsumop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxunidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxistatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvinsumos;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dsinsumop dsinsumop;
        private System.Windows.Forms.BindingSource iNSUMOBindingSource;
        private dsinsumopTableAdapters.INSUMOTableAdapter iNSUMOTableAdapter;
        private dsunidadp dsunidadp;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private dsunidadpTableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inidinsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn instatusDataGridViewTextBoxColumn;
    }
}