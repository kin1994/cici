using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KTV
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAddSong());
            //Application.Run(new FrmAddSinger());
            //Application.Run(new FrmQuerySong());
            //Application.Run(new FrmSingerPhotoResource());


            //Application.Run(new FrmQuerySinger());
            //Application.Run(new FrmSingerList());
            //Application.Run(new FrmMain());
            //Application.Run(new Form1());
            //Application.Run(new FrmRoot());
            Application.Run(new frmLanding());
            //Application.Run(new frmRoom());

        }
    }
}
