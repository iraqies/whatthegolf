using System.Collections.Generic;
using UnityEngine;

public class ValentinesPrizeVase : MonoBehaviour
{
	[SerializeField]
	private GameObject BalloonPrefab;

	[SerializeField]
	private List<Material> materials;

	private Rigidbody rigid;

	private List<Balloon> balloons;

	private void Start()
	{
	}

	private void OnBalloonPopped(Balloon b)
	{
	}

	public void NewBalloon()
	{
	}
}
