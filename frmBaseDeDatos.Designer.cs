namespace Trabajo_Practico_Estructura_de_Datos
{
    partial class frmBaseDeDatos
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
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdProyeccionMulti = new System.Windows.Forms.Button();
            this.cmdProyeccionSimple = new System.Windows.Forms.Button();
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionXConvul = new System.Windows.Forms.Button();
            this.cmdSeleccionMulti = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.gbOpAlge = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.gbSelect.SuspendLayout();
            this.gbWhere.SuspendLayout();
            this.gbOpAlge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.cmdJuntar);
            this.gbSelect.Controls.Add(this.cmdProyeccionMulti);
            this.gbSelect.Controls.Add(this.cmdProyeccionSimple);
            this.gbSelect.Location = new System.Drawing.Point(12, 303);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(200, 119);
            this.gbSelect.TabIndex = 0;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Operaciones de Proyeccion-SELECT";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(6, 85);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(188, 23);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdProyeccionMulti
            // 
            this.cmdProyeccionMulti.Location = new System.Drawing.Point(6, 56);
            this.cmdProyeccionMulti.Name = "cmdProyeccionMulti";
            this.cmdProyeccionMulti.Size = new System.Drawing.Size(188, 23);
            this.cmdProyeccionMulti.TabIndex = 1;
            this.cmdProyeccionMulti.Text = "Proyeccion multiatributo";
            this.cmdProyeccionMulti.UseVisualStyleBackColor = true;
            this.cmdProyeccionMulti.Click += new System.EventHandler(this.cmdProyeccionMulti_Click);
            // 
            // cmdProyeccionSimple
            // 
            this.cmdProyeccionSimple.Location = new System.Drawing.Point(6, 28);
            this.cmdProyeccionSimple.Name = "cmdProyeccionSimple";
            this.cmdProyeccionSimple.Size = new System.Drawing.Size(188, 23);
            this.cmdProyeccionSimple.TabIndex = 0;
            this.cmdProyeccionSimple.Text = "Proyeccion Simple";
            this.cmdProyeccionSimple.UseVisualStyleBackColor = true;
            this.cmdProyeccionSimple.Click += new System.EventHandler(this.cmdProyeccionSimple_Click);
            // 
            // gbWhere
            // 
            this.gbWhere.Controls.Add(this.cmdSeleccionXConvul);
            this.gbWhere.Controls.Add(this.cmdSeleccionMulti);
            this.gbWhere.Controls.Add(this.cmdSeleccionSimple);
            this.gbWhere.Location = new System.Drawing.Point(218, 303);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Size = new System.Drawing.Size(200, 119);
            this.gbWhere.TabIndex = 1;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "Operaciones de seleccion-WHERE";
            // 
            // cmdSeleccionXConvul
            // 
            this.cmdSeleccionXConvul.Location = new System.Drawing.Point(6, 85);
            this.cmdSeleccionXConvul.Name = "cmdSeleccionXConvul";
            this.cmdSeleccionXConvul.Size = new System.Drawing.Size(188, 23);
            this.cmdSeleccionXConvul.TabIndex = 3;
            this.cmdSeleccionXConvul.Text = "Seleccion por Convulciòn\r\n";
            this.cmdSeleccionXConvul.UseVisualStyleBackColor = true;
            this.cmdSeleccionXConvul.Click += new System.EventHandler(this.cmdSeleccionXConvul_Click);
            // 
            // cmdSeleccionMulti
            // 
            this.cmdSeleccionMulti.Location = new System.Drawing.Point(6, 56);
            this.cmdSeleccionMulti.Name = "cmdSeleccionMulti";
            this.cmdSeleccionMulti.Size = new System.Drawing.Size(188, 23);
            this.cmdSeleccionMulti.TabIndex = 2;
            this.cmdSeleccionMulti.Text = "Seleccion Multiatributo";
            this.cmdSeleccionMulti.UseVisualStyleBackColor = true;
            this.cmdSeleccionMulti.Click += new System.EventHandler(this.cmdSeleccionMulti_Click);
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(6, 28);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(188, 23);
            this.cmdSeleccionSimple.TabIndex = 1;
            this.cmdSeleccionSimple.Text = "Seleccion Simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            this.cmdSeleccionSimple.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbOpAlge
            // 
            this.gbOpAlge.Controls.Add(this.cmdDiferencia);
            this.gbOpAlge.Controls.Add(this.cmdInterseccion);
            this.gbOpAlge.Controls.Add(this.cmdUnion);
            this.gbOpAlge.Location = new System.Drawing.Point(424, 303);
            this.gbOpAlge.Name = "gbOpAlge";
            this.gbOpAlge.Size = new System.Drawing.Size(200, 119);
            this.gbOpAlge.TabIndex = 2;
            this.gbOpAlge.TabStop = false;
            this.gbOpAlge.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(6, 85);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(188, 23);
            this.cmdDiferencia.TabIndex = 4;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(6, 56);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(188, 23);
            this.cmdInterseccion.TabIndex = 3;
            this.cmdInterseccion.Text = "Interseccion";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(6, 28);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(188, 23);
            this.cmdUnion.TabIndex = 2;
            this.cmdUnion.Text = "Union";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 12);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(612, 285);
            this.dgvMostrar.TabIndex = 3;
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.gbOpAlge);
            this.Controls.Add(this.gbWhere);
            this.Controls.Add(this.gbSelect);
            this.MaximizeBox = false;
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base De Datos";
            this.gbSelect.ResumeLayout(false);
            this.gbWhere.ResumeLayout(false);
            this.gbOpAlge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdProyeccionMulti;
        private System.Windows.Forms.Button cmdProyeccionSimple;
        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.GroupBox gbOpAlge;
        private System.Windows.Forms.Button cmdSeleccionSimple;
        private System.Windows.Forms.Button cmdSeleccionXConvul;
        private System.Windows.Forms.Button cmdSeleccionMulti;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
        private System.Windows.Forms.DataGridView dgvMostrar;
    }
}