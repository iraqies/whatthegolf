using Core;
using UnityEngine;

public class BoatPlayer : MonoBehaviour
{
	public GameObject BallSprite;

	public GolfBallController Controller;

	public Rigidbody2D Rigid;

	public Collider2D Collider;

	public float NoiseScale = 1f;

	public float WaveForce = 1f;

	public float WaveTorque = 0.1f;

	public float ScrollSpeed = 1f;

	private Vector3 startPos;

	private Vector2 waveScroll;

	private void Awake()
	{
		if (BallSprite != null)
		{
			startPos = BallSprite.transform.localPosition;
		}
	}

	public void Reset()
	{
		if (BallSprite != null)
		{
			BallSprite.transform.position = startPos;
		}
	}

	public Vector3 GetBoatPlayerPosition()
	{
		return base.transform.TransformPoint(startPos);
	}

	public void Dock()
	{
		if (Controller != null)
		{
			Controller.enabled = false;
			if (Controller.shootArrow != null)
			{
				Controller.shootArrow.Hide();
			}
		}
		if (Rigid != null)
		{
			Rigid.velocity = Vector2.zero;
			Rigid.angularVelocity = 0f;
		}
		if (Collider != null)
		{
			Collider.enabled = false;
		}
	}

	public void Undock()
	{
		if (Controller != null)
		{
			Controller.enabled = true;
		}
		if (Collider != null)
		{
			Collider.enabled = true;
		}
	}

	private void FixedUpdate()
	{
		waveScroll += Vector2.one * (Time.deltaTime * ScrollSpeed);
		if (Controller != null && Controller.enabled && Rigid != null)
		{
			Vector3 position = base.transform.position;
			float num = Mathf.PerlinNoise((position.x + waveScroll.x) * NoiseScale, (position.y + waveScroll.y) * NoiseScale);
			float t = Mathf.PerlinNoise((position.x * 2f + waveScroll.x) * NoiseScale, (position.y * 2f + waveScroll.y) * NoiseScale);
			float z = Mathf.Lerp(0f, 360f, t);
			Vector3 vector = Quaternion.Euler(0f, 0f, z) * Vector3.right;
			Rigid.AddForce(new Vector2(num * vector.x * WaveForce, num * vector.y * WaveForce));
			Rigid.AddTorque((num * 2f - 1f) * WaveTorque);
		}
	}
}
