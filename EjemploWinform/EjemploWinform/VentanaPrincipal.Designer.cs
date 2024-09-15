namespace EjemploWinform
{
    partial class VentanaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_listar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.pbx_articulo = new System.Windows.Forms.PictureBox();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_detalle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem11});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarMarca,
            this.tsm_modificar,
            this.tsm_eliminar,
            this.tsm_listar});
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(59, 21);
            this.toolStripMenuItem7.Text = "Marca";
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.Size = new System.Drawing.Size(133, 22);
            this.AgregarMarca.Text = "Agregar";
            this.AgregarMarca.Click += new System.EventHandler(this.AgregarMarca_Click);
            // 
            // tsm_modificar
            // 
            this.tsm_modificar.Name = "tsm_modificar";
            this.tsm_modificar.Size = new System.Drawing.Size(133, 22);
            this.tsm_modificar.Text = "Modificar";
            this.tsm_modificar.Click += new System.EventHandler(this.tsm_modificar_Click);
            // 
            // tsm_eliminar
            // 
            this.tsm_eliminar.Name = "tsm_eliminar";
            this.tsm_eliminar.Size = new System.Drawing.Size(133, 22);
            this.tsm_eliminar.Text = "Eliminar";
            this.tsm_eliminar.Click += new System.EventHandler(this.tsm_eliminar_Click);
            // 
            // tsm_listar
            // 
            this.tsm_listar.Name = "tsm_listar";
            this.tsm_listar.Size = new System.Drawing.Size(133, 22);
            this.tsm_listar.Text = "Listar";
            this.tsm_listar.Click += new System.EventHandler(this.tsm_listar_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem4});
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(81, 21);
            this.toolStripMenuItem11.Text = "Categoria";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem12.Text = "Agregar";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem13.Text = "Modificar";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem14.Text = "Eliminar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Text = "Listar";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Location = new System.Drawing.Point(12, 71);
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.Size = new System.Drawing.Size(588, 248);
            this.dgv_articulos.TabIndex = 1;
            this.dgv_articulos.SelectionChanged += new System.EventHandler(this.dgv_articulos_SelectionChanged);
            // 
            // pbx_articulo
            // 
            this.pbx_articulo.Location = new System.Drawing.Point(606, 71);
            this.pbx_articulo.Name = "pbx_articulo";
            this.pbx_articulo.Size = new System.Drawing.Size(259, 248);
            this.pbx_articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_articulo.TabIndex = 2;
            this.pbx_articulo.TabStop = false;
            // 
            // btn_anterior
            // 
            this.btn_anterior.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(606, 325);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(110, 23);
            this.btn_anterior.TabIndex = 3;
            this.btn_anterior.Text = "Imagen Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(755, 325);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(110, 23);
            this.btn_siguiente.TabIndex = 4;
            this.btn_siguiente.Text = "Imagen Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(198, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_detalle
            // 
            this.btn_detalle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle.Location = new System.Drawing.Point(291, 326);
            this.btn_detalle.Name = "btn_detalle";
            this.btn_detalle.Size = new System.Drawing.Size(75, 23);
            this.btn_detalle.TabIndex = 8;
            this.btn_detalle.Text = "Ver detalle";
            this.btn_detalle.UseVisualStyleBackColor = true;
            this.btn_detalle.Click += new System.EventHandler(this.btn_detalle_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 380);
            this.Controls.Add(this.btn_detalle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.pbx_articulo);
            this.Controls.Add(this.dgv_articulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem AgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsm_modificar;
        private System.Windows.Forms.ToolStripMenuItem tsm_eliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.PictureBox pbx_articulo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.ToolStripMenuItem tsm_listar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_detalle;
    }
}