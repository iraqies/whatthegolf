using System.Collections.Generic;
using UnityEngine;

public class PlatformSpecificGameobject : MonoBehaviour
{
	public List<GameObject> GameObjectsToToggle;

	public bool StateOnStandalone;

	public bool StateOnMobile;

	public bool StateOnSwitch;

	public bool StateOnAppleTV;

	public bool StateOnPS4;

	public bool StateOnXboxOne;

	public bool StateOnPS5;

	private void Awake()
	{
	}
}
