using System;

namespace UnityEngine.U2D.IK
{
	[Serializable]
	public class IKChain2D
	{
		[SerializeField]
		private Transform m_EffectorTransform;

		[SerializeField]
		private Transform m_TargetTransform;

		[SerializeField]
		private int m_TransformCount;

		[SerializeField]
		private Transform[] m_Transforms;

		[SerializeField]
		private Quaternion[] m_DefaultLocalRotations;

		[SerializeField]
		private Quaternion[] m_StoredLocalRotations;

		protected float[] m_Lengths;

		public Transform effector => null;

		public Transform target => null;

		public Transform[] transforms => null;

		public Transform rootTransform => null;

		private Transform lastTransform => null;

		public int transformCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isValid => false;

		public float[] lengths => null;

		private bool Validate()
		{
			return false;
		}

		public void Initialize()
		{
		}

		private void PrepareLengths()
		{
		}

		public void RestoreDefaultPose(bool targetRotationIsConstrained)
		{
		}

		public void StoreLocalRotations()
		{
		}

		public void BlendFkToIk(float finalWeight, bool targetRotationIsConstrained)
		{
		}
	}
}
