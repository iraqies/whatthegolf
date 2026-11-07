using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		public class Body
		{
			[Serializable]
			public class EffectorLink
			{
				public FullBodyBipedEffector effector;

				public float weight;
			}

			public Transform transform;

			public Transform relativeTo;

			public EffectorLink[] effectorLinks;

			public float verticalWeight;

			public float horizontalWeight;

			public float speed;

			private Vector3 lastRelativePos;

			private Vector3 smoothDelta;

			private bool firstUpdate;

			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}
		}

		public Body[] bodies;

		protected override void OnModifyOffset()
		{
		}
	}
}
