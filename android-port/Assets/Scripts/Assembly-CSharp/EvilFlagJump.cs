using System.Collections.Generic;
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

	public float TravelTime;

	public float Height;

	public AnimationCurve XZ_Curve;

	public AnimationCurve Y_Curve;

	public PointSelectionMode jumpMode;

	public ClipSettingsCollection jumpStartSFX;

	public float endSFXThreshold;

	public ClipSettingsCollection jumpEndSFX;

	private Rigidbody m_Rigidbody;

	private Transform m_CurrentTarget;

	private Vector3 m_PositionFrom;

	private float m_TravelTimer;

	private int m_index;

	private bool init;

	private bool playedEndSFX;

	private void Start()
	{
	}

	private void Init()
	{
	}

	public void Move()
	{
	}

	private void FixedUpdate()
	{
	}

	private void SetNextPoint()
	{
	}
}
