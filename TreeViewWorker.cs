using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageViewerApp
{
    static class TreeViewWorker
    {

        static public void PopulateTreeView(TreeView tree, string rootFolderPth,string fileFilter)
        {
            if (tree.Nodes.Count >= 1)
            {
                tree.Nodes.Clear();
            }

            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(rootFolderPth);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                
                GetDirectories(info.GetDirectories(), rootNode,  fileFilter);
                GetFiles(info.FullName, rootNode, fileFilter);

                tree.Nodes.Add(rootNode);
            }
        }

        static private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo, string fileFilter)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir.FullName;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();

                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode, fileFilter);
                    GetFiles(subDir.FullName, aNode, fileFilter);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        static private void GetFiles(string dir, TreeNode td, string fileFilter)
        {
            string[] Files = GetFilesByManyFilters(dir, fileFilter,SearchOption.TopDirectoryOnly);

            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.ImageKey = "file";
                tds.StateImageIndex = 1;

            }
        }

        private static string[] GetFilesByManyFilters(string sourceFolder, string filters, System.IO.SearchOption searchOption)
        {
            return filters.Split('|').SelectMany(filter => System.IO.Directory.GetFiles(sourceFolder, filter, searchOption)).ToArray();
        }

    }
}
