using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000900")]
public class ScrollableButton : Button, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000901")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x41ED8", Offset = "0x41ED8")]
	private struct _003COnPointerUp_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4003112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScrollableButton _003C_003E4__this;

		[Token(Token = "0x4003115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PointerEventData eventData;

		[Token(Token = "0x4003116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x600299B")]
		[Address(RVA = "0x183F91C", Offset = "0x183F91C", VA = "0x183F91C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600299C")]
		[Address(RVA = "0x183FBB8", Offset = "0x183FBB8", VA = "0x183FBB8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4003110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ScrollRect _scrollGameObject;

	[Token(Token = "0x4003111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool _canClick;

	[Token(Token = "0x6002992")]
	[Address(RVA = "0x1680020", Offset = "0x1680020", VA = "0x1680020")]
	public void Init(ScrollRect scrollGameObject)
	{
	}

	[Token(Token = "0x6002993")]
	[Address(RVA = "0x1680028", Offset = "0x1680028", VA = "0x1680028", Slot = "41")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002994")]
	[Address(RVA = "0x1680040", Offset = "0x1680040", VA = "0x1680040", Slot = "42")]
	public override void OnSubmit(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6002995")]
	[Address(RVA = "0x1680058", Offset = "0x1680058", VA = "0x1680058", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002996")]
	[Address(RVA = "0x16800F4", Offset = "0x16800F4", VA = "0x16800F4", Slot = "43")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002997")]
	[Address(RVA = "0x168011C", Offset = "0x168011C", VA = "0x168011C", Slot = "44")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002998")]
	[Address(RVA = "0x1680140", Offset = "0x1680140", VA = "0x1680140", Slot = "45")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002999")]
	[Address(RVA = "0x1680164", Offset = "0x1680164", VA = "0x1680164")]
	public ScrollableButton()
	{
	}

	[Token(Token = "0x600299A")]
	[Address(RVA = "0x1680174", Offset = "0x1680174", VA = "0x1680174")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x675E8", Offset = "0x675E8")]
	[DebuggerHidden]
	private void _003C_003En__0(PointerEventData eventData)
	{
	}
}
