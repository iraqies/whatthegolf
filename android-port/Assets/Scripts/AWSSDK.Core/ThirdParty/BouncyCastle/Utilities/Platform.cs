using System.Collections;

namespace ThirdParty.BouncyCastle.Utilities
{
	internal abstract class Platform
	{
		internal static IList CreateArrayList()
		{
			return null;
		}

		internal static IList CreateArrayList(int capacity)
		{
			return null;
		}

		internal static IList CreateArrayList(ICollection collection)
		{
			return null;
		}

		internal static IList CreateArrayList(IEnumerable collection)
		{
			return null;
		}
	}
}
