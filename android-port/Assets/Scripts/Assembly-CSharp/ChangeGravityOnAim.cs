using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChangeGravityOnAim : MonoBehaviour
{
	public GolfBallController Controller;

	public float GravityStrength;

	public Transform InnerWhiteArrow;

	public float WhiteArrowMoveSpeed = 10f;

	public AudioSource OnSource;

	public List<GameObject> Balls;

	private float moveTimer;

	private Vector3 origGravity3D;
	private Vector2 origGravity2D;

	private void Start()
	{
		origGravity3D = Physics.gravity;
		origGravity2D = Physics2D.gravity;
		if (Controller != null)
			Controller.OnAimUpdate += OnAimUpdate;
	}

	private void OnDestroy()
	{
		Physics.gravity = origGravity3D.sqrMagnitude > 0.01f ? origGravity3D : new Vector3(0f, -50f, 0f);
		Physics2D.gravity = origGravity2D.sqrMagnitude > 0.01f ? origGravity2D : new Vector2(0f, -50f);
	}

	private void OnAimUpdate(Vector3 dir, bool b)
	{
		if (!b && !Controller.BlockShooting)
		{
			Physics.gravity = dir * GravityStrength;
			Physics2D.gravity = dir * GravityStrength;
		}
	}

	private void Update()
	{
		if (Controller.IsAiming)
		{
			InnerWhiteArrow.gameObject.SetActive(true);
			moveTimer = (moveTimer + Time.deltaTime * WhiteArrowMoveSpeed) % 1f;
			InnerWhiteArrow.transform.localPosition = Vector3.Lerp(new Vector3(-0.5f, 0f, 0f), new Vector3(0.5f, 0f, 0f), moveTimer);
			if (!OnSource.isPlaying)
			{
				OnSource.Play();
			}
		}
		else
		{
			InnerWhiteArrow.gameObject.SetActive(false);
			moveTimer = 0f;
			if (OnSource.isPlaying)
			{
				OnSource.Stop();
			}
		}
		bool flag = true;
		for (int i = 0; i < Balls.Count; i++)
		{
			flag = !(Balls[i] != null) && flag;
		}
		if (flag)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}
}
