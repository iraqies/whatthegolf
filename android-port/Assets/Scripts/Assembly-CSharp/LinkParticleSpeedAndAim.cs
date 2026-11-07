using Core;
using UnityEngine;

public class LinkParticleSpeedAndAim : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private float max;

	[SerializeField]
	private float min;

	private ParticleSystem p;

	private void Start()
	{
	}

	private void OnAimUpdate(Vector3 boost, bool b)
	{
	}

	private void OnDestroy()
	{
	}
}
