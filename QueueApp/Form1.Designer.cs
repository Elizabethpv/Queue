
namespace QueueApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnque = new System.Windows.Forms.Button();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.TxtDeque = new System.Windows.Forms.TextBox();
            this.btndeque = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnque
            // 
            this.btnEnque.Location = new System.Drawing.Point(284, 99);
            this.btnEnque.Name = "btnEnque";
            this.btnEnque.Size = new System.Drawing.Size(275, 35);
            this.btnEnque.TabIndex = 0;
            this.btnEnque.Text = "Enque";
            this.btnEnque.UseVisualStyleBackColor = true;
            this.btnEnque.Click += new System.EventHandler(this.btnEnque_Click);
            // 
            // txtWrite
            // 
            this.txtWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrite.Location = new System.Drawing.Point(284, 41);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(275, 37);
            this.txtWrite.TabIndex = 1;
            // 
            // TxtDeque
            // 
            this.TxtDeque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeque.Location = new System.Drawing.Point(284, 155);
            this.TxtDeque.Multiline = true;
            this.TxtDeque.Name = "TxtDeque";
            this.TxtDeque.Size = new System.Drawing.Size(275, 37);
            this.TxtDeque.TabIndex = 2;
            this.TxtDeque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDeque.TextChanged += new System.EventHandler(this.TxtDeque_TextChanged);
            // 
            // btndeque
            // 
            this.btndeque.Location = new System.Drawing.Point(284, 213);
            this.btndeque.Name = "btndeque";
            this.btndeque.Size = new System.Drawing.Size(275, 35);
            this.btndeque.TabIndex = 3;
            this.btndeque.Text = "Deque";
            this.btndeque.UseVisualStyleBackColor = true;
            this.btndeque.Click += new System.EventHandler(this.btndeque_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(773, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(773, 150);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(95, 35);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(711, 12);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(173, 43);
            this.lst2.TabIndex = 6;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(711, 79);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(173, 43);
            this.lst1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndeque);
            this.Controls.Add(this.TxtDeque);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.btnEnque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnque;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox TxtDeque;
        private System.Windows.Forms.Button btndeque;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

