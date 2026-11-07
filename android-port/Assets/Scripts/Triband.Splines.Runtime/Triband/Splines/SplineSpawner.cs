using System.Collections.Generic;
using UnityEngine;

namespace Triband.Splines
{
	[ExecuteInEditMode]
	public sealed class SplineSpawner : MonoBehaviour
	{
		private enum ObjectSource
		{
			Array = 0,
			StartCap = 1,
			EndCap = 2
		}

		public delegate void OnUpdateDelegate();

		[SerializeField]
		private Spline m_Spline;

		[SerializeField]
		private SplineSpawnerSettings m_Settings;

		[SerializeField]
		private List<GameObject> m_Objects;

		private const string kEditorSettingsKey = "Triband.Splines.SplineSpawnerEditorSettings";

		private const float kMinDistance = 0.1f;

		private bool m_IsDirty;

		private List<(SplineValue, float)> m_EvaluationCache;

		public OnUpdateDelegate onSpawnerUpdated;

		public SplineSpawnerSettings Settings => null;

		public Spline spline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToSplineEvents()
		{
		}

		private void UnsubscribeToSplineEvents()
		{
		}

		public void Reset()
		{
		}

		private void Update()
		{
		}

		public void Evaluate()
		{
		}

		internal void SetDirty()
		{
		}

		internal void OnSplineChanged()
		{
		}

		private void EvaluateSplineCount()
		{
		}

		private void EvaluateSplineLength()
		{
		}

		private void SpawnOrGetObject(SplineValue value, float t, int count, int seed, ObjectSource objectSource)
		{
		}

		private Vector3 GetPosition(SplineValue value, float t, int seed)
		{
			return default;
		}

		private Quaternion GetRotation(SplineValue value, float t, int index, int seed)
		{
			return default;
		}

		private Vector3 GetScale(SplineValue value, float t, int seed)
		{
			return default;
		}

		private float GetStartOffset()
		{
			return 0f;
		}

		private float GetEndOffset()
		{
			return 0f;
		}
	}
}
