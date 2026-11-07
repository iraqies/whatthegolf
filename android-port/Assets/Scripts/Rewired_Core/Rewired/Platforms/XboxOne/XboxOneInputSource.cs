using System.Collections.Generic;
using Rewired.Platforms.Custom;

namespace Rewired.Platforms.XboxOne
{
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource
	{
		private enum BadConnectionReason
		{
			None = 0,
			GamepadNotActive = 1,
			InvalidName = 2
		}

		private struct KeIKjldUhnrhbxEDCqQPYBcpLrnR
		{
			public uint XiLNYbgSQRueYGNGMfEwcQjqkIZiA;

			public uint wqiepMikKKhrqfHDUTjbEWFFYBPIb;

			public KeIKjldUhnrhbxEDCqQPYBcpLrnR(uint P_0, uint P_1)
			{
				XiLNYbgSQRueYGNGMfEwcQjqkIZiA = 0u;
				wqiepMikKKhrqfHDUTjbEWFFYBPIb = 0u;
			}
		}

		private class eeJCpJPyLyCauVmvuyRDEsgwvGdw : Joystick
		{
			private readonly IXboxOneInputSource twtzIKfuPcwLuTdbfRDPmfUOUduI;

			private int ulCqkHwLZwjESRELyVoUMXJhfSsw;

			private ulong bFoBjtBxgrnmejxgvrbzdRweMJUJA;

			private string[] KIqgBODrHnRXqFsGFkLbIspBllAAB;

			public eeJCpJPyLyCauVmvuyRDEsgwvGdw(IXboxOneInputSource P_0, ulong P_1, int P_2, bool P_3)
				: base(null, null, 0, 0, 0)
			{
			}

			public override void Update()
			{
			}

			public void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(ulong P_0)
			{
			}

			private void EkXCrrMAdYVgltAlInmpCPmGNlBs()
			{
			}

			private bool IKCLDPTiIKTdmSlZPgUWaOkbUbhVA(int P_0)
			{
				return false;
			}

			private void rPtSeZBOGGRFLDbCvUnzwwfdVeJb()
			{
			}
		}

		private readonly bool jYTNgflwwEgvgbZuuTHYnPAnuRao;

		private Queue<KeIKjldUhnrhbxEDCqQPYBcpLrnR> fUtTCVwuOUQtKQMgsuQVPwKFAbYI;

		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		public override bool isReady => false;

		public XboxOneInputSource()
			: base(0)
		{
		}

		public override void Update()
		{
		}

		private void dcIWkUgDjpHhJaJAhasLaITZpIezA(uint P_0, bool P_1)
		{
		}

		private void TCOVEDFPeYeNnjpNbQHuiRleVdNuB(uint P_0, bool P_1)
		{
		}

		private void cqzbpIfBfoyibbCQFIZeDCjQRzcgb()
		{
		}

		private bool HIJBhUruJGvuQLxKyWqTuTalHYru(uint P_0, bool P_1, out BadConnectionReason P_2)
		{
			P_2 = default;
			return false;
		}

		public bool SetXboxOneVibration(ulong xboxOneJoystickId, OCxnhoeHJSmdQcYpgnyghAYbUGqI vibration)
		{
			return false;
		}

		public override void Dispose()
		{
		}

		~XboxOneInputSource()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
