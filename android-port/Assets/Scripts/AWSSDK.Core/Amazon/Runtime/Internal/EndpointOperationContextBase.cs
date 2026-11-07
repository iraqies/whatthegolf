using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000156")]
	public abstract class EndpointOperationContextBase
	{
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x10")]
		private string _customerCredentials;

		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x18")]
		private string _operationName;

		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x20")]
		private EndpointDiscoveryDataBase _endpointDiscoveryData;

		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x28")]
		private bool _evictCacheKey;

		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x30")]
		private Uri _evictUri;

		[Token(Token = "0x170002D5")]
		public virtual string CustomerCredentials
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x11FE0EC", Offset = "0x11FE0EC", VA = "0x11FE0EC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x11FE0F4", Offset = "0x11FE0F4", VA = "0x11FE0F4", Slot = "5")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002D6")]
		public virtual string OperationName
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x11FE0FC", Offset = "0x11FE0FC", VA = "0x11FE0FC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x11FE104", Offset = "0x11FE104", VA = "0x11FE104", Slot = "7")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002D7")]
		public virtual EndpointDiscoveryDataBase EndpointDiscoveryData
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x11FE10C", Offset = "0x11FE10C", VA = "0x11FE10C", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x11FE114", Offset = "0x11FE114", VA = "0x11FE114", Slot = "9")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002D8")]
		public virtual bool EvictCacheKey
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x11FE11C", Offset = "0x11FE11C", VA = "0x11FE11C", Slot = "10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x11FE124", Offset = "0x11FE124", VA = "0x11FE124", Slot = "11")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002D9")]
		public virtual Uri EvictUri
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x11FE12C", Offset = "0x11FE12C", VA = "0x11FE12C", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x11FE134", Offset = "0x11FE134", VA = "0x11FE134", Slot = "13")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x11FE03C", Offset = "0x11FE03C", VA = "0x11FE03C")]
		protected EndpointOperationContextBase(string customerCredentials, string operationName, EndpointDiscoveryDataBase endpointDiscoveryData, bool evictCacheKey, Uri evictUri)
		{
		}
	}
}
