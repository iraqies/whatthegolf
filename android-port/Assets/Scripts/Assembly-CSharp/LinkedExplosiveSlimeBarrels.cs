using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LinkedExplosiveSlimeBarrels : MonoBehaviour
{
	[SerializeField]
	private List<ExplosionBarrel2D> _barrel;

	[SerializeField]
	private OpenBarricade _barricade;

	[SerializeField]
	private List<GameObject> _decals;

	[SerializeField]
	private List<GameObject> _deactivateObjectsOnExplode;

	[SerializeField]
	private OverworldMainDoorRobot _robot;

	[SerializeField]
	private UnityEvent _onExplode;

	private void Start()
	{
	}

	public void ExplodeAll(Collider2D col)
	{
	}
}
