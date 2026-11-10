using System.Collections.Generic;
using UnityEngine;

public class ZombieClub : MonoBehaviour
{
	public Transform[] seats;

	private List<Transform> freeSeats;

	private void Start()
	{
		freeSeats = new List<Transform>();
		if (seats != null)
		{
			freeSeats.AddRange(seats);
		}
	}

	public Transform TakeSeat()
	{
		if (freeSeats == null)
		{
			freeSeats = new List<Transform>();
			if (seats != null)
			{
				freeSeats.AddRange(seats);
			}
		}
		if (freeSeats.Count == 0)
		{
			return null;
		}
		Transform result = freeSeats[0];
		freeSeats.RemoveAt(0);
		return result;
	}

	public Transform TakeClosestSeat(Vector3 position)
	{
		if (freeSeats == null)
		{
			freeSeats = new List<Transform>();
			if (seats != null)
			{
				freeSeats.AddRange(seats);
			}
		}
		if (freeSeats.Count == 0)
		{
			return null;
		}
		Transform closest = null;
		float bestDist = float.PositiveInfinity;
		for (int i = 0; i < freeSeats.Count; i++)
		{
			Transform seat = freeSeats[i];
			if (seat != null)
			{
				float dist = Vector3.Distance(position, seat.position);
				if (dist < bestDist)
				{
					bestDist = dist;
					closest = seat;
				}
			}
		}
		if (closest != null)
		{
			freeSeats.Remove(closest);
		}
		return closest;
	}

	public void FreeSeat(Transform seat)
	{
		if (seat != null && freeSeats != null && !freeSeats.Contains(seat))
		{
			freeSeats.Add(seat);
		}
	}

	private void OnDrawGizmos()
	{
	}
}
