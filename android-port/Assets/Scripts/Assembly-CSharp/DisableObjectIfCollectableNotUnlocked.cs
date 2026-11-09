using UnityEngine;

public class DisableObjectIfCollectableNotUnlocked : MonoBehaviour
{
	public Collectable Collectable;

	private void Awake()
	{
		if (Collectable != null && !Collectable.IsUnlocked())
		{
			gameObject.SetActive(false);
		}
	}
}
