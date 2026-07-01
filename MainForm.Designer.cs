namespace CP_Ideas_Tracker
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dgvProblems = new DataGridView();
            cmsProblems = new ContextMenuStrip(components);
            exportIdeaToolStripMenuItem = new ToolStripMenuItem();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProblems).BeginInit();
            cmsProblems.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProblems
            // 
            dgvProblems.AllowUserToAddRows = false;
            dgvProblems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProblems.ContextMenuStrip = cmsProblems;
            dgvProblems.Location = new Point(0, 46);
            dgvProblems.Name = "dgvProblems";
            dgvProblems.ReadOnly = true;
            dgvProblems.Size = new Size(1158, 581);
            dgvProblems.TabIndex = 0;
            dgvProblems.MouseDown += dgvProblems_MouseDown;
            // 
            // cmsProblems
            // 
            cmsProblems.Items.AddRange(new ToolStripItem[] { exportIdeaToolStripMenuItem, modifyToolStripMenuItem });
            cmsProblems.Name = "exportIdeaToolStripMenuItem";
            cmsProblems.Size = new Size(166, 48);
            // 
            // exportIdeaToolStripMenuItem
            // 
            exportIdeaToolStripMenuItem.Name = "exportIdeaToolStripMenuItem";
            exportIdeaToolStripMenuItem.Size = new Size(165, 22);
            exportIdeaToolStripMenuItem.Text = "Export Idea as .txt";
            exportIdeaToolStripMenuItem.Click += exportIdeaToolStripMenuItem_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(138, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 39);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 39);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(165, 22);
            modifyToolStripMenuItem.Text = "Modify";


            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 629);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(dgvProblems);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvProblems).EndInit();
            cmsProblems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProblems;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private ContextMenuStrip cmsProblems;
        private ToolStripMenuItem exportIdeaToolStripMenuItem;
        private ToolStripMenuItem modifyToolStripMenuItem;
    }
}