using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Platforms.Custom;

namespace Rewired.Platforms.XboxOne
{
	[Token(Token = "0x20001A1")]
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource
	{
		[Token(Token = "0x20001A2")]
		private enum BadConnectionReason
		{
			[Token(Token = "0x400096C")]
			None = 0,
			[Token(Token = "0x400096D")]
			GamepadNotActive = 1,
			[Token(Token = "0x400096E")]
			InvalidName = 2
		}

		[Token(Token = "0x20001A3")]
		private struct KeIKjldUhnrhbxEDCqQPYBcpLrnR
		{
			[Token(Token = "0x400096F")]
			[FieldOffset(Offset = "0x0")]
			public uint XiLNYbgSQRueYGNGMfEwcQjqkIZiA;

			[Token(Token = "0x4000970")]
			[FieldOffset(Offset = "0x4")]
			public uint wqiepMikKKhrqfHDUTjbEWFFYBPIb;

			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0x239CD14", Offset = "0x239CD14", VA = "0x239CD14")]
			public KeIKjldUhnrhbxEDCqQPYBcpLrnR(uint P_0, uint P_1)
			{
			}
		}

		[Token(Token = "0x20001A4")]
		private class eeJCpJPyLyCauVmvuyRDEsgwvGdw : Joystick
		{
			[Token(Token = "0x4000971")]
			[FieldOffset(Offset = "0x70")]
			private readonly IXboxOneInputSource twtzIKfuPcwLuTdbfRDPmfUOUduI;

			[Token(Token = "0x4000972")]
			[FieldOffset(Offset = "0x78")]
			private int ulCqkHwLZwjESRELyVoUMXJhfSsw;

			[Token(Token = "0x4000973")]
			[FieldOffset(Offset = "0x80")]
			private ulong bFoBjtBxgrnmejxgvrbzdRweMJUJA;

			[Token(Token = "0x4000974")]
			[FieldOffset(Offset = "0x88")]
			private string[] KIqgBODrHnRXqFsGFkLbIspBllAAB;

			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x239CD1C", Offset = "0x239CD1C", VA = "0x239CD1C")]
			public eeJCpJPyLyCauVmvuyRDEsgwvGdw(IXboxOneInputSource P_0, ulong P_1, int P_2, bool P_3)
			{
			}

			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0x239D2EC", Offset = "0x239D2EC", VA = "0x239D2EC", Slot = "4")]
			public virtual void jRaYtHNVcykNMAbqOnSGaKIIGSEaA()
			{
			}

			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x239D168", Offset = "0x239D168", VA = "0x239D168")]
			public void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(ulong P_0)
			{
			}

			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x239DEFC", Offset = "0x239DEFC", VA = "0x239DEFC")]
			private void EkXCrrMAdYVgltAlInmpCPmGNlBs()
			{
			}

			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x239DEE4", Offset = "0x239DEE4", VA = "0x239DEE4")]
			private bool IKCLDPTiIKTdmSlZPgUWaOkbUbhVA(int P_0)
			{
				return default;
			}

			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x239CF48", Offset = "0x239CF48", VA = "0x239CF48")]
			private void rPtSeZBOGGRFLDbCvUnzwwfdVeJb()
			{
			}
		}

		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x41")]
		private readonly bool jYTNgflwwEgvgbZuuTHYnPAnuRao;

		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x48")]
		private Queue<KeIKjldUhnrhbxEDCqQPYBcpLrnR> fUtTCVwuOUQtKQMgsuQVPwKFAbYI;

		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x50")]
		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		[Token(Token = "0x1700037E")]
		public override bool isReady
		{
			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x24400EC", Offset = "0x24400EC", VA = "0x24400EC", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x24400F4", Offset = "0x24400F4", VA = "0x24400F4")]
		public XboxOneInputSource()
		{
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x24407C8", Offset = "0x24407C8", VA = "0x24407C8", Slot = "10")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x2440B98", Offset = "0x2440B98", VA = "0x2440B98")]
		private void dcIWkUgDjpHhJaJAhasLaITZpIezA(uint P_0, bool P_1)
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x2440D5C", Offset = "0x2440D5C", VA = "0x2440D5C")]
		private void TCOVEDFPeYeNnjpNbQHuiRleVdNuB(uint P_0, bool P_1)
		{
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x2440A00", Offset = "0x2440A00", VA = "0x2440A00")]
		private void cqzbpIfBfoyibbCQFIZeDCjQRzcgb()
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x24404AC", Offset = "0x24404AC", VA = "0x24404AC")]
		private bool HIJBhUruJGvuQLxKyWqTuTalHYru(uint P_0, bool P_1, out BadConnectionReason P_2)
		{
			return default;
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x2440F64", Offset = "0x2440F64", VA = "0x2440F64", Slot = "11")]
		public bool SetXboxOneVibration(ulong xboxOneJoystickId, OCxnhoeHJSmdQcYpgnyghAYbUGqI vibration)
		{
			return default;
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x24410A8", Offset = "0x24410A8", VA = "0x24410A8", Slot = "7")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x2441134", Offset = "0x2441134", VA = "0x2441134", Slot = "1")]
		~XboxOneInputSource()
		{
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x24411E4", Offset = "0x24411E4", VA = "0x24411E4", Slot = "8")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
