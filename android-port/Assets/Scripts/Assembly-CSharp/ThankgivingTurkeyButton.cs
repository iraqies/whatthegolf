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
		if (Time.time - _cooldown < 0.5 || col == null || col.gameObject == null)
		{
			return;
		}
		if (col.gameObject.CompareTag("Ball") || col.gameObject.CompareTag("Player") || col.gameObject.GetComponentInParent<OverworldBall2D>() != null)
		{
			_counter++;
			_cooldown = Time.time;
		}
		if (_counter >= 3 && _flagPackStarter != null)
		{
			_flagPackStarter.StartPack();
			_counter = 0;
		}
	}
}
