using System.Collections.Generic;
using UnityEngine;

public class ZombieClub : MonoBehaviour
{
	public Transform[] seats;

	private List<Transform> freeSeats;

	private void Start()
	{
	}

	public Transform TakeSeat()
	{
		return null;
	}

	public Transform TakeClosestSeat(Vector3 position)
	{
		return null;
	}

	public void FreeSeat(Transform seat)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
