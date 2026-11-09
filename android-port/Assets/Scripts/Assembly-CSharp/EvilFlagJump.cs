using System.Collections.Generic;
using System.Linq;
using Audio;
using Core;
using UnityEngine;

public class EvilFlagJump : MonoBehaviour, IFlagMovable
{
	public enum PointSelectionMode
	{
		Farthest = 0,
		Sequence = 1,
		Random = 2
	}

	public List<Transform> Positions;

	public GolfBallController ball;

	public float TravelTime = 0.6f;

	public float Height = 30f;

	public AnimationCurve XZ_Curve;

	public AnimationCurve Y_Curve;

	public PointSelectionMode jumpMode;

	public ClipSettingsCollection jumpStartSFX;

	public float endSFXThreshold = 0.8f;

	public ClipSettingsCollection jumpEndSFX;

	private Rigidbody m_Rigidbody;

	private Transform m_CurrentTarget;

	private Vector3 m_PositionFrom;

	private float m_TravelTimer = 1f;

	private int m_index;

	private bool init;

	private bool playedEndSFX;

	private void Start()
	{
		Init();
	}

	private void Init()
	{
		if (init) return;
		m_Rigidbody = GetComponent<Rigidbody>();
		if (Positions != null && Positions.Count > 0)
		{
			m_CurrentTarget = Positions[0];
			if (m_CurrentTarget != null && m_Rigidbody != null)
				m_Rigidbody.MovePosition(m_CurrentTarget.position);
		}
		init = true;
	}

	public void Move()
	{
		Init();
		if (m_TravelTimer != 0f && m_TravelTimer < TravelTime)
			return;
		if (jumpStartSFX != null)
			jumpStartSFX.Play(null, transform.position, 1f, 1f, 0f);
		playedEndSFX = false;
		SetNextPoint();
		m_TravelTimer = 0f;
		if (m_Rigidbody != null)
			m_PositionFrom = m_Rigidbody.position;
	}

	private void FixedUpdate()
	{
		float t = TravelTime > 0.001f ? (m_TravelTimer / TravelTime) : 1f;
		if (t <= 1f && m_CurrentTarget != null && m_Rigidbody != null)
		{
			Vector3 targetPos = m_CurrentTarget.position;
			float xzT = XZ_Curve != null ? Mathf.Clamp01(XZ_Curve.Evaluate(t)) : Mathf.Clamp01(t);
			float yT = Y_Curve != null ? Y_Curve.Evaluate(t) : Mathf.Sin(t * Mathf.PI);
			float y = Mathf.Lerp(targetPos.y, targetPos.y + Height, yT);
			float x = Mathf.Lerp(m_PositionFrom.x, targetPos.x, xzT);
			float z = Mathf.Lerp(m_PositionFrom.z, targetPos.z, xzT);
			m_Rigidbody.MovePosition(new Vector3(x, y, z));

			if (t > endSFXThreshold && !playedEndSFX)
			{
				playedEndSFX = true;
				if (jumpEndSFX != null)
					jumpEndSFX.Play(null, transform.position, 1f, 1f, 0f);
			}
		}
		m_TravelTimer += Time.fixedDeltaTime;
	}

	private void SetNextPoint()
	{
		if (Positions == null || Positions.Count == 0)
			return;
		if (jumpMode == PointSelectionMode.Farthest && ball != null)
		{
			var ordered = Positions.Where(p => p != null).OrderBy(p => Vector3.Distance(p.position, ball.transform.position)).ToList();
			ordered.Remove(m_CurrentTarget);
			if (ordered.Count > 0)
				m_CurrentTarget = ordered[ordered.Count - 1];
		}
		else if (jumpMode == PointSelectionMode.Sequence)
		{
			m_index = (m_index + 1) % Positions.Count;
			m_CurrentTarget = Positions[m_index];
		}
		else if (jumpMode == PointSelectionMode.Random)
		{
			m_index = Random.Range(0, Positions.Count);
			m_CurrentTarget = Positions[m_index];
		}
	}
}
