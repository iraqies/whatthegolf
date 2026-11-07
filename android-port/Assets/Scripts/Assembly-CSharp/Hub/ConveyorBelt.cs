using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001090")]
	public class ConveyorBelt : MonoBehaviour
	{
		[Token(Token = "0x4005716")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isInHub;

		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x18BA410", Offset = "0x18BA410", VA = "0x18BA410")]
		public void OnTriggerExit2D(Collider2D collision)
		{
		}

		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x18BA48C", Offset = "0x18BA48C", VA = "0x18BA48C")]
		public ConveyorBelt()
		{
		}
	}
}
