using System;
using System.Collections.Generic;
using UnityEngine;

namespace Triband.Splines
{
	[ExecuteInEditMode]
	public class SplineMesh : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		public struct UVSettings
		{
			public UVMode horizontalUVMode;

			public UVMode verticalUVMode;
		}

		public enum UVMode
		{
			WorldSpace = 0,
			Normalized = 1
		}

		[Serializable]
		private class SerializableShapeGeneratorData
		{
			[SerializeField]
			private string assemblyQualifiedTypeName;

			[SerializeField]
			private string json;

			public string AssemblyQualifiedTypeName => null;

			public string Json => null;

			public SerializableShapeGeneratorData(string assemblyQualifiedTypeName, string json)
			{
			}
		}

		[SerializeField]
		private Spline spline;

		[SerializeField]
		private bool drawGizmos;

		[SerializeField]
		private float ringsPerUnit;

		[SerializeField]
		private float startOffset;

		[SerializeField]
		private float startOffsetFraction;

		[SerializeField]
		private StartOffsetMode startOffsetMode;

		[SerializeField]
		public float endOffset;

		[SerializeField]
		private float endOffsetFraction;

		[SerializeField]
		private StartOffsetMode endOffsetMode;

		[SerializeField]
		private UVSettings uvSettings;

		[SerializeField]
		private List<SerializableShapeGeneratorData> serializedData;

		[SerializeField]
		private string selectedShapeGeneratorTypeName;

		[SerializeReference]
		private IShapeGeneratorData selectedShapeGeneratorData;

		private ShapeGenerator shapeGenerator;

		private Dictionary<Type, IShapeGeneratorData> dataByGeneratorType;

		private Mesh generatedMesh;

		private List<Vector3> vertexBuffer;

		private List<Vector3> normalBuffer;

		private List<Vector2> uvBuffer;

		private List<Vertex> vertices;

		public Spline _spline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		internal void Generate()
		{
		}

		private float GetStartOffset()
		{
			return 0f;
		}

		private float GetEndOffset()
		{
			return 0f;
		}

		private void GenerateEndCaps(List<Vertex> vertices, List<int> triangles)
		{
		}

		private Vertex GetVertexForSplineValue(SplineValue value, Vertex2D pointVertex)
		{
			return default;
		}

		private void UpdateMesh(Mesh mesh, List<Vertex> vertices, List<int> triangles)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void DrawGizmoLines()
		{
		}

		private void DrawGizmoVertices()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void DeserializeGeneratorData()
		{
		}

		private void RestoreSelectedShapeGenerator()
		{
		}
	}
}
