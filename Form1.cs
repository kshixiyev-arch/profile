namespace profile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Şəkil Faylları|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Profil şəkli seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "istifadəçi adı")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "istifadəçi adı";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "gmail ünvanı")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "gmail ünvanı";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Telefon")
            {
                txtPhone.Text = "";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "Telefon";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string code = txtMasked.Text.Trim();

            if (username == "" || username == "istifadəçi adı")
            {
                MessageBox.Show("Lütfən, istifadəçi adını daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email == "" || email == "gmail ünvanı" || !email.Contains("@"))
            {
                MessageBox.Show("Düzgün bir gmail ünvanı daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefonun 10 rəqəm olub-olmadığını yoxlayır
            if (phone == "" || phone == "Telefon")
            {
                MessageBox.Show("Lütfən, telefon nömrəsini daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (phone.Length != 10)
            {
                MessageBox.Show("Telefon nömrəsi dəqiq 10 rəqəm olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Məlumatlar uğurla yadda saxlanıldı!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Rəqəm və Backspace xaricində heç bir düyməni qəbul etmir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
