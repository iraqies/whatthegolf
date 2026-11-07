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
			return null;
		}

		private void Start()
		{
		}

		public override void Dance(Vector2 dir)
		{
		}

		private IEnumerator DanceCoroutine(Vector3 dir)
		{
			return null;
		}

		public override void Fail(Vector2 dir)
		{
		}
	}
}
