using System.Collections;
using UnityEngine;

public class InsideObserver : MonoBehaviour
{
	public Transform Target;

	public Rigidbody MainRigid;

	public Rigidbody Head;

	public Vector3 LookAtOffset;

	public float MoveForce = 10f;

	public float MoveHeadForce = 5f;

	public Light SearchLight;

	public Color AlertedColor = Color.red;

	public Color NormalColor = Color.white;

	public Transform StopFollowPoint;

	public AudioClip ObserverEnabled;

	public AudioClip LightTurnOn;

	private Vector3 offset;

	private new bool enabled;

	public bool IsAlerted { get; private set; }

	private void Start()
	{
		if (Target != null && MainRigid != null)
		{
			offset = MainRigid.position - Target.position;
		}
	}

	private void FixedUpdate()
	{
		if (!enabled || MainRigid == null || Target == null)
		{
			return;
		}
		if (StopFollowPoint == null || MainRigid.position.x < StopFollowPoint.position.x)
		{
			Vector3 targetPos = Target.position + offset;
			Vector3 diff = targetPos - MainRigid.position;
			float mag = Mathf.Clamp(diff.magnitude, 0f, 5f);
			MainRigid.AddForce(diff.normalized * (mag * MoveForce));
		}
		if (Head != null)
		{
			Vector3 lookDir = (Target.position + LookAtOffset - Head.transform.position).normalized;
			if (lookDir.sqrMagnitude > 0.0001f)
			{
				Head.transform.up = -lookDir;
			}
		}
	}

	public void SetAlertedState()
	{
		if (SearchLight != null)
		{
			SearchLight.color = AlertedColor;
		}
		IsAlerted = true;
	}

	public void SetNormalState()
	{
		if (SearchLight != null)
		{
			SearchLight.color = NormalColor;
		}
		IsAlerted = false;
	}

	public IEnumerator StartSequence()
	{
		if (ObserverEnabled != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(ObserverEnabled);
		}
		enabled = true;
		yield return new WaitForSeconds(0.5f);
		if (LightTurnOn != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(LightTurnOn);
		}
		if (SearchLight != null)
		{
			SearchLight.enabled = true;
		}
	}
}
