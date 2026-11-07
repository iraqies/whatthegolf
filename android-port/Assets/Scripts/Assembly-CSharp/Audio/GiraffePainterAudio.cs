using System.Collections;
using UnityEngine;

namespace Audio
{
	public class GiraffePainterAudio : MonoBehaviour
	{
		[SerializeField]
		private bool isSprayCan;

		[SerializeField]
		private GiraffePainterController painter;

		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private float sourcePlayDelay;

		[SerializeField]
		private ClipSettingsCollection autoCompleteSfx;

		[SerializeField]
		private ClipSettingsCollection newPoseReadySfx;

		[SerializeField]
		private ClipSettingsCollection failPoseSfx;

		[SerializeField]
		private ClipSettingsCollection shakeCanSfx;

		private bool didChangePose;

		private GiraffePainterController.PaintStateEnum state;

		private GolfGoal goal;

		private void Awake()
		{
		}

		private void OnAnyComplete()
		{
		}

		private void OnGoal(string obj)
		{
		}

		private void Instance_OnLevelWillUnload()
		{
		}

		private void OnRedoPose()
		{
		}

		private void OnNewPose()
		{
		}

		private void OnChangeState(GiraffePainterController.PaintStateEnum newState)
		{
		}

		private IEnumerator DelayedPlay(float duration)
		{
			return null;
		}

		private IEnumerator RedoPoseSequence()
		{
			return null;
		}
	}
}
