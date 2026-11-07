using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	public class RotateAroundAxis : MonoBehaviour
	{
		public enum Speed
		{
			Stopped = 0,
			Slow = 1,
			Fast = 2
		}

		public enum RotationAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		[SerializeField]
		private Speed _speed;

		[SerializeField]
		private float _slowRotationSpeed;

		[SerializeField]
		private float _fastRotationSpeed;

		[SerializeField]
		private RotationAxis _rotateAroundAxis;

		[SerializeField]
		private Space _relativeTo;

		[SerializeField]
		private bool _reverse;

		public Speed speed
		{
			get
			{
				return Speed.Stopped;
			}
			set
			{
			}
		}

		public float slowRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fastRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RotationAxis rotateAroundAxis
		{
			get
			{
				return RotationAxis.X;
			}
			set
			{
			}
		}

		public Space relativeTo
		{
			get
			{
				return Space.World;
			}
			set
			{
			}
		}

		public bool reverse
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Update()
		{
		}

		private static Vector3 UBTdCMgMmDUkfQSXMUxOcULfkPYFA(RotationAxis P_0)
		{
			return default;
		}

		public void SetSpeed(Speed speed)
		{
		}

		public void SetSpeed(int speed)
		{
		}
	}
}
