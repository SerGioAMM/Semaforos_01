namespace Semaforos_01
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
            btn_EstablecerTiempos = new Button();
            btn_NuevoTiempo = new Button();
            btn_Pausar = new Button();
            txt_TiempoVerde = new TextBox();
            txt_TiempoAmarillo = new TextBox();
            txt_TiempoRojo = new TextBox();
            Semaforo_Oeste = new PictureBox();
            Semaforo_Este = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Contador_Oeste = new Label();
            Añadir_Carro = new Button();
            Contador_Norte = new Label();
            Semaforo_Norte = new PictureBox();
            Semaforo_Sur = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Oeste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Este).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Norte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Sur).BeginInit();
            SuspendLayout();
            // 
            // btn_EstablecerTiempos
            // 
            btn_EstablecerTiempos.Location = new Point(9, 39);
            btn_EstablecerTiempos.Name = "btn_EstablecerTiempos";
            btn_EstablecerTiempos.Size = new Size(75, 48);
            btn_EstablecerTiempos.TabIndex = 1;
            btn_EstablecerTiempos.Text = "Establecer Tiempos";
            btn_EstablecerTiempos.UseVisualStyleBackColor = true;
            btn_EstablecerTiempos.Click += btn_EstablecerTiempos_Click;
            // 
            // btn_NuevoTiempo
            // 
            btn_NuevoTiempo.Enabled = false;
            btn_NuevoTiempo.Location = new Point(90, 39);
            btn_NuevoTiempo.Name = "btn_NuevoTiempo";
            btn_NuevoTiempo.Size = new Size(75, 48);
            btn_NuevoTiempo.TabIndex = 2;
            btn_NuevoTiempo.Text = "Nuevos Tiempos";
            btn_NuevoTiempo.UseVisualStyleBackColor = true;
            btn_NuevoTiempo.Click += btn_NuevoTiempo_Click;
            // 
            // btn_Pausar
            // 
            btn_Pausar.Enabled = false;
            btn_Pausar.Location = new Point(171, 39);
            btn_Pausar.Name = "btn_Pausar";
            btn_Pausar.Size = new Size(75, 48);
            btn_Pausar.TabIndex = 3;
            btn_Pausar.Text = "Pausar";
            btn_Pausar.UseVisualStyleBackColor = true;
            btn_Pausar.Click += btn_Pausar_Click;
            // 
            // txt_TiempoVerde
            // 
            txt_TiempoVerde.BackColor = SystemColors.MenuText;
            txt_TiempoVerde.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_TiempoVerde.ForeColor = Color.LimeGreen;
            txt_TiempoVerde.Location = new Point(9, 8);
            txt_TiempoVerde.Name = "txt_TiempoVerde";
            txt_TiempoVerde.Size = new Size(75, 29);
            txt_TiempoVerde.TabIndex = 5;
            txt_TiempoVerde.Text = "6";
            txt_TiempoVerde.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_TiempoAmarillo
            // 
            txt_TiempoAmarillo.BackColor = SystemColors.MenuText;
            txt_TiempoAmarillo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_TiempoAmarillo.ForeColor = Color.Yellow;
            txt_TiempoAmarillo.Location = new Point(90, 8);
            txt_TiempoAmarillo.Name = "txt_TiempoAmarillo";
            txt_TiempoAmarillo.Size = new Size(75, 29);
            txt_TiempoAmarillo.TabIndex = 6;
            txt_TiempoAmarillo.Text = "4";
            txt_TiempoAmarillo.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_TiempoRojo
            // 
            txt_TiempoRojo.BackColor = SystemColors.MenuText;
            txt_TiempoRojo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_TiempoRojo.ForeColor = Color.Red;
            txt_TiempoRojo.Location = new Point(171, 8);
            txt_TiempoRojo.Name = "txt_TiempoRojo";
            txt_TiempoRojo.Size = new Size(75, 29);
            txt_TiempoRojo.TabIndex = 7;
            txt_TiempoRojo.Text = "6";
            txt_TiempoRojo.TextAlign = HorizontalAlignment.Center;
            // 
            // Semaforo_Oeste
            // 
            Semaforo_Oeste.BackColor = Color.Transparent;
            Semaforo_Oeste.Image = Properties.Resources.Semaforo_Rojo_01;
            Semaforo_Oeste.Location = new Point(369, 344);
            Semaforo_Oeste.Name = "Semaforo_Oeste";
            Semaforo_Oeste.Size = new Size(30, 80);
            Semaforo_Oeste.SizeMode = PictureBoxSizeMode.StretchImage;
            Semaforo_Oeste.TabIndex = 8;
            Semaforo_Oeste.TabStop = false;
            // 
            // Semaforo_Este
            // 
            Semaforo_Este.BackColor = Color.Transparent;
            Semaforo_Este.Image = Properties.Resources.Semaforo_Rojo_01;
            Semaforo_Este.Location = new Point(719, 102);
            Semaforo_Este.Name = "Semaforo_Este";
            Semaforo_Este.Size = new Size(30, 80);
            Semaforo_Este.SizeMode = PictureBoxSizeMode.StretchImage;
            Semaforo_Este.TabIndex = 9;
            Semaforo_Este.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Contador_Oeste
            // 
            Contador_Oeste.BackColor = Color.Black;
            Contador_Oeste.Font = new Font("Pixeled", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contador_Oeste.ForeColor = Color.Red;
            Contador_Oeste.Location = new Point(289, 371);
            Contador_Oeste.Name = "Contador_Oeste";
            Contador_Oeste.Size = new Size(74, 53);
            Contador_Oeste.TabIndex = 13;
            Contador_Oeste.Text = "0";
            Contador_Oeste.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Añadir_Carro
            // 
            Añadir_Carro.Location = new Point(90, 102);
            Añadir_Carro.Name = "Añadir_Carro";
            Añadir_Carro.Size = new Size(75, 45);
            Añadir_Carro.TabIndex = 15;
            Añadir_Carro.Text = "Añadir Carros";
            Añadir_Carro.UseVisualStyleBackColor = true;
            Añadir_Carro.Click += Añadir_Carro_Click;
            // 
            // Contador_Norte
            // 
            Contador_Norte.BackColor = Color.Black;
            Contador_Norte.Font = new Font("Pixeled", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contador_Norte.ForeColor = Color.LimeGreen;
            Contador_Norte.Location = new Point(694, 407);
            Contador_Norte.Name = "Contador_Norte";
            Contador_Norte.Size = new Size(74, 53);
            Contador_Norte.TabIndex = 14;
            Contador_Norte.Text = "0";
            Contador_Norte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Semaforo_Norte
            // 
            Semaforo_Norte.BackColor = Color.Transparent;
            Semaforo_Norte.Image = Properties.Resources.Semaforo_Verde_01;
            Semaforo_Norte.Location = new Point(440, 27);
            Semaforo_Norte.Name = "Semaforo_Norte";
            Semaforo_Norte.Size = new Size(30, 80);
            Semaforo_Norte.SizeMode = PictureBoxSizeMode.StretchImage;
            Semaforo_Norte.TabIndex = 16;
            Semaforo_Norte.TabStop = false;
            // 
            // Semaforo_Sur
            // 
            Semaforo_Sur.BackColor = Color.Transparent;
            Semaforo_Sur.Image = Properties.Resources.Semaforo_Verde_01;
            Semaforo_Sur.Location = new Point(658, 380);
            Semaforo_Sur.Name = "Semaforo_Sur";
            Semaforo_Sur.Size = new Size(30, 80);
            Semaforo_Sur.SizeMode = PictureBoxSizeMode.StretchImage;
            Semaforo_Sur.TabIndex = 17;
            Semaforo_Sur.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(252, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 48);
            button1.TabIndex = 18;
            button1.Text = "Nota Importante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cruce_01;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1124, 561);
            Controls.Add(button1);
            Controls.Add(Semaforo_Sur);
            Controls.Add(Semaforo_Norte);
            Controls.Add(Añadir_Carro);
            Controls.Add(Contador_Norte);
            Controls.Add(Contador_Oeste);
            Controls.Add(Semaforo_Este);
            Controls.Add(Semaforo_Oeste);
            Controls.Add(txt_TiempoRojo);
            Controls.Add(txt_TiempoAmarillo);
            Controls.Add(txt_TiempoVerde);
            Controls.Add(btn_Pausar);
            Controls.Add(btn_NuevoTiempo);
            Controls.Add(btn_EstablecerTiempos);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Semaforos_v1.1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Semaforo_Oeste).EndInit();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Este).EndInit();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Norte).EndInit();
            ((System.ComponentModel.ISupportInitialize)Semaforo_Sur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_EstablecerTiempos;
        private Button btn_NuevoTiempo;
        private Button btn_Pausar;
        private TextBox txt_TiempoVerde;
        private TextBox txt_TiempoAmarillo;
        private TextBox txt_TiempoRojo;
        private PictureBox Semaforo_Oeste;
        private PictureBox Semaforo_Este;
        private System.Windows.Forms.Timer timer1;
        private Label Contador_Oeste;
        private Label Contador_Sur_;
        private Button Añadir_Carro;
        private Label Contador_Norte;
        private PictureBox Semaforo_Norte;
        private PictureBox Semaforo_Sur;
        private Button button1;
    }
}
