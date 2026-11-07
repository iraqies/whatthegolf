using Core;
using UnityEngine;

public class BoatPlayer : MonoBehaviour
{
	public GameObject BallSprite;

	public GolfBallController Controller;

	public Rigidbody2D Rigid;

	public Collider2D Collider;

	public float NoiseScale;

	public float WaveForce;

	public float WaveTorque;

	public float ScrollSpeed;

	private Vector3 startPos;

	private Vector2 waveScroll;

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	public Vector3 GetBoatPlayerPosition()
	{
		return default;
	}

	public void Dock()
	{
	}

	public void Undock()
	{
	}

	private void FixedUpdate()
	{
	}
}
