using System.Collections.Generic;
using Audio;
using UnityEngine;

public class WeightLiftingWinCheck : MonoBehaviour
{
	public float SleepMagnitude;

	public BoxCollider2D WinZone;

	public Collider2D BarCol;

	public List<Collider2D> ResetColliders;

	public List<Transform> WinPoints;

	public ClipSettingsCollection sfxOnWin;

	private Rigidbody2D rigid;

	private Vector3 startPos;

	private Quaternion startRot;

	private float nextGruntSfxTime;

	private void Awake()
	{
	}

	private void OnTriggerStay2D(Collider2D other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void Reset()
	{
	}
}
