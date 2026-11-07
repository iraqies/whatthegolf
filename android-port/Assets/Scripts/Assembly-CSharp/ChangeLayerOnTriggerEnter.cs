using UnityEngine;

public class ChangeLayerOnTriggerEnter : MonoBehaviour
{
	public LayerMask ValidLayers;

	public string NewLayer;

	private void OnTriggerEnter(Collider other)
	{
	}
}
