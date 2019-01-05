/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/3/2019
 * Time: 8:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai6
{
	/// <summary>
	/// Description of Clshuman.
	/// </summary>
	public class Clshuman
	{
		
		string iname,iid;
		int iage,iyear;
		public int year
		{
			get
			{
				return iyear;
			}
			set
			{
				iyear = value;
			}
		}
		public int age
		{
			get
			{
				return iage = DateTime.Now.Year - iyear;
			}
			
			
		}
		public string id
		{
			get
			{
				return iid;
			}
			set
			{
				iid = value;
			}
		}
		public string name
		{
			get
			{
				return iname;
			}
			set
			{
				iname = value;
			}
		}
		public Clshuman()
		{
		}
	}
}
