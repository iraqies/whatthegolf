using UnityEngine;

public class JetpackJoyrideBackgroundObject : MonoBehaviour
{
	public float MoveSpeedMod = 1f;

	public bool MoveWithPhysics;

	public Transform BackgroundObjectStartPosition;

	public Transform BackgroundObjectEndPosition;

	public Rigidbody2D Rigidbody { get; set; }

	private void Awake()
	{
		if (MoveWithPhysics)
		{
			Rigidbody = GetComponent<Rigidbody2D>();
		}
	}
}
