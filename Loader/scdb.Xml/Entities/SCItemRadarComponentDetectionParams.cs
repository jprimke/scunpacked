using System.Xml.Serialization;

namespace Loader.SCDb.Xml.Entities
{
	public class SCItemRadarComponentDetectionParams
	{
		[XmlAttribute]
		public bool detectable;

		[XmlAttribute]
		public double liveDetectionRange;

		[XmlAttribute]
		public double partialDetectionRange;

		[XmlAttribute]
		public double signatureBoostMultiplier;

		[XmlAttribute]
		public double timeoutRangeMultiplier;
	}
}
