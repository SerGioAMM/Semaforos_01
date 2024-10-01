using Microsoft.VisualBasic.ApplicationServices;
using Semaforos_01.Properties;
using System.DirectoryServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace Semaforos_01
{
    public partial class Form1 : Form
    {
        int Tiempo_Rojo_EsteOeste, Tiempo_Rojo_NorteSur;
        int Tiempo_Verde_EsteOeste, Tiempo_Verde_NorteSur;
        int Tiempo_Amarillo_EsteOeste, Tiempo_Amarillo_NorteSur;

        int Nuevo_Tiempo_Rojo;
        int Nuevo_Tiempo_Verde;
        int Nuevo_Tiempo_Amarillo;

        //0=Rojo 1=Verde 2=Amarillo
        int Estado_Semaforos = 0; 
        int Estado_Semaforos_2 = 1;

        SoundPlayer Sonido_Semaforo = new SoundPlayer("C:\\Users\\SerGio\\Documents\\C#Projects\\Semaforos_01 - Carros - 4Semaforos\\Resources\\light-switch-81967.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Semaforos Este y Oeste
            switch (Estado_Semaforos)
            {
                case 0://Si está en Rojo
                    if (Tiempo_Rojo_EsteOeste == 0)
                    {
                        Cambiar_Color(Semaforo_Oeste, Color.LimeGreen, Tiempo_Verde_EsteOeste, Resources.Semaforo_Verde_01, Contador_Oeste);
                        Cambiar_Color(Semaforo_Este, Color.LimeGreen, Tiempo_Verde_EsteOeste, Resources.Semaforo_Verde_01, Contador_Oeste);

                        Sonido_Semaforo.Play();
                        Estado_Semaforos = 1;

                        break;
                    }
                    Tiempo_Rojo_EsteOeste--;
                    Actualizar_Contador(Tiempo_Rojo_EsteOeste, Contador_Oeste);
                    break;
                case 1://Si está Verde
                    if (Tiempo_Verde_EsteOeste == 0)
                    {
                        Cambiar_Color(Semaforo_Oeste, Color.Yellow, Tiempo_Amarillo_EsteOeste, Resources.Semaforo_Amarillo_01, Contador_Oeste);
                        Cambiar_Color(Semaforo_Este, Color.Yellow, Tiempo_Amarillo_EsteOeste, Resources.Semaforo_Amarillo_01, Contador_Oeste);
                        Sonido_Semaforo.Play();
                        Estado_Semaforos = 2;
                        break;
                    }
                    Tiempo_Verde_EsteOeste--;
                    Actualizar_Contador(Tiempo_Verde_EsteOeste, Contador_Oeste);
                    break;
                case 2://Si está Amarillo
                    if (Tiempo_Amarillo_EsteOeste == 0)
                    {
                        Cambiar_Color(Semaforo_Oeste, Color.Red, Tiempo_Rojo_EsteOeste, Resources.Semaforo_Rojo_01, Contador_Oeste);
                        Cambiar_Color(Semaforo_Este, Color.Red, Tiempo_Rojo_EsteOeste, Resources.Semaforo_Rojo_01, Contador_Oeste);

                        //Reiniciar Tiempos
                        Reiniciar_TIempos_EsteOeste();

                        Actualizar_Contador(Tiempo_Rojo_EsteOeste, Contador_Oeste);

                        Sonido_Semaforo.Play();

                        Estado_Semaforos = 0;

                        break;
                    }
                    Tiempo_Amarillo_EsteOeste--;
                    Actualizar_Contador(Tiempo_Amarillo_EsteOeste, Contador_Oeste);
                    break;

            }

            //Norte y Sur
            switch (Estado_Semaforos_2)
            {
                case 0://Si está en Rojo
                    if (Tiempo_Rojo_NorteSur == 0)
                    {
                        Cambiar_Color(Semaforo_Norte, Color.LimeGreen, Tiempo_Rojo_NorteSur, Resources.Semaforo_Verde_01, Contador_Norte);
                        Cambiar_Color(Semaforo_Sur, Color.LimeGreen, Tiempo_Rojo_NorteSur, Resources.Semaforo_Verde_01, Contador_Norte);

                        Sonido_Semaforo.Play();

                        Estado_Semaforos_2 = 1;

                        break;
                    }
                    Tiempo_Rojo_NorteSur--;
                    Actualizar_Contador(Tiempo_Rojo_NorteSur, Contador_Norte);
                    break;
                case 1:
                    if (Tiempo_Verde_NorteSur == 0)
                    {
                        Cambiar_Color(Semaforo_Norte, Color.Yellow, Tiempo_Amarillo_NorteSur, Resources.Semaforo_Amarillo_01, Contador_Norte);
                        Cambiar_Color(Semaforo_Sur, Color.Yellow, Tiempo_Amarillo_NorteSur, Resources.Semaforo_Amarillo_01, Contador_Norte);

                        Sonido_Semaforo.Play();

                        Estado_Semaforos_2 = 2;
                        break;
                    }
                    Tiempo_Verde_NorteSur--;
                    Actualizar_Contador(Tiempo_Verde_NorteSur, Contador_Norte);

                    break;
                case 2:
                    if (Tiempo_Amarillo_NorteSur == 0)
                    {
                        Cambiar_Color(Semaforo_Norte, Color.Red, Tiempo_Rojo_NorteSur, Resources.Semaforo_Rojo_01, Contador_Norte);
                        Cambiar_Color(Semaforo_Sur, Color.Red, Tiempo_Rojo_NorteSur, Resources.Semaforo_Rojo_01, Contador_Norte);

                        //Reiniciar Tiempos
                        Reiniciar_TIempos_NorteSur();

                        Actualizar_Contador(Tiempo_Rojo_NorteSur, Contador_Norte);

                        Sonido_Semaforo.Play();

                        Estado_Semaforos_2 = 0;

                        break;
                    }
                    Tiempo_Amarillo_NorteSur--;
                    Actualizar_Contador(Tiempo_Amarillo_NorteSur, Contador_Norte);
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nuevo_Tiempo_Verde = int.Parse(txt_TiempoVerde.Text);
            Nuevo_Tiempo_Amarillo = int.Parse(txt_TiempoAmarillo.Text);
            Nuevo_Tiempo_Rojo = int.Parse(txt_TiempoRojo.Text);
            Actualizar_Contador(Nuevo_Tiempo_Rojo, Contador_Oeste);
            Actualizar_Contador(Nuevo_Tiempo_Rojo / 2, Contador_Norte);

        }
        static void Cambiar_Color(PictureBox Semaforo, Color _Color, int Tiempo_Color, Image imagen, Label Contador)
        {
            Semaforo.Image = imagen;
            Contador.ForeColor = _Color;
            Contador.Text = Tiempo_Color.ToString();
        }
        static void Actualizar_Contador(int Tiempo_Color, Label Contador)
        {
            Contador.Text = Tiempo_Color.ToString();
        }
        public void Reiniciar_TIempos_EsteOeste()
        {
            Tiempo_Verde_EsteOeste = Nuevo_Tiempo_Verde;
            Tiempo_Amarillo_EsteOeste = Nuevo_Tiempo_Amarillo;
            Tiempo_Rojo_EsteOeste = Nuevo_Tiempo_Rojo;


        }
        public void Reiniciar_TIempos_NorteSur()
        {
            if (Nuevo_Tiempo_Rojo % 2 == 0)
            {
                Tiempo_Verde_NorteSur = (Nuevo_Tiempo_Rojo / 2);
                Tiempo_Amarillo_NorteSur = (Nuevo_Tiempo_Rojo / 2)-1;

            }
            else
            {
                Tiempo_Verde_NorteSur = (Nuevo_Tiempo_Rojo / 2)+1;
                Tiempo_Amarillo_NorteSur = (Nuevo_Tiempo_Rojo / 2);
            }
            
            Tiempo_Rojo_NorteSur = (Nuevo_Tiempo_Verde + Nuevo_Tiempo_Amarillo) + 1;

        }

        private void btn_NuevoTiempo_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (btn_NuevoTiempo.Text == "Cancelar")
            {
                txt_TiempoVerde.Enabled = false;
                txt_TiempoAmarillo.Enabled = false;
                txt_TiempoRojo.Enabled = false;
                btn_EstablecerTiempos.Enabled = false;

                btn_Pausar.Enabled = true;
                //btn_Ejecutar.Enabled = true;

                btn_NuevoTiempo.Text = "Nuevo Tiempo";
            }
            else
            {

                txt_TiempoVerde.Enabled = true;
                txt_TiempoAmarillo.Enabled = true;
                txt_TiempoRojo.Enabled = true;
                btn_EstablecerTiempos.Enabled = true;

                btn_Pausar.Enabled = false;
                //btn_Ejecutar.Enabled = false;

                txt_TiempoVerde.Focus();

                btn_NuevoTiempo.Text = "Cancelar";
            }


        }

        private void btn_EstablecerTiempos_Click(object sender, EventArgs e)
        {
            try {
                timer1.Start();
                btn_NuevoTiempo.Text = "Nuevo Tiempo";
                btn_Pausar.Text = "Pausar";
                txt_TiempoVerde.Enabled = false;
                txt_TiempoAmarillo.Enabled = false;
                txt_TiempoRojo.Enabled = false;
                btn_EstablecerTiempos.Enabled = false;

                btn_Pausar.Enabled = true;
                //btn_Ejecutar.Enabled = true;
                btn_NuevoTiempo.Enabled = true;

                //Nuevos Tiempos Capturados desde las cajas de Texto
                Nuevo_Tiempo_Verde = int.Parse(txt_TiempoVerde.Text);
                Nuevo_Tiempo_Amarillo = int.Parse(txt_TiempoAmarillo.Text);
                Nuevo_Tiempo_Rojo = int.Parse(txt_TiempoRojo.Text);

                Reiniciar_TIempos_EsteOeste();
                Reiniciar_TIempos_NorteSur();
            }
            catch
            {
                MessageBox.Show("Por favor ingresar un número válido.");
            }
        }

        private void btn_Pausar_Click(object sender, EventArgs e)
        {
            if (btn_Pausar.Text == "Reanudar")
            {
                timer1.Start();
                btn_Pausar.Text = "Pausar";
            }
            else
            {
                timer1.Stop();
                btn_Pausar.Text = "Reanudar";
            }
        }
        public void Skin_Carro(PictureBox Carro, Image imagen, Image imagen2, Image imagen3, Image imagen4)
        {
            Random random = new Random();
            int Skin = random.Next(1, 100);
            if (Skin > 0 && Skin <= 25)
            {
                Carro.Image = imagen;

            }
            else if (Skin > 25 && Skin <= 50)
            {
                Carro.Image = imagen2;
            }
            else if (Skin > 50 && Skin <= 75)
            {
                Carro.Image = imagen3;
            }
            else
            {
                Carro.Image = imagen4;
            }
        }

        private void Añadir_Carro_Click(object sender, EventArgs e)
            {
                // Crear el Carro Izquiero
                PictureBox Carro_LadoIzquierdo = new PictureBox();
                Carro_LadoIzquierdo.BackColor = Color.Transparent;
                Carro_LadoIzquierdo.SizeMode = PictureBoxSizeMode.StretchImage;
                Carro_LadoIzquierdo.Size = new Size(59, 56);
                Carro_LadoIzquierdo.Location = new Point(20, 310);

                // Crear el Carro Derecho
                PictureBox Carro_LadoDerecho = new PictureBox();
                Carro_LadoDerecho.BackColor = Color.Transparent;
                Carro_LadoDerecho.SizeMode = PictureBoxSizeMode.StretchImage;
                Carro_LadoDerecho.Size = new Size(59, 56);
                Carro_LadoDerecho.Location = new Point(1040, 210);

                // Crear el Carro Arriba
                PictureBox Carro_Arriba = new PictureBox();
                Carro_Arriba.BackColor = Color.Transparent;
                Carro_Arriba.SizeMode = PictureBoxSizeMode.StretchImage;
                Carro_Arriba.Size = new Size(59, 56);
                Carro_Arriba.Location = new Point(475, -20);

                // Crear el Carro Abajo
                PictureBox Carro_Abajo = new PictureBox();
                Carro_Abajo.BackColor = Color.Transparent;
                Carro_Abajo.SizeMode = PictureBoxSizeMode.StretchImage;
                Carro_Abajo.Size = new Size(59, 56);
                Carro_Abajo.Location = new Point(575, 535);

                Skin_Carro(Carro_LadoIzquierdo, Resources.Carro_Derecha_01, Resources.Carro_Derecha_02, Resources.Carro_Derecha_03, Resources.Carro_Derecha_04);
                Skin_Carro(Carro_LadoDerecho, Resources.Carro_Izquierda_01, Resources.Carro_Izquierda_02, Resources.Carro_Izquierda_03, Resources.Carro_Izquierda_04);
                Skin_Carro(Carro_Abajo, Resources.Carro_Arriba_01, Resources.Carro_Arriba_02, Resources.Carro_Arriba_03, Resources.Carro_Arriba_04);
                Skin_Carro(Carro_Arriba, Resources.Carro_Abajo_01, Resources.Carro_Abajo_02, Resources.Carro_Abajo_03, Resources.Carro_Abajo_04);

                // Agregar los carros al formulario
                this.Controls.Add(Carro_LadoIzquierdo);
                this.Controls.Add(Carro_LadoDerecho);
                this.Controls.Add(Carro_Arriba);
                this.Controls.Add(Carro_Abajo);

                // Crear y configurar el temporizador para mover los carros
                System.Windows.Forms.Timer moveTimer = new System.Windows.Forms.Timer();
                moveTimer.Interval = 100;
                moveTimer.Tick += (s, ev) =>
                {
                    //Carro del laod izquierdo
                    if ((Carro_LadoIzquierdo.Left >= 315 && Carro_LadoIzquierdo.Left <= 415) && (Estado_Semaforos == 0))
                    {
                        // Mover el carro hacia la derecha
                        Carro_LadoIzquierdo.Left += 0;
                    }
                    else if ((Carro_LadoIzquierdo.Left >= 315 && Carro_LadoIzquierdo.Left <= 660) && (Estado_Semaforos == 2))
                    {
                        Carro_LadoIzquierdo.Left += 30;
                    }
                    else
                    {
                        // Mover el carro hacia la derecha
                        Carro_LadoIzquierdo.Left += 10;
                    }

                    //Carro del lado derecho
                    if ((Carro_LadoDerecho.Left <= 755 && Carro_LadoDerecho.Left >= 655) && (Estado_Semaforos == 0))
                    {
                        // Mover el carro hacia la Izquierda
                        Carro_LadoDerecho.Left -= 0;
                    }
                    else if ((Carro_LadoDerecho.Left <= 755 && Carro_LadoDerecho.Left >= 320) && (Estado_Semaforos == 2))
                    {
                        // Mover el carro hacia la Izquierda
                        Carro_LadoDerecho.Left -= 30;
                    }
                    else
                    {
                        // Mover el carro hacia la Izquierda
                        Carro_LadoDerecho.Left -= 10;
                    }

                    //Carro de Arriba
                    if ((Carro_Arriba.Top >= 50 && Carro_Arriba.Top <= 150) && (Estado_Semaforos_2 == 0))
                    {
                        // Mover el carro hacia Abajo
                        Carro_Arriba.Top += 0;
                    }
                    else if ((Carro_Arriba.Top >= 100 && Carro_Arriba.Top <= 425) && (Estado_Semaforos_2 == 2))
                    {
                        // Mover el carro hacia Abajo
                        Carro_Arriba.Top += 30;
                    }
                    else
                    {
                        // Mover el carro hacia Abajo
                        Carro_Arriba.Top += 10;
                    }

                    //575, 535
                    if ((Carro_Abajo.Top <= 455 && Carro_Abajo.Top >= 355) && (Estado_Semaforos_2 == 0))
                    {
                        // Mover el carro hacia Arriba
                        Carro_Abajo.Top -= 0;
                    }
                    else if ((Carro_Abajo.Top <= 455 && Carro_Abajo.Top >= 80) && (Estado_Semaforos_2 == 2))
                    {
                        // Mover el carro hacia Arriba
                        Carro_Abajo.Top -= 30;
                    }
                    else
                    {
                        // Mover el carro hacia Arriba
                        Carro_Abajo.Top -= 10;
                    }

                    // Verificar si los carros han llegado a la posición final
                    if ((Carro_LadoIzquierdo.Left >= 770 && Carro_LadoDerecho.Left <= 20) && (Carro_Arriba.Top >= 500 && Carro_Abajo.Top <= 20))
                    {
                        this.Controls.Remove(Carro_LadoIzquierdo);
                        Carro_LadoIzquierdo.Dispose();

                        this.Controls.Remove(Carro_LadoDerecho);
                        Carro_LadoDerecho.Dispose();

                        this.Controls.Remove(Carro_Arriba);
                        Carro_Arriba.Dispose();

                        this.Controls.Remove(Carro_Abajo);
                        Carro_Abajo.Dispose();

                        moveTimer.Dispose();
                        moveTimer.Stop();

                    }

                };

        // Iniciar el movimiento
        moveTimer.Start();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El usuario solo podrá controlar el Contador Izquierdo\n\nPara mejores resultados usar valores pares.");
        }
    }
}
