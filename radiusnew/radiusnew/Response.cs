
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace radiusnew
{ 
	[XmlRoot(ElementName="medical")]
	public class Medical {
		[XmlElement(ElementName="name")]
		public string Name { get; set; }
		[XmlElement(ElementName="people")]
		public string People { get; set; }
		[XmlElement(ElementName="time")]
		public string Time { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName="radius")]
	public class Radius {
		[XmlElement(ElementName="medical")]
		public List<Medical> Medical { get; set; }
		[XmlElement(ElementName="Time")]
		public string Time { get; set; }
	}
}

