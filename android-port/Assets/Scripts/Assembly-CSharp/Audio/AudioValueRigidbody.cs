using UnityEngine;

namespace Audio
{
	public class AudioValueRigidbody : BaseAudioValue
	{
		public enum RigidbodyValueListenType
		{
			VELOCITY_MAGNITUDE = 0,
			VELOCITY_X = 1,
			VELOCITY_Y = 2,
			VELOCITY_Z = 3,
			VELOCITY_XY_MAGNITUDE = 4,
			VELOCITY_XZ_MAGNITUDE = 5,
			ANGULAR_VELOCITY = 6,
			ANGULAR_VELOCITY_X = 7,
			ANGULAR_VELOCITY_Y = 8,
			ANGULAR_VELOCITY_Z = 9
		}

		public Rigidbody component3D;

		public Rigidbody2D component2D;

		public RigidbodyValueListenType listenType;

		protected override bool Use2D => component3D == null;

		private void Update()
		{
			if (component3D == null && component2D == null)
				return;
			SetValue();
		}

		public override string ValueInputName()
		{
			string prefix = "";
			if (component2D != null && component2D.gameObject != null)
				prefix += component2D.gameObject.name;
			else if (component3D != null && component3D.gameObject != null)
				prefix += component3D.gameObject.name;
			return string.Format("{0} {1}", prefix, listenType.ToString().ToLower());
		}

		protected override void SetValue()
		{
			switch (listenType)
			{
			case RigidbodyValueListenType.VELOCITY_MAGNITUDE:
				if (Use2D)
				{
					if (component2D != null)
						value = component2D.velocity.magnitude;
				}
				else if (component3D != null)
				{
					value = component3D.velocity.magnitude;
				}
				break;
			case RigidbodyValueListenType.VELOCITY_X:
				if (Use2D)
				{
					if (component2D != null)
						value = component2D.velocity.x;
				}
				else if (component3D != null)
				{
					value = component3D.velocity.x;
				}
				break;
			case RigidbodyValueListenType.VELOCITY_Y:
				if (Use2D)
				{
					if (component2D != null)
						value = component2D.velocity.y;
				}
				else if (component3D != null)
				{
					value = component3D.velocity.y;
				}
				break;
			case RigidbodyValueListenType.VELOCITY_Z:
				if (Use2D)
				{
					value = 0f;
				}
				else if (component3D != null)
				{
					value = component3D.velocity.z;
				}
				break;
			case RigidbodyValueListenType.VELOCITY_XY_MAGNITUDE:
				if (Use2D)
				{
					if (component2D != null)
						value = component2D.velocity.magnitude;
				}
				else if (component3D != null)
				{
					Vector3 v = component3D.velocity;
					value = new Vector2(v.x, v.y).magnitude;
				}
				break;
			case RigidbodyValueListenType.VELOCITY_XZ_MAGNITUDE:
				if (Use2D)
				{
					if (component2D != null)
						value = new Vector2(component2D.velocity.x, 0f).magnitude;
				}
				else if (component3D != null)
				{
					Vector3 v = component3D.velocity;
					value = new Vector2(v.x, v.z).magnitude;
				}
				break;
			case RigidbodyValueListenType.ANGULAR_VELOCITY:
				if (Use2D)
				{
					if (component2D != null)
						value = component2D.angularVelocity;
				}
				else if (component3D != null)
				{
					value = component3D.angularVelocity.magnitude;
				}
				break;
			case RigidbodyValueListenType.ANGULAR_VELOCITY_X:
				if (!Use2D && component3D != null)
					value = component3D.transform.InverseTransformDirection(component3D.angularVelocity).x;
				break;
			case RigidbodyValueListenType.ANGULAR_VELOCITY_Y:
				if (!Use2D && component3D != null)
					value = component3D.transform.InverseTransformDirection(component3D.angularVelocity).y;
				break;
			case RigidbodyValueListenType.ANGULAR_VELOCITY_Z:
				if (!Use2D && component3D != null)
					value = component3D.transform.InverseTransformDirection(component3D.angularVelocity).z;
				break;
			}
			base.SetValue();
		}
	}
}
