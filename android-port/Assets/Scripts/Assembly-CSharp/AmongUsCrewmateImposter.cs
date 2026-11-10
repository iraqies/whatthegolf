using Audio;
using UnityEngine;
using UnityEngine.Events;

public class AmongUsCrewmateImposter : MonoBehaviour
{
	public GameObject HatItem;

	public ClipSettingsCollection gruntClipCollection;

	public ClipSettingsCollection impactClipCollection;

	private Transform position;

	public UnityEvent OnHit;

	private Animator animator;

	private bool isHit;

	private void Start()
	{
		if (position == null)
		{
			position = base.transform;
		}
		animator = GetComponentInChildren<Animator>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		if (other.gameObject.tag == "Knife" && !isHit)
		{
			OnHit?.Invoke();
			if (animator != null)
			{
				animator.enabled = false;
			}
			UnKinematicAllRigids component = GetComponent<UnKinematicAllRigids>();
			if (component != null)
			{
				component.MakeUnkinematic();
			}
			AddForce component2 = GetComponent<AddForce>();
			if (component2 != null)
			{
				component2.Execute();
			}
			if (HatItem != null)
			{
				Unparent componentInChildren = HatItem.GetComponentInChildren<Unparent>();
				if (componentInChildren != null)
				{
					componentInChildren.UnparentObject();
				}
				Rigidbody componentInChildren2 = HatItem.GetComponentInChildren<Rigidbody>();
				if (componentInChildren2 != null)
				{
					componentInChildren2.isKinematic = false;
				}
			}
			Play();
			isHit = true;
		}
		if (other.gameObject.tag == "Ball" && !isHit)
		{
			OnHit?.Invoke();
			if (HatItem != null)
			{
				Unparent componentInChildren3 = HatItem.GetComponentInChildren<Unparent>();
				if (componentInChildren3 != null)
				{
					componentInChildren3.UnparentObject();
				}
				Rigidbody componentInChildren4 = HatItem.GetComponentInChildren<Rigidbody>();
				if (componentInChildren4 != null)
				{
					componentInChildren4.isKinematic = false;
				}
			}
			Play();
			isHit = true;
		}
	}

	private void DefaultSetPos()
	{
		if (position == null)
		{
			position = base.transform;
		}
	}

	private void Play()
	{
		if (position == null)
		{
			position = base.transform;
		}
		if (gruntClipCollection != null)
		{
			gruntClipCollection.Play(position.position);
		}
		if (impactClipCollection != null)
		{
			impactClipCollection.Play(position.position);
		}
	}
}
