using UnityEngine;

public class HammerToy : MonoBehaviour
{
	public Collider flatTrigger;

	public FlatToyBehaviour flatControllerPrefab;

	public FlatToyBehaviour flatPropPrefab;

	private bool canFlatten;

	private FlatToyBehaviour instantiatedFlatToy;

	private void OnTriggerStay(Collider other)
	{
	}

	private void InstantiateFlatController(GameObject GOtoReplace, bool isController)
	{
	}

	public void FlattenFromAnimation()
	{
	}
}
