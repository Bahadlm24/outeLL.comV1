using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outeLL.comV1
{
    public partial class frmPopupmenu : Form
    {
        public frmPopupmenu()
        {
            InitializeComponent();
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac ==3)
            {
                MessageBox.Show(sayac.ToString());
                timer1.Stop();
                this.Close();
            }
        }
    }
}
