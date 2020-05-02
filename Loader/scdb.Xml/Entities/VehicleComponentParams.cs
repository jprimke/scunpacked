using System.Xml.Serialization;

namespace Loader.SCDb.Xml.Entities
{
	public class VehicleComponentParams
	{
		[XmlAttribute]
		public int crewSize;

		[XmlAttribute]
		public int dogfightEnabled;

		[XmlAttribute]
		public double emergencyStatusDamageThreshold;

		[XmlAttribute]
		public double incomingDamageModifierToAI;

		[XmlAttribute]
		public bool isGravlevVehicle;

		[XmlAttribute]
		public string landingSystem;

		[XmlAttribute]
		public string manufacturer;

		[XmlAttribute]
		public string modification;

		[XmlAttribute]
		public int unmovable;

		[XmlAttribute]
		public string vehicleCareer;

		[XmlAttribute]
		public string vehicleCareerRef;

		[XmlAttribute]
		public string vehicleDefinition;

		[XmlAttribute]
		public string vehicleDescription;

		[XmlAttribute]
		public string vehicleName;

		[XmlAttribute]
		public string vehicleRole;

		[XmlAttribute]
		public string vehicleRoleRef;
	}
}
