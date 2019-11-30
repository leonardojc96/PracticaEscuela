namespace PracticaEscuela.Vistas.Cursos
{
    partial class InicioCursos
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
            System.Windows.Forms.Label cursoIdLabel;
            System.Windows.Forms.Label divisionLabel;
            System.Windows.Forms.Label activoLabel;
            this.escuelaDataSet = new PracticaEscuela.EscuelaDataSet();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new PracticaEscuela.EscuelaDataSetTableAdapters.CursoTableAdapter();
            this.tableAdapterManager = new PracticaEscuela.EscuelaDataSetTableAdapters.TableAdapterManager();
            this.cursoIdTextBox = new System.Windows.Forms.TextBox();
            this.divisionTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.cursoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            cursoIdLabel = new System.Windows.Forms.Label();
            divisionLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cursoIdLabel
            // 
            cursoIdLabel.AutoSize = true;
            cursoIdLabel.Location = new System.Drawing.Point(12, 17);
            cursoIdLabel.Name = "cursoIdLabel";
            cursoIdLabel.Size = new System.Drawing.Size(49, 13);
            cursoIdLabel.TabIndex = 4;
            cursoIdLabel.Text = "Curso Id:";
            // 
            // divisionLabel
            // 
            divisionLabel.AutoSize = true;
            divisionLabel.Location = new System.Drawing.Point(12, 43);
            divisionLabel.Name = "divisionLabel";
            divisionLabel.Size = new System.Drawing.Size(47, 13);
            divisionLabel.TabIndex = 6;
            divisionLabel.Text = "Division:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(12, 71);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 8;
            activoLabel.Text = "Activo:";
            // 
            // escuelaDataSet
            // 
            this.escuelaDataSet.DataSetName = "EscuelaDataSet";
            this.escuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.escuelaDataSet;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.InscripcionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PracticaEscuela.EscuelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursoIdTextBox
            // 
            this.cursoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "CursoId", true));
            this.cursoIdTextBox.Location = new System.Drawing.Point(67, 14);
            this.cursoIdTextBox.Name = "cursoIdTextBox";
            this.cursoIdTextBox.Size = new System.Drawing.Size(104, 20);
            this.cursoIdTextBox.TabIndex = 5;
            // 
            // divisionTextBox
            // 
            this.divisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Division", true));
            this.divisionTextBox.Location = new System.Drawing.Point(67, 40);
            this.divisionTextBox.Name = "divisionTextBox";
            this.divisionTextBox.Size = new System.Drawing.Size(104, 20);
            this.divisionTextBox.TabIndex = 7;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cursoBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(67, 66);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 9;
            this.activoCheckBox.Text = "checkBox1";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cursoDataGridView
            // 
            this.cursoDataGridView.AllowUserToAddRows = false;
            this.cursoDataGridView.AllowUserToDeleteRows = false;
            this.cursoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cursoDataGridView.AutoGenerateColumns = false;
            this.cursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.cursoDataGridView.DataSource = this.cursoBindingSource;
            this.cursoDataGridView.Location = new System.Drawing.Point(249, 3);
            this.cursoDataGridView.Name = "cursoDataGridView";
            this.cursoDataGridView.ReadOnly = true;
            this.cursoDataGridView.Size = new System.Drawing.Size(445, 367);
            this.cursoDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CursoId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CursoId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Division";
            this.dataGridViewTextBoxColumn3.HeaderText = "Division";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(168, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panelCampos);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.cursoDataGridView);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 381);
            this.panel1.TabIndex = 12;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.cursoIdTextBox);
            this.panelCampos.Controls.Add(divisionLabel);
            this.panelCampos.Controls.Add(cursoIdLabel);
            this.panelCampos.Controls.Add(this.divisionTextBox);
            this.panelCampos.Controls.Add(activoLabel);
            this.panelCampos.Controls.Add(this.activoCheckBox);
            this.panelCampos.Location = new System.Drawing.Point(26, 67);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(200, 100);
            this.panelCampos.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(87, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // InicioCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "InicioCursos";
            this.Load += new System.EventHandler(this.InicioGrupo_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.escuelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EscuelaDataSet escuelaDataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private EscuelaDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private EscuelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cursoIdTextBox;
        private System.Windows.Forms.TextBox divisionTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DataGridView cursoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelCampos;
    }
}