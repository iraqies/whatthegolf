using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	[Token(Token = "0x20002C1")]
	public class PlayerController : ComponentWrapper<Rewired.PlayerController>, IPlayerController
	{
		[Serializable]
		[Token(Token = "0x20002C2")]
		public class ButtonStateChangedHandler : UnityEvent<int, bool>
		{
			[Token(Token = "0x6001420")]
			[Address(RVA = "0x238D204", Offset = "0x238D204", VA = "0x238D204")]
			public ButtonStateChangedHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002C3")]
		public class AxisValueChangedHandler : UnityEvent<int, float>
		{
			[Token(Token = "0x6001421")]
			[Address(RVA = "0x238D1AC", Offset = "0x238D1AC", VA = "0x238D1AC")]
			public AxisValueChangedHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002C4")]
		public class EnabledStateChangedHandler : UnityEvent<bool>
		{
			[Token(Token = "0x6001422")]
			[Address(RVA = "0x238DAD0", Offset = "0x238DAD0", VA = "0x238DAD0")]
			public EnabledStateChangedHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002C5")]
		internal sealed class ElementWithSourceInfo
		{
			[Token(Token = "0x4000E99")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _name;

			[Token(Token = "0x4000E9A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Rewired.PlayerController.Element.TypeWithSource _elementType;

			[Token(Token = "0x4000E9B")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000E9C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private int _actionId;

			[Token(Token = "0x4000E9D")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private AxisCoordinateMode _coordinateMode;

			[Token(Token = "0x4000E9E")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _absoluteToRelativeSensitivity;

			[Token(Token = "0x4000E9F")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _repeatRate;

			[Token(Token = "0x1700056E")]
			public string name
			{
				[Token(Token = "0x6001423")]
				[Address(RVA = "0x238DA54", Offset = "0x238DA54", VA = "0x238DA54")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001424")]
				[Address(RVA = "0x238DA5C", Offset = "0x238DA5C", VA = "0x238DA5C")]
				set
				{
				}
			}

			[Token(Token = "0x1700056F")]
			public Rewired.PlayerController.Element.TypeWithSource elementType
			{
				[Token(Token = "0x6001425")]
				[Address(RVA = "0x238DA64", Offset = "0x238DA64", VA = "0x238DA64")]
				get
				{
					return default;
				}
				[Token(Token = "0x6001426")]
				[Address(RVA = "0x238DA6C", Offset = "0x238DA6C", VA = "0x238DA6C")]
				set
				{
				}
			}

			[Token(Token = "0x17000570")]
			public bool enabled
			{
				[Token(Token = "0x6001427")]
				[Address(RVA = "0x238DA74", Offset = "0x238DA74", VA = "0x238DA74")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000571")]
			public int actionId
			{
				[Token(Token = "0x6001428")]
				[Address(RVA = "0x238DA7C", Offset = "0x238DA7C", VA = "0x238DA7C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000572")]
			public AxisCoordinateMode coordinateMode
			{
				[Token(Token = "0x6001429")]
				[Address(RVA = "0x238DA84", Offset = "0x238DA84", VA = "0x238DA84")]
				get
				{
					return default;
				}
				[Token(Token = "0x600142A")]
				[Address(RVA = "0x238DA8C", Offset = "0x238DA8C", VA = "0x238DA8C")]
				set
				{
				}
			}

			[Token(Token = "0x17000573")]
			public float absoluteSourceSensitivity
			{
				[Token(Token = "0x600142B")]
				[Address(RVA = "0x238DA94", Offset = "0x238DA94", VA = "0x238DA94")]
				get
				{
					return default;
				}
				[Token(Token = "0x600142C")]
				[Address(RVA = "0x238DA9C", Offset = "0x238DA9C", VA = "0x238DA9C")]
				set
				{
				}
			}

			[Token(Token = "0x17000574")]
			public float repeatRate
			{
				[Token(Token = "0x600142D")]
				[Address(RVA = "0x238DAA4", Offset = "0x238DAA4", VA = "0x238DAA4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600142E")]
			[Address(RVA = "0x238D8B0", Offset = "0x238D8B0", VA = "0x238D8B0")]
			public Rewired.PlayerController.Element.Definition ToDefinition()
			{
				return null;
			}

			[Token(Token = "0x600142F")]
			[Address(RVA = "0x238DAAC", Offset = "0x238DAAC", VA = "0x238DAAC")]
			public ElementWithSourceInfo()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002C6")]
		internal sealed class ElementInfo
		{
			[Token(Token = "0x4000EA0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _name;

			[Token(Token = "0x4000EA1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Rewired.PlayerController.Element.Type _elementType;

			[Token(Token = "0x4000EA2")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4000EA3")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private ElementWithSourceInfo[] _elements;

			[Token(Token = "0x17000575")]
			public string name
			{
				[Token(Token = "0x6001430")]
				[Address(RVA = "0x238D25C", Offset = "0x238D25C", VA = "0x238D25C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001431")]
				[Address(RVA = "0x238D264", Offset = "0x238D264", VA = "0x238D264")]
				set
				{
				}
			}

			[Token(Token = "0x17000576")]
			public Rewired.PlayerController.Element.Type elementType
			{
				[Token(Token = "0x6001432")]
				[Address(RVA = "0x238D26C", Offset = "0x238D26C", VA = "0x238D26C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6001433")]
				[Address(RVA = "0x238D274", Offset = "0x238D274", VA = "0x238D274")]
				set
				{
				}
			}

			[Token(Token = "0x17000577")]
			public bool enabled
			{
				[Token(Token = "0x6001434")]
				[Address(RVA = "0x238D27C", Offset = "0x238D27C", VA = "0x238D27C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000578")]
			public ElementWithSourceInfo[] elements
			{
				[Token(Token = "0x6001435")]
				[Address(RVA = "0x238D284", Offset = "0x238D284", VA = "0x238D284")]
				set
				{
				}
			}

			[Token(Token = "0x6001436")]
			[Address(RVA = "0x238D28C", Offset = "0x238D28C", VA = "0x238D28C")]
			public Rewired.PlayerController.Element.Definition ToDefinition()
			{
				return null;
			}

			[Token(Token = "0x6001437")]
			[Address(RVA = "0x238D9E8", Offset = "0x238D9E8", VA = "0x238D9E8")]
			public ElementInfo()
			{
			}
		}

		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputManager_Base _rewiredInputManager;

		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _playerId;

		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ElementInfo> _elements;

		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ButtonStateChangedHandler _onButtonStateChanged;

		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AxisValueChangedHandler _onAxisValueChanged;

		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EnabledStateChangedHandler _onEnabledStateChanged;

		[Token(Token = "0x17000567")]
		public int playerId
		{
			[Token(Token = "0x60013F9")]
			[Address(RVA = "0x23F6600", Offset = "0x23F6600", VA = "0x23F6600", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x60013FA")]
			[Address(RVA = "0x23F6670", Offset = "0x23F6670", VA = "0x23F6670", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000568")]
		public IList<Rewired.PlayerController.Button> buttons
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x23F68CC", Offset = "0x23F68CC", VA = "0x23F68CC", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000569")]
		public IList<Rewired.PlayerController.Axis> axes
		{
			[Token(Token = "0x60013FC")]
			[Address(RVA = "0x23F6950", Offset = "0x23F6950", VA = "0x23F6950", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056A")]
		public IList<Rewired.PlayerController.Element> elements
		{
			[Token(Token = "0x60013FD")]
			[Address(RVA = "0x23F69D4", Offset = "0x23F69D4", VA = "0x23F69D4", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056B")]
		public int buttonCount
		{
			[Token(Token = "0x60013FE")]
			[Address(RVA = "0x23F6A58", Offset = "0x23F6A58", VA = "0x23F6A58", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700056C")]
		public int axisCount
		{
			[Token(Token = "0x60013FF")]
			[Address(RVA = "0x23F6ACC", Offset = "0x23F6ACC", VA = "0x23F6ACC", Slot = "28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700056D")]
		public int elementCount
		{
			[Token(Token = "0x6001400")]
			[Address(RVA = "0x23F6B40", Offset = "0x23F6B40", VA = "0x23F6B40", Slot = "29")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000022")]
		public event Action<int, bool> ButtonStateChangedEvent
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x23F6BB4", Offset = "0x23F6BB4", VA = "0x23F6BB4", Slot = "30")]
			add
			{
			}
			[Token(Token = "0x6001402")]
			[Address(RVA = "0x23F6C38", Offset = "0x23F6C38", VA = "0x23F6C38", Slot = "31")]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event Action<int, float> AxisValueChangedEvent
		{
			[Token(Token = "0x6001403")]
			[Address(RVA = "0x23F6CBC", Offset = "0x23F6CBC", VA = "0x23F6CBC", Slot = "32")]
			add
			{
			}
			[Token(Token = "0x6001404")]
			[Address(RVA = "0x23F6D40", Offset = "0x23F6D40", VA = "0x23F6D40", Slot = "33")]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event Action<bool> EnabledStateChangedEvent
		{
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x23F6DC4", Offset = "0x23F6DC4", VA = "0x23F6DC4", Slot = "34")]
			add
			{
			}
			[Token(Token = "0x6001406")]
			[Address(RVA = "0x23F6E48", Offset = "0x23F6E48", VA = "0x23F6E48", Slot = "35")]
			remove
			{
			}
		}

		[Token(Token = "0x6001407")]
		[Address(RVA = "0x23F6ECC", Offset = "0x23F6ECC", VA = "0x23F6ECC", Slot = "36")]
		public bool GetButton(int index)
		{
			return default;
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0x23F6F54", Offset = "0x23F6F54", VA = "0x23F6F54", Slot = "37")]
		public bool GetButtonDown(int index)
		{
			return default;
		}

		[Token(Token = "0x6001409")]
		[Address(RVA = "0x23F6FDC", Offset = "0x23F6FDC", VA = "0x23F6FDC", Slot = "38")]
		public bool GetButtonUp(int index)
		{
			return default;
		}

		[Token(Token = "0x600140A")]
		[Address(RVA = "0x23F7064", Offset = "0x23F7064", VA = "0x23F7064", Slot = "39")]
		public float GetAxis(int index)
		{
			return default;
		}

		[Token(Token = "0x600140B")]
		[Address(RVA = "0x23F70EC", Offset = "0x23F70EC", VA = "0x23F70EC", Slot = "40")]
		public float GetAxisRaw(int index)
		{
			return default;
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0x23F7174", Offset = "0x23F7174", VA = "0x23F7174", Slot = "41")]
		public Rewired.PlayerController.Element GetElement(int index)
		{
			return null;
		}

		[Token(Token = "0x600140D")]
		public T GetElement<T>(int index) where T : Rewired.PlayerController.Element
		{
			return null;
		}

		[Token(Token = "0x600140E")]
		[Address(RVA = "0x23F71FC", Offset = "0x23F71FC", VA = "0x23F71FC", Slot = "4")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x600140F")]
		[Address(RVA = "0x23F72FC", Offset = "0x23F72FC", VA = "0x23F72FC", Slot = "5")]
		protected override void OnAwakeFinished()
		{
		}

		[Token(Token = "0x6001410")]
		[Address(RVA = "0x23F74E4", Offset = "0x23F74E4", VA = "0x23F74E4", Slot = "7")]
		protected override void OnEnabled()
		{
		}

		[Token(Token = "0x6001411")]
		[Address(RVA = "0x23F75FC", Offset = "0x23F75FC", VA = "0x23F75FC", Slot = "8")]
		protected override void OnDisabled()
		{
		}

		[Token(Token = "0x6001412")]
		[Address(RVA = "0x23F7714", Offset = "0x23F7714", VA = "0x23F7714", Slot = "11")]
		protected override void OnValidated()
		{
		}

		[Token(Token = "0x6001413")]
		[Address(RVA = "0x23F77CC", Offset = "0x23F77CC", VA = "0x23F77CC", Slot = "10")]
		protected override void OnReset()
		{
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0x23F7950", Offset = "0x23F7950", VA = "0x23F7950", Slot = "18")]
		protected override void Subscribe()
		{
		}

		[Token(Token = "0x6001415")]
		[Address(RVA = "0x23F7B2C", Offset = "0x23F7B2C", VA = "0x23F7B2C", Slot = "19")]
		protected override void Unsubscribe()
		{
		}

		[Token(Token = "0x6001416")]
		[Address(RVA = "0x23F7D08", Offset = "0x23F7D08", VA = "0x23F7D08", Slot = "15")]
		protected override object GetCreateSourceArgs()
		{
			return null;
		}

		[Token(Token = "0x6001417")]
		[Address(RVA = "0x23F7D10", Offset = "0x23F7D10", VA = "0x23F7D10", Slot = "14")]
		protected override Rewired.PlayerController CreateSource(object args)
		{
			return null;
		}

		[Token(Token = "0x6001418")]
		[Address(RVA = "0x23F8210", Offset = "0x23F8210", VA = "0x23F8210", Slot = "43")]
		internal virtual List<ElementInfo> JSZQIzdJrIgpNZMUgvzpsvgYGBNt()
		{
			return null;
		}

		[Token(Token = "0x6001419")]
		[Address(RVA = "0x23F868C", Offset = "0x23F868C", VA = "0x23F868C")]
		private void HoMrMjuRzLMGezBUOnjHCXyGadHG(int P_0, bool P_1)
		{
		}

		[Token(Token = "0x600141A")]
		[Address(RVA = "0x23F87F8", Offset = "0x23F87F8", VA = "0x23F87F8")]
		private void ghoFULOHEeeqyJlbKyZkQSyDIDpV(int P_0, float P_1)
		{
		}

		[Token(Token = "0x600141B")]
		[Address(RVA = "0x23F7384", Offset = "0x23F7384", VA = "0x23F7384")]
		private void PqgQEaeDDKafZwtNKIuKefEJwAoQ(bool P_0)
		{
		}

		[Token(Token = "0x600141C")]
		[Address(RVA = "0x23F7294", Offset = "0x23F7294", VA = "0x23F7294")]
		private void hVGUAUmaQHChgkFIpXjrpSJAxBwl()
		{
		}

		[Token(Token = "0x600141D")]
		[Address(RVA = "0x23F8970", Offset = "0x23F8970", VA = "0x23F8970")]
		public PlayerController()
		{
		}

		[Token(Token = "0x600141E")]
		[Address(RVA = "0x23F8AA0", Offset = "0x23F8AA0", VA = "0x23F8AA0", Slot = "20")]
		private bool Rewired_002EIPlayerController_002Eget_enabled()
		{
			return default;
		}

		[Token(Token = "0x600141F")]
		[Address(RVA = "0x23F8AA8", Offset = "0x23F8AA8", VA = "0x23F8AA8", Slot = "21")]
		private void Rewired_002EIPlayerController_002Eset_enabled(bool value)
		{
		}
	}
}
