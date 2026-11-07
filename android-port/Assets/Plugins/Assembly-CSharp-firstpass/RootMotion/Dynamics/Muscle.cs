using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	public class Muscle
	{
		[Serializable]
		public enum Group
		{
			Hips = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Hand = 4,
			Leg = 5,
			Foot = 6,
			Tail = 7,
			Prop = 8
		}

		[Serializable]
		public class InternalCollisionIgnoreSettings
		{
			public bool ignoreAll;

			public ConfigurableJoint[] muscles;

			public Group[] groups;
		}

		[Serializable]
		public class Props
		{
			public Group group;

			public float mappingWeight;

			public float pinWeight;

			public float muscleWeight;

			public float muscleDamper;

			public bool mapPosition;

			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			public Transform[] animatedTargetChildren;

			public Props()
			{
			}

			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			public void Clamp()
			{
			}
		}

		public struct State
		{
			public float mappingWeightMlp;

			public float pinWeightMlp;

			public float muscleWeightMlp;

			public float maxForceMlp;

			public float muscleDamperMlp;

			public float muscleDamperAdd;

			public float immunity;

			public float impulseMlp;

			public Vector3 velocity;

			public Vector3 angularVelocity;

			public bool isDisconnected;

			public bool resetFlag;

			public static State Default => default;

			public void Clamp()
			{
			}
		}

		public class TargetChild
		{
			public Transform t;

			public Vector3 defaultLocalPosition;

			public Quaternion defaultLocalRotation;

			public TargetChild(Transform t)
			{
			}

			public void Map()
			{
			}
		}

		public string name;

		public ConfigurableJoint joint;

		public Transform target;

		public Props props;

		public State state;

		public int[] parentIndexes;

		public int[] childIndexes;

		public bool[] childFlags;

		public int[] kinshipDegrees;

		public MuscleCollisionBroadcaster broadcaster;

		public JointBreakBroadcaster jointBreakBroadcaster;

		public Vector3 positionOffset;

		[SerializeField]
		public ConfigurableJoint additionalPin;

		[SerializeField]
		public Transform additionalPinTarget;

		[SerializeField]
		public float additionalPinWeight;

		public Vector3 mappedVelocity;

		public Vector3 mappedAngularVelocity;

		public bool isPropMuscle;

		[SerializeField]
		public int index;

		private Transform rebuildParent;

		private Vector3 rebuildPosition;

		private Quaternion rebuildRotation;

		private Vector3 rebuildTargetPosition;

		private Quaternion rebuildTargetRotation;

		private ConfigurableJointMotion rebuildAngularXMotion;

		private ConfigurableJointMotion rebuildAngularYMotion;

		private ConfigurableJointMotion rebuildAngularZMotion;

		public Vector3 targetMappedPosition;

		public Quaternion targetMappedRotation;

		public Vector3 targetSampledPosition;

		public Quaternion targetSampledRotation;

		private JointDrive slerpDrive;

		private float lastJointDriveRotationWeight;

		private float lastRotationDamper;

		private Vector3 defaultPosition;

		private Vector3 defaultTargetLocalPosition;

		private Vector3 lastMappedPosition;

		private Quaternion defaultLocalRotation;

		private Quaternion localRotationConvert;

		private Quaternion toParentSpace;

		private Quaternion toJointSpaceInverse;

		private Quaternion toJointSpaceDefault;

		private Quaternion targetAnimatedRotation;

		private Quaternion defaultRotation;

		private Quaternion rotationRelativeToTarget;

		private Quaternion defaultTargetLocalRotation;

		private Quaternion lastMappedRotation;

		private Transform targetParent;

		private Transform connectedBodyTransform;

		private ConfigurableJointMotion angularXMotionDefault;

		private ConfigurableJointMotion angularYMotionDefault;

		private ConfigurableJointMotion angularZMotionDefault;

		private bool directTargetParent;

		private bool initiated;

		private Collider[] _colliders;

		private float lastReadTime;

		private float lastWriteTime;

		private bool[] disabledColliders;

		private TargetChild[] targetChildren;

		private Vector3 additionalTargetVelocity;

		private Vector3 targetAnimatedCenterOfMass;

		private Vector3 additionalPinTargetAnimatedCenterOfMass;

		private Quaternion defaultTargetRotRelToMuscleInverse;

		public Transform transform { get; private set; }

		public Rigidbody rigidbody { get; private set; }

		public Transform connectedBodyTarget { get; private set; }

		public Vector3 targetAnimatedPosition { get; private set; }

		public Quaternion targetAnimatedWorldRotation { get; private set; }

		public Collider[] colliders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 targetVelocity { get; private set; }

		public Rigidbody additionalRigidbody { get; private set; }

		public Quaternion targetRotationRelative { get; private set; }

		public Rigidbody rebuildConnectedBody { get; private set; }

		public Transform rebuildTargetParent { get; private set; }

		public Vector3 defaultTargetPosRelToMuscle { get; private set; }

		public Quaternion defaultTargetRotRelToMuscle { get; private set; }

		public Quaternion defaultMuscleRotRelToTarget { get; private set; }

		private Quaternion localRotation => default;

		private Quaternion parentRotation => default;

		private Quaternion targetParentRotation => default;

		private Quaternion targetLocalRotation => default;

		public bool IsValid(bool log)
		{
			return false;
		}

		public void Rebuild()
		{
		}

		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		public void InitiateAdditionalPin()
		{
		}

		public void UpdateColliders()
		{
		}

		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		private bool ForceIgnore(Muscle otherMuscle)
		{
			return false;
		}

		public void IgnoreAngularLimits(bool ignore)
		{
		}

		public void FixTargetTransforms()
		{
		}

		public void Reset()
		{
		}

		public void MoveToTarget()
		{
		}

		public void SetKinematic(bool to)
		{
		}

		public void Read()
		{
		}

		public void ClearVelocities()
		{
		}

		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, bool angularPinning, float deltaTime)
		{
		}

		public void StoreTargetMappedPosition()
		{
		}

		public void StoreTargetMappedRotation()
		{
		}

		public void Map(float mappingWeightMaster)
		{
		}

		public void ResetTargetLocalPosition()
		{
		}

		public void CalculateMappedVelocity()
		{
		}

		public void MapDisconnected()
		{
		}

		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning, float deltaTime)
		{
		}

		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default;
		}

		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default;
		}
	}
}
