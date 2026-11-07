using System.Collections.Generic;
using UnityEngine;

namespace MPuppet
{
	public class MPuppetSetup : MonoBehaviour
	{
		[SerializeField]
		private JointDriveSettings balanceJointDriveSettings;

		[SerializeField]
		private JointDriveSettings unbalanceJointDriveSettings;

		[SerializeField]
		private GameObject Root;

		[SerializeField]
		private GameObject Body;

		[SerializeField]
		private GameObject Head;

		[SerializeField]
		private GameObject UpperLeftArm;

		[SerializeField]
		private GameObject LowerLeftArm;

		[SerializeField]
		private GameObject LeftHand;

		[SerializeField]
		private GameObject UpperRightArm;

		[SerializeField]
		private GameObject LowerRightArm;

		[SerializeField]
		private GameObject RightHand;

		[SerializeField]
		private GameObject UpperLeftLeg;

		[SerializeField]
		private GameObject LowerLeftLeg;

		[SerializeField]
		private GameObject LeftFoot;

		[SerializeField]
		private GameObject UpperRightLeg;

		[SerializeField]
		private GameObject LowerRightLeg;

		[SerializeField]
		private GameObject RightFoot;

		private GameObject[] limbGameObjects;

		private List<Rigidbody> m_rigidbodies;

		public GameObject[] LimbGameObjects => null;

		public List<Rigidbody> Rigidbodies => null;

		public List<ConfigJoint> Joints { get; private set; }

		public ConfigJoint RootJoint { get; private set; }

		public ConfigJoint BodyJoint { get; private set; }

		public ConfigJoint HeadJoint { get; private set; }

		public ConfigJoint UpperLeftArmJoint { get; private set; }

		public ConfigJoint LowerLeftArmJoint { get; private set; }

		public ConfigJoint LeftHandJoint { get; private set; }

		public ConfigJoint UpperRightArmJoint { get; private set; }

		public ConfigJoint LowerRightArmJoint { get; private set; }

		public ConfigJoint RightHandJoint { get; private set; }

		public ConfigJoint UpperLeftLegJoint { get; private set; }

		public ConfigJoint LowerLeftLegJoint { get; private set; }

		public ConfigJoint LeftFootJoint { get; private set; }

		public ConfigJoint UpperRightLegJoint { get; private set; }

		public ConfigJoint LowerRightLegJoint { get; private set; }

		public ConfigJoint RightFootJoint { get; private set; }

		public Dictionary<LimbPosition, ConfigJoint> RightLeg { get; private set; }

		public Dictionary<LimbPosition, ConfigJoint> LeftLeg { get; private set; }

		public Dictionary<LimbPosition, ConfigJoint> RightArm { get; private set; }

		public Dictionary<LimbPosition, ConfigJoint> LeftArm { get; private set; }

		public JointDrive BalanceJointDrive => default;

		public JointDrive UnbalanceJointDrive => default;

		public bool isInitialized { get; private set; }

		public GameObject GetRoot()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private JointDrive InitializeJointDrive(JointDriveSettings settings)
		{
			return default;
		}

		public Vector3 GetCenterOfMass()
		{
			return default;
		}
	}
}
