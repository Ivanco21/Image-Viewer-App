using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewerApp
{
    static class InitMain
    {
        /// <summary>
        /// Simple image viewer
        /// This viewer works for all images in folder and subfolders
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainViewerFrm());
        }
    }
}
