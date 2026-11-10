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

	public bool isOpen => SaveGame.GetIsDoorOpen(id);

	public void OpenDoor(bool setObjectState = false)
	{
		SaveGame.SetDoorOpen(id);
		SaveGame.Save(false);
		Debug.Log("Barricade Opened: " + id);
		if (setObjectState)
		{
			DeactiveObjects();
		}
	}

	private void InstanceOnOnToggleOverworld(bool obj)
	{
		if (obj && SaveGame.GetIsDoorOpen(id))
		{
			DeactiveObjects();
		}
	}

	private void OnEnable()
	{
		if (SaveGame.GetIsDoorOpen(id))
		{
			DeactiveObjects();
		}
	}

	public void UpdateState()
	{
		if (SaveGame.GetIsDoorOpen(id))
		{
			DeactiveObjects();
		}
	}

	private void SetState()
	{
		if (SaveGame.GetIsDoorOpen(id))
		{
			DeactiveObjects();
		}
	}

	private void DeactiveObjects()
	{
		if (_gameObjectsToDeactiveteIfdoorIsOpen != null)
		{
			foreach (GameObject item in _gameObjectsToDeactiveteIfdoorIsOpen)
			{
				if (item != null)
				{
					item.SetActive(value: false);
				}
			}
		}
		if (_gameObjectsToActivate != null)
		{
			foreach (GameObject item2 in _gameObjectsToActivate)
			{
				if (item2 != null)
				{
					if (item2.GetComponent<Rigidbody2D>() != null)
					{
						item2.transform.SetParent(base.transform.parent);
					}
					item2.SetActive(value: true);
				}
			}
		}
	}

	public void SetActive(List<GameObject> toList)
	{
		if (_gameObjectsToDeactiveteIfdoorIsOpen != null)
		{
			_gameObjectsToDeactiveteIfdoorIsOpen.AddRange(toList);
		}
	}

	public void SetDecals(List<GameObject> toList)
	{
		if (_gameObjectsToActivate != null)
		{
			_gameObjectsToActivate.AddRange(toList);
		}
	}
}
