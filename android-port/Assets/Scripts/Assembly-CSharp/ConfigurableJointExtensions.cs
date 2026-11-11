using UnityEngine;

public static class ConfigurableJointExtensions
{
	public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation)
	{
		if (joint.configuredInWorldSpace)
		{
			Debug.LogError("SetTargetRotationLocal should not be used with joints that are configured in world space. For world space joints, use SetTargetRotation.", joint);
		}
		SetTargetRotationInternal(joint, targetLocalRotation, startLocalRotation, Space.Self);
	}

	public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation)
	{
		if (!joint.configuredInWorldSpace)
		{
			Debug.LogError("SetTargetRotation must be used with joints that are configured in world space. For local space joints, use SetTargetRotationLocal.", joint);
		}
		SetTargetRotationInternal(joint, targetWorldRotation, startWorldRotation, Space.World);
	}

	private static void SetTargetRotationInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Space space)
	{
		Vector3 axis = joint.axis;
		Vector3 normalized = Vector3.Cross(joint.axis, joint.secondaryAxis).normalized;
		Vector3 normalized2 = Vector3.Cross(normalized, axis).normalized;
		Quaternion quaternion = Quaternion.LookRotation(normalized, normalized2);
		Quaternion result = Quaternion.Inverse(quaternion);
		if (space == Space.World)
		{
			result *= startRotation * Quaternion.Inverse(targetRotation);
		}
		else
		{
			result *= Quaternion.Inverse(targetRotation) * startRotation;
		}
		result *= quaternion;
		joint.targetRotation = result;
	}
}
