using UnityEngine;

public class DestroyObject : MonoBehaviour
{
	public GameObject objectToDestroy;

	private void Start()
	{
		if (objectToDestroy == null)
			objectToDestroy = gameObject;
	}

	public void Destroy()
	{
		if (objectToDestroy != null)
			Object.Destroy(objectToDestroy);
	}
}
