namespace WindowsFormsApp2
{
    partial class frmpedidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.fKPEDIDODEpdid36B12243BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSetPedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSetPed = new WindowsFormsApp2.panesitoDataSetPed();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtclienteid = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pEDIDOTableAdapter = new WindowsFormsApp2.panesitoDataSet4TableAdapters.PEDIDOTableAdapter();
            this.pEDIDO_DETALLETableAdapter = new WindowsFormsApp2.panesitoDataSet4TableAdapters.PEDIDO_DETALLETableAdapter();
            this.pEDIDOTableAdapter1 = new WindowsFormsApp2.panesitoDataSetPedTableAdapters.PEDIDOTableAdapter();
            this.fKPEDIDODEpdid36B12243BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pEDIDO_DETALLETableAdapter1 = new WindowsFormsApp2.panesitoDataSetPedTableAdapters.PEDIDO_DETALLETableAdapter();
            this.pEDIDOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet5 = new WindowsFormsApp2.panesitoDataSet5();
            this.panesitoDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet6 = new WindowsFormsApp2.panesitoDataSet6();
            this.panesitoDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pEDIDOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pEDIDOTableAdapter2 = new WindowsFormsApp2.panesitoDataSet5TableAdapters.PEDIDOTableAdapter();
            this.peidpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peidclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peidempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pefechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peestatuspedidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPEDIDODEpdid36B12243BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetPedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPEDIDODEpdid36B12243BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(94, 69);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(204, 26);
            this.dtpfecha.TabIndex = 38;
            this.dtpfecha.UseWaitCursor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(458, 58);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(133, 29);
            this.btnsalir.TabIndex = 37;
            this.btnsalir.Text = "Mostrar";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(458, 5);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(133, 29);
            this.btneliminar.TabIndex = 36;
            this.btneliminar.Text = "Deshabilitar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(314, 58);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(133, 29);
            this.btnactualizar.TabIndex = 35;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(314, 5);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(133, 29);
            this.btninsertar.TabIndex = 33;
            this.btninsertar.Text = "Guardar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.AllowUserToAddRows = false;
            this.dgvarticulos.AllowUserToDeleteRows = false;
            this.dgvarticulos.AutoGenerateColumns = false;
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peidpedidoDataGridViewTextBoxColumn,
            this.peidclienteDataGridViewTextBoxColumn,
            this.peidempleadoDataGridViewTextBoxColumn,
            this.pefechaDataGridViewTextBoxColumn,
            this.peestatuspedidoDataGridViewCheckBoxColumn});
            this.dgvarticulos.DataSource = this.pEDIDOBindingSource2;
            this.dgvarticulos.Location = new System.Drawing.Point(39, 136);
            this.dgvarticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.RowTemplate.Height = 24;
            this.dgvarticulos.Size = new System.Drawing.Size(552, 250);
            this.dgvarticulos.TabIndex = 34;
            this.dgvarticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarticulos_CellContentClick);
            // 
            // fKPEDIDODEpdid36B12243BindingSource1
            // 
            this.fKPEDIDODEpdid36B12243BindingSource1.DataMember = "FK__PEDIDO_DE__pd_id__36B12243";
            this.fKPEDIDODEpdid36B12243BindingSource1.DataSource = this.pEDIDOBindingSource;
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.panesitoDataSetPedBindingSource;
            // 
            // panesitoDataSetPedBindingSource
            // 
            this.panesitoDataSetPedBindingSource.DataSource = this.panesitoDataSetPed;
            this.panesitoDataSetPedBindingSource.Position = 0;
            // 
            // panesitoDataSetPed
            // 
            this.panesitoDataSetPed.DataSetName = "panesitoDataSetPed";
            this.panesitoDataSetPed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(234, 4);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(64, 20);
            this.txtstatus.TabIndex = 32;
            // 
            // txtclienteid
            // 
            this.txtclienteid.Location = new System.Drawing.Point(94, 39);
            this.txtclienteid.Margin = new System.Windows.Forms.Padding(2);
            this.txtclienteid.Name = "txtclienteid";
            this.txtclienteid.Size = new System.Drawing.Size(204, 20);
            this.txtclienteid.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 5);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(63, 20);
            this.txtid.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Estatus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // pEDIDO_DETALLETableAdapter
            // 
            this.pEDIDO_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // pEDIDOTableAdapter1
            // 
            this.pEDIDOTableAdapter1.ClearBeforeFill = true;
            // 
            // fKPEDIDODEpdid36B12243BindingSource
            // 
            this.fKPEDIDODEpdid36B12243BindingSource.DataMember = "FK__PEDIDO_DE__pd_id__36B12243";
            this.fKPEDIDODEpdid36B12243BindingSource.DataSource = this.pEDIDOBindingSource;
            // 
            // pEDIDO_DETALLETableAdapter1
            // 
            this.pEDIDO_DETALLETableAdapter1.ClearBeforeFill = true;
            // 
            // pEDIDOBindingSource1
            // 
            this.pEDIDOBindingSource1.DataMember = "PEDIDO";
            this.pEDIDOBindingSource1.DataSource = this.panesitoDataSetPedBindingSource;
            // 
            // panesitoDataSet5
            // 
            this.panesitoDataSet5.DataSetName = "panesitoDataSet5";
            this.panesitoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panesitoDataSet5BindingSource
            // 
            this.panesitoDataSet5BindingSource.DataSource = this.panesitoDataSet5;
            this.panesitoDataSet5BindingSource.Position = 0;
            // 
            // panesitoDataSet6
            // 
            this.panesitoDataSet6.DataSetName = "panesitoDataSet6";
            this.panesitoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panesitoDataSet6BindingSource
            // 
            this.panesitoDataSet6BindingSource.DataSource = this.panesitoDataSet6;
            this.panesitoDataSet6BindingSource.Position = 0;
            // 
            // pEDIDOBindingSource2
            // 
            this.pEDIDOBindingSource2.DataMember = "PEDIDO";
            this.pEDIDOBindingSource2.DataSource = this.panesitoDataSet5BindingSource;
            // 
            // pEDIDOTableAdapter2
            // 
            this.pEDIDOTableAdapter2.ClearBeforeFill = true;
            // 
            // peidpedidoDataGridViewTextBoxColumn
            // 
            this.peidpedidoDataGridViewTextBoxColumn.DataPropertyName = "pe_id_pedido";
            this.peidpedidoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.peidpedidoDataGridViewTextBoxColumn.Name = "peidpedidoDataGridViewTextBoxColumn";
            this.peidpedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peidclienteDataGridViewTextBoxColumn
            // 
            this.peidclienteDataGridViewTextBoxColumn.DataPropertyName = "pe_id_cliente";
            this.peidclienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.peidclienteDataGridViewTextBoxColumn.Name = "peidclienteDataGridViewTextBoxColumn";
            this.peidclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peidempleadoDataGridViewTextBoxColumn
            // 
            this.peidempleadoDataGridViewTextBoxColumn.DataPropertyName = "pe_id_empleado";
            this.peidempleadoDataGridViewTextBoxColumn.HeaderText = "ID Empleado";
            this.peidempleadoDataGridViewTextBoxColumn.Name = "peidempleadoDataGridViewTextBoxColumn";
            this.peidempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pefechaDataGridViewTextBoxColumn
            // 
            this.pefechaDataGridViewTextBoxColumn.DataPropertyName = "pe_fecha";
            this.pefechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.pefechaDataGridViewTextBoxColumn.Name = "pefechaDataGridViewTextBoxColumn";
            this.pefechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peestatuspedidoDataGridViewCheckBoxColumn
            // 
            this.peestatuspedidoDataGridViewCheckBoxColumn.DataPropertyName = "pe_estatus_pedido";
            this.peestatuspedidoDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.peestatuspedidoDataGridViewCheckBoxColumn.Name = "peestatuspedidoDataGridViewCheckBoxColumn";
            this.peestatuspedidoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(123, 99);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(175, 20);
            this.txtEmpleado.TabIndex = 40;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Empleado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmpedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 388);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtclienteid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmpedidos";
            this.Text = "frmpedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPEDIDODEpdid36B12243BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetPedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSetPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPEDIDODEpdid36B12243BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtclienteid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private panesitoDataSet4TableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private panesitoDataSet4TableAdapters.PEDIDO_DETALLETableAdapter pEDIDO_DETALLETableAdapter;
        private System.Windows.Forms.BindingSource panesitoDataSetPedBindingSource;
        private panesitoDataSetPed panesitoDataSetPed;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private panesitoDataSetPedTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter1;
        private System.Windows.Forms.BindingSource fKPEDIDODEpdid36B12243BindingSource;
        private panesitoDataSetPedTableAdapters.PEDIDO_DETALLETableAdapter pEDIDO_DETALLETableAdapter1;
        private System.Windows.Forms.BindingSource fKPEDIDODEpdid36B12243BindingSource1;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource1;
        private System.Windows.Forms.BindingSource panesitoDataSet6BindingSource;
        private panesitoDataSet6 panesitoDataSet6;
        private panesitoDataSet5 panesitoDataSet5;
        private System.Windows.Forms.BindingSource panesitoDataSet5BindingSource;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource2;
        private panesitoDataSet5TableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn peidpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peidclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peidempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pefechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn peestatuspedidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label3;
    }
}

