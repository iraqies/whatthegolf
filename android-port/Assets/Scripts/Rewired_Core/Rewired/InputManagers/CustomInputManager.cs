using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

namespace Rewired.InputManagers
{
	[Token(Token = "0x200016A")]
	internal class CustomInputManager : PlatformInputManager
	{
		[Token(Token = "0x200016B")]
		private class KmjMmfyELXzeRNHGiatyYKKdIqBx : IInputManagerJoystickPublic
		{
			[Token(Token = "0x4000860")]
			[FieldOffset(Offset = "0x10")]
			private readonly InputSource twtzIKfuPcwLuTdbfRDPmfUOUduI;

			[Token(Token = "0x4000861")]
			[FieldOffset(Offset = "0x18")]
			private readonly CustomInputSource uvqirFvSaQaSLJywHrfkGSZIjZIBA;

			[Token(Token = "0x4000862")]
			[FieldOffset(Offset = "0x20")]
			private readonly Controller.Extension ieNssgrFeJiIpjsZwbsJdGwhvyJU;

			[Token(Token = "0x4000863")]
			[FieldOffset(Offset = "0x28")]
			private int kniQQKPsrTyUTKqICYwwQKlUfoRf;

			[Token(Token = "0x4000864")]
			[FieldOffset(Offset = "0x2C")]
			private int nyPspetimSyUTqhIxJtYJkZCgjlM;

			[Token(Token = "0x4000865")]
			[FieldOffset(Offset = "0x30")]
			private long? orGeZnHyIQImwrQbTiysYDyAvZUR;

			[Token(Token = "0x4000866")]
			[FieldOffset(Offset = "0x40")]
			private int xmEXVfyENtoyjKLfjizpdurnqqpi;

			[Token(Token = "0x4000867")]
			[FieldOffset(Offset = "0x44")]
			public Guid cUhzBTzwBmFECgMqAsRWDOSsbdVY;

			[Token(Token = "0x4000868")]
			[FieldOffset(Offset = "0x58")]
			public string gLHfwCyqreiUZEYrUxDpSgvRFFht;

			[Token(Token = "0x4000869")]
			[FieldOffset(Offset = "0x60")]
			public string QKGJzZtcEVRujqXgWpGOAarEKtHh;

			[Token(Token = "0x400086A")]
			[FieldOffset(Offset = "0x68")]
			private int yLLlShtixVkbYMaIfuUMijmLCboKA;

			[Token(Token = "0x400086B")]
			[FieldOffset(Offset = "0x6C")]
			private int tpoonPbJmajQyAErVLnAOoXhqZqEb;

			[Token(Token = "0x400086C")]
			[FieldOffset(Offset = "0x70")]
			private float[] qugobParkJGeDYgxggFADuHJrSREA;

			[Token(Token = "0x400086D")]
			[FieldOffset(Offset = "0x78")]
			private bool[] QKMemPJOCQdfGcajCUROfzfnXvDE;

			[Token(Token = "0x400086E")]
			[FieldOffset(Offset = "0x80")]
			private HardwareJoystickMap_InputManager yPbTGFEOQNqKOEHVnHaIUhnHjgYD;

			[Token(Token = "0x400086F")]
			[FieldOffset(Offset = "0x88")]
			public CustomInputSource.Joystick LsybBclOJVPTDUJtdKjIwxCfcMse;

			[Token(Token = "0x4000870")]
			[FieldOffset(Offset = "0x90")]
			private bool ulpWNMyBfTTmuiYwnRErPHSaPABK;

			[Token(Token = "0x4000871")]
			[FieldOffset(Offset = "0x98")]
			private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> MzECUhxACfqrWuBRNBbBzuCqFsTG;

			[Token(Token = "0x1700034A")]
			public int RjAiGdvCPfvtkTaCKkDzQpjuKUmN
			{
				[Token(Token = "0x6000BE2")]
				[Address(RVA = "0x24637AC", Offset = "0x24637AC", VA = "0x24637AC")]
				get
				{
					return yoeBSGSMfedbVJbmmIAXCvMMbFVS();
				}
			}

