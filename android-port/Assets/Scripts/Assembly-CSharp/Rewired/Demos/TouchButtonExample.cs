using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	[Token(Token = "0x2001162")]
	[Attribute(Name = "RequireComponent", RVA = "0x47D9C", Offset = "0x47D9C")]
	public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4005BE5")]
		[FieldOffset(Offset = "0x18")]
		public bool allowMouseControl;

		[Token(Token = "0x4005BE6")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x571DC", Offset = "0x571DC")]
		private bool isPressed__BackingField;

		[Token(Token = "0x1700088B")]
		public bool isPressed
		{
			[Token(Token = "0x6004F54")]
			[Address(RVA = "0x171E6C0", Offset = "0x171E6C0", VA = "0x171E6C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70088", Offset = "0x70088")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004F55")]
			[Address(RVA = "0x171E6C8", Offset = "0x171E6C8", VA = "0x171E6C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70098", Offset = "0x70098")]
			private set
			{
			}
		}

		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x171E6D0", Offset = "0x171E6D0", VA = "0x171E6D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x171E700", Offset = "0x171E700", VA = "0x171E700")]
		private void Restart()
		{
		}

		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x171E708", Offset = "0x171E708", VA = "0x171E708", Slot = "4")]
		private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x171E744", Offset = "0x171E744", VA = "0x171E744", Slot = "5")]
		private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x171E738", Offset = "0x171E738", VA = "0x171E738")]
		private static bool IsMousePointerId(int id)
		{
			return default;
		}

		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x171E770", Offset = "0x171E770", VA = "0x171E770")]
		public TouchButtonExample()
		{
		}
	}
}
