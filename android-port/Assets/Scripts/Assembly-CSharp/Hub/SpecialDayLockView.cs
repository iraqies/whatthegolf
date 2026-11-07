using UnityEngine;

namespace Hub
{
	public class SpecialDayLockView : MonoBehaviour
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private SpecialDayOverworldButton2D door;

		private static readonly int Open;

		private static readonly int Shake1;

		private static readonly int Locked;

		public void OnCollisionEnter2D(Collision2D other)
		{
		}

		public void SetState(bool active, bool hasBeenOpenedBefore)
		{
		}

		private void Shake()
		{
		}

		public void Unlock(bool immediate)
		{
		}

		private float GetAnimationDuration()
		{
			return 0f;
		}

		private void Lock()
		{
		}
	}
}
