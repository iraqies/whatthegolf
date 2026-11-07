using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002AC")]
	[DisallowMultipleComponent]
	public class TimelineChild : TimelineEffector
	{
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37440", Offset = "0x37440")]
		private Timeline parent__BackingField;

		[Token(Token = "0x17000232")]
		public Timeline parent
		{
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x13207E4", Offset = "0x13207E4", VA = "0x13207E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B9BC", Offset = "0x3B9BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x13207EC", Offset = "0x13207EC", VA = "0x13207EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B9CC", Offset = "0x3B9CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000233")]
		protected override Timeline timeline
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x13207F4", Offset = "0x13207F4", VA = "0x13207F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x13207FC", Offset = "0x13207FC", VA = "0x13207FC", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x1320828", Offset = "0x1320828", VA = "0x1320828")]
		public void CacheParent()
		{
		}

		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x13209AC", Offset = "0x13209AC", VA = "0x13209AC")]
		public TimelineChild()
		{
		}
	}
}
