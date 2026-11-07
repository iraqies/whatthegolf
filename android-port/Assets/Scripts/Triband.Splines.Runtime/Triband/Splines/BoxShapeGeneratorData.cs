using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class BoxShapeGeneratorData : IShapeGeneratorData
	{
		[SerializeField]
		private Vector2 size;

		[SerializeField]
		private Vector2 offset;

		[SerializeField]
		private Vector2 pivot;
	}
}
