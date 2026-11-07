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
	}

	private void FirstTime()
	{
	}
}
