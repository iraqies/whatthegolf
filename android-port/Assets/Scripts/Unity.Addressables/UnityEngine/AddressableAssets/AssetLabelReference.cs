using System;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	[Token(Token = "0x2000031")]
	public class AssetLabelReference : IKeyEvaluator
	{
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B12CC", Offset = "0x1B12CC")]
		[SerializeField]
		private string m_LabelString;

		[Token(Token = "0x1700002B")]
		public string labelString
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2A27C8C", Offset = "0x2A27C8C", VA = "0x2A27C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2A27C94", Offset = "0x2A27C94", VA = "0x2A27C94")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public object RuntimeKey
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2A27C9C", Offset = "0x2A27C9C", VA = "0x2A27C9C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2A27CFC", Offset = "0x2A27CFC", VA = "0x2A27CFC", Slot = "5")]
		public bool RuntimeKeyIsValid()
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2A27D8C", Offset = "0x2A27D8C", VA = "0x2A27D8C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2A27DAC", Offset = "0x2A27DAC", VA = "0x2A27DAC")]
		public AssetLabelReference()
		{
		}
	}
}
