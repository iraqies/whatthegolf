using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsContainer : MonoBehaviour
{
	public List<GameObject> ObjectsToIgnore;

	private static GameObject _ball;

	private static GameObject _islandBall;

	private List<Collider2D> CollidersToCheck;

	private List<Collider2D> DisabledColliders;

	private List<Collider2D> ToRemove;

	private bool[] disabledByCheck;

	private List<Rigidbody2D> RigidbodyToCheck;

	private int checkInterval;

	private int currentCheck;

	private float currDistance;

	private Vector3 ballPos;

	private static ObjectsContainer _instance;

	public static ObjectsContainer Instance
	{
		get
		{
			return null;
		}
		private set
		{
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
	}

	private bool CheckForNames(string name, string[] names)
	{
		return false;
	}

	private bool CaseInsensitiveContains(string text, string value, StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
	{
		return false;
	}

	private void Update()
	{
	}

	public void DisableObjectsCheck(bool state)
	{
	}

	public void RemoveFromComputing(Collider2D collider)
	{
	}

	public static void SetBall(GameObject ballRef)
	{
	}

	public static void SetIslandBall(GameObject ballRef)
	{
	}

	public static GameObject GetIslandBall()
	{
		return null;
	}

	private void InvokeCheck()
	{
	}

	private void CheckCollider(List<Collider2D> toCheck, Vector3 PositionToCheck)
	{
	}

	private void RemoveFromCheck()
	{
	}

	private void CheckBodies(Vector3 PositionToCheck)
	{
	}
}
