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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dvgproductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dataSetproducto = new WindowsFormsApp2.forms.DataSetproducto();
            this.dataSetproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOTableAdapter = new WindowsFormsApp2.forms.DataSetproductoTableAdapters.PRODUCTOTableAdapter();
            this.pridproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pridcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prprecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
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
            this.btnGuardarProducto.Location = new System.Drawing.Point(476, 29);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(154, 39);
            this.btnGuardarProducto.TabIndex = 8;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Deshabilitar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = true;
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
            this.prprecioDataGridViewTextBoxColumn});
            this.dvgproductos.DataSource = this.pRODUCTOBindingSource;
            this.dvgproductos.Location = new System.Drawing.Point(-2, 171);
            this.dvgproductos.Name = "dvgproductos";
            this.dvgproductos.RowTemplate.Height = 24;
            this.dvgproductos.Size = new System.Drawing.Size(838, 282);
            this.dvgproductos.TabIndex = 12;
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
            this.txtnombre.TabIndex = 14;
            // 
            // dataSetproducto
            // 
            this.dataSetproducto.DataSetName = "DataSetproducto";
            this.dataSetproducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetproductoBindingSource
            // 
            this.dataSetproductoBindingSource.DataSource = this.dataSetproducto;
            this.dataSetproductoBindingSource.Position = 0;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataMember = "PRODUCTO";
            this.pRODUCTOBindingSource.DataSource = this.dataSetproducto;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // pridproductoDataGridViewTextBoxColumn
            // 
            this.pridproductoDataGridViewTextBoxColumn.DataPropertyName = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.HeaderText = "pr_id_producto";
            this.pridproductoDataGridViewTextBoxColumn.Name = "pridproductoDataGridViewTextBoxColumn";
            this.pridproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prnombreDataGridViewTextBoxColumn
            // 
            this.prnombreDataGridViewTextBoxColumn.DataPropertyName = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.HeaderText = "pr_nombre";
            this.prnombreDataGridViewTextBoxColumn.Name = "prnombreDataGridViewTextBoxColumn";
            // 
            // prdescripcionDataGridViewTextBoxColumn
            // 
            this.prdescripcionDataGridViewTextBoxColumn.DataPropertyName = "pr_descripcion";
            this.prdescripcionDataGridViewTextBoxColumn.HeaderText = "pr_descripcion";
            this.prdescripcionDataGridViewTextBoxColumn.Name = "prdescripcionDataGridViewTextBoxColumn";
            // 
            // pridcategoriaDataGridViewTextBoxColumn
            // 
            this.pridcategoriaDataGridViewTextBoxColumn.DataPropertyName = "pr_id_categoria";
            this.pridcategoriaDataGridViewTextBoxColumn.HeaderText = "pr_id_categoria";
            this.pridcategoriaDataGridViewTextBoxColumn.Name = "pridcategoriaDataGridViewTextBoxColumn";
            // 
            // prprecioDataGridViewTextBoxColumn
            // 
            this.prprecioDataGridViewTextBoxColumn.DataPropertyName = "pr_precio";
            this.prprecioDataGridViewTextBoxColumn.HeaderText = "pr_precio";
            this.prprecioDataGridViewTextBoxColumn.Name = "prprecioDataGridViewTextBoxColumn";
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 465);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dvgproductos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
            this.Text = "frmproductos";
            this.Load += new System.EventHandler(this.frmproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dvgproductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private DataSetproducto dataSetproducto;
        private System.Windows.Forms.BindingSource dataSetproductoBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private DataSetproductoTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pridcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prprecioDataGridViewTextBoxColumn;
    }
}