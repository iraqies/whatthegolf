using Core;
using UnityEngine;

public class AliveTrailer : MonoBehaviour
{
	[SerializeField]
	private Transform _inHole;

	[SerializeField]
	private float _duration;

	[SerializeField]
	private AnimationCurve _scale;

	[SerializeField]
	private AnimationCurve _rotation;

	[SerializeField]
	private AnimationCurve _position;

	private bool done;

	[SerializeField]
	private ParticleSystem _particle;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void SuckIntoPipe(GolfBallController c)
	{
	}
}
