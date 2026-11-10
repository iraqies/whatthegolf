using System.Collections.Generic;
using UnityEngine;

public class OverworldDoorPlateManualOverride : GolfBehaviour
{
	public List<GameObject> stateSmoke;

	public List<GameObject> stateSmoke2;

	public List<GameObject> stateExploded;

	public List<GameObject> stateNormal;

	public ParticleSystem explosionParticles;

	public GameObject stateStartExploded;

	public Explosion2D explosion;

	[SerializeField]
	private OverworldMainDoorPlate plate;

	private float activeTime;

	private float cooldown = 0.1f;

	private float nextHitTime;

	private int hits;

	private Vector3 basePos;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Rigidbody2D rigid;

	[SerializeField]
	private PolygonCollider2D col;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		plate = GetComponent<OverworldMainDoorPlate>();
		animator = GetComponent<Animator>();
		rigid = GetComponent<Rigidbody2D>();
		col = GetComponent<PolygonCollider2D>();
	}

	private void Update()
	{
		if (hits == 1)
		{
			base.transform.position = new Vector3(basePos.x + Random.Range(-1f, 1f) * 0.02f, basePos.y, basePos.z);
		}
		if (hits == 2)
		{
			base.transform.position = new Vector3(basePos.x + Random.Range(-1f, 1f) * 0.05f, basePos.y + Random.Range(-1f, 1f) * 0.02f, basePos.z);
		}
	}

	private void Awake()
	{
		basePos = base.transform.position;
		SetStateNormal();
		if (plate == null)
		{
			return;
		}
		if (plate.isInitialized)
		{
			if (plate.isOn)
			{
				SetStateExploded(true);
				if (stateStartExploded != null)
				{
					stateStartExploded.SetActive(true);
				}
			}
		}
		else
		{
			plate.OnInit += Plate_OnInit;
		}
	}

	private void Plate_OnInit()
	{
		if (plate != null)
		{
			plate.OnInit -= Plate_OnInit;
			if (plate.isOn)
			{
				SetStateExploded(true);
				if (stateStartExploded != null)
				{
					stateStartExploded.SetActive(true);
				}
			}
		}
	}

	private void Init()
	{
		if (plate != null && plate.isOn)
		{
			SetStateExploded(true);
			if (stateStartExploded != null)
			{
				stateStartExploded.SetActive(true);
			}
		}
	}

	private void SetStateNormal()
	{
		if (animator != null)
		{
			animator.SetBool("Smoke", false);
			animator.speed = 1f;
		}
		stateSmoke?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateSmoke2?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateExploded?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateNormal?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(true);
			}
		});
		if (col != null)
		{
			col.enabled = true;
		}
	}

	private void SetStateSmoke()
	{
		if (animator != null)
		{
			animator.SetBool("Smoke", true);
			animator.speed = 1f;
		}
		stateSmoke2?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateSmoke?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(true);
			}
		});
		stateExploded?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateNormal?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
	}

	private void SetStateSmoke2()
	{
		if (animator != null)
		{
			animator.speed = 10f;
		}
		stateSmoke2?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(true);
			}
		});
		stateSmoke?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(true);
			}
		});
		stateExploded?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateNormal?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
	}

	private void SetStateExploded(bool fromLoad = false)
	{
		if (animator != null)
		{
			animator.speed = 1f;
		}
		stateSmoke?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateSmoke2?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		stateExploded?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(true);
			}
		});
		stateNormal?.ForEach(delegate(GameObject go)
		{
			if (go != null)
			{
				go.SetActive(false);
			}
		});
		if (fromLoad)
		{
			if (explosionParticles != null)
			{
				explosionParticles.gameObject.SetActive(false);
			}
		}
		else
		{
			if (explosionParticles != null)
			{
				explosionParticles.Play();
			}
			if (explosion != null)
			{
				explosion.Explode(1f);
			}
		}
		if (col != null)
		{
			col.enabled = false;
		}
		if (plate != null)
		{
			plate.SetState(true, false);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.collider != null && collision.collider.attachedRigidbody != null)
		{
			OverworldBall2D component = collision.collider.attachedRigidbody.GetComponent<OverworldBall2D>();
			if (component != null && Time.time > nextHitTime)
			{
				HitOverride(component);
			}
		}
	}

	private void HitOverride(OverworldBall2D ball)
	{
		if (ball == null)
		{
			return;
		}
		if (ball.rigidBody != null)
		{
			ball.rigidBody.velocity = Vector2.zero;
			Vector3 normalized = (base.transform.position - ball.transform.position).normalized;
			ball.rigidBody.AddForce(new Vector2(normalized.x * -21f, normalized.y * -21f), ForceMode2D.Impulse);
		}
		nextHitTime = Time.time + 0.15f;
		int num = hits;
		hits = num + 1;
		if (num == 0)
		{
			SetStateSmoke();
		}
		if (hits == 2)
		{
			SetStateSmoke2();
		}
		if (hits == 3)
		{
			SetStateExploded(false);
		}
	}
}
