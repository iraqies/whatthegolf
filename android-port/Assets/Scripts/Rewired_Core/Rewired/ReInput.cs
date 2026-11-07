using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public static class ReInput
	{
		[EditorBrowsable]
		public sealed class ConfigHelper : CodeHelper
		{
			private static ConfigHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			private float rcFjLisvbvYtJGWpnKEYgFUHqZfd;

			private float UJqtCyevQhANodQxANgKNPSQEzWI;

			internal static ConfigHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

			public bool alwaysUseUnityInput => false;

			public bool disableNativeInput => false;

			public bool ignoreInputWhenAppNotInFocus => false;

			public float defaultAbsoluteAxisPollingDeadZone => 0f;

			public float defaultRelativeAxisPollingDeadZone => 0f;

			public bool autoAssignJoysticks
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public int maxJoysticksPerPlayer
			{
				set
				{
				}
			}

			public bool distributeJoysticksEvenly
			{
				set
				{
				}
			}

			internal static ConfigHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			private ConfigHelper()
			{
			}
		}

		[EditorBrowsable]
		public sealed class ControllerHelper : CodeHelper
		{
			[EditorBrowsable]
			public sealed class PollingHelper : CodeHelper
			{
				private static PollingHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

				internal static PollingHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

				internal static PollingHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
				{
					return null;
				}

				private PollingHelper()
				{
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> uASjJkZZigXWClPGrxYXTWuYytCB(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> vrICuQWYoOrlhALPFYnIOpJlEyPk(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> poJGVDxjXbhXycFeIsdyHsoedsCYA(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> nTOaOzAizIVxHePeOnxkRHlAxAWS()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> cLPDCRhyqgMmkTmpLiLNnnreryrD()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> vjoctRbePlNRDLebnEgMQAlXsvCEA()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> xLpJNhMMqKQpDjLnVPCaMhTCFhvDA()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> uStEnMWAjtgNoCXbEUVvdQyxXPXSA(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> vdQAqndUFXikgRdontniOExbHDlBA(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> utngrPJaCAzrAjFBBjQiFNhEtvAib(int P_0)
				{
					return null;
				}
			}

			[EditorBrowsable]
			public sealed class ConflictCheckingHelper : CodeHelper
			{
				private static ConflictCheckingHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

				internal static ConflictCheckingHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

				internal static ConflictCheckingHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
				{
					return null;
				}

				private ConflictCheckingHelper()
				{
				}
			}

			private static ControllerHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			public readonly PollingHelper polling;

			public readonly ConflictCheckingHelper conflictChecking;

			internal static ControllerHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

			public IList<Controller> Controllers => null;

			public Mouse Mouse => null;

			public Keyboard Keyboard => null;

			public int joystickCount => 0;

			public IList<Joystick> Joysticks => null;

			public int customControllerCount => 0;

			public IList<CustomController> CustomControllers => null;

			internal static ControllerHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			private ControllerHelper()
			{
			}

			public Controller GetController(ControllerType controllerType, int controllerId)
			{
				return null;
			}

			public Controller GetController(ControllerIdentifier controllerIdentifier)
			{
				return null;
			}

			public bool IsControllerAssigned(ControllerType controllerType, int controllerId)
			{
				return false;
			}

			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId)
			{
				return false;
			}

			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true)
			{
			}

			public Joystick GetJoystick(int joystickId)
			{
				return null;
			}

			public Joystick[] GetJoysticks()
			{
				return null;
			}

			public bool IsJoystickAssigned(Joystick joystick)
			{
				return false;
			}

			public bool IsJoystickAssigned(int joystickId)
			{
				return false;
			}

			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId)
			{
				return false;
			}

			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true)
			{
			}

			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly)
			{
				return 0;
			}

			public void SetUnityJoystickId(int joystickId, int unityJoystickId)
			{
			}

			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly)
			{
				return false;
			}

			public CustomController GetCustomController(int customControllerId)
			{
				return null;
			}

			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId)
			{
				return false;
			}

			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true)
			{
			}

			public CustomController CreateCustomController(int sourceControllerId)
			{
				return null;
			}

			public bool DestroyCustomController(CustomController customController)
			{
				return false;
			}

			public Controller GetLastActiveController(ControllerType controllerType)
			{
				return null;
			}

			public ControllerType GetLastActiveControllerType()
			{
				return ControllerType.Keyboard;
			}

			public bool AutoAssignJoystick(Joystick joystick)
			{
				return false;
			}

			public void AutoAssignJoysticks()
			{
			}
		}

		[EditorBrowsable]
		public sealed class MappingHelper : CodeHelper
		{
			private static MappingHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			internal static MappingHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

			public IList<InputMapCategory> MapCategories => null;

			public IEnumerable<InputMapCategory> UserAssignableMapCategories => null;

			public IList<InputCategory> ActionCategories => null;

			public IList<InputLayout> JoystickLayouts => null;

			public IList<InputLayout> KeyboardLayouts => null;

			public IList<InputLayout> MouseLayouts => null;

			public IList<InputLayout> CustomControllerLayouts => null;

			public IList<InputAction> Actions => null;

			internal static MappingHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			private MappingHelper()
			{
			}

			public InputMapCategory GetMapCategory(int mapCategoryId)
			{
				return null;
			}

			public int GetMapCategoryId(string name)
			{
				return 0;
			}

			public InputCategory GetActionCategory(string name)
			{
				return null;
			}

			public InputLayout GetLayout(ControllerType controllerType, int layoutId)
			{
				return null;
			}

			public int GetLayoutId(ControllerType controllerType, string name)
			{
				return 0;
			}

			public IList<InputLayout> MapLayouts(ControllerType controllerType)
			{
				return null;
			}

			public InputAction GetAction(int actionId)
			{
				return null;
			}

			public InputAction GetAction(string name)
			{
				return null;
			}

			public int GetActionId(string name)
			{
				return 0;
			}

			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName)
			{
				return null;
			}

			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId)
			{
				return null;
			}

			public IList<InputBehavior> GetInputBehaviors(int playerId)
			{
				return null;
			}

			public InputBehavior GetInputBehavior(int playerId, int behaviorId)
			{
				return null;
			}

			internal InputBehavior kRhNFszrrvRsbYXXXIXgWSMseAZb(int P_0)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId)
			{
				return null;
			}

			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				return null;
			}

			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id)
			{
				return null;
			}

			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id)
			{
				return null;
			}
		}

		[EditorBrowsable]
		public sealed class PlayerHelper : CodeHelper
		{
			private static PlayerHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			internal static PlayerHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

			public int playerCount => 0;

			public int allPlayerCount => 0;

			public IList<Player> Players => null;

			public IList<Player> AllPlayers => null;

			public Player SystemPlayer => null;

			internal static PlayerHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			private PlayerHelper()
			{
			}

			public IList<Player> GetPlayers(bool includeSystemPlayer = false)
			{
				return null;
			}

			public Player GetPlayer(int playerId)
			{
				return null;
			}

			public Player GetSystemPlayer()
			{
				return null;
			}
		}

		[EditorBrowsable]
		public sealed class TimeHelper : CodeHelper
		{
			private static TimeHelper LDnMtBpByMhNcmNpPzdzLRPijZRi;

			internal static TimeHelper izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

			public double unscaledTime => 0.0;

			public uint currentFrame => 0u;

			internal static TimeHelper nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			private TimeHelper()
			{
			}
		}

		private class hZoSIeiGQlsNpxKnhkskatxNwdZA
		{
			private class kDKEfdfOLDciMiJECUQyUkOtQTwpB
			{
				public readonly UpdateLoopType PiEdbgjMHSsksYjRKSGckYZEsfAE;

				private double FcWClUEYqCkONndVVYEPBiKEVBNB;

				private double XZOBJpCdOwBGkZIyBYDcVtUfFFWmA;

				private double wZXFAliRaxWJujhJCKLDQTOTYZoc;

				private double NOBBHpOgmrCDwBpMuddlsRhuNmMRA;

				private uint NCglwbjCeCDmrtawbrrpCSJyjfSA;

				private uint UivYnXQnUJuOgczaZBaIEfHvkPAJ;

				private float dJqdUrXrkApZXanEYjNoMExGczlc;

				private float YoGxJgYUpoJzBxiNAHVJzSahzkLj;

				public double BHafZFWbiZCkNYpfoeSagMhWvnNK => paLHovbBGDAzINmOeqjeVKpQPUvMA();

				public uint XhKxIzDXGwEJghbHIgWHJwLzJsmD => XzWjlvfKKBjVkBrgjxpnmKyuPikL();

				public double paLHovbBGDAzINmOeqjeVKpQPUvMA()
				{
					return 0.0;
				}

				public uint XzWjlvfKKBjVkBrgjxpnmKyuPikL()
				{
					return 0u;
				}

				public kDKEfdfOLDciMiJECUQyUkOtQTwpB(UpdateLoopType P_0)
				{
				}

				public void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
				{
				}
			}

			private static class TbDNSGwIxLAfdqScpHJWJUvftbIQ
			{
				public static StopwatchBase xalFtCqNqSQGgJNyNzskdnWqkjIL => VWMySbJZveqUtZOagnGEriQqNsDO();

				public static StopwatchBase VWMySbJZveqUtZOagnGEriQqNsDO()
				{
					return null;
				}
			}

			private StopwatchBase hArdDerumcBRzshORbjwoKPaIhvm;

			private double aEQkUBDfXMggCpBhlrKNfYCKOQFK;

			private kDKEfdfOLDciMiJECUQyUkOtQTwpB GIGZxQvhKXDENIiOdEmKJcLFFHANA;

			private ADictionary<int, kDKEfdfOLDciMiJECUQyUkOtQTwpB> fsZiqIxBodMcuysspsefSOuHjyKt;

			private uint AWyHCOmvqqiSaSAbNuHstXbiGTmf;

			public double BHafZFWbiZCkNYpfoeSagMhWvnNK => paLHovbBGDAzINmOeqjeVKpQPUvMA();

			internal double wEeKniBOCFcwArpfmZhOqVuhQdhP => xaraaObeWBpecprFjrnJQQNNpPaJA();

			public uint XhKxIzDXGwEJghbHIgWHJwLzJsmD => XzWjlvfKKBjVkBrgjxpnmKyuPikL();

			public double paLHovbBGDAzINmOeqjeVKpQPUvMA()
			{
				return 0.0;
			}

			internal double xaraaObeWBpecprFjrnJQQNNpPaJA()
			{
				return 0.0;
			}

			public uint XzWjlvfKKBjVkBrgjxpnmKyuPikL()
			{
				return 0u;
			}

			public void rZuOrpWYhhCfBPmUsQdcUinbQbVD()
			{
			}

			public void jpwugzufXqktYbXkMYboQpqCbQgL()
			{
			}

			public void jRaYtHNVcykNMAbqOnSGaKIIGSEaA(UpdateLoopType P_0)
			{
			}
		}

		[EditorBrowsable]
		public sealed class UnityTouch : CodeHelper
		{
			private static UnityTouch LDnMtBpByMhNcmNpPzdzLRPijZRi;

			internal static UnityTouch izfChqvjKyhCcypSioMPzwuCmhEV => nSDedHgxFmfKpDQgiatnprpCjsRjB();

			public int touchCount => 0;

			internal static UnityTouch nSDedHgxFmfKpDQgiatnprpCjsRjB()
			{
				return null;
			}

			private UnityTouch()
			{
			}

			public Touch GetTouch(int index)
			{
				return default;
			}
		}

		internal class MqUEZjlwiIeKTuXxUzFWBUliKyLL
		{
			[Serializable]
			private sealed class yNqIGGPBgoDiQbHyTmBpJcgluJfsA
			{
				public static readonly yNqIGGPBgoDiQbHyTmBpJcgluJfsA _003C_003E9;

				public static Func<bool> _003C_003E9__11_1;

				public static Func<bool> _003C_003E9__11_2;

				public static Func<int> _003C_003E9__11_3;

				public static Func<float> _003C_003E9__11_4;

				public static Func<bool> _003C_003E9__11_5;

				public static Func<string> _003C_003E9__11_0;

				internal bool tWDswhYAvBqHImkNJdYGpAwokPVM()
				{
					return false;
				}

				internal bool LBgFBZQrZLQqglpncuFkjnZgRpSO()
				{
					return false;
				}

				internal int pNTdosrvgmmgqqQIYuBZbWKKoCpj()
				{
					return 0;
				}

				internal float AElOJWFyoEskqxqdgUiyBMRpImTB()
				{
					return 0f;
				}

				internal bool IBnfeLEHNkAMvGXwOccFPpbKfgwiA()
				{
					return false;
				}

				internal string fqfnoFdSaoYewLmeTldQXFozeXiq()
				{
					return null;
				}
			}

			public readonly ValueWatcher<bool> UZYSHsTJwyaEEFondgqwlzyMavdk;

			public readonly ValueWatcher<bool> KYiOUlwMqmWUeZyXbFwxCXGMMnDJ;

			public readonly ValueWatcher<bool> vbOhiocIcDPNMFSYkWDgYncMpduHA;

			public readonly ValueWatcher<int> bYcrVqtLPhbPOoKrkaPlbHEWjLygb;

			public readonly ValueWatcher<float> qDnfJdfXrGdKIjhGHpBGIytaTokcE;

			public readonly ValueWatcher<string> CRuRampAWykoWdPZeqkFGVaRdTjs;

			public readonly ValueWatcher<bool> mYuWjVGPwctxkGRqeqjMVZiXqUQ;

			private int LqefkSWyanwezQfUHigehUsVcaio;

			private readonly ValueWatcher[] YCSshVVGDwHfgBfrWXhtGsZExlIu;

			public int gOuDkZUQNKJvrYshgNhmDOkegsQi => oELcJhtWFBzYOFupnonVTYfbvyzN();

			public int oELcJhtWFBzYOFupnonVTYfbvyzN()
			{
				return 0;
			}

			public void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			public void uNorXdRhAZJVgdORHzhewkLNilUr()
			{
			}
		}

		[Serializable]
		private sealed class cgEOizKXucFXVuDYJObcnLIdaeTG
		{
			public static readonly cgEOizKXucFXVuDYJObcnLIdaeTG _003C_003E9;

			public static Func<bool> _003C_003E9__221_0;

			internal void TDDiqmPleXAatJzZudtmfHVfcaTEA(Exception P_0)
			{
			}

			internal void ZfmGIXNjbXILurFfUjnNBqwPWzqR(Exception P_0)
			{
			}

			internal void FCEhqTiwEbxeTVPvQspMepWjMzyAb(Exception P_0)
			{
			}

			internal void MfetaeDhesggpwtBdkNDnrxNUPKs(Exception P_0)
			{
			}

			internal void ygyKQijsPTyjSmaEXkDpwzcfstbN(Exception P_0)
			{
			}

			internal void sKWexrMIZTGMdilvVozOUbVLJxcT(Exception P_0)
			{
			}

			internal void GFmRdWcpdvgqTwWvxiPXChNqNoBk(Exception P_0)
			{
			}

			internal void bqWVBlqBuflPyHklEcVCgPsKGyEd(Exception P_0)
			{
			}

			internal void AArQVFcZfagUZcVGJKtdEEjyGOtjA(Exception P_0)
			{
			}

			internal bool bKlGBRKPxYxDUcMjyzVSkpkneezIb()
			{
				return false;
			}
		}

		private static InputManager_Base HvlowarpEJjTwmVIKndWValQpypI;

		private static PlatformInputManager CTpVLYlUovEEvUpcNlivRncrrQbW;

		internal static nWObnmDQDyPAcKuVnyCIqGPjixDdb GAwkqrvWlvpikRXvCLOCwZfKeMsC;

		internal static pmhdIRhCoLlQZffSYgOmsLkpxsjN VmqcbbbvPImXBEBcMHWjUAXVfrUSA;

		internal static BBctKivJxEjGKRzyEkHSRjJoJqnW hqGXmYxZUrSrCxDobJTGEPCWvHAsA;

		private static ControllerDataFiles hvtSbKLcAoLwFocNZGaXyDHVIyhp;

		private static UserData afarNIRJlvcfXIrnUwLxEgdcbDEjA;

		private static bool obpzIVquVRQseulcTcTZaHvizTjRA;

		private static ConfigVars MzljsQKNnzXzAuzZSJhUefpPCcEy;

		private static UpdateLoopType JZKJGBsuSaOLhJiTvsRyNFkLxwMp;

		private static bool ccufkjAWAhTbJaDuyGebaJsLxHKUA;

		private static Platform uDnCOOlZZpUIrgXGeSbcMIctXMiG;

		private static WebplayerPlatform EWHwzexfoiyRFhLiBgPzrmmYiUKt;

		private static EditorPlatform unICjthLTqHPNnLSrXcmbvFaXzQQ;

		private static bool uncSVBAxHAmqUjuITaNtgwfiLSRd;

		private static TimerAbs HmHsEaZxDIDUXLKxzIztJkUaaoZm;

		private static hZoSIeiGQlsNpxKnhkskatxNwdZA EgFqVkhnQuwqWzKlxbTTqBIkwAdn;

		private static string qvEajoyMuISFgeEqGQeJiQKMKgmK;

		private static bool hCmEAcPmvppxEjhawxLgIZABpLik;

		private static bool GkmiXdOXsbIXKjeFpIDPABcVkAEp;

		private static bool ciaKHlkdfnxSFTEXSBgJHScCNEMbA;

		private static int UELUFrjaUxsAhaTllRzYIkUctOmj;

		internal static int _id;

		private static int eiTDtHWtAjacrCGIktMvceGodkmNA;

		private static int CDFHTYcVYyNjfwcbyMnOntgUhkKJ;

		private static bool DxzQhCtDRoyInHoxWcnNRxVqcFzB;

		private static readonly UnityTouch akZVbtgXAOvjVgWMOQHFJjdJMvoD;

		private static readonly PlayerHelper GdwWjDCOcxwJUizjrHagUJgJeCNJ;

		private static readonly ControllerHelper QpbBNmWrfInkcoGyYFaZIQVXTXrNA;

		private static readonly MappingHelper qIzETGiaCujiFKelzjMBwftDgerG;

		private static readonly TimeHelper ecdLtUBiFgzGXZaYvntixqlbMFjm;

		private static readonly ConfigHelper zFposRXLCpdyIpBgRutQBeayGyFI;

		private static WiGEESztaQcOlAVSzDYLfidomemMA apYTMDWGCXhutvjiTTLcQkjwiobJ;

		private static UserDataStore LPxDLELdQfiHxinMUfSElrZHFOEd;

		private static IControllerAssigner CDsiOyqanEANRJmTqOQLnofCbVXm;

		private static MqUEZjlwiIeKTuXxUzFWBUliKyLL KCnPsFgFLyiYyEYWEjTridcaKheJA;

		private static SafeAction<ControllerStatusChangedEventArgs> uFMSNayMaqnyuBvdoywREwUAsimj;

		private static SafeAction<ControllerStatusChangedEventArgs> RSMIOQyasZdEIGhSzpIEFbajfJYPc;

		private static SafeAction<ControllerStatusChangedEventArgs> JYXlYmJfMTgurfCCixbvqZlIozKP;

		private static SafeAction BbIMbQeLvHjivRxkUFEuuHyecJUe;

		private static SafeAction DoMcMTFZOcROcVWyENyvXEFgDWYm;

		private static SafeAction DxDDJgdGopEpAltRNiEBalwJEIfob;

		private static SafeAction BDmisuCgVCeghMSBpbXRvlOriVYBb;

		private static SafeAction vMWkXfFtLyWssWlmvPyaljgWTHhk;

		private static Action<bool> _ApplicationFocusChangedEvent;

		private static Action IzBYZMAEXTGrtOeLAlYNcYpctpQK;

		private static Action<UpdateLoopType> TrQuHFJWSbBEQkUuadDRDhOfcwRn;

		private static Action<UpdateLoopType> DIGTJvqzbyagBhANOgLCGihAWkgZ;

		private static Action<UpdateLoopType> RwMSqmrPEIcUWPMqqCGgofpACAIz;

		private static Action nEoJdFSxGZTTQgqVzwyiDJlZpkoT;

		private static Action<bool> yNbnOmzfriGRWQMmXbBnZbjOIcYA;

		private static Action<bool> TcVDZtTBkbCPvFcbwUNzUxWXdNzKA;

		private static Action<bool> EPCOWdjrRVZgEJREalGNkcBsOdV;

		private static Action<FullScreenMode> IQDcUMOkJbbJpvsxoxIaATuqmVFJ;

		private static Action atJFAUEGsWvXzxPSVIFgFPyLZccI;

		private static Action<bool> BHfOhXExzTwULJhJBFXiuCiXbVPK;

		internal static double unscaledDeltaTime;

		internal static double unscaledTime;

		internal static double unscaledTimePrev;

		internal static uint currentFrame;

		internal static uint previousFrame;

		internal static uint absFrame;

		private static WiGEESztaQcOlAVSzDYLfidomemMA QgbIinFdaCcKNDxZdcNgHuxnvnzHb => zSYhkRQkYPqgPPMYzDCElfXNUCiV();

		public static PlayerHelper players => null;

		public static ControllerHelper controllers => null;

		public static MappingHelper mapping => null;

		public static UnityTouch touch => null;

		public static TimeHelper time => null;

		public static IUserDataStore userDataStore => null;

		public static ConfigHelper configuration => null;

		public static string programVersion => null;

		public static bool usingUnityInput => false;

		public static bool unityJoystickIdentificationRequired => false;

		public static bool isReady => false;

		internal static int id => 0;

		internal static UpdateLoopType currentUpdateLoop => UpdateLoopType.Update;

		internal static ConfigVars configVars => null;

		internal static UserData UserData => null;

		internal static Platform currentPlatform => Platform.Unknown;

		internal static WebplayerPlatform webplayerPlatform => WebplayerPlatform.None;

		internal static EditorPlatform editorPlatform => EditorPlatform.None;

		internal static bool checkNeverPressed => false;

		internal static bool isEditor => false;

		internal static Guid defaultHardwareJoystickMapGuid => default;

		internal static bool isRunningInEditMode => false;

		internal static double realTime => 0.0;

		internal static int currentUnityFrame => 0;

		private static bool zNyGeVXSIgnSvIDeeAEQjOxSNRYfb => LGvylBNxbyodOTRLiUUmqHZteFmo();

		internal static bool isAllowedEditorWindowFocused => false;

		internal static bool isUnityEditorFocused => false;

		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform => false;

		private static bool epCjQafeDYRojVpaRIeiCxKFjwof => OXRbStNfOJTabUskwEwfYclERVgf();

		internal static bool applicationRunInBackground => false;

		internal static InputManager_Base rewiredInputManager => null;

		internal static PlatformInputManager primaryInputManager => null;

		internal static IControllerAssigner controllerAssigner => null;

		internal static int timeScalePauseChangedCount => 0;

		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action InputSourceUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action EditorRecompileEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action ShutDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action InitializedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<bool> ApplicationFocusChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action EarlyUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static event Action<UpdateLoopType> UpdateEndedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		static ReInput()
		{
		}

		private static WiGEESztaQcOlAVSzDYLfidomemMA zSYhkRQkYPqgPPMYzDCElfXNUCiV()
		{
			return null;
		}

		private static bool LGvylBNxbyodOTRLiUUmqHZteFmo()
		{
			return false;
		}

		private static bool OXRbStNfOJTabUskwEwfYclERVgf()
		{
			return false;
		}

		internal static bool IsInputAllowed(ControllerType controllerType)
		{
			return false;
		}

		internal static void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(InputManager_Base P_0, Func<ConfigVars, object> P_1, ConfigVars P_2, ControllerDataFiles P_3, UserData P_4)
		{
		}

		internal static void edGQWybkvEgdpdpFVqgmUdPGZTqV()
		{
		}

		internal static void FddrIOuEFxAEchqWvFaTErixupUu(UpdateLoopType P_0)
		{
		}

		private static void noKmfvdPLaGovcnpLUDWmQJqtyuAA(UpdateLoopType P_0)
		{
		}

		private static void VxQffUITEqMNYFntBlCQCUoWpOodB()
		{
		}

		internal static void jRaYtHNVcykNMAbqOnSGaKIIGSEaA(UpdateLoopType P_0)
		{
		}

		internal static void xKyppkUUtEcaFoPeiMUWhYAtRasV()
		{
		}

		internal static void LWWrvKsndLGerwSeVdnkTVqAzMnP()
		{
		}

		internal static void bzOGfyCVRfBbKzomQOgXceRcFkIjb()
		{
		}

		internal static void bkbtHSeXqnEvLDwYOkKMebMJpxpf(bool P_0)
		{
		}

		internal static void froUXlIdrkajRjAcMiLmmOCCQMmm()
		{
		}

		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController)
		{
			return null;
		}

		internal static HardwareJoystickMap fdqXOouyCFlzjkPTPiIErxwlIHye(Guid P_0)
		{
			return null;
		}

		internal static HardwareJoystickTemplateMap rfsEypEpDSCojIvJWQqUMoXAhWHO(Guid P_0)
		{
			return null;
		}

		internal static IList<HardwareJoystickTemplateMap> NyMhJvALUKLeLLDFuwVjXLerIxgdA(Guid P_0)
		{
			return null;
		}

		internal static int GetNewJoystickId()
		{
			return 0;
		}

		internal static void HandleCallbackException(string source, Exception exception)
		{
		}

		internal static void HandleExternalInterfaceException(string source, Exception exception)
		{
		}

		internal static void CheckRewiredVersionCompatibility()
		{
		}

		internal static float TpRDVeKUrDzPBCwrBJsvhbGodtGT()
		{
			return 0f;
		}

		internal static bool CheckInitialized()
		{
			return false;
		}

		internal static bool CheckInitialized(int reInputId)
		{
			return false;
		}

		private static void vySTJyCQQbGmMkAKrmQlPwABCQhE()
		{
		}

		private static void YhaddXEWASnLYtmXhkQurcwjDWkPA()
		{
		}

		private static void vvnGZHfUStdhjUsYlsLiYRHwhKXg()
		{
		}

		private static void LJNkuIumYUrwPEaXMrTJGeZvMNxe()
		{
		}

		private static void gvyVbcfgxJoHCgHCMpkGqQFLWVmJ(BridgedController P_0)
		{
		}

		private static void XbzGxHmPnLSRwWFaMhRHIylwgclg(ControllerDisconnectedEventArgs P_0)
		{
		}

		private static void PUyKKfOBaawGLxPIxGJwGRhAoMls(ControllerStatusChangedEventArgs P_0)
		{
		}

		private static void iMqpfKAKSOAZpIOaLIqnRLvZlxzP(ControllerStatusChangedEventArgs P_0)
		{
		}

		private static void tJDcUjiPVLjHhRpCEnddSqykgjZY(ControllerStatusChangedEventArgs P_0)
		{
		}

		private static void JpkuUtwWxYVeZSTbpXuvptwLbCTc(UpdateControllerInfoEventArgs P_0)
		{
		}

		private static void xKXEQmiiNXKorUsTsPlIOtwcwnfr(bool P_0)
		{
		}

		private static void knnWPfeazRExMNUGyhISzowVnouk(bool P_0)
		{
		}

		private static void qCViIgANYdkSaCjgCKjdsocAngtDA(int P_0)
		{
		}

		private static void yYkWdJJVWdAmxbPIBmMJTDVEgMPm(bool P_0)
		{
		}

		private static void STlfpSSClhBfHJInYFgTePujYnqwB(bool P_0)
		{
		}

		private static void JaxBYPFZsFwQSYeYUhbJgQnBWTaY()
		{
		}

		private static void ExTSxDbLJXjqNMzpYuBREBUEugJb()
		{
		}

		private static void eluifZHoypzzwuCRdKpaEltadRFGA(bool P_0)
		{
		}

		private static void UoqRqIFlbmbMteHEhPCXEDTNMiuB(Func<ConfigVars, object> P_0)
		{
		}

		private static void gNOuFVusZxBVSuCaAILcKBpFgAtbA()
		{
		}

		private static void nRaBRAYQPLInWdZbPkcAoOMGefydA()
		{
		}
	}
}
