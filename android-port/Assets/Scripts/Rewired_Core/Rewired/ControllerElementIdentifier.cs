using System;
using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x20000E1")]
	public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal
	{
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _positiveName;

		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _negativeName;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerElementType _elementType;

		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CompoundControllerElementType _compoundElementType;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x38")]
		internal readonly bool isMappableOnPlatform;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x39")]
		private bool TxSJwJoaEWVxcucVapNSpYPnWYhO;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x0")]
		private static ControllerElementIdentifier TCiwSGTHwRAlWXdcLyuCBNCcQIzT;

		[Token(Token = "0x170001F1")]
		public int id
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x235C7D8", Offset = "0x235C7D8", VA = "0x235C7D8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001F2")]
		public string name
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x235C7E0", Offset = "0x235C7E0", VA = "0x235C7E0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x235C7E8", Offset = "0x235C7E8", VA = "0x235C7E8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public string positiveName
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x235C8B4", Offset = "0x235C8B4", VA = "0x235C8B4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x235C8BC", Offset = "0x235C8BC", VA = "0x235C8BC")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public string negativeName
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x235C924", Offset = "0x235C924", VA = "0x235C924", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x235C92C", Offset = "0x235C92C", VA = "0x235C92C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public ControllerElementType elementType
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x235C994", Offset = "0x235C994", VA = "0x235C994")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001F6")]
		internal static ControllerElementIdentifier BlankReadOnly
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x235CC84", Offset = "0x235CC84", VA = "0x235CC84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x235C99C", Offset = "0x235C99C", VA = "0x235C99C")]
		public ControllerElementIdentifier()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x235C9A4", Offset = "0x235C9A4", VA = "0x235C9A4")]
		public ControllerElementIdentifier(ControllerElementIdentifier P_0)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2357974", Offset = "0x2357974", VA = "0x2357974")]
		internal ControllerElementIdentifier(int P_0, string P_1, string P_2, string P_3, ControllerElementType P_4, CompoundControllerElementType P_5, bool P_6)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x235C9FC", Offset = "0x235C9FC", VA = "0x235C9FC")]
		internal ControllerElementIdentifier(int P_0, string P_1, string P_2, string P_3, ControllerElementType P_4, bool P_5)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x235CA64", Offset = "0x235CA64", VA = "0x235CA64")]
		internal ControllerElementIdentifier(ControllerElementIdentifier P_0, bool P_1, ControllerElementType P_2)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x235CAC8", Offset = "0x235CAC8", VA = "0x235CAC8")]
		public ControllerElementIdentifier Clone()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x235CB5C", Offset = "0x235CB5C", VA = "0x235CB5C")]
		public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x235C850", Offset = "0x235C850", VA = "0x235C850")]
		private void jkZRClFCcxCwnCTMVClsLjAEHDHAb()
		{
		}
	}
}
