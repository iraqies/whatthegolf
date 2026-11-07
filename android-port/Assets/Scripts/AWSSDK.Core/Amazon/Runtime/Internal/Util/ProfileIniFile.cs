using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Util
{
	public class ProfileIniFile : IniFile
	{
		private const string ProfileMarker = "profile";

		public bool ProfileMarkerRequired { get; set; }

		public override HashSet<string> ListSectionNames()
		{
			return null;
		}

		public ProfileIniFile(string filePath, bool profileMarkerRequired)
			: base(null)
		{
		}

		public override bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
		{
			properties = null;
			return false;
		}
	}
}
