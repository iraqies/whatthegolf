using UnityEngine;

namespace Ghost
{
	public class GolfGhostRecorder : MonoBehaviour
	{
		private Transform ball;

		private bool isRecording;

		private float startTime;

		private float nextSaveTime;

		public float UpdateRate;

		public int currentStroke;

		public GolfGhostData Ghost { get; private set; }

		public void StartNewRecording()
		{
		}

		public void RecordStroke(Transform ball)
		{
		}

		public void PauseRecording()
		{
		}

		private static string GetPrefabID(Transform ball)
		{
			return null;
		}

		public void EndRecording()
		{
		}

		private void SavePoint()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
