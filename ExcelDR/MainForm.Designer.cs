namespace ExcelDR
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnAssignDate = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnSelectPath = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// btnAssignDate
			// 
			this.btnAssignDate.Location = new System.Drawing.Point(216, 72);
			this.btnAssignDate.Name = "btnAssignDate";
			this.btnAssignDate.Size = new System.Drawing.Size(124, 23);
			this.btnAssignDate.TabIndex = 3;
			this.btnAssignDate.Text = "&Assign Date";
			this.btnAssignDate.UseVisualStyleBackColor = true;
			this.btnAssignDate.Click += new System.EventHandler(this.btnAssignDate_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(84, 25);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(366, 21);
			this.txtPath.TabIndex = 1;
			// 
			// btnSelectPath
			// 
			this.btnSelectPath.Location = new System.Drawing.Point(473, 24);
			this.btnSelectPath.Name = "btnSelectPath";
			this.btnSelectPath.Size = new System.Drawing.Size(47, 23);
			this.btnSelectPath.TabIndex = 2;
			this.btnSelectPath.Text = "...";
			this.btnSelectPath.UseVisualStyleBackColor = true;
			this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "&File path:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 183);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSelectPath);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnAssignDate);
			this.Name = "MainForm";
			this.Text = "Manipulator Daily Report";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAssignDate;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnSelectPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

