using UnityEngine;

public class OverworldPositionSave : MonoBehaviour
{
	public float SaveVelocityThreshold;

	private bool startSaving;

	private Rigidbody2D rigid;

	private OverworldID id;

	private readonly string saveKey;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void FixedUpdate()
	{
	}
}
