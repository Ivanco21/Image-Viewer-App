
namespace ImageViewerApp
{
    partial class MainViewerFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeGeneral = new System.Windows.Forms.TreeView();
            this.rootDirWatcher = new System.IO.FileSystemWatcher();
            this.pnlFolderSelect = new System.Windows.Forms.Panel();
            this.tbRootPath = new System.Windows.Forms.TextBox();
            this.lblSelectDir = new System.Windows.Forms.Label();
            this.btnRootDirSelect = new System.Windows.Forms.Button();
            this.dlgRootSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.pbViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rootDirWatcher)).BeginInit();
            this.pnlFolderSelect.SuspendLayout();
            this.pnlViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // treeGeneral
            // 
            this.treeGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeGeneral.Location = new System.Drawing.Point(12, 53);
            this.treeGeneral.Name = "treeGeneral";
            this.treeGeneral.Size = new System.Drawing.Size(176, 381);
            this.treeGeneral.TabIndex = 2;
            // 
            // rootDirWatcher
            // 
            this.rootDirWatcher.EnableRaisingEvents = true;
            this.rootDirWatcher.IncludeSubdirectories = true;
            this.rootDirWatcher.SynchronizingObject = this;
            this.rootDirWatcher.Changed += new System.IO.FileSystemEventHandler(this.rootDirWatcher_Changed);
            this.rootDirWatcher.Created += new System.IO.FileSystemEventHandler(this.rootDirWatcher_Changed);
            this.rootDirWatcher.Deleted += new System.IO.FileSystemEventHandler(this.rootDirWatcher_Changed);
            this.rootDirWatcher.Renamed += new System.IO.RenamedEventHandler(this.rootDirWatcher_Renamed);
            // 
            // pnlFolderSelect
            // 
            this.pnlFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFolderSelect.Controls.Add(this.tbRootPath);
            this.pnlFolderSelect.Controls.Add(this.lblSelectDir);
            this.pnlFolderSelect.Controls.Add(this.btnRootDirSelect);
            this.pnlFolderSelect.Location = new System.Drawing.Point(12, 12);
            this.pnlFolderSelect.Name = "pnlFolderSelect";
            this.pnlFolderSelect.Size = new System.Drawing.Size(774, 35);
            this.pnlFolderSelect.TabIndex = 3;
            // 
            // tbRootPath
            // 
            this.tbRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootPath.Location = new System.Drawing.Point(92, 9);
            this.tbRootPath.Name = "tbRootPath";
            this.tbRootPath.ReadOnly = true;
            this.tbRootPath.Size = new System.Drawing.Size(639, 20);
            this.tbRootPath.TabIndex = 2;
            this.tbRootPath.TextChanged += new System.EventHandler(this.tbRootPath_TextChanged);
            // 
            // lblSelectDir
            // 
            this.lblSelectDir.AutoSize = true;
            this.lblSelectDir.Location = new System.Drawing.Point(3, 12);
            this.lblSelectDir.Name = "lblSelectDir";
            this.lblSelectDir.Size = new System.Drawing.Size(83, 13);
            this.lblSelectDir.TabIndex = 1;
            this.lblSelectDir.Text = "Select directory:";
            // 
            // btnRootDirSelect
            // 
            this.btnRootDirSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRootDirSelect.Location = new System.Drawing.Point(737, 9);
            this.btnRootDirSelect.Name = "btnRootDirSelect";
            this.btnRootDirSelect.Size = new System.Drawing.Size(34, 20);
            this.btnRootDirSelect.TabIndex = 0;
            this.btnRootDirSelect.Text = "...";
            this.btnRootDirSelect.UseVisualStyleBackColor = true;
            this.btnRootDirSelect.Click += new System.EventHandler(this.btnRootDirSelect_Click);
            // 
            // pnlViewer
            // 
            this.pnlViewer.Controls.Add(this.pbViewer);
            this.pnlViewer.Location = new System.Drawing.Point(195, 54);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(592, 384);
            this.pnlViewer.TabIndex = 4;
            // 
            // pbViewer
            // 
            this.pbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewer.Location = new System.Drawing.Point(0, 0);
            this.pbViewer.Name = "pbViewer";
            this.pbViewer.Size = new System.Drawing.Size(592, 384);
            this.pbViewer.TabIndex = 0;
            this.pbViewer.TabStop = false;
            // 
            // MainViewerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 446);
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.pnlFolderSelect);
            this.Controls.Add(this.treeGeneral);
            this.MinimumSize = new System.Drawing.Size(815, 485);
            this.Name = "MainViewerFrm";
            this.ShowIcon = false;
            this.Text = "Image viewer ";
            this.Load += new System.EventHandler(this.MainViewerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rootDirWatcher)).EndInit();
            this.pnlFolderSelect.ResumeLayout(false);
            this.pnlFolderSelect.PerformLayout();
            this.pnlViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeGeneral;
        private System.IO.FileSystemWatcher rootDirWatcher;
        private System.Windows.Forms.Panel pnlFolderSelect;
        private System.Windows.Forms.FolderBrowserDialog dlgRootSelect;
        private System.Windows.Forms.TextBox tbRootPath;
        private System.Windows.Forms.Label lblSelectDir;
        private System.Windows.Forms.Button btnRootDirSelect;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.PictureBox pbViewer;
    }
}

