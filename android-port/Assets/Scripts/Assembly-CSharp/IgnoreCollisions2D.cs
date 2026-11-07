using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisions2D : MonoBehaviour
{
	[SerializeField]
	private GameObject rootA;

	[SerializeField]
	private List<Collider2D> rootAblackList;

	[SerializeField]
	private GameObject rootB;

	[SerializeField]
	private List<Collider2D> rootBblacklist;

	[SerializeField]
	private bool ignoreCollisions;

	private void Awake()
	{
	}
}
