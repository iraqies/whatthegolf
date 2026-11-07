using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000133")]
	public static class ReInput
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x190EF0", Offset = "0x190EF0")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x190EF0", Offset = "0x190EF0")]
		public sealed class ConfigHelper : CodeHelper
		{
			[Token(Token = "0x4000738")]
			[FieldOffset(Offset = "0x0")]
			private static ConfigHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			[Token(Token = "0x4000739")]
			[FieldOffset(Offset = "0x10")]
			private float rcFjLisvbvYtJGWpnKEYgFUHqZfd;

			[Token(Token = "0x400073A")]
			[FieldOffset(Offset = "0x14")]
			private float UJqtCyevQhANodQxANgKNPSQEzWI;

			[Token(Token = "0x170002E7")]
			internal static ConfigHelper izfChqvjKyhCcypSioMPzwuCmhEV
			{
				[Token(Token = "0x60009D5")]
				[Address(RVA = "0x238F2B4", Offset = "0x238F2B4", VA = "0x238F2B4")]
				get
				{
					return nSDedHgxFmfKpDQgiatnprpCjsRjB();
				}
			}

			[Token(Token = "0x170002E8")]
			public bool alwaysUseUnityInput
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0x238F350", Offset = "0x238F350", VA = "0x238F350")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002E9")]
			public bool disableNativeInput
			{
				[Token(Token = "0x60009D8")]
				[Address(RVA = "0x238F3F8", Offset = "0x238F3F8", VA = "0x238F3F8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002EA")]
			public bool ignoreInputWhenAppNotInFocus
			{
				[Token(Token = "0x60009D9")]
				[Address(RVA = "0x238F3FC", Offset = "0x238F3FC", VA = "0x238F3FC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002EB")]
			public float defaultAbsoluteAxisPollingDeadZone
			{
				[Token(Token = "0x60009DA")]
				[Address(RVA = "0x238F4A4", Offset = "0x238F4A4", VA = "0x238F4A4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002EC")]
			public float defaultRelativeAxisPollingDeadZone
			{
				[Token(Token = "0x60009DB")]
				[Address(RVA = "0x238F528", Offset = "0x238F528", VA = "0x238F528")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002ED")]
			public bool autoAssignJoysticks
			{
				[Token(Token = "0x60009DC")]
				[Address(RVA = "0x238F5A8", Offset = "0x238F5A8", VA = "0x238F5A8")]
				get
				{
					return default;
				}
				[Token(Token = "0x60009DD")]
				[Address(RVA = "0x238F650", Offset = "0x238F650", VA = "0x238F650")]
				set
				{
				}
			}

			[Token(Token = "0x170002EE")]
			public int maxJoysticksPerPlayer
			{
				[Token(Token = "0x60009DE")]
				[Address(RVA = "0x238F730", Offset = "0x238F730", VA = "0x238F730")]
				set
				{
				}
			}

			[Token(Token = "0x170002EF")]
			public bool distributeJoysticksEvenly
			{
				[Token(Token = "0x60009DF")]
				[Address(RVA = "0x238F818", Offset = "0x238F818", VA = "0x238F818")]
				set
				{
				}
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x238F2B4", Offset = "0x238F2B4", VA = "0x238F2B4")]
			internal static ConfigHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x238F338", Offset = "0x238F338", VA = "0x238F338")]
			private ConfigHelper()
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x190F30", Offset = "0x190F30")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x190F30", Offset = "0x190F30")]
		public sealed class ControllerHelper : CodeHelper
		{
			[Token(Token = "0x2000136")]
			[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x190F70", Offset = "0x190F70")]
			[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x190F70", Offset = "0x190F70")]
			public sealed class PollingHelper : CodeHelper
			{
				[Token(Token = "0x400073E")]
				[FieldOffset(Offset = "0x0")]
				private static PollingHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

				[Token(Token = "0x170002F8")]
				internal static PollingHelper izfChqvjKyhCcypSioMPzwuCmhEV
				{
					[Token(Token = "0x6000A00")]
					[Address(RVA = "0x23BF810", Offset = "0x23BF810", VA = "0x23BF810")]
					get
					{
						return nSDedHgxFmfKpDQgiatnprpCjsRjB();
					}
				}

				[Token(Token = "0x6000A00")]
				[Address(RVA = "0x23BF810", Offset = "0x23BF810", VA = "0x23BF810")]
				internal static PollingHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
				{
					return null;
				}

				[Token(Token = "0x6000A01")]
				[Address(RVA = "0x23BF884", Offset = "0x23BF884", VA = "0x23BF884")]
				private PollingHelper()
				{
				}

				[Token(Token = "0x6000A02")]
				[Address(RVA = "0x23BF88C", Offset = "0x23BF88C", VA = "0x23BF88C")]
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				[Token(Token = "0x6000A03")]
				[Address(RVA = "0x23BFBA8", Offset = "0x23BFBA8", VA = "0x23BFBA8")]
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				[Token(Token = "0x6000A04")]
				[Address(RVA = "0x23BFE94", Offset = "0x23BFE94", VA = "0x23BFE94")]
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x23BF9FC", Offset = "0x23BF9FC", VA = "0x23BF9FC")]
				private IEnumerable<ControllerPollingInfo> uASjJkZZigXWClPGrxYXTWuYytCB(int P_0)
				{
					return null;
				}

				[Token(Token = "0x6000A06")]
				[Address(RVA = "0x23BFD18", Offset = "0x23BFD18", VA = "0x23BFD18")]
				private IEnumerable<ControllerPollingInfo> vrICuQWYoOrlhALPFYnIOpJlEyPk(int P_0)
				{
					return null;
				}

				[Token(Token = "0x6000A07")]
				[Address(RVA = "0x23C0024", Offset = "0x23C0024", VA = "0x23C0024")]
				private IEnumerable<ControllerPollingInfo> poJGVDxjXbhXycFeIsdyHsoedsCYA(int P_0)
				{
					return null;
				}

				[Token(Token = "0x6000A08")]
				[Address(RVA = "0x23BFAA0", Offset = "0x23BFAA0", VA = "0x23BFAA0")]
				private IEnumerable<ControllerPollingInfo> nTOaOzAizIVxHePeOnxkRHlAxAWS()
				{
					return null;
				}

				[Token(Token = "0x6000A09")]
				[Address(RVA = "0x23BFAD0", Offset = "0x23BFAD0", VA = "0x23BFAD0")]
				private IEnumerable<ControllerPollingInfo> cLPDCRhyqgMmkTmpLiLNnnreryrD()
				{
					return null;
				}

				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0x23BFDBC", Offset = "0x23BFDBC", VA = "0x23BFDBC")]
				private IEnumerable<ControllerPollingInfo> vjoctRbePlNRDLebnEgMQAlXsvCEA()
				{
					return null;
				}

				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x23C00C4", Offset = "0x23C00C4", VA = "0x23C00C4")]
				private IEnumerable<ControllerPollingInfo> xLpJNhMMqKQpDjLnVPCaMhTCFhvDA()
				{
					return null;
				}

				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0x23BFB04", Offset = "0x23BFB04", VA = "0x23BFB04")]
				private IEnumerable<ControllerPollingInfo> uStEnMWAjtgNoCXbEUVvdQyxXPXSA(int P_0)
				{
					return null;
				}

				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0x23BFDF0", Offset = "0x23BFDF0", VA = "0x23BFDF0")]
				private IEnumerable<ControllerPollingInfo> vdQAqndUFXikgRdontniOExbHDlBA(int P_0)
				{
					return null;
				}

				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0x23C00F4", Offset = "0x23C00F4", VA = "0x23C00F4")]
				private IEnumerable<ControllerPollingInfo> utngrPJaCAzrAjFBBjQiFNhEtvAib(int P_0)
				{
					return null;
				}
			}

			[Token(Token = "0x2000137")]
			[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x190FB0", Offset = "0x190FB0")]
			[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x190FB0", Offset = "0x190FB0")]
			public sealed class ConflictCheckingHelper : CodeHelper
			{
				[Token(Token = "0x400073F")]
				[FieldOffset(Offset = "0x0")]
				private static ConflictCheckingHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

				[Token(Token = "0x170002F9")]
				internal static ConflictCheckingHelper izfChqvjKyhCcypSioMPzwuCmhEV
				{
					[Token(Token = "0x6000A0F")]
					[Address(RVA = "0x23BF794", Offset = "0x23BF794", VA = "0x23BF794")]
					get
					{
						return nSDedHgxFmfKpDQgiatnprpCjsRjB();
					}
				}

				[Token(Token = "0x6000A0F")]
				[Address(RVA = "0x23BF794", Offset = "0x23BF794", VA = "0x23BF794")]
				internal static ConflictCheckingHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
				{
					return null;
				}

				[Token(Token = "0x6000A10")]
				[Address(RVA = "0x23BF808", Offset = "0x23BF808", VA = "0x23BF808")]
				private ConflictCheckingHelper()
				{
				}
			}

			[Token(Token = "0x400073B")]
			[FieldOffset(Offset = "0x0")]
			private static ControllerHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			[Token(Token = "0x400073C")]
			[FieldOffset(Offset = "0x10")]
			public readonly PollingHelper polling;

			[Token(Token = "0x400073D")]
			[FieldOffset(Offset = "0x18")]
			public readonly ConflictCheckingHelper conflictChecking;

			[Token(Token = "0x170002F0")]
			internal static ControllerHelper izfChqvjKyhCcypSioMPzwuCmhEV
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x238F8F8", Offset = "0x238F8F8", VA = "0x238F8F8")]
				get
				{
					return nSDedHgxFmfKpDQgiatnprpCjsRjB();
				}
			}

			[Token(Token = "0x170002F1")]
			public IList<Controller> Controllers
			{
				[Token(Token = "0x60009E2")]
				[Address(RVA = "0x238F9C4", Offset = "0x238F9C4", VA = "0x238F9C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002F2")]
			public Mouse Mouse
			{
				[Token(Token = "0x60009E8")]
				[Address(RVA = "0x238FE68", Offset = "0x238FE68", VA = "0x238FE68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002F3")]
			public Keyboard Keyboard
			{
				[Token(Token = "0x60009E9")]
				[Address(RVA = "0x238FF04", Offset = "0x238FF04", VA = "0x238FF04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002F4")]
			public int joystickCount
			{
				[Token(Token = "0x60009EA")]
				[Address(RVA = "0x238FFA0", Offset = "0x238FFA0", VA = "0x238FFA0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002F5")]
			public IList<Joystick> Joysticks
			{
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0x2390040", Offset = "0x2390040", VA = "0x2390040")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002F6")]
			public int customControllerCount
			{
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x2390848", Offset = "0x2390848", VA = "0x2390848")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170002F7")]
			public IList<CustomController> CustomControllers
			{
				[Token(Token = "0x60009F6")]
				[Address(RVA = "0x23908E8", Offset = "0x23908E8", VA = "0x23908E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x238F8F8", Offset = "0x238F8F8", VA = "0x238F8F8")]
			internal static ControllerHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x238F988", Offset = "0x238F988", VA = "0x238F988")]
			private ControllerHelper()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x238FA7C", Offset = "0x238FA7C", VA = "0x238FA7C")]
			public Controller GetController(ControllerType controllerType, int controllerId)
			{
				return null;
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x238FB40", Offset = "0x238FB40", VA = "0x238FB40")]
			public Controller GetController(ControllerIdentifier controllerIdentifier)
			{
				return null;
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x238FC0C", Offset = "0x238FC0C", VA = "0x238FC0C")]
			public bool IsControllerAssigned(ControllerType controllerType, int controllerId)
			{
				return default;
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x238FCC8", Offset = "0x238FCC8", VA = "0x238FCC8")]
			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId)
			{
				return default;
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x238FD98", Offset = "0x238FD98", VA = "0x238FD98")]
			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true)
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x23900F8", Offset = "0x23900F8", VA = "0x23900F8")]
			public Joystick GetJoystick(int joystickId)
			{
				return null;
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x23901B4", Offset = "0x23901B4", VA = "0x23901B4")]
			public Joystick[] GetJoysticks()
			{
				return null;
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x2390224", Offset = "0x2390224", VA = "0x2390224")]
			public bool IsJoystickAssigned(Joystick joystick)
			{
				return default;
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x23902D8", Offset = "0x23902D8", VA = "0x23902D8")]
			public bool IsJoystickAssigned(int joystickId)
			{
				return default;
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x239038C", Offset = "0x239038C", VA = "0x239038C")]
			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId)
			{
				return default;
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x2390448", Offset = "0x2390448", VA = "0x2390448")]
			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true)
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x2390504", Offset = "0x2390504", VA = "0x2390504")]
			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly)
			{
				return default;
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x2390698", Offset = "0x2390698", VA = "0x2390698")]
			public void SetUnityJoystickId(int joystickId, int unityJoystickId)
			{
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x23907AC", Offset = "0x23907AC", VA = "0x23907AC")]
			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly)
			{
				return default;
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x23909A0", Offset = "0x23909A0", VA = "0x23909A0")]
			public CustomController GetCustomController(int customControllerId)
			{
				return null;
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x2390A58", Offset = "0x2390A58", VA = "0x2390A58")]
			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId)
			{
				return default;
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x2390B14", Offset = "0x2390B14", VA = "0x2390B14")]
			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true)
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x2390BD0", Offset = "0x2390BD0", VA = "0x2390BD0")]
			public CustomController CreateCustomController(int sourceControllerId)
			{
				return null;
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x2390C88", Offset = "0x2390C88", VA = "0x2390C88")]
			public bool DestroyCustomController(CustomController customController)
			{
				return default;
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x2390D50", Offset = "0x2390D50", VA = "0x2390D50")]
			public Controller GetLastActiveController(ControllerType controllerType)
			{
				return null;
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x2390E08", Offset = "0x2390E08", VA = "0x2390E08")]
			public ControllerType GetLastActiveControllerType()
			{
				return default;
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x2390EA8", Offset = "0x2390EA8", VA = "0x2390EA8")]
			public bool AutoAssignJoystick(Joystick joystick)
			{
				return default;
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x2390F80", Offset = "0x2390F80", VA = "0x2390F80")]
			public void AutoAssignJoysticks()
			{
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x190FF0", Offset = "0x190FF0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x190FF0", Offset = "0x190FF0")]
		public sealed class MappingHelper : CodeHelper
		{
			[Token(Token = "0x4000740")]
			[FieldOffset(Offset = "0x0")]
			private static MappingHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			[Token(Token = "0x170002FA")]
			internal static MappingHelper izfChqvjKyhCcypSioMPzwuCmhEV
			{
				[Token(Token = "0x6000A11")]
				[Address(RVA = "0x23910AC", Offset = "0x23910AC", VA = "0x23910AC")]
				get
				{
					return nSDedHgxFmfKpDQgiatnprpCjsRjB();
				}
			}

			[Token(Token = "0x170002FB")]
			public IList<InputMapCategory> MapCategories
			{
				[Token(Token = "0x6000A13")]
				[Address(RVA = "0x2391128", Offset = "0x2391128", VA = "0x2391128")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002FC")]
			public IEnumerable<InputMapCategory> UserAssignableMapCategories
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x2391350", Offset = "0x2391350", VA = "0x2391350")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002FD")]
			public IList<InputCategory> ActionCategories
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x23914C0", Offset = "0x23914C0", VA = "0x23914C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002FE")]
			public IList<InputLayout> JoystickLayouts
			{
				[Token(Token = "0x6000A1C")]
				[Address(RVA = "0x2391A4C", Offset = "0x2391A4C", VA = "0x2391A4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002FF")]
			public IList<InputLayout> KeyboardLayouts
			{
				[Token(Token = "0x6000A1D")]
				[Address(RVA = "0x2391B04", Offset = "0x2391B04", VA = "0x2391B04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000300")]
			public IList<InputLayout> MouseLayouts
			{
				[Token(Token = "0x6000A1E")]
				[Address(RVA = "0x2391BBC", Offset = "0x2391BBC", VA = "0x2391BBC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000301")]
			public IList<InputLayout> CustomControllerLayouts
			{
				[Token(Token = "0x6000A1F")]
				[Address(RVA = "0x2391C74", Offset = "0x2391C74", VA = "0x2391C74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000302")]
			public IList<InputAction> Actions
			{
				[Token(Token = "0x6000A20")]
				[Address(RVA = "0x2391D2C", Offset = "0x2391D2C", VA = "0x2391D2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x23910AC", Offset = "0x23910AC", VA = "0x23910AC")]
			internal static MappingHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x2391120", Offset = "0x2391120", VA = "0x2391120")]
			private MappingHelper()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x23911E0", Offset = "0x23911E0", VA = "0x23911E0")]
			public InputMapCategory GetMapCategory(int mapCategoryId)
			{
				return null;
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x2391298", Offset = "0x2391298", VA = "0x2391298")]
			public int GetMapCategoryId(string name)
			{
				return default;
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x2391408", Offset = "0x2391408", VA = "0x2391408")]
			public InputCategory GetActionCategory(string name)
			{
				return null;
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x2391578", Offset = "0x2391578", VA = "0x2391578")]
			public InputLayout GetLayout(ControllerType controllerType, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x2391750", Offset = "0x2391750", VA = "0x2391750")]
			public int GetLayoutId(ControllerType controllerType, string name)
			{
				return default;
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x2391928", Offset = "0x2391928", VA = "0x2391928")]
			public IList<InputLayout> MapLayouts(ControllerType controllerType)
			{
				return null;
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x2391DE4", Offset = "0x2391DE4", VA = "0x2391DE4")]
			public InputAction GetAction(int actionId)
			{
				return null;
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x238C954", Offset = "0x238C954", VA = "0x238C954")]
			public InputAction GetAction(string name)
			{
				return null;
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x2391E9C", Offset = "0x2391E9C", VA = "0x2391E9C")]
			public int GetActionId(string name)
			{
				return default;
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x2391F54", Offset = "0x2391F54", VA = "0x2391F54")]
			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName)
			{
				return null;
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x2392024", Offset = "0x2392024", VA = "0x2392024")]
			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId)
			{
				return null;
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x23920F4", Offset = "0x23920F4", VA = "0x23920F4")]
			public IList<InputBehavior> GetInputBehaviors(int playerId)
			{
				return null;
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x23921C0", Offset = "0x23921C0", VA = "0x23921C0")]
			public InputBehavior GetInputBehavior(int playerId, int behaviorId)
			{
				return null;
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x2392280", Offset = "0x2392280", VA = "0x2392280")]
			internal InputBehavior kRhNFszrrvRsbYXXXIXgWSMseAZb(int P_0)
			{
				return null;
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x2392308", Offset = "0x2392308", VA = "0x2392308")]
			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x2392900", Offset = "0x2392900", VA = "0x2392900")]
			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x23924F8", Offset = "0x23924F8", VA = "0x23924F8")]
			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x2393088", Offset = "0x2393088", VA = "0x2393088")]
			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x2392AD4", Offset = "0x2392AD4", VA = "0x2392AD4")]
			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x23925E4", Offset = "0x23925E4", VA = "0x23925E4")]
			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x23926FC", Offset = "0x23926FC", VA = "0x23926FC")]
			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x2392814", Offset = "0x2392814", VA = "0x2392814")]
			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x2392C2C", Offset = "0x2392C2C", VA = "0x2392C2C")]
			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x2393524", Offset = "0x2393524", VA = "0x2393524")]
			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id)
			{
				return null;
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x23935E8", Offset = "0x23935E8", VA = "0x23935E8")]
			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id)
			{
				return null;
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191030", Offset = "0x191030")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191030", Offset = "0x191030")]
		public sealed class PlayerHelper : CodeHelper
		{
			[Token(Token = "0x4000741")]
			[FieldOffset(Offset = "0x0")]
			private static PlayerHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			[Token(Token = "0x17000303")]
			internal static PlayerHelper izfChqvjKyhCcypSioMPzwuCmhEV
			{
				[Token(Token = "0x6000A34")]
				[Address(RVA = "0x2394118", Offset = "0x2394118", VA = "0x2394118")]
				get
				{
					return nSDedHgxFmfKpDQgiatnprpCjsRjB();
				}
			}

			[Token(Token = "0x17000304")]
			public int playerCount
			{
				[Token(Token = "0x6000A36")]
				[Address(RVA = "0x2394194", Offset = "0x2394194", VA = "0x2394194")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000305")]
			public int allPlayerCount
			{
				[Token(Token = "0x6000A37")]
				[Address(RVA = "0x2394228", Offset = "0x2394228", VA = "0x2394228")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000306")]
			public IList<Player> Players
			{
				[Token(Token = "0x6000A38")]
				[Address(RVA = "0x23942BC", Offset = "0x23942BC", VA = "0x23942BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000307")]
			public IList<Player> AllPlayers
			{
				[Token(Token = "0x6000A39")]
				[Address(RVA = "0x2394374", Offset = "0x2394374", VA = "0x2394374")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000308")]
			public Player SystemPlayer
			{
				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0x239442C", Offset = "0x239442C", VA = "0x239442C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x2394118", Offset = "0x2394118", VA = "0x2394118")]
			internal static PlayerHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x239418C", Offset = "0x239418C", VA = "0x239418C")]
			private PlayerHelper()
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x23944C8", Offset = "0x23944C8", VA = "0x23944C8")]
			public IList<Player> GetPlayers(bool includeSystemPlayer = false)
			{
				return null;
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x238C510", Offset = "0x238C510", VA = "0x238C510")]
			public Player GetPlayer(int playerId)
			{
				return null;
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x23945BC", Offset = "0x23945BC", VA = "0x23945BC")]
			public Player GetSystemPlayer()
			{
				return null;
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191070", Offset = "0x191070")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x191070", Offset = "0x191070")]
		public sealed class TimeHelper : CodeHelper
		{
			[Token(Token = "0x4000742")]
			[FieldOffset(Offset = "0x0")]
			private static TimeHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			[Token(Token = "0x17000309")]
			internal static TimeHelper izfChqvjKyhCcypSioMPzwuCmhEV
			{
				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0x2394658", Offset = "0x2394658", VA = "0x2394658")]
				get
				{
					return nSDedHgxFmfKpDQgiatnprpCjsRjB();
				}
			}

			[Token(Token = "0x1700030A")]
			public double unscaledTime
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x23946D4", Offset = "0x23946D4", VA = "0x23946D4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700030B")]
			public uint currentFrame
			{
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0x2394790", Offset = "0x2394790", VA = "0x2394790")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x2394658", Offset = "0x2394658", VA = "0x2394658")]
			internal static TimeHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x23946CC", Offset = "0x23946CC", VA = "0x23946CC")]
			private TimeHelper()
			{
			}
		}

		[Token(Token = "0x200013B")]
		private class hZoSIeiGQlsNpxKnhkskatxNwdZA
		{
			[Token(Token = "0x200013C")]
			private class kDKEfdfOLDciMiJECUQyUkOtQTwpB
			{
				[Token(Token = "0x4000748")]
				[FieldOffset(Offset = "0x10")]
				public readonly UpdateLoopType PiEdbgjMHSsksYjRKSGckYZEsfAE;

				[Token(Token = "0x4000749")]
				[FieldOffset(Offset = "0x18")]
				private double FcWClUEYqCkONndVVYEPBiKEVBNB;

				[Token(Token = "0x400074A")]
				[FieldOffset(Offset = "0x20")]
				private double XZOBJpCdOwBGkZIyBYDcVtUfFFWmA;

				[Token(Token = "0x400074B")]
				[FieldOffset(Offset = "0x28")]
				private double wZXFAliRaxWJujhJCKLDQTOTYZoc;

				[Token(Token = "0x400074C")]
				[FieldOffset(Offset = "0x30")]
				private double NOBBHpOgmrCDwBpMuddlsRhuNmMRA;

				[Token(Token = "0x400074D")]
				[FieldOffset(Offset = "0x38")]
				private uint NCglwbjCeCDmrtawbrrpCSJyjfSA;

				[Token(Token = "0x400074E")]
				[FieldOffset(Offset = "0x3C")]
				private uint UivYnXQnUJuOgczaZBaIEfHvkPAJ;

				[Token(Token = "0x400074F")]
				[FieldOffset(Offset = "0x40")]
				private float dJqdUrXrkApZXanEYjNoMExGczlc;

				[Token(Token = "0x4000750")]
				[FieldOffset(Offset = "0x44")]
				private float YoGxJgYUpoJzBxiNAHVJzSahzkLj;

				[Token(Token = "0x1700030F")]
				public double BHafZFWbiZCkNYpfoeSagMhWvnNK
				{
					[Token(Token = "0x6000A49")]
					[Address(RVA = "0x23C03F0", Offset = "0x23C03F0", VA = "0x23C03F0")]
					get
					{
						return paLHovbBGDAzINmOeqjeVKpQPUvMA();
					}
				}

				[Token(Token = "0x17000310")]
				public uint XhKxIzDXGwEJghbHIgWHJwLzJsmD
				{
					[Token(Token = "0x6000A4A")]
					[Address(RVA = "0x23C03F8", Offset = "0x23C03F8", VA = "0x23C03F8")]
					get
					{
						return XzWjlvfKKBjVkBrgjxpnmKyuPikL();
					}
				}

				[Token(Token = "0x6000A49")]
				[Address(RVA = "0x23C03F0", Offset = "0x23C03F0", VA = "0x23C03F0")]
				public double paLHovbBGDAzINmOeqjeVKpQPUvMA()
				{
					return default;
				}

				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x23C03F8", Offset = "0x23C03F8", VA = "0x23C03F8")]
				public uint XzWjlvfKKBjVkBrgjxpnmKyuPikL()
				{
					return default;
				}

				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x23C0400", Offset = "0x23C0400", VA = "0x23C0400")]
				public kDKEfdfOLDciMiJECUQyUkOtQTwpB(UpdateLoopType P_0)
				{
				}

				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x23C0440", Offset = "0x23C0440", VA = "0x23C0440")]
				public void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
				{
				}
			}

			[Token(Token = "0x200013D")]
			private static class TbDNSGwIxLAfdqScpHJWJUvftbIQ
			{
				[Token(Token = "0x17000311")]
				public static StopwatchBase xalFtCqNqSQGgJNyNzskdnWqkjIL
				{
					[Token(Token = "0x6000A4D")]
					[Address(RVA = "0x23C031C", Offset = "0x23C031C", VA = "0x23C031C")]
					get
					{
						return VWMySbJZveqUtZOagnGEriQqNsDO();
					}
				}

				[Token(Token = "0x6000A4D")]
				[Address(RVA = "0x23C031C", Offset = "0x23C031C", VA = "0x23C031C")]
				public static StopwatchBase VWMySbJZveqUtZOagnGEriQqNsDO()
				{
					return null;
				}
			}

			[Token(Token = "0x4000743")]
			[FieldOffset(Offset = "0x10")]
			private StopwatchBase hArdDerumcBRzshORbjwoKPaIhvm;

			[Token(Token = "0x4000744")]
			[FieldOffset(Offset = "0x18")]
			private double aEQkUBDfXMggCpBhlrKNfYCKOQFK;

			[Token(Token = "0x4000745")]
			[FieldOffset(Offset = "0x20")]
			private kDKEfdfOLDciMiJECUQyUkOtQTwpB GIGZxQvhKXDENIiOdEmKJcLFFHANA;

			[Token(Token = "0x4000746")]
			[FieldOffset(Offset = "0x28")]
			private ADictionary<int, kDKEfdfOLDciMiJECUQyUkOtQTwpB> fsZiqIxBodMcuysspsefSOuHjyKt;

			[Token(Token = "0x4000747")]
			[FieldOffset(Offset = "0x30")]
			private uint AWyHCOmvqqiSaSAbNuHstXbiGTmf;

			[Token(Token = "0x1700030C")]
			public double BHafZFWbiZCkNYpfoeSagMhWvnNK
			{
				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x2394774", Offset = "0x2394774", VA = "0x2394774")]
				get
				{
					return paLHovbBGDAzINmOeqjeVKpQPUvMA();
				}
			}

			[Token(Token = "0x1700030D")]
			internal double wEeKniBOCFcwArpfmZhOqVuhQdhP
			{
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x2394EB8", Offset = "0x2394EB8", VA = "0x2394EB8")]
				get
				{
					return xaraaObeWBpecprFjrnJQQNNpPaJA();
				}
			}

			[Token(Token = "0x1700030E")]
			public uint XhKxIzDXGwEJghbHIgWHJwLzJsmD
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x239482C", Offset = "0x239482C", VA = "0x239482C")]
				get
				{
					return XzWjlvfKKBjVkBrgjxpnmKyuPikL();
				}
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x2394774", Offset = "0x2394774", VA = "0x2394774")]
			public double paLHovbBGDAzINmOeqjeVKpQPUvMA()
			{
				return default;
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x2394EB8", Offset = "0x2394EB8", VA = "0x2394EB8")]
			internal double xaraaObeWBpecprFjrnJQQNNpPaJA()
			{
				return default;
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x239482C", Offset = "0x239482C", VA = "0x239482C")]
			public uint XzWjlvfKKBjVkBrgjxpnmKyuPikL()
			{
				return default;
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x2394EF4", Offset = "0x2394EF4", VA = "0x2394EF4")]
			public hZoSIeiGQlsNpxKnhkskatxNwdZA()
			{
			}

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x2395228", Offset = "0x2395228", VA = "0x2395228")]
			public void rZuOrpWYhhCfBPmUsQdcUinbQbVD()
			{
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x2394F28", Offset = "0x2394F28", VA = "0x2394F28")]
			public void jpwugzufXqktYbXkMYboQpqCbQgL()
			{
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x2395254", Offset = "0x2395254", VA = "0x2395254")]
			public void jRaYtHNVcykNMAbqOnSGaKIIGSEaA(UpdateLoopType P_0)
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1910B0", Offset = "0x1910B0")]
		[AttributeAttribute(Name = "BrowsableAttribute", RVA = "0x1910B0", Offset = "0x1910B0")]
		public sealed class UnityTouch : CodeHelper
		{
			[Token(Token = "0x4000751")]
			[FieldOffset(Offset = "0x0")]
			private static UnityTouch LDnMtBpByMhNcmNpPzdzLRPijZRi;

			[Token(Token = "0x17000312")]
			internal static UnityTouch izfChqvjKyhCcypSioMPzwuCmhEV
			{
				[Token(Token = "0x6000A4E")]
				[Address(RVA = "0x2394848", Offset = "0x2394848", VA = "0x2394848")]
				get
				{
					return nSDedHgxFmfKpDQgiatnprpCjsRjB();
				}
			}

			[Token(Token = "0x17000313")]
			public int touchCount
			{
				[Token(Token = "0x6000A50")]
				[Address(RVA = "0x23948C4", Offset = "0x23948C4", VA = "0x23948C4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x2394848", Offset = "0x2394848", VA = "0x2394848")]
			internal static UnityTouch nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x23948BC", Offset = "0x23948BC", VA = "0x23948BC")]
			private UnityTouch()
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x23948CC", Offset = "0x23948CC", VA = "0x23948CC")]
			public Touch GetTouch(int index)
			{
				return default;
			}
		}

		[Token(Token = "0x200013F")]
		internal class MqUEZjlwiIeKTuXxUzFWBUliKyLL
		{
			[Serializable]
			[Token(Token = "0x2000140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1910F0", Offset = "0x1910F0")]
			private sealed class yNqIGGPBgoDiQbHyTmBpJcgluJfsA
			{
				[Token(Token = "0x400075B")]
				[FieldOffset(Offset = "0x0")]
				public static readonly yNqIGGPBgoDiQbHyTmBpJcgluJfsA _003C_003E9;

				[Token(Token = "0x400075C")]
				[FieldOffset(Offset = "0x8")]
				public static Func<bool> _003C_003E9__11_1;

				[Token(Token = "0x400075D")]
				[FieldOffset(Offset = "0x10")]
				public static Func<bool> _003C_003E9__11_2;

				[Token(Token = "0x400075E")]
				[FieldOffset(Offset = "0x18")]
				public static Func<int> _003C_003E9__11_3;

				[Token(Token = "0x400075F")]
				[FieldOffset(Offset = "0x20")]
				public static Func<float> _003C_003E9__11_4;

				[Token(Token = "0x4000760")]
				[FieldOffset(Offset = "0x28")]
				public static Func<bool> _003C_003E9__11_5;

				[Token(Token = "0x4000761")]
				[FieldOffset(Offset = "0x30")]
				public static Func<string> _003C_003E9__11_0;

				[Token(Token = "0x6000A57")]
				[Address(RVA = "0x23C01F4", Offset = "0x23C01F4", VA = "0x23C01F4")]
				public yNqIGGPBgoDiQbHyTmBpJcgluJfsA()
				{
				}

				[Token(Token = "0x6000A58")]
				[Address(RVA = "0x23C01FC", Offset = "0x23C01FC", VA = "0x23C01FC")]
				internal bool tWDswhYAvBqHImkNJdYGpAwokPVM()
				{
					return default;
				}

				[Token(Token = "0x6000A59")]
				[Address(RVA = "0x23C0204", Offset = "0x23C0204", VA = "0x23C0204")]
				internal bool LBgFBZQrZLQqglpncuFkjnZgRpSO()
				{
					return default;
				}

				[Token(Token = "0x6000A5A")]
				[Address(RVA = "0x23C020C", Offset = "0x23C020C", VA = "0x23C020C")]
				internal int pNTdosrvgmmgqqQIYuBZbWKKoCpj()
				{
					return default;
				}

				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0x23C0214", Offset = "0x23C0214", VA = "0x23C0214")]
				internal float AElOJWFyoEskqxqdgUiyBMRpImTB()
				{
					return default;
				}

				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x23C021C", Offset = "0x23C021C", VA = "0x23C021C")]
				internal bool IBnfeLEHNkAMvGXwOccFPpbKfgwiA()
				{
					return default;
				}

				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0x23C0238", Offset = "0x23C0238", VA = "0x23C0238")]
				internal string fqfnoFdSaoYewLmeTldQXFozeXiq()
				{
					return null;
				}
			}

			[Token(Token = "0x4000752")]
			[FieldOffset(Offset = "0x10")]
			public readonly ValueWatcher<bool> UZYSHsTJwyaEEFondgqwlzyMavdk;

			[Token(Token = "0x4000753")]
			[FieldOffset(Offset = "0x18")]
			public readonly ValueWatcher<bool> KYiOUlwMqmWUeZyXbFwxCXGMMnDJ;

			[Token(Token = "0x4000754")]
			[FieldOffset(Offset = "0x20")]
			public readonly ValueWatcher<bool> vbOhiocIcDPNMFSYkWDgYncMpduHA;

			[Token(Token = "0x4000755")]
			[FieldOffset(Offset = "0x28")]
			public readonly ValueWatcher<int> bYcrVqtLPhbPOoKrkaPlbHEWjLygb;

			[Token(Token = "0x4000756")]
			[FieldOffset(Offset = "0x30")]
			public readonly ValueWatcher<float> qDnfJdfXrGdKIjhGHpBGIytaTokcE;

			[Token(Token = "0x4000757")]
			[FieldOffset(Offset = "0x38")]
			public readonly ValueWatcher<string> CRuRampAWykoWdPZeqkFGVaRdTjs;

			[Token(Token = "0x4000758")]
			[FieldOffset(Offset = "0x40")]
			public readonly ValueWatcher<bool> mYuWjVGPwctxkGRqeqjMVZiXqUQ;

			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0x48")]
			private int LqefkSWyanwezQfUHigehUsVcaio;

			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x50")]
			private readonly ValueWatcher[] YCSshVVGDwHfgBfrWXhtGsZExlIu;

			[Token(Token = "0x17000314")]
			public int gOuDkZUQNKJvrYshgNhmDOkegsQi
			{
				[Token(Token = "0x6000A52")]
				[Address(RVA = "0x23936AC", Offset = "0x23936AC", VA = "0x23936AC")]
				get
				{
					return oELcJhtWFBzYOFupnonVTYfbvyzN();
				}
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x23936AC", Offset = "0x23936AC", VA = "0x23936AC")]
			public int oELcJhtWFBzYOFupnonVTYfbvyzN()
			{
				return default;
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x23936B4", Offset = "0x23936B4", VA = "0x23936B4")]
			public MqUEZjlwiIeKTuXxUzFWBUliKyLL()
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x239402C", Offset = "0x239402C", VA = "0x239402C")]
			public void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x23940A8", Offset = "0x23940A8", VA = "0x23940A8")]
			public void uNorXdRhAZJVgdORHzhewkLNilUr()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191100", Offset = "0x191100")]
		private sealed class cgEOizKXucFXVuDYJObcnLIdaeTG
		{
			[Token(Token = "0x4000762")]
			[FieldOffset(Offset = "0x0")]
			public static readonly cgEOizKXucFXVuDYJObcnLIdaeTG _003C_003E9;

			[Token(Token = "0x4000763")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool> _003C_003E9__221_0;

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x2394938", Offset = "0x2394938", VA = "0x2394938")]
			public cgEOizKXucFXVuDYJObcnLIdaeTG()
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x2394940", Offset = "0x2394940", VA = "0x2394940")]
			internal void TDDiqmPleXAatJzZudtmfHVfcaTEA(Exception P_0)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x23949CC", Offset = "0x23949CC", VA = "0x23949CC")]
			internal void ZfmGIXNjbXILurFfUjnNBqwPWzqR(Exception P_0)
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x2394A58", Offset = "0x2394A58", VA = "0x2394A58")]
			internal void FCEhqTiwEbxeTVPvQspMepWjMzyAb(Exception P_0)
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x2394AE4", Offset = "0x2394AE4", VA = "0x2394AE4")]
			internal void MfetaeDhesggpwtBdkNDnrxNUPKs(Exception P_0)
			{
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x2394B70", Offset = "0x2394B70", VA = "0x2394B70")]
			internal void ygyKQijsPTyjSmaEXkDpwzcfstbN(Exception P_0)
			{
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x2394BFC", Offset = "0x2394BFC", VA = "0x2394BFC")]
			internal void sKWexrMIZTGMdilvVozOUbVLJxcT(Exception P_0)
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x2394C88", Offset = "0x2394C88", VA = "0x2394C88")]
			internal void GFmRdWcpdvgqTwWvxiPXChNqNoBk(Exception P_0)
			{
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x2394D14", Offset = "0x2394D14", VA = "0x2394D14")]
			internal void bqWVBlqBuflPyHklEcVCgPsKGyEd(Exception P_0)
			{
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x2394DA0", Offset = "0x2394DA0", VA = "0x2394DA0")]
			internal void AArQVFcZfagUZcVGJKtdEEjyGOtjA(Exception P_0)
			{
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x2394E2C", Offset = "0x2394E2C", VA = "0x2394E2C")]
			internal bool bKlGBRKPxYxDUcMjyzVSkpkneezIb()
			{
				return default;
			}
		}

		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x0")]
		private static InputManager_Base HvlowarpEJjTwmVIKndWValQpypI;

		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x8")]
		private static PlatformInputManager CTpVLYlUovEEvUpcNlivRncrrQbW;

		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x10")]
		internal static nWObnmDQDyPAcKuVnyCIqGPjixDdb GAwkqrvWlvpikRXvCLOCwZfKeMsC;

		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x18")]
		internal static pmhdIRhCoLlQZffSYgOmsLkpxsjN VmqcbbbvPImXBEBcMHWjUAXVfrUSA;

		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x20")]
		internal static BBctKivJxEjGKRzyEkHSRjJoJqnW hqGXmYxZUrSrCxDobJTGEPCWvHAsA;

		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x28")]
		private static ControllerDataFiles hvtSbKLcAoLwFocNZGaXyDHVIyhp;

		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x30")]
		private static UserData afarNIRJlvcfXIrnUwLxEgdcbDEjA;

		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x38")]
		private static bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x40")]
		private static ConfigVars MzljsQKNnzXzAuzZSJhUefpPCcEy;

		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x48")]
		private static UpdateLoopType JZKJGBsuSaOLhJiTvsRyNFkLxwMp;

		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x4C")]
		private static bool ccufkjAWAhTbJaDuyGebaJsLxHKUA;

		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x50")]
		private static Platform uDnCOOlZZpUIrgXGeSbcMIctXMiG;

		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x54")]
		private static WebplayerPlatform EWHwzexfoiyRFhLiBgPzrmmYiUKt;

		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x58")]
		private static EditorPlatform unICjthLTqHPNnLSrXcmbvFaXzQQ;

		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x5C")]
		private static bool uncSVBAxHAmqUjuITaNtgwfiLSRd;

		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x60")]
		private static TimerAbs HmHsEaZxDIDUXLKxzIztJkUaaoZm;

		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x68")]
		private static hZoSIeiGQlsNpxKnhkskatxNwdZA EgFqVkhnQuwqWzKlxbTTqBIkwAdn;

		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x70")]
		private static string qvEajoyMuISFgeEqGQeJiQKMKgmK;

		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x78")]
		private static bool hCmEAcPmvppxEjhawxLgIZABpLik;

		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x79")]
		private static bool GkmiXdOXsbIXKjeFpIDPABcVkAEp;

		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x7A")]
		private static bool ciaKHlkdfnxSFTEXSBgJHScCNEMbA;

		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x7C")]
		private static int UELUFrjaUxsAhaTllRzYIkUctOmj;

		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x80")]
		internal static int _id;

		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x84")]
		private static int eiTDtHWtAjacrCGIktMvceGodkmNA;

		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x88")]
		private static int CDFHTYcVYyNjfwcbyMnOntgUhkKJ;

		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x8C")]
		private static bool DxzQhCtDRoyInHoxWcnNRxVqcFzB;

		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x90")]
		private static readonly UnityTouch akZVbtgXAOvjVgWMOQHFJjdJMvoD;

		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x98")]
		private static readonly PlayerHelper GdwWjDCOcxwJUizjrHagUJgJeCNJ;

		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0xA0")]
		private static readonly ControllerHelper QpbBNmWrfInkcoGyYFaZIQVXTXrNA;

		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0xA8")]
		private static readonly MappingHelper qIzETGiaCujiFKelzjMBwftDgerG;

		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0xB0")]
		private static readonly TimeHelper ecdLtUBiFgzGXZaYvntixqlbMFjm;

		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0xB8")]
		private static readonly ConfigHelper zFposRXLCpdyIpBgRutQBeayGyFI;

		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0xC0")]
		private static WiGEESztaQcOlAVSzDYLfidomemMA apYTMDWGCXhutvjiTTLcQkjwiobJ;

		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0xC8")]
		private static UserDataStore LPxDLELdQfiHxinMUfSElrZHFOEd;

		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0xD0")]
		private static IControllerAssigner CDsiOyqanEANRJmTqOQLnofCbVXm;

		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0xD8")]
		private static MqUEZjlwiIeKTuXxUzFWBUliKyLL KCnPsFgFLyiYyEYWEjTridcaKheJA;

		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0xE0")]
		private static SafeAction<ControllerStatusChangedEventArgs> uFMSNayMaqnyuBvdoywREwUAsimj;

		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0xE8")]
		private static SafeAction<ControllerStatusChangedEventArgs> RSMIOQyasZdEIGhSzpIEFbajfJYPc;

		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0xF0")]
		private static SafeAction<ControllerStatusChangedEventArgs> JYXlYmJfMTgurfCCixbvqZlIozKP;

		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0xF8")]
		private static SafeAction BbIMbQeLvHjivRxkUFEuuHyecJUe;

		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x100")]
		private static SafeAction DoMcMTFZOcROcVWyENyvXEFgDWYm;

		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x108")]
		private static SafeAction DxDDJgdGopEpAltRNiEBalwJEIfob;

		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x110")]
		private static SafeAction BDmisuCgVCeghMSBpbXRvlOriVYBb;

		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x118")]
		private static SafeAction vMWkXfFtLyWssWlmvPyaljgWTHhk;

		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x120")]
		private static Action<bool> _ApplicationFocusChangedEvent;

		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x128")]
		private static Action IzBYZMAEXTGrtOeLAlYNcYpctpQK;

		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x130")]
		private static Action<UpdateLoopType> TrQuHFJWSbBEQkUuadDRDhOfcwRn;

		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x138")]
		private static Action<UpdateLoopType> DIGTJvqzbyagBhANOgLCGihAWkgZ;

		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x140")]
		private static Action<UpdateLoopType> RwMSqmrPEIcUWPMqqCGgofpACAIz;

		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x148")]
		private static Action nEoJdFSxGZTTQgqVzwyiDJlZpkoT;

		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x150")]
		private static Action<bool> yNbnOmzfriGRWQMmXbBnZbjOIcYA;

		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x158")]
		private static Action<bool> TcVDZtTBkbCPvFcbwUNzUxWXdNzKA;

		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x160")]
		private static Action<bool> EPCOWdjrRVZgEJREalGNkcBsOdV;

		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x168")]
		private static Action<FullScreenMode> IQDcUMOkJbbJpvsxoxIaATuqmVFJ;

		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x170")]
		private static Action atJFAUEGsWvXzxPSVIFgFPyLZccI;

		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x178")]
		private static Action<bool> BHfOhXExzTwULJhJBFXiuCiXbVPK;

		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x180")]
		internal static double unscaledDeltaTime;

		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x188")]
		internal static double unscaledTime;

		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x190")]
		internal static double unscaledTimePrev;

		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x198")]
		internal static uint currentFrame;

		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x19C")]
		internal static uint previousFrame;

		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x1A0")]
		internal static uint absFrame;

		[Token(Token = "0x170002C4")]
		private static WiGEESztaQcOlAVSzDYLfidomemMA QgbIinFdaCcKNDxZdcNgHuxnvnzHb
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x23FFC74", Offset = "0x23FFC74", VA = "0x23FFC74")]
			get
			{
				return zSYhkRQkYPqgPPMYzDCElfXNUCiV();
			}
		}

		[Token(Token = "0x170002C5")]
		public static PlayerHelper players
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x23F67F8", Offset = "0x23F67F8", VA = "0x23F67F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C6")]
		public static ControllerHelper controllers
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x23FB340", Offset = "0x23FB340", VA = "0x23FB340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C7")]
		public static MappingHelper mapping
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x2400D40", Offset = "0x2400D40", VA = "0x2400D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C8")]
		public static UnityTouch touch
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x2400E14", Offset = "0x2400E14", VA = "0x2400E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C9")]
		public static TimeHelper time
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x2400EE8", Offset = "0x2400EE8", VA = "0x2400EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CA")]
		public static IUserDataStore userDataStore
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x2400FBC", Offset = "0x2400FBC", VA = "0x2400FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CB")]
		public static ConfigHelper configuration
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x2401090", Offset = "0x2401090", VA = "0x2401090")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CC")]
		public static string programVersion
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x2401164", Offset = "0x2401164", VA = "0x2401164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CD")]
		public static bool usingUnityInput
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x24013C4", Offset = "0x24013C4", VA = "0x24013C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002CE")]
		public static bool unityJoystickIdentificationRequired
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x2401428", Offset = "0x2401428", VA = "0x2401428")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002CF")]
		public static bool isReady
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x2401644", Offset = "0x2401644", VA = "0x2401644")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D0")]
		internal static int id
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x24016A8", Offset = "0x24016A8", VA = "0x24016A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D1")]
		internal static UpdateLoopType currentUpdateLoop
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x240170C", Offset = "0x240170C", VA = "0x240170C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D2")]
		internal static ConfigVars configVars
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x2401770", Offset = "0x2401770", VA = "0x2401770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D3")]
		internal static UserData UserData
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x24017D4", Offset = "0x24017D4", VA = "0x24017D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D4")]
		internal static Platform currentPlatform
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x2401838", Offset = "0x2401838", VA = "0x2401838")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D5")]
		internal static WebplayerPlatform webplayerPlatform
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x240189C", Offset = "0x240189C", VA = "0x240189C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D6")]
		internal static EditorPlatform editorPlatform
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x2401900", Offset = "0x2401900", VA = "0x2401900")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D7")]
		internal static bool checkNeverPressed
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x2401964", Offset = "0x2401964", VA = "0x2401964")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D8")]
		internal static bool isEditor
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x2401C4C", Offset = "0x2401C4C", VA = "0x2401C4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002D9")]
		internal static Guid defaultHardwareJoystickMapGuid
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x2401CB8", Offset = "0x2401CB8", VA = "0x2401CB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002DA")]
		internal static bool isRunningInEditMode
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x2401D90", Offset = "0x2401D90", VA = "0x2401D90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002DB")]
		internal static double realTime
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x2401DF4", Offset = "0x2401DF4", VA = "0x2401DF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002DC")]
		internal static int currentUnityFrame
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x2401E9C", Offset = "0x2401E9C", VA = "0x2401E9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002DD")]
		private static bool zNyGeVXSIgnSvIDeeAEQjOxSNRYfb
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x2401F3C", Offset = "0x2401F3C", VA = "0x2401F3C")]
			get
			{
				return LGvylBNxbyodOTRLiUUmqHZteFmo();
			}
		}

		[Token(Token = "0x170002DE")]
		internal static bool isAllowedEditorWindowFocused
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x2402038", Offset = "0x2402038", VA = "0x2402038")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002DF")]
		internal static bool isUnityEditorFocused
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x24021B8", Offset = "0x24021B8", VA = "0x24021B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002E0")]
		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x24014FC", Offset = "0x24014FC", VA = "0x24014FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002E1")]
		private static bool epCjQafeDYRojVpaRIeiCxKFjwof
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x24022D0", Offset = "0x24022D0", VA = "0x24022D0")]
			get
			{
				return OXRbStNfOJTabUskwEwfYclERVgf();
			}
		}

		[Token(Token = "0x170002E2")]
		internal static bool applicationRunInBackground
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x24025A4", Offset = "0x24025A4", VA = "0x24025A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002E3")]
		internal static InputManager_Base rewiredInputManager
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x240265C", Offset = "0x240265C", VA = "0x240265C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E4")]
		internal static PlatformInputManager primaryInputManager
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x2401B60", Offset = "0x2401B60", VA = "0x2401B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E5")]
		internal static IControllerAssigner controllerAssigner
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x24026C0", Offset = "0x24026C0", VA = "0x24026C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E6")]
		internal static int timeScalePauseChangedCount
		{
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x2402724", Offset = "0x2402724", VA = "0x2402724")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1400000F")]
		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x23FFD4C", Offset = "0x23FFD4C", VA = "0x23FFD4C")]
			add
			{
			}
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x23FFDE8", Offset = "0x23FFDE8", VA = "0x23FFDE8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x23FFE84", Offset = "0x23FFE84", VA = "0x23FFE84")]
			add
			{
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x23FFF20", Offset = "0x23FFF20", VA = "0x23FFF20")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x23FFFBC", Offset = "0x23FFFBC", VA = "0x23FFFBC")]
			add
			{
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x2400058", Offset = "0x2400058", VA = "0x2400058")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public static event Action InputSourceUpdateEvent
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x24000F4", Offset = "0x24000F4", VA = "0x24000F4")]
			add
			{
			}
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x2400244", Offset = "0x2400244", VA = "0x2400244")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public static event Action EditorRecompileEvent
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x2400364", Offset = "0x2400364", VA = "0x2400364")]
			add
			{
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x24003E8", Offset = "0x24003E8", VA = "0x24003E8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public static event Action ShutDownEvent
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x24004A0", Offset = "0x24004A0", VA = "0x24004A0")]
			add
			{
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x2400524", Offset = "0x2400524", VA = "0x2400524")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public static event Action InitializedEvent
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x24005DC", Offset = "0x24005DC", VA = "0x24005DC")]
			add
			{
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x2400660", Offset = "0x2400660", VA = "0x2400660")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		internal static event Action<bool> ApplicationFocusChangedEvent
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x2400718", Offset = "0x2400718", VA = "0x2400718")]
			add
			{
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x24007D4", Offset = "0x24007D4", VA = "0x24007D4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		internal static event Action EarlyUpdateEvent
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x2400890", Offset = "0x2400890", VA = "0x2400890")]
			add
			{
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x240094C", Offset = "0x240094C", VA = "0x240094C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x2400A08", Offset = "0x2400A08", VA = "0x2400A08")]
			add
			{
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x2400AC4", Offset = "0x2400AC4", VA = "0x2400AC4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		internal static event Action<UpdateLoopType> UpdateEndedEvent
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x2400B80", Offset = "0x2400B80", VA = "0x2400B80")]
			add
			{
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x2400C3C", Offset = "0x2400C3C", VA = "0x2400C3C")]
			remove
			{
			}
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x23FF654", Offset = "0x23FF654", VA = "0x23FF654")]
		static ReInput()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x23FFC74", Offset = "0x23FFC74", VA = "0x23FFC74")]
		private static WiGEESztaQcOlAVSzDYLfidomemMA zSYhkRQkYPqgPPMYzDCElfXNUCiV()
		{
			return null;
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2401F3C", Offset = "0x2401F3C", VA = "0x2401F3C")]
		private static bool LGvylBNxbyodOTRLiUUmqHZteFmo()
		{
			return default;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x24022D0", Offset = "0x24022D0", VA = "0x24022D0")]
		private static bool OXRbStNfOJTabUskwEwfYclERVgf()
		{
			return default;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x2402444", Offset = "0x2402444", VA = "0x2402444")]
		internal static bool IsInputAllowed(ControllerType controllerType)
		{
			return default;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x2402788", Offset = "0x2402788", VA = "0x2402788")]
		internal static void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(InputManager_Base P_0, Func<ConfigVars, object> P_1, ConfigVars P_2, ControllerDataFiles P_3, UserData P_4)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x24054A4", Offset = "0x24054A4", VA = "0x24054A4")]
		internal static void edGQWybkvEgdpdpFVqgmUdPGZTqV()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x24057E0", Offset = "0x24057E0", VA = "0x24057E0")]
		internal static void FddrIOuEFxAEchqWvFaTErixupUu(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x24058A4", Offset = "0x24058A4", VA = "0x24058A4")]
		private static void noKmfvdPLaGovcnpLUDWmQJqtyuAA(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x2405A84", Offset = "0x2405A84", VA = "0x2405A84")]
		private static void VxQffUITEqMNYFntBlCQCUoWpOodB()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x2405CC4", Offset = "0x2405CC4", VA = "0x2405CC4")]
		internal static void jRaYtHNVcykNMAbqOnSGaKIIGSEaA(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x24061C0", Offset = "0x24061C0", VA = "0x24061C0")]
		internal static void xKyppkUUtEcaFoPeiMUWhYAtRasV()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x24062F8", Offset = "0x24062F8", VA = "0x24062F8")]
		internal static void LWWrvKsndLGerwSeVdnkTVqAzMnP()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2406928", Offset = "0x2406928", VA = "0x2406928")]
		internal static void bzOGfyCVRfBbKzomQOgXceRcFkIjb()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x24069C4", Offset = "0x24069C4", VA = "0x24069C4")]
		internal static void bkbtHSeXqnEvLDwYOkKMebMJpxpf(bool P_0)
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2406AE4", Offset = "0x2406AE4", VA = "0x2406AE4")]
		internal static void froUXlIdrkajRjAcMiLmmOCCQMmm()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x2406C44", Offset = "0x2406C44", VA = "0x2406C44")]
		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController)
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x2406CC4", Offset = "0x2406CC4", VA = "0x2406CC4")]
		internal static HardwareJoystickMap fdqXOouyCFlzjkPTPiIErxwlIHye(Guid P_0)
		{
			return null;
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x2406D4C", Offset = "0x2406D4C", VA = "0x2406D4C")]
		internal static HardwareJoystickTemplateMap rfsEypEpDSCojIvJWQqUMoXAhWHO(Guid P_0)
		{
			return null;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x2406DD4", Offset = "0x2406DD4", VA = "0x2406DD4")]
		internal static IList<HardwareJoystickTemplateMap> NyMhJvALUKLeLLDFuwVjXLerIxgdA(Guid P_0)
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x2407180", Offset = "0x2407180", VA = "0x2407180")]
		internal static int GetNewJoystickId()
		{
			return default;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x2405C18", Offset = "0x2405C18", VA = "0x2405C18")]
		internal static void HandleCallbackException(string source, Exception exception)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x24071F0", Offset = "0x24071F0", VA = "0x24071F0")]
		internal static void HandleExternalInterfaceException(string source, Exception exception)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x2403484", Offset = "0x2403484", VA = "0x2403484")]
		internal static void CheckRewiredVersionCompatibility()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x2407580", Offset = "0x2407580", VA = "0x2407580")]
		internal static float TpRDVeKUrDzPBCwrBJsvhbGodtGT()
		{
			return default;
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x2407604", Offset = "0x2407604", VA = "0x2407604")]
		internal static bool CheckInitialized()
		{
			return default;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x23F9C9C", Offset = "0x23F9C9C", VA = "0x23F9C9C")]
		internal static bool CheckInitialized(int reInputId)
		{
			return default;
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x24051B4", Offset = "0x24051B4", VA = "0x24051B4")]
		private static void vySTJyCQQbGmMkAKrmQlPwABCQhE()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x2406444", Offset = "0x2406444", VA = "0x2406444")]
		private static void YhaddXEWASnLYtmXhkQurcwjDWkPA()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x240796C", Offset = "0x240796C", VA = "0x240796C")]
		private static void vvnGZHfUStdhjUsYlsLiYRHwhKXg()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2400CF8", Offset = "0x2400CF8", VA = "0x2400CF8")]
		private static void LJNkuIumYUrwPEaXMrTJGeZvMNxe()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2407A48", Offset = "0x2407A48", VA = "0x2407A48")]
		private static void gvyVbcfgxJoHCgHCMpkGqQFLWVmJ(BridgedController P_0)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2407CC8", Offset = "0x2407CC8", VA = "0x2407CC8")]
		private static void XbzGxHmPnLSRwWFaMhRHIylwgclg(ControllerDisconnectedEventArgs P_0)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2405718", Offset = "0x2405718", VA = "0x2405718")]
		private static void PUyKKfOBaawGLxPIxGJwGRhAoMls(ControllerStatusChangedEventArgs P_0)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x2407EC4", Offset = "0x2407EC4", VA = "0x2407EC4")]
		private static void iMqpfKAKSOAZpIOaLIqnRLvZlxzP(ControllerStatusChangedEventArgs P_0)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x2407DFC", Offset = "0x2407DFC", VA = "0x2407DFC")]
		private static void tJDcUjiPVLjHhRpCEnddSqykgjZY(ControllerStatusChangedEventArgs P_0)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x2407F8C", Offset = "0x2407F8C", VA = "0x2407F8C")]
		private static void JpkuUtwWxYVeZSTbpXuvptwLbCTc(UpdateControllerInfoEventArgs P_0)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x240800C", Offset = "0x240800C", VA = "0x240800C")]
		private static void xKXEQmiiNXKorUsTsPlIOtwcwnfr(bool P_0)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x2408194", Offset = "0x2408194", VA = "0x2408194")]
		private static void knnWPfeazRExMNUGyhISzowVnouk(bool P_0)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x24082F4", Offset = "0x24082F4", VA = "0x24082F4")]
		private static void qCViIgANYdkSaCjgCKjdsocAngtDA(int P_0)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x2408484", Offset = "0x2408484", VA = "0x2408484")]
		private static void yYkWdJJVWdAmxbPIBmMJTDVEgMPm(bool P_0)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x24085E4", Offset = "0x24085E4", VA = "0x24085E4")]
		private static void STlfpSSClhBfHJInYFgTePujYnqwB(bool P_0)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x2403560", Offset = "0x2403560", VA = "0x2403560")]
		private static void JaxBYPFZsFwQSYeYUhbJgQnBWTaY()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x2407690", Offset = "0x2407690", VA = "0x2407690")]
		private static void ExTSxDbLJXjqNMzpYuBREBUEugJb()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x2408750", Offset = "0x2408750", VA = "0x2408750")]
		private static void eluifZHoypzzwuCRdKpaEltadRFGA(bool P_0)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x2403840", Offset = "0x2403840", VA = "0x2403840")]
		private static void UoqRqIFlbmbMteHEhPCXEDTNMiuB(Func<ConfigVars, object> P_0)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x240529C", Offset = "0x240529C", VA = "0x240529C")]
		private static void gNOuFVusZxBVSuCaAILcKBpFgAtbA()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x240729C", Offset = "0x240729C", VA = "0x240729C")]
		private static void nRaBRAYQPLInWdZbPkcAoOMGefydA()
		{
		}
	}
}
