using Core;
using UnityEngine;

public class ShootingTargetIncrementLevelRTPC : MonoBehaviour
{
	public ShootingGalleryTarget[] targets;

	public LevelData levelData;

	private float startValue;

	private float incrementValue;

	private int hits;

	private void Start()
	{
	}

	private void OnAnyHit(Vector3 hit)
	{
	}
}
