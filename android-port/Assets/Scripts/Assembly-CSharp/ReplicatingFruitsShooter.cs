using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class ReplicatingFruitsShooter : ShooterBase
{
	public Rigidbody controller_rb;

	public GameObject[] objectsList;

	public int maxNumberOfFruits;

	public int maxNumberOfFruitChain;

	public float distanceBetweenFruits;

	public bool randomRotation;

	private Animator animator;

	private GolfBallController ballController;

	private List<GameObject> listOfFruits;

	[SerializeField]
	private GameObject startObject;

	[SerializeField]
	private ClipSettingsCollection AudioOnSpawn;

	[SerializeField]
	private AnimationCurve curve;

	[SerializeField]
	private float inDuration;

	[SerializeField]
	private float outDuration;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private IEnumerator ShootFruits(Vector3 boost)
	{
		return null;
	}

	private IEnumerator DestroyFruit(GameObject fruit)
	{
		return null;
	}
}
