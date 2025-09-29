namespace Showcase_Client_PI_Activiteit
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 35);
            label1.Name = "label1";
            label1.Size = new Size(532, 50);
            label1.TabIndex = 0;
            label1.Text = "Connect To Server";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(469, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 40);
            textBox1.TabIndex = 1;
            textBox1.Text = "Name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(469, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 40);
            textBox2.TabIndex = 2;
            textBox2.Text = "192.168.178.153";
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(553, 333);
            button1.Name = "button1";
            button1.Size = new Size(173, 42);
            button1.TabIndex = 3;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}