using System.Collections;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class TimedTrailRenderer : MonoBehaviour
	{
		public class Point
		{
			public float timeCreated;

			public Vector3 position;

			public bool lineBreak;
		}

		public bool emit;

		public float emitTime;

		public Material material;

		public float lifeTime;

		public Color[] colors;

		public float[] sizes;

		public float uvLengthScale;

		public bool higherQualityUVs;

		public int movePixelsForRebuild;

		public float maxRebuildTime;

		public float minVertexDistance;

		public float maxVertexDistance;

		public float maxAngle;

		public bool ignoreTimeScale;

		public bool autoDestruct;

		private ArrayList points;

		private GameObject o;

		private Vector3 lastPosition;

		private Vector3 lastCameraPosition1;

		private Vector3 lastCameraPosition2;

		private float lastRebuildTime;

		private bool lastFrameEmit;

		protected virtual void OnStart()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public virtual void ClearPoints()
		{
		}

		public virtual void Init()
		{
		}

		public float GetTime()
		{
			return 0f;
		}

		public float GetDeltaTime()
		{
			return 0f;
		}
	}
}
