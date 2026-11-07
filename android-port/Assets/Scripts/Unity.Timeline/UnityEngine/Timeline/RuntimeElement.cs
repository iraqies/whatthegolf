using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000026")]
	internal abstract class RuntimeElement : IInterval
	{
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC288", Offset = "0x1BC288")]
		private int intervalBit__BackingField;

		[Token(Token = "0x17000085")]
		public abstract long intervalStart
		{
			[Token(Token = "0x60001B9")]
			get;
		}

		[Token(Token = "0x17000086")]
		public abstract long intervalEnd
		{
			[Token(Token = "0x60001BA")]
			get;
		}

		[Token(Token = "0x17000087")]
		public int intervalBit
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2AEAFAC", Offset = "0x2AEAFAC", VA = "0x2AEAFAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC540", Offset = "0x1BC540")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2AEAFB4", Offset = "0x2AEAFB4", VA = "0x2AEAFB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC550", Offset = "0x1BC550")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public abstract bool enable
		{
			[Token(Token = "0x60001BD")]
			set;
		}

		[Token(Token = "0x60001BE")]
		public abstract void EvaluateAt(double localTime, FrameData frameData);

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2AEAFBC", Offset = "0x2AEAFBC", VA = "0x2AEAFBC", Slot = "10")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2AE7E60", Offset = "0x2AE7E60", VA = "0x2AE7E60")]
		protected RuntimeElement()
		{
		}
	}
}
