namespace Trabajo_Practico_Estructura_de_Datos
{
    partial class frmConsultaBaseDeDatos
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
            this.lblConsultaEnSQL = new System.Windows.Forms.Label();
            this.txtOpRealizar = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaEnSQL
            // 
            this.lblConsultaEnSQL.AutoSize = true;
            this.lblConsultaEnSQL.Location = new System.Drawing.Point(12, 14);
            this.lblConsultaEnSQL.Name = "lblConsultaEnSQL";
            this.lblConsultaEnSQL.Size = new System.Drawing.Size(90, 13);
            this.lblConsultaEnSQL.TabIndex = 0;
            this.lblConsultaEnSQL.Text = "Consulta en SQL:";
            // 
            // txtOpRealizar
            // 
            this.txtOpRealizar.Location = new System.Drawing.Point(12, 30);
            this.txtOpRealizar.Multiline = true;
            this.txtOpRealizar.Name = "txtOpRealizar";
            this.txtOpRealizar.Size = new System.Drawing.Size(776, 121);
            this.txtOpRealizar.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(685, 157);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(103, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(15, 186);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(773, 252);
            this.dgvConsulta.TabIndex = 3;
            // 
            // frmConsultaBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.txtOpRealizar);
            this.Controls.Add(this.lblConsultaEnSQL);
            this.MaximizeBox = false;
            this.Name = "frmConsultaBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaBaseDeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaEnSQL;
        private System.Windows.Forms.TextBox txtOpRealizar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}