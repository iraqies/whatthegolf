using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
	public UnityEvent OnEnter;

	public UnityEvent OnExit;

	public List<string> Tags;

	public Color OnColor = Color.green;

	public Color OffColor = Color.red;

	public int PlayersOnButton;

	public float Delay;

	public List<AudioClip> OnTriggeredClips;

	public Animator ButtonAnimator;

	public List<MeshRenderer> MeshesToUpdate;

	private Light light;

	private float delayTime;

	private bool delayIsEnterInvoke;

	private bool hasPendingInvoke;

	private void Awake()
	{
		light = GetComponentInChildren<Light>();
	}

	private void Update()
	{
		if (hasPendingInvoke && Time.time >= delayTime)
		{
			hasPendingInvoke = false;
			if (delayIsEnterInvoke)
			{
				EnterInvoke();
			}
			else
			{
				ExitInvoke();
			}
		}
	}

	private bool MatchesTag(string tag)
	{
		if (Tags == null || Tags.Count == 0)
		{
			return true;
		}
		return Tags.Contains(tag);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || !MatchesTag(other.tag))
		{
			return;
		}
		PlayersOnButton++;
		if (PlayersOnButton == 1)
		{
			if (Delay > 0f)
			{
				delayTime = Time.time + Delay;
				delayIsEnterInvoke = true;
				hasPendingInvoke = true;
			}
			else
			{
				EnterInvoke();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null || !MatchesTag(other.tag))
		{
			return;
		}
		PlayersOnButton++;
		if (PlayersOnButton == 1)
		{
			if (Delay > 0f)
			{
				delayTime = Time.time + Delay;
				delayIsEnterInvoke = true;
				hasPendingInvoke = true;
			}
			else
			{
				EnterInvoke();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null || !MatchesTag(other.tag))
		{
			return;
		}
		PlayersOnButton = Mathf.Max(0, PlayersOnButton - 1);
		if (PlayersOnButton == 0)
		{
			if (Delay > 0f)
			{
				delayTime = Time.time + Delay;
				delayIsEnterInvoke = false;
				hasPendingInvoke = true;
			}
			else
			{
				ExitInvoke();
			}
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other == null || !MatchesTag(other.tag))
		{
			return;
		}
		PlayersOnButton = Mathf.Max(0, PlayersOnButton - 1);
		if (PlayersOnButton == 0)
		{
			if (Delay > 0f)
			{
				delayTime = Time.time + Delay;
				delayIsEnterInvoke = false;
				hasPendingInvoke = true;
			}
			else
			{
				ExitInvoke();
			}
		}
	}

	private void EnterInvoke()
	{
		if (ButtonAnimator != null)
		{
			ButtonAnimator.SetBool("Pressed", true);
		}
		if (light != null)
		{
			light.color = OnColor;
		}
		if (OnTriggeredClips != null && OnTriggeredClips.Count > 0)
		{
			AudioClip clip = OnTriggeredClips[Random.Range(0, OnTriggeredClips.Count)];
			if (clip != null)
			{
				AudioManager.PlaySFX(clip, transform.position);
			}
		}
		OnEnter?.Invoke();
	}

	private void ExitInvoke()
	{
		if (ButtonAnimator != null)
		{
			ButtonAnimator.SetBool("Pressed", false);
		}
		if (light != null)
		{
			light.color = OffColor;
		}
		OnExit?.Invoke();
	}
}
