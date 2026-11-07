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
	}
}
