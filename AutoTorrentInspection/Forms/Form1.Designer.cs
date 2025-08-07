namespace AutoTorrentInspection.Forms
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLoadFile = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            cbCategory = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            btnAnnounceList = new System.Windows.Forms.Button();
            cbShowAll = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            contextMenuOpenFolder = new System.Windows.Forms.ContextMenuStrip(components);
            OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DeleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cbFixCue = new System.Windows.Forms.CheckBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel_Encode = new System.Windows.Forms.ToolStripStatusLabel();
            btnWebP = new System.Windows.Forms.Button();
            btnCompare = new System.Windows.Forms.Button();
            btnTreeView = new System.Windows.Forms.Button();
            ColPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuOpenFolder.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new System.Drawing.Point(12, 12);
            btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new System.Drawing.Size(87, 33);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "载入";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.MouseUp += btnLoadFile_MouseUp;
            // 
            // btnRefresh
            // 
            btnRefresh.AllowDrop = true;
            btnRefresh.Enabled = false;
            btnRefresh.Location = new System.Drawing.Point(12, 53);
            btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(87, 33);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnTest_Click;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCategory.Enabled = false;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(13, 135);
            cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(85, 32);
            cbCategory.TabIndex = 3;
            cbCategory.MouseEnter += cbCategory_MouseEnter;
            cbCategory.MouseLeave += cbCategory_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColPath, ColFileName, ColSize, 状态 });
            dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            dataGridView1.Location = new System.Drawing.Point(105, 13);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.Size = new System.Drawing.Size(467, 415);
            dataGridView1.TabIndex = 9;
            dataGridView1.TabStop = false;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.KeyUp += dataGridView1_KeyUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "torrent File|*.torrent";
            // 
            // btnAnnounceList
            // 
            btnAnnounceList.Enabled = false;
            btnAnnounceList.Location = new System.Drawing.Point(12, 94);
            btnAnnounceList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAnnounceList.Name = "btnAnnounceList";
            btnAnnounceList.Size = new System.Drawing.Size(87, 33);
            btnAnnounceList.TabIndex = 2;
            btnAnnounceList.Text = "Tracker";
            btnAnnounceList.UseVisualStyleBackColor = true;
            btnAnnounceList.Click += btnAnnounceList_Click;
            // 
            // cbShowAll
            // 
            cbShowAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cbShowAll.AutoSize = true;
            cbShowAll.Location = new System.Drawing.Point(13, 379);
            cbShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbShowAll.Name = "cbShowAll";
            cbShowAll.Size = new System.Drawing.Size(108, 28);
            cbShowAll.TabIndex = 4;
            cbShowAll.Text = "显示全部";
            cbShowAll.UseVisualStyleBackColor = true;
            // 
            // contextMenuOpenFolder
            // 
            contextMenuOpenFolder.ImageScalingSize = new System.Drawing.Size(24, 24);
            contextMenuOpenFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenFolderToolStripMenuItem, toolStripSeparator1, OpenFileToolStripMenuItem, DeleteFileToolStripMenuItem });
            contextMenuOpenFolder.Name = "contextMenuOpenFolder";
            contextMenuOpenFolder.Size = new System.Drawing.Size(207, 100);
            // 
            // OpenFolderToolStripMenuItem
            // 
            OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
            OpenFolderToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            OpenFolderToolStripMenuItem.Text = "打开所在文件夹";
            OpenFolderToolStripMenuItem.Click += OpenFolderToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // OpenFileToolStripMenuItem
            // 
            OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            OpenFileToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            OpenFileToolStripMenuItem.Text = "打开选中文件";
            OpenFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            // 
            // DeleteFileToolStripMenuItem
            // 
            DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem";
            DeleteFileToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            DeleteFileToolStripMenuItem.Text = "删除选中文件";
            DeleteFileToolStripMenuItem.Click += DeleteFileToolStripMenuItem_Click;
            // 
            // cbFixCue
            // 
            cbFixCue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cbFixCue.AutoSize = true;
            cbFixCue.Enabled = false;
            cbFixCue.Location = new System.Drawing.Point(13, 405);
            cbFixCue.Name = "cbFixCue";
            cbFixCue.Size = new System.Drawing.Size(107, 28);
            cbFixCue.TabIndex = 10;
            cbFixCue.Text = "cue 修复";
            cbFixCue.UseVisualStyleBackColor = true;
            cbFixCue.MouseEnter += cbFixCue_MouseEnter;
            cbFixCue.MouseLeave += cbFixCue_MouseLeave;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel_Status, toolStripStatusLabel_Encode });
            statusStrip1.Location = new System.Drawing.Point(0, 430);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(584, 31);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Status
            // 
            toolStripStatusLabel_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
            toolStripStatusLabel_Status.Size = new System.Drawing.Size(284, 24);
            toolStripStatusLabel_Status.Spring = true;
            toolStripStatusLabel_Status.Text = "请载入文件或文件夹";
            toolStripStatusLabel_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_Encode
            // 
            toolStripStatusLabel_Encode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel_Encode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripStatusLabel_Encode.Name = "toolStripStatusLabel_Encode";
            toolStripStatusLabel_Encode.Size = new System.Drawing.Size(284, 24);
            toolStripStatusLabel_Encode.Spring = true;
            toolStripStatusLabel_Encode.Text = " (0.00)";
            toolStripStatusLabel_Encode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnWebP
            // 
            btnWebP.Enabled = false;
            btnWebP.Location = new System.Drawing.Point(12, 344);
            btnWebP.Name = "btnWebP";
            btnWebP.Size = new System.Drawing.Size(87, 33);
            btnWebP.TabIndex = 12;
            btnWebP.Text = "WebP";
            btnWebP.UseVisualStyleBackColor = true;
            btnWebP.Visible = false;
            btnWebP.Click += btnWebP_Click;
            // 
            // btnCompare
            // 
            btnCompare.Enabled = false;
            btnCompare.Location = new System.Drawing.Point(12, 177);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new System.Drawing.Size(87, 33);
            btnCompare.TabIndex = 13;
            btnCompare.Text = "对比";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Visible = false;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnTreeView
            // 
            btnTreeView.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnTreeView.Enabled = false;
            btnTreeView.Location = new System.Drawing.Point(13, 343);
            btnTreeView.Name = "btnTreeView";
            btnTreeView.Size = new System.Drawing.Size(87, 33);
            btnTreeView.TabIndex = 14;
            btnTreeView.Text = "查看结构";
            btnTreeView.UseVisualStyleBackColor = true;
            btnTreeView.Visible = false;
            btnTreeView.Click += btnTreeView_Click;
            // 
            // ColPath
            // 
            ColPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ColPath.HeaderText = "路径";
            ColPath.MinimumWidth = 8;
            ColPath.Name = "ColPath";
            ColPath.ReadOnly = true;
            ColPath.Width = 82;
            // 
            // ColFileName
            // 
            ColFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ColFileName.HeaderText = "文件名";
            ColFileName.MinimumWidth = 8;
            ColFileName.Name = "ColFileName";
            ColFileName.ReadOnly = true;
            ColFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColFileName.Width = 70;
            // 
            // ColSize
            // 
            ColSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ColSize.HeaderText = "大小";
            ColSize.MinimumWidth = 8;
            ColSize.Name = "ColSize";
            ColSize.ReadOnly = true;
            ColSize.Width = 82;
            // 
            // 状态
            // 
            状态.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            状态.HeaderText = "状态";
            状态.MinimumWidth = 8;
            状态.Name = "状态";
            状态.ReadOnly = true;
            状态.Width = 82;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(584, 461);
            Controls.Add(btnTreeView);
            Controls.Add(btnCompare);
            Controls.Add(btnWebP);
            Controls.Add(statusStrip1);
            Controls.Add(cbFixCue);
            Controls.Add(cbShowAll);
            Controls.Add(btnAnnounceList);
            Controls.Add(dataGridView1);
            Controls.Add(cbCategory);
            Controls.Add(btnRefresh);
            Controls.Add(btnLoadFile);
            Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(380, 300);
            Name = "Form1";
            Text = "Auto Torrent Inspection";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuOpenFolder.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAnnounceList;
        private System.Windows.Forms.CheckBox cbShowAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbFixCue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Encode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.Button btnWebP;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnTreeView;
        private System.Windows.Forms.ToolStripMenuItem DeleteFileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
    }
}

