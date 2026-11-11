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
		rigid = GetComponent<Rigidbody>();
		if (rigid != null)
		{
			baseDrag = rigid.drag;
		}
		Controller.OnAimUpdate += Controller_OnAimUpdate;
		Controller.OnShoot += delegate
		{
			OnCancel();
		};
		Controller.OnCancel += OnCancel;
	}

	private void Start()
	{
		Fan.Toggle(false);
	}

	private void OnCancel()
	{
		Fan.Toggle(false);
		if (rigid != null)
		{
			rigid.drag = baseDrag;
		}
	}

	private void Controller_OnAimUpdate(Vector3 v, bool b)
	{
		if (!b)
		{
			if (rigid != null)
			{
				rigid.drag = 10f;
			}
			if (v.magnitude > Controller.CancelThreshold * 1.2f)
			{
				Fan.Toggle(true);
			}
		}
	}
}
