using System;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TouchController : CustomController
	{
		[SerializeField]
		private bool _disableMouseInputWhenEnabled;

		[SerializeField]
		private bool _useCustomController;

		[NonSerialized]
		private bool ZONfyvTwmuSbXEYCxPhYKNWDJIaE;

		public bool disableMouseInputWhenEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useCustomController
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private TouchController()
		{
		}

		internal override void OnDisable()
		{
		}

		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal override bool GetUseCustomController()
		{
			return false;
		}

		internal override void SetUseCustomController(bool value)
		{
		}

		private void gbiGPNIAJVqgQnKFyeBCIIExwkrYA(bool P_0)
		{
		}

		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		private bool ajhXJbgnqLHNDTtpxLqCuAgGrnVb()
		{
			return false;
		}
	}
}
