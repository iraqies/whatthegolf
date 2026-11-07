using System.Collections;
using UnityEngine;

public class OverworldComputerChangePersonalityOnHit : MonoBehaviour
{
	[SerializeField]
	private Animator _face;

	[SerializeField]
	private float _duration;

	private static readonly int PersonalityState;

	private static readonly int ScanLines;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private IEnumerator Hit()
	{
		return null;
	}
}
