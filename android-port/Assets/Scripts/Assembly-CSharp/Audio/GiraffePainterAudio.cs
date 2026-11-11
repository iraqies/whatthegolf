using System.Collections;
using UnityEngine;

namespace Audio
{
	public class GiraffePainterAudio : MonoBehaviour
	{
		[SerializeField]
		[Header("Continuous Sounds")]
		private AudioSource paintLoopSource;

		[SerializeField]
		private float paintLoopDelay = 1f;

		[SerializeField]
		[Header("Pose Change Sequence")]
		private float poseChangeDelay = 0.5f;

		[SerializeField]
		private ClipSettingsCollection giraffeMumbleClips;

		[SerializeField]
		private ClipSettingsCollection painterDisgruntledClips;

		[SerializeField]
		private ClipSettingsCollection clothShuffleClips;

		[SerializeField]
		[Header("Level Reset Sound")]
		private ClipSettingsCollection paperRipClips;

		private float initialLoopVolume;

		private Coroutine delayedPlayRoutine;

		private void Awake()
		{
			if (paintLoopSource != null)
			{
				initialLoopVolume = paintLoopSource.volume;
			}
		}

		private void OnEnable()
		{
			LevelReset();
		}

		private void OnDisable()
		{
			StopAllCoroutines();
			if (paintLoopSource != null && paintLoopSource.isPlaying)
			{
				paintLoopSource.Stop();
			}
		}

		public void BallAiming()
		{
			StopDelayPlayRoutine();
			if (paintLoopSource != null && paintLoopSource.isPlaying)
			{
				paintLoopSource.Stop();
			}
		}

		public void BallAimCancelled()
		{
			StopDelayPlayRoutine();
			delayedPlayRoutine = StartCoroutine(DelayedPlay(0.1f));
		}

		public void BallMoving()
		{
			StopDelayPlayRoutine();
			if (paintLoopSource != null && paintLoopSource.isPlaying)
			{
				paintLoopSource.Stop();
			}
			if (giraffeMumbleClips != null)
			{
				giraffeMumbleClips.Play(null, Vector3.zero, 1f, 1f);
			}
		}

		public void BallDoneMoving()
		{
			StartCoroutine(RedoPoseSequence());
			StopDelayPlayRoutine();
			delayedPlayRoutine = StartCoroutine(DelayedPlay(paintLoopDelay));
		}

		private void LevelReset()
		{
			StopAllCoroutines();
			if (paintLoopSource != null && paintLoopSource.isPlaying)
			{
				paintLoopSource.Stop();
			}
			if (paperRipClips != null)
			{
				paperRipClips.Play(null, Vector3.zero, 1f, 1f);
			}
			delayedPlayRoutine = StartCoroutine(DelayedPlay(paintLoopDelay));
		}

		private void StopDelayPlayRoutine()
		{
			if (delayedPlayRoutine != null)
			{
				StopCoroutine(delayedPlayRoutine);
			}
		}

		private IEnumerator DelayedPlay(float delay)
		{
			yield return new WaitForSeconds(delay);
			if (paintLoopSource != null)
			{
				paintLoopSource.Play();
			}
		}

		private IEnumerator RedoPoseSequence()
		{
			if (painterDisgruntledClips != null)
			{
				painterDisgruntledClips.Play(null, Vector3.zero, 1f, 1f);
			}
			yield return new WaitForSeconds(poseChangeDelay);
			if (clothShuffleClips != null)
			{
				clothShuffleClips.Play(null, Vector3.zero, 1f, 1f);
			}
		}
	}
}
