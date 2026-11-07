using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseSpringAction : MonoBehaviour
{
	public SpringJoint2D joint;
	public UnityEvent OnFullPull = new UnityEvent();
	public float InvokeThreshold = 1.5f;
	public List<AudioClip> ReleaseSounds = new List<AudioClip>();
	private float origDistance;
	private float delay;
	private bool isDragging;

	private void Awake()
	{
		if (joint == null) joint = GetComponent<SpringJoint2D>();
		if (joint != null) origDistance = joint.distance;
	}

	private void OnEnable()
	{
		delay = 0.25f;
	}

	private void FixedUpdate()
	{
		if (delay > 0f)
		{
			delay -= Time.fixedDeltaTime;
			return;
		}
		bool held = (Input.touchCount > 0) || Input.GetMouseButton(0);
		if (held && Camera.main != null)
		{
			Vector2 screenPos = Input.touchCount > 0 ? Input.GetTouch(0).position : (Vector2)Input.mousePosition;
			Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
			if (joint != null)
			{
				joint.connectedAnchor = worldPos;
				float pullDist = Vector2.Distance(transform.position, worldPos);
				if (pullDist >= Mathf.Max(0.5f, InvokeThreshold))
				{
					OnFullPull?.Invoke();
					delay = 0.5f;
				}
			}
			else
			{
				OnFullPull?.Invoke();
				delay = 0.5f;
			}
		}
	}
}
