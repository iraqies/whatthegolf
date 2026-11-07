using UnityEngine;

public class Antenna : MonoBehaviour
{
	public Renderer rend;

	public Transform target;

	public Transform golfBall;

	public string materialName;

	public string propertyName;

	public float maxDist;

	public float winDist;

	public GolfGoal goal;

	public AnimationCurve distanceToNoiseCurve;

	public Rigidbody[] antennaParts;

	private Material screenMaterial;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
