using UnityEngine;

public class ToggleBehaviourBasedOnPlatform : MonoBehaviour
{
	public enum WhenToToggleEnum
	{
		Awake = 0,
		OnEnable = 1,
		Start = 2
	}

	public bool StateOnMobile;

	public Behaviour[] BehavioursToToggle;

	public GameObject[] GameObjectsToToggle;

	public WhenToToggleEnum WhenToToggle;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void Toggle()
	{
	}
}
