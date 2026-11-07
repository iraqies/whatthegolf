using Audio;
using UnityEngine;

public class BallHitter : MonoBehaviour
{
	[SerializeField]
	private float HitForce;

	public ClipSettingsCollection HitClips;

	private void OnCollisionEnter(Collision other)
	{
	}
}
