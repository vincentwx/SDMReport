using System;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json;
using SDContract;
namespace SDMReport
{
	public partial class SDMReportViewController : UIViewController
	{
		public SDMReportViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
		async partial void OnSignIn (UIButton sender)
		{
			LoginRequest req = new LoginRequest();

			req.UserName = c_userName.Text;
			req.Password = c_password.Text;

			string jReq = Newtonsoft.Json.JsonConvert.SerializeObject(req);

			HttpClient httpClient = new HttpClient(); 

			StringContent content = new StringContent(jReq, Encoding.UTF8, "application/json");


			HttpResponseMessage response = await httpClient.PostAsync("http://192.168.1.82:8990/api/Login",content);
			if (response.IsSuccessStatusCode)
			{
				string jRsp=  await response.Content.ReadAsStringAsync();
				LoginResponse rsp = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginResponse>(jRsp);
				UIAlertView alert = new UIAlertView ("Result", rsp.Result, null, "OK", null);
				alert.Show();
			}
			else
			{
				string errMsg=  await response.Content.ReadAsStringAsync();

				UIAlertView alert = new UIAlertView ("Error", errMsg, null, "OK", null);
				alert.Show();
			}

		}
		partial void OnSignUp (UIButton sender)
		{

		}

	}
}

