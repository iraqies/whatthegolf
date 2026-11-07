using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000DC")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x74")]
		public bool bakeHandIK;

		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RangeAttribute", RVA = "0x353EC", Offset = "0x353EC")]
		public float IKKeyReductionError;

		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x3540C", Offset = "0x3540C")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1383E74", Offset = "0x1383E74", VA = "0x1383E74")]
		private void Awake()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x138434C", Offset = "0x138434C", VA = "0x138434C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1384368", Offset = "0x1384368", VA = "0x1384368", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1384444", Offset = "0x1384444", VA = "0x1384444", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1384520", Offset = "0x1384520", VA = "0x1384520", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x13846F0", Offset = "0x13846F0", VA = "0x13846F0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x13849A8", Offset = "0x13849A8", VA = "0x13849A8")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1384A90", Offset = "0x1384A90", VA = "0x1384A90")]
		public HumanoidBaker()
		{
		}
	}
}
