using System.Collections;
using UnityEngine;

public class InsideObserver : MonoBehaviour
{
	public Transform Target;

	public Rigidbody MainRigid;

	public Rigidbody Head;

	public Vector3 LookAtOffset;

	public float MoveForce;

	public float MoveHeadForce;

	public Light SearchLight;

	public Color AlertedColor;

	public Color NormalColor;

	public Transform StopFollowPoint;

	public AudioClip ObserverEnabled;

	public AudioClip LightTurnOn;

	private Vector3 offset;

	private new bool enabled;

	public bool IsAlerted { get; private set; }

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetAlertedState()
	{
	}

	public void SetNormalState()
	{
	}

	public IEnumerator StartSequence()
	{
		return null;
	}
}
