using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Hub
{
	public class SpecialDayLockView : MonoBehaviour
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private SpecialDayOverworldButton2D door;

		private static readonly int Open = Animator.StringToHash("Open");

		private static readonly int Shake1 = Animator.StringToHash("Shake");

		private static readonly int Locked = Animator.StringToHash("Locked");

		public void OnCollisionEnter2D(Collision2D other)
		{
			if (door != null)
			{
				door.OnCollisionEnter2D(other);
			}
		}

		public void SetState(bool active, bool hasBeenOpenedBefore)
		{
			if (!active)
			{
				Lock();
			}
			else if (hasBeenOpenedBefore || DailyChallenges.HasSpecialBeenPlayedBefore())
			{
				Unlock(immediate: true);
			}
			else
			{
				Shake();
			}
		}

		private void Shake()
		{
			if (animator != null)
			{
				animator.SetTrigger(Shake1);
			}
		}

		public async void Unlock(bool immediate)
		{
			if (immediate)
			{
				gameObject.SetActive(value: false);
				return;
			}
			if (animator != null)
			{
				animator.SetTrigger(Open);
			}
			await Task.Delay(TimeSpan.FromSeconds(GetAnimationDuration()));
			if (this != null && gameObject != null)
			{
				gameObject.SetActive(value: false);
			}
		}

		private float GetAnimationDuration()
		{
			return 1f;
		}

		private void Lock()
		{
			if (animator != null)
			{
				animator.SetTrigger(Locked);
			}
			gameObject.SetActive(value: true);
		}
	}
}
