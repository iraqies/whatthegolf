using System.Collections.Generic;
using Core;
using UnityEngine;

public class Bartender : MonoBehaviour
{
	public enum BartenderStateEnum
	{
		Normal = 0,
		GoingIntoHiding = 1,
		Hiding = 2,
		Resetting = 3
	}

	public GolfBallController Controller;

	public List<BreakableBottle> Bottles;

	public Transform Flag;

	public float HideSpeed = 1f;

	public float ResetSpeed = 1f;

	public float HideDuration = 3f;

	public float FlagWaveRange = 0.3f;

	public float FlagWaveSpeed = 3f;

	private bool hasSurrendered;

	private Animator animator;

	private int startNumberOfBottles;

	private BartenderStateEnum bartenderState;

	private float animationTimer;

	private Vector3 startPos;

	private void Start()
	{
		startPos = base.transform.position;
		animator = GetComponent<Animator>();
		Controller.OnShoot += OnShoot;
		startNumberOfBottles = Bottles.Count;
	}

	private void OnShoot(Vector3 vector3)
	{
		if (bartenderState != BartenderStateEnum.GoingIntoHiding && bartenderState != BartenderStateEnum.Resetting)
		{
			bartenderState = BartenderStateEnum.GoingIntoHiding;
			animationTimer = 0f;
		}
	}

	private void Update()
	{
		int num = 0;
		foreach (BreakableBottle bottle in Bottles)
		{
			if (bottle == null)
			{
				num++;
			}
		}
		if (num == startNumberOfBottles)
		{
			hasSurrendered = true;
		}
		switch (bartenderState)
		{
		case BartenderStateEnum.Normal:
			animator.SetFloat("AnimationSpeed", 0.4f);
			break;
		case BartenderStateEnum.GoingIntoHiding:
			animationTimer += Time.deltaTime * HideSpeed;
			base.transform.position = Vector3.MoveTowards(base.transform.position, new Vector3(startPos.x, -5.87f, startPos.z), animationTimer);
			animator.SetFloat("AnimationSpeed", 2f);
			if (base.transform.position.y <= -5.87f)
			{
				bartenderState = BartenderStateEnum.Hiding;
				animationTimer = 0f;
			}
			break;
		case BartenderStateEnum.Hiding:
			animationTimer += Time.deltaTime;
			animator.SetFloat("AnimationSpeed", 0.6f);
			if (animationTimer >= HideDuration && !hasSurrendered)
			{
				bartenderState = BartenderStateEnum.Resetting;
				animationTimer = 0f;
			}
			break;
		case BartenderStateEnum.Resetting:
			animator.SetFloat("AnimationSpeed", 0.1f);
			animationTimer += Time.deltaTime * ResetSpeed;
			base.transform.position = Vector3.MoveTowards(base.transform.position, new Vector3(startPos.x, startPos.y, startPos.z), animationTimer);
			if (base.transform.position.y >= startPos.y)
			{
				bartenderState = BartenderStateEnum.Normal;
				animationTimer = 0f;
			}
			break;
		}
		if (hasSurrendered)
		{
			float x = Mathf.PingPong(Time.time * FlagWaveSpeed, FlagWaveRange * 2f) - FlagWaveRange;
			Flag.up = Vector3.MoveTowards(Flag.up, new Vector3(x, 1f, 0f), Time.deltaTime * 1.5f);
		}
	}
}
