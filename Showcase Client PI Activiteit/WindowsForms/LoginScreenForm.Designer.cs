namespace Showcase_Client_PI_Activiteit
{
    partial class LoginScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreenForm));
            headerLabel = new Label();
            nameTextBox = new TextBox();
            ipTextBox = new TextBox();
            connectToServerButton = new Button();
            ErrorLabel1 = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Lucida Console", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.ControlText;
            headerLabel.Location = new Point(374, 35);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(532, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Connect To Server";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.ForeColor = SystemColors.ControlText;
            nameTextBox.Location = new Point(469, 164);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(342, 40);
            nameTextBox.TabIndex = 1;
            // 
            // ipTextBox
            // 
            ipTextBox.BackColor = Color.White;
            ipTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipTextBox.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ipTextBox.ForeColor = SystemColors.ControlText;
            ipTextBox.Location = new Point(469, 246);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.PlaceholderText = "IP Addres";
            ipTextBox.Size = new Size(342, 40);
            ipTextBox.TabIndex = 2;
            ipTextBox.Text = "127.0.0.1";
            // 
            // connectToServerButton
            // 
            connectToServerButton.BackColor = Color.White;
            connectToServerButton.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connectToServerButton.ForeColor = SystemColors.ControlText;
            connectToServerButton.Location = new Point(553, 333);
            connectToServerButton.Name = "connectToServerButton";
            connectToServerButton.Size = new Size(173, 42);
            connectToServerButton.TabIndex = 3;
            connectToServerButton.Text = "Connect";
            connectToServerButton.UseVisualStyleBackColor = false;
            connectToServerButton.Click += ConnectToServerButton_Click;
            // 
            // ErrorLabel1
            // 
            ErrorLabel1.AutoSize = true;
            ErrorLabel1.ForeColor = Color.Red;
            ErrorLabel1.Location = new Point(533, 299);
            ErrorLabel1.Name = "ErrorLabel1";
            ErrorLabel1.Size = new Size(0, 20);
            ErrorLabel1.TabIndex = 4;
            // 
            // LoginScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 673);
            Controls.Add(ErrorLabel1);
            Controls.Add(connectToServerButton);
            Controls.Add(ipTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(headerLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginScreenForm";
            Text = "Login Screen";
            FormClosing += LoginScreenForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox nameTextBox;
        private TextBox ipTextBox;
        private Button connectToServerButton;
        public Label ErrorLabel1 { get; private set; }
    }
}