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
            appState.extFilter = Properties.Resources.fileExtentions;

            if (AcessChecker.CheckAccessToFolders(appState.rootFolderPath))
            {
                TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
            }
            else
            {
                SetNullInitState(appState.rootFolderPath);
            }
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

                if (AcessChecker.CheckAccessToFolders(appState.rootFolderPath))
                {
                    TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
                    pbViewer.Image = null;
                }
                else
                {
                    SetNullInitState(appState.rootFolderPath);
                }
            }
        }

        private void treeGeneral_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (pbViewer.Image != null)
            {
                pbViewer.Image.Dispose();
            }

            string pathToDirOrFile = e.Node.Tag.ToString();
            FileAttributes attr = File.GetAttributes(pathToDirOrFile);
            string filePth;

            if (!attr.HasFlag(FileAttributes.Directory))
            {
                filePth = e.Node.Tag.ToString();

                try
                {
                    Image img = Image.FromFile(filePth);
                    pbViewer.Image = img;
                    pbViewer.SizeMode = PictureBoxSizeMode.Zoom;

                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show($"File: {filePth} - not valid for display!", "File read error");
                }

            }
            else
            {
                pbViewer.Image = null;
            }
        }

        private void rootDirWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (AcessChecker.CheckAccessToFolders(appState.rootFolderPath))
            {
                TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
            }
            else
            {
                SetNullInitState(appState.rootFolderPath);
            }
        }

        private void rootDirWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (AcessChecker.CheckAccessToFolders(appState.rootFolderPath))
            {
                TreeViewWorker.PopulateTreeView(treeGeneral, appState.rootFolderPath, appState.extFilter);
            }
            else
            {
                SetNullInitState(appState.rootFolderPath);
            }
        }

        private void MainViewerFrm_ResizeEnd(object sender, EventArgs e)
        {
            pbViewer.Refresh();
        }

        private void SetNullInitState(string pth)
        {
            treeGeneral.Nodes.Clear();
            pbViewer.Image = null;
            MessageBox.Show($"Acсess denied for one or some folders on folder path - {pth} {Environment.NewLine} " +
                            $"Change current folder for correct work!", "Acсess error");
        }
    }
}
