using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000AF")]
	public static class RaycasterManager
	{
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<BaseRaycaster> s_Raycasters;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2C2EE74", Offset = "0x2C2EE74", VA = "0x2C2EE74")]
		internal static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2C2EF64", Offset = "0x2C2EF64", VA = "0x2C2EF64")]
		public static List<BaseRaycaster> GetRaycasters()
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x2C2EFC8", Offset = "0x2C2EFC8", VA = "0x2C2EFC8")]
		internal static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
		}
	}
}
