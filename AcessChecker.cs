using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace ImageViewerApp
{
    static class AcessChecker
    {
        //check access for all folders
        static public bool CheckAccessToFolders(string rootFolderPath)
        {
            try
            {
                List<string> allFldrs = new List<string>();
                allFldrs = Directory.GetDirectories(rootFolderPath, "*", SearchOption.AllDirectories).ToList();
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
    }
}

