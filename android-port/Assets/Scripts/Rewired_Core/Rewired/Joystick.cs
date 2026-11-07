using System;
using System.Collections.ObjectModel;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

namespace Rewired
{
	public class Joystick : ControllerWithAxes
	{
		private const int OhrFFSZMzOTDmDfeFKMpnIEqEzKW = 0;

		private const int dXWFHhEjXVHNkmSNuzPizcIEcTZH = 1;

		private IInputManagerJoystickPublic EatmzbjgpSKzrpMZwcWwOZUZiihP;

		private readonly JoystickType[] HMZZjJkCjEaHRLhyIqzCkjuwNAwd;

		private readonly ReadOnlyCollection<JoystickType> eXSMJXNrBEOMtsJspAcSHHvOvIdi;

		private readonly bool OlbVRqsSBEtRqSittUWERZaqzxXk;

		private readonly bool sWgekvUoGxEjnAXOtkFlKFVqFVAl;

		private readonly bool riIYUkZICekLoeJBrMrGBAvCabsX;

		private readonly int RQswxjUgvoJzPcaSYFLfcfxGvkxsA;

		private readonly float[] cHApXOnOYvppOsbuqcPjWIcGOsIi;

		private readonly TimerAbs[] ifDixddKyelvbcKEcCwEkmKwiwjLb;

		private readonly int nGzbpVDglcowGGmUjmoNUvXQietbA;

		private readonly Hat[] lQCkuukVwwDBOwsdnsTAxXUgANcx;

		private readonly ReadOnlyCollection<Hat> JaHbtlSQSGxZzASGripXpCSsrmkd;

		public long? systemId => null;

		public int unityId => 0;

		public override Guid deviceInstanceGuid => default;

		public bool supportsVibration => false;

		public int vibrationMotorCount => 0;

		public int hatCount => 0;

		internal int zfwMqMcMdqXTQMwrxKsBjTZHvIF => AjHAHZhBCFfIHUXWrXSROxnIvTGuA();

		internal HardwareControllerMapIdentifier BBOiFMbIkLuQbioSkwqyhykKdIjtA => OLuURksjMCAscnjWSFolIUnwIeZRA();

		internal int AjHAHZhBCFfIHUXWrXSROxnIvTGuA()
		{
			return 0;
		}

		internal HardwareControllerMapIdentifier OLuURksjMCAscnjWSFolIUnwIeZRA()
		{
			return default;
		}

		internal Joystick(BridgedController P_0)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, 0, null, null, null, null)
		{
		}

		private Joystick(int P_0, InputSource P_1, string P_2, string P_3, string P_4, Guid P_5, int P_6, int P_7, bool[] P_8, HardwareControllerMap_Game P_9, Extension P_10, ControllerDataUpdater P_11)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, 0, null, null, null, null)
		{
		}

		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData()
		{
			return null;
		}

		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public void StopVibration()
		{
		}

		internal override void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		internal void UByBUxdeeRfyWdxWnNFetplCMBqd(UpdateControllerInfoEventArgs P_0)
		{
		}

		internal void UByBUxdeeRfyWdxWnNFetplCMBqd(BridgedController P_0)
		{
		}

		private void UByBUxdeeRfyWdxWnNFetplCMBqd(IInputManagerJoystickPublic P_0)
		{
		}

		internal override void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		internal override void xKXEQmiiNXKorUsTsPlIOtwcwnfr(bool P_0)
		{
		}

		protected override void Disconnected()
		{
		}

		private void RkjJWtCPffqNHKYZiSpumVKUPDFy()
		{
		}

		private void bHBLahoTRLPtRodWlXSmrvvlJxqN(int P_0, float P_1, float P_2, bool P_3, bool P_4)
		{
		}

		private void BgjoCYeKFJqCzlQmKKzPOUmZoLiG()
		{
		}

		internal static int BLBeFCaTjYjfxFliEgaztNfvQKfCA(Joystick P_0, Joystick P_1)
		{
			return 0;
		}
	}
}
