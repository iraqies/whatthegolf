using System;
using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x20000E2")]
	public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
	{
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _positiveName;

		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _negativeName;

		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerTemplateElementType _elementType;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x34")]
		internal readonly bool isMappableOnPlatform;

		[Token(Token = "0x170001F7")]
		public int id
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x236D7F0", Offset = "0x236D7F0", VA = "0x236D7F0", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001F8")]
		public string name
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x236D7F8", Offset = "0x236D7F8", VA = "0x236D7F8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F9")]
		public string positiveName
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x236D800", Offset = "0x236D800", VA = "0x236D800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FA")]
		public string negativeName
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x236D808", Offset = "0x236D808", VA = "0x236D808", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FB")]
		public ControllerTemplateElementType elementType
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x236D810", Offset = "0x236D810", VA = "0x236D810", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x236D818", Offset = "0x236D818", VA = "0x236D818")]
		public ControllerTemplateElementIdentifier()
		{
		}
	}
}
