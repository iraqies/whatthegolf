using UnityEngine;
using UnityEngine.UI;

public class KeepSomethingSelected : MonoBehaviour
{
	[SerializeField]
	private Selectable[] _defaultSelectables;

	[SerializeField]
	public GameObject _lastSelected;

	public Selectable[] defaultSelectables
	{
		set
		{
		}
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void KeepSelection()
	{
	}
}
