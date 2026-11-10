using UnityEngine;

public class OverworldExplosionCrater : MonoBehaviour
{
	public ExplosionBarrel2D Barrel;

	public Vector3 ExplodedEuler;

	private void Start()
	{
		if (Barrel == null)
		{
			Barrel = GetComponentInParent<ExplosionBarrel2D>();
		}
		if (Barrel != null)
		{
			Barrel.OnExplode -= OnExplode;
			Barrel.OnExplode += OnExplode;
		}
	}

	private void OnExplode(Collider2D collider2D)
	{
		transform.localEulerAngles = ExplodedEuler;
	}
}
