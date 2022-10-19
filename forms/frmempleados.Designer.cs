namespace WindowsFormsApp2.forms
{
    partial class frmempleados
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
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtexterior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtinterior = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtamaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtapaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.eMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEmpleadoEdi = new WindowsFormsApp2.DSEmpleadoEdi();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcolonia = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbmunicipio = new System.Windows.Forms.ComboBox();
            this.mUNICIPIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMunicipioEdi = new WindowsFormsApp2.DSMunicipioEdi();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbrol = new System.Windows.Forms.ComboBox();
            this.rOLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRolEdi = new WindowsFormsApp2.DSRolEdi();
            this.mUNICIPIOTableAdapter = new WindowsFormsApp2.DSMunicipioEdiTableAdapters.MUNICIPIOTableAdapter();
            this.eMPLEADOTableAdapter = new WindowsFormsApp2.DSEmpleadoEdiTableAdapters.EMPLEADOTableAdapter();
            this.rOLTableAdapter = new WindowsFormsApp2.DSRolEdiTableAdapters.ROLTableAdapter();
            this.emidempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emcontraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emapellidopaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emapellidomaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emtelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emnuminteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emnumexteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emcoloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emidmunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEmpleadoEdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMunicipioEdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRolEdi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(637, 85);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(337, 30);
            this.txtcalle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Colonia:";
            // 
            // txtexterior
            // 
            this.txtexterior.Location = new System.Drawing.Point(871, 49);
            this.txtexterior.Name = "txtexterior";
            this.txtexterior.Size = new System.Drawing.Size(103, 30);
            this.txtexterior.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(745, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "N. Exterior:";
            // 
            // txtinterior
            // 
            this.txtinterior.Location = new System.Drawing.Point(637, 49);
            this.txtinterior.Name = "txtinterior";
            this.txtinterior.Size = new System.Drawing.Size(102, 30);
            this.txtinterior.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "N. Interior:";
            // 
            // txtamaterno
            // 
            this.txtamaterno.Location = new System.Drawing.Point(159, 149);
            this.txtamaterno.Name = "txtamaterno";
            this.txtamaterno.Size = new System.Drawing.Size(337, 30);
            this.txtamaterno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Apellido P:";
            // 
            // txtapaterno
            // 
            this.txtapaterno.Location = new System.Drawing.Point(159, 185);
            this.txtapaterno.Name = "txtapaterno";
            this.txtapaterno.Size = new System.Drawing.Size(337, 30);
            this.txtapaterno.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Apellido M:";
            // 
            // dgvempleados
            // 
            this.dgvempleados.AllowUserToAddRows = false;
            this.dgvempleados.AllowUserToDeleteRows = false;
            this.dgvempleados.AutoGenerateColumns = false;
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emidempleadoDataGridViewTextBoxColumn,
            this.emusuarioDataGridViewTextBoxColumn,
            this.emcontraseñaDataGridViewTextBoxColumn,
            this.emapellidopaternoDataGridViewTextBoxColumn,
            this.emapellidomaternoDataGridViewTextBoxColumn,
            this.emtelefonoDataGridViewTextBoxColumn,
            this.emcalleDataGridViewTextBoxColumn,
            this.emnuminteriorDataGridViewTextBoxColumn,
            this.emnumexteriorDataGridViewTextBoxColumn,
            this.emcoloniaDataGridViewTextBoxColumn,
            this.emidmunicipioDataGridViewTextBoxColumn,
            this.emridDataGridViewTextBoxColumn,
            this.emstatusDataGridViewTextBoxColumn});
            this.dgvempleados.DataSource = this.eMPLEADOBindingSource;
            this.dgvempleados.Location = new System.Drawing.Point(27, 293);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.ReadOnly = true;
            this.dgvempleados.RowTemplate.Height = 24;
            this.dgvempleados.Size = new System.Drawing.Size(1087, 328);
            this.dgvempleados.TabIndex = 48;
            this.dgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellContentClick);
            // 
            // eMPLEADOBindingSource
            // 
            this.eMPLEADOBindingSource.DataMember = "EMPLEADO";
            this.eMPLEADOBindingSource.DataSource = this.dSEmpleadoEdi;
            // 
            // dSEmpleadoEdi
            // 
            this.dSEmpleadoEdi.DataSetName = "DSEmpleadoEdi";
            this.dSEmpleadoEdi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(820, 239);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(154, 39);
            this.btncancelar.TabIndex = 47;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(643, 239);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(154, 39);
            this.btnguardar.TabIndex = 24;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(342, 37);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(154, 30);
            this.txttelefono.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(159, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(67, 30);
            this.txtid.TabIndex = 42;
            // 
            // txtcolonia
            // 
            this.txtcolonia.Location = new System.Drawing.Point(159, 221);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(337, 30);
            this.txtcolonia.TabIndex = 10;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(159, 73);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(337, 30);
            this.txtusuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
            // 
            // cmbstatus
            // 
            this.cmbstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Activo",
            "Cancelado"});
            this.cmbstatus.Location = new System.Drawing.Point(897, 130);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(121, 33);
            this.cmbstatus.TabIndex = 20;
            // 
            // cmbmunicipio
            // 
            this.cmbmunicipio.DataSource = this.mUNICIPIOBindingSource;
            this.cmbmunicipio.DisplayMember = "mu_descripcion";
            this.cmbmunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmunicipio.FormattingEnabled = true;
            this.cmbmunicipio.Location = new System.Drawing.Point(654, 130);
            this.cmbmunicipio.Name = "cmbmunicipio";
            this.cmbmunicipio.Size = new System.Drawing.Size(137, 33);
            this.cmbmunicipio.TabIndex = 18;
            this.cmbmunicipio.ValueMember = "mu_id_municipio";
            // 
            // mUNICIPIOBindingSource
            // 
            this.mUNICIPIOBindingSource.DataMember = "MUNICIPIO";
            this.mUNICIPIOBindingSource.DataSource = this.dSMunicipioEdi;
            // 
            // dSMunicipioEdi
            // 
            this.dSMunicipioEdi.DataSetName = "DSMunicipioEdi";
            this.dSMunicipioEdi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 60;
            this.label11.Text = "Municipio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(810, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "Status:";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(159, 109);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(337, 30);
            this.txtcontraseña.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 25);
            this.label12.TabIndex = 63;
            this.label12.Text = "Contraseña:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(650, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 25);
            this.label13.TabIndex = 65;
            this.label13.Text = "Rol:";
            // 
            // cmbrol
            // 
            this.cmbrol.DataSource = this.rOLBindingSource;
            this.cmbrol.DisplayMember = "r_tipo";
            this.cmbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Location = new System.Drawing.Point(706, 184);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(237, 33);
            this.cmbrol.TabIndex = 22;
            this.cmbrol.ValueMember = "r_id";
            // 
            // rOLBindingSource
            // 
            this.rOLBindingSource.DataMember = "ROL";
            this.rOLBindingSource.DataSource = this.dSRolEdi;
            // 
            // dSRolEdi
            // 
            this.dSRolEdi.DataSetName = "DSRolEdi";
            this.dSRolEdi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mUNICIPIOTableAdapter
            // 
            this.mUNICIPIOTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLEADOTableAdapter
            // 
            this.eMPLEADOTableAdapter.ClearBeforeFill = true;
            // 
            // rOLTableAdapter
            // 
            this.rOLTableAdapter.ClearBeforeFill = true;
            // 
            // emidempleadoDataGridViewTextBoxColumn
            // 
            this.emidempleadoDataGridViewTextBoxColumn.DataPropertyName = "em_id_empleado";
            this.emidempleadoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.emidempleadoDataGridViewTextBoxColumn.Name = "emidempleadoDataGridViewTextBoxColumn";
            this.emidempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emusuarioDataGridViewTextBoxColumn
            // 
            this.emusuarioDataGridViewTextBoxColumn.DataPropertyName = "em_usuario";
            this.emusuarioDataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.emusuarioDataGridViewTextBoxColumn.Name = "emusuarioDataGridViewTextBoxColumn";
            this.emusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emcontraseñaDataGridViewTextBoxColumn
            // 
            this.emcontraseñaDataGridViewTextBoxColumn.DataPropertyName = "em_contraseña";
            this.emcontraseñaDataGridViewTextBoxColumn.HeaderText = "CONTRASEÑA";
            this.emcontraseñaDataGridViewTextBoxColumn.Name = "emcontraseñaDataGridViewTextBoxColumn";
            this.emcontraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.emcontraseñaDataGridViewTextBoxColumn.Visible = false;
            // 
            // emapellidopaternoDataGridViewTextBoxColumn
            // 
            this.emapellidopaternoDataGridViewTextBoxColumn.DataPropertyName = "em_apellido_paterno";
            this.emapellidopaternoDataGridViewTextBoxColumn.HeaderText = "APELLIDO PATERNO";
            this.emapellidopaternoDataGridViewTextBoxColumn.Name = "emapellidopaternoDataGridViewTextBoxColumn";
            this.emapellidopaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emapellidomaternoDataGridViewTextBoxColumn
            // 
            this.emapellidomaternoDataGridViewTextBoxColumn.DataPropertyName = "em_apellido_materno";
            this.emapellidomaternoDataGridViewTextBoxColumn.HeaderText = "APELLIDO MATERNO";
            this.emapellidomaternoDataGridViewTextBoxColumn.Name = "emapellidomaternoDataGridViewTextBoxColumn";
            this.emapellidomaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emtelefonoDataGridViewTextBoxColumn
            // 
            this.emtelefonoDataGridViewTextBoxColumn.DataPropertyName = "em_telefono";
            this.emtelefonoDataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.emtelefonoDataGridViewTextBoxColumn.Name = "emtelefonoDataGridViewTextBoxColumn";
            this.emtelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emcalleDataGridViewTextBoxColumn
            // 
            this.emcalleDataGridViewTextBoxColumn.DataPropertyName = "em_calle";
            this.emcalleDataGridViewTextBoxColumn.HeaderText = "CALLE";
            this.emcalleDataGridViewTextBoxColumn.Name = "emcalleDataGridViewTextBoxColumn";
            this.emcalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emnuminteriorDataGridViewTextBoxColumn
            // 
            this.emnuminteriorDataGridViewTextBoxColumn.DataPropertyName = "em_num_interior";
            this.emnuminteriorDataGridViewTextBoxColumn.HeaderText = "#INTERIOR";
            this.emnuminteriorDataGridViewTextBoxColumn.Name = "emnuminteriorDataGridViewTextBoxColumn";
            this.emnuminteriorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emnumexteriorDataGridViewTextBoxColumn
            // 
            this.emnumexteriorDataGridViewTextBoxColumn.DataPropertyName = "em_num_exterior";
            this.emnumexteriorDataGridViewTextBoxColumn.HeaderText = "#EXTERIOR";
            this.emnumexteriorDataGridViewTextBoxColumn.Name = "emnumexteriorDataGridViewTextBoxColumn";
            this.emnumexteriorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emcoloniaDataGridViewTextBoxColumn
            // 
            this.emcoloniaDataGridViewTextBoxColumn.DataPropertyName = "em_colonia";
            this.emcoloniaDataGridViewTextBoxColumn.HeaderText = "COLONIA";
            this.emcoloniaDataGridViewTextBoxColumn.Name = "emcoloniaDataGridViewTextBoxColumn";
            this.emcoloniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emidmunicipioDataGridViewTextBoxColumn
            // 
            this.emidmunicipioDataGridViewTextBoxColumn.DataPropertyName = "em_id_municipio";
            this.emidmunicipioDataGridViewTextBoxColumn.HeaderText = "MUNICIPIO";
            this.emidmunicipioDataGridViewTextBoxColumn.Name = "emidmunicipioDataGridViewTextBoxColumn";
            this.emidmunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emridDataGridViewTextBoxColumn
            // 
            this.emridDataGridViewTextBoxColumn.DataPropertyName = "em_r_id";
            this.emridDataGridViewTextBoxColumn.HeaderText = "ROL";
            this.emridDataGridViewTextBoxColumn.Name = "emridDataGridViewTextBoxColumn";
            this.emridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emstatusDataGridViewTextBoxColumn
            // 
            this.emstatusDataGridViewTextBoxColumn.DataPropertyName = "em_status";
            this.emstatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.emstatusDataGridViewTextBoxColumn.Name = "emstatusDataGridViewTextBoxColumn";
            this.emstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 633);
            this.Controls.Add(this.cmbrol);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.cmbmunicipio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtexterior);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtinterior);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtamaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtapaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmempleados";
            this.Text = "frmempleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmempleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEmpleadoEdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUNICIPIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMunicipioEdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRolEdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtexterior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinterior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtamaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtapaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcolonia;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbmunicipio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbrol;
        private DSMunicipioEdi dSMunicipioEdi;
        private System.Windows.Forms.BindingSource mUNICIPIOBindingSource;
        private DSMunicipioEdiTableAdapters.MUNICIPIOTableAdapter mUNICIPIOTableAdapter;
        private DSEmpleadoEdi dSEmpleadoEdi;
        private System.Windows.Forms.BindingSource eMPLEADOBindingSource;
        private DSEmpleadoEdiTableAdapters.EMPLEADOTableAdapter eMPLEADOTableAdapter;
        private DSRolEdi dSRolEdi;
        private System.Windows.Forms.BindingSource rOLBindingSource;
        private DSRolEdiTableAdapters.ROLTableAdapter rOLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emidempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emcontraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emapellidopaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emapellidomaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emtelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emnuminteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emnumexteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emcoloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emidmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emstatusDataGridViewTextBoxColumn;
    }
}