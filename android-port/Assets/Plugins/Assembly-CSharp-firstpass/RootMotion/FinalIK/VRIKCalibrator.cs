using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001DA")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20001DB")]
		public class Settings
		{
			[Token(Token = "0x4000C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scaleMlp;

			[Token(Token = "0x4000C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000C7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 headOffset;

			[Token(Token = "0x4000C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector3 handOffset;

			[Token(Token = "0x4000C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float footForwardOffset;

			[Token(Token = "0x4000C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float footInwardOffset;

			[Token(Token = "0x4000C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36AEC", Offset = "0x36AEC")]
			public float footHeadingOffset;

			[Token(Token = "0x4000C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36B0C", Offset = "0x36B0C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36B24", Offset = "0x36B24")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x1359B2C", Offset = "0x1359B2C", VA = "0x1359B2C")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001DC")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20001DD")]
			public class Target
			{
				[Token(Token = "0x4000C92")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000C93")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000C94")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000D86")]
				[Address(RVA = "0x135AF38", Offset = "0x135AF38", VA = "0x135AF38")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000D87")]
				[Address(RVA = "0x135AFF4", Offset = "0x135AFF4", VA = "0x135AFF4")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000C8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000C8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000C90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000C91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x1359B24", Offset = "0x1359B24", VA = "0x1359B24")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x1329C0C", Offset = "0x1329C0C", VA = "0x1329C0C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x1327F74", Offset = "0x1327F74", VA = "0x1327F74")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x1329D70", Offset = "0x1329D70", VA = "0x1329D70")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x13291D0", Offset = "0x13291D0", VA = "0x13291D0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x132A56C", Offset = "0x132A56C", VA = "0x132A56C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
}
