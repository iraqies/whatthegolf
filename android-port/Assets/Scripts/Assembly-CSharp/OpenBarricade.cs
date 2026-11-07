using System.Collections.Generic;
using UnityEngine;

public class OpenBarricade : MonoBehaviour
{
	[SerializeField]
	private string id;

	[SerializeField]
	private List<GameObject> _gameObjectsToDeactiveteIfdoorIsOpen;

	[SerializeField]
	private List<GameObject> _gameObjectsToActivate;

	public bool isOpen => false;

	public void OpenDoor(bool setObjectState = false)
	{
	}

	private void InstanceOnOnToggleOverworld(bool obj)
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateState()
	{
	}

	private void SetState()
	{
	}

	private void DeactiveObjects()
	{
	}

	public void SetActive(List<GameObject> toList)
	{
	}

	public void SetDecals(List<GameObject> toList)
	{
	}
}
