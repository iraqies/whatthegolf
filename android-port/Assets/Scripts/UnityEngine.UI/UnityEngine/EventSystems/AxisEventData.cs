using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x2000084")]
	public class AxisEventData : BaseEventData
	{
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F841C", Offset = "0x1F841C")]
		private Vector2 moveVector__BackingField;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F842C", Offset = "0x1F842C")]
		private MoveDirection moveDir__BackingField;

		[Token(Token = "0x17000165")]
		public Vector2 moveVector
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x2BF7CAC", Offset = "0x2BF7CAC", VA = "0x2BF7CAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B04", Offset = "0x1F8B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public MoveDirection moveDir
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x2BF7CB4", Offset = "0x2BF7CB4", VA = "0x2BF7CB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B14", Offset = "0x1F8B14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2BF7CBC", Offset = "0x2BF7CBC", VA = "0x2BF7CBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8B24", Offset = "0x1F8B24")]
			set
			{
			}
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2BF7CC4", Offset = "0x2BF7CC4", VA = "0x2BF7CC4")]
		public AxisEventData(EventSystem eventSystem)
		{
		}
	}
}
