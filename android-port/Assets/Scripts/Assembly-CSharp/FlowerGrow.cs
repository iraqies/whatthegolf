using UnityEngine;

public class FlowerGrow : MonoBehaviour
{
	public Transform flower;

	public int growthStep;

	private GrowFlowerChallenge growFlowerChallenge;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
