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

	public float StartDelay = 2f;

	public float TimeBetweenShifts = 1f;

	public AudioClip SwitchClip;

	public AudioClip GoClip;

	public LightId onLight;

	public float lerpSpeed = 1f;

	private IEnumerator Start()
	{
		if (lights != null)
		{
			for (int i = 0; i < lights.Length; i++)
			{
				if (lights[i] == null)
				{
					continue;
				}
				if (i == (int)onLight)
				{
					if (onColors != null && i < onColors.Length)
					{
						lights[i].material.color = onColors[i];
					}
				}
				else if (offColors != null && i < offColors.Length)
				{
					lights[i].material.color = offColors[i];
				}
			}
		}
		if (Player != null)
		{
			Player.AddBlockingFunction(IsBlocking);
		}
		if (Opponents != null)
		{
			foreach (GolfBallController opponent in Opponents)
			{
				if (opponent != null)
				{
					opponent.enabled = false;
				}
			}
		}
		onLight = LightId.none;
		yield return new WaitForSecondsRealtime(StartDelay);
		onLight = LightId.red;
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(SwitchClip);
		}
		yield return new WaitForSecondsRealtime(TimeBetweenShifts);
		onLight = LightId.yellow;
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(SwitchClip);
		}
		if (Opponents != null)
		{
			foreach (GolfBallController opponent2 in Opponents)
			{
				if (opponent2 != null)
				{
					opponent2.enabled = true;
				}
			}
		}
		yield return new WaitForSecondsRealtime(TimeBetweenShifts);
		onLight = LightId.green;
		if (Player != null)
		{
			Player.RemoveBlockingFunction(IsBlocking);
		}
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(GoClip);
		}
	}

	private bool IsBlocking()
	{
		return true;
	}

	private void Update()
	{
		if (lights == null)
		{
			return;
		}
		for (int i = 0; i < lights.Length; i++)
		{
			if (lights[i] == null)
			{
				continue;
			}
			Material material = lights[i].material;
			Color color = lights[i].material.color;
			if (i == (int)onLight)
			{
				if (onColors != null && i < onColors.Length)
				{
					material.color = Color.Lerp(color, onColors[i], Time.unscaledDeltaTime * lerpSpeed);
				}
			}
			else if (offColors != null && i < offColors.Length)
			{
				material.color = Color.Lerp(color, offColors[i], Time.unscaledDeltaTime * lerpSpeed);
			}
		}
	}
}
