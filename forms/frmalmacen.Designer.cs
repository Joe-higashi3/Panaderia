namespace WindowsFormsApp2.forms
{
    partial class frmalmacen
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
            this.dgalmacen = new System.Windows.Forms.DataGridView();
            this.apidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMACENPRODUCTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsalmacen2 = new WindowsFormsApp2.dsalmacen2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dsalmacen = new WindowsFormsApp2.dsalmacen();
            this.aLMACENPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLMACEN_PRODUCTOTableAdapter = new WindowsFormsApp2.dsalmacenTableAdapters.ALMACEN_PRODUCTOTableAdapter();
            this.aLMACEN_PRODUCTOTableAdapter1 = new WindowsFormsApp2.dsalmacen2TableAdapters.ALMACEN_PRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENPRODUCTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsalmacen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsalmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENPRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgalmacen
            // 
            this.dgalmacen.AllowUserToDeleteRows = false;
            this.dgalmacen.AutoGenerateColumns = false;
            this.dgalmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgalmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apidDataGridViewTextBoxColumn,
            this.apnombreDataGridViewTextBoxColumn});
            this.dgalmacen.DataSource = this.aLMACENPRODUCTOBindingSource1;
            this.dgalmacen.Location = new System.Drawing.Point(12, 120);
            this.dgalmacen.Name = "dgalmacen";
            this.dgalmacen.ReadOnly = true;
            this.dgalmacen.Size = new System.Drawing.Size(413, 267);
            this.dgalmacen.TabIndex = 0;
            this.dgalmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgalmacen_CellContentClick);
            this.dgalmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgalmacen_CellContentClick);
            // 
            // apidDataGridViewTextBoxColumn
            // 
            this.apidDataGridViewTextBoxColumn.DataPropertyName = "ap_id";
            this.apidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.apidDataGridViewTextBoxColumn.Name = "apidDataGridViewTextBoxColumn";
            this.apidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apnombreDataGridViewTextBoxColumn
            // 
            this.apnombreDataGridViewTextBoxColumn.DataPropertyName = "ap_nombre";
            this.apnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.apnombreDataGridViewTextBoxColumn.Name = "apnombreDataGridViewTextBoxColumn";
            this.apnombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLMACENPRODUCTOBindingSource1
            // 
            this.aLMACENPRODUCTOBindingSource1.DataMember = "ALMACEN_PRODUCTO";
            this.aLMACENPRODUCTOBindingSource1.DataSource = this.dsalmacen2;
            // 
            // dsalmacen2
            // 
            this.dsalmacen2.DataSetName = "dsalmacen2";
            this.dsalmacen2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(96, 23);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(68, 24);
            this.txtid.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(96, 66);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(329, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(207, 21);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 26);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dsalmacen
            // 
            this.dsalmacen.DataSetName = "dsalmacen";
            this.dsalmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLMACENPRODUCTOBindingSource
            // 
            this.aLMACENPRODUCTOBindingSource.DataMember = "ALMACEN_PRODUCTO";
            this.aLMACENPRODUCTOBindingSource.DataSource = this.dsalmacen;
            // 
            // aLMACEN_PRODUCTOTableAdapter
            // 
            this.aLMACEN_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // aLMACEN_PRODUCTOTableAdapter1
            // 
            this.aLMACEN_PRODUCTOTableAdapter1.ClearBeforeFill = true;
            // 
            // frmalmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 399);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgalmacen);
            this.Name = "frmalmacen";
            this.Text = "frmalmacen";
            this.Load += new System.EventHandler(this.frmalmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENPRODUCTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsalmacen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsalmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENPRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgalmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnagregar;
        private dsalmacen dsalmacen;
        private System.Windows.Forms.BindingSource aLMACENPRODUCTOBindingSource;
        private dsalmacenTableAdapters.ALMACEN_PRODUCTOTableAdapter aLMACEN_PRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apnombreDataGridViewTextBoxColumn;
        private dsalmacen2 dsalmacen2;
        private System.Windows.Forms.BindingSource aLMACENPRODUCTOBindingSource1;
        private dsalmacen2TableAdapters.ALMACEN_PRODUCTOTableAdapter aLMACEN_PRODUCTOTableAdapter1;
    }
}