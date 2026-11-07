using Hub;
using UnityEngine;

public class ThankgivingTurkeyButton : MonoBehaviour
{
	[SerializeField]
	private FlagPackStarter _flagPackStarter;

	private int _counter;

	private double _cooldown;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}
}
