using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	public sealed class SplineSpawner : MonoBehaviour
	{
		[Token(Token = "0x200001B")]
		private enum ObjectSource
		{
			[Token(Token = "0x4000066")]
			Array = 0,
			[Token(Token = "0x4000067")]
			StartCap = 1,
			[Token(Token = "0x4000068")]
			EndCap = 2
		}

		[Token(Token = "0x200001C")]
		public delegate void OnUpdateDelegate();

		[Serializable]
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B009C", Offset = "0x1B009C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Transform, GameObject> _003C_003E9__15_0;

			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Transform, GameObject> _003C_003E9__21_0;

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2A0D3DC", Offset = "0x2A0D3DC", VA = "0x2A0D3DC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2A0D3E4", Offset = "0x2A0D3E4", VA = "0x2A0D3E4")]
			internal GameObject _003COnEnable_003Eb__15_0(Transform t)
			{
				return null;
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2A0D400", Offset = "0x2A0D400", VA = "0x2A0D400")]
			internal GameObject _003CEvaluate_003Eb__21_0(Transform t)
			{
				return null;
			}
		}

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Spline m_Spline;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SplineSpawnerSettings m_Settings;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> m_Objects;

		[Token(Token = "0x4000060")]
		private const string kEditorSettingsKey = "Triband.Splines.SplineSpawnerEditorSettings";

		[Token(Token = "0x4000061")]
		private const float kMinDistance = 0.1f;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsDirty;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x38")]
		private List<(SplineValue, float)> m_EvaluationCache;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x40")]
		public OnUpdateDelegate onSpawnerUpdated;

		[Token(Token = "0x17000030")]
		public SplineSpawnerSettings Settings
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2A0AC18", Offset = "0x2A0AC18", VA = "0x2A0AC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public Spline spline
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2A0AC20", Offset = "0x2A0AC20", VA = "0x2A0AC20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2A0AC28", Offset = "0x2A0AC28", VA = "0x2A0AC28")]
			set
			{
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2A0AC30", Offset = "0x2A0AC30", VA = "0x2A0AC30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2A0B114", Offset = "0x2A0B114", VA = "0x2A0B114")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2A0AE80", Offset = "0x2A0AE80", VA = "0x2A0AE80")]
		private void SubscribeToSplineEvents()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2A0B1A4", Offset = "0x2A0B1A4", VA = "0x2A0B1A4")]
		private void UnsubscribeToSplineEvents()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2A0B354", Offset = "0x2A0B354", VA = "0x2A0B354")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2A0B610", Offset = "0x2A0B610", VA = "0x2A0B610")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2A0B650", Offset = "0x2A0B650", VA = "0x2A0B650")]
		public void Evaluate()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2A0B108", Offset = "0x2A0B108", VA = "0x2A0B108")]
		internal void SetDirty()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2A0C4E4", Offset = "0x2A0C4E4", VA = "0x2A0C4E4")]
		internal void OnSplineChanged()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2A0BCA8", Offset = "0x2A0BCA8", VA = "0x2A0BCA8")]
		private void EvaluateSplineCount()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2A0BECC", Offset = "0x2A0BECC", VA = "0x2A0BECC")]
		private void EvaluateSplineLength()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2A0C690", Offset = "0x2A0C690", VA = "0x2A0C690")]
		private void SpawnOrGetObject(SplineValue value, float t, int count, int seed, ObjectSource objectSource)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2A0CAAC", Offset = "0x2A0CAAC", VA = "0x2A0CAAC")]
		private Vector3 GetPosition(SplineValue value, float t, int seed)
		{
			return default;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2A0CCA8", Offset = "0x2A0CCA8", VA = "0x2A0CCA8")]
		private Quaternion GetRotation(SplineValue value, float t, int index, int seed)
		{
			return default;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2A0D010", Offset = "0x2A0D010", VA = "0x2A0D010")]
		private Vector3 GetScale(SplineValue value, float t, int seed)
		{
			return default;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2A0C4E8", Offset = "0x2A0C4E8", VA = "0x2A0C4E8")]
		private float GetStartOffset()
		{
			return default;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2A0C5BC", Offset = "0x2A0C5BC", VA = "0x2A0C5BC")]
		private float GetEndOffset()
		{
			return default;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2A0D10C", Offset = "0x2A0D10C", VA = "0x2A0D10C")]
		public SplineSpawner()
		{
		}
	}
}
