using UnityEngine;

public class RotatingPlanet : MonoBehaviour
{
	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform targetPlanet;

	private void Update()
	{
		if (Time.timeScale == 0f || Time.deltaTime == 0f || targetPlanet == null)
		{
			return;
		}
		transform.RotateAround(targetPlanet.position, Vector3.forward, speed * Time.deltaTime);
	}
}
