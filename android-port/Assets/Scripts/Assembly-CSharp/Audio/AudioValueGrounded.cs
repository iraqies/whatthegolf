using System;
using UnityEngine;

namespace Audio
{
	public class AudioValueGrounded : BaseAudioValue
	{
		[Serializable]
		public class Direction
		{
			public Vector3 direction = Vector3.down;

			public bool localAxis = true;

			public Vector3 GetDirection(Transform transform)
			{
				if (localAxis && transform != null)
					return transform.TransformDirection(direction);
				return direction;
			}
		}

		public Transform relativeTransform;

		public Transform[] checkTransforms = new Transform[1];

		public Direction[] directions = new Direction[1] { new Direction() };

		public bool check2DColliders;

		public float distanceToGround = 2f;

		public LayerMask layermask;

		public float raycastFrequency = 5f;

		private float nextCheckTime;

		protected override bool Use2D => check2DColliders;

		private float cooldown => raycastFrequency > 0f ? (1f / raycastFrequency) : 0f;

		private void Update()
		{
			if (checkTransforms != null)
				SetValue();
		}

		public override string ValueInputName()
		{
			string s = "";
			if (checkTransforms != null)
			{
				for (int i = 0; i < checkTransforms.Length; i++)
				{
					if (checkTransforms[i] != null)
						s = s + " " + checkTransforms[i].name;
				}
			}
			return string.Format("Grounded ({0})", s);
		}

		protected override void SetValue()
		{
			if (Time.time > nextCheckTime)
			{
				value = Grounded() ? 1f : 0f;
				base.SetValue();
			}
		}

		private bool Grounded()
		{
			nextCheckTime = Time.time + cooldown;
			if (checkTransforms == null || directions == null)
				return false;
			bool hitAny = false;
			for (int i = 0; i < checkTransforms.Length; i++)
			{
				Transform t = checkTransforms[i];
				if (t == null) continue;
				for (int j = 0; j < directions.Length; j++)
				{
					if (directions[j] == null) continue;
					Vector3 dir = directions[j].GetDirection(relativeTransform != null ? relativeTransform : t);
					if (check2DColliders)
					{
						RaycastHit2D hit2d = Physics2D.Raycast(t.position, dir, distanceToGround, layermask);
						if (hit2d.collider != null)
							hitAny = true;
					}
					else
					{
						if (Physics.Raycast(t.position, dir, out _, distanceToGround, layermask))
							hitAny = true;
					}
				}
			}
			return hitAny;
		}
	}
}
