
namespace WindowsFormsApp2.forms
{
    partial class frminsumos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.dgvinsumos = new System.Windows.Forms.DataGridView();
            this.iNSUMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInsumosp = new WindowsFormsApp2.dsInsumosp();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxistatus = new System.Windows.Forms.ComboBox();
            this.iNSUMOTableAdapter = new WindowsFormsApp2.dsInsumospTableAdapters.INSUMOTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxunidad = new System.Windows.Forms.ComboBox();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsunidad = new WindowsFormsApp2.dsunidad();
            this.uNIDADTableAdapter = new WindowsFormsApp2.dsunidadTableAdapters.UNIDADTableAdapter();
            this.inidinsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInsumosp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsunidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(80, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(80, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(117, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(354, 43);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 2;
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
            this.inprecioDataGridViewTextBoxColumn,
            this.in_cantidad,
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
            this.dgvinsumos.Location = new System.Drawing.Point(12, 212);
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
            this.dgvinsumos.TabIndex = 8;
            this.dgvinsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinsumos_CellContentClick);
            // 
            // iNSUMOBindingSource
            // 
            this.iNSUMOBindingSource.DataMember = "INSUMO";
            this.iNSUMOBindingSource.DataSource = this.dsInsumosp;
            // 
            // dsInsumosp
            // 
            this.dsInsumosp.DataSetName = "dsInsumosp";
            this.dsInsumosp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(497, 167);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 27);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(643, 167);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 27);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // cmbxistatus
            // 
            this.cmbxistatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxistatus.FormattingEnabled = true;
            this.cmbxistatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cmbxistatus.Location = new System.Drawing.Point(617, 108);
            this.cmbxistatus.Name = "cmbxistatus";
            this.cmbxistatus.Size = new System.Drawing.Size(121, 21);
            this.cmbxistatus.TabIndex = 5;
            // 
            // iNSUMOTableAdapter
            // 
            this.iNSUMOTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(354, 107);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidad:";
            // 
            // cmbxunidad
            // 
            this.cmbxunidad.DataSource = this.uNIDADBindingSource;
            this.cmbxunidad.DisplayMember = "un_descripcion";
            this.cmbxunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxunidad.FormattingEnabled = true;
            this.cmbxunidad.Location = new System.Drawing.Point(617, 46);
            this.cmbxunidad.Name = "cmbxunidad";
            this.cmbxunidad.Size = new System.Drawing.Size(121, 21);
            this.cmbxunidad.TabIndex = 4;
            this.cmbxunidad.ValueMember = "un_id_unidad";
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.dsunidad;
            // 
            // dsunidad
            // 
            this.dsunidad.DataSetName = "dsunidad";
            this.dsunidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
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
            // inprecioDataGridViewTextBoxColumn
            // 
            this.inprecioDataGridViewTextBoxColumn.DataPropertyName = "in_precio";
            this.inprecioDataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.inprecioDataGridViewTextBoxColumn.Name = "inprecioDataGridViewTextBoxColumn";
            this.inprecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // in_cantidad
            // 
            this.in_cantidad.DataPropertyName = "in_cantidad";
            this.in_cantidad.HeaderText = "CANTIDAD";
            this.in_cantidad.Name = "in_cantidad";
            this.in_cantidad.ReadOnly = true;
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
            // frminsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbxunidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxistatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvinsumos);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frminsumos";
            this.Text = "INSUMOS";
            this.Load += new System.EventHandler(this.frminsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSUMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInsumosp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsunidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.DataGridView dgvinsumos;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxistatus;
        private dsInsumosp dsInsumosp;
        private System.Windows.Forms.BindingSource iNSUMOBindingSource;
        private dsInsumospTableAdapters.INSUMOTableAdapter iNSUMOTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxunidad;
        private dsunidad dsunidad;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private dsunidadTableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inidinsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inprecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn instatusDataGridViewTextBoxColumn;
    }
}