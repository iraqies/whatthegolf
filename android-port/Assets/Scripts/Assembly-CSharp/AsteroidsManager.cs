using UnityEngine;

public class AsteroidsManager : MonoBehaviour
{
	public float checkFrequency = 0.5f;

	private float checkTimer;

	public Animator UFOAnimator;

	private void Start()
	{
		checkTimer = checkFrequency;
	}

	private void Update()
	{
		checkTimer -= Time.deltaTime;
		if (!(checkTimer > 0f))
		{
			RecountAsteroids();
			checkTimer = checkFrequency;
		}
	}

	public void RecountAsteroids()
	{
		if (Object.FindObjectsOfType<Asteroid>().Length == 0)
		{
			UFOAnimator.SetTrigger("Enter");
		}
	}
}
