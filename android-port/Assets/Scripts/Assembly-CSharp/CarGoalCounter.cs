using System.Collections.Generic;
using UnityEngine;

public class CarGoalCounter : MonoBehaviour
{
	private int currentPlayerPosition;

	private List<CarOpponentController> opponentsInGoal;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
