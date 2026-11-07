using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001151")]
	public class ControlRemappingDemo1 : MonoBehaviour
	{
		[Token(Token = "0x2001152")]
		private class ControllerSelection
		{
			[Token(Token = "0x4005B8F")]
			[FieldOffset(Offset = "0x10")]
			private int _id;

			[Token(Token = "0x4005B90")]
			[FieldOffset(Offset = "0x14")]
			private int _idPrev;

			[Token(Token = "0x4005B91")]
			[FieldOffset(Offset = "0x18")]
			private ControllerType _type;

			[Token(Token = "0x4005B92")]
			[FieldOffset(Offset = "0x1C")]
			private ControllerType _typePrev;

			[Token(Token = "0x17000874")]
			public int id
			{
				[Token(Token = "0x6004EFE")]
				[Address(RVA = "0x178FDB0", Offset = "0x178FDB0", VA = "0x178FDB0")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004EFF")]
				[Address(RVA = "0x178FDB8", Offset = "0x178FDB8", VA = "0x178FDB8")]
				set
				{
				}
			}

			[Token(Token = "0x17000875")]
			public ControllerType type
			{
				[Token(Token = "0x6004F00")]
				[Address(RVA = "0x178FDC4", Offset = "0x178FDC4", VA = "0x178FDC4")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F01")]
				[Address(RVA = "0x178FDCC", Offset = "0x178FDCC", VA = "0x178FDCC")]
				set
				{
				}
			}

			[Token(Token = "0x17000876")]
			public bool hasSelection
			{
				[Token(Token = "0x6004F02")]
				[Address(RVA = "0x178FDD8", Offset = "0x178FDD8", VA = "0x178FDD8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6004EFD")]
			[Address(RVA = "0x178FD70", Offset = "0x178FD70", VA = "0x178FD70")]
			public ControllerSelection()
			{
			}

			[Token(Token = "0x6004F03")]
			[Address(RVA = "0x178FDE8", Offset = "0x178FDE8", VA = "0x178FDE8")]
			public void Set(int id, ControllerType type)
			{
			}

			[Token(Token = "0x6004F04")]
			[Address(RVA = "0x178FDA0", Offset = "0x178FDA0", VA = "0x178FDA0")]
			public void Clear()
			{
			}
		}

		[Token(Token = "0x2001153")]
		private class DialogHelper
		{
			[Token(Token = "0x2001154")]
			public enum DialogType
			{
				[Token(Token = "0x4005B9F")]
				None = 0,
				[Token(Token = "0x4005BA0")]
				JoystickConflict = 1,
				[Token(Token = "0x4005BA1")]
				ElementConflict = 2,
				[Token(Token = "0x4005BA2")]
				KeyConflict = 3,
				[Token(Token = "0x4005BA3")]
				DeleteAssignmentConfirmation = 10,
				[Token(Token = "0x4005BA4")]
				AssignElement = 11
			}

			[Token(Token = "0x4005B93")]
			private const float openBusyDelay = 0.25f;

			[Token(Token = "0x4005B94")]
			private const float closeBusyDelay = 0.1f;

			[Token(Token = "0x4005B95")]
			[FieldOffset(Offset = "0x10")]
			private DialogType _type;

			[Token(Token = "0x4005B96")]
			[FieldOffset(Offset = "0x14")]
			private bool _enabled;

			[Token(Token = "0x4005B97")]
			[FieldOffset(Offset = "0x18")]
			private float _busyTime;

			[Token(Token = "0x4005B98")]
			[FieldOffset(Offset = "0x1C")]
			private bool _busyTimerRunning;

			[Token(Token = "0x4005B99")]
			[FieldOffset(Offset = "0x20")]
			private Action<int> drawWindowDelegate;

			[Token(Token = "0x4005B9A")]
			[FieldOffset(Offset = "0x28")]
			private GUI.WindowFunction drawWindowFunction;

			[Token(Token = "0x4005B9B")]
			[FieldOffset(Offset = "0x30")]
			private WindowProperties windowProperties;

			[Token(Token = "0x4005B9C")]
			[FieldOffset(Offset = "0x60")]
			private int currentActionId;

			[Token(Token = "0x4005B9D")]
			[FieldOffset(Offset = "0x68")]
			private Action<int, UserResponse> resultCallback;

			[Token(Token = "0x17000877")]
			private float busyTimer
			{
				[Token(Token = "0x6004F05")]
				[Address(RVA = "0x178FDFC", Offset = "0x178FDFC", VA = "0x178FDFC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000878")]
			public bool enabled
			{
				[Token(Token = "0x6004F06")]
				[Address(RVA = "0x178FE34", Offset = "0x178FE34", VA = "0x178FE34")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000879")]
			public DialogType type
			{
				[Token(Token = "0x6004F07")]
				[Address(RVA = "0x178FE3C", Offset = "0x178FE3C", VA = "0x178FE3C")]
				set
				{
				}
			}

			[Token(Token = "0x1700087A")]
			public bool busy
			{
				[Token(Token = "0x6004F08")]
				[Address(RVA = "0x178FEE0", Offset = "0x178FEE0", VA = "0x178FEE0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6004F09")]
			[Address(RVA = "0x178FEE8", Offset = "0x178FEE8", VA = "0x178FEE8")]
			public DialogHelper()
			{
			}

			[Token(Token = "0x6004F0A")]
			[Address(RVA = "0x178FFE0", Offset = "0x178FFE0", VA = "0x178FFE0")]
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
			{
			}

			[Token(Token = "0x6004F0B")]
			[Address(RVA = "0x1790078", Offset = "0x1790078", VA = "0x1790078")]
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
			{
			}

			[Token(Token = "0x6004F0C")]
			[Address(RVA = "0x1790120", Offset = "0x1790120", VA = "0x1790120")]
			public void Update()
			{
			}

			[Token(Token = "0x6004F0D")]
			[Address(RVA = "0x1790170", Offset = "0x1790170", VA = "0x1790170")]
			public void Draw()
			{
			}

			[Token(Token = "0x6004F0E")]
			[Address(RVA = "0x1790390", Offset = "0x1790390", VA = "0x1790390")]
			public void DrawConfirmButton(string title)
			{
			}

			[Token(Token = "0x6004F0F")]
			[Address(RVA = "0x1790660", Offset = "0x1790660", VA = "0x1790660")]
			public void DrawConfirmButton(UserResponse response, string title)
			{
			}

			[Token(Token = "0x6004F10")]
			[Address(RVA = "0x179089C", Offset = "0x179089C", VA = "0x179089C")]
			public void DrawCancelButton()
			{
			}

			[Token(Token = "0x6004F11")]
			[Address(RVA = "0x17908F4", Offset = "0x17908F4", VA = "0x17908F4")]
			public void DrawCancelButton(string title)
			{
			}

			[Token(Token = "0x6004F12")]
			[Address(RVA = "0x1790BB8", Offset = "0x1790BB8", VA = "0x1790BB8")]
			public void Confirm()
			{
			}

			[Token(Token = "0x6004F13")]
			[Address(RVA = "0x17905BC", Offset = "0x17905BC", VA = "0x17905BC")]
			public void Confirm(UserResponse response)
			{
			}

			[Token(Token = "0x6004F14")]
			[Address(RVA = "0x1790B20", Offset = "0x1790B20", VA = "0x1790B20")]
			public void Cancel()
			{
			}

			[Token(Token = "0x6004F15")]
			[Address(RVA = "0x1790CA4", Offset = "0x1790CA4", VA = "0x1790CA4")]
			private void DrawWindow(int windowId)
			{
			}

			[Token(Token = "0x6004F16")]
			[Address(RVA = "0x1790344", Offset = "0x1790344", VA = "0x1790344")]
			private void UpdateTimers()
			{
			}

			[Token(Token = "0x6004F17")]
			[Address(RVA = "0x1790CFC", Offset = "0x1790CFC", VA = "0x1790CFC")]
			private void StartBusyTimer(float time)
			{
			}

			[Token(Token = "0x6004F18")]
			[Address(RVA = "0x1790C50", Offset = "0x1790C50", VA = "0x1790C50")]
			private void Close()
			{
			}

			[Token(Token = "0x6004F19")]
			[Address(RVA = "0x178FEA0", Offset = "0x178FEA0", VA = "0x178FEA0")]
			private void StateChanged(float delay)
			{
			}

			[Token(Token = "0x6004F1A")]
			[Address(RVA = "0x1790D3C", Offset = "0x1790D3C", VA = "0x1790D3C")]
			private void Reset()
			{
			}

			[Token(Token = "0x6004F1B")]
			[Address(RVA = "0x1790D54", Offset = "0x1790D54", VA = "0x1790D54")]
			private void ResetTimers()
			{
			}

			[Token(Token = "0x6004F1C")]
			[Address(RVA = "0x1790D5C", Offset = "0x1790D5C", VA = "0x1790D5C")]
			public void FullReset()
			{
			}
		}

		[Token(Token = "0x2001155")]
		private abstract class QueueEntry
		{
			[Token(Token = "0x2001156")]
			public enum State
			{
				[Token(Token = "0x4005BAB")]
				Waiting = 0,
				[Token(Token = "0x4005BAC")]
				Confirmed = 1,
				[Token(Token = "0x4005BAD")]
				Canceled = 2
			}

			[Token(Token = "0x4005BA5")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x570FC", Offset = "0x570FC")]
			private int id__BackingField;

			[Token(Token = "0x4005BA6")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5710C", Offset = "0x5710C")]
			private QueueActionType queueActionType__BackingField;

			[Token(Token = "0x4005BA7")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5711C", Offset = "0x5711C")]
			private State state__BackingField;

			[Token(Token = "0x4005BA8")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5712C", Offset = "0x5712C")]
			private UserResponse response__BackingField;

			[Token(Token = "0x4005BA9")]
			[FieldOffset(Offset = "0x0")]
			private static int uidCounter;

			[Token(Token = "0x1700087B")]
			public int id
			{
				[Token(Token = "0x6004F1D")]
				[Address(RVA = "0x1791028", Offset = "0x1791028", VA = "0x1791028")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED8", Offset = "0x6FED8")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F1E")]
				[Address(RVA = "0x1791030", Offset = "0x1791030", VA = "0x1791030")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEE8", Offset = "0x6FEE8")]
				protected set
				{
				}
			}

			[Token(Token = "0x1700087C")]
			public QueueActionType queueActionType
			{
				[Token(Token = "0x6004F1F")]
				[Address(RVA = "0x1791038", Offset = "0x1791038", VA = "0x1791038")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEF8", Offset = "0x6FEF8")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F20")]
				[Address(RVA = "0x1791040", Offset = "0x1791040", VA = "0x1791040")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF08", Offset = "0x6FF08")]
				protected set
				{
				}
			}

			[Token(Token = "0x1700087D")]
			public State state
			{
				[Token(Token = "0x6004F21")]
				[Address(RVA = "0x1791048", Offset = "0x1791048", VA = "0x1791048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF18", Offset = "0x6FF18")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F22")]
				[Address(RVA = "0x1791050", Offset = "0x1791050", VA = "0x1791050")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF28", Offset = "0x6FF28")]
				protected set
				{
				}
			}

			[Token(Token = "0x1700087E")]
			public UserResponse response
			{
				[Token(Token = "0x6004F23")]
				[Address(RVA = "0x1791058", Offset = "0x1791058", VA = "0x1791058")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF38", Offset = "0x6FF38")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F24")]
				[Address(RVA = "0x1791060", Offset = "0x1791060", VA = "0x1791060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF48", Offset = "0x6FF48")]
				protected set
				{
				}
			}

			[Token(Token = "0x1700087F")]
			protected static int nextId
			{
				[Token(Token = "0x6004F25")]
				[Address(RVA = "0x1791068", Offset = "0x1791068", VA = "0x1791068")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6004F26")]
			[Address(RVA = "0x178FD00", Offset = "0x178FD00", VA = "0x178FD00")]
			public QueueEntry(QueueActionType queueActionType)
			{
			}

			[Token(Token = "0x6004F27")]
			[Address(RVA = "0x17910BC", Offset = "0x17910BC", VA = "0x17910BC")]
			public void Confirm(UserResponse response)
			{
			}

			[Token(Token = "0x6004F28")]
			[Address(RVA = "0x17910C8", Offset = "0x17910C8", VA = "0x17910C8")]
			public void Cancel()
			{
			}
		}

		[Token(Token = "0x2001157")]
		private class JoystickAssignmentChange : QueueEntry
		{
			[Token(Token = "0x4005BAE")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5713C", Offset = "0x5713C")]
			private int playerId__BackingField;

			[Token(Token = "0x4005BAF")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5714C", Offset = "0x5714C")]
			private int joystickId__BackingField;

			[Token(Token = "0x4005BB0")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5715C", Offset = "0x5715C")]
			private bool assign__BackingField;

			[Token(Token = "0x17000880")]
			public int playerId
			{
				[Token(Token = "0x6004F29")]
				[Address(RVA = "0x1790F6C", Offset = "0x1790F6C", VA = "0x1790F6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF58", Offset = "0x6FF58")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F2A")]
				[Address(RVA = "0x1790F74", Offset = "0x1790F74", VA = "0x1790F74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF68", Offset = "0x6FF68")]
				private set
				{
				}
			}

			[Token(Token = "0x17000881")]
			public int joystickId
			{
				[Token(Token = "0x6004F2B")]
				[Address(RVA = "0x1790F7C", Offset = "0x1790F7C", VA = "0x1790F7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF78", Offset = "0x6FF78")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F2C")]
				[Address(RVA = "0x1790F84", Offset = "0x1790F84", VA = "0x1790F84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF88", Offset = "0x6FF88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000882")]
			public bool assign
			{
				[Token(Token = "0x6004F2D")]
				[Address(RVA = "0x1790F8C", Offset = "0x1790F8C", VA = "0x1790F8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FF98", Offset = "0x6FF98")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F2E")]
				[Address(RVA = "0x1790F94", Offset = "0x1790F94", VA = "0x1790F94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FFA8", Offset = "0x6FFA8")]
				private set
				{
				}
			}

			[Token(Token = "0x6004F2F")]
			[Address(RVA = "0x1790F9C", Offset = "0x1790F9C", VA = "0x1790F9C")]
			public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
			{
			}
		}

		[Token(Token = "0x2001158")]
		private class ElementAssignmentChange : QueueEntry
		{
			[Token(Token = "0x4005BB1")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5716C", Offset = "0x5716C")]
			private ElementAssignmentChangeType changeType__BackingField;

			[Token(Token = "0x4005BB2")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5717C", Offset = "0x5717C")]
			private InputMapper.Context context__BackingField;

			[Token(Token = "0x17000883")]
			public ElementAssignmentChangeType changeType
			{
				[Token(Token = "0x6004F30")]
				[Address(RVA = "0x1790D78", Offset = "0x1790D78", VA = "0x1790D78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FFB8", Offset = "0x6FFB8")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F31")]
				[Address(RVA = "0x1790D80", Offset = "0x1790D80", VA = "0x1790D80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FFC8", Offset = "0x6FFC8")]
				set
				{
				}
			}

			[Token(Token = "0x17000884")]
			public InputMapper.Context context
			{
				[Token(Token = "0x6004F32")]
				[Address(RVA = "0x1790D88", Offset = "0x1790D88", VA = "0x1790D88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FFD8", Offset = "0x6FFD8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004F33")]
				[Address(RVA = "0x1790D90", Offset = "0x1790D90", VA = "0x1790D90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FFE8", Offset = "0x6FFE8")]
				private set
				{
				}
			}

			[Token(Token = "0x6004F34")]
			[Address(RVA = "0x1790D98", Offset = "0x1790D98", VA = "0x1790D98")]
			public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
			{
			}

			[Token(Token = "0x6004F35")]
			[Address(RVA = "0x1790E20", Offset = "0x1790E20", VA = "0x1790E20")]
			public ElementAssignmentChange(ElementAssignmentChange other)
			{
			}
		}

		[Token(Token = "0x2001159")]
		private class FallbackJoystickIdentification : QueueEntry
		{
			[Token(Token = "0x4005BB3")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5718C", Offset = "0x5718C")]
			private int joystickId__BackingField;

			[Token(Token = "0x4005BB4")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5719C", Offset = "0x5719C")]
			private string joystickName__BackingField;

			[Token(Token = "0x17000885")]
			public int joystickId
			{
				[Token(Token = "0x6004F36")]
				[Address(RVA = "0x1790EC4", Offset = "0x1790EC4", VA = "0x1790EC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FFF8", Offset = "0x6FFF8")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004F37")]
				[Address(RVA = "0x1790ECC", Offset = "0x1790ECC", VA = "0x1790ECC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70008", Offset = "0x70008")]
				private set
				{
				}
			}

			[Token(Token = "0x17000886")]
			public string joystickName
			{
				[Token(Token = "0x6004F38")]
				[Address(RVA = "0x1790ED4", Offset = "0x1790ED4", VA = "0x1790ED4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70018", Offset = "0x70018")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004F39")]
				[Address(RVA = "0x1790EDC", Offset = "0x1790EDC", VA = "0x1790EDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70028", Offset = "0x70028")]
				private set
				{
				}
			}

			[Token(Token = "0x6004F3A")]
			[Address(RVA = "0x1790EE4", Offset = "0x1790EE4", VA = "0x1790EE4")]
			public FallbackJoystickIdentification(int joystickId, string joystickName)
			{
			}
		}

		[Token(Token = "0x200115A")]
		private class Calibration : QueueEntry
		{
			[Token(Token = "0x4005BB5")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x571AC", Offset = "0x571AC")]
			private Player player__BackingField;

			[Token(Token = "0x4005BB6")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x571BC", Offset = "0x571BC")]
			private Joystick joystick__BackingField;

			[Token(Token = "0x4005BB7")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x571CC", Offset = "0x571CC")]
			private CalibrationMap calibrationMap__BackingField;

			[Token(Token = "0x4005BB8")]
			[FieldOffset(Offset = "0x38")]
			public int selectedElementIdentifierId;

			[Token(Token = "0x4005BB9")]
			[FieldOffset(Offset = "0x3C")]
			public bool recording;

			[Token(Token = "0x17000887")]
			private Player player
			{
				[Token(Token = "0x6004F3B")]
				[Address(RVA = "0x178FC44", Offset = "0x178FC44", VA = "0x178FC44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70038", Offset = "0x70038")]
				set
				{
				}
			}

			[Token(Token = "0x17000888")]
			public Joystick joystick
			{
				[Token(Token = "0x6004F3C")]
				[Address(RVA = "0x178FC4C", Offset = "0x178FC4C", VA = "0x178FC4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70048", Offset = "0x70048")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004F3D")]
				[Address(RVA = "0x178FC54", Offset = "0x178FC54", VA = "0x178FC54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70058", Offset = "0x70058")]
				private set
				{
				}
			}

			[Token(Token = "0x17000889")]
			public CalibrationMap calibrationMap
			{
				[Token(Token = "0x6004F3E")]
				[Address(RVA = "0x178FC5C", Offset = "0x178FC5C", VA = "0x178FC5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70068", Offset = "0x70068")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004F3F")]
				[Address(RVA = "0x178FC64", Offset = "0x178FC64", VA = "0x178FC64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70078", Offset = "0x70078")]
				private set
				{
				}
			}

			[Token(Token = "0x6004F40")]
			[Address(RVA = "0x178FC6C", Offset = "0x178FC6C", VA = "0x178FC6C")]
			public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
			{
			}
		}

		[Token(Token = "0x200115B")]
		private struct WindowProperties
		{
			[Token(Token = "0x4005BBA")]
			[FieldOffset(Offset = "0x0")]
			public int windowId;

			[Token(Token = "0x4005BBB")]
			[FieldOffset(Offset = "0x4")]
			public Rect rect;

			[Token(Token = "0x4005BBC")]
			[FieldOffset(Offset = "0x18")]
			public Action<string, string> windowDrawDelegate;

			[Token(Token = "0x4005BBD")]
			[FieldOffset(Offset = "0x20")]
			public string title;

			[Token(Token = "0x4005BBE")]
			[FieldOffset(Offset = "0x28")]
			public string message;
		}

		[Token(Token = "0x200115C")]
		private enum QueueActionType
		{
			[Token(Token = "0x4005BC0")]
			None = 0,
			[Token(Token = "0x4005BC1")]
			JoystickAssignment = 1,
			[Token(Token = "0x4005BC2")]
			ElementAssignment = 2,
			[Token(Token = "0x4005BC3")]
			FallbackJoystickIdentification = 3,
			[Token(Token = "0x4005BC4")]
			Calibrate = 4
		}

		[Token(Token = "0x200115D")]
		private enum ElementAssignmentChangeType
		{
			[Token(Token = "0x4005BC6")]
			Add = 0,
			[Token(Token = "0x4005BC7")]
			Replace = 1,
			[Token(Token = "0x4005BC8")]
			Remove = 2,
			[Token(Token = "0x4005BC9")]
			ReassignOrRemove = 3,
			[Token(Token = "0x4005BCA")]
			ConflictCheck = 4
		}

		[Token(Token = "0x200115E")]
		public enum UserResponse
		{
			[Token(Token = "0x4005BCC")]
			Confirm = 0,
			[Token(Token = "0x4005BCD")]
			Cancel = 1,
			[Token(Token = "0x4005BCE")]
			Custom1 = 2,
			[Token(Token = "0x4005BCF")]
			Custom2 = 3
		}

		[Token(Token = "0x4005B78")]
		private const float defaultModalWidth = 250f;

		[Token(Token = "0x4005B79")]
		private const float defaultModalHeight = 200f;

		[Token(Token = "0x4005B7A")]
		private const float assignmentTimeout = 5f;

		[Token(Token = "0x4005B7B")]
		[FieldOffset(Offset = "0x18")]
		private DialogHelper dialog;

		[Token(Token = "0x4005B7C")]
		[FieldOffset(Offset = "0x20")]
		private InputMapper inputMapper;

		[Token(Token = "0x4005B7D")]
		[FieldOffset(Offset = "0x28")]
		private InputMapper.ConflictFoundEventData conflictFoundEventData;

		[Token(Token = "0x4005B7E")]
		[FieldOffset(Offset = "0x30")]
		private bool guiState;

		[Token(Token = "0x4005B7F")]
		[FieldOffset(Offset = "0x31")]
		private bool busy;

		[Token(Token = "0x4005B80")]
		[FieldOffset(Offset = "0x32")]
		private bool pageGUIState;

		[Token(Token = "0x4005B81")]
		[FieldOffset(Offset = "0x38")]
		private Player selectedPlayer;

		[Token(Token = "0x4005B82")]
		[FieldOffset(Offset = "0x40")]
		private int selectedMapCategoryId;

		[Token(Token = "0x4005B83")]
		[FieldOffset(Offset = "0x48")]
		private ControllerSelection selectedController;

		[Token(Token = "0x4005B84")]
		[FieldOffset(Offset = "0x50")]
		private ControllerMap selectedMap;

		[Token(Token = "0x4005B85")]
		[FieldOffset(Offset = "0x58")]
		private bool showMenu;

		[Token(Token = "0x4005B86")]
		[FieldOffset(Offset = "0x59")]
		private bool startListening;

		[Token(Token = "0x4005B87")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 actionScrollPos;

		[Token(Token = "0x4005B88")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 calibrateScrollPos;

		[Token(Token = "0x4005B89")]
		[FieldOffset(Offset = "0x70")]
		private Queue<QueueEntry> actionQueue;

		[Token(Token = "0x4005B8A")]
		[FieldOffset(Offset = "0x78")]
		private bool setupFinished;

		[NonSerialized]
		[Token(Token = "0x4005B8B")]
		[FieldOffset(Offset = "0x79")]
		private bool initialized;

		[Token(Token = "0x4005B8C")]
		[FieldOffset(Offset = "0x7A")]
		private bool isCompiling;

		[Token(Token = "0x4005B8D")]
		[FieldOffset(Offset = "0x80")]
		private GUIStyle style_wordWrap;

		[Token(Token = "0x4005B8E")]
		[FieldOffset(Offset = "0x88")]
		private GUIStyle style_centeredBox;

		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x18AE3CC", Offset = "0x18AE3CC", VA = "0x18AE3CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0x18AE708", Offset = "0x18AE708", VA = "0x18AE708")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0x18AE83C", Offset = "0x18AE83C", VA = "0x18AE83C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x18AE448", Offset = "0x18AE448", VA = "0x18AE448")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x18AECA0", Offset = "0x18AECA0", VA = "0x18AECA0")]
		private void Setup()
		{
		}

		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x18AE70C", Offset = "0x18AE70C", VA = "0x18AE70C")]
		private void Subscribe()
		{
		}

		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x18AE858", Offset = "0x18AE858", VA = "0x18AE858")]
		private void Unsubscribe()
		{
		}

		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x18AEDBC", Offset = "0x18AEDBC", VA = "0x18AEDBC")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6004ECA")]
		[Address(RVA = "0x18AEE40", Offset = "0x18AEE40", VA = "0x18AEE40")]
		private void HandleMenuControl()
		{
		}

		[Token(Token = "0x6004ECB")]
		[Address(RVA = "0x18AF920", Offset = "0x18AF920", VA = "0x18AF920")]
		private void Close()
		{
		}

		[Token(Token = "0x6004ECC")]
		[Address(RVA = "0x18AF944", Offset = "0x18AF944", VA = "0x18AF944")]
		private void Open()
		{
		}

		[Token(Token = "0x6004ECD")]
		[Address(RVA = "0x18AEFCC", Offset = "0x18AEFCC", VA = "0x18AEFCC")]
		private void DrawInitialScreen()
		{
		}

		[Token(Token = "0x6004ECE")]
		[Address(RVA = "0x18AF5E4", Offset = "0x18AF5E4", VA = "0x18AF5E4")]
		private void DrawPage()
		{
		}

		[Token(Token = "0x6004ECF")]
		[Address(RVA = "0x18AFA7C", Offset = "0x18AFA7C", VA = "0x18AFA7C")]
		private void DrawPlayerSelector()
		{
		}

		[Token(Token = "0x6004ED0")]
		[Address(RVA = "0x18B0A50", Offset = "0x18B0A50", VA = "0x18B0A50")]
		private void DrawMouseAssignment()
		{
		}

		[Token(Token = "0x6004ED1")]
		[Address(RVA = "0x18B01E0", Offset = "0x18B01E0", VA = "0x18B01E0")]
		private void DrawJoystickSelector()
		{
		}

		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x18B1130", Offset = "0x18B1130", VA = "0x18B1130")]
		private void DrawControllerSelector()
		{
		}

		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x18B1ABC", Offset = "0x18B1ABC", VA = "0x18B1ABC")]
		private void DrawCalibrateButton()
		{
		}

		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x18B1E40", Offset = "0x18B1E40", VA = "0x18B1E40")]
		private void DrawMapCategories()
		{
		}

		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x18B26DC", Offset = "0x18B26DC", VA = "0x18B26DC")]
		private void DrawCategoryActions()
		{
		}

		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x18B4258", Offset = "0x18B4258", VA = "0x18B4258")]
		private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
		{
		}

		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x18B4444", Offset = "0x18B4444", VA = "0x18B4444")]
		private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
		{
		}

		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x18B40C0", Offset = "0x18B40C0", VA = "0x18B40C0")]
		private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x18AF850", Offset = "0x18AF850", VA = "0x18AF850")]
		private void ShowDialog()
		{
		}

		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x18B4538", Offset = "0x18B4538", VA = "0x18B4538")]
		private void DrawModalWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x18B4738", Offset = "0x18B4738", VA = "0x18B4738")]
		private void DrawModalWindow_OkayOnly(string title, string message)
		{
		}

		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x18B4920", Offset = "0x18B4920", VA = "0x18B4920")]
		private void DrawElementAssignmentWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x18B4C8C", Offset = "0x18B4C8C", VA = "0x18B4C8C")]
		private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x18B4F18", Offset = "0x18B4F18", VA = "0x18B4F18")]
		private void DrawElementAssignmentNormalConflictWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x18B51D8", Offset = "0x18B51D8", VA = "0x18B51D8")]
		private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x18B53F0", Offset = "0x18B53F0", VA = "0x18B53F0")]
		private void DrawFallbackJoystickIdentificationWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x18B57C4", Offset = "0x18B57C4", VA = "0x18B57C4")]
		private void DrawCalibrationWindow(string title, string message)
		{
		}

		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x18B6B64", Offset = "0x18B6B64", VA = "0x18B6B64")]
		private void DialogResultCallback(int queueActionId, UserResponse response)
		{
		}

		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x18AF9F4", Offset = "0x18AF9F4", VA = "0x18AF9F4")]
		private Rect GetScreenCenteredRect(float width, float height)
		{
			return default;
		}

		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x18B4008", Offset = "0x18B4008", VA = "0x18B4008")]
		private void EnqueueAction(QueueEntry entry)
		{
		}

		[Token(Token = "0x6004EE5")]
		[Address(RVA = "0x18AF35C", Offset = "0x18AF35C", VA = "0x18AF35C")]
		private void ProcessQueue()
		{
		}

		[Token(Token = "0x6004EE6")]
		[Address(RVA = "0x18B6D00", Offset = "0x18B6D00", VA = "0x18B6D00")]
		private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
		{
			return default;
		}

		[Token(Token = "0x6004EE7")]
		[Address(RVA = "0x18B7004", Offset = "0x18B7004", VA = "0x18B7004")]
		private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
		{
			return default;
		}

		[Token(Token = "0x6004EE8")]
		[Address(RVA = "0x18B7520", Offset = "0x18B7520", VA = "0x18B7520")]
		private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
		{
			return default;
		}

		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x18B77D0", Offset = "0x18B77D0", VA = "0x18B77D0")]
		private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
		{
			return default;
		}

		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x18B7A04", Offset = "0x18B7A04", VA = "0x18B7A04")]
		private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
		{
			return default;
		}

		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x18B7D88", Offset = "0x18B7D88", VA = "0x18B7D88")]
		private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
		{
			return default;
		}

		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x18B70DC", Offset = "0x18B70DC", VA = "0x18B70DC")]
		private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
		{
			return default;
		}

		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x18B72E4", Offset = "0x18B72E4", VA = "0x18B72E4")]
		private bool ProcessCalibration(Calibration entry)
		{
			return default;
		}

		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0x18B8140", Offset = "0x18B8140", VA = "0x18B8140")]
		private void PlayerSelectionChanged()
		{
		}

		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0x18B3FF8", Offset = "0x18B3FF8", VA = "0x18B3FF8")]
		private void ControllerSelectionChanged()
		{
		}

		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0x18B817C", Offset = "0x18B817C", VA = "0x18B817C")]
		private void ClearControllerSelection()
		{
		}

		[Token(Token = "0x6004EF1")]
		[Address(RVA = "0x18B81B8", Offset = "0x18B81B8", VA = "0x18B81B8")]
		private void ClearMapSelection()
		{
		}

		[Token(Token = "0x6004EF2")]
		[Address(RVA = "0x18AE874", Offset = "0x18AE874", VA = "0x18AE874")]
		private void ResetAll()
		{
		}

		[Token(Token = "0x6004EF3")]
		[Address(RVA = "0x18AF950", Offset = "0x18AF950", VA = "0x18AF950")]
		private void ClearWorkingVars()
		{
		}

		[Token(Token = "0x6004EF4")]
		[Address(RVA = "0x18AF260", Offset = "0x18AF260", VA = "0x18AF260")]
		private void SetGUIStateStart()
		{
		}

		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x18AF86C", Offset = "0x18AF86C", VA = "0x18AF86C")]
		private void SetGUIStateEnd()
		{
		}

		[Token(Token = "0x6004EF6")]
		[Address(RVA = "0x18B81C8", Offset = "0x18B81C8", VA = "0x18B81C8")]
		private void JoystickConnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004EF7")]
		[Address(RVA = "0x18B8754", Offset = "0x18B8754", VA = "0x18B8754")]
		private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004EF8")]
		[Address(RVA = "0x18B8D0C", Offset = "0x18B8D0C", VA = "0x18B8D0C")]
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004EF9")]
		[Address(RVA = "0x18B8D98", Offset = "0x18B8D98", VA = "0x18B8D98")]
		private void OnConflictFound(InputMapper.ConflictFoundEventData data)
		{
		}

		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x18B8DA0", Offset = "0x18B8DA0", VA = "0x18B8DA0")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x18AE89C", Offset = "0x18AE89C", VA = "0x18AE89C")]
		public void IdentifyAllJoysticks()
		{
		}

		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x18B8DA8", Offset = "0x18B8DA8", VA = "0x18B8DA8")]
		public ControlRemappingDemo1()
		{
		}
	}
}
