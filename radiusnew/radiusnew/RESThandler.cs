using System;
using RestSharp;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace radiusnew
{
	public class RESThandler
	{
		private string url;
		private IRestResponse Response;
		public RESThandler ()
		{
			url = "";
		}
		public RESThandler (string lurl)
		{
			url = lurl;
		}
		public Radius ExecuteRequest()
		{
			var client = new RestClient (url);
			var request = new RestRequest ();

			Response = client.Execute (request);
			XmlSerializer serializer = new XmlSerializer (typeof(Radius));
			Radius objRss;
			TextReader sr = new StringReader (Response.Content);
			objRss = (Radius)serializer.Deserialize (sr);
			return objRss;
		}
		public async Task<Radius> ExecuteRequestAsync()
		{
			var client = new RestClient (url);
			var request = new RestRequest ();

			Response = await client.ExecuteTaskAsync (request);
			XmlSerializer serializer = new XmlSerializer (typeof(Radius));
			Radius objRss;
			TextReader sr = new StringReader (Response.Content);
			objRss = (Radius)serializer.Deserialize (sr);
			return objRss;
		}
	}
}

