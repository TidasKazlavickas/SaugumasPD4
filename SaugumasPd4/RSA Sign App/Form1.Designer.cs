namespace RSA_Sign_App
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
            txtPrivateKeyLocation = new TextBox();
            btnBrowsePrivateKey = new Button();
            btnPublicKey = new Button();
            txtPublicKeyLocation = new TextBox();
            txtBaseString = new TextBox();
            txtSignature = new TextBox();
            btnGenerateSign = new Button();
            btnVerifySign = new Button();
            cboRsaSHAkey = new ComboBox();
            SuspendLayout();
            // 
            // txtPrivateKeyLocation
            // 
            txtPrivateKeyLocation.Enabled = false;
            txtPrivateKeyLocation.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtPrivateKeyLocation.Location = new Point(31, 57);
            txtPrivateKeyLocation.Name = "txtPrivateKeyLocation";
            txtPrivateKeyLocation.Size = new Size(391, 23);
            txtPrivateKeyLocation.TabIndex = 0;
            txtPrivateKeyLocation.Text = "Private Locations";
            // 
            // btnBrowsePrivateKey
            // 
            btnBrowsePrivateKey.Location = new Point(473, 57);
            btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            btnBrowsePrivateKey.Size = new Size(125, 23);
            btnBrowsePrivateKey.TabIndex = 1;
            btnBrowsePrivateKey.Text = "Private";
            btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            btnBrowsePrivateKey.Click += btnBrowsePrivateKey_Click;
            // 
            // btnPublicKey
            // 
            btnPublicKey.Location = new Point(473, 108);
            btnPublicKey.Name = "btnPublicKey";
            btnPublicKey.Size = new Size(125, 23);
            btnPublicKey.TabIndex = 3;
            btnPublicKey.Text = "Public";
            btnPublicKey.UseVisualStyleBackColor = true;
            btnPublicKey.Click += btnPublicKey_Click;
            // 
            // txtPublicKeyLocation
            // 
            txtPublicKeyLocation.Enabled = false;
            txtPublicKeyLocation.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtPublicKeyLocation.Location = new Point(31, 108);
            txtPublicKeyLocation.Name = "txtPublicKeyLocation";
            txtPublicKeyLocation.Size = new Size(391, 23);
            txtPublicKeyLocation.TabIndex = 2;
            txtPublicKeyLocation.Text = "Public Locations";
            // 
            // txtBaseString
            // 
            txtBaseString.Location = new Point(31, 184);
            txtBaseString.Multiline = true;
            txtBaseString.Name = "txtBaseString";
            txtBaseString.Size = new Size(604, 82);
            txtBaseString.TabIndex = 5;
            txtBaseString.Text = "Tekstas";
            // 
            // txtSignature
            // 
            txtSignature.Location = new Point(31, 298);
            txtSignature.Multiline = true;
            txtSignature.Name = "txtSignature";
            txtSignature.Size = new Size(604, 100);
            txtSignature.TabIndex = 6;
            txtSignature.Text = "Parasas";
            // 
            // btnGenerateSign
            // 
            btnGenerateSign.Location = new Point(704, 196);
            btnGenerateSign.Name = "btnGenerateSign";
            btnGenerateSign.Size = new Size(134, 56);
            btnGenerateSign.TabIndex = 7;
            btnGenerateSign.Text = "Generuoti parasa";
            btnGenerateSign.UseVisualStyleBackColor = true;
            btnGenerateSign.Click += btnGenerateSign_Click;
            // 
            // btnVerifySign
            // 
            btnVerifySign.Location = new Point(704, 326);
            btnVerifySign.Name = "btnVerifySign";
            btnVerifySign.Size = new Size(134, 40);
            btnVerifySign.TabIndex = 8;
            btnVerifySign.Text = "Patikrinti parasa";
            btnVerifySign.UseVisualStyleBackColor = true;
            btnVerifySign.Click += btnVerifySign_Click;
            // 
            // cboRsaSHAkey
            // 
            cboRsaSHAkey.FormattingEnabled = true;
            cboRsaSHAkey.Location = new Point(651, 85);
            cboRsaSHAkey.Name = "cboRsaSHAkey";
            cboRsaSHAkey.Size = new Size(161, 23);
            cboRsaSHAkey.TabIndex = 4;
            cboRsaSHAkey.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(btnVerifySign);
            Controls.Add(btnGenerateSign);
            Controls.Add(txtSignature);
            Controls.Add(txtBaseString);
            Controls.Add(cboRsaSHAkey);
            Controls.Add(btnPublicKey);
            Controls.Add(txtPublicKeyLocation);
            Controls.Add(btnBrowsePrivateKey);
            Controls.Add(txtPrivateKeyLocation);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Main_App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrivateKeyLocation;
        private Button btnBrowsePrivateKey;
        private Button btnPublicKey;
        private TextBox txtPublicKeyLocation;
        private TextBox txtBaseString;
        private TextBox txtSignature;
        private Button btnGenerateSign;
        private Button btnVerifySign;
        private ComboBox cboRsaSHAkey;
    }
}