using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playsfi
{
    public partial class Form1 : Form
    {
        private int cont = 0;
        private Timer tiempo;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            tiempo = new Timer();
            tiempo.Interval = 100; // intervalo en miliSegs
            tiempo.Tick += Tiempo_Tick;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (pgbBarra.Value < 100)
            {
                pgbBarra.Value += 5;

                //fotos
                //estó efectua el cambio de fotos
                if (pgbBarra.Value % 20 == 0)
                {
                    pbFotos.Image = imgCarga.Images[cont];
                    cont = (cont + 1) % imgCarga.Images.Count;

                }

                //reiniciar el contador
                if (cont == imgCarga.Images.Count)
                {
                    cont = 0;
                }
            }
            else { 
                tiempo.Stop();
                Acceso acceso = new Acceso();
                acceso.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiempo.Start();

        }
    }
}
