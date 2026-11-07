using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	[Token(Token = "0x200010B")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public enum Group
		{
			[Token(Token = "0x4000637")]
			Hips = 0,
			[Token(Token = "0x4000638")]
			Spine = 1,
			[Token(Token = "0x4000639")]
			Head = 2,
			[Token(Token = "0x400063A")]
			Arm = 3,
			[Token(Token = "0x400063B")]
			Hand = 4,
			[Token(Token = "0x400063C")]
			Leg = 5,
			[Token(Token = "0x400063D")]
			Foot = 6,
			[Token(Token = "0x400063E")]
			Tail = 7,
			[Token(Token = "0x400063F")]
			Prop = 8
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public class InternalCollisionIgnoreSettings
		{
			[Token(Token = "0x4000640")]
			[FieldOffset(Offset = "0x10")]
			public bool ignoreAll;

			[Token(Token = "0x4000641")]
			[FieldOffset(Offset = "0x18")]
			public ConfigurableJoint[] muscles;

			[Token(Token = "0x4000642")]
			[FieldOffset(Offset = "0x20")]
			public Group[] groups;

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x134FD10", Offset = "0x134FD10", VA = "0x134FD10")]
			public InternalCollisionIgnoreSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010E")]
		public class Props
		{
			[Token(Token = "0x4000643")]
			[FieldOffset(Offset = "0x10")]
			public Group group;

			[Token(Token = "0x4000644")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3577C", Offset = "0x3577C")]
			public float mappingWeight;

			[Token(Token = "0x4000645")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35794", Offset = "0x35794")]
			public float pinWeight;

			[Token(Token = "0x4000646")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x357AC", Offset = "0x357AC")]
			public float muscleWeight;

			[Token(Token = "0x4000647")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x357C4", Offset = "0x357C4")]
			public float muscleDamper;

			[Token(Token = "0x4000648")]
			[FieldOffset(Offset = "0x24")]
			public bool mapPosition;

			[Token(Token = "0x4000649")]
			[FieldOffset(Offset = "0x28")]
			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			[Token(Token = "0x400064A")]
			[FieldOffset(Offset = "0x30")]
			public Transform[] animatedTargetChildren;

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x134FD98", Offset = "0x134FD98", VA = "0x134FD98")]
			public Props()
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x134FEB0", Offset = "0x134FEB0", VA = "0x134FEB0")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x134FFF8", Offset = "0x134FFF8", VA = "0x134FFF8")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x200010F")]
		public struct State
		{
			[Token(Token = "0x400064B")]
			[FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x400064C")]
			[FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x400064D")]
			[FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x400064E")]
			[FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x400064F")]
			[FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x4000650")]
			[FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x4000651")]
			[FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x4000652")]
			[FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x4000653")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x4000654")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x4000655")]
			[FieldOffset(Offset = "0x38")]
			public bool isDisconnected;

			[Token(Token = "0x4000656")]
			[FieldOffset(Offset = "0x39")]
			public bool resetFlag;

			[Token(Token = "0x170000F7")]
			public static State Default
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0x1350074", Offset = "0x1350074", VA = "0x1350074")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1350098", Offset = "0x1350098", VA = "0x1350098")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000110")]
		public class TargetChild
		{
			[Token(Token = "0x4000657")]
			[FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000658")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000659")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1350128", Offset = "0x1350128", VA = "0x1350128")]
			public TargetChild(Transform t)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1350198", Offset = "0x1350198", VA = "0x1350198")]
			public void Map()
			{
			}
		}

		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x70")]
		public int[] parentIndexes;

		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x78")]
		public int[] childIndexes;

		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x80")]
		public bool[] childFlags;

		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x88")]
		public int[] kinshipDegrees;

		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x90")]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x98")]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 positionOffset;

		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3566C", Offset = "0x3566C")]
		private Transform transform__BackingField;

		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3567C", Offset = "0x3567C")]
		private Rigidbody rigidbody__BackingField;

		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3568C", Offset = "0x3568C")]
		private Transform connectedBodyTarget__BackingField;

		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3569C", Offset = "0x3569C")]
		private Vector3 targetAnimatedPosition__BackingField;

		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x356AC", Offset = "0x356AC")]
		private Quaternion targetAnimatedWorldRotation__BackingField;

		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x356BC", Offset = "0x356BC")]
		private Vector3 targetVelocity__BackingField;

		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x356CC", Offset = "0x356CC")]
		private Rigidbody additionalRigidbody__BackingField;

		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		public Transform additionalPinTarget;

		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		public float additionalPinWeight;

		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x10C")]
		public Vector3 mappedVelocity;

		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x118")]
		public Vector3 mappedAngularVelocity;

		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x124")]
		public bool isPropMuscle;

		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		public int index;

		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3571C", Offset = "0x3571C")]
		private Quaternion targetRotationRelative__BackingField;

		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3572C", Offset = "0x3572C")]
		private Rigidbody rebuildConnectedBody__BackingField;

		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3573C", Offset = "0x3573C")]
		private Transform rebuildTargetParent__BackingField;

		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3574C", Offset = "0x3574C")]
		private Vector3 defaultTargetPosRelToMuscle__BackingField;

		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3575C", Offset = "0x3575C")]
		private Quaternion defaultTargetRotRelToMuscle__BackingField;

		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3576C", Offset = "0x3576C")]
		private Quaternion defaultMuscleRotRelToTarget__BackingField;

		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x180")]
		private Transform rebuildParent;

		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x188")]
		private Vector3 rebuildPosition;

		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x194")]
		private Quaternion rebuildRotation;

		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x1A4")]
		private Vector3 rebuildTargetPosition;

		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x1B0")]
		private Quaternion rebuildTargetRotation;

		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x1C0")]
		private ConfigurableJointMotion rebuildAngularXMotion;

		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x1C4")]
		private ConfigurableJointMotion rebuildAngularYMotion;

		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x1C8")]
		private ConfigurableJointMotion rebuildAngularZMotion;

		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x1CC")]
		public Vector3 targetMappedPosition;

		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x1D8")]
		public Quaternion targetMappedRotation;

		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x1E8")]
		public Vector3 targetSampledPosition;

		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x1F4")]
		public Quaternion targetSampledRotation;

		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x204")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x210")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x214")]
		private float lastRotationDamper;

		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x218")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x224")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x230")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x23C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x24C")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x25C")]
		private Quaternion toParentSpace;

		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x26C")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x27C")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x28C")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x29C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x2AC")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x2BC")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x2CC")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x2E0")]
		private Transform targetParent;

		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x2E8")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x2F0")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0x2F4")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x2F8")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x2FC")]
		private bool directTargetParent;

		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x2FD")]
		private bool initiated;

		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x300")]
		private Collider[] _colliders;

		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x308")]
		private float lastReadTime;

		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x30C")]
		private float lastWriteTime;

		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x310")]
		private bool[] disabledColliders;

		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x318")]
		private TargetChild[] targetChildren;

		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x320")]
		private Vector3 additionalTargetVelocity;

		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x32C")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x338")]
		private Vector3 additionalPinTargetAnimatedCenterOfMass;

		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x344")]
		private Quaternion defaultTargetRotRelToMuscleInverse;

		[Token(Token = "0x170000E5")]
		public Transform transform
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x13B5694", Offset = "0x13B5694", VA = "0x13B5694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38594", Offset = "0x38594")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x13B569C", Offset = "0x13B569C", VA = "0x13B569C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x385A4", Offset = "0x385A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x13B56A4", Offset = "0x13B56A4", VA = "0x13B56A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x385B4", Offset = "0x385B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x13B56AC", Offset = "0x13B56AC", VA = "0x13B56AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x385C4", Offset = "0x385C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x13B56B4", Offset = "0x13B56B4", VA = "0x13B56B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x385D4", Offset = "0x385D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x13B56BC", Offset = "0x13B56BC", VA = "0x13B56BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x385E4", Offset = "0x385E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x13B56C4", Offset = "0x13B56C4", VA = "0x13B56C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x385F4", Offset = "0x385F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x13B56D0", Offset = "0x13B56D0", VA = "0x13B56D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38604", Offset = "0x38604")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public Quaternion targetAnimatedWorldRotation
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x13B56DC", Offset = "0x13B56DC", VA = "0x13B56DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38614", Offset = "0x38614")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x13B56E8", Offset = "0x13B56E8", VA = "0x13B56E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38624", Offset = "0x38624")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Collider[] colliders
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x13B56F4", Offset = "0x13B56F4", VA = "0x13B56F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x13B56FC", Offset = "0x13B56FC", VA = "0x13B56FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x13B5704", Offset = "0x13B5704", VA = "0x13B5704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38634", Offset = "0x38634")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x13B5710", Offset = "0x13B5710", VA = "0x13B5710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38644", Offset = "0x38644")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public Rigidbody additionalRigidbody
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x13B571C", Offset = "0x13B571C", VA = "0x13B571C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38654", Offset = "0x38654")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x13B5724", Offset = "0x13B5724", VA = "0x13B5724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38664", Offset = "0x38664")]
			private set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x13B572C", Offset = "0x13B572C", VA = "0x13B572C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38674", Offset = "0x38674")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x13B5740", Offset = "0x13B5740", VA = "0x13B5740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38684", Offset = "0x38684")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public Rigidbody rebuildConnectedBody
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x13B5984", Offset = "0x13B5984", VA = "0x13B5984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38694", Offset = "0x38694")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x13B598C", Offset = "0x13B598C", VA = "0x13B598C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x386A4", Offset = "0x386A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public Transform rebuildTargetParent
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x13B5994", Offset = "0x13B5994", VA = "0x13B5994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x386B4", Offset = "0x386B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x13B599C", Offset = "0x13B599C", VA = "0x13B599C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x386C4", Offset = "0x386C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public Vector3 defaultTargetPosRelToMuscle
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x13B59A4", Offset = "0x13B59A4", VA = "0x13B59A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x386D4", Offset = "0x386D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x13B59B4", Offset = "0x13B59B4", VA = "0x13B59B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x386E4", Offset = "0x386E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public Quaternion defaultTargetRotRelToMuscle
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x13B59C4", Offset = "0x13B59C4", VA = "0x13B59C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x386F4", Offset = "0x386F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x13B59D8", Offset = "0x13B59D8", VA = "0x13B59D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38704", Offset = "0x38704")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public Quaternion defaultMuscleRotRelToTarget
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x13B59EC", Offset = "0x13B59EC", VA = "0x13B59EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38714", Offset = "0x38714")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x13B5A00", Offset = "0x13B5A00", VA = "0x13B5A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38724", Offset = "0x38724")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		private Quaternion localRotation
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x13B6E7C", Offset = "0x13B6E7C", VA = "0x13B6E7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F4")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x13B6FA4", Offset = "0x13B6FA4", VA = "0x13B6FA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F5")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x13B6EFC", Offset = "0x13B6EFC", VA = "0x13B6EFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F6")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x13B70D0", Offset = "0x13B70D0", VA = "0x13B70D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x13B5754", Offset = "0x13B5754", VA = "0x13B5754")]
		public bool IsValid(bool log)
		{
			return default;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x13B5A14", Offset = "0x13B5A14", VA = "0x13B5A14")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x13B5B64", Offset = "0x13B5B64", VA = "0x13B5B64", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x13B6B44", Offset = "0x13B6B44", VA = "0x13B6B44")]
		public void InitiateAdditionalPin()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x13B6D64", Offset = "0x13B6D64", VA = "0x13B6D64")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x13B73CC", Offset = "0x13B73CC", VA = "0x13B73CC")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x13B7624", Offset = "0x13B7624", VA = "0x13B7624")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x13B7734", Offset = "0x13B7734", VA = "0x13B7734")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x13B7914", Offset = "0x13B7914", VA = "0x13B7914")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x13B7B10", Offset = "0x13B7B10", VA = "0x13B7B10")]
		private bool ForceIgnore(Muscle otherMuscle)
		{
			return default;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x13B7D98", Offset = "0x13B7D98", VA = "0x13B7D98")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x13B7E54", Offset = "0x13B7E54", VA = "0x13B7E54")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x13B7EC4", Offset = "0x13B7EC4", VA = "0x13B7EC4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x13B8088", Offset = "0x13B8088", VA = "0x13B8088")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x13B6C8C", Offset = "0x13B6C8C", VA = "0x13B6C8C")]
		public void SetKinematic(bool to)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x13B7168", Offset = "0x13B7168", VA = "0x13B7168")]
		public void Read()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x13B8210", Offset = "0x13B8210", VA = "0x13B8210")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x13B83A0", Offset = "0x13B83A0", VA = "0x13B83A0")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x13B8620", Offset = "0x13B8620", VA = "0x13B8620", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x13B8BE4", Offset = "0x13B8BE4", VA = "0x13B8BE4")]
		public void StoreTargetMappedPosition()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x13B8C20", Offset = "0x13B8C20", VA = "0x13B8C20")]
		public void StoreTargetMappedRotation()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x13B8C60", Offset = "0x13B8C60", VA = "0x13B8C60")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x13B8FE0", Offset = "0x13B8FE0", VA = "0x13B8FE0")]
		public void ResetTargetLocalPosition()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x13B900C", Offset = "0x13B900C", VA = "0x13B900C")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x13B9178", Offset = "0x13B9178", VA = "0x13B9178")]
		public void MapDisconnected()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x13B8744", Offset = "0x13B8744", VA = "0x13B8744")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x13B9270", Offset = "0x13B9270", VA = "0x13B9270")]
		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x13B89D8", Offset = "0x13B89D8", VA = "0x13B89D8")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x13B9404", Offset = "0x13B9404", VA = "0x13B9404")]
		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x13B9384", Offset = "0x13B9384", VA = "0x13B9384")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x13B85BC", Offset = "0x13B85BC", VA = "0x13B85BC")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x13B95BC", Offset = "0x13B95BC", VA = "0x13B95BC")]
		public Muscle()
		{
		}
	}
}
