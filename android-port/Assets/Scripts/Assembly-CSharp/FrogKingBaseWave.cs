using System.Collections;
using Audio;
using UnityEngine;

public abstract class FrogKingBaseWave : MonoBehaviour
{
	public AudioEventAsset sfxOneshotOnSpawn;

	public float oneshotDelay;

	public Animator FrogKingAnimator;

	public float FrogKingSpawnAnimationTime;

	public float Weight = 0.5f;

	public string AnimatorStateName;

	public float TimeSpentInAnimation;

	public abstract IEnumerator WaveRoutine(SHMUPFrogKing frogKing);

	public virtual void OnSinkReset()
	{
		if (!string.IsNullOrEmpty(AnimatorStateName) && FrogKingAnimator != null)
		{
			FrogKingAnimator.SetBool(AnimatorStateName, false);
		}
	}

	public IEnumerator FrogKingSpawnWaveRoutine()
	{
		if (FrogKingAnimator == null)
			yield return null;
		yield return new WaitForSeconds(FrogKingSpawnAnimationTime);
		if (FrogKingAnimator != null)
			FrogKingAnimator.SetBool("Spawn", false);
	}

	public IEnumerator WaveAnimationsRoutine()
	{
		if (string.IsNullOrEmpty(AnimatorStateName))
			yield return null;
		if (FrogKingAnimator != null && !string.IsNullOrEmpty(AnimatorStateName))
			FrogKingAnimator.SetBool(AnimatorStateName, true);
		yield return new WaitForSeconds(TimeSpentInAnimation);
		if (FrogKingAnimator != null && !string.IsNullOrEmpty(AnimatorStateName))
			FrogKingAnimator.SetBool(AnimatorStateName, false);
	}

	public bool TryPlayOneshot(AudioEventAsset oneshot, Vector3 pos)
	{
		if (oneshot == null)
			return false;
		if (oneshotDelay > 0f)
			oneshot.PlayDelayed(pos, oneshotDelay, 1f, 1f);
		else
			oneshot.Play(pos, 1f, 1f, false);
		return true;
	}
}
