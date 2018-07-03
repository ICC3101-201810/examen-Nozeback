using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExamenPacman
{
    public partial class Form1 : Form
    {
        Usuarios user=new Usuarios();
        bool arriba;
        bool abajo;
        bool izq;
        bool der;
        int score=0;
        //velocidades
        int vel = 20;
        int fantasmaRojoX = 25;
        int fantasmaRojoY = 25;
        int fantasmaRosadoX = 25;
        int fantasmaRosadoY = 25;

        
        public int Random(string eje)
        {
            Random rnd = new Random();
            int rt;
            if (eje == "x")
            {
                rt = rnd.Next(100, 1200);
                return rt;
            }
            else return rt = rnd.Next(200, 700);
        }


        public Form1()
        {
            foreach (Usuarios a in Lista.CargarDatos("registro.txt"))
            {
                Lista.registro.Add(a);
            }
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            
            if(Usuario == null || Contra ==null)
            {
                DialogResult l = new DialogResult();
                l = MessageBox.Show("el usuario no existe, crea uno nuevo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (l == DialogResult.Cancel)
                {
                    Lista.Guardar(Lista.registro);
                    Environment.Exit(0);
                }
            }
            else {
                user.NombreUsuario = Usuario.Text;
                user.Contrasena = Contra.Text;
                int s = 0;
                foreach (Usuarios p in Lista.registro)
                {
                    if (!user.ChequeoContra(Usuario.Text, Contra.Text))
                    {
                        s++;
                        panelJuego.Visible = true;
                        label5.Text = "START";
                        label5.Visible = true;
                        Thread.Sleep(2000);
                        label5.Visible = false;
                        temporizador.Enabled = true;
                    }
                }
                if (s == 0)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("el usuario no existe, crea uno nuevo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (r == DialogResult.OK)
                    {
                        label2.Visible = false;
                        Usuario.Visible = false;
                        Contrasena.Visible = false;
                        Contra.Visible = false;
                        Ingresar.Visible = false;
                        Crear.Visible = false;
                        panelNuevoUsuario.Visible = true;
                        textBox1 = Usuario;
                        textBox2 = Contra;
                    }
                    else
                    {
                        Lista.Guardar(Lista.registro);
                        Environment.Exit(0);
                    }
                }
            }
            
            
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            Usuario.Visible = false;
            Contrasena.Visible = false;
            Contra.Visible = false;
            Ingresar.Visible = false;
            Crear.Visible = false;
            panelNuevoUsuario.Visible = true;

        }
        private void CloseCancel(FormClosingEventArgs e)
        {
            if (MessageBox.Show("seguro que quieres salir de juego?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else Lista.Guardar(Lista.registro);
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void KeyAbajo(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                der = true;
                ThePacMan.Image = Properties.Resources.pacman_right;
                System.Threading.Thread.Sleep(20);
                ThePacMan.Image = Properties.Resources.pacman_right1;
                System.Threading.Thread.Sleep(20);
            }
            if (e.KeyCode == Keys.Left)
            {
                izq = true;
                ThePacMan.Image = Properties.Resources.pacman_left;
                System.Threading.Thread.Sleep(20);
                ThePacMan.Image = Properties.Resources.pacman_left1;
                System.Threading.Thread.Sleep(20);
            }
            if (e.KeyCode == Keys.Up)
            {
                arriba = true;
                ThePacMan.Image = Properties.Resources.pacman_up;
                System.Threading.Thread.Sleep(20);
                ThePacMan.Image = Properties.Resources.pacman_up1;
                System.Threading.Thread.Sleep(20);
            }
            if (e.KeyCode == Keys.Down)
            {
                abajo = true;
                ThePacMan.Image = Properties.Resources.pacman_down;
                System.Threading.Thread.Sleep(20);
                ThePacMan.Image = Properties.Resources.pacman_down1;
                System.Threading.Thread.Sleep(20);
            }

        }

        private void KeyArriba(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                der = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                izq = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                arriba = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                abajo = false;
            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            aparecimientoCherry.Enabled = true;
            aprecimientoChiri.Enabled = true;
            Score.Text = "Score:" + score;
            if (arriba)
            {
                ThePacMan.Top += vel;
            }
            if (abajo)
            {
                ThePacMan.Top -= vel;
            }
            if (der)
            {
                ThePacMan.Left -= vel;
            }
            if (izq)
            {
                ThePacMan.Left += vel;
            }
            //seguimiento fantasma rojo
            if (ThePacMan.Top > RedGhost.Top)
            {
                RedGhost.Top += fantasmaRojoY;
            }
            if (ThePacMan.Top > RedGhost.Top)
            {
                RedGhost.Top += fantasmaRojoY;
            }
            if (ThePacMan.Top < RedGhost.Top)
            {
                RedGhost.Top -= fantasmaRojoY;
            }
            if (ThePacMan.Left > RedGhost.Left)
            {
                RedGhost.Left += fantasmaRojoX;
            }
            if (ThePacMan.Left < RedGhost.Left)
            {
                RedGhost.Left -= fantasmaRojoX;
            }
            // seguimiento fanyasma rosado
            if (ThePacMan.Top > PinkGhost.Top)
            {
                PinkGhost.Top += fantasmaRosadoY;
            }
            if (ThePacMan.Top < PinkGhost.Top)
            {
                PinkGhost.Top -= fantasmaRosadoY;
            }
            if (ThePacMan.Left > PinkGhost.Left)
            {
                PinkGhost.Left += fantasmaRosadoX;
            }
            if (ThePacMan.Left < PinkGhost.Left)
            {
                PinkGhost.Left -= fantasmaRosadoX;
            }
            //puntaje
            if(ThePacMan.Bounds.IntersectsWith(Cherry.Bounds))
            {
                score += 10;
                Cherry.Visible=false;
                Cherry.Top = 0;
                Cherry.Left = 0;
                tiempocherry.Stop();
                aparecimientoCherry.Enabled = true;

            }
            if (ThePacMan.Bounds.IntersectsWith(chirimoya.Bounds))
            {
                score += 15;
                chirimoya.Visible = false;
                chirimoya.Top = 0;
                chirimoya.Left = 0;
                timerchiri.Stop();
                aprecimientoChiri.Enabled = true;
            }
            if (ThePacMan.Bounds.IntersectsWith(RedGhost.Bounds))
            {
                ThePacMan.Left = 650;
                ThePacMan.Top = 400;
                label5.Text = "GAME OVER";
                label5.Visible = true;
                temporizador.Stop();
            }
            if (ThePacMan.Bounds.IntersectsWith(PinkGhost.Bounds))
            {
                ThePacMan.Left = 650;
                ThePacMan.Top = 400;
                label5.Text = "GAME OVER";
                label5.Visible = true;
                temporizador.Stop();
            }
            if (ThePacMan.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                ThePacMan.Left = 650;
                ThePacMan.Top = 400;
                label5.Text = "GAME OVER";
                label5.Visible = true;
                temporizador.Stop();
            }
            if (ThePacMan.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                ThePacMan.Left = 650;
                ThePacMan.Top = 400;
                label5.Text = "GAME OVER";
                label5.Visible = true;
                temporizador.Stop();
            }
            if (ThePacMan.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                ThePacMan.Left = 650;
                ThePacMan.Top = 400;
                label5.Text = "GAME OVER";
                label5.Visible = true;
                temporizador.Stop();
            }
            if (ThePacMan.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                ThePacMan.Left = 650;
                ThePacMan.Top = 400;
                label5.Text = "GAME OVER";
                label5.Visible = true;
                temporizador.Stop();
            }

        }

        private void panelNuevoUsuario_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void Creacion_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox2 == null)
            {
                DialogResult l = new DialogResult();
                l = MessageBox.Show("ingresa todos los datos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (l == DialogResult.Cancel)
                {
                    label2.Visible = true;
                    Usuario.Visible = true;
                    Contrasena.Visible = true;
                    Contra.Visible = true;
                    Ingresar.Visible = true;
                    Crear.Visible = true;
                    panelNuevoUsuario.Visible = false;
                    textBox1.Clear();
                    textBox2.Clear();
                }
                
            }
            else
            {
                int r = 0;
                List<int> spg = new List<int>();
                user.NombreUsuario = textBox1.Text;
                user.Contrasena = textBox2.Text;
                user.ScoreAcumulado = 0;
                user.ScorePerGame = spg;
                if (Lista.registro.Count() > 0)
                {
                    foreach (Usuarios u in Lista.registro)
                    {
                        if (user.ChequeoContra(textBox1.Text, textBox2.Text) == true)
                        {
                            r++;
                        }

                    }
                    if (r == 0)
                    {
                        Lista.registro.Add(user);
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                else Lista.registro.Add(user);

                label2.Visible = true;
                Usuario.Visible = true;
                Contrasena.Visible = true;
                Contra.Visible = true;
                Ingresar.Visible = true;
                Crear.Visible = true;
                panelNuevoUsuario.Visible = false;
                textBox1.Clear();
                textBox2.Clear();
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nombre del nuevo usuario
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //contrasena nuevo usuario
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void aparecimientoCherry_Tick(object sender, EventArgs e)
        {
            tiempocherry.Enabled = true;
            Cherry.Top = Random("y");
            Cherry.Left = Random("x");

        }

        private void aprecimientoChiri_Tick(object sender, EventArgs e)
        {
            timerchiri.Enabled = true;
            chirimoya.Top = Random("y");
            chirimoya.Left = Random("x");
        }

        private void timerchiri_Tick(object sender, EventArgs e)
        {
            aprecimientoChiri.Enabled = true;
            chirimoya.Top = 0;
            chirimoya.Left = 0;
        }

        private void tiempocherry_Tick(object sender, EventArgs e)
        {
            aparecimientoCherry.Enabled = true;
            Cherry.Top = 0;
            Cherry.Left = 0;

        }

        private void panelJuego_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                Lista.Guardar(Lista.registro);
                Application.Exit();
            }
        }

        private void volver1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            Usuario.Visible = true;
            Contrasena.Visible = true;
            Contra.Visible = true;
            Ingresar.Visible = true;
            Crear.Visible = true;
            panelNuevoUsuario.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void volver2_Click(object sender, EventArgs e)
        {
            temporizador.Stop();
            panelJuego.Visible = false;
        }

        
    }
}
