using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		public enum Mode
		{
			FeetCentroid = 0,
			CenterOfPressure = 1
		}

		public Mode mode;

		public float velocityDamper;

		public float velocityLerpSpeed;

		public float velocityMax;

		public float centerOfPressureSpeed;

		public Vector3 offset;

		[CompilerGenerated]
		private Quaternion inverseRotation__BackingField;

		[CompilerGenerated]
		private float lastGroundedTime__BackingField;

		public bool[] groundContacts;

		public Vector3[] groundContactPoints;

		private LayerMask groundLayers;

		public Vector3 position { get; private set; }

		public Vector3 direction { get; private set; }

		public float angle { get; private set; }

		public Vector3 velocity { get; private set; }

		public Vector3 centerOfPressure { get; private set; }

		public Quaternion rotation { get; private set; }

		private Quaternion inverseRotation
		{
			[CompilerGenerated]
			set
			{
				inverseRotation__BackingField = value;
			}
		}

		public bool isGrounded { get; private set; }

		private float lastGroundedTime
		{
			[CompilerGenerated]
			set
			{
				lastGroundedTime__BackingField = value;
			}
		}

		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		private void OnHierarchyChanged()
		{
		}

		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		private void OnPreActivate()
		{
		}

		private void OnPreLateUpdate()
		{
		}

		private void OnPreDeactivate()
		{
		}

		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default;
		}

		private bool IsGrounded()
		{
			return false;
		}

		private Vector3 GetCenterOfMass()
		{
			return default;
		}

		private Vector3 GetCenterOfMassVelocity()
		{
			return default;
		}

		private Vector3 GetCenterOfPressure()
		{
			return default;
		}

		private Vector3 GetFeetCentroid()
		{
			return default;
		}
	}
}
