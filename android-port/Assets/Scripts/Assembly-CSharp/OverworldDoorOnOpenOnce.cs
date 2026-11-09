using UnityEngine;
using UnityEngine.Events;

public class OverworldDoorOnOpenOnce : MonoBehaviour
{
	[SerializeField]
	private OverworldButton2D door;

	[SerializeField]
	private GameObject doorButton;

	[SerializeField]
	private UnityEvent onDoorFirstTime;

	[SerializeField]
	private UnityEvent onDoorAlreadyOpened;

	[SerializeField]
	private bool _useOnStartingToOpen;

	private void Start()
	{
		if (door == null && doorButton != null)
			door = doorButton.GetComponent<OverworldButton2D>();
		if (door == null)
			door = GetComponent<OverworldButton2D>() ?? GetComponentInParent<OverworldButton2D>();
		if (door == null)
			return;

		if (door.openOrOpening)
		{
			onDoorAlreadyOpened?.Invoke();
		}
		else if (_useOnStartingToOpen)
		{
			door.OnStartingToOpen -= FirstTime;
			door.OnStartingToOpen += FirstTime;
		}
		else
		{
			door.OnOpen -= FirstTime;
			door.OnOpen += FirstTime;
		}
	}

	private void FirstTime()
	{
		if (door != null)
		{
			door.OnStartingToOpen -= FirstTime;
			door.OnOpen -= FirstTime;
		}
		onDoorFirstTime?.Invoke();
	}
}
