using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherTrigger : MonoBehaviour
{
	public int flameDamage;

	private List<ExtinguishableFlame> flamesInside;

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	private void Update()
	{
	}
}
