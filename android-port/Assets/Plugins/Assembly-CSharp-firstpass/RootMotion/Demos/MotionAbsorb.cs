using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		public enum Mode
		{
			Position = 0,
			PositionOffset = 1
		}

		[Serializable]
		public class Absorber
		{
			public FullBodyBipedEffector effector;

			public float weight;

			private Vector3 position;

			private Quaternion rotation;

			private IKEffector e;

			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			public void UpdateEffectorWeights(float w)
			{
			}

			public void SetPosition(float w)
			{
			}

			public void SetRotation(float w)
			{
			}
		}

		public Mode mode;

		public Absorber[] absorbers;

		public AnimationCurve falloff;

		public float falloffSpeed;

		private float timer;

		private float w;

		private Mode initialMode;

		protected override void Start()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		protected override void OnModifyOffset()
		{
		}

		private void AfterIK()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
