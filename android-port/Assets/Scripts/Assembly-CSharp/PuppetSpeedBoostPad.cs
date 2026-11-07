using Audio;
using UnityEngine;

public class PuppetSpeedBoostPad : MonoBehaviour
{
	[SerializeField]
	private bool useLocalPadDirection;

	[SerializeField]
	private Vector3 direction;

	[SerializeField]
	private float force;

	[SerializeField]
	private ClipSettingsCollection sfxOnJump;

	private float lastSfxTime;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
