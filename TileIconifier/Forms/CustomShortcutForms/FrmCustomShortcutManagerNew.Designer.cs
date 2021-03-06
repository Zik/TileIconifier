﻿using TileIconifier.Controls;

namespace TileIconifier.Forms.CustomShortcutForms
{
    partial class FrmCustomShortcutManagerNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomShortcutManagerNew));
            this.fldBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.opnSteamExe = new System.Windows.Forms.OpenFileDialog();
            this.opnOtherTarget = new System.Windows.Forms.OpenFileDialog();
            this.opnChromeExe = new System.Windows.Forms.OpenFileDialog();
            this.radShortcutLocation = new TileIconifier.Controls.AllOrCurrentUserRadios();
            this.txtShortcutName = new System.Windows.Forms.TextBox();
            this.lblShortcutName = new System.Windows.Forms.Label();
            this.btnGenerateShortcut = new System.Windows.Forms.Button();
            this.lblCurrentIcon = new System.Windows.Forms.Label();
            this.pctCurrentIcon = new System.Windows.Forms.PictureBox();
            this.tabShortcutType = new System.Windows.Forms.TabControl();
            this.tabExplorer = new System.Windows.Forms.TabPage();
            this.pnlExplorer = new System.Windows.Forms.Panel();
            this.btnExplorerBrowse = new System.Windows.Forms.Button();
            this.txtCustomFolder = new System.Windows.Forms.TextBox();
            this.radCustomFolder = new System.Windows.Forms.RadioButton();
            this.radSpecialFolder = new System.Windows.Forms.RadioButton();
            this.cmbExplorerGuids = new System.Windows.Forms.ComboBox();
            this.tabSteam = new System.Windows.Forms.TabPage();
            this.btnSteamLibrariesPath = new System.Windows.Forms.Button();
            this.btnSteamExeChange = new System.Windows.Forms.Button();
            this.btnSteamInstallationChange = new System.Windows.Forms.Button();
            this.txtSteamInstallationPath = new System.Windows.Forms.TextBox();
            this.txtSteamExecutablePath = new System.Windows.Forms.TextBox();
            this.txtSteamLibraryPaths = new System.Windows.Forms.TextBox();
            this.lstSteamGames = new TileIconifier.Controls.SortableListView();
            this.tabChromeApps = new System.Windows.Forms.TabPage();
            this.lstChromeAppItems = new TileIconifier.Controls.SortableListView();
            this.btnChromeAppPathChange = new System.Windows.Forms.Button();
            this.txtChromeAppPath = new System.Windows.Forms.TextBox();
            this.btnChromeExePathChange = new System.Windows.Forms.Button();
            this.txtChromeExePath = new System.Windows.Forms.TextBox();
            this.tabWindowsStore = new System.Windows.Forms.TabPage();
            this.lstWindowsStoreApps = new TileIconifier.Controls.SortableListView();
            this.tabURI = new System.Windows.Forms.TabPage();
            this.txtUriString = new System.Windows.Forms.TextBox();
            this.lblUriString = new System.Windows.Forms.Label();
            this.lblUriExplain = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.lblOtherShortcutArguments = new System.Windows.Forms.Label();
            this.txtOtherShortcutArguments = new System.Windows.Forms.TextBox();
            this.lblOtherTargetPath = new System.Windows.Forms.Label();
            this.btnOtherTargetBrowse = new System.Windows.Forms.Button();
            this.txtOtherTargetPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctCurrentIcon)).BeginInit();
            this.tabShortcutType.SuspendLayout();
            this.tabExplorer.SuspendLayout();
            this.pnlExplorer.SuspendLayout();
            this.tabSteam.SuspendLayout();
            this.tabChromeApps.SuspendLayout();
            this.tabWindowsStore.SuspendLayout();
            this.tabURI.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fldBrowser
            // 
            resources.ApplyResources(this.fldBrowser, "fldBrowser");
            this.fldBrowser.ShowNewFolderButton = false;
            // 
            // opnSteamExe
            // 
            this.opnSteamExe.FileName = "Steam.exe";
            resources.ApplyResources(this.opnSteamExe, "opnSteamExe");
            // 
            // opnOtherTarget
            // 
            resources.ApplyResources(this.opnOtherTarget, "opnOtherTarget");
            // 
            // opnChromeExe
            // 
            this.opnChromeExe.FileName = "chrome.exe";
            resources.ApplyResources(this.opnChromeExe, "opnChromeExe");
            // 
            // radShortcutLocation
            // 
            resources.ApplyResources(this.radShortcutLocation, "radShortcutLocation");
            this.radShortcutLocation.Name = "radShortcutLocation";
            // 
            // txtShortcutName
            // 
            resources.ApplyResources(this.txtShortcutName, "txtShortcutName");
            this.txtShortcutName.Name = "txtShortcutName";
            // 
            // lblShortcutName
            // 
            resources.ApplyResources(this.lblShortcutName, "lblShortcutName");
            this.lblShortcutName.Name = "lblShortcutName";
            // 
            // btnGenerateShortcut
            // 
            resources.ApplyResources(this.btnGenerateShortcut, "btnGenerateShortcut");
            this.btnGenerateShortcut.Name = "btnGenerateShortcut";
            this.btnGenerateShortcut.UseVisualStyleBackColor = true;
            this.btnGenerateShortcut.Click += new System.EventHandler(this.btnGenerateShortcut_Click);
            // 
            // lblCurrentIcon
            // 
            resources.ApplyResources(this.lblCurrentIcon, "lblCurrentIcon");
            this.lblCurrentIcon.Name = "lblCurrentIcon";
            // 
            // pctCurrentIcon
            // 
            resources.ApplyResources(this.pctCurrentIcon, "pctCurrentIcon");
            this.pctCurrentIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctCurrentIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCurrentIcon.Name = "pctCurrentIcon";
            this.pctCurrentIcon.TabStop = false;
            this.pctCurrentIcon.Click += new System.EventHandler(this.pctCurrentIcon_Click);
            // 
            // tabShortcutType
            // 
            resources.ApplyResources(this.tabShortcutType, "tabShortcutType");
            this.tabShortcutType.Controls.Add(this.tabExplorer);
            this.tabShortcutType.Controls.Add(this.tabSteam);
            this.tabShortcutType.Controls.Add(this.tabChromeApps);
            this.tabShortcutType.Controls.Add(this.tabWindowsStore);
            this.tabShortcutType.Controls.Add(this.tabURI);
            this.tabShortcutType.Controls.Add(this.tabOther);
            this.tabShortcutType.Name = "tabShortcutType";
            this.tabShortcutType.SelectedIndex = 0;
            this.tabShortcutType.SelectedIndexChanged += new System.EventHandler(this.tabShortcutType_SelectedIndexChanged);
            // 
            // tabExplorer
            // 
            resources.ApplyResources(this.tabExplorer, "tabExplorer");
            this.tabExplorer.Controls.Add(this.pnlExplorer);
            this.tabExplorer.Name = "tabExplorer";
            this.tabExplorer.UseVisualStyleBackColor = true;
            // 
            // pnlExplorer
            // 
            resources.ApplyResources(this.pnlExplorer, "pnlExplorer");
            this.pnlExplorer.Controls.Add(this.btnExplorerBrowse);
            this.pnlExplorer.Controls.Add(this.txtCustomFolder);
            this.pnlExplorer.Controls.Add(this.radCustomFolder);
            this.pnlExplorer.Controls.Add(this.radSpecialFolder);
            this.pnlExplorer.Controls.Add(this.cmbExplorerGuids);
            this.pnlExplorer.Name = "pnlExplorer";
            // 
            // btnExplorerBrowse
            // 
            resources.ApplyResources(this.btnExplorerBrowse, "btnExplorerBrowse");
            this.btnExplorerBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExplorerBrowse.FlatAppearance.BorderSize = 0;
            this.btnExplorerBrowse.Name = "btnExplorerBrowse";
            this.btnExplorerBrowse.UseVisualStyleBackColor = true;
            this.btnExplorerBrowse.Click += new System.EventHandler(this.btnExplorerBrowse_Click);
            // 
            // txtCustomFolder
            // 
            resources.ApplyResources(this.txtCustomFolder, "txtCustomFolder");
            this.txtCustomFolder.Name = "txtCustomFolder";
            // 
            // radCustomFolder
            // 
            resources.ApplyResources(this.radCustomFolder, "radCustomFolder");
            this.radCustomFolder.Name = "radCustomFolder";
            this.radCustomFolder.UseVisualStyleBackColor = true;
            // 
            // radSpecialFolder
            // 
            resources.ApplyResources(this.radSpecialFolder, "radSpecialFolder");
            this.radSpecialFolder.Checked = true;
            this.radSpecialFolder.Name = "radSpecialFolder";
            this.radSpecialFolder.TabStop = true;
            this.radSpecialFolder.UseVisualStyleBackColor = true;
            this.radSpecialFolder.CheckedChanged += new System.EventHandler(this.radSpecialFolder_CheckedChanged);
            // 
            // cmbExplorerGuids
            // 
            resources.ApplyResources(this.cmbExplorerGuids, "cmbExplorerGuids");
            this.cmbExplorerGuids.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExplorerGuids.FormattingEnabled = true;
            this.cmbExplorerGuids.Name = "cmbExplorerGuids";
            this.cmbExplorerGuids.SelectedIndexChanged += new System.EventHandler(this.cmbExplorerGuids_SelectedIndexChanged);
            // 
            // tabSteam
            // 
            resources.ApplyResources(this.tabSteam, "tabSteam");
            this.tabSteam.Controls.Add(this.btnSteamLibrariesPath);
            this.tabSteam.Controls.Add(this.btnSteamExeChange);
            this.tabSteam.Controls.Add(this.btnSteamInstallationChange);
            this.tabSteam.Controls.Add(this.txtSteamInstallationPath);
            this.tabSteam.Controls.Add(this.txtSteamExecutablePath);
            this.tabSteam.Controls.Add(this.txtSteamLibraryPaths);
            this.tabSteam.Controls.Add(this.lstSteamGames);
            this.tabSteam.Name = "tabSteam";
            this.tabSteam.UseVisualStyleBackColor = true;
            // 
            // btnSteamLibrariesPath
            // 
            resources.ApplyResources(this.btnSteamLibrariesPath, "btnSteamLibrariesPath");
            this.btnSteamLibrariesPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteamLibrariesPath.FlatAppearance.BorderSize = 0;
            this.btnSteamLibrariesPath.Name = "btnSteamLibrariesPath";
            this.btnSteamLibrariesPath.UseVisualStyleBackColor = true;
            this.btnSteamLibrariesPath.Click += new System.EventHandler(this.btnSteamLibrariesPath_Click);
            // 
            // btnSteamExeChange
            // 
            resources.ApplyResources(this.btnSteamExeChange, "btnSteamExeChange");
            this.btnSteamExeChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteamExeChange.FlatAppearance.BorderSize = 0;
            this.btnSteamExeChange.Name = "btnSteamExeChange";
            this.btnSteamExeChange.UseVisualStyleBackColor = true;
            this.btnSteamExeChange.Click += new System.EventHandler(this.btnSteamExeChange_Click);
            // 
            // btnSteamInstallationChange
            // 
            resources.ApplyResources(this.btnSteamInstallationChange, "btnSteamInstallationChange");
            this.btnSteamInstallationChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteamInstallationChange.FlatAppearance.BorderSize = 0;
            this.btnSteamInstallationChange.Name = "btnSteamInstallationChange";
            this.btnSteamInstallationChange.UseVisualStyleBackColor = true;
            this.btnSteamInstallationChange.Click += new System.EventHandler(this.btnInstallationChange_Click);
            // 
            // txtSteamInstallationPath
            // 
            resources.ApplyResources(this.txtSteamInstallationPath, "txtSteamInstallationPath");
            this.txtSteamInstallationPath.Name = "txtSteamInstallationPath";
            this.txtSteamInstallationPath.ReadOnly = true;
            // 
            // txtSteamExecutablePath
            // 
            resources.ApplyResources(this.txtSteamExecutablePath, "txtSteamExecutablePath");
            this.txtSteamExecutablePath.Name = "txtSteamExecutablePath";
            this.txtSteamExecutablePath.ReadOnly = true;
            // 
            // txtSteamLibraryPaths
            // 
            resources.ApplyResources(this.txtSteamLibraryPaths, "txtSteamLibraryPaths");
            this.txtSteamLibraryPaths.Name = "txtSteamLibraryPaths";
            this.txtSteamLibraryPaths.ReadOnly = true;
            // 
            // lstSteamGames
            // 
            resources.ApplyResources(this.lstSteamGames, "lstSteamGames");
            this.lstSteamGames.FullRowSelect = true;
            this.lstSteamGames.HideSelection = false;
            this.lstSteamGames.MultiSelect = false;
            this.lstSteamGames.Name = "lstSteamGames";
            this.lstSteamGames.UseCompatibleStateImageBehavior = false;
            this.lstSteamGames.View = System.Windows.Forms.View.Details;
            this.lstSteamGames.SelectedIndexChanged += new System.EventHandler(this.lstSteamGames_SelectedIndexChanged);
            // 
            // tabChromeApps
            // 
            resources.ApplyResources(this.tabChromeApps, "tabChromeApps");
            this.tabChromeApps.Controls.Add(this.lstChromeAppItems);
            this.tabChromeApps.Controls.Add(this.btnChromeAppPathChange);
            this.tabChromeApps.Controls.Add(this.txtChromeAppPath);
            this.tabChromeApps.Controls.Add(this.btnChromeExePathChange);
            this.tabChromeApps.Controls.Add(this.txtChromeExePath);
            this.tabChromeApps.Name = "tabChromeApps";
            this.tabChromeApps.UseVisualStyleBackColor = true;
            // 
            // lstChromeAppItems
            // 
            resources.ApplyResources(this.lstChromeAppItems, "lstChromeAppItems");
            this.lstChromeAppItems.FullRowSelect = true;
            this.lstChromeAppItems.HideSelection = false;
            this.lstChromeAppItems.MultiSelect = false;
            this.lstChromeAppItems.Name = "lstChromeAppItems";
            this.lstChromeAppItems.UseCompatibleStateImageBehavior = false;
            this.lstChromeAppItems.View = System.Windows.Forms.View.Details;
            this.lstChromeAppItems.SelectedIndexChanged += new System.EventHandler(this.lstChromeAppItems_SelectedIndexChanged);
            // 
            // btnChromeAppPathChange
            // 
            resources.ApplyResources(this.btnChromeAppPathChange, "btnChromeAppPathChange");
            this.btnChromeAppPathChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChromeAppPathChange.FlatAppearance.BorderSize = 0;
            this.btnChromeAppPathChange.Name = "btnChromeAppPathChange";
            this.btnChromeAppPathChange.UseVisualStyleBackColor = true;
            this.btnChromeAppPathChange.Click += new System.EventHandler(this.btnChromeAppPathChange_Click);
            // 
            // txtChromeAppPath
            // 
            resources.ApplyResources(this.txtChromeAppPath, "txtChromeAppPath");
            this.txtChromeAppPath.Name = "txtChromeAppPath";
            this.txtChromeAppPath.ReadOnly = true;
            // 
            // btnChromeExePathChange
            // 
            resources.ApplyResources(this.btnChromeExePathChange, "btnChromeExePathChange");
            this.btnChromeExePathChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChromeExePathChange.FlatAppearance.BorderSize = 0;
            this.btnChromeExePathChange.Name = "btnChromeExePathChange";
            this.btnChromeExePathChange.UseVisualStyleBackColor = true;
            this.btnChromeExePathChange.Click += new System.EventHandler(this.btnChromeExePathChange_Click);
            // 
            // txtChromeExePath
            // 
            resources.ApplyResources(this.txtChromeExePath, "txtChromeExePath");
            this.txtChromeExePath.Name = "txtChromeExePath";
            this.txtChromeExePath.ReadOnly = true;
            // 
            // tabWindowsStore
            // 
            resources.ApplyResources(this.tabWindowsStore, "tabWindowsStore");
            this.tabWindowsStore.Controls.Add(this.lstWindowsStoreApps);
            this.tabWindowsStore.Name = "tabWindowsStore";
            this.tabWindowsStore.UseVisualStyleBackColor = true;
            // 
            // lstWindowsStoreApps
            // 
            resources.ApplyResources(this.lstWindowsStoreApps, "lstWindowsStoreApps");
            this.lstWindowsStoreApps.FullRowSelect = true;
            this.lstWindowsStoreApps.HideSelection = false;
            this.lstWindowsStoreApps.MultiSelect = false;
            this.lstWindowsStoreApps.Name = "lstWindowsStoreApps";
            this.lstWindowsStoreApps.UseCompatibleStateImageBehavior = false;
            this.lstWindowsStoreApps.View = System.Windows.Forms.View.Details;
            this.lstWindowsStoreApps.SelectedIndexChanged += new System.EventHandler(this.lstWindowsStoreApps_SelectedIndexChanged);
            // 
            // tabURI
            // 
            resources.ApplyResources(this.tabURI, "tabURI");
            this.tabURI.Controls.Add(this.txtUriString);
            this.tabURI.Controls.Add(this.lblUriString);
            this.tabURI.Controls.Add(this.lblUriExplain);
            this.tabURI.Name = "tabURI";
            this.tabURI.UseVisualStyleBackColor = true;
            // 
            // txtUriString
            // 
            resources.ApplyResources(this.txtUriString, "txtUriString");
            this.txtUriString.Name = "txtUriString";
            // 
            // lblUriString
            // 
            resources.ApplyResources(this.lblUriString, "lblUriString");
            this.lblUriString.Name = "lblUriString";
            // 
            // lblUriExplain
            // 
            resources.ApplyResources(this.lblUriExplain, "lblUriExplain");
            this.lblUriExplain.Name = "lblUriExplain";
            // 
            // tabOther
            // 
            resources.ApplyResources(this.tabOther, "tabOther");
            this.tabOther.Controls.Add(this.lblOtherShortcutArguments);
            this.tabOther.Controls.Add(this.txtOtherShortcutArguments);
            this.tabOther.Controls.Add(this.lblOtherTargetPath);
            this.tabOther.Controls.Add(this.btnOtherTargetBrowse);
            this.tabOther.Controls.Add(this.txtOtherTargetPath);
            this.tabOther.Name = "tabOther";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // lblOtherShortcutArguments
            // 
            resources.ApplyResources(this.lblOtherShortcutArguments, "lblOtherShortcutArguments");
            this.lblOtherShortcutArguments.Name = "lblOtherShortcutArguments";
            // 
            // txtOtherShortcutArguments
            // 
            resources.ApplyResources(this.txtOtherShortcutArguments, "txtOtherShortcutArguments");
            this.txtOtherShortcutArguments.Name = "txtOtherShortcutArguments";
            // 
            // lblOtherTargetPath
            // 
            resources.ApplyResources(this.lblOtherTargetPath, "lblOtherTargetPath");
            this.lblOtherTargetPath.Name = "lblOtherTargetPath";
            // 
            // btnOtherTargetBrowse
            // 
            resources.ApplyResources(this.btnOtherTargetBrowse, "btnOtherTargetBrowse");
            this.btnOtherTargetBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherTargetBrowse.FlatAppearance.BorderSize = 0;
            this.btnOtherTargetBrowse.Name = "btnOtherTargetBrowse";
            this.btnOtherTargetBrowse.UseVisualStyleBackColor = true;
            this.btnOtherTargetBrowse.Click += new System.EventHandler(this.btnOtherTargetBrowse_Click);
            // 
            // txtOtherTargetPath
            // 
            resources.ApplyResources(this.txtOtherTargetPath, "txtOtherTargetPath");
            this.txtOtherTargetPath.Name = "txtOtherTargetPath";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // FrmCustomShortcutManagerNew
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.radShortcutLocation);
            this.Controls.Add(this.txtShortcutName);
            this.Controls.Add(this.lblShortcutName);
            this.Controls.Add(this.btnGenerateShortcut);
            this.Controls.Add(this.lblCurrentIcon);
            this.Controls.Add(this.pctCurrentIcon);
            this.Controls.Add(this.tabShortcutType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCustomShortcutManagerNew";
            this.Load += new System.EventHandler(this.FrmCustomShortcutManagerNew_Load);
            this.Resize += new System.EventHandler(this.FrmCustomShortcutManagerNew_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pctCurrentIcon)).EndInit();
            this.tabShortcutType.ResumeLayout(false);
            this.tabExplorer.ResumeLayout(false);
            this.pnlExplorer.ResumeLayout(false);
            this.pnlExplorer.PerformLayout();
            this.tabSteam.ResumeLayout(false);
            this.tabSteam.PerformLayout();
            this.tabChromeApps.ResumeLayout(false);
            this.tabChromeApps.PerformLayout();
            this.tabWindowsStore.ResumeLayout(false);
            this.tabURI.ResumeLayout(false);
            this.tabURI.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabShortcutType;
        private System.Windows.Forms.TabPage tabExplorer;
        private System.Windows.Forms.TabPage tabSteam;
        private SortableListView lstSteamGames;
        private System.Windows.Forms.TextBox txtSteamLibraryPaths;
        private System.Windows.Forms.TextBox txtSteamInstallationPath;
        private System.Windows.Forms.TextBox txtSteamExecutablePath;
        private System.Windows.Forms.Button btnSteamInstallationChange;
        private System.Windows.Forms.Button btnSteamExeChange;
        private System.Windows.Forms.OpenFileDialog opnSteamExe;
        private System.Windows.Forms.Button btnSteamLibrariesPath;
        private System.Windows.Forms.FolderBrowserDialog fldBrowser;
        private AllOrCurrentUserRadios radShortcutLocation;
        private System.Windows.Forms.TextBox txtShortcutName;
        private System.Windows.Forms.Label lblShortcutName;
        private System.Windows.Forms.Button btnGenerateShortcut;
        private System.Windows.Forms.Label lblCurrentIcon;
        private System.Windows.Forms.PictureBox pctCurrentIcon;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Label lblOtherShortcutArguments;
        private System.Windows.Forms.TextBox txtOtherShortcutArguments;
        private System.Windows.Forms.Label lblOtherTargetPath;
        private System.Windows.Forms.Button btnOtherTargetBrowse;
        private System.Windows.Forms.TextBox txtOtherTargetPath;
        private System.Windows.Forms.OpenFileDialog opnOtherTarget;
        private System.Windows.Forms.Panel pnlExplorer;
        private System.Windows.Forms.TextBox txtCustomFolder;
        private System.Windows.Forms.RadioButton radCustomFolder;
        private System.Windows.Forms.RadioButton radSpecialFolder;
        private System.Windows.Forms.ComboBox cmbExplorerGuids;
        private System.Windows.Forms.Button btnExplorerBrowse;
        private System.Windows.Forms.TabPage tabChromeApps;
        private System.Windows.Forms.Button btnChromeExePathChange;
        private System.Windows.Forms.TextBox txtChromeExePath;
        private System.Windows.Forms.Button btnChromeAppPathChange;
        private System.Windows.Forms.TextBox txtChromeAppPath;
        private SortableListView lstChromeAppItems;
        private System.Windows.Forms.TabPage tabWindowsStore;
        private SortableListView lstWindowsStoreApps;
        private System.Windows.Forms.OpenFileDialog opnChromeExe;
        private System.Windows.Forms.TabPage tabURI;
        private System.Windows.Forms.TextBox txtUriString;
        private System.Windows.Forms.Label lblUriString;
        private System.Windows.Forms.Label lblUriExplain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}