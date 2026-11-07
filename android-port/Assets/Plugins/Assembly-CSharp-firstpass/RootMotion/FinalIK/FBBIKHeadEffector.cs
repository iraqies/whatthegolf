using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200015F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000160")]
		public class BendBone
		{
			[Token(Token = "0x400089E")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400089F")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35E70", Offset = "0x35E70")]
			public float weight;

			[Token(Token = "0x40008A0")]
			[FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x1339FAC", Offset = "0x1339FAC", VA = "0x1339FAC")]
			public BendBone()
			{
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x1339FE8", Offset = "0x1339FE8", VA = "0x1339FE8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x133A020", Offset = "0x133A020", VA = "0x133A020")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35D4C", Offset = "0x35D4C")]
		public float positionWeight;

		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35D64", Offset = "0x35D64")]
		public float bodyWeight;

		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35D7C", Offset = "0x35D7C")]
		public float thighWeight;

		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x2C")]
		public bool handsPullBody;

		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35D94", Offset = "0x35D94")]
		public float rotationWeight;

		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35DAC", Offset = "0x35DAC")]
		public float bodyClampWeight;

		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35DC4", Offset = "0x35DC4")]
		public float headClampWeight;

		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35DDC", Offset = "0x35DDC")]
		public float bendWeight;

		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x40")]
		public BendBone[] bendBones;

		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35DF4", Offset = "0x35DF4")]
		public float CCDWeight;

		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35E0C", Offset = "0x35E0C")]
		public float roll;

		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35E24", Offset = "0x35E24")]
		public float damper;

		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x58")]
		public Transform[] CCDBones;

		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35E40", Offset = "0x35E40")]
		public float postStretchWeight;

		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x64")]
		public float maxStretch;

		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x68")]
		public float stretchDamper;

		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x6C")]
		public bool fixHead;

		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x70")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35E58", Offset = "0x35E58")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1369AF0", Offset = "0x1369AF0", VA = "0x1369AF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1369E64", Offset = "0x1369E64", VA = "0x1369E64")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x136A328", Offset = "0x136A328", VA = "0x136A328")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x136A720", Offset = "0x136A720", VA = "0x136A720")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x136AEC0", Offset = "0x136AEC0", VA = "0x136AEC0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x136B1B0", Offset = "0x136B1B0", VA = "0x136B1B0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x136B4B8", Offset = "0x136B4B8", VA = "0x136B4B8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x136BD60", Offset = "0x136BD60", VA = "0x136BD60")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x136ACA0", Offset = "0x136ACA0", VA = "0x136ACA0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x136BF28", Offset = "0x136BF28", VA = "0x136BF28")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x136BC58", Offset = "0x136BC58", VA = "0x136BC58")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x136BB78", Offset = "0x136BB78", VA = "0x136BB78")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x136C1C4", Offset = "0x136C1C4", VA = "0x136C1C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x136C4D4", Offset = "0x136C4D4", VA = "0x136C4D4")]
		public FBBIKHeadEffector()
		{
		}
	}
}
