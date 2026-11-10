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

		public GameObject[] LimbGameObjects => limbGameObjects;

		public List<Rigidbody> Rigidbodies => m_rigidbodies;

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

		public JointDrive BalanceJointDrive => InitializeJointDrive(balanceJointDriveSettings);

		public JointDrive UnbalanceJointDrive => InitializeJointDrive(unbalanceJointDriveSettings);

		public bool isInitialized { get; private set; }

		public GameObject GetRoot()
		{
			return Root != null ? Root : gameObject;
		}

		private void Awake()
		{
			if (!isInitialized)
			{
				Initialize();
			}
		}

		public void Initialize()
		{
			if (isInitialized)
			{
				return;
			}
			Joints = new List<ConfigJoint>();
			m_rigidbodies = new List<Rigidbody>();
			RootJoint = AddLimb(Root);
			BodyJoint = AddLimb(Body);
			HeadJoint = AddLimb(Head);
			UpperLeftArmJoint = AddLimb(UpperLeftArm);
			LowerLeftArmJoint = AddLimb(LowerLeftArm);
			LeftHandJoint = AddLimb(LeftHand);
			UpperRightArmJoint = AddLimb(UpperRightArm);
			LowerRightArmJoint = AddLimb(LowerRightArm);
			RightHandJoint = AddLimb(RightHand);
			UpperLeftLegJoint = AddLimb(UpperLeftLeg);
			LowerLeftLegJoint = AddLimb(LowerLeftLeg);
			LeftFootJoint = AddLimb(LeftFoot);
			UpperRightLegJoint = AddLimb(UpperRightLeg);
			LowerRightLegJoint = AddLimb(LowerRightLeg);
			RightFootJoint = AddLimb(RightFoot);

			LeftLeg = new Dictionary<LimbPosition, ConfigJoint>
			{
				{ LimbPosition.Upper, UpperLeftLegJoint },
				{ LimbPosition.Lower, LowerLeftLegJoint },
				{ LimbPosition.HandOrFoot, LeftFootJoint }
			};
			RightLeg = new Dictionary<LimbPosition, ConfigJoint>
			{
				{ LimbPosition.Upper, UpperRightLegJoint },
				{ LimbPosition.Lower, LowerRightLegJoint },
				{ LimbPosition.HandOrFoot, RightFootJoint }
			};
			LeftArm = new Dictionary<LimbPosition, ConfigJoint>
			{
				{ LimbPosition.Upper, UpperLeftArmJoint },
				{ LimbPosition.Lower, LowerLeftArmJoint },
				{ LimbPosition.HandOrFoot, LeftHandJoint }
			};
			RightArm = new Dictionary<LimbPosition, ConfigJoint>
			{
				{ LimbPosition.Upper, UpperRightArmJoint },
				{ LimbPosition.Lower, LowerRightArmJoint },
				{ LimbPosition.HandOrFoot, RightHandJoint }
			};

			List<GameObject> gos = new List<GameObject>();
			for (int i = 0; i < Joints.Count; i++)
			{
				if (Joints[i] != null)
				{
					gos.Add(Joints[i].gameObject);
					if (Joints[i]._rigidbody != null)
					{
						m_rigidbodies.Add(Joints[i]._rigidbody);
					}
				}
			}
			limbGameObjects = gos.ToArray();
			isInitialized = true;
		}

		private ConfigJoint AddLimb(GameObject go)
		{
			if (go == null)
			{
				return null;
			}
			ConfigJoint cj = ConfigJoint.GetOrAdd(go);
			if (cj != null && !Joints.Contains(cj))
			{
				Joints.Add(cj);
			}
			return cj;
		}

		private JointDrive InitializeJointDrive(JointDriveSettings settings)
		{
			return settings.GetJointDrive();
		}

		public Vector3 GetCenterOfMass()
		{
			if (m_rigidbodies == null || m_rigidbodies.Count == 0)
			{
				return transform.position;
			}
			Vector3 sum = Vector3.zero;
			float totalMass = 0f;
			for (int i = 0; i < m_rigidbodies.Count; i++)
			{
				Rigidbody rb = m_rigidbodies[i];
				if (rb != null)
				{
					sum += rb.worldCenterOfMass * rb.mass;
					totalMass += rb.mass;
				}
			}
			return totalMass > 0.001f ? sum / totalMass : transform.position;
		}
	}
}
