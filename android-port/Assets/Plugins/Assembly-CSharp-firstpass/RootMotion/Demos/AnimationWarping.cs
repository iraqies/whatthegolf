using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		public struct Warp
		{
			public int animationLayer;

			public string animationState;

			public AnimationCurve weightCurve;

			public Transform warpFrom;

			public Transform warpTo;

			public FullBodyBipedEffector effector;
		}

		[Serializable]
		public enum EffectorMode
		{
			PositionOffset = 0,
			Position = 1
		}

		public Animator animator;

		public EffectorMode effectorMode;

		public Warp[] warps;

		private EffectorMode lastMode;

		protected override void Start()
		{
		}

		public float GetWarpWeight(int warpIndex)
		{
			return 0f;
		}

		protected override void OnModifyOffset()
		{
		}

		private void OnDisable()
		{
		}
	}
}
