using UnityEngine;

public class Toggler : MonoBehaviour
{
	public bool startOn;

	public float startDelay;

	public float duration;

	public float interval;

	public Transform toggleableContainer;

	private IToggleable toggleable;

	private float durationTimer;

	private float startTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
