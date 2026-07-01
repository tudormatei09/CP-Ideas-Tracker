namespace CP_Ideas_Tracker
{
    public partial class AddEditProblemForm : Form
    {
        private int _userId;
        private string _ideaText = "";
        private ProblemNote? _existingProblem;

        public ProblemNote? SavedProblem { get; private set; }

        public AddEditProblemForm(int userId)
        {
            InitializeComponent();

            _userId = userId;
            Text = "Add Problem";

            progressSave.Visible = false;
            lblSaveStatus.Visible = false;
        }

        public AddEditProblemForm(int userId, ProblemNote existingProblem) : this(userId)
        {
            _existingProblem = existingProblem;

            Text = "Edit Problem";

            txtProblemLink.Text = existingProblem.ProblemLink;
            txtProblemName.Text = existingProblem.ProblemName;
            txtPlatform.Text = existingProblem.Platform;
            txtTags.Text = existingProblem.Tags;

            _ideaText = existingProblem.Idea;
            lblIdeaStatus.Text = "Existing idea loaded.";
        }

        private void btnImportIdea_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Import idea from text file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ideaText = File.ReadAllText(openFileDialog.FileName);
                lblIdeaStatus.Text = "Imported: " + Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void btnExportIdea_Click(object sender, EventArgs e)
        {
            if (_ideaText.Trim() == "")
            {
                MessageBox.Show("No idea available to export.");
                return;
            }

            using SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Export idea as text file";

            string fileName = txtProblemName.Text.Trim();

            if (fileName == "")
            {
                fileName = "idea";
            }

            saveFileDialog.FileName = fileName + ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, _ideaText);
                MessageBox.Show("Idea exported successfully.");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            progressSave.Visible = true;
            lblSaveStatus.Visible = true;
            progressSave.Value = 0;
            lblSaveStatus.Text = "Validating...";

            await Task.Delay(200);

            if (txtProblemLink.Text.Trim() == "")
            {
                MessageBox.Show("Problem link is required.");
                progressSave.Visible = false;
                lblSaveStatus.Visible = false;
                return;
            }

            if (_ideaText.Trim() == "")
            {
                MessageBox.Show("You must import an idea .txt file.");
                progressSave.Visible = false;
                lblSaveStatus.Visible = false;
                return;
            }

            progressSave.Value = 50;
            lblSaveStatus.Text = "Preparing problem...";

            await Task.Delay(200);

            SavedProblem = new ProblemNote
            {
                Id = _existingProblem?.Id ?? 0,
                UserId = _userId,
                ProblemLink = txtProblemLink.Text.Trim(),
                ProblemName = txtProblemName.Text.Trim(),
                Platform = txtPlatform.Text.Trim(),
                Idea = _ideaText,
                Tags = txtTags.Text.Trim(),
                SourceUser = _existingProblem?.SourceUser ?? "",
                IsImported = _existingProblem?.IsImported ?? false
            };

            progressSave.Value = 100;
            lblSaveStatus.Text = "Saved.";

            await Task.Delay(200);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}