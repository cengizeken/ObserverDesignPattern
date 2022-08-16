using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aselsan.RadarDonanimTest.ObserverDesignPattern
{
    public partial class AnaForm : Form
    {
        AnaFormKontrol anaFormKontrol;
        DcGucTestleriKontrol dcGucTestleriKontrol;
        DcGucTestTestleriModel dcGucTestleriModel = new DcGucTestTestleriModel();

        public AnaForm()
        {
            InitializeComponent();
            this.anaFormKontrol = new AnaFormKontrol();
            this.dcGucTestleriKontrol = new DcGucTestleriKontrol();
            dcGucTestleriModel.AddObserver(this.anaFormKontrol);
            dcGucTestleriModel.AddObserver(this.dcGucTestleriKontrol);
        }
        
        private void btnOlcumeBasla_Click(object sender, EventArgs e)
        {
            this.dcGucTestleriModel.DcGucTestlerineBasla();
        }
    }
}
