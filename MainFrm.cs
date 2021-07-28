using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageViewerApp
{
    public partial class MainViewerFrm : Form
    {
        private AppState appState;

        public MainViewerFrm()
        {
            InitializeComponent();
            appState = new AppState();
        }

        private void MainViewerFrm_Load(object sender, EventArgs e)
        {
            string initPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            tbRootPath.Text = initPath;
            rootDirWatcher.Path = initPath;

            appState.rootFolderPath = initPath;
            appState.extFilter = ConfigurationManager.AppSettings["viewExtent"];

            TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
        }

        private void btnRootDirSelect_Click(object sender, EventArgs e)
        {
            DialogResult selectRes= dlgRootSelect.ShowDialog();
            if (selectRes == DialogResult.OK)
            {
                tbRootPath.Text = dlgRootSelect.SelectedPath;
            }
        }

        private void tbRootPath_TextChanged(object sender, EventArgs e)
        {
            if (appState.rootFolderPath != null )
            {
                appState.rootFolderPath = tbRootPath.Text;
                TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
            }
        }

        private void rootDirWatcher_Changed(object sender, FileSystemEventArgs e)
        {
           TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
        }

        private void rootDirWatcher_Renamed(object sender, RenamedEventArgs e)
        {
           TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
        }

    }
}
