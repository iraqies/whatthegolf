using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000202")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000203")]
		public class Partner
		{
			[Token(Token = "0x4000D89")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000D8A")]
			[FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000D8B")]
			[FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000D8C")]
			[FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000D8D")]
			[FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000D8E")]
			[FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000D8F")]
			[FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000D90")]
			[FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000D91")]
			[FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000D92")]
			[FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000D93")]
			[FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170001C0")]
			private Transform neck
			{
				[Token(Token = "0x6000E17")]
				[Address(RVA = "0x134EF78", Offset = "0x134EF78", VA = "0x134EF78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000E15")]
			[Address(RVA = "0x134E840", Offset = "0x134E840", VA = "0x134E840")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x134E860", Offset = "0x134E860", VA = "0x134E860")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000E18")]
			[Address(RVA = "0x134EDEC", Offset = "0x134EDEC", VA = "0x134EDEC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000E19")]
			[Address(RVA = "0x134EFD0", Offset = "0x134EFD0", VA = "0x134EFD0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x13A7E10", Offset = "0x13A7E10", VA = "0x13A7E10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x13A7E4C", Offset = "0x13A7E4C", VA = "0x13A7E4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x13A7EB4", Offset = "0x13A7EB4", VA = "0x13A7EB4")]
		public KissingRig()
		{
		}
	}
}
