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

	private void Start()
	{
		Controller.OnAimUpdate += OnAimUpdate;
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
