using UnityEngine;

namespace Audio
{
	public class ApplyAudioMaterialFromCollisionAudio : MonoBehaviour
	{
		public AudioMaterial audioMaterial;

		private OnCollisionAudioRemote collisionAudio;

		private void Start()
		{
			collisionAudio = GetComponent<OnCollisionAudioRemote>();
			if (collisionAudio != null && collisionAudio.GetRoot != null)
			{
				var settings = collisionAudio.GetRoot.GetComponent<AudioMaterialSettings>();
				if (settings == null)
					settings = collisionAudio.GetRoot.AddComponent<AudioMaterialSettings>();
				if (settings != null)
					settings.material = audioMaterial;
			}
		}
	}
}
