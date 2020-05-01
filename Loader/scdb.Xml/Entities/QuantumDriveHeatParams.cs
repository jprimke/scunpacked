using System.Xml.Serialization;

namespace Loader.SCDb.Xml.Entities
{
	public class QuantumDriveHeatParams
	{
		[XmlAttribute]
		public double preRampUpThermalEnergyDraw;

		[XmlAttribute]
		public double rampUpThermalEnergyDraw;

		[XmlAttribute]
		public double inFlightThermalEnergyDraw;

		[XmlAttribute]
		public double rampDownThermalEnergyDraw;

		[XmlAttribute]
		public double postRampDownThermalEnergyDraw;
	}
}