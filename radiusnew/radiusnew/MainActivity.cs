using System;
using System.IO;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace radiusnew
{
	[Activity (Label = "radiusnew", Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		List <Medical> myList;

		RESThandler objRest;
		ListView lstRadiusItems;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			lstRadiusItems = FindViewById <ListView> (Resource.Id.lstRadius);
			LoadRadiusPeopleWaiting ();
			lstRadiusItems.ItemClick += OnLstRadiusItemsClick;


			// Get our button from the layout resource,
			// and attach an event to it

//			CopyDatabase ();
//			objDb = new DatabaseManager();
//				lstRadiusItems.ItemClick += OnLstRadiusItemsClick;

		}
		public async void LoadRadiusPeopleWaiting()
		{
			objRest = new RESThandler (@"https://www.radiuswaikato.co.nz/xmlpub/");
			var Response = await objRest.ExecuteRequestAsync ();
			lstRadiusItems.Adapter = new DataAdapter (this, Response.Medical);
			myList = Response.Medical;

		}
//		public void CopyDatabase()
//		{
//			// Check if your DB has already been extracted.
//			//if (!File.Exists(dbPath))
//			{
//				using (BinaryReader br = new BinaryReader(Assets.Open(dbName)))
//				{
//					using (BinaryWriter bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
//					{
//						byte[] buffer = new byte[2048];
//						int len = 0;
//						while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
//						{
//							bw.Write (buffer, 0, len);
//						}
//					}
//				}
//			}
//		}
				 void OnLstRadiusItemsClick (object sender, AdapterView.ItemClickEventArgs e)
		{


			var RadiusDetail = myList[e.Position];
			var detailview = new Intent (this, typeof(DetailView));
			detailview.PutExtra ("Name", RadiusDetail.Name);

			StartActivity (detailview);
		}

	}
}


