/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/3/2019
 * Time: 8:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai6
{
	/// <summary>
	/// Description of Clsroom.
	/// </summary>
	public class Clsroom : Clshuman
	{
		int idayleft,icost;
		string itype;
		double imoney;
		public int dayleft
		{
			get
			{
				return idayleft;
			}
			set
			{
				idayleft = value;
			}
		}
		public string type
		{
			get
			{
				return itype;
			}
			set
			{
				itype = value;
			}
		}
		public double money
		{
			get
			{
				return imoney = icost * idayleft;
			}
		
		}
		public int cost
		{
			get
			{
				return icost;
			}
			set
			{
				icost = value;
			}
		}
		public Clsroom()
		{
		}
	}
}
