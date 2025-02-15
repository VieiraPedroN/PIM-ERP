namespace PIM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label title_login;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button acessar;

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
            email = new TextBox();
            senha = new TextBox();
            title_login = new Label();
            acessar = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // email
            // 
            email.Cursor = Cursors.IBeam;
            email.ImeMode = ImeMode.NoControl;
            email.Location = new Point(262, 178);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(290, 25);
            email.TabIndex = 0;
            // 
            // senha
            // 
            senha.AcceptsReturn = true;
            senha.Cursor = Cursors.IBeam;
            senha.Location = new Point(262, 232);
            senha.Multiline = true;
            senha.Name = "senha";
            senha.Size = new Size(290, 25);
            senha.TabIndex = 0;
            // 
            // title_login
            // 
            title_login.AutoSize = true;
            title_login.BackColor = Color.Transparent;
            title_login.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_login.Location = new Point(246, 60);
            title_login.Margin = new Padding(0);
            title_login.Name = "title_login";
            title_login.Size = new Size(142, 55);
            title_login.TabIndex = 0;
            title_login.Text = "Login";
            // 
            // acessar
            // 
            acessar.BackColor = Color.SlateBlue;
            acessar.Cursor = Cursors.Hand;
            acessar.FlatAppearance.BorderSize = 0;
            acessar.FlatStyle = FlatStyle.Flat;
            acessar.Location = new Point(262, 289);
            acessar.Name = "acessar";
            acessar.Size = new Size(290, 35);
            acessar.TabIndex = 0;
            acessar.Text = "Acessar";
            acessar.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(262, 333);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Lembre-se de mim";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(447, 334);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu a senha?";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // Form1
            // 
            BackColor = Color.MediumSlateBlue;
            BackgroundImage = PIM_ERP.Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(title_login);
            Controls.Add(email);
            Controls.Add(senha);
            Controls.Add(acessar);
            Name = "Form1";
            Text = "PIM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
    }
}
