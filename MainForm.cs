namespace CP_Ideas_Tracker
{
    public partial class MainForm : Form
    {
        private int _userId;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(int userId) : this()
        {
            _userId = userId;
            Text = "CP Ideas Tracker";

            LoadProblems();
        }

        private void LoadProblems()
        {
            List<ProblemNote> problems = ProblemRepository.GetProblemsByUser(_userId);

            dgvProblems.DataSource = null;
            dgvProblems.DataSource = problems;

            dgvProblems.Columns["Id"].Visible = false;
            dgvProblems.Columns["UserId"].Visible = false;
            dgvProblems.Columns["Idea"].Visible = false;
            dgvProblems.Columns["SourceUser"].Visible = false;
            dgvProblems.Columns["IsImported"].Visible = false;

            dgvProblems.Columns["ProblemLink"].HeaderText = "Problem Link";
            dgvProblems.Columns["ProblemName"].HeaderText = "Problem Name";
            dgvProblems.Columns["Platform"].HeaderText = "Platform";
            dgvProblems.Columns["Tags"].HeaderText = "Tags";
            //dgvProblems.Columns["IsImported"].HeaderText = "Imported";
            dgvProblems.Columns["CreatedAt"].HeaderText = "Created At";
            dgvProblems.Columns["UpdatedAt"].HeaderText = "Updated At";

            dgvProblems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProblems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditProblemForm form = new AddEditProblemForm(_userId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.SavedProblem != null)
                {
                    ProblemRepository.AddProblem(form.SavedProblem);
                    LoadProblems();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProblems.CurrentRow == null)
            {
                MessageBox.Show("Select a problem first.");
                return;
            }

            ProblemNote selectedProblem = (ProblemNote)dgvProblems.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this problem?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            ProblemRepository.DeleteProblem(selectedProblem.Id, _userId);

            LoadProblems();
        }

        private void exportIdeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProblems.CurrentRow == null)
            {
                MessageBox.Show("Select a problem first.");
                return;
            }

            ProblemNote selectedProblem = (ProblemNote)dgvProblems.CurrentRow.DataBoundItem;

            using SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Export idea as text file";

            string fileName = selectedProblem.ProblemName.Trim();

            if (fileName == "")
            {
                fileName = "idea";
            }

            saveFileDialog.FileName = fileName + ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, selectedProblem.Idea);
                MessageBox.Show("Idea exported successfully.");
            }
        }

        private void dgvProblems_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvProblems.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0)
                {
                    dgvProblems.ClearSelection();
                    dgvProblems.Rows[hit.RowIndex].Selected = true;

                    foreach (DataGridViewCell cell in dgvProblems.Rows[hit.RowIndex].Cells)
                    {
                        if (cell.Visible)
                        {
                            dgvProblems.CurrentCell = cell;
                            break;
                        }
                    }
                }
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProblems.CurrentRow == null)
            {
                MessageBox.Show("Select a problem first.");
                return;
            }

            ProblemNote selectedProblem = (ProblemNote)dgvProblems.CurrentRow.DataBoundItem;

            AddEditProblemForm form = new AddEditProblemForm(_userId, selectedProblem);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.SavedProblem != null)
                {
                    ProblemRepository.UpdateProblem(form.SavedProblem);
                    LoadProblems();
                }
            }
        }
    }
}