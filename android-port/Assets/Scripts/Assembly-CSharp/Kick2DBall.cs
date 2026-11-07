using System.Collections.Generic;
using UnityEngine;

public class Kick2DBall : MonoBehaviour
{
	[SerializeField]
	private VolleyGame VolleyGame;

	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private float force;

	[SerializeField]
	private float helperForce;

	private Rigidbody2D rigid;

	private float nextPush;

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void PlaySfx()
	{
	}
}
