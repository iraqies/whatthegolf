using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x2000086")]
	public class BaseEventData : AbstractEventData
	{
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x18")]
		private readonly EventSystem m_EventSystem;

		[Token(Token = "0x17000168")]
		public GameObject selectedObject
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x2BF7D30", Offset = "0x2BF7D30", VA = "0x2BF7D30")]
			set
			{
			}
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2BF7D04", Offset = "0x2BF7D04", VA = "0x2BF7D04")]
		public BaseEventData(EventSystem eventSystem)
		{
		}
	}
}
