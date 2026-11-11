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

	private void Awake()
	{
		light = GetComponentInChildren<Light>();
		if (MeshesToUpdate != null)
		{
			for (int i = 0; i < MeshesToUpdate.Count; i++)
			{
				if (MeshesToUpdate[i] != null && MeshesToUpdate[i].material != null)
				{
					MeshesToUpdate[i].material.color = OffColor;
				}
			}
		}
	}

	private void Update()
	{
		if (delayTime > 0f)
		{
			delayTime -= Time.deltaTime;
			if (delayTime <= 0f)
			{
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
		if (!enabled || other == null || !MatchesTag(other.tag))
		{
			return;
		}
		int prev = PlayersOnButton;
		PlayersOnButton = prev + 1;
		if (prev == 0)
		{
			if (Delay > 0f)
			{
				delayTime = Delay;
				delayIsEnterInvoke = true;
			}
			else
			{
				EnterInvoke();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!enabled || other == null || !MatchesTag(other.tag))
		{
			return;
		}
		int prev = PlayersOnButton;
		PlayersOnButton = prev + 1;
		if (prev == 0)
		{
			if (Delay > 0f)
			{
				delayTime = Delay;
				delayIsEnterInvoke = true;
			}
			else
			{
				EnterInvoke();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (!enabled || other == null || !MatchesTag(other.tag))
		{
			return;
		}
		PlayersOnButton = Mathf.Max(0, PlayersOnButton - 1);
		if (PlayersOnButton == 0)
		{
			if (Delay > 0f)
			{
				delayTime = Delay;
				delayIsEnterInvoke = false;
			}
			else
			{
				ExitInvoke();
			}
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (!enabled || other == null || !MatchesTag(other.tag))
		{
			return;
		}
		PlayersOnButton = Mathf.Max(0, PlayersOnButton - 1);
		if (PlayersOnButton == 0)
		{
			if (Delay > 0f)
			{
				delayTime = Delay;
				delayIsEnterInvoke = false;
			}
			else
			{
				ExitInvoke();
			}
		}
	}

	private void EnterInvoke()
	{
		OnEnter?.Invoke();
		if (light != null)
		{
			light.color = OnColor;
		}
		if (MeshesToUpdate != null)
		{
			for (int i = 0; i < MeshesToUpdate.Count; i++)
			{
				if (MeshesToUpdate[i] != null && MeshesToUpdate[i].material != null)
				{
					MeshesToUpdate[i].material.color = OnColor;
				}
			}
		}
		if (ButtonAnimator != null)
		{
			ButtonAnimator.SetBool("Up", false);
		}
		if (OnTriggeredClips != null && OnTriggeredClips.Count > 0)
		{
			AudioClip clip = OnTriggeredClips[Random.Range(0, OnTriggeredClips.Count)];
			if (clip != null)
			{
				AudioManager.PlaySFX(clip, transform.position);
			}
		}
	}

	private void ExitInvoke()
	{
		OnExit?.Invoke();
		if (light != null)
		{
			light.color = OffColor;
		}
		if (MeshesToUpdate != null)
		{
			for (int i = 0; i < MeshesToUpdate.Count; i++)
			{
				if (MeshesToUpdate[i] != null && MeshesToUpdate[i].material != null)
				{
					MeshesToUpdate[i].material.color = OffColor;
				}
			}
		}
		if (ButtonAnimator != null)
		{
			ButtonAnimator.SetBool("Up", true);
		}
	}
}
