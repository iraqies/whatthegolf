using System;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class RequiredNest1
	{
		public Transform trans1;

		public RequiredNest2 nest2;
	}
}
