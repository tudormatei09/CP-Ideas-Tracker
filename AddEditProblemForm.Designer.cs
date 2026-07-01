namespace CP_Ideas_Tracker
{
    partial class AddEditProblemForm
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
            lblLink = new Label();
            txtProblemLink = new TextBox();
            lblName = new Label();
            txtProblemName = new TextBox();
            lblPlatform = new Label();
            txtPlatform = new TextBox();
            lblIdea = new Label();
            lblIdeaStatus = new Label();
            btnImportIdea = new Button();
            btnExportIdea = new Button();
            lblTags = new Label();
            txtTags = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            progressSave = new ProgressBar();
            lblSaveStatus = new Label();
            SuspendLayout();
            // 
            // lblLink
            // 
            lblLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLink.Location = new Point(12, 33);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(81, 22);
            lblLink.TabIndex = 0;
            lblLink.Text = "Problem Link:";
            // 
            // txtProblemLink
            // 
            txtProblemLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProblemLink.Location = new Point(118, 30);
            txtProblemLink.Name = "txtProblemLink";
            txtProblemLink.Size = new Size(847, 23);
            txtProblemLink.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.Location = new Point(12, 78);
            lblName.Name = "lblName";
            lblName.Size = new Size(93, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Problem Name: ";
            // 
            // txtProblemName
            // 
            txtProblemName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProblemName.Location = new Point(118, 75);
            txtProblemName.Name = "txtProblemName";
            txtProblemName.Size = new Size(847, 23);
            txtProblemName.TabIndex = 3;
            // 
            // lblPlatform
            // 
            lblPlatform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPlatform.Location = new Point(12, 126);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(56, 15);
            lblPlatform.TabIndex = 4;
            lblPlatform.Text = "Platform:";
            // 
            // txtPlatform
            // 
            txtPlatform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPlatform.Location = new Point(118, 123);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(847, 23);
            txtPlatform.TabIndex = 5;
            // 
            // lblIdea
            // 
            lblIdea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIdea.Location = new Point(12, 198);
            lblIdea.Name = "lblIdea";
            lblIdea.Size = new Size(51, 15);
            lblIdea.TabIndex = 6;
            lblIdea.Text = "Idea file:";
            // 
            // lblIdeaStatus
            // 
            lblIdeaStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIdeaStatus.AutoSize = true;
            lblIdeaStatus.BackColor = SystemColors.ButtonHighlight;
            lblIdeaStatus.Location = new Point(74, 198);
            lblIdeaStatus.Name = "lblIdeaStatus";
            lblIdeaStatus.Size = new Size(119, 15);
            lblIdeaStatus.TabIndex = 7;
            lblIdeaStatus.Text = "No idea file imported";
            // 
            // btnImportIdea
            // 
            btnImportIdea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnImportIdea.Location = new Point(74, 227);
            btnImportIdea.Name = "btnImportIdea";
            btnImportIdea.Size = new Size(75, 23);
            btnImportIdea.TabIndex = 8;
            btnImportIdea.Text = "Import .txt";
            btnImportIdea.UseVisualStyleBackColor = true;
            // 
            // btnExportIdea
            // 
            btnExportIdea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExportIdea.Location = new Point(155, 227);
            btnExportIdea.Name = "btnExportIdea";
            btnExportIdea.Size = new Size(75, 23);
            btnExportIdea.TabIndex = 9;
            btnExportIdea.Text = "Export .txt";
            btnExportIdea.UseVisualStyleBackColor = true;
            // 
            // lblTags
            // 
            lblTags.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTags.AutoSize = true;
            lblTags.Location = new Point(12, 270);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(34, 15);
            lblTags.TabIndex = 10;
            lblTags.Text = "Tags:";
            // 
            // txtTags
            // 
            txtTags.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTags.Location = new Point(63, 267);
            txtTags.Name = "txtTags";
            txtTags.Size = new Size(902, 23);
            txtTags.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(12, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(93, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // progressSave
            // 
            progressSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressSave.Location = new Point(12, 365);
            progressSave.Name = "progressSave";
            progressSave.Size = new Size(953, 23);
            progressSave.TabIndex = 14;
            progressSave.Visible = false;
            // 
            // lblSaveStatus
            // 
            lblSaveStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSaveStatus.Location = new Point(12, 409);
            lblSaveStatus.Name = "lblSaveStatus";
            lblSaveStatus.Size = new Size(0, 15);
            lblSaveStatus.TabIndex = 15;


            btnImportIdea.Click += btnImportIdea_Click;
            btnExportIdea.Click += btnExportIdea_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;


            // 
            // AddEditProblemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 619);
            Controls.Add(lblSaveStatus);
            Controls.Add(progressSave);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTags);
            Controls.Add(lblTags);
            Controls.Add(btnExportIdea);
            Controls.Add(btnImportIdea);
            Controls.Add(lblIdeaStatus);
            Controls.Add(lblIdea);
            Controls.Add(txtPlatform);
            Controls.Add(lblPlatform);
            Controls.Add(txtProblemName);
            Controls.Add(lblName);
            Controls.Add(txtProblemLink);
            Controls.Add(lblLink);
            Name = "AddEditProblemForm";
            Text = "AddEditProblemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLink;
        private TextBox txtProblemLink;
        private Label lblName;
        private TextBox txtProblemName;
        private Label lblPlatform;
        private TextBox txtPlatform;
        private Label lblIdea;
        private Label lblIdeaStatus;
        private Button btnImportIdea;
        private Button btnExportIdea;
        private Label lblTags;
        private TextBox txtTags;
        private Button btnSave;
        private Button btnCancel;
        private ProgressBar progressSave;
        private Label lblSaveStatus;
    }
}