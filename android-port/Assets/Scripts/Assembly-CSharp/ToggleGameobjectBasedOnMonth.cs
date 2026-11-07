using System.Collections.Generic;
using UnityEngine;

public class ToggleGameobjectBasedOnMonth : MonoBehaviour
{
	[SerializeField]
	private int month;

	[SerializeField]
	private List<GameObject> objectsToToggle;

	private void Awake()
	{
	}
}
