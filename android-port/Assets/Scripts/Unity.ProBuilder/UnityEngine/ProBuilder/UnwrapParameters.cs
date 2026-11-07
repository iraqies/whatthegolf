using System;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public sealed class UnwrapParameters
	{
		internal const float k_HardAngle = 88f;

		internal const float k_PackMargin = 20f;

		internal const float k_AngleError = 8f;

		internal const float k_AreaError = 15f;

		[SerializeField]
		private float m_HardAngle;

		[SerializeField]
		private float m_PackMargin;

		[SerializeField]
		private float m_AngleError;

		[SerializeField]
		private float m_AreaError;

		public float hardAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float packMargin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angleError
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float areaError
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public UnwrapParameters()
		{
		}

		public UnwrapParameters(UnwrapParameters other)
		{
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
