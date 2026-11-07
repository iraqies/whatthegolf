using UnityEngine;

public class RainCloud2D : MonoBehaviour, IToggleable
{
	public bool startOn;

	public ParticleSystem particles;

	public float triggerDelay;

	public MonoBehaviour[] toggleBehaviours;

	public bool IsOn { get; set; }

	private void Awake()
	{
	}

	public void Toggle()
	{
	}

	public void Toggle(bool status)
	{
	}
}
