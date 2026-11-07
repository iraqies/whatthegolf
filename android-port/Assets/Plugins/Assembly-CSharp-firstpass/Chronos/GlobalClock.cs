using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x2000297")]
	public class GlobalClock : Clock
	{
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x68")]
		protected HashSet<Clock> clocks;

		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x70")]
		protected HashSet<Timeline> timelines;

		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _key;

		[Token(Token = "0x17000213")]
		public string key
		{
			[Token(Token = "0x6001128")]
			[Address(RVA = "0x1377E44", Offset = "0x1377E44", VA = "0x1377E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001129")]
			[Address(RVA = "0x1377E4C", Offset = "0x1377E4C", VA = "0x1377E4C")]
			internal set
			{
			}
		}

		[Token(Token = "0x6001127")]
		[Address(RVA = "0x1377D78", Offset = "0x1377D78", VA = "0x1377D78")]
		public GlobalClock()
		{
		}

		[Token(Token = "0x600112A")]
		[Address(RVA = "0x1377E54", Offset = "0x1377E54", VA = "0x1377E54", Slot = "10")]
		internal virtual void Register(Timeline timeline)
		{
		}

		[Token(Token = "0x600112B")]
		[Address(RVA = "0x1377F40", Offset = "0x1377F40", VA = "0x1377F40", Slot = "11")]
		internal virtual void Unregister(Timeline timeline)
		{
		}

		[Token(Token = "0x600112C")]
		[Address(RVA = "0x137802C", Offset = "0x137802C", VA = "0x137802C", Slot = "12")]
		internal virtual void Register(Clock clock)
		{
		}

		[Token(Token = "0x600112D")]
		[Address(RVA = "0x1378118", Offset = "0x1378118", VA = "0x1378118", Slot = "13")]
		internal virtual void Unregister(Clock clock)
		{
		}
	}
}
