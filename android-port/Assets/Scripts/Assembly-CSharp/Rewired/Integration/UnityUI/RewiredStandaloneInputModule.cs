using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Token(Token = "0x2001150")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		[Token(Token = "0x4005B55")]
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		[Token(Token = "0x4005B56")]
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		[Token(Token = "0x4005B57")]
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		[Token(Token = "0x4005B58")]
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		[Token(Token = "0x4005B59")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		[Token(Token = "0x4005B5A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool useAllRewiredGamePlayers;

		[Token(Token = "0x4005B5B")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool useRewiredSystemPlayer;

		[Token(Token = "0x4005B5C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int[] rewiredPlayerIds;

		[Token(Token = "0x4005B5D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool usePlayingPlayersOnly;

		[Token(Token = "0x4005B5E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<Rewired.Components.PlayerMouse> playerMice;

		[Token(Token = "0x4005B5F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool moveOneElementPerAxisPress;

		[Token(Token = "0x4005B60")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool setActionsById;

		[Token(Token = "0x4005B61")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private int horizontalActionId;

		[Token(Token = "0x4005B62")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int verticalActionId;

		[Token(Token = "0x4005B63")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int submitActionId;

		[Token(Token = "0x4005B64")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int cancelActionId;

		[Token(Token = "0x4005B65")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_HorizontalAxis;

		[Token(Token = "0x4005B66")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string m_VerticalAxis;

		[Token(Token = "0x4005B67")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string m_SubmitButton;

		[Token(Token = "0x4005B68")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string m_CancelButton;

		[Token(Token = "0x4005B69")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_InputActionsPerSecond;

		[Token(Token = "0x4005B6A")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float m_RepeatDelay;

		[Token(Token = "0x4005B6B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_allowMouseInput;

		[Token(Token = "0x4005B6C")]
		[FieldOffset(Offset = "0xD9")]
		[SerializeField]
		private bool m_allowMouseInputIfTouchSupported;

		[Token(Token = "0x4005B6D")]
		[FieldOffset(Offset = "0xDA")]
		[SerializeField]
		private bool m_allowTouchInput;

		[Token(Token = "0x4005B6E")]
		[FieldOffset(Offset = "0xDB")]
		[SerializeField]
		private bool m_deselectIfBackgroundClicked;

		[Token(Token = "0x4005B6F")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private bool m_deselectBeforeSelecting;

		[Token(Token = "0x4005B70")]
		[FieldOffset(Offset = "0xDD")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x570B0", Offset = "0x570B0")]
		private bool m_ForceModuleActive;

		[NonSerialized]
		[Token(Token = "0x4005B71")]
		[FieldOffset(Offset = "0xE0")]
		private int[] playerIds;

		[Token(Token = "0x4005B72")]
		[FieldOffset(Offset = "0xE8")]
		private bool recompiling;

		[NonSerialized]
		[Token(Token = "0x4005B73")]
		[FieldOffset(Offset = "0xE9")]
		private bool isTouchSupported;

		[NonSerialized]
		[Token(Token = "0x4005B74")]
		[FieldOffset(Offset = "0xF0")]
		private double m_PrevActionTime;

		[NonSerialized]
		[Token(Token = "0x4005B75")]
		[FieldOffset(Offset = "0xF8")]
		private Vector2 m_LastMoveVector;

		[NonSerialized]
		[Token(Token = "0x4005B76")]
		[FieldOffset(Offset = "0x100")]
		private int m_ConsecutiveMoveCount;

		[NonSerialized]
		[Token(Token = "0x4005B77")]
		[FieldOffset(Offset = "0x104")]
		private bool m_HasFocus;

		[Token(Token = "0x17000859")]
		public InputManager_Base RewiredInputManager
		{
			[Token(Token = "0x6004E67")]
			[Address(RVA = "0x1651048", Offset = "0x1651048", VA = "0x1651048")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E68")]
			[Address(RVA = "0x1651050", Offset = "0x1651050", VA = "0x1651050")]
			set
			{
			}
		}

		[Token(Token = "0x1700085A")]
		public bool UseAllRewiredGamePlayers
		{
			[Token(Token = "0x6004E69")]
			[Address(RVA = "0x1651058", Offset = "0x1651058", VA = "0x1651058")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E6A")]
			[Address(RVA = "0x1651060", Offset = "0x1651060", VA = "0x1651060")]
			set
			{
			}
		}

		[Token(Token = "0x1700085B")]
		public bool UseRewiredSystemPlayer
		{
			[Token(Token = "0x6004E6B")]
			[Address(RVA = "0x1651598", Offset = "0x1651598", VA = "0x1651598")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E6C")]
			[Address(RVA = "0x16515A0", Offset = "0x16515A0", VA = "0x16515A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700085C")]
		public int[] RewiredPlayerIds
		{
			[Token(Token = "0x6004E6D")]
			[Address(RVA = "0x16515B8", Offset = "0x16515B8", VA = "0x16515B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E6E")]
			[Address(RVA = "0x1651634", Offset = "0x1651634", VA = "0x1651634")]
			set
			{
			}
		}

		[Token(Token = "0x1700085D")]
		public bool UsePlayingPlayersOnly
		{
			[Token(Token = "0x6004E6F")]
			[Address(RVA = "0x16516E0", Offset = "0x16516E0", VA = "0x16516E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E70")]
			[Address(RVA = "0x16516E8", Offset = "0x16516E8", VA = "0x16516E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700085E")]
		public List<Rewired.Components.PlayerMouse> PlayerMice
		{
			[Token(Token = "0x6004E71")]
			[Address(RVA = "0x16516F0", Offset = "0x16516F0", VA = "0x16516F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E72")]
			[Address(RVA = "0x1651770", Offset = "0x1651770", VA = "0x1651770")]
			set
			{
			}
		}

		[Token(Token = "0x1700085F")]
		public bool MoveOneElementPerAxisPress
		{
			[Token(Token = "0x6004E73")]
			[Address(RVA = "0x1651820", Offset = "0x1651820", VA = "0x1651820")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E74")]
			[Address(RVA = "0x1651828", Offset = "0x1651828", VA = "0x1651828")]
			set
			{
			}
		}

		[Token(Token = "0x17000860")]
		public bool allowMouseInput
		{
			[Token(Token = "0x6004E75")]
			[Address(RVA = "0x1651830", Offset = "0x1651830", VA = "0x1651830")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E76")]
			[Address(RVA = "0x1651838", Offset = "0x1651838", VA = "0x1651838")]
			set
			{
			}
		}

		[Token(Token = "0x17000861")]
		public bool allowMouseInputIfTouchSupported
		{
			[Token(Token = "0x6004E77")]
			[Address(RVA = "0x1651840", Offset = "0x1651840", VA = "0x1651840")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E78")]
			[Address(RVA = "0x1651848", Offset = "0x1651848", VA = "0x1651848")]
			set
			{
			}
		}

		[Token(Token = "0x17000862")]
		public bool allowTouchInput
		{
			[Token(Token = "0x6004E79")]
			[Address(RVA = "0x1651850", Offset = "0x1651850", VA = "0x1651850")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E7A")]
			[Address(RVA = "0x1651858", Offset = "0x1651858", VA = "0x1651858")]
			set
			{
			}
		}

		[Token(Token = "0x17000863")]
		public bool deselectIfBackgroundClicked
		{
			[Token(Token = "0x6004E7B")]
			[Address(RVA = "0x1651860", Offset = "0x1651860", VA = "0x1651860")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E7C")]
			[Address(RVA = "0x1651868", Offset = "0x1651868", VA = "0x1651868")]
			set
			{
			}
		}

		[Token(Token = "0x17000864")]
		private bool deselectBeforeSelecting
		{
			[Token(Token = "0x6004E7D")]
			[Address(RVA = "0x1651870", Offset = "0x1651870", VA = "0x1651870")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E7E")]
			[Address(RVA = "0x1651878", Offset = "0x1651878", VA = "0x1651878")]
			set
			{
			}
		}

		[Token(Token = "0x17000865")]
		public bool SetActionsById
		{
			[Token(Token = "0x6004E7F")]
			[Address(RVA = "0x1651880", Offset = "0x1651880", VA = "0x1651880")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E80")]
			[Address(RVA = "0x1651888", Offset = "0x1651888", VA = "0x1651888")]
			set
			{
			}
		}

		[Token(Token = "0x17000866")]
		public int HorizontalActionId
		{
			[Token(Token = "0x6004E81")]
			[Address(RVA = "0x16518A0", Offset = "0x16518A0", VA = "0x16518A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E82")]
			[Address(RVA = "0x16518A8", Offset = "0x16518A8", VA = "0x16518A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000867")]
		public int VerticalActionId
		{
			[Token(Token = "0x6004E83")]
			[Address(RVA = "0x1651A10", Offset = "0x1651A10", VA = "0x1651A10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E84")]
			[Address(RVA = "0x1651A18", Offset = "0x1651A18", VA = "0x1651A18")]
			set
			{
			}
		}

		[Token(Token = "0x17000868")]
		public int SubmitActionId
		{
			[Token(Token = "0x6004E85")]
			[Address(RVA = "0x1651B80", Offset = "0x1651B80", VA = "0x1651B80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E86")]
			[Address(RVA = "0x1651B88", Offset = "0x1651B88", VA = "0x1651B88")]
			set
			{
			}
		}

		[Token(Token = "0x17000869")]
		public int CancelActionId
		{
			[Token(Token = "0x6004E87")]
			[Address(RVA = "0x1651CF0", Offset = "0x1651CF0", VA = "0x1651CF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E88")]
			[Address(RVA = "0x1651CF8", Offset = "0x1651CF8", VA = "0x1651CF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700086A")]
		protected override bool isMouseSupported
		{
			[Token(Token = "0x6004E89")]
			[Address(RVA = "0x1651E60", Offset = "0x1651E60", VA = "0x1651E60", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700086B")]
		private bool isTouchAllowed
		{
			[Token(Token = "0x6004E8A")]
			[Address(RVA = "0x1651EB4", Offset = "0x1651EB4", VA = "0x1651EB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700086C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x739F0", Offset = "0x739F0")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x6004E8B")]
			[Address(RVA = "0x1651EBC", Offset = "0x1651EBC", VA = "0x1651EBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E8C")]
			[Address(RVA = "0x1651EC4", Offset = "0x1651EC4", VA = "0x1651EC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700086D")]
		public bool forceModuleActive
		{
			[Token(Token = "0x6004E8D")]
			[Address(RVA = "0x1651ECC", Offset = "0x1651ECC", VA = "0x1651ECC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E8E")]
			[Address(RVA = "0x1651ED4", Offset = "0x1651ED4", VA = "0x1651ED4")]
			set
			{
			}
		}

		[Token(Token = "0x1700086E")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x6004E8F")]
			[Address(RVA = "0x1651EDC", Offset = "0x1651EDC", VA = "0x1651EDC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E90")]
			[Address(RVA = "0x1651EE4", Offset = "0x1651EE4", VA = "0x1651EE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700086F")]
		public float repeatDelay
		{
			[Token(Token = "0x6004E91")]
			[Address(RVA = "0x1651EEC", Offset = "0x1651EEC", VA = "0x1651EEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E92")]
			[Address(RVA = "0x1651EF4", Offset = "0x1651EF4", VA = "0x1651EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000870")]
		public string horizontalAxis
		{
			[Token(Token = "0x6004E93")]
			[Address(RVA = "0x1651EFC", Offset = "0x1651EFC", VA = "0x1651EFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E94")]
			[Address(RVA = "0x1651F04", Offset = "0x1651F04", VA = "0x1651F04")]
			set
			{
			}
		}

		[Token(Token = "0x17000871")]
		public string verticalAxis
		{
			[Token(Token = "0x6004E95")]
			[Address(RVA = "0x1652004", Offset = "0x1652004", VA = "0x1652004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E96")]
			[Address(RVA = "0x165200C", Offset = "0x165200C", VA = "0x165200C")]
			set
			{
			}
		}

		[Token(Token = "0x17000872")]
		public string submitButton
		{
			[Token(Token = "0x6004E97")]
			[Address(RVA = "0x165210C", Offset = "0x165210C", VA = "0x165210C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E98")]
			[Address(RVA = "0x1652114", Offset = "0x1652114", VA = "0x1652114")]
			set
			{
			}
		}

		[Token(Token = "0x17000873")]
		public string cancelButton
		{
			[Token(Token = "0x6004E99")]
			[Address(RVA = "0x1652214", Offset = "0x1652214", VA = "0x1652214")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E9A")]
			[Address(RVA = "0x165221C", Offset = "0x165221C", VA = "0x165221C")]
			set
			{
			}
		}

		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x165231C", Offset = "0x165231C", VA = "0x165231C")]
		private RewiredStandaloneInputModule()
		{
		}

		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x165246C", Offset = "0x165246C", VA = "0x165246C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x165288C", Offset = "0x165288C", VA = "0x165288C", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x1652B14", Offset = "0x1652B14", VA = "0x1652B14", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default;
		}

		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x1652B1C", Offset = "0x1652B1C", VA = "0x1652B1C", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default;
		}

		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x16534F4", Offset = "0x16534F4", VA = "0x16534F4", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x16535E0", Offset = "0x16535E0", VA = "0x16535E0", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x1653608", Offset = "0x1653608", VA = "0x1653608", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x1653ED0", Offset = "0x1653ED0", VA = "0x1653ED0")]
		private bool ProcessTouchEvents()
		{
			return default;
		}

		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x16543C8", Offset = "0x16543C8", VA = "0x16543C8")]
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x1653BC4", Offset = "0x1653BC4", VA = "0x1653BC4")]
		private bool SendSubmitEventToSelectedObject()
		{
			return default;
		}

		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x1654E0C", Offset = "0x1654E0C", VA = "0x1654E0C")]
		private Vector2 GetRawMoveVector()
		{
			return default;
		}

		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x16538CC", Offset = "0x16538CC", VA = "0x16538CC")]
		private bool SendMoveEventToSelectedObject()
		{
			return default;
		}

		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x1655178", Offset = "0x1655178", VA = "0x1655178")]
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
		}

		[Token(Token = "0x6004EA9")]
		[Address(RVA = "0x165426C", Offset = "0x165426C", VA = "0x165426C")]
		private void ProcessMouseEvents()
		{
		}

		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x1655384", Offset = "0x1655384", VA = "0x1655384")]
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
		}

		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x1653760", Offset = "0x1653760", VA = "0x1653760")]
		private bool SendUpdateEventToSelectedObject()
		{
			return default;
		}

		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x165570C", Offset = "0x165570C", VA = "0x165570C")]
		private void ProcessMousePress(MouseButtonEventData data)
		{
		}

		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x1654C14", Offset = "0x1654C14", VA = "0x1654C14")]
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x1655E78", Offset = "0x1655E78", VA = "0x1655E78")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x1652A38", Offset = "0x1652A38", VA = "0x1652A38")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default;
		}

		[Token(Token = "0x6004EB0")]
		[Address(RVA = "0x1655E80", Offset = "0x1655E80", VA = "0x1655E80", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6004EB1")]
		[Address(RVA = "0x1655FC4", Offset = "0x1655FC4", VA = "0x1655FC4", Slot = "27")]
		protected override bool IsDefaultPlayer(int playerId)
		{
			return default;
		}

		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x1652684", Offset = "0x1652684", VA = "0x1652684")]
		private void InitializeRewired()
		{
		}

		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x1651078", Offset = "0x1651078", VA = "0x1651078")]
		private void SetupRewiredVars()
		{
		}

		[Token(Token = "0x6004EB4")]
		[Address(RVA = "0x165646C", Offset = "0x165646C", VA = "0x165646C")]
		private void SetUpRewiredPlayerMice()
		{
		}

		[Token(Token = "0x6004EB5")]
		[Address(RVA = "0x165619C", Offset = "0x165619C", VA = "0x165619C")]
		private void SetUpRewiredActions()
		{
		}

		[Token(Token = "0x6004EB6")]
		[Address(RVA = "0x1655120", Offset = "0x1655120", VA = "0x1655120")]
		private bool GetButton(Player player, int actionId)
		{
			return default;
		}

		[Token(Token = "0x6004EB7")]
		[Address(RVA = "0x16530B0", Offset = "0x16530B0", VA = "0x16530B0")]
		private bool GetButtonDown(Player player, int actionId)
		{
			return default;
		}

		[Token(Token = "0x6004EB8")]
		[Address(RVA = "0x165514C", Offset = "0x165514C", VA = "0x165514C")]
		private bool GetNegativeButton(Player player, int actionId)
		{
			return default;
		}

		[Token(Token = "0x6004EB9")]
		[Address(RVA = "0x16530DC", Offset = "0x16530DC", VA = "0x16530DC")]
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return default;
		}

		[Token(Token = "0x6004EBA")]
		[Address(RVA = "0x1653108", Offset = "0x1653108", VA = "0x1653108")]
		private float GetAxis(Player player, int actionId)
		{
			return default;
		}

		[Token(Token = "0x6004EBB")]
		[Address(RVA = "0x1652964", Offset = "0x1652964", VA = "0x1652964")]
		private void CheckEditorRecompile()
		{
		}

		[Token(Token = "0x6004EBC")]
		[Address(RVA = "0x1656620", Offset = "0x1656620", VA = "0x1656620")]
		private void OnEditorRecompile()
		{
		}

		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x1656694", Offset = "0x1656694", VA = "0x1656694")]
		private void ClearRewiredVars()
		{
		}

		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x1653134", Offset = "0x1653134", VA = "0x1653134")]
		private bool DidAnyMouseMove()
		{
			return default;
		}

		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x1653320", Offset = "0x1653320", VA = "0x1653320")]
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			return default;
		}

		[Token(Token = "0x6004EC0")]
		[Address(RVA = "0x1656700", Offset = "0x1656700", VA = "0x1656700")]
		private void OnRewiredInitialized()
		{
		}

		[Token(Token = "0x6004EC1")]
		[Address(RVA = "0x1656704", Offset = "0x1656704", VA = "0x1656704")]
		private void OnRewiredShutDown()
		{
		}
	}
}
