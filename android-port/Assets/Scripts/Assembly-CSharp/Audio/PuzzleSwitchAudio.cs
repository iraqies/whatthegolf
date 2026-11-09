using Puzzle;
using UnityEngine;

namespace Audio
{
	public class PuzzleSwitchAudio : MonoBehaviour
	{
		public RandomAudioClips downClips;

		public RandomAudioClips upClips;

		private PuzzleSwitchBase puzzleSwitch;

		private void Awake()
		{
			puzzleSwitch = GetComponent<PuzzleSwitchBase>() ?? GetComponentInParent<PuzzleSwitchBase>();
		}

		private void OnEnable()
		{
			if (puzzleSwitch != null)
			{
				puzzleSwitch.OnTrigger -= OnSwitchChanged;
				puzzleSwitch.OnTrigger += OnSwitchChanged;
			}
		}

		private void OnDisable()
		{
			if (puzzleSwitch != null)
				puzzleSwitch.OnTrigger -= OnSwitchChanged;
		}

		private void OnSwitchChanged(bool down)
		{
			if (down)
				downClips?.PlayRandomClip(transform);
			else
				upClips?.PlayRandomClip(transform);
		}
	}
}
