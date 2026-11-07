using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000220")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x20")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x28")]
		public Transform headTracker;

		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x30")]
		public Transform bodyTracker;

		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x38")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x40")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x48")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x50")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x58")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x1327E10", Offset = "0x1327E10", VA = "0x1327E10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x1329D04", Offset = "0x1329D04", VA = "0x1329D04")]
		public VRIKCalibrationController()
		{
		}
	}
}
