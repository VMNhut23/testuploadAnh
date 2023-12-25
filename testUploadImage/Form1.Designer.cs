
namespace testUploadImage
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBManager2DataSet = new testUploadImage.DBManager2DataSet();
			this.testTableAdapter = new testUploadImage.DBManager2DataSetTableAdapters.TestTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBManager2DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn});
			this.dataGridView1.DataSource = this.testBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(1, 258);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(799, 192);
			this.dataGridView1.TabIndex = 0;
			// 
			// tenDataGridViewTextBoxColumn
			// 
			this.tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
			this.tenDataGridViewTextBoxColumn.HeaderText = "ten";
			this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
			this.tenDataGridViewTextBoxColumn.Width = 125;
			// 
			// hinhAnhDataGridViewImageColumn
			// 
			this.hinhAnhDataGridViewImageColumn.DataPropertyName = "hinhAnh";
			this.hinhAnhDataGridViewImageColumn.HeaderText = "hinhAnh";
			this.hinhAnhDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.hinhAnhDataGridViewImageColumn.MinimumWidth = 6;
			this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
			this.hinhAnhDataGridViewImageColumn.Width = 125;
			// 
			// testBindingSource
			// 
			this.testBindingSource.DataMember = "Test";
			this.testBindingSource.DataSource = this.dBManager2DataSet;
			// 
			// dBManager2DataSet
			// 
			this.dBManager2DataSet.DataSetName = "DBManager2DataSet";
			this.dBManager2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// testTableAdapter
			// 
			this.testTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(108, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ten";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Anh";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(181, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(202, 22);
			this.textBox1.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(210, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(458, 65);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 50);
			this.button2.TabIndex = 5;
			this.button2.Text = "Them";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(458, 145);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 50);
			this.button3.TabIndex = 6;
			this.button3.Text = "Sua";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(612, 101);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(93, 50);
			this.button4.TabIndex = 7;
			this.button4.Text = "Loc";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBManager2DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private DBManager2DataSet dBManager2DataSet;
		private System.Windows.Forms.BindingSource testBindingSource;
		private DBManager2DataSetTableAdapters.TestTableAdapter testTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
		private System.Windows.Forms.Button button4;
	}
}

