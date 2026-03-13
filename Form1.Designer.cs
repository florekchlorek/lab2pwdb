namespace lab2
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
            listViewKoszyk = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewKoszyk
            // 
            listViewKoszyk.BackgroundImageTiled = true;
            listViewKoszyk.Location = new Point(26, 25);
            listViewKoszyk.Name = "listViewKoszyk";
            listViewKoszyk.Size = new Size(231, 406);
            listViewKoszyk.TabIndex = 0;
            listViewKoszyk.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(299, 208);
            button1.Name = "button1";
            button1.Size = new Size(221, 39);
            button1.TabIndex = 1;
            button1.Text = "Wybierz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 302);
            button2.Name = "button2";
            button2.Size = new Size(221, 39);
            button2.TabIndex = 2;
            button2.Text = "Transport";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 392);
            button3.Name = "button3";
            button3.Size = new Size(221, 39);
            button3.TabIndex = 3;
            button3.Text = "Zapłać";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(377, 59);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "Cena:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewKoszyk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewKoszyk;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}
