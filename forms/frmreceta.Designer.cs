namespace WindowsFormsApp2.forms
{
    partial class frmreceta
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ridrecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitoDataSet3 = new WindowsFormsApp2.panesitoDataSet3();
            this.rECETATableAdapter = new WindowsFormsApp2.panesitoDataSet3TableAdapters.RECETATableAdapter();
            this.txtid_receta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cbxgrupo = new System.Windows.Forms.ComboBox();
            this.gRUPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposDataSet2 = new WindowsFormsApp2.gruposDataSet2();
            this.gruposDataSet = new WindowsFormsApp2.gruposDataSet();
            this.eSTADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTADOTableAdapter = new WindowsFormsApp2.gruposDataSetTableAdapters.ESTADOTableAdapter();
            this.gRUPOTableAdapter = new WindowsFormsApp2.gruposDataSet2TableAdapters.GRUPOTableAdapter();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(620, 126);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 19);
            this.btncancelar.TabIndex = 0;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(528, 126);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(76, 19);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridrecetaDataGridViewTextBoxColumn,
            this.rnombreDataGridViewTextBoxColumn,
            this.rgrupoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECETABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // ridrecetaDataGridViewTextBoxColumn
            // 
            this.ridrecetaDataGridViewTextBoxColumn.DataPropertyName = "r_id_receta";
            this.ridrecetaDataGridViewTextBoxColumn.HeaderText = "ID Receta";
            this.ridrecetaDataGridViewTextBoxColumn.Name = "ridrecetaDataGridViewTextBoxColumn";
            this.ridrecetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rnombreDataGridViewTextBoxColumn
            // 
            this.rnombreDataGridViewTextBoxColumn.DataPropertyName = "r_nombre";
            this.rnombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.rnombreDataGridViewTextBoxColumn.Name = "rnombreDataGridViewTextBoxColumn";
            this.rnombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.rnombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // rgrupoDataGridViewTextBoxColumn
            // 
            this.rgrupoDataGridViewTextBoxColumn.DataPropertyName = "r_grupo";
            this.rgrupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.rgrupoDataGridViewTextBoxColumn.Name = "rgrupoDataGridViewTextBoxColumn";
            this.rgrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rgrupoDataGridViewTextBoxColumn.Width = 250;
            // 
            // rECETABindingSource
            // 
            this.rECETABindingSource.DataMember = "RECETA";
            this.rECETABindingSource.DataSource = this.panesitoDataSet3;
            // 
            // panesitoDataSet3
            // 
            this.panesitoDataSet3.DataSetName = "panesitoDataSet3";
            this.panesitoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECETATableAdapter
            // 
            this.rECETATableAdapter.ClearBeforeFill = true;
            // 
            // txtid_receta
            // 
            this.txtid_receta.Location = new System.Drawing.Point(86, 20);
            this.txtid_receta.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_receta.Name = "txtid_receta";
            this.txtid_receta.Size = new System.Drawing.Size(76, 20);
            this.txtid_receta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Receta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grupo:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(86, 58);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(76, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // cbxgrupo
            // 
            this.cbxgrupo.DataSource = this.gRUPOBindingSource;
            this.cbxgrupo.DisplayMember = "g_descripcion";
            this.cbxgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgrupo.FormattingEnabled = true;
            this.cbxgrupo.Location = new System.Drawing.Point(86, 98);
            this.cbxgrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxgrupo.Name = "cbxgrupo";
            this.cbxgrupo.Size = new System.Drawing.Size(92, 21);
            this.cbxgrupo.TabIndex = 9;
            this.cbxgrupo.ValueMember = "g_id_grupo";
            // 
            // gRUPOBindingSource
            // 
            this.gRUPOBindingSource.DataMember = "GRUPO";
            this.gRUPOBindingSource.DataSource = this.gruposDataSet2;
            // 
            // gruposDataSet2
            // 
            this.gruposDataSet2.DataSetName = "gruposDataSet2";
            this.gruposDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposDataSet
            // 
            this.gruposDataSet.DataSetName = "gruposDataSet";
            this.gruposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTADOBindingSource
            // 
            this.eSTADOBindingSource.DataMember = "ESTADO";
            this.eSTADOBindingSource.DataSource = this.gruposDataSet;
            // 
            // eSTADOTableAdapter
            // 
            this.eSTADOTableAdapter.ClearBeforeFill = true;
            // 
            // gRUPOTableAdapter
            // 
            this.gRUPOTableAdapter.ClearBeforeFill = true;
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.DataSource = this.gRUPOBindingSource;
            this.cmbxstatus.DisplayMember = "g_descripcion";
            this.cmbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Location = new System.Drawing.Point(281, 20);
            this.cmbxstatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(92, 21);
            this.cmbxstatus.TabIndex = 10;
            this.cmbxstatus.ValueMember = "g_id_grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status:";
            // 
            // frmreceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.cbxgrupo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid_receta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmreceta";
            this.Text = "frmreceta";
            this.Load += new System.EventHandler(this.frmreceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECETABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private panesitoDataSet3 panesitoDataSet3;
        private System.Windows.Forms.BindingSource rECETABindingSource;
        private panesitoDataSet3TableAdapters.RECETATableAdapter rECETATableAdapter;
        private System.Windows.Forms.TextBox txtid_receta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridrecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxgrupo;
        private gruposDataSet gruposDataSet;
        private System.Windows.Forms.BindingSource eSTADOBindingSource;
        private gruposDataSetTableAdapters.ESTADOTableAdapter eSTADOTableAdapter;
        private gruposDataSet2 gruposDataSet2;
        private System.Windows.Forms.BindingSource gRUPOBindingSource;
        private gruposDataSet2TableAdapters.GRUPOTableAdapter gRUPOTableAdapter;
        private System.Windows.Forms.ComboBox cmbxstatus;
        private System.Windows.Forms.Label label4;
    }
}