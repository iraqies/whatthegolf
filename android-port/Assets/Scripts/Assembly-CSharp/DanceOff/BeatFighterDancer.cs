using System.Collections;
using UnityEngine;

namespace DanceOff
{
	public class BeatFighterDancer : Dancer
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private float minDelay;

		[SerializeField]
		private float maxDelay;

		private string DirToAnimation(Vector2 dir)
		{
			if ((dir - Vector2.right).sqrMagnitude < 1E-10f)
			{
				return "Hit Right";
			}
			if ((dir - Vector2.left).sqrMagnitude < 1E-10f)
			{
				return "Hit Left";
			}
			if ((dir - Vector2.up).sqrMagnitude < 1E-10f)
			{
				return "Jump";
			}
			if ((dir - Vector2.down).sqrMagnitude < 1E-10f)
			{
				return "Duck";
			}
			return "Idle";
		}

		private void Start()
		{
			if (animator != null)
			{
				animator.speed = Random.Range(0.95f, 1.05f);
			}
		}

		public override void Dance(Vector2 dir)
		{
			StartCoroutine(DanceCoroutine(dir));
		}

		private IEnumerator DanceCoroutine(Vector3 dir)
		{
			yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
			if (animator != null)
			{
				animator.CrossFadeInFixedTime(DirToAnimation(dir), 0.1f);
			}
		}

		public override void Fail(Vector2 dir)
		{
		}
	}
}
