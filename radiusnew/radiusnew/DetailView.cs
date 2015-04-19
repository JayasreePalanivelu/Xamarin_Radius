
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace radiusnew
{
	[Activity (Label = "DetailView")]			
	public class DetailView : Activity
	{
		TextView txtTelephone;
		TextView txtAddress;
		TextView txtOpenHrs;
		string  LocationName; 
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.detail);
			LocationName = Intent.GetStringExtra("Name");	

			Toast.MakeText (this, LocationName, ToastLength.Short).Show (); 
			txtAddress = FindViewById <TextView> (Resource.Id.txtAddress);
			txtOpenHrs = FindViewById<TextView> (Resource.Id.txtOpenHrs);
			txtTelephone = FindViewById <TextView> (Resource.Id.txtTelephone);
			if (LocationName == "Rototuna") {
				LoadDetailRotatuna ();
			} else if (LocationName == "St. Andrews") {
				LoadDetailStAndrews ();
			} else if (LocationName == "Davies Corner") {
				LoadDetailDavies ();
			} else if (LocationName == "K'aute Family") {
				LoadKauteFamily ();
			} else if (LocationName == "ParentLine") {
				LoadParentline ();
			}



			// Create your application here
		}	
		public  void LoadDetailRotatuna()
		{
			txtAddress.Text = "Rototuna Shopping Centre Hamilton";
			Toast.MakeText (this,txtAddress.Text, ToastLength.Short).Show (); 
			txtTelephone.Text = "078525377";
			txtOpenHrs.Text = "Mon -Sun 08:00 AM - 05:00 PM";

		}
		public void LoadDetailStAndrews()
		{
			txtAddress.Text = "26 Bryant Road, Te rapa, Hamilton";
			txtTelephone.Text = " 078494181";
			txtOpenHrs.Text = "Mon - Fri 08:00AM - 05:00 PM";

		}
		public void LoadDetailDavies()
		{
			txtAddress.Text = "31 Hukunai Road, Chartwell, Hamilton";
						txtOpenHrs.Text = "Mon -Sun 08:00 AM - 08:00 PM";
			txtTelephone.Text = " 078555370";
		}
		public void LoadKauteFamily()
		{
			txtAddress.Text = "960 Victoria Street, Hamilton";
				txtOpenHrs.Text= "Mon - Fri 09:00 AM - 05:00 PM";
			txtTelephone.Text = "078492767";

		}
		public void LoadParentline()
		{
			txtAddress.Text= "48 Palmerston Street, Hamilton";
			txtOpenHrs.Text = "Mon - Fri 09:00Am - 12:00 PM";
			txtTelephone.Text = "079032079";


		}
	}
}


