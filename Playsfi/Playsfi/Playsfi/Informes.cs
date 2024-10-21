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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        public void informeFavs() {
            NombreYFavs nomF = new NombreYFavs();
            crvInformes.ReportSource = nomF;
        }

        public void informeCats() { 
            Cats c = new Cats();
            crvInformes.ReportSource = c;
        }

        public void informeDescat() { 
            Descatalogados desc = new Descatalogados();
            crvInformes.ReportSource = desc;
        }
    }
}
