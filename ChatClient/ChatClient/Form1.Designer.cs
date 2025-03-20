namespace ChatClient
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
            components = new System.ComponentModel.Container();
            btnConnect = new Button();
            btnSend = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtCount = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(15, 7);
            btnConnect.Margin = new Padding(2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(120, 50);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "연결";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(15, 95);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 50);
            btnSend.TabIndex = 0;
            btnSend.Text = "메시지 전송";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(150, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 394);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtCount
            // 
            txtCount.Enabled = false;
            txtCount.Location = new Point(61, 376);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(74, 23);
            txtCount.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 384);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Count";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 411);
            Controls.Add(txtCount);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnSend;
        private ListBox listBox1;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtCount;
        private Label label1;
    }
}
