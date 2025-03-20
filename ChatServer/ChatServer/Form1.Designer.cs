namespace ChatServer
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
            btnListen = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            txtCount = new TextBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(15, 7);
            btnListen.Margin = new Padding(2);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(116, 46);
            btnListen.TabIndex = 0;
            btnListen.Text = "시작";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(150, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 394);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 386);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Count";
            // 
            // txtCount
            // 
            txtCount.Enabled = false;
            txtCount.Location = new Point(57, 378);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(74, 23);
            txtCount.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 411);
            Controls.Add(txtCount);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnListen);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private ListBox listBox1;
        private Label label1;
        private TextBox txtCount;
    }
}
