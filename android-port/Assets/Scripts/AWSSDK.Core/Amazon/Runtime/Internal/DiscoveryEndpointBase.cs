using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200014F")]
	public abstract class DiscoveryEndpointBase
	{
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x10")]
		private DateTime _createdOn;

		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x18")]
		private string _address;

		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x20")]
		private long _cachePeriodInMinutes;

		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x28")]
		private object objectExtendLock;

		[Token(Token = "0x170002D0")]
		public string Address
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x11F2204", Offset = "0x11F2204", VA = "0x11F2204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x11F2154", Offset = "0x11F2154", VA = "0x11F2154")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002D1")]
		public long CachePeriodInMinutes
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x11F220C", Offset = "0x11F220C", VA = "0x11F220C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x11F2214", Offset = "0x11F2214", VA = "0x11F2214")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x11F208C", Offset = "0x11F208C", VA = "0x11F208C")]
		protected DiscoveryEndpointBase(string address, long cachePeriodInMinutes)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x11F221C", Offset = "0x11F221C", VA = "0x11F221C")]
		public bool HasExpired()
		{
			return default;
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x11F22C0", Offset = "0x11F22C0", VA = "0x11F22C0")]
		public void ExtendExpiration(long minutes)
		{
		}
	}
}
