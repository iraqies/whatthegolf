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

	public float HideSpeed;

	public float ResetSpeed;

	public float HideDuration;

	public float FlagWaveRange;

	public float FlagWaveSpeed;

	private bool hasSurrendered;

	private Animator animator;

	private int startNumberOfBottles;

	private BartenderStateEnum bartenderState;

	private float animationTimer;

	private Vector3 startPos;

	private void Start()
	{
	}

	private void OnShoot(Vector3 vector3)
	{
	}

	private void Update()
	{
	}
}
