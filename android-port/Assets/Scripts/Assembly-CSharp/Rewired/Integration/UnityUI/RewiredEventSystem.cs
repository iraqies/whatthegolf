using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Token(Token = "0x2001149")]
	public class RewiredEventSystem : EventSystem
	{
		[Token(Token = "0x4005B3D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _alwaysUpdate;

		[Token(Token = "0x17000849")]
		public bool alwaysUpdate
		{
			[Token(Token = "0x6004E2A")]
			[Address(RVA = "0x164DB50", Offset = "0x164DB50", VA = "0x164DB50")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E2B")]
			[Address(RVA = "0x164DB58", Offset = "0x164DB58", VA = "0x164DB58")]
			set
			{
			}
		}

		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x164DB60", Offset = "0x164DB60", VA = "0x164DB60", Slot = "18")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x164DD3C", Offset = "0x164DD3C", VA = "0x164DD3C")]
		public RewiredEventSystem()
		{
		}
	}
}
