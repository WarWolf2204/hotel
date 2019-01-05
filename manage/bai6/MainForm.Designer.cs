/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/3/2019
 * Time: 8:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bai6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ten = new System.Windows.Forms.TextBox();
			this.nam = new System.Windows.Forms.TextBox();
			this.cmnd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ngaytro = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.show = new System.Windows.Forms.DataGrid();
			this.nhap = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbC = new System.Windows.Forms.RadioButton();
			this.rbB = new System.Windows.Forms.RadioButton();
			this.rbA = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "year";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "id";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ten
			// 
			this.ten.Location = new System.Drawing.Point(66, 11);
			this.ten.Name = "ten";
			this.ten.Size = new System.Drawing.Size(119, 20);
			this.ten.TabIndex = 4;
			// 
			// nam
			// 
			this.nam.Location = new System.Drawing.Point(66, 55);
			this.nam.Name = "nam";
			this.nam.Size = new System.Drawing.Size(119, 20);
			this.nam.TabIndex = 5;
			this.nam.TextChanged += new System.EventHandler(this.NamTextChanged);
			// 
			// cmnd
			// 
			this.cmnd.Location = new System.Drawing.Point(66, 98);
			this.cmnd.Name = "cmnd";
			this.cmnd.Size = new System.Drawing.Size(119, 20);
			this.cmnd.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(244, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "day";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ngaytro
			// 
			this.ngaytro.Location = new System.Drawing.Point(307, 14);
			this.ngaytro.Name = "ngaytro";
			this.ngaytro.Size = new System.Drawing.Size(119, 20);
			this.ngaytro.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(244, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "type room";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// show
			// 
			this.show.DataMember = "";
			this.show.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.show.Location = new System.Drawing.Point(22, 191);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(404, 106);
			this.show.TabIndex = 14;
			// 
			// nhap
			// 
			this.nhap.Location = new System.Drawing.Point(52, 137);
			this.nhap.Name = "nhap";
			this.nhap.Size = new System.Drawing.Size(57, 39);
			this.nhap.TabIndex = 15;
			this.nhap.Text = "add";
			this.nhap.UseVisualStyleBackColor = true;
			this.nhap.Click += new System.EventHandler(this.NhapClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbC);
			this.groupBox1.Controls.Add(this.rbB);
			this.groupBox1.Controls.Add(this.rbA);
			this.groupBox1.Location = new System.Drawing.Point(307, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(119, 36);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// rbC
			// 
			this.rbC.Location = new System.Drawing.Point(84, 12);
			this.rbC.Name = "rbC";
			this.rbC.Size = new System.Drawing.Size(33, 24);
			this.rbC.TabIndex = 2;
			this.rbC.TabStop = true;
			this.rbC.Text = "C";
			this.rbC.UseVisualStyleBackColor = true;
			this.rbC.CheckedChanged += new System.EventHandler(this.RbCCheckedChanged);
			// 
			// rbB
			// 
			this.rbB.Location = new System.Drawing.Point(45, 12);
			this.rbB.Name = "rbB";
			this.rbB.Size = new System.Drawing.Size(33, 24);
			this.rbB.TabIndex = 1;
			this.rbB.TabStop = true;
			this.rbB.Text = "B";
			this.rbB.UseVisualStyleBackColor = true;
			this.rbB.CheckedChanged += new System.EventHandler(this.RbBCheckedChanged);
			// 
			// rbA
			// 
			this.rbA.Location = new System.Drawing.Point(6, 12);
			this.rbA.Name = "rbA";
			this.rbA.Size = new System.Drawing.Size(33, 24);
			this.rbA.TabIndex = 0;
			this.rbA.TabStop = true;
			this.rbA.Text = "A";
			this.rbA.UseVisualStyleBackColor = true;
			this.rbA.CheckedChanged += new System.EventHandler(this.RbACheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 309);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.nhap);
			this.Controls.Add(this.show);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ngaytro);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmnd);
			this.Controls.Add(this.nam);
			this.Controls.Add(this.ten);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "bai6";
			((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbA;
		private System.Windows.Forms.RadioButton rbB;
		private System.Windows.Forms.RadioButton rbC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button nhap;
		private System.Windows.Forms.DataGrid show;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox ngaytro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox cmnd;
		private System.Windows.Forms.TextBox nam;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
