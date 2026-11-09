using System.Collections;
using UnityEngine;

public class OverworldComputerChangePersonalityOnHit : MonoBehaviour
{
	[SerializeField] private Animator _face;
	[SerializeField] private float _duration = 2f;

	private static readonly int PersonalityState = Animator.StringToHash("PersonalityState");
	private static readonly int ScanLines = Animator.StringToHash("ScanLines");

	private void Start()
	{
		if (_face == null)
			_face = GetComponentInChildren<Animator>();
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		StopAllCoroutines();
		StartCoroutine(Hit());
	}

	private IEnumerator Hit()
	{
		if (_face != null)
		{
			_face.SetInteger(PersonalityState, UnityEngine.Random.Range(1, 4));
			_face.SetTrigger(ScanLines);
		}
		yield return new WaitForSeconds(_duration > 0f ? _duration : 2f);
		if (_face != null)
		{
			_face.SetInteger(PersonalityState, 0);
		}
	}
}
