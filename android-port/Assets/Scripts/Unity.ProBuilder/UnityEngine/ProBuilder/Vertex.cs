using System;
using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public sealed class Vertex : IEquatable<Vertex>
	{
		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private Vector3 m_Normal;

		[SerializeField]
		private Vector4 m_Tangent;

		[SerializeField]
		private Vector2 m_UV0;

		[SerializeField]
		private Vector2 m_UV2;

		[SerializeField]
		private Vector4 m_UV3;

		[SerializeField]
		private Vector4 m_UV4;

		[SerializeField]
		private MeshArrays m_Attributes;

		public Vector3 position
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Color color
		{
			set
			{
			}
		}

		public Vector3 normal
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector4 tangent
		{
			set
			{
			}
		}

		public Vector2 uv0
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 uv2
		{
			set
			{
			}
		}

		public Vector4 uv3
		{
			set
			{
			}
		}

		public Vector4 uv4
		{
			set
			{
			}
		}

		private bool hasPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasColor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasNormal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasTangent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasUV0
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasUV2
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasUV3
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool hasUV4
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HasArrays(MeshArrays attribute)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Vertex other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(Vertex a, Vertex b)
		{
			return false;
		}

		public static bool operator !=(Vertex a, Vertex b)
		{
			return !(a == b);
		}

		public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
			position = null;
			color = null;
			uv0 = null;
			normal = null;
			tangent = null;
			uv2 = null;
			uv3 = null;
			uv4 = null;
		}

		public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, MeshArrays attributes)
		{
			position = null;
			color = null;
			uv0 = null;
			normal = null;
			tangent = null;
			uv2 = null;
			uv3 = null;
			uv4 = null;
		}
	}
}
