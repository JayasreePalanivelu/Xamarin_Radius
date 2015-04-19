
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
using Android.Gms.Maps;
using Android.Support.V4.App;

namespace radiusnew
{
	[Activity (Label = "googlemap_radius",MainLauncher = true)]			
	public class googlemap_radius : FragmentActivity, IOnMapReadyCallback
	{
		private GoogleMap mMap;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.googlemapradius);
			SetUpMap ();
			// Create your application here
		}
		private void SetUpMap()
		{
			if (mMap == null) {
				FragmentManager.FindFragmentById<MapFragment> (Resource.Id.map).GetMapAsync(this);
			}
		}
		public void OnMapReady(GoogleMap googleMap)
		{
			mMap = googleMap;
		}

	}
}

