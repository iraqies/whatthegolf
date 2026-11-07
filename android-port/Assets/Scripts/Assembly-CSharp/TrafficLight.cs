using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
	public enum LightId
	{
		red = 0,
		yellow = 1,
		green = 2,
		none = 3
	}

	public Renderer[] lights;

	public Color[] onColors;

	public Color[] offColors;

	public GolfBallController Player;

	public List<GolfBallController> Opponents;

	public float StartDelay;

	public float TimeBetweenShifts;

	public AudioClip SwitchClip;

	public AudioClip GoClip;

	public LightId onLight;

	public float lerpSpeed;

	private IEnumerator Start()
	{
		return null;
	}

	private bool IsBlocking()
	{
		return false;
	}

	private void Update()
	{
	}
}
