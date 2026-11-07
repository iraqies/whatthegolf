using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	[Token(Token = "0x2000006")]
	public class ConfigurableValue
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _stringValue;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _intValue;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _floatValue;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _boolValue;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEngine.Object _objectValue;

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x29F7640", Offset = "0x29F7640", VA = "0x29F7640")]
		public ConfigurableValue()
		{
		}
	}
}
