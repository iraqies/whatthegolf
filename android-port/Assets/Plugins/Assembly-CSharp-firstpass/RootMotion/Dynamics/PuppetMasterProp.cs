using UnityEngine;

namespace RootMotion.Dynamics
{
	public class PuppetMasterProp : MonoBehaviour
	{
		public Transform meshRoot;

		public Muscle.Props muscleProps;

		public bool forceLayers;

		public float mass;

		public int propType;

		public PhysicMaterial pickedUpMaterial;

		public Vector3 additionalPinOffsetAdd;

		public float additionalPinWeight;

		public float additionalPinMass;

		private int defaultLayer;

		private Transform defaultParent;

		private Collider[] colliders;

		private PhysicMaterial[] droppedMaterials;

		private Rigidbody r;

		private float _mass;

		private float _drag;

		private float _angularDrag;

		private bool _useGravity;

		private bool _isKinematic;

		private RigidbodyInterpolation _interpolation;

		private CollisionDetectionMode _collisionDetectionMode;

		private RigidbodyConstraints _constraints;

		private Collider[] emptyColliders;

		public bool isPickedUp { get; private set; }

		protected Muscle propMuscle { get; private set; }

		public Rigidbody GetRigidbody()
		{
			return null;
		}

		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void RemoveRigidbody()
		{
		}

		private void ReattachRigidbody()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
