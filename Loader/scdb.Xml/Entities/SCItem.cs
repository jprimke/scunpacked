using System.Xml.Serialization;

namespace Loader.SCDb.Xml.Entities
{
	public class SCItem
	{
		[XmlAttribute]
		public string attachToTileItemPort;

		[XmlAttribute]
		public bool inheritModelTagFromHost;

		public SItemPortCoreParams[] ItemPorts;

		[XmlAttribute]
		public string placeInteraction;

		[XmlAttribute]
		public bool turnedOnByDefault;

		[XmlAttribute]
		public string turnOffInteraction;

		[XmlAttribute]
		public string turnOnInteraction;
	}
}
