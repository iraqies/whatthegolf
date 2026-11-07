using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Serializable]
	[Token(Token = "0x200003A")]
	public struct SerializedType
	{
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7DB8", Offset = "0x1B7DB8")]
		private string m_AssemblyName;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7E04", Offset = "0x1B7E04")]
		[SerializeField]
		private string m_ClassName;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x10")]
		private Type m_CachedType;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7E50", Offset = "0x1B7E50")]
		private bool ValueChanged__BackingField;

		[Token(Token = "0x1700002E")]
		public string AssemblyName
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2A714D4", Offset = "0x2A714D4", VA = "0x2A714D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public string ClassName
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2A714DC", Offset = "0x2A714DC", VA = "0x2A714DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public Type Value
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2A6AC88", Offset = "0x2A6AC88", VA = "0x2A6AC88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2A715AC", Offset = "0x2A715AC", VA = "0x2A715AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool ValueChanged
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2A71678", Offset = "0x2A71678", VA = "0x2A71678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8484", Offset = "0x1B8484")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2A71680", Offset = "0x2A71680", VA = "0x2A71680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8494", Offset = "0x1B8494")]
			set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2A714E4", Offset = "0x2A714E4", VA = "0x2A714E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
