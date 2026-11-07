using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChangeGravityOnAim : MonoBehaviour
{
	public GolfBallController Controller;

	public float GravityStrength;

	public Transform InnerWhiteArrow;

	public float WhiteArrowMoveSpeed;

	public AudioSource OnSource;

	public List<GameObject> Balls;

	private float moveTimer;

	private void Start()
	{
	}

	private void OnAimUpdate(Vector3 dir, bool b)
	{
	}

	private void Update()
	{
	}
}