			[Token(Token = "0x1700034B")]
			public int STrqcXxJVXWmOzdWQDdtJmduqYaEb
			{
				[Token(Token = "0x6000BE3")]
				[Address(RVA = "0x24637F4", Offset = "0x24637F4", VA = "0x24637F4")]
				get
				{
					return xmOVOxrPwKgsSCbbfHbepxLoFZxY();
				}
			}

			[Token(Token = "0x1700034C")]
			public int rewiredId
			{
				[Token(Token = "0x6000BE4")]
				[Address(RVA = "0x246383C", Offset = "0x246383C", VA = "0x246383C", Slot = "4")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000BE5")]
				[Address(RVA = "0x2463844", Offset = "0x2463844", VA = "0x2463844")]
				set
				{
				}
			}

			[Token(Token = "0x1700034D")]
			public int inputManagerId
			{
				[Token(Token = "0x6000BE6")]
				[Address(RVA = "0x246384C", Offset = "0x246384C", VA = "0x246384C", Slot = "5")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000BE7")]
				[Address(RVA = "0x2463854", Offset = "0x2463854", VA = "0x2463854")]
				set
				{
				}
			}

			[Token(Token = "0x1700034E")]
			public string name
			{
				[Token(Token = "0x6000BE8")]
				[Address(RVA = "0x246385C", Offset = "0x246385C", VA = "0x246385C", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700034F")]
			public long? systemId
			{
				[Token(Token = "0x6000BE9")]
				[Address(RVA = "0x24638F0", Offset = "0x24638F0", VA = "0x24638F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000350")]
			public int unityId
			{
				[Token(Token = "0x6000BEA")]
				[Address(RVA = "0x24638FC", Offset = "0x24638FC", VA = "0x24638FC", Slot = "8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000351")]
			public Guid instanceGuid
			{
				[Token(Token = "0x6000BEB")]
				[Address(RVA = "0x2463904", Offset = "0x2463904", VA = "0x2463904", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000352")]
			public Guid persistentGuid
			{
				[Token(Token = "0x6000BEC")]
				[Address(RVA = "0x2463A84", Offset = "0x2463A84", VA = "0x2463A84", Slot = "10")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000353")]
			public Controller.Extension extension
			{
				[Token(Token = "0x6000BED")]
				[Address(RVA = "0x2463A88", Offset = "0x2463A88", VA = "0x2463A88", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x24637AC", Offset = "0x24637AC", VA = "0x24637AC")]
			public int yoeBSGSMfedbVJbmmIAXCvMMbFVS()
			{
				return default;
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x24637F4", Offset = "0x24637F4", VA = "0x24637F4")]
			public int xmOVOxrPwKgsSCbbfHbepxLoFZxY()
			{
				return default;
			}

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x2463A90", Offset = "0x2463A90", VA = "0x2463A90", Slot = "11")]
			public void SetVibration(float amount, int motorIndex)
			{
			}

			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x2463A94", Offset = "0x2463A94", VA = "0x2463A94", Slot = "12")]
			public void StopVibration()
			{
			}

			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x2463A98", Offset = "0x2463A98", VA = "0x2463A98")]
			public KmjMmfyELXzeRNHGiatyYKKdIqBx(CustomInputSource P_0, long? P_1, int P_2, CustomInputSource.Joystick P_3, InputSource P_4, Controller.Extension P_5, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> P_6)
			{
			}

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x2463BEC", Offset = "0x2463BEC", VA = "0x2463BEC")]
			public void kzmsoJcHfxzYjwlZofNXqivrtrbh()
			{
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x2463CAC", Offset = "0x2463CAC", VA = "0x2463CAC", Slot = "14")]
			public void Update()
			{
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x2464058", Offset = "0x2464058", VA = "0x2464058")]
			public int dRTWaRkWIkEMLraxMRHrbdGkCqGCA(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0)
			{
				return default;
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x2464100", Offset = "0x2464100", VA = "0x2464100")]
			private void ZsSGuyFeNhejoyHSIRMfnABaLlydA(BridgedControllerHWInfo P_0)
			{
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x24645A4", Offset = "0x24645A4", VA = "0x24645A4")]
			private void ZsSGuyFeNhejoyHSIRMfnABaLlydA(BridgedController P_0)
			{
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x2464640", Offset = "0x2464640", VA = "0x2464640", Slot = "15")]
			public void FillData(ControllerDataUpdater dataUpdater)
			{
			}

			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x2464790", Offset = "0x2464790", VA = "0x2464790")]
			public BridgedControllerHWInfo wlgJJzqpwWlttiTkqCeBJnfMAizL()
			{
				return null;
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x2464834", Offset = "0x2464834", VA = "0x2464834", Slot = "16")]
			public BridgedController ToBridgedController()
			{
				return null;
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x24648A4", Offset = "0x24648A4", VA = "0x24648A4", Slot = "17")]
			public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
			{
				return null;
			}

			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x2463CF4", Offset = "0x2463CF4", VA = "0x2463CF4")]
			private void dtkrhYOvGizZeJBgYiXXFyVpYjce()
			{
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x2463EA8", Offset = "0x2463EA8", VA = "0x2463EA8")]
			private void MGEvRBxTXmrzVAbFgmVqKAAmKjlj()
			{
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x24649CC", Offset = "0x24649CC", VA = "0x24649CC")]
			private bool HJcRYlOYnieEhWqubAkAbPeBDumaA(HardwareJoystickMap.Platform_Custom.Button P_0)
			{
				return default;
			}

			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x2464910", Offset = "0x2464910", VA = "0x2464910")]
			private float vKvknQyltTIOpMBpDfAHAfgnfcpAA(HardwareJoystickMap.Platform_Custom.Axis P_0)
			{
				return default;
			}

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x2464AB4", Offset = "0x2464AB4", VA = "0x2464AB4")]
			private float vKvknQyltTIOpMBpDfAHAfgnfcpAA(int P_0)
			{
				return default;
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x2464A94", Offset = "0x2464A94", VA = "0x2464A94")]
			private bool HJcRYlOYnieEhWqubAkAbPeBDumaA(int P_0)
			{
				return default;
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x2463C0C", Offset = "0x2463C0C", VA = "0x2463C0C")]
			private void uxvVoENawKQUBgtDORfvcLmpPHIB()
			{
			}

			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x246415C", Offset = "0x246415C", VA = "0x246415C")]
			private string gGionhosfhAUReDWKmiZOyIKcoAI()
			{
				return null;
			}

			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x2464AD4", Offset = "0x2464AD4", VA = "0x2464AD4")]
			public static int XLDWYYvsgeAfEFpjEpYvIWmVwcbE(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0, KmjMmfyELXzeRNHGiatyYKKdIqBx P_1)
			{
				return default;
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x2464B04", Offset = "0x2464B04", VA = "0x2464B04")]
			public static int uSJfSSvTECbbVqebAzVeyXUpCeHd(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0, KmjMmfyELXzeRNHGiatyYKKdIqBx P_1)
			{
				return default;
			}
		}

		[Token(Token = "0x200016C")]
		private class uXwpZJyBcTFBiyOnNcViQRLSxmDx
		{
			[Token(Token = "0x200016D")]
			public enum NEFqovlzdGEkcwPeIoXZpJBhQWBJ
			{
				[Token(Token = "0x4000874")]
				Exact = 0,
				[Token(Token = "0x4000875")]
				Approximate = 1
			}

			[Token(Token = "0x200016E")]
			public class MggRSwUVUSfoCdutybFWQDHtDgUt
			{
				[Token(Token = "0x4000876")]
				[FieldOffset(Offset = "0x10")]
				public int vLaDHvfmijzLwCtDfpDRfeHfsWbqc;

				[Token(Token = "0x4000877")]
				[FieldOffset(Offset = "0x18")]
				public long? TGwSKVtHvYDggEqcgfOlEPytpNqMA;

				[Token(Token = "0x4000878")]
				[FieldOffset(Offset = "0x28")]
				public string dguorTmaquKzUTHTlsJHWLmDYLpe;

				[Token(Token = "0x4000879")]
				[FieldOffset(Offset = "0x30")]
				public int lICdlIDUnBRyGFLyltrkLDJRDJVO;

				[Token(Token = "0x400087A")]
				[FieldOffset(Offset = "0x34")]
				public int tpoonPbJmajQyAErVLnAOoXhqZqEb;

				[Token(Token = "0x400087B")]
				[FieldOffset(Offset = "0x38")]
				public int yLLlShtixVkbYMaIfuUMijmLCboKA;

				[Token(Token = "0x6000C08")]
				[Address(RVA = "0x23A4984", Offset = "0x23A4984", VA = "0x23A4984")]
				public MggRSwUVUSfoCdutybFWQDHtDgUt(int P_0, long? P_1, string P_2, int P_3, int P_4, int P_5)
				{
				}

				[Token(Token = "0x6000C09")]
				[Address(RVA = "0x23A49F0", Offset = "0x23A49F0", VA = "0x23A49F0")]
				public bool dRTWaRkWIkEMLraxMRHrbdGkCqGCA(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0, NEFqovlzdGEkcwPeIoXZpJBhQWBJ P_1)
				{
					return default;
				}
			}

			[Token(Token = "0x200016F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191120", Offset = "0x191120")]
			private sealed class VAiwrfHLDPdVFnytijkRVTvsZtsi : IDisposable, IEnumerable, IEnumerator, IEnumerable<MggRSwUVUSfoCdutybFWQDHtDgUt>, IEnumerator<MggRSwUVUSfoCdutybFWQDHtDgUt>
			{
				[Token(Token = "0x400087C")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x400087D")]
				[FieldOffset(Offset = "0x18")]
				private MggRSwUVUSfoCdutybFWQDHtDgUt VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x400087E")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x400087F")]
				[FieldOffset(Offset = "0x28")]
				public uXwpZJyBcTFBiyOnNcViQRLSxmDx TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000880")]
				[FieldOffset(Offset = "0x30")]
				private KmjMmfyELXzeRNHGiatyYKKdIqBx bkgcrrWCRFOtLkjgQGzzaVDQJynbA;

				[Token(Token = "0x4000881")]
				[FieldOffset(Offset = "0x38")]
				public KmjMmfyELXzeRNHGiatyYKKdIqBx VukUHiuaNKfVWgJZtDZBhZgYFbeXA;

				[Token(Token = "0x4000882")]
				[FieldOffset(Offset = "0x40")]
				private NEFqovlzdGEkcwPeIoXZpJBhQWBJ WqfMvsqFdNcyCXobEzTCxnUdUxrF;

				[Token(Token = "0x4000883")]
				[FieldOffset(Offset = "0x44")]
				public NEFqovlzdGEkcwPeIoXZpJBhQWBJ aGoqjFKjTqxYmTFXGFrTzlYRkhXy;

				[Token(Token = "0x4000884")]
				[FieldOffset(Offset = "0x48")]
				private int YhcsJywchOwatkdZFPbKBklpfunV;

				[Token(Token = "0x4000885")]
				[FieldOffset(Offset = "0x4C")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000354")]
				private MggRSwUVUSfoCdutybFWQDHtDgUt System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInputManagers_002ECustomInputManager_002EJoystickRecords_002ERecord_003E_002ECurrent
				{
					[Token(Token = "0x6000C0D")]
					[Address(RVA = "0x23A4C98", Offset = "0x23A4C98", VA = "0x23A4C98", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInputManagers_002ECustomInputManager_002EJoystickRecords_002ERecord_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000355")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000C0F")]
					[Address(RVA = "0x23A4CE0", Offset = "0x23A4CE0", VA = "0x23A4CE0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000C0A")]
				[Address(RVA = "0x23A4B1C", Offset = "0x23A4B1C", VA = "0x23A4B1C")]
				[DebuggerHidden]
				public VAiwrfHLDPdVFnytijkRVTvsZtsi(int P_0)
				{
				}

				[Token(Token = "0x6000C0B")]
				[Address(RVA = "0x23A4B64", Offset = "0x23A4B64", VA = "0x23A4B64", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000C0C")]
				[Address(RVA = "0x23A4B68", Offset = "0x23A4B68", VA = "0x23A4B68", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000C0D")]
				[Address(RVA = "0x23A4C98", Offset = "0x23A4C98", VA = "0x23A4C98", Slot = "10")]
				[DebuggerHidden]
				private MggRSwUVUSfoCdutybFWQDHtDgUt System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInputManagers_002ECustomInputManager_002EJoystickRecords_002ERecord_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000C0E")]
				[Address(RVA = "0x23A4CA0", Offset = "0x23A4CA0", VA = "0x23A4CA0", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000C0F")]
				[Address(RVA = "0x23A4CE0", Offset = "0x23A4CE0", VA = "0x23A4CE0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000C10")]
				[Address(RVA = "0x23A4CE8", Offset = "0x23A4CE8", VA = "0x23A4CE8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<MggRSwUVUSfoCdutybFWQDHtDgUt> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EInputManagers_002ECustomInputManager_002EJoystickRecords_002ERecord_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000C11")]
				[Address(RVA = "0x23A4DBC", Offset = "0x23A4DBC", VA = "0x23A4DBC", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000872")]
			[FieldOffset(Offset = "0x10")]
			private List<MggRSwUVUSfoCdutybFWQDHtDgUt> UwGmbGTujPCBtLRcPMDVnuFMDlrS;

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x2464B90", Offset = "0x2464B90", VA = "0x2464B90")]
			public uXwpZJyBcTFBiyOnNcViQRLSxmDx()
			{
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x2464C14", Offset = "0x2464C14", VA = "0x2464C14")]
			public void CQYqTMmvttNbVynJkterllzoWgKe(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0)
			{
			}

			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x2465030", Offset = "0x2465030", VA = "0x2465030")]
			public IEnumerable<MggRSwUVUSfoCdutybFWQDHtDgUt> JhAfrVJVWWlugTxWtItbSJXlMNCd(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0, NEFqovlzdGEkcwPeIoXZpJBhQWBJ P_1)
			{
				return null;
			}

			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x2464F3C", Offset = "0x2464F3C", VA = "0x2464F3C")]
			private void mIMjpeKiQlKAsiYxehIGdvJWmupB(int P_0, int P_1)
			{
			}
		}

		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x38")]
		private List<KmjMmfyELXzeRNHGiatyYKKdIqBx> pfvHZfkVJHuFpTIaVPSjIEuhIisl;

		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x40")]
		private int OeeHBecrguVtJOJkdEjZKpQgYwls;

		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x48")]
		private uXwpZJyBcTFBiyOnNcViQRLSxmDx yOgOXMdWSZKgHOWSXqOzTssrAWni;

		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x50")]
		private UpdateLoopType IykDTZdiEUdjfaMPasESCgLSFroIc;

		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x58")]
		private Action<int, ControllerDataUpdater> zxGQuXWGAufVLbkLjNzszbXATpQrA;

		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x60")]
		private PlatformInputManager dLeGbmnDSSIBftSnJkmMPNabIURs;

		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x68")]
		private CustomInputSource uvqirFvSaQaSLJywHrfkGSZIjZIBA;

		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x70")]
		private bool mosSJnjLnefWplKjFDNNyyTdOAaG;

		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x78")]
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> MzECUhxACfqrWuBRNBbBzuCqFsTG;

		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x80")]
		private Func<int> VbbCuMeRTNjQXExlYVBnBBhBxmfmB;

		[Token(Token = "0x17000348")]
		public override PlatformInputManager primaryInputManager
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x2376368", Offset = "0x2376368", VA = "0x2376368", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000349")]
		public override InputSource inputSourceType
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x2376370", Offset = "0x2376370", VA = "0x2376370", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x2375F50", Offset = "0x2375F50", VA = "0x2375F50")]
		public CustomInputManager(CustomInputSource P_0, UpdateLoopSetting P_1, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> P_2, Func<int> P_3)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x237638C", Offset = "0x237638C", VA = "0x237638C", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x2376440", Offset = "0x2376440", VA = "0x2376440", Slot = "7")]
		public override void Update(UpdateLoopType updateLoop)
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x23765C8", Offset = "0x23765C8", VA = "0x23765C8", Slot = "8")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x23765E0", Offset = "0x23765E0", VA = "0x23765E0", Slot = "12")]
		public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x23765E8", Offset = "0x23765E8", VA = "0x23765E8", Slot = "11")]
		public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data)
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x2376740", Offset = "0x2376740", VA = "0x2376740", Slot = "9")]
		public override void SystemDeviceConnected()
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x237675C", Offset = "0x237675C", VA = "0x237675C", Slot = "10")]
		public override void SystemDeviceDisconnected()
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x2376778", Offset = "0x2376778", VA = "0x2376778", Slot = "13")]
		public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x237677C", Offset = "0x237677C", VA = "0x237677C", Slot = "14")]
		public override IUnifiedMouseSource GetUnifiedMouseSource()
		{
			return null;
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x2376784", Offset = "0x2376784", VA = "0x2376784", Slot = "15")]
		public override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
		{
			return null;
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x237678C", Offset = "0x237678C", VA = "0x237678C")]
		private void vOupObHoGGqcZUAbdBHmnAnfgYrI(CustomInputSource.Joystick[] P_0)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x237652C", Offset = "0x237652C", VA = "0x237652C")]
		private void QbVAjVWFtjNLxYhAcdqihqDFeguS()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x2376A28", Offset = "0x2376A28", VA = "0x2376A28")]
		private void ftbgfAiDvmSdIeusVzSkTpuhpzBV(int P_0, int P_1, List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_2, List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_3)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x2377588", Offset = "0x2377588", VA = "0x2377588")]
		private bool YOpkZHCZwdYZaaxJAJIvhEZXQJFg(List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_0, int P_1)
		{
			return default;
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x2377490", Offset = "0x2377490", VA = "0x2377490")]
		private int UZDtQCJtoBAzOcKCFQAhAcWCSlRe(List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_0)
		{
			return default;
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x2377670", Offset = "0x2377670", VA = "0x2377670")]
		private bool SOyWHlXMPORgpMASVXPztNAVPsaL(List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_0, int P_1)
		{
			return default;
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x2376E24", Offset = "0x2376E24", VA = "0x2376E24")]
		private void xRxIiLagAyRqoXRhMeqWoRVnsVfg(int P_0, List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_1, int P_2, List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_3, uXwpZJyBcTFBiyOnNcViQRLSxmDx.NEFqovlzdGEkcwPeIoXZpJBhQWBJ P_4)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x2377010", Offset = "0x2377010", VA = "0x2377010")]
		private void pEdRcuYEfPeDfCbDzlhCjQTcTroNA(int P_0, List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_1, uXwpZJyBcTFBiyOnNcViQRLSxmDx.NEFqovlzdGEkcwPeIoXZpJBhQWBJ P_2)
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x23764DC", Offset = "0x23764DC", VA = "0x23764DC")]
		private void vKPnlrydRfdvHsSeMDWMWLWGxPmt()
		{
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x237786C", Offset = "0x237786C", VA = "0x237786C")]
		private bool YkzrGmlCpVDGEtVFCmSTRQlVMnyR(CustomInputSource.Joystick[] P_0)
		{
			return default;
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x2376CA4", Offset = "0x2376CA4", VA = "0x2376CA4")]
		private void mZaUgDoxXIdSkCMllUmYWlPzEksd(List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_0, List<KmjMmfyELXzeRNHGiatyYKKdIqBx> P_1, bool P_2)
		{
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x2377AE8", Offset = "0x2377AE8", VA = "0x2377AE8")]
		private void CTOpPdkFJUgxrzSfEfbZBihGShecA(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0, bool P_1)
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x2377B38", Offset = "0x2377B38", VA = "0x2377B38")]
		private void xvpcZQAidNYRofKPLPjklwQcsfJI(KmjMmfyELXzeRNHGiatyYKKdIqBx P_0, bool P_1)
		{
		}
	}
}
