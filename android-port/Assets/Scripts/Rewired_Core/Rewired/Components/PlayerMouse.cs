using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	[Token(Token = "0x20002C7")]
	public sealed class PlayerMouse : PlayerController, IPlayerController, IMouseInputSource
	{
		[Serializable]
		[Token(Token = "0x20002C8")]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2>
		{
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x238E350", Offset = "0x238E350", VA = "0x238E350")]
			public ScreenPositionChangedHandler()
			{
			}
		}

		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _defaultToCenter;

		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _pointerSpeed;

		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useHardwarePointerPosition;

		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _clampToMovementArea;

		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Rect _movementArea;

		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Rewired.PlayerMouse.MovementAreaUnit _movementAreaUnit;

		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScreenPositionChangedHandler _onScreenPositionChanged;

		[Token(Token = "0x17000579")]
		private new Rewired.PlayerMouse rmMLNGpqXVBSkkjZadentyrvdrgtA
		{
			[Token(Token = "0x6001438")]
			[Address(RVA = "0x23FB770", Offset = "0x23FB770", VA = "0x23FB770")]
			get
			{
				return MVmNVaAnZpWvkMHvvuWxKjqAiYHg();
			}
		}

		[Token(Token = "0x1700057A")]
		public bool defaultToCenter
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x23FB7E0", Offset = "0x23FB7E0", VA = "0x23FB7E0", Slot = "54")]
			get
			{
				return default;
			}
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x23FB890", Offset = "0x23FB890", VA = "0x23FB890")]
			set
			{
			}
		}

		[Token(Token = "0x1700057B")]
		public bool clampToMovementArea
		{
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x23FB9A8", Offset = "0x23FB9A8", VA = "0x23FB9A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x23FBA50", Offset = "0x23FBA50", VA = "0x23FBA50")]
			set
			{
			}
		}

		[Token(Token = "0x1700057C")]
		public ScreenRect movementArea
		{
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x23FBB5C", Offset = "0x23FBB5C", VA = "0x23FBB5C", Slot = "55")]
			get
			{
				return default;
			}
			[Token(Token = "0x600143E")]
			[Address(RVA = "0x23FBC60", Offset = "0x23FBC60", VA = "0x23FBC60", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x1700057D")]
		public Rewired.PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x23FBF00", Offset = "0x23FBF00", VA = "0x23FBF00", Slot = "57")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x23FBFB0", Offset = "0x23FBFB0", VA = "0x23FBFB0", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700057E")]
		public Vector2 screenPosition
		{
			[Token(Token = "0x6001441")]
			[Address(RVA = "0x23FC0C8", Offset = "0x23FC0C8", VA = "0x23FC0C8", Slot = "59")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001442")]
			[Address(RVA = "0x23FC178", Offset = "0x23FC178", VA = "0x23FC178")]
			set
			{
			}
		}

		[Token(Token = "0x1700057F")]
		public Vector2 screenPositionPrev
		{
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x23FC264", Offset = "0x23FC264", VA = "0x23FC264", Slot = "60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000580")]
		public Vector2 screenPositionDelta
		{
			[Token(Token = "0x6001444")]
			[Address(RVA = "0x23FC314", Offset = "0x23FC314", VA = "0x23FC314", Slot = "61")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000581")]
		public Rewired.PlayerController.MouseAxis xAxis
		{
			[Token(Token = "0x6001445")]
			[Address(RVA = "0x23FC3C4", Offset = "0x23FC3C4", VA = "0x23FC3C4", Slot = "62")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000582")]
		public Rewired.PlayerController.MouseAxis yAxis
		{
			[Token(Token = "0x6001446")]
			[Address(RVA = "0x23FC478", Offset = "0x23FC478", VA = "0x23FC478", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000583")]
		public Rewired.PlayerController.MouseWheel wheel
		{
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x23FC52C", Offset = "0x23FC52C", VA = "0x23FC52C", Slot = "64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000584")]
		public Rewired.PlayerController.Button leftButton
		{
			[Token(Token = "0x6001448")]
			[Address(RVA = "0x23FC5E0", Offset = "0x23FC5E0", VA = "0x23FC5E0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000585")]
		public Rewired.PlayerController.Button rightButton
		{
			[Token(Token = "0x6001449")]
			[Address(RVA = "0x23FC694", Offset = "0x23FC694", VA = "0x23FC694", Slot = "66")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000586")]
		public Rewired.PlayerController.Button middleButton
		{
			[Token(Token = "0x600144A")]
			[Address(RVA = "0x23FC748", Offset = "0x23FC748", VA = "0x23FC748", Slot = "67")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000587")]
		public float pointerSpeed
		{
			[Token(Token = "0x600144B")]
			[Address(RVA = "0x23FC7FC", Offset = "0x23FC7FC", VA = "0x23FC7FC", Slot = "68")]
			get
			{
				return default;
			}
			[Token(Token = "0x600144C")]
			[Address(RVA = "0x23FC8AC", Offset = "0x23FC8AC", VA = "0x23FC8AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000588")]
		public bool useHardwarePointerPosition
		{
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x23FC9D4", Offset = "0x23FC9D4", VA = "0x23FC9D4", Slot = "69")]
			get
			{
				return default;
			}
			[Token(Token = "0x600144E")]
			[Address(RVA = "0x23FCA84", Offset = "0x23FCA84", VA = "0x23FCA84")]
			set
			{
			}
		}

		[Token(Token = "0x17000589")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
		{
			[Token(Token = "0x6001459")]
			[Address(RVA = "0x23FDE54", Offset = "0x23FDE54", VA = "0x23FDE54", Slot = "45")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_enabled();
			}
		}

		[Token(Token = "0x1700058A")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
		{
			[Token(Token = "0x600145D")]
			[Address(RVA = "0x23FE350", Offset = "0x23FE350", VA = "0x23FE350", Slot = "51")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_screenPosition();
			}
		}

		[Token(Token = "0x1700058B")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x23FE47C", Offset = "0x23FE47C", VA = "0x23FE47C", Slot = "52")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_screenPositionDelta();
			}
		}

		[Token(Token = "0x1700058C")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
		{
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x23FE5A8", Offset = "0x23FE5A8", VA = "0x23FE5A8", Slot = "53")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_wheelDelta();
			}
		}

		[Token(Token = "0x1700058D")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x23FE6D4", Offset = "0x23FE6D4", VA = "0x23FE6D4", Slot = "46")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_locked();
			}
		}

		[Token(Token = "0x14000025")]
		public event Action<Vector2> ScreenPositionChangedEvent
		{
			[Token(Token = "0x600144F")]
			[Address(RVA = "0x23FCB4C", Offset = "0x23FCB4C", VA = "0x23FCB4C", Slot = "70")]
			add
			{
			}
			[Token(Token = "0x6001450")]
			[Address(RVA = "0x23FCC10", Offset = "0x23FCC10", VA = "0x23FCC10", Slot = "71")]
			remove
			{
			}
		}

		[Token(Token = "0x6001438")]
		[Address(RVA = "0x23FB770", Offset = "0x23FB770", VA = "0x23FB770")]
		private Rewired.PlayerMouse MVmNVaAnZpWvkMHvvuWxKjqAiYHg()
		{
			return null;
		}

		[Token(Token = "0x6001451")]
		[Address(RVA = "0x23FCD1C", Offset = "0x23FCD1C", VA = "0x23FCD1C", Slot = "11")]
		protected override void OnValidated()
		{
		}

		[Token(Token = "0x6001452")]
		[Address(RVA = "0x23FCDD8", Offset = "0x23FCDD8", VA = "0x23FCDD8", Slot = "10")]
		protected override void OnReset()
		{
		}

		[Token(Token = "0x6001453")]
		[Address(RVA = "0x23FCE90", Offset = "0x23FCE90", VA = "0x23FCE90", Slot = "14")]
		protected override Rewired.PlayerController CreateSource(object args)
		{
			return null;
		}

		[Token(Token = "0x6001454")]
		[Address(RVA = "0x23FD454", Offset = "0x23FD454", VA = "0x23FD454", Slot = "17")]
		protected override void Deinitialize()
		{
		}

		[Token(Token = "0x6001455")]
		[Address(RVA = "0x23FD4AC", Offset = "0x23FD4AC", VA = "0x23FD4AC", Slot = "18")]
		protected override void Subscribe()
		{
		}

		[Token(Token = "0x6001456")]
		[Address(RVA = "0x23FD5F8", Offset = "0x23FD5F8", VA = "0x23FD5F8", Slot = "19")]
		protected override void Unsubscribe()
		{
		}

		[Token(Token = "0x6001457")]
		[Address(RVA = "0x23FD780", Offset = "0x23FD780", VA = "0x23FD780", Slot = "43")]
		internal override List<ElementInfo> JSZQIzdJrIgpNZMUgvzpsvgYGBNt()
		{
			return null;
		}

		[Token(Token = "0x6001458")]
		[Address(RVA = "0x23FDCA4", Offset = "0x23FDCA4", VA = "0x23FDCA4")]
		private void ANgikIdwhGPHaecgsDERWPOVuXJs(Vector2 P_0)
		{
		}

		[Token(Token = "0x6001459")]
		[Address(RVA = "0x23FDE54", Offset = "0x23FDE54", VA = "0x23FDE54", Slot = "45")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eget_enabled()
		{
			return default;
		}

		[Token(Token = "0x600145A")]
		[Address(RVA = "0x23FDF84", Offset = "0x23FDF84", VA = "0x23FDF84", Slot = "48")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonDown(int button)
		{
			return default;
		}

		[Token(Token = "0x600145B")]
		[Address(RVA = "0x23FE0C8", Offset = "0x23FE0C8", VA = "0x23FE0C8", Slot = "49")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
		{
			return default;
		}

		[Token(Token = "0x600145C")]
		[Address(RVA = "0x23FE20C", Offset = "0x23FE20C", VA = "0x23FE20C", Slot = "50")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
		{
			return default;
		}

		[Token(Token = "0x600145D")]
		[Address(RVA = "0x23FE350", Offset = "0x23FE350", VA = "0x23FE350", Slot = "51")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_screenPosition()
		{
			return default;
		}

		[Token(Token = "0x600145E")]
		[Address(RVA = "0x23FE47C", Offset = "0x23FE47C", VA = "0x23FE47C", Slot = "52")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_screenPositionDelta()
		{
			return default;
		}

		[Token(Token = "0x600145F")]
		[Address(RVA = "0x23FE5A8", Offset = "0x23FE5A8", VA = "0x23FE5A8", Slot = "53")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_wheelDelta()
		{
			return default;
		}

		[Token(Token = "0x6001460")]
		[Address(RVA = "0x23FE6D4", Offset = "0x23FE6D4", VA = "0x23FE6D4", Slot = "46")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eget_locked()
		{
			return default;
		}

		[Token(Token = "0x6001461")]
		[Address(RVA = "0x23FE804", Offset = "0x23FE804", VA = "0x23FE804")]
		public PlayerMouse()
		{
		}

		[Token(Token = "0x6001462")]
		[Address(RVA = "0x23FE8B8", Offset = "0x23FE8B8", VA = "0x23FE8B8", Slot = "20")]
		private bool Rewired_002EIPlayerController_002Eget_enabled()
		{
			return default;
		}

		[Token(Token = "0x6001463")]
		[Address(RVA = "0x23FE8C0", Offset = "0x23FE8C0", VA = "0x23FE8C0", Slot = "21")]
		private void Rewired_002EIPlayerController_002Eset_enabled(bool value)
		{
		}
	}
}
