using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000184")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000186")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000A17")]
				YawPitch = 0,
				[Token(Token = "0x4000A18")]
				FromTo = 1
			}

			[Token(Token = "0x40009F9")]
			[FieldOffset(Offset = "0x48")]
			public Transform target;

			[Token(Token = "0x40009FA")]
			[FieldOffset(Offset = "0x50")]
			public Transform bendGoal;

			[Token(Token = "0x40009FB")]
			[FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x362A0", Offset = "0x362A0")]
			public float positionWeight;

			[Token(Token = "0x40009FC")]
			[FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x362B8", Offset = "0x362B8")]
			public float rotationWeight;

			[Token(Token = "0x40009FD")]
			[FieldOffset(Offset = "0x60")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40009FE")]
			[FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x362D0", Offset = "0x362D0")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40009FF")]
			[FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x362E8", Offset = "0x362E8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000A00")]
			[FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36300", Offset = "0x36300")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A01")]
			[FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36318", Offset = "0x36318")]
			public float swivelOffset;

			[Token(Token = "0x4000A02")]
			[FieldOffset(Offset = "0x74")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000A03")]
			[FieldOffset(Offset = "0x80")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000A04")]
			[FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36338", Offset = "0x36338")]
			public float armLengthMlp;

			[Token(Token = "0x4000A05")]
			[FieldOffset(Offset = "0x90")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000A06")]
			[FieldOffset(Offset = "0x98")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000A07")]
			[FieldOffset(Offset = "0xA4")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000A08")]
			[FieldOffset(Offset = "0xB4")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000A09")]
			[FieldOffset(Offset = "0xC0")]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000A0A")]
			[FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36358", Offset = "0x36358")]
			private Vector3 position__BackingField;

			[Token(Token = "0x4000A0B")]
			[FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36368", Offset = "0x36368")]
			private Quaternion rotation__BackingField;

			[Token(Token = "0x4000A0C")]
			[FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000A0D")]
			[FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000A0E")]
			[FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000A0F")]
			[FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000A10")]
			[FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000A11")]
			[FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000A12")]
			[FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000A13")]
			[FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000A14")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000A15")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x1700016D")]
			public Vector3 position
			{
				[Token(Token = "0x6000B48")]
				[Address(RVA = "0x13400DC", Offset = "0x13400DC", VA = "0x13400DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A0BC", Offset = "0x3A0BC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B49")]
				[Address(RVA = "0x13400E8", Offset = "0x13400E8", VA = "0x13400E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A0CC", Offset = "0x3A0CC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700016E")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000B4A")]
				[Address(RVA = "0x13400F4", Offset = "0x13400F4", VA = "0x13400F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A0DC", Offset = "0x3A0DC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B4B")]
				[Address(RVA = "0x1340100", Offset = "0x1340100", VA = "0x1340100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A0EC", Offset = "0x3A0EC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700016F")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000B4C")]
				[Address(RVA = "0x134010C", Offset = "0x134010C", VA = "0x134010C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000170")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000B4D")]
				[Address(RVA = "0x1340140", Offset = "0x1340140", VA = "0x1340140")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000171")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000B4E")]
				[Address(RVA = "0x1340180", Offset = "0x1340180", VA = "0x1340180")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000172")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000B4F")]
				[Address(RVA = "0x13401CC", Offset = "0x13401CC", VA = "0x13401CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x1340218", Offset = "0x1340218", VA = "0x1340218", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x1340B38", Offset = "0x1340B38", VA = "0x1340B38", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x1340D60", Offset = "0x1340D60", VA = "0x1340D60", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x1340D84", Offset = "0x1340D84", VA = "0x1340D84")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x1341048", Offset = "0x1341048", VA = "0x1341048")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x1342DB0", Offset = "0x1342DB0", VA = "0x1342DB0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x1342DDC", Offset = "0x1342DDC", VA = "0x1342DDC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x1342300", Offset = "0x1342300", VA = "0x1342300")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default;
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x13424B0", Offset = "0x13424B0", VA = "0x13424B0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default;
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x1342FA8", Offset = "0x1342FA8", VA = "0x1342FA8")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000187")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000A19")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36378", Offset = "0x36378")]
			private float sqrMag__BackingField;

			[Token(Token = "0x4000A1A")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36388", Offset = "0x36388")]
			private float mag__BackingField;

			[Token(Token = "0x4000A1B")]
			[FieldOffset(Offset = "0x18")]
			public VirtualBone[] bones;

			[Token(Token = "0x4000A1C")]
			[FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000A1D")]
			[FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000A1E")]
			[FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000A1F")]
			[FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000A20")]
			[FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000173")]
			private float sqrMag
			{
				[Token(Token = "0x6000B5F")]
				[Address(RVA = "0x1343164", Offset = "0x1343164", VA = "0x1343164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A0FC", Offset = "0x3A0FC")]
				set
				{
				}
			}

			[Token(Token = "0x17000174")]
			public float mag
			{
				[Token(Token = "0x6000B60")]
				[Address(RVA = "0x134316C", Offset = "0x134316C", VA = "0x134316C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A10C", Offset = "0x3A10C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B61")]
				[Address(RVA = "0x1343174", Offset = "0x1343174", VA = "0x1343174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A11C", Offset = "0x3A11C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B5A")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000B5B")]
			public abstract void PreSolve();

			[Token(Token = "0x6000B5C")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000B5D")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000B5E")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x134317C", Offset = "0x134317C", VA = "0x134317C")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x1343184", Offset = "0x1343184", VA = "0x1343184")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x13433E8", Offset = "0x13433E8", VA = "0x13433E8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x1343468", Offset = "0x1343468", VA = "0x1343468")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x1342C68", Offset = "0x1342C68", VA = "0x1342C68")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x13430E8", Offset = "0x13430E8", VA = "0x13430E8")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000188")]
		public class Footstep
		{
			[Token(Token = "0x4000A21")]
			[FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000A22")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000A23")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000A24")]
			[FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000A25")]
			[FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000A26")]
			[FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000A27")]
			[FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36398", Offset = "0x36398")]
			private float stepProgress__BackingField;

			[Token(Token = "0x4000A28")]
			[FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000A29")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000A2A")]
			[FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000A2B")]
			[FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000A2C")]
			[FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000A2D")]
			[FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000A2E")]
			[FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000175")]
			public bool isStepping
			{
				[Token(Token = "0x6000B68")]
				[Address(RVA = "0x13436CC", Offset = "0x13436CC", VA = "0x13436CC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000176")]
			public float stepProgress
			{
				[Token(Token = "0x6000B69")]
				[Address(RVA = "0x13436E0", Offset = "0x13436E0", VA = "0x13436E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A12C", Offset = "0x3A12C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B6A")]
				[Address(RVA = "0x13436E8", Offset = "0x13436E8", VA = "0x13436E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A13C", Offset = "0x3A13C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x13436F0", Offset = "0x13436F0", VA = "0x13436F0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x1343834", Offset = "0x1343834", VA = "0x1343834")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x134387C", Offset = "0x134387C", VA = "0x134387C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x1343A24", Offset = "0x1343A24", VA = "0x1343A24")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x1343B94", Offset = "0x1343B94", VA = "0x1343B94")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x1343CE4", Offset = "0x1343CE4", VA = "0x1343CE4")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000189")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000A2F")]
			[FieldOffset(Offset = "0x48")]
			public Transform target;

			[Token(Token = "0x4000A30")]
			[FieldOffset(Offset = "0x50")]
			public Transform bendGoal;

			[Token(Token = "0x4000A31")]
			[FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x363A8", Offset = "0x363A8")]
			public float positionWeight;

			[Token(Token = "0x4000A32")]
			[FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x363C0", Offset = "0x363C0")]
			public float rotationWeight;

			[Token(Token = "0x4000A33")]
			[FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x363D8", Offset = "0x363D8")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A34")]
			[FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x363F0", Offset = "0x363F0")]
			public float swivelOffset;

			[Token(Token = "0x4000A35")]
			[FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36410", Offset = "0x36410")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000A36")]
			[FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36428", Offset = "0x36428")]
			public float legLengthMlp;

			[Token(Token = "0x4000A37")]
			[FieldOffset(Offset = "0x70")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000A38")]
			[FieldOffset(Offset = "0x78")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000A39")]
			[FieldOffset(Offset = "0x84")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000A3A")]
			[FieldOffset(Offset = "0x94")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A3B")]
			[FieldOffset(Offset = "0xA0")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A3C")]
			[FieldOffset(Offset = "0xAC")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A3D")]
			[FieldOffset(Offset = "0xBC")]
			public float currentMag;

			[Token(Token = "0x4000A3E")]
			[FieldOffset(Offset = "0xC0")]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000A3F")]
			[FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36448", Offset = "0x36448")]
			private Vector3 position__BackingField;

			[Token(Token = "0x4000A40")]
			[FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36458", Offset = "0x36458")]
			private Quaternion rotation__BackingField;

			[Token(Token = "0x4000A41")]
			[FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36468", Offset = "0x36468")]
			private bool hasToes__BackingField;

			[Token(Token = "0x4000A42")]
			[FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36478", Offset = "0x36478")]
			private Vector3 thighRelativeToPelvis__BackingField;

			[Token(Token = "0x4000A43")]
			[FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000A44")]
			[FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000A45")]
			[FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000A46")]
			[FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000A47")]
			[FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000A48")]
			[FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000A49")]
			[FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000177")]
			public Vector3 position
			{
				[Token(Token = "0x6000B71")]
				[Address(RVA = "0x1343E30", Offset = "0x1343E30", VA = "0x1343E30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A14C", Offset = "0x3A14C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B72")]
				[Address(RVA = "0x1343E3C", Offset = "0x1343E3C", VA = "0x1343E3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A15C", Offset = "0x3A15C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000178")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000B73")]
				[Address(RVA = "0x1343E48", Offset = "0x1343E48", VA = "0x1343E48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A16C", Offset = "0x3A16C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B74")]
				[Address(RVA = "0x1343E54", Offset = "0x1343E54", VA = "0x1343E54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A17C", Offset = "0x3A17C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000179")]
			public bool hasToes
			{
				[Token(Token = "0x6000B75")]
				[Address(RVA = "0x1343E60", Offset = "0x1343E60", VA = "0x1343E60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A18C", Offset = "0x3A18C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B76")]
				[Address(RVA = "0x1343E68", Offset = "0x1343E68", VA = "0x1343E68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A19C", Offset = "0x3A19C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700017A")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000B77")]
				[Address(RVA = "0x1343E70", Offset = "0x1343E70", VA = "0x1343E70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017B")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000B78")]
				[Address(RVA = "0x1343EA4", Offset = "0x1343EA4", VA = "0x1343EA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017C")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000B79")]
				[Address(RVA = "0x1343EDC", Offset = "0x1343EDC", VA = "0x1343EDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017D")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000B7A")]
				[Address(RVA = "0x1343F14", Offset = "0x1343F14", VA = "0x1343F14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017E")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000B7B")]
				[Address(RVA = "0x1343F4C", Offset = "0x1343F4C", VA = "0x1343F4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017F")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000B7C")]
				[Address(RVA = "0x1343F8C", Offset = "0x1343F8C", VA = "0x1343F8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A1AC", Offset = "0x3A1AC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B7D")]
				[Address(RVA = "0x1343F98", Offset = "0x1343F98", VA = "0x1343F98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A1BC", Offset = "0x3A1BC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x1343FA4", Offset = "0x1343FA4", VA = "0x1343FA4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x1344698", Offset = "0x1344698", VA = "0x1344698", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x1344C84", Offset = "0x1344C84", VA = "0x1344C84", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x1344C34", Offset = "0x1344C34", VA = "0x1344C34")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x1344AD4", Offset = "0x1344AD4", VA = "0x1344AD4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x1345064", Offset = "0x1345064", VA = "0x1345064")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x13454D4", Offset = "0x13454D4", VA = "0x13454D4")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x13451E8", Offset = "0x13451E8", VA = "0x13451E8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x1345798", Offset = "0x1345798", VA = "0x1345798", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x1345914", Offset = "0x1345914", VA = "0x1345914", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x1345960", Offset = "0x1345960", VA = "0x1345960")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018A")]
		public class Locomotion
		{
			[Token(Token = "0x4000A4A")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36488", Offset = "0x36488")]
			public float weight;

			[Token(Token = "0x4000A4B")]
			[FieldOffset(Offset = "0x14")]
			public float footDistance;

			[Token(Token = "0x4000A4C")]
			[FieldOffset(Offset = "0x18")]
			public float stepThreshold;

			[Token(Token = "0x4000A4D")]
			[FieldOffset(Offset = "0x1C")]
			public float angleThreshold;

			[Token(Token = "0x4000A4E")]
			[FieldOffset(Offset = "0x20")]
			public float comAngleMlp;

			[Token(Token = "0x4000A4F")]
			[FieldOffset(Offset = "0x24")]
			public float maxVelocity;

			[Token(Token = "0x4000A50")]
			[FieldOffset(Offset = "0x28")]
			public float velocityFactor;

			[Token(Token = "0x4000A51")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x364A0", Offset = "0x364A0")]
			public float maxLegStretch;

			[Token(Token = "0x4000A52")]
			[FieldOffset(Offset = "0x30")]
			public float rootSpeed;

			[Token(Token = "0x4000A53")]
			[FieldOffset(Offset = "0x34")]
			public float stepSpeed;

			[Token(Token = "0x4000A54")]
			[FieldOffset(Offset = "0x38")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000A55")]
			[FieldOffset(Offset = "0x40")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000A56")]
			[FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x364C0", Offset = "0x364C0")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000A57")]
			[FieldOffset(Offset = "0x4C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000A58")]
			[FieldOffset(Offset = "0x50")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000A59")]
			[FieldOffset(Offset = "0x54")]
			public Vector3 offset;

			[Token(Token = "0x4000A5A")]
			[FieldOffset(Offset = "0x60")]
			public bool blockingEnabled;

			[Token(Token = "0x4000A5B")]
			[FieldOffset(Offset = "0x64")]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000A5C")]
			[FieldOffset(Offset = "0x68")]
			public float raycastRadius;

			[Token(Token = "0x4000A5D")]
			[FieldOffset(Offset = "0x6C")]
			public float raycastHeight;

			[Token(Token = "0x4000A5E")]
			[FieldOffset(Offset = "0x70")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000A5F")]
			[FieldOffset(Offset = "0x78")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000A60")]
			[FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x364DC", Offset = "0x364DC")]
			private Vector3 centerOfMass__BackingField;

			[Token(Token = "0x4000A61")]
			[FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000A62")]
			[FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000A63")]
			[FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000A64")]
			[FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000A65")]
			[FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000180")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000B89")]
				[Address(RVA = "0x1345A8C", Offset = "0x1345A8C", VA = "0x1345A8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A1CC", Offset = "0x3A1CC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B8A")]
				[Address(RVA = "0x1345A98", Offset = "0x1345A98", VA = "0x1345A98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A1DC", Offset = "0x3A1DC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x1345AA4", Offset = "0x1345AA4", VA = "0x1345AA4")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x1345D34", Offset = "0x1345D34", VA = "0x1345D34")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x1345F4C", Offset = "0x1345F4C", VA = "0x1345F4C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x1346194", Offset = "0x1346194", VA = "0x1346194")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x1346258", Offset = "0x1346258", VA = "0x1346258")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000B90")]
			[Address(RVA = "0x1347388", Offset = "0x1347388", VA = "0x1347388")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default;
			}

			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x13474BC", Offset = "0x13474BC", VA = "0x13474BC")]
			private bool CanStep()
			{
				return default;
			}

			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x1347548", Offset = "0x1347548", VA = "0x1347548")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default;
			}

			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x1347614", Offset = "0x1347614", VA = "0x1347614")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018B")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000A66")]
			[FieldOffset(Offset = "0x48")]
			public Transform headTarget;

			[Token(Token = "0x4000A67")]
			[FieldOffset(Offset = "0x50")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000A68")]
			[FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x364EC", Offset = "0x364EC")]
			public float positionWeight;

			[Token(Token = "0x4000A69")]
			[FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36504", Offset = "0x36504")]
			public float rotationWeight;

			[Token(Token = "0x4000A6A")]
			[FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3651C", Offset = "0x3651C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000A6B")]
			[FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36534", Offset = "0x36534")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000A6C")]
			[FieldOffset(Offset = "0x68")]
			public Transform chestGoal;

			[Token(Token = "0x4000A6D")]
			[FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3654C", Offset = "0x3654C")]
			public float chestGoalWeight;

			[Token(Token = "0x4000A6E")]
			[FieldOffset(Offset = "0x74")]
			public float minHeadHeight;

			[Token(Token = "0x4000A6F")]
			[FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36564", Offset = "0x36564")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000A70")]
			[FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3657C", Offset = "0x3657C")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000A71")]
			[FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36594", Offset = "0x36594")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x36594", Offset = "0x36594")]
			public float neckStiffness;

			[Token(Token = "0x4000A72")]
			[FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x365E8", Offset = "0x365E8")]
			public float rotateChestByHands;

			[Token(Token = "0x4000A73")]
			[FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36600", Offset = "0x36600")]
			public float chestClampWeight;

			[Token(Token = "0x4000A74")]
			[FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36618", Offset = "0x36618")]
			public float headClampWeight;

			[Token(Token = "0x4000A75")]
			[FieldOffset(Offset = "0x90")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000A76")]
			[FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36630", Offset = "0x36630")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000A77")]
			[FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36648", Offset = "0x36648")]
			public float maxRootAngle;

			[Token(Token = "0x4000A78")]
			[FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36664", Offset = "0x36664")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x4000A79")]
			[FieldOffset(Offset = "0xA0")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000A7A")]
			[FieldOffset(Offset = "0xAC")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000A7B")]
			[FieldOffset(Offset = "0xBC")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000A7C")]
			[FieldOffset(Offset = "0xC8")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000A7D")]
			[FieldOffset(Offset = "0xD8")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000A7E")]
			[FieldOffset(Offset = "0xE4")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A7F")]
			[FieldOffset(Offset = "0xF0")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A80")]
			[FieldOffset(Offset = "0xFC")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A81")]
			[FieldOffset(Offset = "0x108")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A82")]
			[FieldOffset(Offset = "0x118")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A83")]
			[FieldOffset(Offset = "0x128")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A84")]
			[FieldOffset(Offset = "0x138")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000A85")]
			[FieldOffset(Offset = "0x144")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A86")]
			[FieldOffset(Offset = "0x150")]
			public Vector3 headPosition;

			[Token(Token = "0x4000A87")]
			[FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36684", Offset = "0x36684")]
			private Quaternion anchorRotation__BackingField;

			[Token(Token = "0x4000A88")]
			[FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36694", Offset = "0x36694")]
			private Quaternion anchorRelativeToHead__BackingField;

			[Token(Token = "0x4000A89")]
			[FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000A8A")]
			[FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000A8B")]
			[FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000A8C")]
			[FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000A8D")]
			[FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000A8E")]
			[FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000A8F")]
			[FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000A90")]
			[FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000A91")]
			[FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000A92")]
			[FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000A93")]
			[FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000A94")]
			[FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000A95")]
			[FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000A96")]
			[FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000A97")]
			[FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000A98")]
			[FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000A99")]
			[FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000A9A")]
			[FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000A9B")]
			[FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000A9C")]
			[FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x17000181")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000B94")]
				[Address(RVA = "0x1347308", Offset = "0x1347308", VA = "0x1347308")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000182")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000B95")]
				[Address(RVA = "0x1347724", Offset = "0x1347724", VA = "0x1347724")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000183")]
			public VirtualBone head
			{
				[Token(Token = "0x6000B96")]
				[Address(RVA = "0x1347348", Offset = "0x1347348", VA = "0x1347348")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000184")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000B97")]
				[Address(RVA = "0x134777C", Offset = "0x134777C", VA = "0x134777C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A1EC", Offset = "0x3A1EC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B98")]
				[Address(RVA = "0x1347790", Offset = "0x1347790", VA = "0x1347790")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A1FC", Offset = "0x3A1FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000185")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000B99")]
				[Address(RVA = "0x13477A4", Offset = "0x13477A4", VA = "0x13477A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A20C", Offset = "0x3A20C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000B9A")]
				[Address(RVA = "0x13477B8", Offset = "0x13477B8", VA = "0x13477B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A21C", Offset = "0x3A21C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x13477CC", Offset = "0x13477CC", VA = "0x13477CC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x1348198", Offset = "0x1348198", VA = "0x1348198", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x1348410", Offset = "0x1348410", VA = "0x1348410", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x1348880", Offset = "0x1348880", VA = "0x1348880")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x1348CC8", Offset = "0x1348CC8", VA = "0x1348CC8")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x1349484", Offset = "0x1349484", VA = "0x1349484")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x1349B30", Offset = "0x1349B30", VA = "0x1349B30")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x134A1B4", Offset = "0x134A1B4", VA = "0x134A1B4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x134A300", Offset = "0x134A300", VA = "0x134A300", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x1348A18", Offset = "0x1348A18", VA = "0x1348A18")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x134989C", Offset = "0x134989C", VA = "0x134989C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x13490EC", Offset = "0x13490EC", VA = "0x13490EC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x134A398", Offset = "0x134A398", VA = "0x134A398")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default;
			}

			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x1349964", Offset = "0x1349964", VA = "0x1349964")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x1349624", Offset = "0x1349624", VA = "0x1349624")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x134A5E0", Offset = "0x134A5E0", VA = "0x134A5E0")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000A9E")]
			Pelvis = 0,
			[Token(Token = "0x4000A9F")]
			Chest = 1,
			[Token(Token = "0x4000AA0")]
			Head = 2,
			[Token(Token = "0x4000AA1")]
			LeftHand = 3,
			[Token(Token = "0x4000AA2")]
			RightHand = 4,
			[Token(Token = "0x4000AA3")]
			LeftFoot = 5,
			[Token(Token = "0x4000AA4")]
			RightFoot = 6,
			[Token(Token = "0x4000AA5")]
			LeftHeel = 7,
			[Token(Token = "0x4000AA6")]
			RightHeel = 8
		}

		[Serializable]
		[Token(Token = "0x200018D")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000AA8")]
			Pelvis = 0,
			[Token(Token = "0x4000AA9")]
			Chest = 1,
			[Token(Token = "0x4000AAA")]
			Head = 2
		}

		[Serializable]
		[Token(Token = "0x200018E")]
		public class VirtualBone
		{
			[Token(Token = "0x4000AAB")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000AAC")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000AAD")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000AAE")]
			[FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000AAF")]
			[FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000AB0")]
			[FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000AB1")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x1340A9C", Offset = "0x1340A9C", VA = "0x1340A9C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x1340B18", Offset = "0x1340B18", VA = "0x1340B18")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x134A7E0", Offset = "0x134A7E0", VA = "0x134A7E0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x134323C", Offset = "0x134323C", VA = "0x134323C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default;
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x13435A0", Offset = "0x13435A0", VA = "0x13435A0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x134237C", Offset = "0x134237C", VA = "0x134237C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x134287C", Offset = "0x134287C", VA = "0x134287C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x134A960", Offset = "0x134A960", VA = "0x134A960")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default;
			}

			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x1349DD4", Offset = "0x1349DD4", VA = "0x1349DD4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x134AAC0", Offset = "0x134AAC0", VA = "0x134AAC0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default;
			}
		}

		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36278", Offset = "0x36278")]
		public int LOD;

		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0xC8")]
		public bool plantFeet;

		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36290", Offset = "0x36290")]
		private VirtualBone rootBone__BackingField;

		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0xD8")]
		public Spine spine;

		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0xE0")]
		public Arm leftArm;

		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0xE8")]
		public Arm rightArm;

		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0xF0")]
		public Leg leftLeg;

		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0xF8")]
		public Leg rightLeg;

		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x100")]
		public Locomotion locomotion;

		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700016C")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x139D280", Offset = "0x139D280", VA = "0x139D280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A09C", Offset = "0x3A09C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x139D288", Offset = "0x139D288", VA = "0x139D288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A0AC", Offset = "0x3A0AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x139984C", Offset = "0x139984C", VA = "0x139984C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1399CD8", Offset = "0x1399CD8", VA = "0x1399CD8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x1399B7C", Offset = "0x1399B7C", VA = "0x1399B7C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x139A440", Offset = "0x139A440", VA = "0x139A440")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x139A5A0", Offset = "0x139A5A0", VA = "0x139A5A0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x139A674", Offset = "0x139A674", VA = "0x139A674")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x139A764", Offset = "0x139A764", VA = "0x139A764", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x139A8E4", Offset = "0x139A8E4", VA = "0x139A8E4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x139AB28", Offset = "0x139AB28", VA = "0x139AB28", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x139ABA4", Offset = "0x139ABA4", VA = "0x139ABA4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x139AC20", Offset = "0x139AC20", VA = "0x139AC20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x1399F1C", Offset = "0x1399F1C", VA = "0x1399F1C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default;
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x139A008", Offset = "0x139A008", VA = "0x139A008")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default;
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x139A32C", Offset = "0x139A32C", VA = "0x139A32C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x139ADF8", Offset = "0x139ADF8", VA = "0x139ADF8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x139AF6C", Offset = "0x139AF6C", VA = "0x139AF6C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x139B4E0", Offset = "0x139B4E0", VA = "0x139B4E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x139C988", Offset = "0x139C988", VA = "0x139C988")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x139AFB4", Offset = "0x139AFB4", VA = "0x139AFB4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x139B848", Offset = "0x139B848", VA = "0x139B848")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x139CD4C", Offset = "0x139CD4C", VA = "0x139CD4C")]
		private Vector3 GetPosition(int index)
		{
			return default;
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x139CD90", Offset = "0x139CD90", VA = "0x139CD90")]
		private Quaternion GetRotation(int index)
		{
			return default;
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x139C834", Offset = "0x139C834", VA = "0x139C834")]
		private void Write()
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x139CDD0", Offset = "0x139CDD0", VA = "0x139CDD0")]
		private Vector3 GetPelvisOffset()
		{
			return default;
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x139D290", Offset = "0x139D290", VA = "0x139D290")]
		public IKSolverVR()
		{
		}
	}
}
