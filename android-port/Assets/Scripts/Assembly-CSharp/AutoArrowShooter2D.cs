using System.Collections.Generic;
using Audio;
using UnityEngine;
using Utility;

public class AutoArrowShooter2D : MonoBehaviour
{
	public Animator Animator;

	public Transform ArcherTorso;

	public float ShootForce;

	public float ShootInterval;

	public Transform ArrowStart;

	public Arrow2D ArrowTemplate;

	public List<Vector2> ShootDirections;

	public Vector2 ShotRandomnessRange;

	public int MaxNumberOfActiveArrows;

	private ObjectPool<Arrow2D> arrowPool;

	private float timer;

	private Vector2 nextShotDirection;

	private Quaternion lastRot;

	private List<Arrow2D> spawnedArrows;

	public ClipSettingsCollection ShootSFX;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnHitGoal()
	{
	}

	public void Shoot(Vector3 boost)
	{
	}

	private Arrow2D SpawnNewArrow()
	{
		return null;
	}
}
