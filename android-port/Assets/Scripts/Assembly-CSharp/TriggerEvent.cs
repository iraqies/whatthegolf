using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
	public UnityEvent OnEnter;

	public UnityEvent OnExit;

	public List<string> Tags;

	public Color OnColor;

	public Color OffColor;

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
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void EnterInvoke()
	{
	}

	private void ExitInvoke()
	{
	}
}
