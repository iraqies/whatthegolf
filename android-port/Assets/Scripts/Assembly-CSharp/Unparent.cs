using UnityEngine;

public class Unparent : MonoBehaviour
{
	public GameObject objectToUnparent;

	public void UnparentObject()
	{
		if (objectToUnparent != null)
		{
			objectToUnparent.transform.parent = null;
		}
	}
}
