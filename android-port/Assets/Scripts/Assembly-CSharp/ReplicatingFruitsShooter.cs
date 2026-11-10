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
		ballController = GetComponent<GolfBallController>();
		if (listOfFruits != null)
		{
			listOfFruits.Add(startObject);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (ballController != null)
		{
			ballController.ShootCoolDown = 0.6f;
		}
		StartCoroutine(ShootFruits(boost));
	}

	private IEnumerator ShootFruits(Vector3 boost)
	{
		Vector3 stepVec = boost.normalized * 10f;
		int count = Mathf.RoundToInt(boost.magnitude * (float)maxNumberOfFruitChain) + 1;
		if (controller_rb != null)
		{
			controller_rb.useGravity = false;
		}
		for (int i = 0; i < count; i++)
		{
			if (Physics.Raycast(base.transform.position + Vector3.up, boost, boost.magnitude * 10f * distanceBetweenFruits))
			{
				if (ballController != null)
				{
					ballController.ShootCoolDown = 0f;
				}
			}
			else
			{
				float x = Random.Range(-360f, 360f);
				float y = Random.Range(-360f, 360f);
				float z = Random.Range(-360f, 360f);
				if (objectsList != null && objectsList.Length > 0)
				{
					GameObject fruit = Object.Instantiate(objectsList[Random.Range(0, objectsList.Length - 1)]);
					if (randomRotation)
					{
						fruit.transform.rotation = Quaternion.Euler(x, y, z);
					}
					fruit.transform.position = base.transform.position + stepVec * distanceBetweenFruits;
					fruit.layer = 2;
					Vector3 targetScale = fruit.transform.localScale;
					StartCoroutine(pTween.To(inDuration, 0f, 1f, delegate(float t)
					{
						if (fruit != null && fruit.transform != null)
						{
							float t2 = ((curve != null) ? curve.Evaluate(t) : t);
							fruit.transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, t2);
						}
					}));
					if (AudioOnSpawn != null)
					{
						AudioOnSpawn.Play(fruit.transform.position);
					}
					fruit.AddComponent<TreeCounter>();
					listOfFruits.Add(fruit);
					if (listOfFruits.Count >= maxNumberOfFruits && listOfFruits.Count > 0)
					{
						GameObject fruitToDestroy = listOfFruits[0];
						listOfFruits.RemoveAt(0);
						StartCoroutine(DestroyFruit(fruitToDestroy));
					}
					base.transform.position = fruit.transform.position;
				}
				yield return new WaitForSeconds(0.05f);
			}
		}
		if (controller_rb != null)
		{
			controller_rb.useGravity = true;
		}
	}

	private IEnumerator DestroyFruit(GameObject fruit)
	{
		Vector3 startScale = ((fruit != null) ? fruit.transform.localScale : Vector3.one);
		yield return StartCoroutine(pTween.To(outDuration, 0f, 1f, delegate(float t)
		{
			if (fruit != null && fruit.transform != null)
			{
				float t2 = ((curve != null) ? Mathf.Clamp01(curve.Evaluate(t)) : Mathf.Clamp01(t));
				fruit.transform.localScale = Vector3.Lerp(startScale, Vector3.zero, t2);
			}
		}));
		if (fruit != null)
		{
			Object.Destroy(fruit);
		}
	}

	public ReplicatingFruitsShooter()
	{
		maxNumberOfFruitChain = 7;
		distanceBetweenFruits = 1f;
		randomRotation = true;
		listOfFruits = new List<GameObject>();
	}
}
