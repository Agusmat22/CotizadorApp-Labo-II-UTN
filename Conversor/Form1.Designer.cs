namespace Conversor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb_cotizacion = new Label();
            lb_euro = new Label();
            lb_dolar = new Label();
            lb_peso = new Label();
            txb_ingresoEuro = new TextBox();
            txb_ingresoDolar = new TextBox();
            txb_ingresoPeso = new TextBox();
            btn_euro = new Button();
            btn_dolar = new Button();
            btn_peso = new Button();
            btn_padlock = new Button();
            img_listPadlock = new ImageList(components);
            txb_muestraEuro1 = new TextBox();
            txb_muestraDolar1 = new TextBox();
            txb_muestraPeso1 = new TextBox();
            txb_muestraPeso2 = new TextBox();
            txb_muestraDolar2 = new TextBox();
            txb_muestraEuro2 = new TextBox();
            txb_muestraEuro3 = new TextBox();
            txb_muestraDolar3 = new TextBox();
            txb_muestraPeso3 = new TextBox();
            lb_euro2 = new Label();
            lb_dolar2 = new Label();
            lb_peso2 = new Label();
            txb_cotEuro = new TextBox();
            txb_cotDolar = new TextBox();
            txb_cotPeso = new TextBox();
            SuspendLayout();
            // 
            // lb_cotizacion
            // 
            lb_cotizacion.AutoSize = true;
            lb_cotizacion.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cotizacion.Location = new Point(79, 23);
            lb_cotizacion.Name = "lb_cotizacion";
            lb_cotizacion.Size = new Size(95, 20);
            lb_cotizacion.TabIndex = 0;
            lb_cotizacion.Text = "Cotizacion";
            // 
            // lb_euro
            // 
            lb_euro.AutoSize = true;
            lb_euro.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_euro.Location = new Point(12, 111);
            lb_euro.Name = "lb_euro";
            lb_euro.Size = new Size(48, 20);
            lb_euro.TabIndex = 1;
            lb_euro.Text = "Euro";
            // 
            // lb_dolar
            // 
            lb_dolar.AutoSize = true;
            lb_dolar.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dolar.Location = new Point(12, 161);
            lb_dolar.Name = "lb_dolar";
            lb_dolar.Size = new Size(55, 20);
            lb_dolar.TabIndex = 2;
            lb_dolar.Text = "Dolar";
            // 
            // lb_peso
            // 
            lb_peso.AutoSize = true;
            lb_peso.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_peso.Location = new Point(13, 208);
            lb_peso.Name = "lb_peso";
            lb_peso.Size = new Size(47, 20);
            lb_peso.TabIndex = 3;
            lb_peso.Text = "Peso";
            // 
            // txb_ingresoEuro
            // 
            txb_ingresoEuro.Location = new Point(79, 108);
            txb_ingresoEuro.Name = "txb_ingresoEuro";
            txb_ingresoEuro.Size = new Size(88, 23);
            txb_ingresoEuro.TabIndex = 4;
            // 
            // txb_ingresoDolar
            // 
            txb_ingresoDolar.Location = new Point(79, 158);
            txb_ingresoDolar.Name = "txb_ingresoDolar";
            txb_ingresoDolar.Size = new Size(88, 23);
            txb_ingresoDolar.TabIndex = 5;
            // 
            // txb_ingresoPeso
            // 
            txb_ingresoPeso.Location = new Point(79, 208);
            txb_ingresoPeso.Name = "txb_ingresoPeso";
            txb_ingresoPeso.Size = new Size(88, 23);
            txb_ingresoPeso.TabIndex = 6;
            // 
            // btn_euro
            // 
            btn_euro.Location = new Point(203, 107);
            btn_euro.Name = "btn_euro";
            btn_euro.Size = new Size(75, 23);
            btn_euro.TabIndex = 7;
            btn_euro.Text = "->";
            btn_euro.UseVisualStyleBackColor = true;
            btn_euro.Click += btn_euro_Click;
            // 
            // btn_dolar
            // 
            btn_dolar.Location = new Point(203, 157);
            btn_dolar.Name = "btn_dolar";
            btn_dolar.Size = new Size(75, 23);
            btn_dolar.TabIndex = 8;
            btn_dolar.Text = "->";
            btn_dolar.UseVisualStyleBackColor = true;
            btn_dolar.Click += btn_dolar_Click;
            // 
            // btn_peso
            // 
            btn_peso.Location = new Point(203, 208);
            btn_peso.Name = "btn_peso";
            btn_peso.Size = new Size(75, 23);
            btn_peso.TabIndex = 9;
            btn_peso.Text = "->";
            btn_peso.UseVisualStyleBackColor = true;
            btn_peso.Click += btn_peso_Click;
            // 
            // btn_padlock
            // 
            btn_padlock.ImageIndex = 0;
            btn_padlock.ImageList = img_listPadlock;
            btn_padlock.Location = new Point(203, 23);
            btn_padlock.Name = "btn_padlock";
            btn_padlock.Size = new Size(75, 23);
            btn_padlock.TabIndex = 10;
            btn_padlock.UseVisualStyleBackColor = true;
            btn_padlock.Click += btn_padlock_Click;
            // 
            // img_listPadlock
            // 
            img_listPadlock.ColorDepth = ColorDepth.Depth8Bit;
            img_listPadlock.ImageStream = (ImageListStreamer)resources.GetObject("img_listPadlock.ImageStream");
            img_listPadlock.TransparentColor = Color.Transparent;
            img_listPadlock.Images.SetKeyName(0, "padlock_close.png");
            img_listPadlock.Images.SetKeyName(1, "padlock_open.png");
            // 
            // txb_muestraEuro1
            // 
            txb_muestraEuro1.Enabled = false;
            txb_muestraEuro1.Location = new Point(336, 107);
            txb_muestraEuro1.Name = "txb_muestraEuro1";
            txb_muestraEuro1.Size = new Size(88, 23);
            txb_muestraEuro1.TabIndex = 11;
            // 
            // txb_muestraDolar1
            // 
            txb_muestraDolar1.Enabled = false;
            txb_muestraDolar1.Location = new Point(336, 157);
            txb_muestraDolar1.Name = "txb_muestraDolar1";
            txb_muestraDolar1.Size = new Size(88, 23);
            txb_muestraDolar1.TabIndex = 12;
            // 
            // txb_muestraPeso1
            // 
            txb_muestraPeso1.Enabled = false;
            txb_muestraPeso1.Location = new Point(336, 205);
            txb_muestraPeso1.Name = "txb_muestraPeso1";
            txb_muestraPeso1.Size = new Size(88, 23);
            txb_muestraPeso1.TabIndex = 13;
            // 
            // txb_muestraPeso2
            // 
            txb_muestraPeso2.Enabled = false;
            txb_muestraPeso2.Location = new Point(480, 205);
            txb_muestraPeso2.Name = "txb_muestraPeso2";
            txb_muestraPeso2.Size = new Size(88, 23);
            txb_muestraPeso2.TabIndex = 14;
            // 
            // txb_muestraDolar2
            // 
            txb_muestraDolar2.Enabled = false;
            txb_muestraDolar2.Location = new Point(480, 157);
            txb_muestraDolar2.Name = "txb_muestraDolar2";
            txb_muestraDolar2.Size = new Size(88, 23);
            txb_muestraDolar2.TabIndex = 15;
            // 
            // txb_muestraEuro2
            // 
            txb_muestraEuro2.Enabled = false;
            txb_muestraEuro2.Location = new Point(480, 107);
            txb_muestraEuro2.Name = "txb_muestraEuro2";
            txb_muestraEuro2.Size = new Size(88, 23);
            txb_muestraEuro2.TabIndex = 16;
            txb_muestraEuro2.TextChanged += textBox9_TextChanged;
            // 
            // txb_muestraEuro3
            // 
            txb_muestraEuro3.Enabled = false;
            txb_muestraEuro3.Location = new Point(620, 107);
            txb_muestraEuro3.Name = "txb_muestraEuro3";
            txb_muestraEuro3.Size = new Size(88, 23);
            txb_muestraEuro3.TabIndex = 17;
            // 
            // txb_muestraDolar3
            // 
            txb_muestraDolar3.Enabled = false;
            txb_muestraDolar3.Location = new Point(620, 157);
            txb_muestraDolar3.Name = "txb_muestraDolar3";
            txb_muestraDolar3.Size = new Size(88, 23);
            txb_muestraDolar3.TabIndex = 18;
            // 
            // txb_muestraPeso3
            // 
            txb_muestraPeso3.Enabled = false;
            txb_muestraPeso3.Location = new Point(620, 205);
            txb_muestraPeso3.Name = "txb_muestraPeso3";
            txb_muestraPeso3.Size = new Size(88, 23);
            txb_muestraPeso3.TabIndex = 19;
            // 
            // lb_euro2
            // 
            lb_euro2.AutoSize = true;
            lb_euro2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_euro2.Location = new Point(355, 84);
            lb_euro2.Name = "lb_euro2";
            lb_euro2.Size = new Size(44, 19);
            lb_euro2.TabIndex = 20;
            lb_euro2.Text = "Euro";
            // 
            // lb_dolar2
            // 
            lb_dolar2.AutoSize = true;
            lb_dolar2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dolar2.Location = new Point(500, 84);
            lb_dolar2.Name = "lb_dolar2";
            lb_dolar2.Size = new Size(50, 19);
            lb_dolar2.TabIndex = 21;
            lb_dolar2.Text = "Dolar";
            // 
            // lb_peso2
            // 
            lb_peso2.AutoSize = true;
            lb_peso2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_peso2.Location = new Point(646, 85);
            lb_peso2.Name = "lb_peso2";
            lb_peso2.Size = new Size(43, 19);
            lb_peso2.TabIndex = 22;
            lb_peso2.Text = "Peso";
            // 
            // txb_cotEuro
            // 
            txb_cotEuro.Enabled = false;
            txb_cotEuro.Location = new Point(336, 24);
            txb_cotEuro.Name = "txb_cotEuro";
            txb_cotEuro.Size = new Size(88, 23);
            txb_cotEuro.TabIndex = 23;
            txb_cotEuro.TextChanged += txb_cotEuro_TextChanged;
            // 
            // txb_cotDolar
            // 
            txb_cotDolar.Enabled = false;
            txb_cotDolar.Location = new Point(480, 23);
            txb_cotDolar.Name = "txb_cotDolar";
            txb_cotDolar.Size = new Size(88, 23);
            txb_cotDolar.TabIndex = 24;
            // 
            // txb_cotPeso
            // 
            txb_cotPeso.Enabled = false;
            txb_cotPeso.Location = new Point(620, 23);
            txb_cotPeso.Name = "txb_cotPeso";
            txb_cotPeso.Size = new Size(88, 23);
            txb_cotPeso.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 258);
            Controls.Add(txb_cotPeso);
            Controls.Add(txb_cotDolar);
            Controls.Add(txb_cotEuro);
            Controls.Add(lb_peso2);
            Controls.Add(lb_dolar2);
            Controls.Add(lb_euro2);
            Controls.Add(txb_muestraPeso3);
            Controls.Add(txb_muestraDolar3);
            Controls.Add(txb_muestraEuro3);
            Controls.Add(txb_muestraEuro2);
            Controls.Add(txb_muestraDolar2);
            Controls.Add(txb_muestraPeso2);
            Controls.Add(txb_muestraPeso1);
            Controls.Add(txb_muestraDolar1);
            Controls.Add(txb_muestraEuro1);
            Controls.Add(btn_padlock);
            Controls.Add(btn_peso);
            Controls.Add(btn_dolar);
            Controls.Add(btn_euro);
            Controls.Add(txb_ingresoPeso);
            Controls.Add(txb_ingresoDolar);
            Controls.Add(txb_ingresoEuro);
            Controls.Add(lb_peso);
            Controls.Add(lb_dolar);
            Controls.Add(lb_euro);
            Controls.Add(lb_cotizacion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_cotizacion;
        private Label lb_euro;
        private Label lb_dolar;
        private Label lb_peso;
        private TextBox txb_ingresoEuro;
        private TextBox txb_ingresoDolar;
        private TextBox txb_ingresoPeso;
        private Button btn_euro;
        private Button btn_dolar;
        private Button btn_peso;
        private Button btn_padlock;
        private TextBox txb_muestraEuro1;
        private TextBox txb_muestraDolar1;
        private TextBox txb_muestraPeso1;
        private TextBox txb_muestraPeso2;
        private TextBox txb_muestraDolar2;
        private TextBox txb_muestraEuro2;
        private TextBox txb_muestraEuro3;
        private TextBox txb_muestraDolar3;
        private TextBox txb_muestraPeso3;
        private Label lb_euro2;
        private Label lb_dolar2;
        private Label lb_peso2;
        private ImageList img_listPadlock;
        private TextBox txb_cotEuro;
        private TextBox txb_cotDolar;
        private TextBox txb_cotPeso;
    }
}