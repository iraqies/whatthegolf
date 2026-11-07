using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Token(Token = "0x2000004")]
	public class ConfigurableAddress : GuidScriptableObject
	{
		[Token(Token = "0x2000005")]
		public enum EType
		{
			[Token(Token = "0x400000D")]
			OBJECT = 0,
			[Token(Token = "0x400000E")]
			STRING = 1,
			[Token(Token = "0x400000F")]
			INT = 2,
			[Token(Token = "0x4000010")]
			FLOAT = 3,
			[Token(Token = "0x4000011")]
			BOOL = 4
		}

		[Token(Token = "0x4000008")]
		internal const string UNKNOWN_TYPE = "[Any Type]";

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _customAddress;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EType _type;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _objectType;

		[Token(Token = "0x17000004")]
		internal EType valueType
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x29F75EC", Offset = "0x29F75EC", VA = "0x29F75EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000005")]
		internal string objectValueType
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x29F75F4", Offset = "0x29F75F4", VA = "0x29F75F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public string address
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x29F75FC", Offset = "0x29F75FC", VA = "0x29F75FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x29F7638", Offset = "0x29F7638", VA = "0x29F7638")]
		public ConfigurableAddress()
		{
		}
	}
}
