using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member member = new Member();
			Console.Write("新會員帳號");
			
			Console.Write("新會員密碼");

			Console.Write("請輸入帳號");

			Console.Write("請輸入密碼");





		}
		class Address
		{ 
			public string City { get; set; }
			public string ZipCode { get; set; }

			public string Street { get; set; }
		}
		class Telphone
		{
			public string CountryCode { get; set; }
			public string AreaCode { get; set; }
			public string Number { get; set; }
			public string Ext { get; set; }
		}
		class Member
		{
			public string Name { get; set; }
			public string Account { get; set; }
			public string Password { get; set; }
			public string Email { get; set; }
			public Address Address { get; set; }
			public string Cellphone { get; set; }
			public Telphone Telphone { get; set; }
			public void Register(Member Name, Member Account, Member Password, Member ConfirmPassword) 
			{ }
			public void ForgetPassword(Member Name,Member Email ) 
			{ }

			public void Authenticate(Member Account, Member Password) 
			{ }
		}
		
	}
}
