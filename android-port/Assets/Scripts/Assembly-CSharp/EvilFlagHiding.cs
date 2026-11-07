using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class EvilFlagHiding : MonoBehaviour
{
	public List<Transform> sequence;

	public float velocity;

	public float hideYOffset;

	public GolfBallController ball;

	public RandomAudioClips audioClip;

	private Rigidbody rigidbody;

	private int currentIndex;

	private bool moving;

	private void Start()
	{
	}

	private void Ball_OnPreShoot(Vector3 aim)
	{
	}

	private IEnumerator SwitchHole()
	{
		return null;
	}
}
