using System;

namespace SDContract
{
	public class LoginResponse
	{
		public string Result{get;set;}
		public string Name{ get; set;}
		public int AccessLevel{ get; set;}
	
		public LoginResponse ()
		{
		}
	}
}

