using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUploadImage
{
	public partial class Form1 : Form
	{
		dbUploadImageDataContext db = new dbUploadImageDataContext();
		Test ts = new Test();
		private DataTable originTable;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dBManager2DataSet.Test' table. You can move, or remove it, as needed.
			this.testTableAdapter.Fill(this.dBManager2DataSet.Test);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Chon Anh";
			openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.ImageLocation = openFileDialog.FileName;
			}
		}
		private byte[] ImageToByteArray(PictureBox picture)
		{
			MemoryStream memoryStream = new MemoryStream();
			picture.Image.Save(memoryStream, picture.Image.RawFormat);
			return memoryStream.ToArray();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ts.ten = textBox1.Text;
			byte[] anh = ImageToByteArray(pictureBox1);
			ts.hinhAnh = anh;
			db.Tests.InsertOnSubmit(ts);
			db.SubmitChanges();
			MessageBox.Show("Add successfully");
			Form1_Load(sender,e);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string filterText = textBox1.Text.Trim();
			if (!string.IsNullOrEmpty(filterText))
			{
				DataTable filterDBTable = originTable.AsEnumerable()
					.Where(row => row.Field<string>("Name").ToLower().Contains(filterText.ToLower()))
					.CopyToDataTable();
				Form1_Load(sender,e);
			}
		}
	}
}
