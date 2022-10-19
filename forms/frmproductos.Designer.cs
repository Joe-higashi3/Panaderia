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
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetproducto = new WindowsFormsApp2.forms.DataSetproducto();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dataSetproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOTableAdapter = new WindowsFormsApp2.forms.DataSetproductoTableAdapters.PRODUCTOTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panesitoDataSetproductomod1 = new WindowsFormsApp2.panesitoDataSetproductomod1();
            this.pRODUCTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOTableAdapter1 = new WindowsFormsApp2.panesitoDataSetproductomod1TableAdapters.PRODUCTOTableAdapter();
            this.pridproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pridcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetproductomod1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource1)).BeginInit();
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
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(150, 125);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(302, 26);
            this.txtcategoria.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(150, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(78, 26);
            this.txtid.TabIndex = 6;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(320, 20);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(132, 26);
            this.txtprecio.TabIndex = 7;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(503, 106);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(154, 39);
            this.btnGuardarProducto.TabIndex = 8;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
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
            this.prprecioDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.pr_status});
            this.dvgproductos.DataSource = this.pRODUCTOBindingSource1;
            this.dvgproductos.Location = new System.Drawing.Point(-2, 171);
            this.dvgproductos.Name = "dvgproductos";
            this.dvgproductos.RowTemplate.Height = 24;
            this.dvgproductos.Size = new System.Drawing.Size(838, 282);
            this.dvgproductos.TabIndex = 12;
            this.dvgproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproductos_CellContentClick);
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.dataSetproducto;
            // 
            // dataSetproducto
            // 
            this.dataSetproducto.DataSetName = "DataSetproducto";
            this.dataSetproducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtnombre.TabIndex = 14;
            // 
            // dataSetproductoBindingSource
            // 
            this.dataSetproductoBindingSource.DataSource = this.dataSetproducto;
            this.dataSetproductoBindingSource.Position = 0;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
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
            this.cmbxstatus.Location = new System.Drawing.Point(573, 58);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(121, 28);
            this.cmbxstatus.TabIndex = 16;
            // 
            // txtunidad
            // 
            this.txtunidad.Location = new System.Drawing.Point(573, 14);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(132, 26);
            this.txtunidad.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Unidad:";
            // 
            // panesitoDataSetproductomod1
            // 
            this.panesitoDataSetproductomod1.DataSetName = "panesitoDataSetproductomod1";
            this.panesitoDataSetproductomod1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOBindingSource1
            // 
            this.pRODUCTOBindingSource1.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource1.DataSource = this.panesitoDataSetproductomod1;
            // 
            // pRODUCTOTableAdapter1
            // 
            this.pRODUCTOTableAdapter1.ClearBeforeFill = true;
            // 
            // pridproductoDataGridViewTextBoxColumn
            // 
            this.pridproductoDataGridViewTextBoxColumn.DataPropertyName = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.HeaderText = "Id Producto";
            this.pridproductoDataGridViewTextBoxColumn.Name = "pridproductoDataGridViewTextBoxColumn";
            this.pridproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prnombreDataGridViewTextBoxColumn
            // 
            this.prnombreDataGridViewTextBoxColumn.DataPropertyName = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.HeaderText = "Nombre Producto";
            this.prnombreDataGridViewTextBoxColumn.Name = "prnombreDataGridViewTextBoxColumn";
            // 
            // prdescripcionDataGridViewTextBoxColumn
            // 
            this.prdescripcionDataGridViewTextBoxColumn.DataPropertyName = "pr_descripcion";
            this.prdescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.prdescripcionDataGridViewTextBoxColumn.Name = "prdescripcionDataGridViewTextBoxColumn";
            // 
            // pridcategoriaDataGridViewTextBoxColumn
            // 
            this.pridcategoriaDataGridViewTextBoxColumn.DataPropertyName = "pr_id_categoria";
            this.pridcategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.pridcategoriaDataGridViewTextBoxColumn.Name = "pridcategoriaDataGridViewTextBoxColumn";
            // 
            // prprecioDataGridViewTextBoxColumn
            // 
            this.prprecioDataGridViewTextBoxColumn.DataPropertyName = "pr_precio";
            this.prprecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.prprecioDataGridViewTextBoxColumn.Name = "prprecioDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pr_id_unidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // pr_status
            // 
            this.pr_status.DataPropertyName = "pr_status";
            this.pr_status.HeaderText = "Status";
            this.pr_status.Name = "pr_status";
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtunidad);
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
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetproductomod1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource1)).EndInit();
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
        private DataSetproducto dataSetproducto;
        private System.Windows.Forms.BindingSource dataSetproductoBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private DataSetproductoTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxstatus;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.Label label7;
        private panesitoDataSetproductomod1 panesitoDataSetproductomod1;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource1;
        private panesitoDataSetproductomod1TableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prprecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_status;
    }
}