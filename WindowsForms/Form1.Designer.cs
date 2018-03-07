namespace WindowsForms
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbxFilePath = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.tbxDecryptedFilePath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxPrivatePemText = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Path to File";
			// 
			// tbxFilePath
			// 
			this.tbxFilePath.Location = new System.Drawing.Point(80, 13);
			this.tbxFilePath.Name = "tbxFilePath";
			this.tbxFilePath.Size = new System.Drawing.Size(192, 20);
			this.tbxFilePath.TabIndex = 1;
			this.tbxFilePath.Text = "C:\\Users\\esteb\\Desktop\\encryptme.txt";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 206);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(260, 31);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Go!";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// tbxDecryptedFilePath
			// 
			this.tbxDecryptedFilePath.Location = new System.Drawing.Point(12, 180);
			this.tbxDecryptedFilePath.Name = "tbxDecryptedFilePath";
			this.tbxDecryptedFilePath.Size = new System.Drawing.Size(260, 20);
			this.tbxDecryptedFilePath.TabIndex = 8;
			this.tbxDecryptedFilePath.Text = "C:\\Users\\esteb\\Desktop\\decrypted.txt";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Path to write decrypted data:";
			// 
			// tbxPrivatePemText
			// 
			this.tbxPrivatePemText.Location = new System.Drawing.Point(12, 65);
			this.tbxPrivatePemText.Name = "tbxPrivatePemText";
			this.tbxPrivatePemText.Size = new System.Drawing.Size(259, 96);
			this.tbxPrivatePemText.TabIndex = 10;
			this.tbxPrivatePemText.Text = "D:\\tmp\\private.key";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Path to private RSA key file (.key):";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 248);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxPrivatePemText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxDecryptedFilePath);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.tbxFilePath);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "RSA Encryption";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxFilePath;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox tbxDecryptedFilePath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox tbxPrivatePemText;
		private System.Windows.Forms.Label label2;
	}
}

