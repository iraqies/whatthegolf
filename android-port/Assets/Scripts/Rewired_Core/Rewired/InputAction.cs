using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x20000FF")]
	public sealed class InputAction
	{
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InputActionType _type;

		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _descriptiveName;

		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _positiveDescriptiveName;

		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _negativeDescriptiveName;

		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _behaviorId;

		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _userAssignable;

		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _categoryId;

		[NonSerialized]
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x50")]
		private string uJxdPoFMyIUVGOelCDviThTttvnz;

		[NonSerialized]
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x58")]
		private string gywqCDtuIMyhdXDfRAomvPXuOuKl;

		[Token(Token = "0x1700023C")]
		public int id
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x23D28AC", Offset = "0x23D28AC", VA = "0x23D28AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700023D")]
		public string name
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x23D28B4", Offset = "0x23D28B4", VA = "0x23D28B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023E")]
		public InputActionType type
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x23D28BC", Offset = "0x23D28BC", VA = "0x23D28BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700023F")]
		public string descriptiveName
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x23D28C4", Offset = "0x23D28C4", VA = "0x23D28C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000240")]
		public string positiveDescriptiveName
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x23D28CC", Offset = "0x23D28CC", VA = "0x23D28CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000241")]
		public string negativeDescriptiveName
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x23D2960", Offset = "0x23D2960", VA = "0x23D2960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		public int behaviorId
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x23D29F4", Offset = "0x23D29F4", VA = "0x23D29F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000243")]
		public int categoryId
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x23D29FC", Offset = "0x23D29FC", VA = "0x23D29FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x23D2A04", Offset = "0x23D2A04", VA = "0x23D2A04")]
		public InputAction()
		{
		}
	}
}
