using System.Collections;
using UnityEngine;

namespace Audio.Rumble
{
	public class OverworldDoorRumble : MonoBehaviour
	{
		public RumbleEventAsset rumble;

		public void OpenDoorRumble(float duration)
		{
			StartCoroutine(OpenRumbleCoroutine(duration));
			if (rumble != null)
				rumble.Play(0, 1f);
		}

		private IEnumerator OpenRumbleCoroutine(float openDuration)
		{
			if (openDuration > 0f)
				yield return new WaitForSeconds(openDuration);
		}
	}
}
