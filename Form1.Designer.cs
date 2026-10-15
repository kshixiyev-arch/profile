namespace profile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxProfile = new PictureBox();
            btnUploadImage = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtMasked = new MaskedTextBox();
            btnSave = new Button();
            panelStatus = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Image = Properties.Resources.user;
            pictureBoxProfile.Location = new Point(32, 23);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(160, 165);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = SystemColors.ActiveBorder;
            btnUploadImage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUploadImage.Location = new Point(32, 220);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(160, 47);
            btnUploadImage.TabIndex = 1;
            btnUploadImage.Text = "Əlavə et";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(276, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "istifadəçi adı";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 27);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "gmail ünvanı";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(276, 161);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(208, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Text = "Telefon";
            txtPhone.Enter += txtPhone_Enter;
            txtPhone.KeyPress += txtPhone_KeyPress;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // txtMasked
            // 
            txtMasked.Location = new Point(276, 240);
            txtMasked.Mask = "00-00-000";
            txtMasked.Name = "txtMasked";
            txtMasked.Size = new Size(208, 27);
            txtMasked.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.Location = new Point(276, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Yadda saxla";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = SystemColors.ActiveBorder;
            panelStatus.Location = new Point(32, 394);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(452, 62);
            panelStatus.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 479);
            Controls.Add(panelStatus);
            Controls.Add(btnSave);
            Controls.Add(txtMasked);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(btnUploadImage);
            Controls.Add(pictureBoxProfile);
            Name = "Form1";
            Text = "Prrofile";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProfile;
        private Button btnUploadImage;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private MaskedTextBox txtMasked;
        private Button btnSave;
        private Panel panelStatus;
    }
}
