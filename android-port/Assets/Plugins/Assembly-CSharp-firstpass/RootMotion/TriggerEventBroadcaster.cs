using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000F0")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1323360", Offset = "0x1323360", VA = "0x1323360")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1323428", Offset = "0x1323428", VA = "0x1323428")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x13234F0", Offset = "0x13234F0", VA = "0x13234F0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x13235B8", Offset = "0x13235B8", VA = "0x13235B8")]
		public TriggerEventBroadcaster()
		{
		}
	}
}
