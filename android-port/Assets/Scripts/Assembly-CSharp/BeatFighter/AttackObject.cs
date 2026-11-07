using System;
using UnityEngine;

namespace BeatFighter
{
	public class AttackObject : MonoBehaviour
	{
		[SerializeField]
		private Transform attackObject;

		[SerializeField]
		private float speed;

		[SerializeField]
		private bool bounce;

		public float attackTime;

		private Vector3 offset;

		private Func<float, float> timeFunc;

		public void Initialize(float attackTime)
		{
		}

		public void Move(float t)
		{
		}
	}
}
