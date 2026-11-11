using System;
using UnityEngine;

namespace BeatFighter
{
	public class AttackObject : MonoBehaviour
	{
		[SerializeField]
		private Transform attackObject;

		[SerializeField]
		private float speed = 1f;

		[SerializeField]
		private bool bounce;

		public float attackTime;

		private Vector3 offset;

		private Func<float, float> timeFunc;

		public void Initialize(float attackTime)
		{
			this.attackTime = attackTime;
			offset = attackObject.localPosition;
			timeFunc = (bounce ? new Func<float, float>(Mathf.Abs) : ((Func<float, float>)((float x) => x)));
		}

		public void Move(float t)
		{
			attackObject.localPosition = offset + new Vector3(timeFunc(attackTime - t) * speed, 0f, 0f);
		}
	}
}
