using UnityEngine;

public class AmongUsBoulderChangeDirection : MonoBehaviour
{
	public float leftForce;

	public float rightForce;

	public float downForce;

	public float leftTorque;

	public float rightTorque;

	private ConstantForce boulderConstantForce;

	private AmongUsBoulderPlatformType platformType;

	private void Start()
	{
		boulderConstantForce = GetComponent<ConstantForce>();
	}

	public void GoLeft()
	{
		if (boulderConstantForce != null)
		{
			boulderConstantForce.force = new Vector3(0f, 0f, leftForce);
			boulderConstantForce.torque = new Vector3(leftTorque, 0f, 0f);
		}
	}

	public void GoRight()
	{
		if (boulderConstantForce != null)
		{
			boulderConstantForce.force = new Vector3(0f, 0f, rightForce);
			boulderConstantForce.torque = new Vector3(rightTorque, 0f, 0f);
		}
	}

	public void GoDown()
	{
		if (boulderConstantForce != null)
		{
			boulderConstantForce.force = new Vector3(0f, downForce, 0f);
			boulderConstantForce.torque = Vector3.zero;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null || other.gameObject.GetComponentInChildren<AmongUsBoulderPlatformType>() == null)
		{
			return;
		}
		platformType = other.gameObject.GetComponentInChildren<AmongUsBoulderPlatformType>();
		if (platformType != null && boulderConstantForce != null)
		{
			if (platformType.platformDirection == AmongUsBoulderPlatformType.PlatformDirection.Left)
			{
				boulderConstantForce.force = new Vector3(0f, 0f, leftForce);
				boulderConstantForce.torque = new Vector3(leftTorque, 0f, 0f);
			}
			if (platformType.platformDirection == AmongUsBoulderPlatformType.PlatformDirection.Right)
			{
				boulderConstantForce.force = new Vector3(0f, 0f, rightForce);
				boulderConstantForce.torque = new Vector3(rightTorque, 0f, 0f);
			}
			if (platformType.platformDirection == AmongUsBoulderPlatformType.PlatformDirection.Down)
			{
				boulderConstantForce.force = new Vector3(0f, downForce, 0f);
				boulderConstantForce.torque = Vector3.zero;
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null || collision.gameObject.GetComponentInChildren<AmongUsBoulderPlatformType>() == null)
		{
			return;
		}
		platformType = collision.gameObject.GetComponentInChildren<AmongUsBoulderPlatformType>();
		if (platformType != null && boulderConstantForce != null)
		{
			if (platformType.platformDirection == AmongUsBoulderPlatformType.PlatformDirection.Left)
			{
				boulderConstantForce.force = new Vector3(0f, 0f, leftForce);
				boulderConstantForce.torque = new Vector3(leftTorque, 0f, 0f);
			}
			if (platformType.platformDirection == AmongUsBoulderPlatformType.PlatformDirection.Right)
			{
				boulderConstantForce.force = new Vector3(0f, 0f, rightForce);
				boulderConstantForce.torque = new Vector3(rightTorque, 0f, 0f);
			}
		}
	}

	public AmongUsBoulderChangeDirection()
	{
		leftForce = -20f;
		rightForce = 20f;
		downForce = -100f;
		leftTorque = -100f;
		rightTorque = 100f;
	}
}
