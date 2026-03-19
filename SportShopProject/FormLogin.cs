using SportShopProject.Models;

namespace SportShopProject
{//
    public partial class FormLogin : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) || String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Введите логин или пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new SportShopDbContext())
            {
                var user = db.Users
                    .Where(w => w.Login == textBoxLogin.Text && w.Password == textBoxPassword.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ButtonLoginGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
