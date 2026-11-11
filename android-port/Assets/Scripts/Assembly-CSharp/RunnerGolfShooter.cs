using Core;
using UnityEngine;

public class RunnerGolfShooter : GolfBallShooterExperimental
{
	public float ForwardSpeed = 5f;

	public float SpinSpeed = 10f;

	public float JumpSpeed = 5f;

	public float MoveAngleThreshold = 45f;

	public float MoveLaneSpeed = 5f;

	public float LaneWidth = 2f;

	public int NumberOfLanes = 3;

	public int StartLane = 1;

	public AudioClip CoinCollectClip;

	private int currentLane;

	private int targetLane;

	private Vector3 startPos;

	private bool canJump;

	protected override void Awake()
	{
		base.Awake();
		currentLane = StartLane;
		targetLane = StartLane;
		startPos = base.transform.position;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (Vector3.Angle(boost, -base.transform.right) <= MoveAngleThreshold && currentLane > 0)
		{
			currentLane--;
		}
		else if (Vector3.Angle(boost, base.transform.right) <= MoveAngleThreshold && currentLane < NumberOfLanes - 1)
		{
			currentLane++;
		}
		else if (canJump)
		{
			Jump();
			canJump = false;
		}
	}

	private void OnCollisionStay(Collision col)
	{
		if (col == null || col.contacts == null || col.contacts.Length == 0)
		{
			return;
		}
		if (Vector3.Dot(col.contacts[0].normal, Vector3.up) > 0.7f)
		{
			canJump = true;
		}
	}

	protected new void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigid == null)
		{
			return;
		}
		Vector3 forward = Vector3.forward;
		float num = ((float)currentLane - (float)(NumberOfLanes - 1) * 0.5f) * LaneWidth;
		Vector3 a = new Vector3(startPos.x, 0f, 0f) + Vector3.right * num;
		Vector3 b = new Vector3(base.transform.position.x, 0f, 0f);
		float num2 = Vector3.Distance(a, b);
		Vector3 vector = Vector3.zero;
		if (num2 > 0.1f)
		{
			vector = (a - b).normalized * MoveLaneSpeed * Mathf.Clamp01(num2);
		}
		rigid.velocity = new Vector3(vector.x, rigid.velocity.y, forward.z * ForwardSpeed);
		rigid.AddTorque(Vector3.right * SpinSpeed);
	}

	protected virtual void Jump()
	{
		if (rigid != null)
		{
			rigid.velocity += Vector3.up * JumpSpeed;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gameObject.layer == LayerMask.NameToLayer("Coin"))
		{
			Object.Destroy(other.gameObject);
			if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
			{
				AudioManager.Instance.sfx.Play(CoinCollectClip, delegate(AudioSource s)
				{
					s.pitch = Random.Range(0.95f, 1.05f);
					s.volume = 0.5f;
				});
			}
		}
		else if (other.gameObject.layer == LayerMask.NameToLayer("Enemy") && GolfBallController != null)
		{
			GolfBallController.OutOfBounds("Crash", 0.4f);
		}
	}

	public override void OnReset()
	{
		base.OnReset();
		currentLane = StartLane;
		targetLane = StartLane;
	}
}
