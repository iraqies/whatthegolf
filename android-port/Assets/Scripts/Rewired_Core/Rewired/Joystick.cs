using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

namespace Rewired
{
	[Token(Token = "0x2000044")]
	public class Joystick : ControllerWithAxes
	{
		[Token(Token = "0x400017B")]
		private const int OhrFFSZMzOTDmDfeFKMpnIEqEzKW = 0;

		[Token(Token = "0x400017C")]
		private const int dXWFHhEjXVHNkmSNuzPizcIEcTZH = 1;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x158")]
		private IInputManagerJoystickPublic EatmzbjgpSKzrpMZwcWwOZUZiihP;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x160")]
		private readonly JoystickType[] HMZZjJkCjEaHRLhyIqzCkjuwNAwd;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x168")]
		private readonly ReadOnlyCollection<JoystickType> eXSMJXNrBEOMtsJspAcSHHvOvIdi;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x170")]
		private readonly bool OlbVRqsSBEtRqSittUWERZaqzxXk;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x171")]
		private readonly bool sWgekvUoGxEjnAXOtkFlKFVqFVAl;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x172")]
		private readonly bool riIYUkZICekLoeJBrMrGBAvCabsX;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x174")]
		private readonly int RQswxjUgvoJzPcaSYFLfcfxGvkxsA;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x178")]
		private readonly float[] cHApXOnOYvppOsbuqcPjWIcGOsIi;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x180")]
		private readonly TimerAbs[] ifDixddKyelvbcKEcCwEkmKwiwjLb;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x188")]
		private readonly int nGzbpVDglcowGGmUjmoNUvXQietbA;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x190")]
		private readonly Hat[] lQCkuukVwwDBOwsdnsTAxXUgANcx;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x198")]
		private readonly ReadOnlyCollection<Hat> JaHbtlSQSGxZzASGripXpCSsrmkd;

		[Token(Token = "0x1700009A")]
		public long? systemId
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x23DEA88", Offset = "0x23DEA88", VA = "0x23DEA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public int unityId
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x23DEBF4", Offset = "0x23DEBF4", VA = "0x23DEBF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009C")]
		public override Guid deviceInstanceGuid
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x23DED34", Offset = "0x23DED34", VA = "0x23DED34", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009D")]
		public bool supportsVibration
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x23DEEA8", Offset = "0x23DEEA8", VA = "0x23DEEA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009E")]
		public int vibrationMotorCount
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x23DEF5C", Offset = "0x23DEF5C", VA = "0x23DEF5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009F")]
		public int hatCount
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x23DF0DC", Offset = "0x23DF0DC", VA = "0x23DF0DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A0")]
		internal int zfwMqMcMdqXTQMwrxKsBjTZHvIF
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x23DF18C", Offset = "0x23DF18C", VA = "0x23DF18C")]
			get
			{
				return AjHAHZhBCFfIHUXWrXSROxnIvTGuA();
			}
		}

		[Token(Token = "0x170000A1")]
		internal HardwareControllerMapIdentifier BBOiFMbIkLuQbioSkwqyhykKdIjtA
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x23DF244", Offset = "0x23DF244", VA = "0x23DF244")]
			get
			{
				return OLuURksjMCAscnjWSFolIUnwIeZRA();
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x23DF18C", Offset = "0x23DF18C", VA = "0x23DF18C")]
		internal int AjHAHZhBCFfIHUXWrXSROxnIvTGuA()
		{
			return default;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x23DF244", Offset = "0x23DF244", VA = "0x23DF244")]
		internal HardwareControllerMapIdentifier OLuURksjMCAscnjWSFolIUnwIeZRA()
		{
			return default;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x23DF270", Offset = "0x23DF270", VA = "0x23DF270")]
		internal Joystick(BridgedController P_0)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x23DFB00", Offset = "0x23DFB00", VA = "0x23DFB00")]
		private Joystick(int P_0, InputSource P_1, string P_2, string P_3, string P_4, Guid P_5, int P_6, int P_7, bool[] P_8, HardwareControllerMap_Game P_9, Extension P_10, ControllerDataUpdater P_11)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x23E03A4", Offset = "0x23E03A4", VA = "0x23E03A4")]
		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData()
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x23E04F8", Offset = "0x23E04F8", VA = "0x23E04F8")]
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x23E0500", Offset = "0x23E0500", VA = "0x23E0500")]
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x23E0854", Offset = "0x23E0854", VA = "0x23E0854")]
		public void StopVibration()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x23E0AB8", Offset = "0x23E0AB8", VA = "0x23E0AB8", Slot = "13")]
		internal override void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x23E0C04", Offset = "0x23E0C04", VA = "0x23E0C04")]
		internal void UByBUxdeeRfyWdxWnNFetplCMBqd(UpdateControllerInfoEventArgs P_0)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x23E0E70", Offset = "0x23E0E70", VA = "0x23E0E70")]
		internal void UByBUxdeeRfyWdxWnNFetplCMBqd(BridgedController P_0)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x23E0C14", Offset = "0x23E0C14", VA = "0x23E0C14")]
		private void UByBUxdeeRfyWdxWnNFetplCMBqd(IInputManagerJoystickPublic P_0)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x23E0E80", Offset = "0x23E0E80", VA = "0x23E0E80", Slot = "15")]
		internal override void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x23E0EA8", Offset = "0x23E0EA8", VA = "0x23E0EA8", Slot = "19")]
		internal override void xKXEQmiiNXKorUsTsPlIOtwcwnfr(bool P_0)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x23E0F44", Offset = "0x23E0F44", VA = "0x23E0F44", Slot = "21")]
		protected override void Disconnected()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x23E0B54", Offset = "0x23E0B54", VA = "0x23E0B54")]
		private void RkjJWtCPffqNHKYZiSpumVKUPDFy()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x23E06D4", Offset = "0x23E06D4", VA = "0x23E06D4")]
		private void bHBLahoTRLPtRodWlXSmrvvlJxqN(int P_0, float P_1, float P_2, bool P_3, bool P_4)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x23E10C0", Offset = "0x23E10C0", VA = "0x23E10C0")]
		private void BgjoCYeKFJqCzlQmKKzPOUmZoLiG()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x23E11F8", Offset = "0x23E11F8", VA = "0x23E11F8")]
		internal static int BLBeFCaTjYjfxFliEgaztNfvQKfCA(Joystick P_0, Joystick P_1)
		{
			return default;
		}
	}
}
