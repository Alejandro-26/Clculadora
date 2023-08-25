namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResultado = new TextBox();
            btnMasMenos = new Button();
            btnCero = new Button();
            btnPunto = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            btnCeis = new Button();
            btnCinco = new Button();
            BtnCuatro = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnIgual = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            btnPor = new Button();
            btnDivide = new Button();
            btnBorra = new Button();
            btnElevada = new Button();
            btnRaiz = new Button();
            btnPorciento = new Button();
            btnCE = new Button();
            btnC = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Window;
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.ForeColor = SystemColors.Desktop;
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 23;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(224, 28);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMasMenos
            // 
            btnMasMenos.BackColor = Color.White;
            btnMasMenos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasMenos.ForeColor = Color.Firebrick;
            btnMasMenos.Location = new Point(12, 298);
            btnMasMenos.Name = "btnMasMenos";
            btnMasMenos.Size = new Size(45, 39);
            btnMasMenos.TabIndex = 1;
            btnMasMenos.Text = "+/-";
            btnMasMenos.UseVisualStyleBackColor = false;
            btnMasMenos.Click += btnMasMenos_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.White;
            btnCero.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCero.ForeColor = Color.Firebrick;
            btnCero.Location = new Point(57, 298);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(45, 39);
            btnCero.TabIndex = 2;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += agregarNumeros;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = Color.White;
            btnPunto.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPunto.ForeColor = Color.Firebrick;
            btnPunto.Location = new Point(102, 298);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(45, 39);
            btnPunto.TabIndex = 3;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.White;
            btnTres.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.ForeColor = Color.Firebrick;
            btnTres.Location = new Point(102, 255);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(45, 39);
            btnTres.TabIndex = 6;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += agregarNumeros;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.White;
            btnDos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDos.ForeColor = Color.Firebrick;
            btnDos.Location = new Point(57, 255);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(45, 39);
            btnDos.TabIndex = 5;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += agregarNumeros;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.White;
            btnUno.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUno.ForeColor = Color.Firebrick;
            btnUno.Location = new Point(12, 255);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(45, 39);
            btnUno.TabIndex = 4;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += agregarNumeros;
            // 
            // btnCeis
            // 
            btnCeis.BackColor = Color.White;
            btnCeis.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCeis.ForeColor = Color.Firebrick;
            btnCeis.Location = new Point(102, 212);
            btnCeis.Name = "btnCeis";
            btnCeis.Size = new Size(45, 39);
            btnCeis.TabIndex = 9;
            btnCeis.Text = "6";
            btnCeis.UseVisualStyleBackColor = false;
            btnCeis.Click += agregarNumeros;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.White;
            btnCinco.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCinco.ForeColor = Color.Firebrick;
            btnCinco.Location = new Point(57, 212);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(45, 39);
            btnCinco.TabIndex = 8;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += agregarNumeros;
            // 
            // BtnCuatro
            // 
            BtnCuatro.BackColor = Color.White;
            BtnCuatro.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCuatro.ForeColor = Color.Firebrick;
            BtnCuatro.Location = new Point(12, 212);
            BtnCuatro.Name = "BtnCuatro";
            BtnCuatro.Size = new Size(45, 39);
            BtnCuatro.TabIndex = 7;
            BtnCuatro.Text = "4";
            BtnCuatro.UseVisualStyleBackColor = false;
            BtnCuatro.Click += agregarNumeros;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.White;
            btnNueve.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNueve.ForeColor = Color.Firebrick;
            btnNueve.Location = new Point(102, 169);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(45, 39);
            btnNueve.TabIndex = 12;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += agregarNumeros;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.White;
            btnOcho.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOcho.ForeColor = Color.Firebrick;
            btnOcho.Location = new Point(57, 169);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(45, 39);
            btnOcho.TabIndex = 11;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += agregarNumeros;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.White;
            btnSiete.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiete.ForeColor = Color.Firebrick;
            btnSiete.Location = new Point(12, 169);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(45, 39);
            btnSiete.TabIndex = 10;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += agregarNumeros;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.White;
            btnIgual.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.ForeColor = Color.Firebrick;
            btnIgual.Location = new Point(186, 298);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(50, 39);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnMas
            // 
            btnMas.BackColor = Color.White;
            btnMas.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMas.ForeColor = Color.Firebrick;
            btnMas.Location = new Point(186, 257);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(50, 39);
            btnMas.TabIndex = 14;
            btnMas.Tag = "+";
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += clickOperador;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = Color.White;
            btnMenos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenos.ForeColor = Color.Firebrick;
            btnMenos.Location = new Point(186, 214);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(50, 37);
            btnMenos.TabIndex = 15;
            btnMenos.Tag = "-";
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += clickOperador;
            // 
            // btnPor
            // 
            btnPor.BackColor = Color.White;
            btnPor.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPor.ForeColor = Color.Firebrick;
            btnPor.Location = new Point(186, 169);
            btnPor.Name = "btnPor";
            btnPor.Size = new Size(50, 39);
            btnPor.TabIndex = 16;
            btnPor.Tag = "x";
            btnPor.Text = "x";
            btnPor.UseVisualStyleBackColor = false;
            btnPor.Click += clickOperador;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.White;
            btnDivide.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.Firebrick;
            btnDivide.Location = new Point(186, 125);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 39);
            btnDivide.TabIndex = 17;
            btnDivide.Tag = "/";
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += clickOperador;
            // 
            // btnBorra
            // 
            btnBorra.BackColor = Color.White;
            btnBorra.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorra.ForeColor = Color.Firebrick;
            btnBorra.Location = new Point(102, 125);
            btnBorra.Name = "btnBorra";
            btnBorra.Size = new Size(45, 39);
            btnBorra.TabIndex = 18;
            btnBorra.Text = "⊲";
            btnBorra.UseVisualStyleBackColor = false;
            btnBorra.Click += btnBorra_Click;
            // 
            // btnElevada
            // 
            btnElevada.BackColor = Color.White;
            btnElevada.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnElevada.ForeColor = Color.Firebrick;
            btnElevada.Location = new Point(57, 125);
            btnElevada.Name = "btnElevada";
            btnElevada.Size = new Size(45, 39);
            btnElevada.TabIndex = 19;
            btnElevada.Tag = "²";
            btnElevada.Text = "x²";
            btnElevada.UseVisualStyleBackColor = false;
            btnElevada.Click += clickOperador;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.White;
            btnRaiz.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaiz.ForeColor = Color.Firebrick;
            btnRaiz.Location = new Point(12, 125);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(45, 39);
            btnRaiz.TabIndex = 20;
            btnRaiz.Tag = "√";
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += clickOperador;
            // 
            // btnPorciento
            // 
            btnPorciento.BackColor = Color.White;
            btnPorciento.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPorciento.ForeColor = Color.Firebrick;
            btnPorciento.Location = new Point(12, 80);
            btnPorciento.Name = "btnPorciento";
            btnPorciento.Size = new Size(45, 39);
            btnPorciento.TabIndex = 23;
            btnPorciento.Tag = "%";
            btnPorciento.Text = "%";
            btnPorciento.UseVisualStyleBackColor = false;
            btnPorciento.Click += clickOperador;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.White;
            btnCE.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.ForeColor = Color.Firebrick;
            btnCE.Location = new Point(57, 80);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(45, 39);
            btnCE.TabIndex = 22;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.White;
            btnC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.ForeColor = Color.Firebrick;
            btnC.Location = new Point(102, 80);
            btnC.Name = "btnC";
            btnC.Size = new Size(45, 39);
            btnC.TabIndex = 21;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(149, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 73);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(241, 349);
            Controls.Add(pictureBox1);
            Controls.Add(btnPorciento);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(btnRaiz);
            Controls.Add(btnElevada);
            Controls.Add(btnBorra);
            Controls.Add(btnDivide);
            Controls.Add(btnPor);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btnIgual);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnCeis);
            Controls.Add(btnCinco);
            Controls.Add(BtnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnMasMenos);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnMasMenos;
        private Button btnCero;
        private Button btnPunto;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private Button btnCeis;
        private Button btnCinco;
        private Button BtnCuatro;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnIgual;
        private Button btnMas;
        private Button btnMenos;
        private Button btnPor;
        private Button btnDivide;
        private Button btnBorra;
        private Button btnElevada;
        private Button btnRaiz;
        private Button btnPorciento;
        private Button btnCE;
        private Button btnC;
        private PictureBox pictureBox1;
    }
}