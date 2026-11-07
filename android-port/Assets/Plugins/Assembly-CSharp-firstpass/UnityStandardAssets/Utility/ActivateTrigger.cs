using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000041")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		public enum Mode
		{
			[Token(Token = "0x40000FC")]
			Trigger = 0,
			[Token(Token = "0x40000FD")]
			Replace = 1,
			[Token(Token = "0x40000FE")]
			Activate = 2,
			[Token(Token = "0x40000FF")]
			Enable = 3,
			[Token(Token = "0x4000100")]
			Animate = 4,
			[Token(Token = "0x4000101")]
			Deactivate = 5
		}

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x20")]
		public Object target;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x12EA038", Offset = "0x12EA038", VA = "0x12EA038")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x12EA4F4", Offset = "0x12EA4F4", VA = "0x12EA4F4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x12EA4F8", Offset = "0x12EA4F8", VA = "0x12EA4F8")]
		public ActivateTrigger()
		{
		}
	}
}
