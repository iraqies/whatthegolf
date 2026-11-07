using System;
using Il2CppDummyDll;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x20000C1")]
	internal class UnityUnifiedMouseSource : IDisposable, IGetSetEnabled, IUnifiedMouseSource
	{
		[Token(Token = "0x20000C2")]
		private class puflpgkLMPMHzuiiJIwEuxMmWYNg
		{
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0x10")]
			private float[] OLQIvANwxPxdLvhhJWLJIxgsFjwC;

			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x18")]
			private bool[] cMJVUFvfQMWkvBtJpLdwMPYAPQtO;

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x239AA58", Offset = "0x239AA58", VA = "0x239AA58")]
			public puflpgkLMPMHzuiiJIwEuxMmWYNg(int P_0, int P_1)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x239AAF4", Offset = "0x239AAF4", VA = "0x239AAF4")]
			public void sIVOHhfJwwEIlNaMuLHeQvgSxJje(bool[] P_0, float[] P_1)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x239AB9C", Offset = "0x239AB9C", VA = "0x239AB9C")]
			public void sqKPSSlsVXhtJbtQVKkAMGtItVvG(ControllerDataUpdater P_0)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x239ABF0", Offset = "0x239ABF0", VA = "0x239ABF0")]
			public void SPGTRPyvIslcMdbPTItsewSLRPxx()
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x239AC3C", Offset = "0x239AC3C", VA = "0x239AC3C")]
			public void TRdGVpAaqUDZDhNKIlCydndygteTA()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190AE0", Offset = "0x190AE0")]
		private sealed class bISaAuJrMgGmwLJaQqtMKLqAIFQHb
		{
			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x0")]
			public static readonly bISaAuJrMgGmwLJaQqtMKLqAIFQHb _003C_003E9;

			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x8")]
			public static Func<puflpgkLMPMHzuiiJIwEuxMmWYNg> _003C_003E9__20_0;

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x239A990", Offset = "0x239A990", VA = "0x239A990")]
			public bISaAuJrMgGmwLJaQqtMKLqAIFQHb()
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x239A998", Offset = "0x239A998", VA = "0x239A998")]
			internal puflpgkLMPMHzuiiJIwEuxMmWYNg KjKfUoBCnmSNuRHUMefqIBVKYwJoB()
			{
				return null;
			}
		}

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x0")]
		private static HardwareControllerMap_Game NadPxXYRifMljEYjJuhjIbsPVNdr;

		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x10")]
		private UpdateLoopDataSet<puflpgkLMPMHzuiiJIwEuxMmWYNg> TIBkwaYFfrlorrgEzKrMTlQMftSC;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x18")]
		private float[] OLQIvANwxPxdLvhhJWLJIxgsFjwC;

		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x20")]
		private bool[] cMJVUFvfQMWkvBtJpLdwMPYAPQtO;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x28")]
		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x29")]
		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		[Token(Token = "0x1700019A")]
		public bool enabled
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x2437EE4", Offset = "0x2437EE4", VA = "0x2437EE4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public InputSource inputSource
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2437FD8", Offset = "0x2437FD8", VA = "0x2437FD8", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019C")]
		public HardwareControllerMap_Game hardwareMap
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2437FE0", Offset = "0x2437FE0", VA = "0x2437FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019D")]
		public int buttonCount
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x24385C8", Offset = "0x24385C8", VA = "0x24385C8", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019E")]
		public int axisCount
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x24385D0", Offset = "0x24385D0", VA = "0x24385D0", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019F")]
		public Vector2 mousePosition
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x24385D8", Offset = "0x24385D8", VA = "0x24385D8", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A0")]
		public Controller.Extension controllerExtension
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2438610", Offset = "0x2438610", VA = "0x2438610", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2438618", Offset = "0x2438618", VA = "0x2438618")]
		public UnityUnifiedMouseSource()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2438954", Offset = "0x2438954", VA = "0x2438954", Slot = "12")]
		public void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2437F38", Offset = "0x2437F38", VA = "0x2437F38", Slot = "13")]
		public void Clear()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2438A38", Offset = "0x2438A38", VA = "0x2438A38")]
		private void BfPeRRMWMwfjUKkQCFCsSdeTWPdBA()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2438B18", Offset = "0x2438B18", VA = "0x2438B18")]
		private void HPfKmnGbWiEcZsNjewIkeEUMGOZFA(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x243804C", Offset = "0x243804C", VA = "0x243804C")]
		private static HardwareControllerMap_Game HStMDbOieMaNNxlRQxuGsFEKKaRE()
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2438B88", Offset = "0x2438B88", VA = "0x2438B88", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2438C0C", Offset = "0x2438C0C", VA = "0x2438C0C", Slot = "1")]
		~UnityUnifiedMouseSource()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2438CC0", Offset = "0x2438CC0", VA = "0x2438CC0", Slot = "14")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
