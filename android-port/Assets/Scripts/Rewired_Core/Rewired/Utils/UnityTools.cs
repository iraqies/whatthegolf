using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils
{
	public static class UnityTools
	{
		public enum UnityVersion
		{
			UNITY_2_6 = 0,
			UNITY_2_6_1 = 1,
			UNITY_3_0 = 2,
			UNITY_3_0_0 = 3,
			UNITY_3_1 = 4,
			UNITY_3_2 = 5,
			UNITY_3_3 = 6,
			UNITY_3_4 = 7,
			UNITY_3_5 = 8,
			UNITY_3_5_2 = 9,
			UNITY_3_5_7 = 10,
			UNITY_3_MAX = 11,
			UNITY_4_0 = 12,
			UNITY_4_0_1 = 13,
			UNITY_4_1 = 14,
			UNITY_4_2 = 15,
			UNITY_4_3 = 16,
			UNITY_4_4 = 17,
			UNITY_4_5 = 18,
			UNITY_4_6 = 19,
			UNITY_4_6_3p1 = 20,
			UNITY_4_6_3p1Plus = 21,
			UNITY_4_7 = 22,
			UNITY_4_8 = 23,
			UNITY_4_9 = 24,
			UNITY_4_MAX = 25,
			UNITY_5_0 = 26,
			UNITY_5_0_0p1 = 27,
			UNITY_5_0_0p1Plus = 28,
			UNITY_5_0_1 = 29,
			UNITY_5_0_2 = 30,
			UNITY_5_1 = 31,
			UNITY_5_2 = 32,
			UNITY_5_3 = 33,
			UNITY_5_4 = 34,
			UNITY_5_5 = 35,
			UNITY_5_6 = 36,
			UNITY_5_7 = 37,
			UNITY_5_8 = 38,
			UNITY_5_9 = 39,
			UNITY_5_MAX = 40,
			UNITY_2017_0 = 41,
			UNITY_2017_1 = 42,
			UNITY_2017_2 = 43,
			UNITY_2017_3 = 44,
			UNITY_2017_4 = 45,
			UNITY_2017_5 = 46,
			UNITY_2017_6 = 47,
			UNITY_2017_7 = 48,
			UNITY_2017_8 = 49,
			UNITY_2017_9 = 50,
			UNITY_2017_MAX = 51,
			UNITY_2018_0 = 52,
			UNITY_2018_1 = 53,
			UNITY_2018_2 = 54,
			UNITY_2018_3 = 55,
			UNITY_2018_4 = 56,
			UNITY_2018_5 = 57,
			UNITY_2018_6 = 58,
			UNITY_2018_7 = 59,
			UNITY_2018_8 = 60,
			UNITY_2018_9 = 61,
			UNITY_2018_MAX = 62,
			UNITY_2019_0 = 63,
			UNITY_2019_1 = 64,
			UNITY_2019_2 = 65,
			UNITY_2019_3 = 66,
			UNITY_2019_4 = 67,
			UNITY_2019_5 = 68,
			UNITY_2019_6 = 69,
			UNITY_2019_7 = 70,
			UNITY_2019_8 = 71,
			UNITY_2019_9 = 72,
			UNITY_2019_MAX = 73,
			UNITY_2020_0 = 74,
			UNITY_2020_1 = 75,
			UNITY_2020_2 = 76,
			UNITY_2020_3 = 77,
			UNITY_2020_4 = 78,
			UNITY_2020_5 = 79,
			UNITY_2020_6 = 80,
			UNITY_2020_7 = 81,
			UNITY_2020_8 = 82,
			UNITY_2020_9 = 83,
			UNITY_2020_MAX = 84,
			UNITY_2021_0 = 85,
			UNITY_2021_1 = 86,
			UNITY_2021_2 = 87,
			UNITY_2021_3 = 88,
			UNITY_2021_4 = 89,
			UNITY_2021_5 = 90,
			UNITY_2021_6 = 91,
			UNITY_2021_7 = 92,
			UNITY_2021_8 = 93,
			UNITY_2021_9 = 94,
			UNITY_2021_MAX = 95,
			UNITY_2022_0 = 96,
			UNITY_2022_1 = 97,
			UNITY_2022_2 = 98,
			UNITY_2022_3 = 99,
			UNITY_2022_4 = 100,
			UNITY_2022_5 = 101,
			UNITY_2022_6 = 102,
			UNITY_2022_7 = 103,
			UNITY_2022_8 = 104,
			UNITY_2022_9 = 105,
			UNITY_2022_MAX = 106,
			UNITY_2023_0 = 107,
			UNITY_2023_1 = 108,
			UNITY_2023_2 = 109,
			UNITY_2023_3 = 110,
			UNITY_2023_4 = 111,
			UNITY_2023_5 = 112,
			UNITY_2023_6 = 113,
			UNITY_2023_7 = 114,
			UNITY_2023_8 = 115,
			UNITY_2023_9 = 116,
			UNITY_2023_MAX = 117,
			UNITY_2024_0 = 118,
			UNITY_2024_1 = 119,
			UNITY_2024_2 = 120,
			UNITY_2024_3 = 121,
			UNITY_2024_4 = 122,
			UNITY_2024_5 = 123,
			UNITY_2024_6 = 124,
			UNITY_2024_7 = 125,
			UNITY_2024_8 = 126,
			UNITY_2024_9 = 127,
			UNITY_2024_MAX = 128,
			UNITY_2025_0 = 129,
			UNITY_2025_1 = 130,
			UNITY_2025_2 = 131,
			UNITY_2025_3 = 132,
			UNITY_2025_4 = 133,
			UNITY_2025_5 = 134,
			UNITY_2025_6 = 135,
			UNITY_2025_7 = 136,
			UNITY_2025_8 = 137,
			UNITY_2025_9 = 138,
			UNITY_2025_MAX = 139,
			Unknown = 1000
		}

		internal class UnityVersionClass
		{
			public enum IdKBtoGKGXdBiBVmruyzejHHLBeB
			{
				Normal = 0,
				Beta = 1,
				Patch = 2
			}

			public readonly int major;

			public readonly int minor;

			public readonly int maintenance;

			public readonly IdKBtoGKGXdBiBVmruyzejHHLBeB type;

			public readonly int build;

			public UnityVersionClass(string P_0)
			{
			}

			public override string ToString()
			{
				return null;
			}

			private string UcwUkFnuyhCHJjEdMNYqOKrNJrzs(IdKBtoGKGXdBiBVmruyzejHHLBeB P_0)
			{
				return null;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator <(UnityVersionClass a, UnityVersionClass b)
			{
				return false;
			}

			public static bool operator >(UnityVersionClass a, UnityVersionClass b)
			{
				return false;
			}

			public static bool operator >=(UnityVersionClass a, UnityVersionClass b)
			{
				return false;
			}

			public static bool operator ==(UnityVersionClass a, UnityVersionClass b)
			{
				return false;
			}

			public static bool operator !=(UnityVersionClass a, UnityVersionClass b)
			{
				return false;
			}

			public static int Comparison(UnityVersionClass a, UnityVersionClass b)
			{
				return 0;
			}

			public static bool IsValidVersionString(string versionString)
			{
				return false;
			}

			private static int bpxDajArYFJyvGZidJeJAhYNSlAjb(IdKBtoGKGXdBiBVmruyzejHHLBeB P_0)
			{
				return 0;
			}
		}

		private static UnityVersionClass WKDGXJHBvvsYdbmNMdZhdRinWpJtA;

		private static UnityVersion qVwNnaIwKNrVpkqQhRBKhjhZuDye;

		private static string IoIwulCwEMjdQlJPhJclayYFDMto;

		private static Platform NUaVSpthFXYMDNIKPHgmNhOikaUp;

		private static EditorPlatform unICjthLTqHPNnLSrXcmbvFaXzQQ;

		private static bool EeJuUBdEjUCoScMzNOpcUaiJIrUTA;

		private static bool eASqtHcXNuWOmdyLdlSKBrgLxeyB;

		private static bool nsTdBglbvKegswWyQoyVJEKZxqSC;

		private static WebplayerPlatform EWHwzexfoiyRFhLiBgPzrmmYiUKt;

		private static bool vIcDklTouDODaGoOGHHRvWfRrlaK;

		private static bool kxEbCyVbRuHJsRnDcWwMYmtqMfVH;

		private static bool qKowHndTsRGXHOxvxnNvDjwBPAlk;

		private static bool aEEslyeYBovJgvgkzoyLDtbSKGax;

		private static bool tYccRuDCVXrqnFUycwBfpPZuVldmA;

		private static bool KQMNHcNXvGwZMVyxIaWAeUCkuQJb;

		private static string gMrbXjGXjLUEIlscMqaLpOhajlzQA;

		private static ScriptingBackend ouVOgQVxrwlaSCPFMoLNuMzrRnjD;

		private static ScriptingAPILevel NSSlBrrVItfqnyxPaWEeNHgDiIfc;

		private static bool xygumqGoipOjosmbDJIHicflKAUM;

		private static IExternalTools GenhOyijtlFUEKeiWBPiAueyRoWEb;

		[CompilerGenerated]
		private static IAndroidFallbackPlatformHelper EEBIvpMrPPGTmswSJPQoShMLTmzo;

		private static bool hOiPNTabIuSmDxoUqjBuGeUlmqMQ;

		internal static UnityVersionClass unityVersionObj => null;

		public static UnityVersion unityVersion => UnityVersion.UNITY_2_6;

		public static string unityVersionString => null;

		public static Platform platform => Platform.Unknown;

		internal static Platform effectivePlatform => Platform.Unknown;

		public static EditorPlatform editorPlatform => EditorPlatform.None;

		public static bool isEditor => false;

		public static WebplayerPlatform webplayerPlatform => WebplayerPlatform.None;

		public static bool logToDebugLog => false;

		public static bool isAndroidPlatform => false;

		public static bool isIOSPlatform => false;

		public static bool isStandalonePlatform => false;

		public static bool windowsJoystickNamesReturnsEmptyStringsIfJoystickNull => false;

		public static bool supportsUnityUIGraphicRaycastTarget => false;

		public static IExternalTools externalTools => null;

		internal static IAndroidFallbackPlatformHelper YamuuACgfaSgRUmyfSScpMCIdkMJ
		{
			get
			{
				return hOWRNKQaZRobGqmUAaeSIGKDMVZo();
			}
			set
			{
				ANewaltkJCoDsFjRazvRNtaaGRue(androidFallbackPlatformHelper);
			}
		}

		internal static bool isInitialized => false;

		private static bool jYTNgflwwEgvgbZuuTHYnPAnuRao => oWiLLgLAcaWwLQraDxjPnTAHOnSe();

		internal static IAndroidFallbackPlatformHelper hOWRNKQaZRobGqmUAaeSIGKDMVZo()
		{
			return null;
		}

		internal static void ANewaltkJCoDsFjRazvRNtaaGRue(IAndroidFallbackPlatformHelper P_0)
		{
		}

		private static bool oWiLLgLAcaWwLQraDxjPnTAHOnSe()
		{
			return false;
		}

		private static bool rCpHLxCNrAeHtqhxEZNVQHSUNDrwA()
		{
			return false;
		}

		internal static void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(Platform P_0, EditorPlatform P_1, bool P_2, WebplayerPlatform P_3, ScriptingBackend P_4, ScriptingAPILevel P_5, IExternalTools P_6)
		{
		}

		public static bool IsUnityVersionInRange(string minVersionStr, string maxVersionStr)
		{
			return false;
		}

		private static bool nsgecAbbzQBoZawtDCxTLGoqbMgqb(string P_0, out int P_1)
		{
			P_1 = default;
			return false;
		}

		private static void AoPTostLTAzbmulaZRzQbWAogDGr()
		{
		}

		private static UnityVersion gRolDcIonkgmZfMqIjqxrMqqDLbAA(string P_0)
		{
			return UnityVersion.UNITY_2_6;
		}

		private static void VsuyKCUSXYpmazQaXxRJqaRPMOru()
		{
		}

		public static List<string> GetCurrentPlatformResourecesDLLPaths()
		{
			return null;
		}

		public static T GetComponent<T>(Transform transform) where T : class
		{
			return null;
		}

		public static T GetComponent<T>(Component component) where T : class
		{
			return null;
		}

		public static T GetComponent<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		public static T GetComponentInChildren<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		public static T GetComponentInChildren<T>(Transform transform) where T : class
		{
			return null;
		}

		public static T GetComponentInSelfOrChildren<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		public static T GetComponentInSelfOrParents<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		public static T GetComponentInSelfOrParents<T>(Transform transform) where T : class
		{
			return null;
		}

		public static List<T> GetComponentsInSelfAndChildren<T>(Component component) where T : class
		{
			return null;
		}

		public static List<T> GetComponentsInSelfAndChildren<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		public static int GetComponents<T>(Transform transform, List<T> results, bool append) where T : class
		{
			return 0;
		}

		public static int GetComponents<T>(GameObject gameObject, List<T> results, bool append) where T : class
		{
			return 0;
		}

		public static int GetComponentsInSelfAndChildren<T>(Transform transform, List<T> results, bool append) where T : class
		{
			return 0;
		}

		public static int GetComponentsInParents<T>(Transform transform, List<T> results, bool append) where T : class
		{
			return 0;
		}

		public static int GetComponentsInParents<T>(GameObject gameObject, List<T> results, bool append) where T : class
		{
			return 0;
		}

		public static bool IsActiveAndEnabled(Component component)
		{
			return false;
		}

		public static T Instantiate<T>(Object original, Transform parent, bool instantiateInWorldSpace) where T : Object
		{
			return null;
		}

		public static T Instantiate<T>(Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace) where T : Object
		{
			return null;
		}

		public static Vector3 TransformPoint(Transform from, Transform to, Vector3 point)
		{
			return default;
		}

		internal static bool IsObjectInScene<T>(T @object) where T : Object
		{
			return false;
		}

		public static string GetUnityInputAxisName(int unityJoystickIndex, int axisIndex)
		{
			return null;
		}

		public static string GetUnityInputAxisNameByJoystickId(int unityJoystickId, int axisIndex)
		{
			return null;
		}

		public static string GetUnityInputButtonName(int unityJoystickIndex, int buttonIndex)
		{
			return null;
		}

		public static string GetUnityInputButtonNameByJoystickId(int unityJoystickId, int buttonIndex)
		{
			return null;
		}

		public static bool IsValidUnityJoystickName(string name)
		{
			return false;
		}

		public static AnimationCurve Copy(AnimationCurve orig)
		{
			return null;
		}

		public static bool IsNullOrDestroyed<T>(T @object) where T : class
		{
			return false;
		}

		private static _0001 VVfnZlmfPVrEJDFZDSLyMYXCGIlt<_0001>(_0001 P_0) where _0001 : class
		{
			return null;
		}
	}
}
