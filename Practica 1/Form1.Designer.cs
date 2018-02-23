namespace Practica_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pctbxSensor2 = new System.Windows.Forms.PictureBox();
            this.pctbxSensor1 = new System.Windows.Forms.PictureBox();
            this.pctbxDireccion = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblTanque = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjustarfecha = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxSensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(299, 30);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(90, 32);
            this.txtDatos.MaxLength = 24;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(172, 20);
            this.txtDatos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(234, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(122, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sensor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sensor 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de Lectura";
            // 
            // pctbxSensor2
            // 
            this.pctbxSensor2.Location = new System.Drawing.Point(123, 117);
            this.pctbxSensor2.Name = "pctbxSensor2";
            this.pctbxSensor2.Size = new System.Drawing.Size(67, 54);
            this.pctbxSensor2.TabIndex = 11;
            this.pctbxSensor2.TabStop = false;
            // 
            // pctbxSensor1
            // 
            this.pctbxSensor1.ErrorImage = global::Practica_1.Properties.Resources.apagado;
            this.pctbxSensor1.Location = new System.Drawing.Point(26, 117);
            this.pctbxSensor1.Name = "pctbxSensor1";
            this.pctbxSensor1.Size = new System.Drawing.Size(67, 54);
            this.pctbxSensor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctbxSensor1.TabIndex = 10;
            this.pctbxSensor1.TabStop = false;
            // 
            // pctbxDireccion
            // 
            this.pctbxDireccion.ErrorImage = global::Practica_1.Properties.Resources.Norte;
            this.pctbxDireccion.Location = new System.Drawing.Point(390, 106);
            this.pctbxDireccion.Name = "pctbxDireccion";
            this.pctbxDireccion.Size = new System.Drawing.Size(90, 80);
            this.pctbxDireccion.TabIndex = 9;
            this.pctbxDireccion.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Norte.png");
            this.imageList1.Images.SetKeyName(1, "Noreste.png");
            this.imageList1.Images.SetKeyName(2, "Este.png");
            this.imageList1.Images.SetKeyName(3, "Sureste.png");
            this.imageList1.Images.SetKeyName(4, "Sur.png");
            this.imageList1.Images.SetKeyName(5, "Suroeste.png");
            this.imageList1.Images.SetKeyName(6, "Oeste.png");
            this.imageList1.Images.SetKeyName(7, "Noroeste.png");
            this.imageList1.Images.SetKeyName(8, "apagado.png");
            this.imageList1.Images.SetKeyName(9, "encendido.png");
            // 
            // lblTanque
            // 
            this.lblTanque.AutoSize = true;
            this.lblTanque.Location = new System.Drawing.Point(280, 90);
            this.lblTanque.Name = "lblTanque";
            this.lblTanque.Size = new System.Drawing.Size(0, 13);
            this.lblTanque.TabIndex = 13;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(131, 231);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nivel";
            // 
            // btnAjustarfecha
            // 
            this.btnAjustarfecha.Location = new System.Drawing.Point(90, 301);
            this.btnAjustarfecha.Name = "btnAjustarfecha";
            this.btnAjustarfecha.Size = new System.Drawing.Size(200, 23);
            this.btnAjustarfecha.TabIndex = 16;
            this.btnAjustarfecha.Text = "Ajustar fecha";
            this.btnAjustarfecha.UseVisualStyleBackColor = true;
            this.btnAjustarfecha.Click += new System.EventHandler(this.btnAjustarfecha_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(90, 332);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(200, 20);
            this.txtResultado.TabIndex = 18;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(90, 266);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 369);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnAjustarfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTanque);
            this.Controls.Add(this.pctbxSensor2);
            this.Controls.Add(this.pctbxSensor1);
            this.Controls.Add(this.pctbxDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Practica 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxSensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pctbxDireccion;
        private System.Windows.Forms.PictureBox pctbxSensor1;
        private System.Windows.Forms.PictureBox pctbxSensor2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTanque;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjustarfecha;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}

