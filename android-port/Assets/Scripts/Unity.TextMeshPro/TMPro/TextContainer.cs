using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	public class TextContainer : UIBehaviour
	{
		private bool m_hasChanged;

		[SerializeField]
		private Vector2 m_pivot;

		[SerializeField]
		private TextContainerAnchors m_anchorPosition;

		[SerializeField]
		private Rect m_rect;

		private bool m_isDefaultWidth;

		private bool m_isDefaultHeight;

		private bool m_isAutoFitting;

		private Vector3[] m_corners;

		private Vector3[] m_worldCorners;

		[SerializeField]
		private Vector4 m_margins;

		private RectTransform m_rectTransform;

		private static Vector2 k_defaultSize;

		private TextMeshPro m_textMeshPro;

		public bool hasChanged
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 pivot
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public TextContainerAnchors anchorPosition
		{
			get
			{
				return TextContainerAnchors.TopLeft;
			}
			set
			{
			}
		}

		public Rect rect
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 size
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isDefaultWidth => false;

		public bool isDefaultHeight => false;

		public bool isAutoFitting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3[] corners => null;

		public Vector3[] worldCorners => null;

		public Vector4 margins
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public RectTransform rectTransform => null;

		public TextMeshPro textMeshPro => null;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnContainerChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void SetRect(Vector2 size)
		{
		}

		private void UpdateCorners()
		{
		}

		private Vector2 GetPivot(TextContainerAnchors anchor)
		{
			return default;
		}

		private TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			return TextContainerAnchors.TopLeft;
		}
	}
}
