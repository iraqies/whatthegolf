using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Serializable]
	[Token(Token = "0x2000053")]
	public class ResourceLocationData
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B162C", Offset = "0x1B162C")]
		[SerializeField]
		private string[] m_Keys;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1678", Offset = "0x1B1678")]
		[SerializeField]
		private string m_InternalId;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B16C4", Offset = "0x1B16C4")]
		[SerializeField]
		private string m_Provider;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1710", Offset = "0x1B1710")]
		[SerializeField]
		private string[] m_Dependencies;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SerializedType m_ResourceType;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private byte[] SerializedData;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private object _Data;

		[Token(Token = "0x17000053")]
		public string[] Keys
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x2A36C48", Offset = "0x2A36C48", VA = "0x2A36C48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public string InternalId
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x2A36C50", Offset = "0x2A36C50", VA = "0x2A36C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public string Provider
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2A36C58", Offset = "0x2A36C58", VA = "0x2A36C58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public string[] Dependencies
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x2A36C60", Offset = "0x2A36C60", VA = "0x2A36C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public Type ResourceType
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2A36C68", Offset = "0x2A36C68", VA = "0x2A36C68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public object Data
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2A31698", Offset = "0x2A31698", VA = "0x2A31698")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2A36C74", Offset = "0x2A36C74", VA = "0x2A36C74")]
			set
			{
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2A376A8", Offset = "0x2A376A8", VA = "0x2A376A8")]
		public ResourceLocationData(string[] keys, string id, Type provider, Type t, [Optional] string[] dependencies)
		{
		}
	}
}
