using UnityEngine;

namespace Puzzle
{
	public class LazerJoint : MonoBehaviour
	{
		public LineRenderer line;

		public float width = 0.3f;

		public LayerMask layerMask;

		public float length;

		public ParticleSystem particles;

		public bool emit;

		private Vector3 emitDirection;

		private float nextBallhit;

		private Vector3 emitPosition;

		private PuzzleSwitchLaser laserSwitch;

		public SimplePortal enterPortal;

		public SimplePortal exitPortal;

		public void Init(Vector3 startpos, Quaternion rotation, SimplePortal enterPortal = null)
		{
			base.transform.position = startpos;
			base.transform.localRotation = rotation;
			this.enterPortal = enterPortal;
		}

		private void Update()
		{
			if (enterPortal != null)
			{
				base.transform.position = enterPortal.transform.position;
			}
		}

		public void SetJointEmission(bool emit)
		{
			this.emit = emit;
			if (particles != null)
			{
				particles.gameObject.SetActive(emit);
			}
			if (line != null)
			{
				line.enabled = emit;
			}
			if (!emit && laserSwitch != null)
			{
				laserSwitch.SetLaser(null);
				laserSwitch = null;
			}
		}

		private void FixedUpdate()
		{
			if (!emit)
			{
				return;
			}
			if (line != null)
			{
				line.startWidth = width;
				line.endWidth = width;
			}
			if (enterPortal != null)
			{
				emitPosition = base.transform.position + base.transform.up * 0.3f;
			}
			else
			{
				emitPosition = base.transform.position;
			}
			emitDirection = base.transform.up;
			RaycastHit2D hit = Physics2D.CircleCast(emitPosition, width * 0.5f, emitDirection, length, layerMask);
			if (line != null)
			{
				line.SetPosition(0, Vector3.zero);
			}
			if (hit.collider != null)
			{
				if (line != null)
				{
					line.SetPosition(1, base.transform.InverseTransformPoint(hit.centroid));
				}
				if (particles != null)
				{
					particles.gameObject.SetActive(true);
					particles.transform.position = (Vector3)hit.centroid + emitDirection * (width * 0.5f);
				}
				exitPortal = hit.collider.GetComponent<SimplePortal>();
				HandleHit(hit);
			}
			else
			{
				if (line != null)
				{
					line.SetPosition(1, base.transform.InverseTransformPoint(base.transform.position + emitDirection * length));
				}
				if (particles != null)
				{
					particles.gameObject.SetActive(false);
				}
			}
		}

		private void HandleHit(RaycastHit2D hit)
		{
			if (hit.collider == null)
			{
				return;
			}
			PuzzleSwitchLaser component = hit.collider.GetComponent<PuzzleSwitchLaser>();
			if (component != null)
			{
				if (laserSwitch != null && laserSwitch != component)
				{
					laserSwitch.SetLaser(null);
				}
				laserSwitch = component;
				laserSwitch.SetLaser(this);
			}
			else
			{
				if (laserSwitch != null)
				{
					laserSwitch.SetLaser(null);
				}
				laserSwitch = null;
			}
			OverworldBall2D component2 = hit.collider.GetComponent<OverworldBall2D>();
			if (component2 != null && Time.time > nextBallhit)
			{
				Rigidbody2D component3 = component2.GetComponent<Rigidbody2D>();
				if (component3 != null)
				{
					Vector2 normalized = (hit.centroid - component3.position).normalized;
					component3.velocity = normalized * -5f;
					nextBallhit = Time.time + 0.2f;
				}
			}
			else
			{
				PuzzleBall component4 = hit.collider.GetComponent<PuzzleBall>();
				if (component4 != null)
				{
					component4.BallFail();
				}
			}
		}

		private void OnDisable()
		{
			if (laserSwitch != null)
			{
				laserSwitch.SetLaser(null);
			}
		}

		private void OnDestroy()
		{
			if (laserSwitch != null)
			{
				laserSwitch.SetLaser(null);
			}
		}
	}
}
