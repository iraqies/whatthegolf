using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI
{
	[Token(Token = "0x200117D")]
	public class GamepadTemplateUI : MonoBehaviour
	{
		[Token(Token = "0x200117E")]
		private class Stick
		{
			[Token(Token = "0x4005C9E")]
			[FieldOffset(Offset = "0x10")]
			private RectTransform _transform;

			[Token(Token = "0x4005C9F")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 _origPosition;

			[Token(Token = "0x4005CA0")]
			[FieldOffset(Offset = "0x20")]
			private int _xAxisElementId;

			[Token(Token = "0x4005CA1")]
			[FieldOffset(Offset = "0x24")]
			private int _yAxisElementId;

			[Token(Token = "0x1700089B")]
			public Vector2 position
			{
				[Token(Token = "0x6005007")]
				[Address(RVA = "0x17B0DAC", Offset = "0x17B0DAC", VA = "0x17B0DAC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6005008")]
				[Address(RVA = "0x17B0E64", Offset = "0x17B0E64", VA = "0x17B0E64")]
				set
				{
				}
			}

			[Token(Token = "0x6005009")]
			[Address(RVA = "0x17B0F28", Offset = "0x17B0F28", VA = "0x17B0F28")]
			public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
			{
			}

			[Token(Token = "0x600500A")]
			[Address(RVA = "0x17B0FE8", Offset = "0x17B0FE8", VA = "0x17B0FE8")]
			public void Reset()
			{
			}

			[Token(Token = "0x600500B")]
			[Address(RVA = "0x17B1090", Offset = "0x17B1090", VA = "0x17B1090")]
			public bool ContainsElement(int elementId)
			{
				return default;
			}

			[Token(Token = "0x600500C")]
			[Address(RVA = "0x17B1140", Offset = "0x17B1140", VA = "0x17B1140")]
			public void SetAxisPosition(int elementId, float value)
			{
			}
		}

		[Token(Token = "0x200117F")]
		private class UIElement
		{
			[Token(Token = "0x4005CA2")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			[Token(Token = "0x4005CA3")]
			[FieldOffset(Offset = "0x18")]
			public ControllerUIElement element;

			[Token(Token = "0x600500D")]
			[Address(RVA = "0x17B1214", Offset = "0x17B1214", VA = "0x17B1214")]
			public UIElement(int id, ControllerUIElement element)
			{
			}
		}

		[Token(Token = "0x4005C7F")]
		private const float stickRadius = 20f;

		[Token(Token = "0x4005C80")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005C81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform leftStick;

		[Token(Token = "0x4005C82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform rightStick;

		[Token(Token = "0x4005C83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerUIElement leftStickX;

		[Token(Token = "0x4005C84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ControllerUIElement leftStickY;

		[Token(Token = "0x4005C85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ControllerUIElement leftStickButton;

		[Token(Token = "0x4005C86")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ControllerUIElement rightStickX;

		[Token(Token = "0x4005C87")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ControllerUIElement rightStickY;

		[Token(Token = "0x4005C88")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ControllerUIElement rightStickButton;

		[Token(Token = "0x4005C89")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ControllerUIElement actionBottomRow1;

		[Token(Token = "0x4005C8A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ControllerUIElement actionBottomRow2;

		[Token(Token = "0x4005C8B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ControllerUIElement actionBottomRow3;

		[Token(Token = "0x4005C8C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ControllerUIElement actionTopRow1;

		[Token(Token = "0x4005C8D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ControllerUIElement actionTopRow2;

		[Token(Token = "0x4005C8E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ControllerUIElement actionTopRow3;

		[Token(Token = "0x4005C8F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ControllerUIElement leftShoulder;

		[Token(Token = "0x4005C90")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ControllerUIElement leftTrigger;

		[Token(Token = "0x4005C91")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ControllerUIElement rightShoulder;

		[Token(Token = "0x4005C92")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ControllerUIElement rightTrigger;

		[Token(Token = "0x4005C93")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ControllerUIElement center1;

		[Token(Token = "0x4005C94")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ControllerUIElement center2;

		[Token(Token = "0x4005C95")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ControllerUIElement center3;

		[Token(Token = "0x4005C96")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ControllerUIElement dPadUp;

		[Token(Token = "0x4005C97")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ControllerUIElement dPadRight;

		[Token(Token = "0x4005C98")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ControllerUIElement dPadDown;

		[Token(Token = "0x4005C99")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ControllerUIElement dPadLeft;

		[Token(Token = "0x4005C9A")]
		[FieldOffset(Offset = "0xE8")]
		private UIElement[] _uiElementsArray;

		[Token(Token = "0x4005C9B")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<int, ControllerUIElement> _uiElements;

		[Token(Token = "0x4005C9C")]
		[FieldOffset(Offset = "0xF8")]
		private IList<ControllerTemplateElementTarget> _tempTargetList;

		[Token(Token = "0x4005C9D")]
		[FieldOffset(Offset = "0x100")]
		private Stick[] _sticks;

		[Token(Token = "0x1700089A")]
		private Player player
		{
			[Token(Token = "0x6004FF9")]
			[Address(RVA = "0x1481214", Offset = "0x1481214", VA = "0x1481214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FFA")]
		[Address(RVA = "0x1481290", Offset = "0x1481290", VA = "0x1481290")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004FFB")]
		[Address(RVA = "0x1481BA8", Offset = "0x1481BA8", VA = "0x1481BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6004FFC")]
		[Address(RVA = "0x1481ED0", Offset = "0x1481ED0", VA = "0x1481ED0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004FFD")]
		[Address(RVA = "0x1481FE0", Offset = "0x1481FE0", VA = "0x1481FE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FFE")]
		[Address(RVA = "0x14820A4", Offset = "0x14820A4", VA = "0x14820A4")]
		private void DrawActiveElements()
		{
		}

		[Token(Token = "0x6004FFF")]
		[Address(RVA = "0x148234C", Offset = "0x148234C", VA = "0x148234C")]
		private void ActivateElements(Player player, int actionId)
		{
		}

		[Token(Token = "0x6005000")]
		[Address(RVA = "0x1481C6C", Offset = "0x1481C6C", VA = "0x1481C6C")]
		private void DrawLabels()
		{
		}

		[Token(Token = "0x6005001")]
		[Address(RVA = "0x148290C", Offset = "0x148290C", VA = "0x148290C")]
		private void DrawLabels(Player player, InputAction action)
		{
		}

		[Token(Token = "0x6005002")]
		[Address(RVA = "0x1482AD8", Offset = "0x1482AD8", VA = "0x1482AD8")]
		private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
		{
		}

		[Token(Token = "0x6005003")]
		[Address(RVA = "0x148286C", Offset = "0x148286C", VA = "0x148286C")]
		private Stick GetStick(int elementId)
		{
			return null;
		}

		[Token(Token = "0x6005004")]
		[Address(RVA = "0x14832D8", Offset = "0x14832D8", VA = "0x14832D8")]
		private void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6005005")]
		[Address(RVA = "0x14832DC", Offset = "0x14832DC", VA = "0x14832DC")]
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6005006")]
		[Address(RVA = "0x14832E0", Offset = "0x14832E0", VA = "0x14832E0")]
		public GamepadTemplateUI()
		{
		}
	}
}
