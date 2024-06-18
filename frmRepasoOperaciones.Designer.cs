namespace Trabajo_Practico_Estructura_de_Datos
{
    partial class frmRepasoOperaciones
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(12, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(297, 20);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Operacion a realizar en la base de datos:\r\n";
            // 
            // cboLista
            // 
            this.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Items.AddRange(new object[] {
            "Proyeccion Simple I",
            "Proyeccion Simple II",
            "Proyeccion Multiatributo",
            "Proyeccion Multiatributo II",
            "Juntar",
            "Juntar II",
            "Seleccion Simple",
            "Seleccion Simple II",
            "Seleccion Multiatributo",
            "Seleccion Multiatributo II",
            "Seleccion Convulcion",
            "Seleccion Convulcion II",
            "Union",
            "Union II",
            "Interseccion",
            "Interseccion II",
            "Diferencia",
            "Diferencia II",
            "Proyeccion Simple III",
            "Proyeccion Simple IV"});
            this.cboLista.Location = new System.Drawing.Point(315, 12);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(473, 21);
            this.cboLista.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(794, 12);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(131, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 39);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(922, 101);
            this.txtDescripcion.TabIndex = 3;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 146);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(922, 292);
            this.dgvGrilla.TabIndex = 4;
            // 
            // frmRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.lblTexto);
            this.MaximizeBox = false;
            this.Name = "frmRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvGrilla;
    }
}