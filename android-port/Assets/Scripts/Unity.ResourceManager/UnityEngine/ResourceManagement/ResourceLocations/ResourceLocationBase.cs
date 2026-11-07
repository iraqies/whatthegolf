using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	[Token(Token = "0x2000065")]
	public class ResourceLocationBase : IResourceLocation
	{
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		private string m_Name;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		private string m_Id;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		private string m_ProviderId;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		private object m_Data;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		private int m_DependencyHashCode;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x34")]
		private int m_HashCode;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x38")]
		private Type m_Type;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x40")]
		private List<IResourceLocation> m_Dependencies;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x48")]
		private string m_PrimaryKey;

		[Token(Token = "0x17000067")]
		public string InternalId
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2A6B5F8", Offset = "0x2A6B5F8", VA = "0x2A6B5F8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public string ProviderId
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2A6B600", Offset = "0x2A6B600", VA = "0x2A6B600", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public IList<IResourceLocation> Dependencies
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2A6B608", Offset = "0x2A6B608", VA = "0x2A6B608", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public bool HasDependencies
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2A6B610", Offset = "0x2A6B610", VA = "0x2A6B610", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006B")]
		public object Data
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2A6B668", Offset = "0x2A6B668", VA = "0x2A6B668", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2A6B670", Offset = "0x2A6B670", VA = "0x2A6B670")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public string PrimaryKey
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2A6B678", Offset = "0x2A6B678", VA = "0x2A6B678", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2A6B680", Offset = "0x2A6B680", VA = "0x2A6B680")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int DependencyHashCode
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2A6B688", Offset = "0x2A6B688", VA = "0x2A6B688", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006E")]
		public Type ResourceType
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2A6B690", Offset = "0x2A6B690", VA = "0x2A6B690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2A6B698", Offset = "0x2A6B698", VA = "0x2A6B698", Slot = "7")]
		public int Hash(Type t)
		{
			return default;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2A6B6E8", Offset = "0x2A6B6E8", VA = "0x2A6B6E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2A6B6F0", Offset = "0x2A6B6F0", VA = "0x2A6B6F0")]
		public ResourceLocationBase(string name, string id, string providerId, Type t, params IResourceLocation[] dependencies)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2A6B938", Offset = "0x2A6B938", VA = "0x2A6B938")]
		public void ComputeDependencyHash()
		{
		}
	}
}
