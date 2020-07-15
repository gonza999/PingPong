using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Windows
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            EmpezarJuego();
        }
        int scoreLocal = 0;
        int scoreVisitante = 0;

        Random random = new Random();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EmpezarJuego()
        {
            timer1.Start();
            timer2.Start();
            pbxBall.Location = new Point(450, 250);

        }

        double ballX = 5;
        double ballY = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbxPlayerUno.Top = MousePosition.Y;
            lblPuntoLocal.Text = $"{scoreLocal}";
            lblPuntoVisitante.Text = $"{scoreVisitante}";


            pbxBall.Left += (int)ballX;
            pbxBall.Top += (int)ballY;

            if (pbxBall.Left+pbxBall.Width<0 )
            {
                pbxBall.Location = new Point(450, 250);
                scoreVisitante++;
            }
            if (pbxBall.Left + pbxBall.Width > 900)
            {
                pbxBall.Location = new Point(450, 250);
                scoreLocal++;
            }
            if (pbxBall.Top + pbxBall.Height < 0 || pbxBall.Top + pbxBall.Height > 500)
            {
                ballY = -ballY;
            }
            if (pbxBall.Bounds.IntersectsWith(pbxPlayerUno.Bounds) || pbxBall.Bounds.IntersectsWith(pbxPlayerDos.Bounds))
            {
                ballX = -ballX;
            }

                pbxPlayerDos.Top = pbxBall.Top-10 ;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
