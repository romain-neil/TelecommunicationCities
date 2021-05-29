namespace TelecommunicationCities
{
	public class Antenna
	{
		public enum Generation
		{
			G3,
			G4,
			G5,
		}

		public int GetPrice(Generation generation)
		{
			switch (generation)
			{
				case Generation.G3:
					return 5000;
				case Generation.G4:
					return 10000;
				case Generation.G5:
					return 20000;
				default:
					return 0;
			}
		}
	}
}