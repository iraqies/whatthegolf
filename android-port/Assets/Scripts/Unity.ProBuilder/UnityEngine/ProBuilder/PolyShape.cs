using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.ProBuilder
{
	[DisallowMultipleComponent]
	internal sealed class PolyShape : MonoBehaviour
	{
		public enum PolyEditMode
		{
			None = 0,
			Path = 1,
			Height = 2,
			Edit = 3
		}

		private ProBuilderMesh m_Mesh;

		[SerializeField]
		internal List<Vector3> m_Points;

		[SerializeField]
		private float m_Extrude;

		[SerializeField]
		private PolyEditMode m_EditMode;

		[SerializeField]
		private bool m_FlipNormals;

		[SerializeField]
		internal bool isOnGrid;

		public ReadOnlyCollection<Vector3> controlPoints => null;

		public float extrude
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public PolyEditMode polyEditMode
		{
			get
			{
				return PolyEditMode.None;
			}
			set
			{
			}
		}

		public bool flipNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ProBuilderMesh mesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SetControlPoints(IList<Vector3> points)
		{
		}

		private bool IsSnapEnabled()
		{
			return false;
		}
	}
}
