using Chronos;
using Puzzle;
using UnityEngine;

public class AnimatorTimescale : MonoBehaviour, ITimedPuzzleObject
{
	private Animator animator;

	public LocalClock BallClock { get; private set; }

	public float GetDeltaTime()
	{
		return 0f;
	}

	public void SetClock(LocalClock clock)
	{
	}

	private void Update()
	{
	}
}
