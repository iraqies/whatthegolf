using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001080")]
	public class HubPlatformSection : MonoBehaviour
	{
		[Token(Token = "0x40056D8")]
		[FieldOffset(Offset = "0x18")]
		public string pack;

		[Token(Token = "0x40056D9")]
		[FieldOffset(Offset = "0x20")]
		public bool disableIfPackIsIncluded;

		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x14DE50C", Offset = "0x14DE50C", VA = "0x14DE50C")]
		public HubPlatformSection()
		{
		}
	}
}
