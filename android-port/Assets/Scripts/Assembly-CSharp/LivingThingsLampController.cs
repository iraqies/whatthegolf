using Core;
using UnityEngine;

public class LivingThingsLampController : MonoBehaviour
{
	[SerializeField]
	private GameObject cone;

	[SerializeField]
	private Animator _a;

	private void Start()
	{
		GetComponent<GolfBallController>().OnAimStart += OnAimStart;
		GetComponent<GolfBallController>().OnAimUpdate += OnAimUpdate;
		GetComponent<GolfBallController>().OnShoot += OnShoot;
	}

	private void OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	private void OnShoot(Vector3 obj)
	{
		cone.SetActive(value: false);
	}

	private void OnAimStart()
	{
		cone.SetActive(value: true);
	}
}
