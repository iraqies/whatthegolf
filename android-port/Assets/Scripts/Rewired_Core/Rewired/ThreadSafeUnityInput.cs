using UnityEngine;

namespace Rewired
{
	internal static class ThreadSafeUnityInput
	{
		public sealed class Keyboard
		{
			public static readonly int keyValueIndex_Escape;

			public static readonly int keyValueIndex_Menu;

			public static readonly int keyValueIndex_F2;

			public static readonly int keyValueIndex_UpArrow;

			public static readonly int keyValueIndex_RightArrow;

			public static readonly int keyValueIndex_DownArrow;

			public static readonly int keyValueIndex_LeftArrow;

			private static readonly int[] ttPCQOIhBWLspEayDBReynnTjdzD;

			private readonly int ioJHYiWACZZkkzZeFRiOwxJFfdQw;

			private readonly int[] eDsnovpgDYRCEkItkogoNDRSYMgr;

			private readonly bool[] mRJsAJSfWTOusfaseyppRkuiypFP;

			private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

			private int slqCwNOADNuaziwQnpYBsLAgDkbU;

			private readonly bool sXLLyWhVtnTsJUdLYDsshzdInxBV;

			private bool qAUjLUowhhcjcfaueZHSCZUPGnLPA;

			public bool enabled
			{
				set
				{
				}
			}

			static Keyboard()
			{
			}

			public void PostInitialize()
			{
			}

			public void Update()
			{
			}

			public void Monitor(bool state)
			{
			}

			public bool GetKey(KeyCode keyCode)
			{
				return false;
			}

			public void GetKeyValues(bool[] values)
			{
			}

			public void Clear()
			{
			}

			private void OKxvPvoURRjupSYqKtJLgoTgWMxN()
			{
			}

			private void UqdMoMtxMcHiYaHWyMZuAUeCVDWT()
			{
			}

			private void sNGJsvCFsuenrEOXDxjdGIytxIAg()
			{
			}

			private void dLTmNLbcfcSsYBWfHMowHMrlNqOc()
			{
			}

			private void RgnNmZnACSxAgrmsAdhxaroTbLTdb()
			{
			}
		}

		public sealed class Mouse
		{
			private readonly bool[] YXuCILbbSuGPNMGgRTZoPeQmcMPsA;

			private readonly float[] bjSaUzibFNjMvUxWxsNvcnSslSIE;

			private int slqCwNOADNuaziwQnpYBsLAgDkbU;

			private Vector3 ofsfUcwRLOMfZtmGigYHgPHPYaVjA;

			private bool hqIancbNdeQahWmzJNeqgDvorJFLA;

			private bool rUwncdFqovCJQbqmfeNYndIMaweDb;

			public Vector3 mousePosition => default;

			public void PostInitialize()
			{
			}

			public void Update()
			{
			}

			public void Monitor(bool state)
			{
			}

			public void GetButtonValues(bool[] buttons)
			{
			}

			public void GetAxisRawValues(float[] axes)
			{
			}

			private void OKxvPvoURRjupSYqKtJLgoTgWMxN()
			{
			}

			private void ptzeSUAYMaLUihwOYdMoDqBEoBwfb()
			{
			}

			private void UqdMoMtxMcHiYaHWyMZuAUeCVDWT()
			{
			}

			private void sNGJsvCFsuenrEOXDxjdGIytxIAg()
			{
			}

			private void jxvCxrwjjUpCacwLcCRHqdfkrLsA()
			{
			}

			private void RgnNmZnACSxAgrmsAdhxaroTbLTdb()
			{
			}
		}

		private static Mouse bKoZOjcjaRQYKDivtGCcnpEhOVte;

		private static Keyboard YweDTrCAKOQqcjdBMYBocZoZyikKA;

		public static Mouse mouse => null;

		public static Keyboard keyboard => null;

		public static void Initialize()
		{
		}

		public static void PostInitialize()
		{
		}

		public static void PostInitialize2()
		{
		}

		public static void Deinitialize()
		{
		}

		public static void Update()
		{
		}
	}
}
