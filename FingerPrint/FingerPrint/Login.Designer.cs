namespace FingerPrint
{
    partial class Login
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
            this.BTN_Login = new System.Windows.Forms.Button();
            this.TXT_Utilisateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_MotDePasse = new System.Windows.Forms.TextBox();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(127, 117);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(111, 36);
            this.BTN_Login.TabIndex = 0;
            this.BTN_Login.Text = "Connecter";
            this.BTN_Login.UseVisualStyleBackColor = true;
            // 
            // TXT_Utilisateur
            // 
            this.TXT_Utilisateur.Location = new System.Drawing.Point(203, 34);
            this.TXT_Utilisateur.Name = "TXT_Utilisateur";
            this.TXT_Utilisateur.Size = new System.Drawing.Size(175, 20);
            this.TXT_Utilisateur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // TXT_MotDePasse
            // 
            this.TXT_MotDePasse.Location = new System.Drawing.Point(203, 75);
            this.TXT_MotDePasse.Name = "TXT_MotDePasse";
            this.TXT_MotDePasse.Size = new System.Drawing.Size(175, 20);
            this.TXT_MotDePasse.TabIndex = 1;
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(267, 117);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(111, 36);
            this.BTN_Quitter.TabIndex = 0;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_MotDePasse);
            this.Controls.Add(this.TXT_Utilisateur);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Login);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.TextBox TXT_Utilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MotDePasse;
        private System.Windows.Forms.Button BTN_Quitter;
    }
}