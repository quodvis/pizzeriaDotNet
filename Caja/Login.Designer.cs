namespace Caja
{
    partial class LoginForm
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
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIniciarSesion.Location = new System.Drawing.Point(129, 41);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(104, 20);
            this.labelIniciarSesion.TabIndex = 0;
            this.labelIniciarSesion.Text = "Iniciar Sesion";
            this.labelIniciarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(93, 102);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(75, 142);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(154, 102);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(154, 142);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '•';
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(154, 205);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Iniciar Sesion";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.BotonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 299);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelIniciarSesion);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonLogin;
    }
}