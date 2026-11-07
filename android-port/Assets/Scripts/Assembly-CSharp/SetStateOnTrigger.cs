using System.Collections.Generic;
using UnityEngine;

public class SetStateOnTrigger : BaseStateSetter
{
	public bool onExit;

	public LayerMask layerMask;

	public bool canOnlyTriggerOnce;

	public bool useSpecificObjects;

	public List<GameObject> objects;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
