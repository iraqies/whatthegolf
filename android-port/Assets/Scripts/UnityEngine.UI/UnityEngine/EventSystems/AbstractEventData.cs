using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x2000085")]
	public abstract class AbstractEventData
	{
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_Used;

		[Token(Token = "0x17000167")]
		public virtual bool used
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x2BF7204", Offset = "0x2BF7204", VA = "0x2BF7204", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2BF71F0", Offset = "0x2BF71F0", VA = "0x2BF71F0", Slot = "4")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2BF71F8", Offset = "0x2BF71F8", VA = "0x2BF71F8", Slot = "5")]
		public virtual void Use()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2BF720C", Offset = "0x2BF720C", VA = "0x2BF720C")]
		protected AbstractEventData()
		{
		}
	}
}
