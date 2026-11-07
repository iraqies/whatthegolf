using UnityEngine;

public class ChangeLayerOnCollision : MonoBehaviour
{
	public LayerMask ValidLayers;

	public int NewLayer;

	private void OnCollisionEnter(Collision other)
	{
	}
}
