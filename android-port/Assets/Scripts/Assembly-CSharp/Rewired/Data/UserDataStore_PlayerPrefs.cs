using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Data
{
	[Token(Token = "0x200113E")]
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		[Token(Token = "0x200113F")]
		private class ControllerAssignmentSaveInfo
		{
			[Token(Token = "0x2001140")]
			public class PlayerInfo
			{
				[Token(Token = "0x4005B26")]
				[FieldOffset(Offset = "0x10")]
				public int id;

				[Token(Token = "0x4005B27")]
				[FieldOffset(Offset = "0x14")]
				public bool hasKeyboard;

				[Token(Token = "0x4005B28")]
				[FieldOffset(Offset = "0x15")]
				public bool hasMouse;

				[Token(Token = "0x4005B29")]
				[FieldOffset(Offset = "0x18")]
				public JoystickInfo[] joysticks;

				[Token(Token = "0x1700083E")]
				public int joystickCount
				{
					[Token(Token = "0x6004E08")]
					[Address(RVA = "0x18830C0", Offset = "0x18830C0", VA = "0x18830C0")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6004E09")]
				[Address(RVA = "0x18830D8", Offset = "0x18830D8", VA = "0x18830D8")]
				public PlayerInfo()
				{
				}
			}

			[Token(Token = "0x2001141")]
			public class JoystickInfo
			{
				[Token(Token = "0x4005B2A")]
				[FieldOffset(Offset = "0x10")]
				public Guid instanceGuid;

				[Token(Token = "0x4005B2B")]
				[FieldOffset(Offset = "0x20")]
				public string hardwareIdentifier;

				[Token(Token = "0x4005B2C")]
				[FieldOffset(Offset = "0x28")]
				public int id;

				[Token(Token = "0x6004E0A")]
				[Address(RVA = "0x18830B8", Offset = "0x18830B8", VA = "0x18830B8")]
				public JoystickInfo()
				{
				}
			}

			[Token(Token = "0x4005B25")]
			[FieldOffset(Offset = "0x10")]
			public PlayerInfo[] players;

			[Token(Token = "0x1700083D")]
			public int playerCount
			{
				[Token(Token = "0x6004E04")]
				[Address(RVA = "0x18743D8", Offset = "0x18743D8", VA = "0x18743D8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6004E05")]
			[Address(RVA = "0x18743F0", Offset = "0x18743F0", VA = "0x18743F0")]
			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			[Token(Token = "0x6004E06")]
			[Address(RVA = "0x18744F8", Offset = "0x18744F8", VA = "0x18744F8")]
			public int IndexOfPlayer(int playerId)
			{
				return default;
			}

			[Token(Token = "0x6004E07")]
			[Address(RVA = "0x1874580", Offset = "0x1874580", VA = "0x1874580")]
			public bool ContainsPlayer(int playerId)
			{
				return default;
			}
		}

		[Token(Token = "0x2001142")]
		private class JoystickAssignmentHistoryInfo
		{
			[Token(Token = "0x4005B2D")]
			[FieldOffset(Offset = "0x10")]
			public readonly Joystick joystick;

			[Token(Token = "0x4005B2E")]
			[FieldOffset(Offset = "0x18")]
			public readonly int oldJoystickId;

			[Token(Token = "0x6004E0B")]
			[Address(RVA = "0x1874600", Offset = "0x1874600", VA = "0x1874600")]
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}
		}

		[Token(Token = "0x2001143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47CF4", Offset = "0x47CF4")]
		private sealed class _003C_003Ec__DisplayClass78_0
		{
			[Token(Token = "0x4005B2F")]
			[FieldOffset(Offset = "0x10")]
			public Joystick joystick;

			[Token(Token = "0x6004E0C")]
			[Address(RVA = "0x1874184", Offset = "0x1874184", VA = "0x1874184")]
			public _003C_003Ec__DisplayClass78_0()
			{
			}

			[Token(Token = "0x6004E0D")]
			[Address(RVA = "0x187418C", Offset = "0x187418C", VA = "0x187418C")]
			internal bool _003CLoadJoystickAssignmentsNow_003Eb__0(JoystickAssignmentHistoryInfo x)
			{
				return default;
			}
		}

		[Token(Token = "0x2001144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47D04", Offset = "0x47D04")]
		private sealed class _003C_003Ec__DisplayClass78_1
		{
			[Token(Token = "0x4005B30")]
			[FieldOffset(Offset = "0x10")]
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;

			[Token(Token = "0x6004E0E")]
			[Address(RVA = "0x18741B0", Offset = "0x18741B0", VA = "0x18741B0")]
			public _003C_003Ec__DisplayClass78_1()
			{
			}

			[Token(Token = "0x6004E0F")]
			[Address(RVA = "0x18741B8", Offset = "0x18741B8", VA = "0x18741B8")]
			internal bool _003CLoadJoystickAssignmentsNow_003Eb__1(JoystickAssignmentHistoryInfo x)
			{
				return default;
			}
		}

		[Token(Token = "0x2001145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47D14", Offset = "0x47D14")]
		private sealed class _003C_003Ec__DisplayClass78_2
		{
			[Token(Token = "0x4005B31")]
			[FieldOffset(Offset = "0x10")]
			public Joystick match;

			[Token(Token = "0x6004E10")]
			[Address(RVA = "0x18741E8", Offset = "0x18741E8", VA = "0x18741E8")]
			public _003C_003Ec__DisplayClass78_2()
			{
			}

			[Token(Token = "0x6004E11")]
			[Address(RVA = "0x18741F0", Offset = "0x18741F0", VA = "0x18741F0")]
			internal bool _003CLoadJoystickAssignmentsNow_003Eb__2(JoystickAssignmentHistoryInfo x)
			{
				return default;
			}
		}

		[Token(Token = "0x2001146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47D24", Offset = "0x47D24")]
		private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B32")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B33")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B34")]
			[FieldOffset(Offset = "0x20")]
			public UserDataStore_PlayerPrefs _003C_003E4__this;

			[Token(Token = "0x1700083F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004E15")]
				[Address(RVA = "0x1874388", Offset = "0x1874388", VA = "0x1874388", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000840")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004E17")]
				[Address(RVA = "0x18743D0", Offset = "0x18743D0", VA = "0x18743D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004E12")]
			[Address(RVA = "0x1874214", Offset = "0x1874214", VA = "0x1874214")]
			[DebuggerHidden]
			public _003CLoadJoystickAssignmentsDeferred_003Ed__80(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004E13")]
			[Address(RVA = "0x1874240", Offset = "0x1874240", VA = "0x1874240", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004E14")]
			[Address(RVA = "0x1874244", Offset = "0x1874244", VA = "0x1874244", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004E15")]
			[Address(RVA = "0x1874388", Offset = "0x1874388", VA = "0x1874388", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004E16")]
			[Address(RVA = "0x1874390", Offset = "0x1874390", VA = "0x1874390", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004E17")]
			[Address(RVA = "0x18743D0", Offset = "0x18743D0", VA = "0x18743D0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005B11")]
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		[Token(Token = "0x4005B12")]
		private const string logPrefix = "Rewired: ";

		[Token(Token = "0x4005B13")]
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		[Token(Token = "0x4005B14")]
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		[Token(Token = "0x4005B15")]
		private const int controllerMapPPKeyVersion_original = 0;

		[Token(Token = "0x4005B16")]
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		[Token(Token = "0x4005B17")]
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		[Token(Token = "0x4005B18")]
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		[Token(Token = "0x4005B19")]
		private const int controllerMapPPKeyVersion = 2;

		[Token(Token = "0x4005B1A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isEnabled;

		[Token(Token = "0x4005B1B")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool loadDataOnStart;

		[Token(Token = "0x4005B1C")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool loadJoystickAssignments;

		[Token(Token = "0x4005B1D")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool loadKeyboardAssignments;

		[Token(Token = "0x4005B1E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool loadMouseAssignments;

		[Token(Token = "0x4005B1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string playerPrefsKeyPrefix;

		[NonSerialized]
		[Token(Token = "0x4005B20")]
		[FieldOffset(Offset = "0x28")]
		private bool allowImpreciseJoystickAssignmentMatching;

		[NonSerialized]
		[Token(Token = "0x4005B21")]
		[FieldOffset(Offset = "0x29")]
		private bool deferredJoystickAssignmentLoadPending;

		[NonSerialized]
		[Token(Token = "0x4005B22")]
		[FieldOffset(Offset = "0x2A")]
		private bool wasJoystickEverDetected;

		[NonSerialized]
		[Token(Token = "0x4005B23")]
		[FieldOffset(Offset = "0x30")]
		private List<int> __allActionIds;

		[NonSerialized]
		[Token(Token = "0x4005B24")]
		[FieldOffset(Offset = "0x38")]
		private string __allActionIdsString;

		[Token(Token = "0x17000833")]
		public bool IsEnabled
		{
			[Token(Token = "0x6004DAF")]
			[Address(RVA = "0x17405F0", Offset = "0x17405F0", VA = "0x17405F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004DB0")]
			[Address(RVA = "0x17405F8", Offset = "0x17405F8", VA = "0x17405F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000834")]
		public bool LoadDataOnStart
		{
			[Token(Token = "0x6004DB1")]
			[Address(RVA = "0x1740600", Offset = "0x1740600", VA = "0x1740600")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004DB2")]
			[Address(RVA = "0x1740608", Offset = "0x1740608", VA = "0x1740608")]
			set
			{
			}
		}

		[Token(Token = "0x17000835")]
		public bool LoadJoystickAssignments
		{
			[Token(Token = "0x6004DB3")]
			[Address(RVA = "0x1740610", Offset = "0x1740610", VA = "0x1740610")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004DB4")]
			[Address(RVA = "0x1740618", Offset = "0x1740618", VA = "0x1740618")]
			set
			{
			}
		}

		[Token(Token = "0x17000836")]
		public bool LoadKeyboardAssignments
		{
			[Token(Token = "0x6004DB5")]
			[Address(RVA = "0x1740620", Offset = "0x1740620", VA = "0x1740620")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004DB6")]
			[Address(RVA = "0x1740628", Offset = "0x1740628", VA = "0x1740628")]
			set
			{
			}
		}

		[Token(Token = "0x17000837")]
		public bool LoadMouseAssignments
		{
			[Token(Token = "0x6004DB7")]
			[Address(RVA = "0x1740630", Offset = "0x1740630", VA = "0x1740630")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004DB8")]
			[Address(RVA = "0x1740638", Offset = "0x1740638", VA = "0x1740638")]
			set
			{
			}
		}

		[Token(Token = "0x17000838")]
		public string PlayerPrefsKeyPrefix
		{
			[Token(Token = "0x6004DB9")]
			[Address(RVA = "0x1740640", Offset = "0x1740640", VA = "0x1740640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DBA")]
			[Address(RVA = "0x1740648", Offset = "0x1740648", VA = "0x1740648")]
			set
			{
			}
		}

		[Token(Token = "0x17000839")]
		private string playerPrefsKey_controllerAssignments
		{
			[Token(Token = "0x6004DBB")]
			[Address(RVA = "0x1740650", Offset = "0x1740650", VA = "0x1740650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083A")]
		private bool loadControllerAssignments
		{
			[Token(Token = "0x6004DBC")]
			[Address(RVA = "0x17406C0", Offset = "0x17406C0", VA = "0x17406C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700083B")]
		private List<int> allActionIds
		{
			[Token(Token = "0x6004DBD")]
			[Address(RVA = "0x17406E8", Offset = "0x17406E8", VA = "0x17406E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083C")]
		private string allActionIdsString
		{
			[Token(Token = "0x6004DBE")]
			[Address(RVA = "0x1740904", Offset = "0x1740904", VA = "0x1740904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004DBF")]
		[Address(RVA = "0x1740A44", Offset = "0x1740A44", VA = "0x1740A44", Slot = "16")]
		public override void Save()
		{
		}

		[Token(Token = "0x6004DC0")]
		[Address(RVA = "0x1740D08", Offset = "0x1740D08", VA = "0x1740D08", Slot = "17")]
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DC1")]
		[Address(RVA = "0x1740E40", Offset = "0x1740E40", VA = "0x1740E40", Slot = "18")]
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DC2")]
		[Address(RVA = "0x1740F20", Offset = "0x1740F20", VA = "0x1740F20", Slot = "19")]
		public override void SavePlayerData(int playerId)
		{
		}

		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x17410B0", Offset = "0x17410B0", VA = "0x17410B0", Slot = "20")]
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x6004DC4")]
		[Address(RVA = "0x174127C", Offset = "0x174127C", VA = "0x174127C", Slot = "11")]
		public override void Load()
		{
		}

		[Token(Token = "0x6004DC5")]
		[Address(RVA = "0x17414FC", Offset = "0x17414FC", VA = "0x17414FC", Slot = "12")]
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x1741658", Offset = "0x1741658", VA = "0x1741658", Slot = "13")]
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DC7")]
		[Address(RVA = "0x1741734", Offset = "0x1741734", VA = "0x1741734", Slot = "14")]
		public override void LoadPlayerData(int playerId)
		{
		}

		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x1741868", Offset = "0x1741868", VA = "0x1741868", Slot = "15")]
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x1741A0C", Offset = "0x1741A0C", VA = "0x1741A0C", Slot = "23")]
		protected override void OnInitialize()
		{
		}

		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x1742138", Offset = "0x1742138", VA = "0x1742138", Slot = "24")]
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0x17424BC", Offset = "0x17424BC", VA = "0x17424BC", Slot = "27")]
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x17426E8", Offset = "0x17426E8", VA = "0x17426E8", Slot = "25")]
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x1742718", Offset = "0x1742718", VA = "0x1742718", Slot = "21")]
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x6004DCE")]
		[Address(RVA = "0x17428F0", Offset = "0x17428F0", VA = "0x17428F0", Slot = "22")]
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x1741310", Offset = "0x1741310", VA = "0x1741310")]
		private int LoadAll()
		{
			return default;
		}

		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x17417DC", Offset = "0x17417DC", VA = "0x17417DC")]
		private int LoadPlayerDataNow(int playerId)
		{
			return default;
		}

		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x1742BE4", Offset = "0x1742BE4", VA = "0x1742BE4")]
		private int LoadPlayerDataNow(Player player)
		{
			return default;
		}

		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x1742FB0", Offset = "0x1742FB0", VA = "0x1742FB0")]
		private int LoadAllJoystickCalibrationData()
		{
			return default;
		}

		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x17438DC", Offset = "0x17438DC", VA = "0x17438DC")]
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return default;
		}

		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x1743A18", Offset = "0x1743A18", VA = "0x1743A18")]
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return default;
		}

		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x174222C", Offset = "0x174222C", VA = "0x174222C")]
		private int LoadJoystickData(int joystickId)
		{
			return default;
		}

		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x17415F0", Offset = "0x17415F0", VA = "0x17415F0")]
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return default;
		}

		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x174171C", Offset = "0x174171C", VA = "0x174171C")]
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return default;
		}

		[Token(Token = "0x6004DD8")]
		[Address(RVA = "0x17433F8", Offset = "0x17433F8", VA = "0x17433F8")]
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return default;
		}

		[Token(Token = "0x6004DD9")]
		[Address(RVA = "0x17429C4", Offset = "0x17429C4", VA = "0x17429C4")]
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6004DDA")]
		[Address(RVA = "0x17431DC", Offset = "0x17431DC", VA = "0x17431DC")]
		private int LoadInputBehaviors(int playerId)
		{
			return default;
		}

		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x1741918", Offset = "0x1741918", VA = "0x1741918")]
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return default;
		}

		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x1744408", Offset = "0x1744408", VA = "0x1744408")]
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			return default;
		}

		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x1742B00", Offset = "0x1742B00", VA = "0x1742B00")]
		private bool LoadControllerAssignmentsNow()
		{
			return default;
		}

		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x1744798", Offset = "0x1744798", VA = "0x1744798")]
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default;
		}

		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x1744CB8", Offset = "0x1744CB8", VA = "0x1744CB8")]
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default;
		}

		[Token(Token = "0x6004DE0")]
		[Address(RVA = "0x17445B4", Offset = "0x17445B4", VA = "0x17445B4")]
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		[Token(Token = "0x6004DE1")]
		[Address(RVA = "0x1742448", Offset = "0x1742448", VA = "0x1742448")]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		[Token(Token = "0x6004DE2")]
		[Address(RVA = "0x1740AD8", Offset = "0x1740AD8", VA = "0x1740AD8")]
		private void SaveAll()
		{
		}

		[Token(Token = "0x6004DE3")]
		[Address(RVA = "0x1740FC8", Offset = "0x1740FC8", VA = "0x1740FC8")]
		private void SavePlayerDataNow(int playerId)
		{
		}

		[Token(Token = "0x6004DE4")]
		[Address(RVA = "0x17464B8", Offset = "0x17464B8", VA = "0x17464B8")]
		private void SavePlayerDataNow(Player player)
		{
		}

		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0x1746534", Offset = "0x1746534", VA = "0x1746534")]
		private void SaveAllJoystickCalibrationData()
		{
		}

		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x1746B84", Offset = "0x1746B84", VA = "0x1746B84")]
		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x1746B04", Offset = "0x1746B04", VA = "0x1746B04")]
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x17424F0", Offset = "0x17424F0", VA = "0x17424F0")]
		private void SaveJoystickData(int joystickId)
		{
		}

		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x1740DF0", Offset = "0x1740DF0", VA = "0x1740DF0")]
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x1740EFC", Offset = "0x1740EFC", VA = "0x1740EFC")]
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x17467E8", Offset = "0x17467E8", VA = "0x17467E8")]
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
		}

		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x1746DE8", Offset = "0x1746DE8", VA = "0x1746DE8")]
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x17427C4", Offset = "0x17427C4", VA = "0x17427C4")]
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x1746724", Offset = "0x1746724", VA = "0x1746724")]
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
		}

		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x1741160", Offset = "0x1741160", VA = "0x1741160")]
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x1747144", Offset = "0x1747144", VA = "0x1747144")]
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
		}

		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x1741AD8", Offset = "0x1741AD8", VA = "0x1741AD8")]
		private bool SaveControllerAssignments()
		{
			return default;
		}

		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x1747290", Offset = "0x1747290", VA = "0x1747290")]
		private bool ControllerAssignmentSaveDataExists()
		{
			return default;
		}

		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x1747360", Offset = "0x1747360", VA = "0x1747360")]
		private string GetBasePlayerPrefsKey(Player player)
		{
			return null;
		}

		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x1746F24", Offset = "0x1746F24", VA = "0x1746F24")]
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x1747034", Offset = "0x1747034", VA = "0x1747034")]
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x17473D8", Offset = "0x17473D8", VA = "0x17473D8")]
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x1746C5C", Offset = "0x1746C5C", VA = "0x1746C5C")]
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x1747194", Offset = "0x1747194", VA = "0x1747194")]
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return null;
		}

		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x1743B14", Offset = "0x1743B14", VA = "0x1743B14")]
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x1743BD4", Offset = "0x1743BD4", VA = "0x1743BD4")]
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x1743984", Offset = "0x1743984", VA = "0x1743984")]
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x1744518", Offset = "0x1744518", VA = "0x1744518")]
		private string GetInputBehaviorXml(Player player, int id)
		{
			return null;
		}

		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x1743DD0", Offset = "0x1743DD0", VA = "0x1743DD0")]
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x1745EE8", Offset = "0x1745EE8", VA = "0x1745EE8")]
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0x17461D8", Offset = "0x17461D8", VA = "0x17461D8")]
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			return default;
		}

		[Token(Token = "0x6004E00")]
		[Address(RVA = "0x17479A4", Offset = "0x17479A4", VA = "0x17479A4")]
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			return default;
		}

		[Token(Token = "0x6004E01")]
		[Address(RVA = "0x174382C", Offset = "0x174382C", VA = "0x174382C")]
		private void RefreshLayoutManager(int playerId)
		{
		}

		[Token(Token = "0x6004E02")]
		[Address(RVA = "0x17477E0", Offset = "0x17477E0", VA = "0x17477E0")]
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}

		[Token(Token = "0x6004E03")]
		[Address(RVA = "0x1747F28", Offset = "0x1747F28", VA = "0x1747F28")]
		public UserDataStore_PlayerPrefs()
		{
		}
	}
}
