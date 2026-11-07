using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x2000298")]
	[DisallowMultipleComponent]
	public class LocalClock : Clock
	{
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x68")]
		protected Timeline timeline;

		[Token(Token = "0x600112E")]
		[Address(RVA = "0x13A8994", Offset = "0x13A8994", VA = "0x13A8994", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600112F")]
		[Address(RVA = "0x13A89C4", Offset = "0x13A89C4", VA = "0x13A89C4", Slot = "10")]
		public virtual void CacheComponents()
		{
		}

		[Token(Token = "0x6001130")]
		[Address(RVA = "0x13A8AD0", Offset = "0x13A8AD0", VA = "0x13A8AD0")]
		public LocalClock()
		{
		}
	}
}
