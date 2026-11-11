using Chronos;
using Puzzle;
using UnityEngine;

public class AnimatorTimescale : MonoBehaviour, ITimedPuzzleObject
{
	private Animator animator;

	public LocalClock BallClock { get; private set; }

	public float GetDeltaTime()
	{
		if (BallClock != null)
		{
			return BallClock.deltaTime;
		}
		return Time.deltaTime;
	}

	public void SetClock(LocalClock clock)
	{
		BallClock = clock;
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if (!(animator == null) && !(BallClock == null))
		{
			animator.speed = BallClock.localTimeScale;
		}
	}
}
