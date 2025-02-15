namespace PIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            email.Text = "E-mail";
            email.ForeColor = System.Drawing.Color.Gray;

            senha.Text = "Senha";
            senha.ForeColor = System.Drawing.Color.Gray;

            // Ação de remover e adicionar os textos

            email.GotFocus += TextoEmail_GotFocus;
            email.LostFocus += TextoEmail_LostFocus;

            senha.GotFocus += TextoSenha_GotFocus;
            senha.LostFocus += TextoSenha_LostFocus;
        }

        private void TextoEmail_GotFocus(object sender, EventArgs e)
        {
            if (email.Text == "E-mail")
            {
                email.Text = "";
                email.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void TextoEmail_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                email.Text = "E-mail";
                email.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void TextoSenha_GotFocus(Object sender, EventArgs e)
        {
            if (senha.Text == "Senha")
            {
                senha.Text = "";
                senha.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void TextoSenha_LostFocus(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(senha.Text))
            {
                senha.Text = "Senha";
                senha.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = email;
            ActiveControl = senha;
            ActiveControl = acessar;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!email.Bounds.Contains(e.Location))
            {
                this.ActiveControl = null;
            }
        }
    }
}
