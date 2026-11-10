using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectsContainer : MonoBehaviour
{
	public List<GameObject> ObjectsToIgnore;

	private static GameObject _ball;

	private static GameObject _islandBall;

	private List<Collider2D> CollidersToCheck = new List<Collider2D>();

	private List<Collider2D> DisabledColliders = new List<Collider2D>();

	private List<Collider2D> ToRemove = new List<Collider2D>();

	private bool[] disabledByCheck;

	private List<Rigidbody2D> RigidbodyToCheck = new List<Rigidbody2D>();

	private int checkInterval = 10;

	private int currentCheck;

	private float currDistance;

	private Vector3 ballPos = Vector3.zero;

	private static ObjectsContainer _instance;

	public static ObjectsContainer Instance
	{
		get
		{
			return _instance;
		}
		private set
		{
			_instance = value;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void FillCollidersList()
	{
		PolygonCollider2D[] array = UnityEngine.Object.FindObjectsOfType<PolygonCollider2D>();
		CircleCollider2D[] array2 = UnityEngine.Object.FindObjectsOfType<CircleCollider2D>();
		BoxCollider2D[] array3 = UnityEngine.Object.FindObjectsOfType<BoxCollider2D>();
		CapsuleCollider2D[] array4 = UnityEngine.Object.FindObjectsOfType<CapsuleCollider2D>();
		Rigidbody2D[] array5 = UnityEngine.Object.FindObjectsOfType<Rigidbody2D>();
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && array[i].gameObject.activeSelf && array[i].enabled)
				{
					CollidersToCheck.Add(array[i]);
				}
			}
		}
		string[] names = new string[3] { "Flag", "Button", "Save" };
		if (array2 != null)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				if (array2[j] != null && array2[j].gameObject.activeSelf && array2[j].enabled && !CheckForNames(array2[j].name, names))
				{
					CollidersToCheck.Add(array2[j]);
				}
			}
		}
		string[] names2 = new string[10] { "Door", "Bridge", "Wall", "Water", "Trigger", "Button", "Goal", "Chest", "Portal", "Cam" };
		if (array3 != null)
		{
			for (int k = 0; k < array3.Length; k++)
			{
				if (array3[k] != null && array3[k].gameObject.activeSelf && array3[k].enabled && !CheckForNames(array3[k].name, names2))
				{
					CollidersToCheck.Add(array3[k]);
				}
			}
		}
		if (array4 != null)
		{
			for (int l = 0; l < array4.Length; l++)
			{
				if (array4[l] != null && array4[l].gameObject.activeSelf && array4[l].enabled)
				{
					CollidersToCheck.Add(array4[l]);
				}
			}
		}
		string[] names3 = new string[6] { "Ball", "Boat", "Flag", "Save", "Button", "Chest" };
		if (array5 != null)
		{
			for (int m = 0; m < array5.Length; m++)
			{
				if (array5[m] != null && array5[m].gameObject.activeSelf && array5[m].simulated && !CheckForNames(array5[m].name, names3))
				{
					RigidbodyToCheck.Add(array5[m]);
				}
			}
		}
		disabledByCheck = new bool[CollidersToCheck.Count];
	}

	private bool CheckForNames(string name, string[] names)
	{
		if (names == null || name == null)
		{
			return false;
		}
		bool flag = false;
		for (int i = 0; i < names.Length; i++)
		{
			flag |= name.IndexOf(names[i], StringComparison.CurrentCultureIgnoreCase) >= 0;
		}
		return flag;
	}

	private bool CaseInsensitiveContains(string text, string value, StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
	{
		return text.IndexOf(value, stringComparison) >= 0;
	}

	private void Update()
	{
	}

	public void DisableObjectsCheck(bool state)
	{
		if (state)
		{
			if (CollidersToCheck != null)
			{
				CollidersToCheck.RemoveAll((Collider2D x) => x == null);
				if (DisabledColliders != null && DisabledColliders.Count == 0)
				{
					List<Collider2D> collection = CollidersToCheck.FindAll((Collider2D x) => x != null && ObjectsToIgnore != null && ObjectsToIgnore.Exists((GameObject y) => y == x.gameObject));
					DisabledColliders.AddRange(collection);
				}
				if (DisabledColliders != null)
				{
					CollidersToCheck = CollidersToCheck.Except(DisabledColliders).ToList();
					foreach (Collider2D disabledCollider in DisabledColliders)
					{
						if (disabledCollider != null)
						{
							disabledCollider.gameObject.SetActive(true);
						}
					}
				}
			}
		}
		else if (CollidersToCheck != null && DisabledColliders != null)
		{
			CollidersToCheck.AddRange(DisabledColliders);
		}
	}

	public void RemoveFromComputing(Collider2D collider)
	{
		if (ToRemove != null)
		{
			ToRemove.Add(collider);
		}
	}

	public static void SetBall(GameObject ballRef)
	{
		_ball = ballRef;
	}

	public static void SetIslandBall(GameObject ballRef)
	{
		_islandBall = ballRef;
	}

	public static GameObject GetIslandBall()
	{
		return _islandBall;
	}

	private void InvokeCheck()
	{
		if (_islandBall != null)
		{
			ballPos = _islandBall.transform.position;
		}
		else if (_ball != null)
		{
			ballPos = _ball.transform.position;
		}
		CheckCollider(CollidersToCheck, ballPos);
		RemoveFromCheck();
		CheckBodies(ballPos);
		currentCheck = 0;
	}

	private void CheckCollider(List<Collider2D> toCheck, Vector3 PositionToCheck)
	{
		if (toCheck == null)
		{
			return;
		}
		for (int i = 0; i < toCheck.Count; i++)
		{
			Collider2D collider2D = toCheck[i];
			if (collider2D == null || (ToRemove != null && ToRemove.Contains(collider2D)))
			{
				continue;
			}
			currDistance = Vector2.Distance(PositionToCheck, collider2D.transform.position);
			if (currDistance <= 20f)
			{
				if (disabledByCheck != null && i < disabledByCheck.Length && disabledByCheck[i] && !collider2D.enabled)
				{
					collider2D.gameObject.SetActive(true);
					collider2D.enabled = true;
					disabledByCheck[i] = false;
				}
				continue;
			}
			if (currDistance >= 50f && collider2D.gameObject.activeSelf)
			{
				collider2D.gameObject.SetActive(false);
			}
			else if (currDistance < 50f && !collider2D.gameObject.activeSelf)
			{
				collider2D.gameObject.SetActive(true);
			}
			collider2D.enabled = false;
			if (disabledByCheck != null && i < disabledByCheck.Length)
			{
				disabledByCheck[i] = true;
			}
		}
	}

	private void RemoveFromCheck()
	{
		if (ToRemove != null && ToRemove.Count >= 1)
		{
			CollidersToCheck = CollidersToCheck.Except(ToRemove).ToList();
			ToRemove.Clear();
		}
	}

	private void CheckBodies(Vector3 PositionToCheck)
	{
		if (RigidbodyToCheck == null)
		{
			return;
		}
		for (int i = 0; i < RigidbodyToCheck.Count; i++)
		{
			Rigidbody2D rigidbody2D = RigidbodyToCheck[i];
			if (!(rigidbody2D == null))
			{
				currDistance = Vector3.Distance(PositionToCheck, rigidbody2D.transform.position);
				rigidbody2D.simulated = currDistance <= 30f;
			}
		}
	}
}
