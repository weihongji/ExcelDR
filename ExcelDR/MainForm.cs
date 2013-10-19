using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace ExcelDR
{
	public partial class MainForm : Form
	{
		String m_FiledPath = ""; // Path & Name

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			txtPath.Text = FiledPath;
		}

		private void btnSelectPath_Click(object sender, EventArgs e) {
			this.folderBrowserDialog1.SelectedPath = txtPath.Text;
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				txtPath.Text = this.folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnAssignDate_Click(object sender, EventArgs e) {
			if (AssignDate()) {
				FiledPath = txtPath.Text;
			}
		}

		private bool AssignDate() {
			int successCount = 0, failCount =0;

			if (Directory.Exists(txtPath.Text)) {

				Microsoft.Office.Interop.Excel.Application theExcelApp = new Microsoft.Office.Interop.Excel.Application();
				Workbook theExcelBook;
				Worksheet theSheet;
				Range theCell;
				String[] files = Directory.GetFiles(txtPath.Text);

				foreach (String filePath in files) {
					FileInfo file = new FileInfo(filePath);
					String fileName = file.Name; //20090715.xls
					String dateString;
					DateTime dt;

					if (fileName.Length < 8) {
						continue;
					}
					else {
						dateString = fileName.Substring(0, 4) + "/" + fileName.Substring(4, 2) + "/" + fileName.Substring(6, 2);
					}

					if (DateTime.TryParse(dateString, out dt)) {
						theExcelBook = theExcelApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
						theSheet = (Worksheet)theExcelBook.Sheets.get_Item("Sheet1");
						theCell = (Range)theSheet.get_Range("B2", "B2");

						theCell.Value2 = dt.ToString("MM/dd/yyyy");

						theExcelBook.Save();
						theExcelApp.Workbooks.Close();
						successCount++;
					}
					else {
						failCount++;
					}
				}
				theExcelApp.Quit();

				MessageBox.Show(successCount.ToString() + " successed, " + failCount.ToString() + " failed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;
			}
			else {
				MessageBox.Show("File path does not exist.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPath.Focus();
				txtPath.SelectAll();
				return false;
			}
		}

		public String FiledPath {
			get {
				if (m_FiledPath.Length == 0) { // Read from configration file
					if (File.Exists("dr.txt")) {
						m_FiledPath = File.ReadAllText("dr.txt").Trim();
					}
					else {
						m_FiledPath = Directory.GetCurrentDirectory();
						File.WriteAllText("dr.txt", m_FiledPath);
					}
				}

				return m_FiledPath;
			}
			set {
				if (String.Compare(FiledPath, value) != 0) {
					File.WriteAllText("dr.txt", value);
				}
			}
		}
	}
}