using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGreenSpace
{
    public partial class FrmVerificationCode : Form
    {
        string viewMail;
        public FrmVerificationCode(string mail)
        {
            InitializeComponent();
            viewMail = mail;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Mail enviarMail = new Mail();
            if (ValidarDatos())
            {
                int code = enviarMail.Enviar("floadm123@gmail.com", "AdminFlo123", viewMail);
                if (code != -1)
                {
                    FrmInsertCode frmInsertCode = new FrmInsertCode(code);
                    frmInsertCode.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Código no enviado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmVerificationCode_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 228, 116);
            btnSend.BackColor = Color.FromArgb(76, 80, 144);

            txtMail.Focus();
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (String.IsNullOrEmpty(txtMail.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMail, "Introduzca una dirección de correo electrónico.");
            }
            else if (viewMail != txtMail.Text)
            {
                ok = false;
                errorProvider1.SetError(txtMail, "Introduzca el mismo correo electrónico.");
            }
            return ok;
        }

        #region Diseño de interface
        private void txtMail_Enter(object sender, EventArgs e)
        {
            txtMail.BackColor = Color.SkyBlue;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            txtMail.BackColor = Color.White;
        }

        private void btnSend_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnSend.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        #endregion
    }
}