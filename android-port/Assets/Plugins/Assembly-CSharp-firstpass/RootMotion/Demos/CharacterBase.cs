using UnityEngine;

namespace RootMotion.Demos
{
	public abstract class CharacterBase : MonoBehaviour
	{
		public Transform gravityTarget;

		public float gravityMultiplier;

		public float airborneThreshold;

		public float slopeStartAngle;

		public float slopeEndAngle;

		public float spherecastRadius;

		public LayerMask groundLayers;

		private PhysicMaterial zeroFrictionMaterial;

		private PhysicMaterial highFrictionMaterial;

		protected Rigidbody r;

		protected const float half = 0.5f;

		protected float originalHeight;

		protected Vector3 originalCenter;

		protected CapsuleCollider capsule;

		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		protected Vector3 GetGravity()
		{
			return default;
		}

		protected virtual void Start()
		{
		}

		protected virtual RaycastHit GetSpherecastHit()
		{
			return default;
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return 0f;
		}

		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		protected void ScaleCapsule(float mlp)
		{
		}

		protected void HighFriction()
		{
		}

		protected void ZeroFriction()
		{
		}

		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return 0f;
		}
	}
}
