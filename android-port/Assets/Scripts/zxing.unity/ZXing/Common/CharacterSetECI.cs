using System.Collections.Generic;
using System.Text;

namespace ZXing.Common
{
	public sealed class CharacterSetECI : ECI
	{
		internal static readonly IDictionary<int, CharacterSetECI> VALUE_TO_ECI;

		internal static readonly IDictionary<string, CharacterSetECI> NAME_TO_ECI;

		private readonly string encodingName;

		static CharacterSetECI()
		{
		}

		private CharacterSetECI(int value, string encodingName)
			: base(0)
		{
		}

		private static void addCharacterSet(int value, string encodingName)
		{
		}

		private static void addCharacterSet(int value, string[] encodingNames)
		{
		}

		public static CharacterSetECI getCharacterSetECIByName(string name)
		{
			return null;
		}

		public static CharacterSetECI getCharacterSetECI(Encoding encoding)
		{
			return null;
		}

		public static Encoding getEncoding(string encodingName)
		{
			return null;
		}
	}
}
