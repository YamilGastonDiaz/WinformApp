namespace EjemploWinform
{
    partial class ListarMarca
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrarL = new System.Windows.Forms.Button();
            this.dgv_listarM = new System.Windows.Forms.DataGridView();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cerrarL);
            this.panel1.Controls.Add(this.dgv_listarM);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 305);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrarL
            // 
            this.btn_cerrarL.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarL.Location = new System.Drawing.Point(81, 256);
            this.btn_cerrarL.Name = "btn_cerrarL";
            this.btn_cerrarL.Size = new System.Drawing.Size(139, 23);
            this.btn_cerrarL.TabIndex = 1;
            this.btn_cerrarL.Text = "Cerrar";
            this.btn_cerrarL.UseVisualStyleBackColor = true;
            this.btn_cerrarL.Click += new System.EventHandler(this.btn_cerrarL_Click);
            // 
            // dgv_listarM
            // 
            this.dgv_listarM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarM.Location = new System.Drawing.Point(30, 15);
            this.dgv_listarM.Name = "dgv_listarM";
            this.dgv_listarM.Size = new System.Drawing.Size(240, 235);
            this.dgv_listarM.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(98, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(121, 22);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Listar Marca";
            // 
            // ListarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 372);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarMarca";
            this.Load += new System.EventHandler(this.ListarMarca_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgv_listarM;
        private System.Windows.Forms.Button btn_cerrarL;
    }
}