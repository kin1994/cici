using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYKTV
{
    public partial class FrmDiQuDianGe : Form
    {
        public FrmMain father = null;
        public int ver;
        public FrmDiQuDianGe()
        {
            InitializeComponent();
        }

        private void lblLetter_Click(object sender, EventArgs e)
        {
            Label lbl=(Label)sender;
            int num = int.Parse(lbl.Name.Substring(3));
            frmAllSinger singerfrm = new frmAllSinger();
            singerfrm.rowFilter = string.Format("Singertype_id={0}",num);
            singerfrm.ver = Win32.AW_CENTER;
            singerfrm.fatherFrm = this;
            singerfrm.Show();
            this.Hide();
        }

        private void picLetter_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int num = int.Parse(pic.Name.Substring(3));
            frmAllSinger singerfrm = new frmAllSinger();
            singerfrm.rowFilter = string.Format("Singertype_id={0}", num);
            singerfrm.ver = Win32.AW_CENTER;
            singerfrm.fatherFrm = this;
            singerfrm.Show();
            this.Hide();
        }

        private void FrmDiQuDianGe_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle,500,ver);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (father!=null)
            {
                father.Show();
                this.Dispose();
            }
        }
    }
}
