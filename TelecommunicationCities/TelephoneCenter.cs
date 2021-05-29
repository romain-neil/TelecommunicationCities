namespace TelecommunicationCities
{
	public class TelephoneCenter
	{

		public enum BuildingType
		{
			Copper,
			Fiber
		}

		public int GetPrice(BuildingType buildingType)
		{
			switch (buildingType)
			{
				case BuildingType.Copper:
					return 2000;
				case BuildingType.Fiber:
					return 1000;
				default:
					return 0;
			}
		}
		
	}
}