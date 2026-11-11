using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class BreakoutBall : MonoBehaviour
{
	public enum TransferVelocityMode
	{
		X = 0,
		Y = 1,
		XY = 2
	}

	public GolfBallController player;

	public float velTransferMagnitude;

	public float maxVel = 20f;

	public float maxHits = 20f;

	public AnimationCurve velocityEvolution;

	public float startNormalVel = 10f;

	public float minPlayAxisVel = 5f;

	public List<AudioClip> ShootSounds;

	public TransferVelocityMode velTransferMode;

	private Rigidbody2D rigid;

	private Vector2 lastVel;

	private Rigidbody2D playerRigid;

	private Vector2 lastPlayerVel;

	private Vector2 startOffset;

	private float startRot;

	private int hits;

	private float currentMaxVel;

	public string playerTag = "Bat";

	public UnityAction OnTouchBat;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		if (player != null)
		{
			playerRigid = player.gameObject.GetComponent<Rigidbody2D>();
			if (rigid != null && playerRigid != null)
			{
				startOffset = rigid.position - playerRigid.position;
				startRot = rigid.rotation;
			}
			player.OnShoot += Player_OnShoot;
		}
	}

	private void Player_OnShoot(Vector3 dir)
	{
		if (rigid != null && playerRigid != null)
		{
			Vector2 normalized = (rigid.position - playerRigid.position).normalized;
			CollideWithPlayer(-normalized * startNormalVel, playerRigid.velocity, normalized);
		}
		if (player != null)
		{
			player.OnShoot -= Player_OnShoot;
		}
		OnTouchBat?.Invoke();
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(ShootSounds);
		}
	}

	private void FixedUpdate()
	{
		if (rigid != null)
		{
			lastVel = rigid.velocity;
		}
		if (playerRigid != null)
		{
			lastPlayerVel = playerRigid.velocity;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.rigidbody != null && collision.rigidbody.gameObject.tag == playerTag && collision.contacts != null && collision.contacts.Length != 0)
		{
			hits++;
			CollideWithPlayer(lastVel, lastPlayerVel, collision.contacts[0].normal);
			OnTouchBat?.Invoke();
		}
	}

	private void CollideWithPlayer(Vector2 ballVel, Vector2 playerVel, Vector2 normal)
	{
		if (velocityEvolution != null && maxHits > 0f)
		{
			currentMaxVel = velocityEvolution.Evaluate((float)hits / maxHits) * maxVel;
		}
		else
		{
			currentMaxVel = maxVel;
		}
		float num = Vector2.SignedAngle(-ballVel, normal);
		Vector3 vector = (Quaternion.AngleAxis(num * 2f, Vector3.forward) * -new Vector3(ballVel.x, ballVel.y, 0f)).normalized * currentMaxVel;
		Debug.DrawLine(base.transform.position, base.transform.position - new Vector3(ballVel.x, ballVel.y, 0f).normalized * 5f, Color.black, 5f);
		if (rigid != null)
		{
			Debug.DrawLine(rigid.position, rigid.position + normal.normalized * 5f, Color.white, 5f);
			Debug.DrawLine(rigid.position, rigid.position + new Vector2(vector.x, vector.y).normalized * 5f, Color.red, 5f);
		}
		float x = vector.x;
		float y = vector.y;
		if (velTransferMode == TransferVelocityMode.X || velTransferMode == TransferVelocityMode.XY)
		{
			x += playerVel.x * velTransferMagnitude;
			y = Mathf.Sign(y) * Mathf.Max(Mathf.Abs(y), minPlayAxisVel);
		}
		if (velTransferMode == TransferVelocityMode.Y || velTransferMode == TransferVelocityMode.XY)
		{
			y += playerVel.y * velTransferMagnitude;
			x = Mathf.Sign(x) * Mathf.Max(Mathf.Abs(x), minPlayAxisVel);
		}
		Vector2 vector2 = new Vector2(x, y);
		if (rigid != null)
		{
			Debug.DrawLine(rigid.position, rigid.position + vector2.normalized * 5f, Color.green, 5f);
			rigid.velocity = vector2.normalized * currentMaxVel;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null || !other.gameObject.CompareTag("OutOfBounds"))
		{
			return;
		}
		if (playerRigid != null)
		{
			playerRigid.velocity = Vector2.zero;
		}
		if (rigid != null)
		{
			rigid.velocity = Vector2.zero;
			rigid.angularVelocity = 0f;
			if (playerRigid != null)
			{
				rigid.MovePosition(playerRigid.position + startOffset);
			}
			rigid.MoveRotation(startRot);
		}
		hits = 0;
		if (player != null)
		{
			player.OnShoot += Player_OnShoot;
		}
	}
}
