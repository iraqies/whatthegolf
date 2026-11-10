using UnityEngine;

public class DemoEnabler : MonoBehaviour
{
	[SerializeField]
	private bool _switchOnly;

	[SerializeField]
	private bool _steamOnly;

	[SerializeField]
	private bool _inverse;

	[SerializeField]
	private bool _applyOnThisObject;

	private void Awake()
	{
		if (_applyOnThisObject)
		{
			gameObject.SetActive(_inverse);
			return;
		}
		foreach (Transform child in transform)
		{
			if (child != null)
			{
				child.gameObject.SetActive(_inverse);
			}
		}
	}
}
