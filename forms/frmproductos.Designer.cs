namespace WindowsFormsApp2.forms
{
    partial class frmproductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgproductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panesitoDataSetcatag = new WindowsFormsApp2.panesitoDataSetcatag();
            this.panesitoDataSetcatagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOTableAdapter1 = new WindowsFormsApp2.panesitoDataSetcatagTableAdapters.PRODUCTOTableAdapter();
            this.pr_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pridcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pridproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetcatag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetcatagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(150, 93);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(302, 26);
            this.txtdescripcion.TabIndex = 20;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(150, 125);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(302, 26);
            this.txtcategoria.TabIndex = 25;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(150, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(78, 26);
            this.txtid.TabIndex = 5;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(320, 20);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(132, 26);
            this.txtprecio.TabIndex = 10;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(503, 106);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(154, 39);
            this.btnGuardarProducto.TabIndex = 40;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 45;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvgproductos
            // 
            this.dvgproductos.AutoGenerateColumns = false;
            this.dvgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pridproductoDataGridViewTextBoxColumn,
            this.prnombreDataGridViewTextBoxColumn,
            this.prdescripcionDataGridViewTextBoxColumn,
            this.pridcategoriaDataGridViewTextBoxColumn,
            this.pr_cantidad,
            this.prprecioDataGridViewTextBoxColumn,
            this.pr_status});
            this.dvgproductos.DataSource = this.pRODUCTOBindingSource4;
            this.dvgproductos.Location = new System.Drawing.Point(-2, 171);
            this.dvgproductos.Name = "dvgproductos";
            this.dvgproductos.RowTemplate.Height = 24;
            this.dvgproductos.Size = new System.Drawing.Size(838, 282);
            this.dvgproductos.TabIndex = 50;
            this.dvgproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproductos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(150, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 26);
            this.txtnombre.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status:";
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Items.AddRange(new object[] {
            "Activo",
            "Deshabilitado"});
            this.cmbxstatus.Location = new System.Drawing.Point(573, 58);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(121, 28);
            this.cmbxstatus.TabIndex = 35;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(573, 14);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(132, 26);
            this.txtcantidad.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad:";
            // 
            // panesitoDataSetcatag
            // 
            this.panesitoDataSetcatag.DataSetName = "panesitoDataSetcatag";
            this.panesitoDataSetcatag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panesitoDataSetcatagBindingSource
            // 
            this.panesitoDataSetcatagBindingSource.DataSource = this.panesitoDataSetcatag;
            this.panesitoDataSetcatagBindingSource.Position = 0;
            // 
            // pRODUCTOBindingSource4
            // 
            this.pRODUCTOBindingSource4.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource4.DataSource = this.panesitoDataSetcatagBindingSource;
            // 
            // pRODUCTOTableAdapter1
            // 
            this.pRODUCTOTableAdapter1.ClearBeforeFill = true;
            // 
            // pr_cantidad
            // 
            this.pr_cantidad.DataPropertyName = "pr_cantidad";
            this.pr_cantidad.HeaderText = "Cantidad";
            this.pr_cantidad.Name = "pr_cantidad";
            // 
            // pr_status
            // 
            this.pr_status.DataPropertyName = "pr_status";
            this.pr_status.HeaderText = "Status";
            this.pr_status.Name = "pr_status";
            // 
            // prprecioDataGridViewTextBoxColumn
            // 
            this.prprecioDataGridViewTextBoxColumn.DataPropertyName = "pr_precio";
            this.prprecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.prprecioDataGridViewTextBoxColumn.Name = "prprecioDataGridViewTextBoxColumn";
            // 
            // pridcategoriaDataGridViewTextBoxColumn
            // 
            this.pridcategoriaDataGridViewTextBoxColumn.DataPropertyName = "pr_id_categoria";
            this.pridcategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.pridcategoriaDataGridViewTextBoxColumn.Name = "pridcategoriaDataGridViewTextBoxColumn";
            // 
            // prdescripcionDataGridViewTextBoxColumn
            // 
            this.prdescripcionDataGridViewTextBoxColumn.DataPropertyName = "pr_descripcion";
            this.prdescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.prdescripcionDataGridViewTextBoxColumn.Name = "prdescripcionDataGridViewTextBoxColumn";
            // 
            // prnombreDataGridViewTextBoxColumn
            // 
            this.prnombreDataGridViewTextBoxColumn.DataPropertyName = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.HeaderText = "Nombre Producto";
            this.prnombreDataGridViewTextBoxColumn.Name = "prnombreDataGridViewTextBoxColumn";
            // 
            // pridproductoDataGridViewTextBoxColumn
            // 
            this.pridproductoDataGridViewTextBoxColumn.DataPropertyName = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.HeaderText = "Id Producto";
            this.pridproductoDataGridViewTextBoxColumn.Name = "pridproductoDataGridViewTextBoxColumn";
            this.pridproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dvgproductos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmproductos";
            this.Text = "V";
            this.Load += new System.EventHandler(this.frmproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetcatag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetcatagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvgproductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxstatus;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label7;
        private panesitoDataSetcatag panesitoDataSetcatag;
        private System.Windows.Forms.BindingSource panesitoDataSetcatagBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource4;
        private panesitoDataSetcatagTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prprecioDataGridViewTextBoxColumn;
    }
}