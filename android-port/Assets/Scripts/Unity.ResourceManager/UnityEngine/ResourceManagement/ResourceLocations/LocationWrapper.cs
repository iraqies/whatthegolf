using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	[Token(Token = "0x2000066")]
	internal class LocationWrapper : IResourceLocation
	{
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x10")]
		private IResourceLocation m_InternalLocation;

		[Token(Token = "0x1700006F")]
		public string InternalId
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2A69F48", Offset = "0x2A69F48", VA = "0x2A69F48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public string ProviderId
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2A69FFC", Offset = "0x2A69FFC", VA = "0x2A69FFC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public IList<IResourceLocation> Dependencies
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x2A6A0B4", Offset = "0x2A6A0B4", VA = "0x2A6A0B4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public int DependencyHashCode
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2A6A16C", Offset = "0x2A6A16C", VA = "0x2A6A16C", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000073")]
		public bool HasDependencies
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2A6A224", Offset = "0x2A6A224", VA = "0x2A6A224", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000074")]
		public object Data
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2A6A2DC", Offset = "0x2A6A2DC", VA = "0x2A6A2DC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public string PrimaryKey
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2A6A394", Offset = "0x2A6A394", VA = "0x2A6A394", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public Type ResourceType
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2A6A44C", Offset = "0x2A6A44C", VA = "0x2A6A44C", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2A66098", Offset = "0x2A66098", VA = "0x2A66098")]
		public LocationWrapper(IResourceLocation location)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2A6A504", Offset = "0x2A6A504", VA = "0x2A6A504", Slot = "7")]
		public int Hash(Type resultType)
		{
			return default;
		}
	}
}
