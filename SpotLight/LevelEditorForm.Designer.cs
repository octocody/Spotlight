﻿namespace SpotLight
{
    partial class LevelEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelEditorForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ZonesTabPage = new System.Windows.Forms.TabPage();
            this.ZoneListBox = new System.Windows.Forms.ListBox();
            this.EditIndividualButton = new System.Windows.Forms.Button();
            this.ObjectsTabPage = new System.Windows.Forms.TabPage();
            this.MainSceneListView = new GL_EditorFramework.SceneListView();
            this.CurrentObjectLabel = new System.Windows.Forms.Label();
            this.ObjectUIControl = new GL_EditorFramework.ObjectUIControl();
            this.ZoneDocumentTabControl = new SpotLight.DocumentTabControl();
            this.LevelGLControlModern = new GL_EditorFramework.GL_Core.GL_ControlModern();
            this.SpotlightMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveSelectionToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToLinkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToAppropriateListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpotlightWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpotlightStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SpotlightToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.AddObjectTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ZonesTabPage.SuspendLayout();
            this.ObjectsTabPage.SuspendLayout();
            this.ZoneDocumentTabControl.SuspendLayout();
            this.SpotlightMenuStrip.SuspendLayout();
            this.SpotlightStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ZoneDocumentTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(784, 515);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MainTabControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.CurrentObjectLabel);
            this.splitContainer2.Panel2.Controls.Add(this.ObjectUIControl);
            this.splitContainer2.Panel2.Click += new System.EventHandler(this.SplitContainer2_Panel2_Click);
            this.splitContainer2.Size = new System.Drawing.Size(260, 515);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 1;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ZonesTabPage);
            this.MainTabControl.Controls.Add(this.ObjectsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(260, 245);
            this.MainTabControl.TabIndex = 1;
            // 
            // ZonesTabPage
            // 
            this.ZonesTabPage.Controls.Add(this.ZoneListBox);
            this.ZonesTabPage.Controls.Add(this.EditIndividualButton);
            this.ZonesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ZonesTabPage.Name = "ZonesTabPage";
            this.ZonesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ZonesTabPage.Size = new System.Drawing.Size(252, 219);
            this.ZonesTabPage.TabIndex = 0;
            this.ZonesTabPage.Text = "Zones";
            this.ZonesTabPage.UseVisualStyleBackColor = true;
            // 
            // ZoneListBox
            // 
            this.ZoneListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoneListBox.FormattingEnabled = true;
            this.ZoneListBox.Location = new System.Drawing.Point(3, 3);
            this.ZoneListBox.Name = "ZoneListBox";
            this.ZoneListBox.Size = new System.Drawing.Size(246, 190);
            this.ZoneListBox.TabIndex = 3;
            this.ZoneListBox.SelectedIndexChanged += new System.EventHandler(this.ZoneListBox_SelectedIndexChanged);
            // 
            // EditIndividualButton
            // 
            this.EditIndividualButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditIndividualButton.Enabled = false;
            this.EditIndividualButton.Location = new System.Drawing.Point(3, 193);
            this.EditIndividualButton.Name = "EditIndividualButton";
            this.EditIndividualButton.Size = new System.Drawing.Size(246, 23);
            this.EditIndividualButton.TabIndex = 1;
            this.EditIndividualButton.Text = "Edit Individual";
            this.EditIndividualButton.UseVisualStyleBackColor = true;
            this.EditIndividualButton.Click += new System.EventHandler(this.EditIndividualButton_Click);
            // 
            // ObjectsTabPage
            // 
            this.ObjectsTabPage.Controls.Add(this.MainSceneListView);
            this.ObjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ObjectsTabPage.Name = "ObjectsTabPage";
            this.ObjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ObjectsTabPage.Size = new System.Drawing.Size(252, 219);
            this.ObjectsTabPage.TabIndex = 1;
            this.ObjectsTabPage.Text = "Objects";
            this.ObjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainSceneListView
            // 
            this.MainSceneListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSceneListView.Enabled = false;
            this.MainSceneListView.Location = new System.Drawing.Point(3, 3);
            this.MainSceneListView.Name = "MainSceneListView";
            this.MainSceneListView.RootLists = ((System.Collections.Generic.Dictionary<string, System.Collections.IList>)(resources.GetObject("MainSceneListView.RootLists")));
            this.MainSceneListView.Size = new System.Drawing.Size(246, 213);
            this.MainSceneListView.TabIndex = 1;
            this.MainSceneListView.ItemDoubleClicked += new GL_EditorFramework.ItemDoubleClickedEventHandler(this.MainSceneListView_ItemDoubleClicked);
            // 
            // CurrentObjectLabel
            // 
            this.CurrentObjectLabel.AutoSize = true;
            this.CurrentObjectLabel.Location = new System.Drawing.Point(12, 0);
            this.CurrentObjectLabel.Name = "CurrentObjectLabel";
            this.CurrentObjectLabel.Size = new System.Drawing.Size(87, 13);
            this.CurrentObjectLabel.TabIndex = 0;
            this.CurrentObjectLabel.Text = "Nothing selected";
            // 
            // ObjectUIControl
            // 
            this.ObjectUIControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectUIControl.BackColor = System.Drawing.SystemColors.Control;
            this.ObjectUIControl.Location = new System.Drawing.Point(3, 16);
            this.ObjectUIControl.MinimumSize = new System.Drawing.Size(200, 200);
            this.ObjectUIControl.Name = "ObjectUIControl";
            this.ObjectUIControl.Size = new System.Drawing.Size(254, 245);
            this.ObjectUIControl.TabIndex = 1;
            // 
            // ZoneDocumentTabControl
            // 
            this.ZoneDocumentTabControl.Controls.Add(this.LevelGLControlModern);
            this.ZoneDocumentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoneDocumentTabControl.Location = new System.Drawing.Point(0, 0);
            this.ZoneDocumentTabControl.Name = "ZoneDocumentTabControl";
            this.ZoneDocumentTabControl.Size = new System.Drawing.Size(520, 515);
            this.ZoneDocumentTabControl.TabIndex = 1;
            this.ZoneDocumentTabControl.SelectedTabChanged += new System.EventHandler(this.ZoneDocumentTabControl_SelectedTabChanged);
            this.ZoneDocumentTabControl.TabClosing += new SpotLight.DocumentTabClosingEventHandler(this.ZoneDocumentTabControl_TabClosing);
            // 
            // LevelGLControlModern
            // 
            this.LevelGLControlModern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelGLControlModern.BackColor = System.Drawing.Color.Black;
            this.LevelGLControlModern.CameraDistance = 10F;
            this.LevelGLControlModern.CameraTarget = ((OpenTK.Vector3)(resources.GetObject("LevelGLControlModern.CameraTarget")));
            this.LevelGLControlModern.CamRotX = 0F;
            this.LevelGLControlModern.CamRotY = 0F;
            this.LevelGLControlModern.CurrentShader = null;
            this.LevelGLControlModern.Fov = 0.7853982F;
            this.LevelGLControlModern.Location = new System.Drawing.Point(3, 32);
            this.LevelGLControlModern.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.LevelGLControlModern.Name = "LevelGLControlModern";
            this.LevelGLControlModern.NormPickingDepth = 0F;
            this.LevelGLControlModern.ShowOrientationCube = true;
            this.LevelGLControlModern.Size = new System.Drawing.Size(515, 481);
            this.LevelGLControlModern.Stereoscopy = false;
            this.LevelGLControlModern.TabIndex = 0;
            this.LevelGLControlModern.VSync = false;
            this.LevelGLControlModern.ZFar = 32000F;
            this.LevelGLControlModern.ZNear = 1.5F;
            // 
            // SpotlightMenuStrip
            // 
            this.SpotlightMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ModeToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.SpotlightMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SpotlightMenuStrip.Name = "SpotlightMenuStrip";
            this.SpotlightMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.SpotlightMenuStrip.TabIndex = 3;
            this.SpotlightMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.OpenExToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.OptionsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.ToolTipText = "Open a Level file";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OpenExToolStripMenuItem
            // 
            this.OpenExToolStripMenuItem.Name = "OpenExToolStripMenuItem";
            this.OpenExToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenExToolStripMenuItem.Text = "Open With Selector";
            this.OpenExToolStripMenuItem.Click += new System.EventHandler(this.OpenExToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OptionsToolStripMenuItem.Text = "Options";
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.AddObjectToolStripMenuItem,
            this.AddZoneToolStripMenuItem,
            this.DuplicateToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.SelectAllToolStripMenuItem,
            this.DeselectAllToolStripMenuItem,
            this.LevelParametersToolStripMenuItem,
            this.MoveSelectionToToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.UndoToolStripMenuItem.Text = "Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Enabled = false;
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.RedoToolStripMenuItem.Text = "Redo";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // AddObjectToolStripMenuItem
            // 
            this.AddObjectToolStripMenuItem.Enabled = false;
            this.AddObjectToolStripMenuItem.Name = "AddObjectToolStripMenuItem";
            this.AddObjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.AddObjectToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.AddObjectToolStripMenuItem.Text = "Add Object";
            this.AddObjectToolStripMenuItem.Click += new System.EventHandler(this.AddObjectToolStripMenuItem_Click);
            // 
            // AddZoneToolStripMenuItem
            // 
            this.AddZoneToolStripMenuItem.Enabled = false;
            this.AddZoneToolStripMenuItem.Name = "AddZoneToolStripMenuItem";
            this.AddZoneToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.AddZoneToolStripMenuItem.Text = "Add Zone";
            this.AddZoneToolStripMenuItem.Click += new System.EventHandler(this.AddZoneToolStripMenuItem_Click);
            // 
            // DuplicateToolStripMenuItem
            // 
            this.DuplicateToolStripMenuItem.Enabled = false;
            this.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem";
            this.DuplicateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DuplicateToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.DuplicateToolStripMenuItem.Text = "Duplicate";
            this.DuplicateToolStripMenuItem.Click += new System.EventHandler(this.DuplicateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Enabled = false;
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.SelectAllToolStripMenuItem.Text = "Select All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // DeselectAllToolStripMenuItem
            // 
            this.DeselectAllToolStripMenuItem.Enabled = false;
            this.DeselectAllToolStripMenuItem.Name = "DeselectAllToolStripMenuItem";
            this.DeselectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.DeselectAllToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.DeselectAllToolStripMenuItem.Text = "Deselect All";
            this.DeselectAllToolStripMenuItem.Click += new System.EventHandler(this.DeselectAllToolStripMenuItem_Click);
            // 
            // LevelParametersToolStripMenuItem
            // 
            this.LevelParametersToolStripMenuItem.Name = "LevelParametersToolStripMenuItem";
            this.LevelParametersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.LevelParametersToolStripMenuItem.Text = "Level Parameters";
            this.LevelParametersToolStripMenuItem.Click += new System.EventHandler(this.LevelParametersToolStripMenuItem_Click);
            // 
            // MoveSelectionToToolStripMenuItem
            // 
            this.MoveSelectionToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveToLinkedToolStripMenuItem,
            this.MoveToAppropriateListsToolStripMenuItem});
            this.MoveSelectionToToolStripMenuItem.Name = "MoveSelectionToToolStripMenuItem";
            this.MoveSelectionToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MoveSelectionToToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.MoveSelectionToToolStripMenuItem.Text = "Move Selection To";
            // 
            // MoveToLinkedToolStripMenuItem
            // 
            this.MoveToLinkedToolStripMenuItem.Name = "MoveToLinkedToolStripMenuItem";
            this.MoveToLinkedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.MoveToLinkedToolStripMenuItem.Text = "Linked Objects";
            this.MoveToLinkedToolStripMenuItem.Click += new System.EventHandler(this.MoveToLinkedToolStripMenuItem_Click);
            // 
            // MoveToAppropriateListsToolStripMenuItem
            // 
            this.MoveToAppropriateListsToolStripMenuItem.Name = "MoveToAppropriateListsToolStripMenuItem";
            this.MoveToAppropriateListsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.MoveToAppropriateListsToolStripMenuItem.Text = "Appropriate Lists";
            this.MoveToAppropriateListsToolStripMenuItem.Click += new System.EventHandler(this.MoveToAppropriateListsToolStripMenuItem_Click);
            // 
            // ModeToolStripMenuItem
            // 
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditObjectsToolStripMenuItem,
            this.EditLinksToolStripMenuItem});
            this.ModeToolStripMenuItem.Enabled = false;
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ModeToolStripMenuItem.Text = "Mode";
            // 
            // EditObjectsToolStripMenuItem
            // 
            this.EditObjectsToolStripMenuItem.Enabled = false;
            this.EditObjectsToolStripMenuItem.Name = "EditObjectsToolStripMenuItem";
            this.EditObjectsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.EditObjectsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EditObjectsToolStripMenuItem.Text = "Edit Objects";
            this.EditObjectsToolStripMenuItem.Click += new System.EventHandler(this.EditObjectsToolStripMenuItem_Click);
            // 
            // EditLinksToolStripMenuItem
            // 
            this.EditLinksToolStripMenuItem.Enabled = false;
            this.EditLinksToolStripMenuItem.Name = "EditLinksToolStripMenuItem";
            this.EditLinksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.EditLinksToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EditLinksToolStripMenuItem.Text = "Edit Links";
            this.EditLinksToolStripMenuItem.Click += new System.EventHandler(this.EditLinksToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpotlightWikiToolStripMenuItem,
            this.CheckForUpdatesToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // SpotlightWikiToolStripMenuItem
            // 
            this.SpotlightWikiToolStripMenuItem.Name = "SpotlightWikiToolStripMenuItem";
            this.SpotlightWikiToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.SpotlightWikiToolStripMenuItem.Text = "Spotlight Wiki";
            this.SpotlightWikiToolStripMenuItem.Click += new System.EventHandler(this.SpotlightWikiToolStripMenuItem_Click);
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // SpotlightStatusStrip
            // 
            this.SpotlightStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpotlightToolStripStatusLabel});
            this.SpotlightStatusStrip.Location = new System.Drawing.Point(0, 539);
            this.SpotlightStatusStrip.Name = "SpotlightStatusStrip";
            this.SpotlightStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.SpotlightStatusStrip.TabIndex = 4;
            // 
            // SpotlightToolStripStatusLabel
            // 
            this.SpotlightToolStripStatusLabel.Name = "SpotlightToolStripStatusLabel";
            this.SpotlightToolStripStatusLabel.Size = new System.Drawing.Size(91, 17);
            this.SpotlightToolStripStatusLabel.Text = "Spotlight 0.7.0.0";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // AddObjectTimer
            // 
            this.AddObjectTimer.Tick += new System.EventHandler(this.AddObjectTimer_Tick);
            // 
            // LevelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.SpotlightMenuStrip);
            this.Controls.Add(this.SpotlightStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SpotlightMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LevelEditorForm";
            this.Text = "SpotLight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelEditorForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ZonesTabPage.ResumeLayout(false);
            this.ObjectsTabPage.ResumeLayout(false);
            this.ZoneDocumentTabControl.ResumeLayout(false);
            this.SpotlightMenuStrip.ResumeLayout(false);
            this.SpotlightMenuStrip.PerformLayout();
            this.SpotlightStatusStrip.ResumeLayout(false);
            this.SpotlightStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label CurrentObjectLabel;
        private System.Windows.Forms.MenuStrip SpotlightMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.StatusStrip SpotlightStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SpotlightToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LevelParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DuplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenExToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddObjectToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ZonesTabPage;
        private System.Windows.Forms.TabPage ObjectsTabPage;
        private System.Windows.Forms.Button EditIndividualButton;
        public GL_EditorFramework.GL_Core.GL_ControlModern LevelGLControlModern;
        public GL_EditorFramework.ObjectUIControl ObjectUIControl;
        public GL_EditorFramework.SceneListView MainSceneListView;
        private DocumentTabControl ZoneDocumentTabControl;
        private System.Windows.Forms.ListBox ZoneListBox;
        private System.Windows.Forms.ToolStripMenuItem AddZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveSelectionToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveToLinkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveToAppropriateListsToolStripMenuItem;
        private System.Windows.Forms.Timer AddObjectTimer;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpotlightWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
    }
}

