using ICities;

namespace TelecommunicationCities
{
	#region Mod definition
	public class TelcoCities : IUserMod
	{
		public string Name
		{
			get { return "Telecommunication Cities"; }
		}

		public string Description
		{
			get { return "Mod to add some telecommunications (xdsl, fiber, telephonic/fiber center) and some mobile stuff (3g, 4G and 5G !) "; }
		}
	}
	#endregion
}