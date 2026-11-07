using Audio;
using UnityEngine;

public class GolfBoyTrampoline : MonoBehaviour
{
	[SerializeField]
	private float additionalForce;

	[SerializeField]
	private ClipSettingsCollection jumpClip;

	private void OnCollisionEnter(Collision other)
	{
	}
}
