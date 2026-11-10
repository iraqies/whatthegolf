using System.Collections.Generic;
using Audio;
using UnityEngine;

public class HiddenTreeSoccerPlayer : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private List<Rigidbody> _treeParts;

	private static readonly int SawPlayer = Animator.StringToHash("SawPlayer");

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
		if (done || other == null || !other.CompareTag("Player"))
		{
			return;
		}
		done = true;
		if (_treeParts != null)
		{
			foreach (Rigidbody treePart in _treeParts)
			{
				if (treePart != null)
				{
					treePart.isKinematic = false;
					AddForce component = treePart.GetComponent<AddForce>();
					if (component != null)
					{
						component.Execute();
					}
				}
			}
		}
		if (_animator != null)
		{
			_animator.SetTrigger(SawPlayer);
		}
		if (_particles != null)
		{
			_particles.transform.parent = base.transform.parent;
			_particles.Play();
		}
		if (_goop != null)
		{
			_goop.SetActive(false);
		}
		if (_face != null)
		{
			_face.SetActive(true);
		}
		if (_goopToActivate != null)
		{
			_goopToActivate.SetActive(true);
		}
		PlayAudioClipSetting component2 = GetComponent<PlayAudioClipSetting>();
		if (component2 != null)
		{
			component2.Play();
		}
	}
}
