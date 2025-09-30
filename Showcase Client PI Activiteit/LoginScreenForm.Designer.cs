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
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Lucida Console", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(374, 35);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(532, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Connect To Server";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(469, 164);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(342, 40);
            nameTextBox.TabIndex = 1;
            nameTextBox.Text = "Name";
            // 
            // ipTextBox
            // 
            ipTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipTextBox.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ipTextBox.Location = new Point(469, 246);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(342, 40);
            ipTextBox.TabIndex = 2;
            ipTextBox.Text = "192.168.178.153";
            // 
            // connectToServerButton
            // 
            connectToServerButton.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connectToServerButton.Location = new Point(553, 333);
            connectToServerButton.Name = "connectToServerButton";
            connectToServerButton.Size = new Size(173, 42);
            connectToServerButton.TabIndex = 3;
            connectToServerButton.Text = "Connect";
            connectToServerButton.UseVisualStyleBackColor = true;
            connectToServerButton.Click += connectToServerButton_Click;
            // 
            // LoginScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(connectToServerButton);
            Controls.Add(ipTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(headerLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginScreenForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox nameTextBox;
        private TextBox ipTextBox;
        private Button connectToServerButton;
    }
}