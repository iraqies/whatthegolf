using UnityEngine;

public class ToggleActiveStateOfChildren : MonoBehaviour
{
	private int index;

	private void Start() { }

	public void Toggle()
	{
		if (transform.childCount == 0) return;
		index = (index + 1) % transform.childCount;
		for (int i = 0; i < transform.childCount; i++)
			transform.GetChild(i).gameObject.SetActive(i == index);
	}
}
