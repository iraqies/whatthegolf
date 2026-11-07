using UnityEngine;

public class PropPlacer : MonoBehaviour
{
	public float undergroundPct;

	public bool includeMeshesInBounds;

	public bool isLocked;

	[SerializeField]
	private LayerMask mask;

	[SerializeField]
	private Transform _planet;

	public void Place()
	{
	}

	public void PlaceOrbital()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private Vector3 GetBottom()
	{
		return default;
	}
}
