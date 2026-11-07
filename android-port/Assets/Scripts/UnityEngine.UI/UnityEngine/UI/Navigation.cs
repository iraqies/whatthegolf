using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Serializable]
	[Token(Token = "0x200004E")]
	public struct Navigation : IEquatable<Navigation>
	{
		[Token(Token = "0x200004F")]
		[Flags]
		public enum Mode
		{
			[Token(Token = "0x400017E")]
			None = 0,
			[Token(Token = "0x400017F")]
			Horizontal = 1,
			[Token(Token = "0x4000180")]
			Vertical = 2,
			[Token(Token = "0x4000181")]
			Automatic = Horizontal | Vertical,
			[Token(Token = "0x4000182")]
			Explicit = 4
		}

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Mode m_Mode;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private bool m_WrapAround;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Selectable m_SelectOnUp;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Selectable m_SelectOnDown;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Selectable m_SelectOnLeft;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Selectable m_SelectOnRight;

		[Token(Token = "0x170000D8")]
		public Mode mode
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2C2AAC0", Offset = "0x2C2AAC0", VA = "0x2C2AAC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2C2AAC8", Offset = "0x2C2AAC8", VA = "0x2C2AAC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool wrapAround
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2C2AAD0", Offset = "0x2C2AAD0", VA = "0x2C2AAD0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DA")]
		public Selectable selectOnUp
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2C2AAD8", Offset = "0x2C2AAD8", VA = "0x2C2AAD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2C2AAE0", Offset = "0x2C2AAE0", VA = "0x2C2AAE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public Selectable selectOnDown
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2C2AAE8", Offset = "0x2C2AAE8", VA = "0x2C2AAE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2C2AAF0", Offset = "0x2C2AAF0", VA = "0x2C2AAF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public Selectable selectOnLeft
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2C2AAF8", Offset = "0x2C2AAF8", VA = "0x2C2AAF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2C2AB00", Offset = "0x2C2AB00", VA = "0x2C2AB00")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public Selectable selectOnRight
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2C2AB08", Offset = "0x2C2AB08", VA = "0x2C2AB08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x2C2AB10", Offset = "0x2C2AB10", VA = "0x2C2AB10")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public static Navigation defaultNavigation
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2C2AB18", Offset = "0x2C2AB18", VA = "0x2C2AB18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2C2AB38", Offset = "0x2C2AB38", VA = "0x2C2AB38", Slot = "4")]
		public bool Equals(Navigation other)
		{
			return default;
		}
	}
}
