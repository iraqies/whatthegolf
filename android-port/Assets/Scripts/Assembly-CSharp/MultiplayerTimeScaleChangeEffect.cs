using System.Collections;
using Chronos;
using Core;
using UnityEngine;

public class MultiplayerTimeScaleChangeEffect : MonoBehaviour
{
	public Vector2 AlphaRange;

	public float ChangeSpeed;

	public float FovChange;

	public float OrthoSizeChange;

	public Clock Clock;

	public GolfBallController Controller;

	private float target;

	private CameraFilterPack_Color_Sepia sepia;

	private Camera camera;

	private bool initialized;

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}
}
