using Cinemachine;
using UnityEngine;

public class DollyCartController : MonoBehaviour
{
	public CinemachineDollyCart Cart;

	public Transform LookAt;

	public Vector2 WaitTimeBeforeChangeDirection = new Vector2(0.3f, 1f);

	private float waitTimer;

	private void Update()
	{
		if (Cart == null)
		{
			return;
		}
		if (Cart.m_Position == 0f || Cart.m_Position == 1f)
		{
			if (waitTimer > 0f)
			{
				waitTimer -= Time.deltaTime;
				return;
			}
			Cart.m_Speed = 0f - Cart.m_Speed;
			waitTimer = Random.Range(WaitTimeBeforeChangeDirection.x, WaitTimeBeforeChangeDirection.y);
		}
	}
}
