namespace CP_Ideas_Tracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int? userId = UserRepository.LoginUser(txtUsername.Text, txtPassword.Text);

            if (userId == null)
            {
                lblStatus.Text = "Invalid username or password.";
                return;
            }

            MainForm mainForm = new MainForm(userId.Value);
            mainForm.Show();

            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool success = UserRepository.RegisterUser(
                txtUsername.Text,
                txtPassword.Text,
                out string errorMessage
            );

            if (!success)
            {
                lblStatus.Text = errorMessage;
                return;
            }

            lblStatus.Text = "Account created. You can login now.";
        }
    }
}
