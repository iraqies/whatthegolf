using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	[Token(Token = "0x200116B")]
	[Attribute(Name = "RequireComponent", RVA = "0x47EE4", Offset = "0x47EE4")]
	public sealed class UIPointer : UIBehaviour
	{
		[Token(Token = "0x4005C1D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _hideHardwarePointer;

		[Token(Token = "0x4005C1E")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _autoSort;

		[Token(Token = "0x4005C1F")]
		[FieldOffset(Offset = "0x20")]
		private Canvas _canvas;

		[Token(Token = "0x1700088E")]
		public bool autoSort
		{
			[Token(Token = "0x6004F99")]
			[Address(RVA = "0x1737F04", Offset = "0x1737F04", VA = "0x1737F04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004F9A")]
			[Address(RVA = "0x1737F0C", Offset = "0x1737F0C", VA = "0x1737F0C")]
			set
			{
			}
		}

		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x1737F4C", Offset = "0x1737F4C", VA = "0x1737F4C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x173810C", Offset = "0x173810C", VA = "0x173810C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x17381A0", Offset = "0x17381A0", VA = "0x17381A0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x1738218", Offset = "0x1738218", VA = "0x1738218", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		[Token(Token = "0x6004F9F")]
		[Address(RVA = "0x1738290", Offset = "0x1738290", VA = "0x1738290")]
		public void OnScreenPositionChanged(Vector2 screenPosition)
		{
		}

		[Token(Token = "0x6004FA0")]
		[Address(RVA = "0x173809C", Offset = "0x173809C", VA = "0x173809C")]
		private void GetDependencies()
		{
		}

		[Token(Token = "0x6004FA1")]
		[Address(RVA = "0x173843C", Offset = "0x173843C", VA = "0x173843C")]
		public UIPointer()
		{
		}
	}
}
