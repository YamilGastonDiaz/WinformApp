namespace EjemploWinform
{
    partial class Detalle
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
            this.pbox_imgA = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nombreA = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nombreC = new System.Windows.Forms.Label();
            this.lbl_nombreM = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_imgA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_imgA
            // 
            this.pbox_imgA.Location = new System.Drawing.Point(3, 53);
            this.pbox_imgA.Name = "pbox_imgA";
            this.pbox_imgA.Size = new System.Drawing.Size(243, 248);
            this.pbox_imgA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_imgA.TabIndex = 0;
            this.pbox_imgA.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_money);
            this.panel1.Controls.Add(this.lbl_precio);
            this.panel1.Controls.Add(this.lbl_marca);
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.lbl_categoria);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.lbl_nombreM);
            this.panel1.Controls.Add(this.lbl_nombreC);
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Controls.Add(this.lbl_nombreA);
            this.panel1.Controls.Add(this.pbox_imgA);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 316);
            this.panel1.TabIndex = 1;
            // 
            // lbl_nombreA
            // 
            this.lbl_nombreA.AutoSize = true;
            this.lbl_nombreA.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreA.Location = new System.Drawing.Point(20, 9);
            this.lbl_nombreA.Name = "lbl_nombreA";
            this.lbl_nombreA.Size = new System.Drawing.Size(207, 30);
            this.lbl_nombreA.TabIndex = 1;
            this.lbl_nombreA.Text = "Nombre articulo";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(451, 22);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(50, 16);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Text = "Codigo:";
            // 
            // lbl_nombreC
            // 
            this.lbl_nombreC.AutoSize = true;
            this.lbl_nombreC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreC.Location = new System.Drawing.Point(252, 53);
            this.lbl_nombreC.Name = "lbl_nombreC";
            this.lbl_nombreC.Size = new System.Drawing.Size(79, 17);
            this.lbl_nombreC.TabIndex = 3;
            this.lbl_nombreC.Text = "Categoria:";
            // 
            // lbl_nombreM
            // 
            this.lbl_nombreM.AutoSize = true;
            this.lbl_nombreM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreM.Location = new System.Drawing.Point(252, 82);
            this.lbl_nombreM.Name = "lbl_nombreM";
            this.lbl_nombreM.Size = new System.Drawing.Size(53, 17);
            this.lbl_nombreM.TabIndex = 4;
            this.lbl_nombreM.Text = "Marca:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.White;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(255, 216);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(294, 85);
            this.txt_descripcion.TabIndex = 10;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(337, 54);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(103, 16);
            this.lbl_categoria.TabIndex = 11;
            this.lbl_categoria.Text = "XXXXXXXXXXXX";
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(507, 23);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(47, 13);
            this.lbl_code.TabIndex = 12;
            this.lbl_code.Text = "XXXXX";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(337, 83);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(103, 16);
            this.lbl_marca.TabIndex = 13;
            this.lbl_marca.Text = "XXXXXXXXXXXX";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.Red;
            this.lbl_precio.Location = new System.Drawing.Point(259, 153);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(242, 31);
            this.lbl_precio.TabIndex = 14;
            this.lbl_precio.Text = "XXXXXXXXXXXX";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.Location = new System.Drawing.Point(258, 124);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(52, 17);
            this.lbl_money.TabIndex = 15;
            this.lbl_money.Text = "Precio:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(502, 335);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 362);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_imgA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_imgA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nombreA;
        private System.Windows.Forms.Label lbl_nombreM;
        private System.Windows.Forms.Label lbl_nombreC;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Button btn_cerrar;
    }
}