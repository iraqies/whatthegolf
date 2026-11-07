using Core;
using UnityEngine;

public class EnableFanWhenAiming : MonoBehaviour
{
	public Fan Fan;

	public GolfBallController Controller;

	private Rigidbody rigid;

	private float baseDrag;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnCancel()
	{
	}

	private void Controller_OnAimUpdate(Vector3 v, bool b)
	{
	}
}
