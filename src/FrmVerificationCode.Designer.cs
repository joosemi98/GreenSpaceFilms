namespace ProyectoGreenSpace
{
    partial class FrmVerificationCode
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
            this.components = new System.ComponentModel.Container();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMailUser = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(131, 109);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(461, 40);
            this.txtMail.TabIndex = 0;
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(239, 168);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(228, 65);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Enviar correo de verificación";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSend_Paint);
            // 
            // lblMailUser
            // 
            this.lblMailUser.AutoSize = true;
            this.lblMailUser.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailUser.Location = new System.Drawing.Point(127, 72);
            this.lblMailUser.Name = "lblMailUser";
            this.lblMailUser.Size = new System.Drawing.Size(430, 23);
            this.lblMailUser.TabIndex = 2;
            this.lblMailUser.Text = "INTRODUCE TÚ CORREO ELECTRÓNICO:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmVerificationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 289);
            this.Controls.Add(this.lblMailUser);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMail);
            this.Name = "FrmVerificationCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmVerificationCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMailUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}