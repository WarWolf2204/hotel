/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/3/2019
 * Time: 8:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace bai6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Clsroom room = new Clsroom();
		List<Clsroom> dsphong = new List<Clsroom>();
		BindingList<Clsroom> bindingList;
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bindingList = new BindingList<Clsroom>(dsphong);
 			source = new BindingSource(bindingList, null);
			show.DataSource = source;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void cleardata()
		{
			ten.Text = "";
			nam.Text = "";
			cmnd.Text = "";
			ngaytro.Text = "";
		}
		void NhapClick(object sender, EventArgs e)
		{
			
			if(ten.Text.Length > 20 || cmnd.Text.Length > 12 || ten.Text =="" || nam.Text =="" || cmnd.Text =="" || ngaytro.Text =="")
			{
				cleardata();
			}
			else
			{
			room.name = ten.Text;
			room.id = cmnd.Text;
			room.dayleft = int.Parse(ngaytro.Text);
			source.Add(room);
			room = new Clsroom();
			cleardata();
			show.Refresh();
			}
		}
		
		void RbACheckedChanged(object sender, EventArgs e)
		{
			if(rbA.Checked == true)
			{
				room.type = rbA.Text;
				room.cost = int.Parse("200");
			}
		}
		
		void RbBCheckedChanged(object sender, EventArgs e)
		{
			if(rbB.Checked == true)
			{
				room.cost = int.Parse("400");
				room.type = rbB.Text;
			}
		}
		
		void RbCCheckedChanged(object sender, EventArgs e)
		{
			if(rbC.Checked == true)
			{
				room.cost = int.Parse("800");
				room.type = rbC.Text;
			}
		}
		
		void NamTextChanged(object sender, EventArgs e)
		{
			try
			{
				room.year = int.Parse(nam.Text);
			}
			catch
			{}
		}
	}
}
