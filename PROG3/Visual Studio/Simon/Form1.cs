using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon {
    public partial class Form1 : Form {
        //variables globales
        bool salir;
        bool patron;
        bool clickear = false;
        bool juego = false;
        int OFF;
        int cont = 1;
        List<int> simon = new List<int>();
        List<int> jugada = new List<int>();
        System.Media.SoundPlayer s1 = new System.Media.SoundPlayer("Resources/sonido1.wav");
        System.Media.SoundPlayer s2 = new System.Media.SoundPlayer("Resources/sonido2.wav");
        System.Media.SoundPlayer s3 = new System.Media.SoundPlayer("Resources/sonido3.wav");
        System.Media.SoundPlayer s4 = new System.Media.SoundPlayer("Resources/sonido4.wav");

        public Form1() {
            InitializeComponent();
        }

        public void Juego() { //metodo principal del juego
            juego = true;
            btn_inciar.Text = "Partida en curso...";
            while (!salir) {
                clickear = true;
                lbl_estado.Text = "Espere a que termine el patron...";
                Thread.Sleep(500);
                simon.Add(Aleatorio.metodoAl()); //se cargan numeros, de forma aleatoria, en Simon
                int ultimo = simon[simon.Count - 1];
                lbl_nivel.Text = "Nivel: " + cont;
                foreach (int i in simon) { //encargado de iluminar los botones en base al patron dado por Simon
                    if (i == 1) {
                        s1.Play();
                        btn_b1.BackColor = Color.Red;
                        Thread.Sleep(500);
                        btn_b1.BackColor = Color.Maroon;
                        Thread.Sleep(500);
                    } else if (i == 2) {
                        s2.Play();
                        btn_b2.BackColor = Color.Blue;
                        Thread.Sleep(500);
                        btn_b2.BackColor = Color.Navy;
                        Thread.Sleep(500);
                    } else if (i == 3) {
                        s3.Play();
                        btn_b3.BackColor = Color.Lime;
                        Thread.Sleep(500);
                        btn_b3.BackColor = Color.DarkGreen;
                        Thread.Sleep(500);
                    } else if (i == 4) {
                        s4.Play();
                        btn_b4.BackColor = Color.Yellow;
                        Thread.Sleep(500);
                        btn_b4.BackColor = Color.DarkGoldenrod;
                        Thread.Sleep(500);
                    }
                } 
                clickear = false;
                do { //ciclo que impide continuar con el codigo si el usuario no replica el patron
                    lbl_estado.Text = "Replique el patron";
                } while (jugada.Count() < simon.Count()); 
                if (!jugada.SequenceEqual(simon)) { //si el patron no coincide con el de Simon la partida termina, saliendo del ciclo while 
                    lbl_estado.Text = "Mal :(";
                    lbl_patron.Text = "Podes mirar el patron";
                    btn_inciar.Text = "Jugar de nuevo";
                    patron = true;
                    salir = true;
                    new Thread(Perder).Start();
                    Perder();
                } else if (jugada.SequenceEqual(simon)) { //si el patron coincide con el de Simon el juego continua, aumentando la dificultad del nivel
                    lbl_estado.Text = "Buena!!!";
                    Thread.Sleep(1000);
                    cont++;
                    jugada.Clear();
                }
            }
        }

        public void Colores(int ON) { //encargado de iluminar y apagar los botones cuando el usuario hace click, utilizando un timer
            switch (ON) {
                case 1:
                    btn_b1.BackColor = Color.Red;
                    timer_iluminar.Start();
                    OFF = 1;
                    break;
                case 2:
                    btn_b2.BackColor = Color.Blue;
                    timer_iluminar.Start();
                    OFF = 2;
                    break;
                case 3:
                    btn_b3.BackColor = Color.Lime;
                    timer_iluminar.Start();
                    OFF = 3;
                    break;
                case 4:
                    btn_b4.BackColor = Color.Yellow;
                    timer_iluminar.Start();
                    OFF = 4;
                    break;
            }
        }

        public void Perder() { //ejecuta un juego de luces tras perder
            clickear = true;
            Thread.Sleep(400);
            for (int i = 0; i < 3; i++) {
                btn_b1.BackColor = Color.Red;
                btn_b2.BackColor = Color.Red;
                btn_b3.BackColor = Color.Red;
                btn_b4.BackColor = Color.Red;
                Thread.Sleep(400);
                btn_b1.BackColor = Color.Maroon;
                btn_b2.BackColor = Color.Maroon;
                btn_b3.BackColor = Color.Maroon;
                btn_b4.BackColor = Color.Maroon;
                Thread.Sleep(400);
            }
            btn_b1.BackColor = Color.Maroon;
            btn_b2.BackColor = Color.Navy;
            btn_b3.BackColor = Color.DarkGreen;
            btn_b4.BackColor = Color.DarkGoldenrod;
            clickear = false;
            juego = false;
        }

        private void timer_iluminar_Tick(object sender, EventArgs e) { //timer que ayuda al metodo Colores();
            switch (OFF) {
                case 1:
                    timer_iluminar.Stop();
                    btn_b1.BackColor = Color.Maroon;
                    break;
                case 2:
                    timer_iluminar.Stop();
                    btn_b2.BackColor = Color.Navy;
                    break;
                case 3:
                    timer_iluminar.Stop();
                    btn_b3.BackColor = Color.DarkGreen;
                    break;
                case 4:
                    timer_iluminar.Stop();
                    btn_b4.BackColor = Color.DarkGoldenrod;
                    break;
            }
        }

        private void btn_inciar_Click(object sender, EventArgs e) { //boton que inicia el juego
            if (clickear == false && juego == false) { //control para evitar ser utilizado cuando no corresponda
                lbl_patron.Text = "";
                jugada.Clear();
                simon.Clear();
                cont = 1;
                patron = false;
                salir = false;
                new Thread(Juego).Start();
            } 
        }

        private void btn_b1_Click(object sender, EventArgs e) {
            if (clickear == false) { //control para evitar ser utilizado cuando no corresponda
                Colores(1);
                s1.Play();
                jugada.Add(1);
            }
        }

        private void btn_b2_Click(object sender, EventArgs e) {
            if (clickear == false) { //control para evitar ser utilizado cuando no corresponda
                Colores(2);
                s2.Play();
                jugada.Add(2);
            }
        }

        private void btn_b3_Click(object sender, EventArgs e) {
            if (clickear == false) { //control para evitar ser utilizado cuando no corresponda
                Colores(3);
                s3.Play();
                jugada.Add(3);
            }
        }

        private void btn_b4_Click(object sender, EventArgs e) {
            if (clickear == false) { //control para evitar ser utilizado cuando no corresponda
                Colores(4);
                s4.Play();
                jugada.Add(4);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e) { //carga inicial del form
            CheckForIllegalCrossThreadCalls = false;
            lbl_patron.Text = "";
            lbl_estado.Text = "Click en 'JUGAR' para comenzar una partida";
            lbl_nivel.Text = "Nivel: ";
            btn_b1.Text = "";
            btn_b2.Text = "";
            btn_b3.Text = "";
            btn_b4.Text = "";
            btn_b1.BackColor = Color.Maroon;
            btn_b2.BackColor = Color.Navy;
            btn_b3.BackColor = Color.DarkGreen;
            btn_b4.BackColor = Color.DarkGoldenrod;
        }

        private void btn_patron_Click(object sender, EventArgs e) {
            if (patron == true) {
                var ms = string.Join("-", simon);
                var mj = string.Join("-", jugada);
                MessageBox.Show("Patron de Simon: " + Environment.NewLine + ms + Environment.NewLine + "Su patron " + Environment.NewLine + mj, "PATRON");
            } else if (patron == false) { //control para evitar ser utilizado cuando no corresponda
                MessageBox.Show("NO PODES VER EL PATRON DURANTE O ANTES DE LA PARTIDA", "PATRON");
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
