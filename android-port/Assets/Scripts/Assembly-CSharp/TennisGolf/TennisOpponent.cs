using System.Collections;
using UnityEngine;

namespace TennisGolf
{
	public class TennisOpponent : MonoBehaviour
	{
		private enum StateEnum
		{
			Serving = 0,
			Passing = 1,
			Receiving = 2
		}

		public Rigidbody TennisBall;

		public Transform CenterOfThisSide;

		public Transform CenterOfOtherSide;

		public BoxCollider TennisCourt;

		public float CourtSize = 8f;

		public float ShotAngle = 35f;

		public float BallServeHeight = 3f;

		public float BallVelocityMultiplier = 1f;

		public float MoveSpeed = 8f;

		public float JumpHeight = 1.5f;

		public float JumpDuration = 0.4f;

		private Rigidbody rigidbody;

		private StateEnum currentState;

		private TennisBall ball;

		private float enableCollisionTimer;

		private TennisBall tennisBall;

		private float moveSpeedDecrementer;

		private Transform model;

		public bool firstShootNeutral;

		private void Awake()
		{
			rigidbody = GetComponent<Rigidbody>();
			if (TennisBall != null)
			{
				tennisBall = TennisBall.GetComponent<TennisBall>();
				ball = tennisBall;
				if (tennisBall != null)
				{
					tennisBall.OnPlayerWon += OnGameWon;
				}
			}
			if (transform.childCount > 0)
			{
				model = transform.GetChild(0);
			}
		}

		private void OnGameWon()
		{
			enabled = false;
		}

		private void Start()
		{
			if (currentState == StateEnum.Serving)
			{
				StartCoroutine(DoServe());
			}
		}

		private void Update()
		{
			if (enableCollisionTimer > 0f)
			{
				enableCollisionTimer -= Time.deltaTime;
			}
		}

		private void FixedUpdate()
		{
			if (TennisBall == null || (tennisBall != null && tennisBall.GameOver))
			{
				return;
			}
			Vector3 targetPos = CenterOfThisSide != null ? CenterOfThisSide.position : transform.position;
			if (tennisBall != null && tennisBall.GetLastHitter() != gameObject)
			{
				targetPos = new Vector3(TennisBall.position.x, transform.position.y, TennisBall.position.z);
			}
			targetPos.y = transform.position.y;
			float actualSpeed = Mathf.Max(2f, MoveSpeed - moveSpeedDecrementer);
			Vector3 nextPos = Vector3.MoveTowards(transform.position, targetPos, actualSpeed * Time.fixedDeltaTime);
			if (rigidbody != null && rigidbody.isKinematic)
			{
				rigidbody.MovePosition(nextPos);
			}
			else
			{
				transform.position = nextPos;
			}
		}

		private IEnumerator DoServe()
		{
			yield return new WaitForSeconds(0.75f);
			if (TennisBall != null && CenterOfOtherSide != null && tennisBall != null)
			{
				TennisBall.position = transform.position + Vector3.up * BallServeHeight;
				Vector3 target = CenterOfOtherSide.position + new Vector3(Random.Range(-CourtSize * 0.4f, CourtSize * 0.4f), 0f, Random.Range(-CourtSize * 0.3f, CourtSize * 0.3f));
				TennisBall.velocity = tennisBall.CalculateVelocityForTarget(TennisBall.position, target, ShotAngle) * Mathf.Max(0.5f, BallVelocityMultiplier);
				tennisBall.SetLastHitter(gameObject);
			}
			currentState = StateEnum.Receiving;
		}

		private void OnCollisionEnter(Collision other)
		{
			if (enableCollisionTimer > 0f || other == null || TennisBall == null || other.rigidbody != TennisBall)
			{
				return;
			}
			enableCollisionTimer = 0.25f;
			moveSpeedDecrementer += 0.35f;
			if (tennisBall != null && CenterOfOtherSide != null)
			{
				Vector3 target = CenterOfOtherSide.position;
				if (!firstShootNeutral)
				{
					target += new Vector3(Random.Range(-CourtSize * 0.45f, CourtSize * 0.45f), 0f, Random.Range(-CourtSize * 0.35f, CourtSize * 0.35f));
				}
				firstShootNeutral = false;
				TennisBall.velocity = tennisBall.CalculateVelocityForTarget(TennisBall.position, target, ShotAngle) * Mathf.Max(0.5f, BallVelocityMultiplier);
				tennisBall.SetLastHitter(gameObject);
			}
			if (model != null)
			{
				StartCoroutine(ModelJump());
			}
		}

		private IEnumerator ModelJump()
		{
			if (model == null)
			{
				yield break;
			}
			Vector3 startLocal = model.localPosition;
			float dur = Mathf.Max(0.15f, JumpDuration);
			float t = 0f;
			while (t < dur)
			{
				t += Time.deltaTime;
				float n = Mathf.Clamp01(t / dur);
				model.localPosition = startLocal + Vector3.up * (Mathf.Sin(n * Mathf.PI) * JumpHeight);
				yield return null;
			}
			model.localPosition = startLocal;
		}
	}
}
