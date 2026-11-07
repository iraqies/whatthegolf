using UnityEngine;

public class AddressableLabels : MonoBehaviour
{
	public enum AddressableLabel
	{
		ONLOAD = 0,
		MENU = 1,
		MAIN = 2,
		SPORTY = 3,
		HOLE = 4,
		WINTER = 5,
		MAIN_MID = 6,
		MAIN_LATE = 7
	}

	public AddressableLabel label;
}
