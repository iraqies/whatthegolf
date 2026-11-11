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
		if (canFlatten)
		{
			if (other.CompareTag("Player") && instantiatedFlatToy == null)
			{
				InstantiateFlatController(other.transform.gameObject, true);
			}
			else if (other.CompareTag("Toy") && !other.GetComponentInParent<FlatToyBehaviour>())
			{
				InstantiateFlatController(other.transform.gameObject, false);
			}
		}
	}

	private void InstantiateFlatController(GameObject GOtoReplace, bool isController)
	{
		if ((bool)GOtoReplace.GetComponent<Joint>())
		{
			Object.Destroy(GOtoReplace.GetComponent<Joint>());
		}
		GOtoReplace.transform.rotation = Quaternion.Euler(Vector3.Project(GOtoReplace.transform.rotation.eulerAngles, Vector3.up));
		GOtoReplace.transform.position = new Vector3(GOtoReplace.transform.position.x, base.transform.position.y + 1f, GOtoReplace.transform.position.z);
		FlatToyBehaviour original = (isController ? flatControllerPrefab : flatPropPrefab);
		instantiatedFlatToy = Object.Instantiate(original, GOtoReplace.transform.position, GOtoReplace.transform.rotation);
		instantiatedFlatToy.Initialize(GOtoReplace);
	}

	public void FlattenFromAnimation()
	{
		canFlatten = !canFlatten;
		flatTrigger.enabled = canFlatten;
	}
}
