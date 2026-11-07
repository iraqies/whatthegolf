using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HingeJointMotorEnabler : MonoBehaviour
{
	public List<ShootingGalleryTarget> Targets;

	public UnityEvent AllHitEvent;

	private HingeJointMotorTarget joint;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
