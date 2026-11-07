using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class KatamariBallSnake : MonoBehaviour
{
	public float CurrentSize;

	public float BallCompression;

	public float GrowthMod;

	public float ElevationMod;

	public float MinCameraElevation;

	public float ElevationChangeSpeed;

	public float RequiredSizeToWin;

	public float MinShotSpeed;

	public float ForceMod;

	public Vector2 ArrowScaleRange;

	public bool IncreaseMass;

	public bool DestroyCollider;

	public GameObject SphereCollider;

	public PlayAudioClipSetting audioClipSetting;

	public Material snakeMaterial;

	public List<Transform> points;

	public AnimationCurve swallowedObjectMovement;

	public float MoveSpeed;

	public float targetScale;

	public float timeToLerp;

	private GameObject currentObjectToMove;

	[SerializeField]
	private ClipSettingsCollection absorbClip;

	private CBFollow followCam;

	private float targetElevation;

	private float currentElevation;

	private ConstantForce force;

	private GolfBallShooterExperimental shooter;

	private GolfBallController controller;

	private Rigidbody rigidbody;

	private void Awake()
	{
	}

	private void Controller_OnReset()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void Update()
	{
	}

	private IEnumerator MoveObjectInSnake(GameObject otherObject)
	{
		return null;
	}
}
