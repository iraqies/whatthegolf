using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	internal struct CursorData
	{
		public readonly Vector3 position;

		public readonly Vector3 delta;

		public readonly Vector3 positionWS;

		public readonly Vector3 deltaWS;

		public CursorData(Vector3 position, Vector3 delta, Vector3 positionWS, Vector3 deltaWS)
		{
			this.position = default;
			this.delta = default;
			this.positionWS = default;
			this.deltaWS = default;
		}
	}
}
