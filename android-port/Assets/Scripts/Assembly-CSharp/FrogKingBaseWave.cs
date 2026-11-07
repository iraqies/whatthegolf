using System.Collections;
using Audio;
using UnityEngine;

public abstract class FrogKingBaseWave : MonoBehaviour
{
	public AudioEventAsset sfxOneshotOnSpawn;

	public float oneshotDelay;

	public Animator FrogKingAnimator;

	public float FrogKingSpawnAnimationTime;

	public float Weight;

	public string AnimatorStateName;

	public float TimeSpentInAnimation;

	public abstract IEnumerator WaveRoutine(SHMUPFrogKing frogKing);

	public virtual void OnSinkReset()
	{
	}

	public IEnumerator FrogKingSpawnWaveRoutine()
	{
		return null;
	}

	public IEnumerator WaveAnimationsRoutine()
	{
		return null;
	}

	public bool TryPlayOneshot(AudioEventAsset oneshot, Vector3 pos)
	{
		return false;
	}
}
