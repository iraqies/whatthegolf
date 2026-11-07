using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000063")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		public class WaypointList
		{
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x135A0B4", Offset = "0x135A0B4", VA = "0x135A0B4")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000065")]
		public struct RoutePoint
		{
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x135A0A4", Offset = "0x135A0A4", VA = "0x135A0A4")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x346F0", Offset = "0x346F0")]
		private float Length__BackingField;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000031")]
		public float Length
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x132C064", Offset = "0x132C064", VA = "0x132C064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37CD0", Offset = "0x37CD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x132C06C", Offset = "0x132C06C", VA = "0x132C06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37CE0", Offset = "0x37CE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x132C074", Offset = "0x132C074", VA = "0x132C074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x132C090", Offset = "0x132C090", VA = "0x132C090")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x132C390", Offset = "0x132C390", VA = "0x132C390")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x132C448", Offset = "0x132C448", VA = "0x132C448")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x132C7A4", Offset = "0x132C7A4", VA = "0x132C7A4")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x132C0EC", Offset = "0x132C0EC", VA = "0x132C0EC")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x132C8DC", Offset = "0x132C8DC", VA = "0x132C8DC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x132CB58", Offset = "0x132CB58", VA = "0x132CB58")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x132C8E4", Offset = "0x132C8E4", VA = "0x132C8E4")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x132CB60", Offset = "0x132CB60", VA = "0x132CB60")]
		public WaypointCircuit()
		{
		}
	}
}
