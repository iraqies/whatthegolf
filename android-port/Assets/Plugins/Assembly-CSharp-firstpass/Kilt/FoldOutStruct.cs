using System;
using System.Xml.Serialization;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt
{
	[Serializable]
	[Token(Token = "0x2000085")]
	public abstract class FoldOutStruct
	{
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x10")]
		[XmlIgnore]
		[SerializeField]
		private bool _foldOut;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x137356C", Offset = "0x137356C", VA = "0x137356C")]
		protected FoldOutStruct()
		{
		}
	}
}
