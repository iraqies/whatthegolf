using System.Collections.Generic;
using UnityEngine;

public class HiddenTreeSoccerPlayer : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private List<Rigidbody> _treeParts;

	private static readonly int SawPlayer;

	[SerializeField]
	private GameObject _goop;

	[SerializeField]
	private GameObject _face;

	[SerializeField]
	private GameObject _goopToActivate;

	[SerializeField]
	private ParticleSystem _particles;

	private bool done;

	private void OnTriggerEnter(Collider other)
	{
	}
}
