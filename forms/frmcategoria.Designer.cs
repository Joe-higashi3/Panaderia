namespace WindowsFormsApp2.forms
{
    partial class frmcategoria
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
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.caidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panesitodscategoria = new WindowsFormsApp2.panesitodscategoria();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cATEGORIATableAdapter = new WindowsFormsApp2.panesitodscategoriaTableAdapters.CATEGORIATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitodscategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.AutoGenerateColumns = false;
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caidDataGridViewTextBoxColumn,
            this.cadescripcionDataGridViewTextBoxColumn});
            this.dgvcategoria.DataSource = this.cATEGORIABindingSource;
            this.dgvcategoria.Location = new System.Drawing.Point(15, 183);
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.Size = new System.Drawing.Size(364, 199);
            this.dgvcategoria.TabIndex = 16;
            this.dgvcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategoria_CellContentClick);
            // 
            // caidDataGridViewTextBoxColumn
            // 
            this.caidDataGridViewTextBoxColumn.DataPropertyName = "ca_id";
            this.caidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.caidDataGridViewTextBoxColumn.Name = "caidDataGridViewTextBoxColumn";
            this.caidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadescripcionDataGridViewTextBoxColumn
            // 
            this.cadescripcionDataGridViewTextBoxColumn.DataPropertyName = "ca_descripcion";
            this.cadescripcionDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.cadescripcionDataGridViewTextBoxColumn.Name = "cadescripcionDataGridViewTextBoxColumn";
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.panesitodscategoria;
            // 
            // panesitodscategoria
            // 
            this.panesitodscategoria.DataSetName = "panesitodscategoria";
            this.panesitodscategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(34, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(81, 64);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(130, 20);
            this.txtdescripcion.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(81, 100);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(130, 77);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcategoria);
            this.Name = "frmcategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcategoria";
            this.Load += new System.EventHandler(this.frmcategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panesitodscategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnguardar;
        private panesitodscategoria panesitodscategoria;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private panesitodscategoriaTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn caidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}