using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Serializable]
	[Token(Token = "0x2000002")]
	public class AnimationTriggers
	{
		[Token(Token = "0x4000001")]
		private const string kDefaultNormalAnimName = "Normal";

		[Token(Token = "0x4000002")]
		private const string kDefaultHighlightedAnimName = "Highlighted";

		[Token(Token = "0x4000003")]
		private const string kDefaultPressedAnimName = "Pressed";

		[Token(Token = "0x4000004")]
		private const string kDefaultSelectedAnimName = "Selected";

		[Token(Token = "0x4000005")]
		private const string kDefaultDisabledAnimName = "Disabled";

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6C38", Offset = "0x1F6C38")]
		[SerializeField]
		private string m_NormalTrigger;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6C84", Offset = "0x1F6C84")]
		[SerializeField]
		private string m_HighlightedTrigger;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6CD0", Offset = "0x1F6CD0")]
		private string m_PressedTrigger;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6D1C", Offset = "0x1F6D1C")]
		[SerializeField]
		private string m_SelectedTrigger;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F6D68", Offset = "0x1F6D68")]
		[SerializeField]
		private string m_DisabledTrigger;

		[Token(Token = "0x17000001")]
		public string normalTrigger
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2BF7214", Offset = "0x2BF7214", VA = "0x2BF7214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public string highlightedTrigger
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2BF721C", Offset = "0x2BF721C", VA = "0x2BF721C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public string pressedTrigger
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2BF7224", Offset = "0x2BF7224", VA = "0x2BF7224")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public string selectedTrigger
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2BF722C", Offset = "0x2BF722C", VA = "0x2BF722C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public string disabledTrigger
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2BF7234", Offset = "0x2BF7234", VA = "0x2BF7234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2BF723C", Offset = "0x2BF723C", VA = "0x2BF723C")]
		public AnimationTriggers()
		{
		}
	}
}
