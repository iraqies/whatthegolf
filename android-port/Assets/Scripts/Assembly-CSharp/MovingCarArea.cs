using UnityEngine;

public class MovingCarArea : MonoBehaviour
{
	public InvisibleCullingObject cullingRect;

	public MovingCar[] movingCars;

	private float time;

	public void Awake()
	{
		cullingRect.OnVisible += delegate
		{
			base.enabled = true;
		};
		cullingRect.OnInvisible += delegate
		{
			base.enabled = false;
		};
		base.enabled = false;
	}

	public void FixedUpdate()
	{
		time += Time.deltaTime;
		for (int i = 0; i < movingCars.Length; i++)
		{
			movingCars[i].Move(time);
		}
	}
}
