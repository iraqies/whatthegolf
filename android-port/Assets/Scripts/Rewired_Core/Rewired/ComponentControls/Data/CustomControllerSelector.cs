using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	public sealed class CustomControllerSelector
	{
		[SerializeField]
		private bool _findUsingSourceId;

		[SerializeField]
		private int _sourceId;

		[SerializeField]
		private bool _findUsingTag;

		[SerializeField]
		private string _tag;

		[SerializeField]
		private bool _findInPlayer;

		[SerializeField]
		private int _playerId;

		public bool findUsingSourceId => false;

		public int sourceId => 0;

		public bool findUsingTag => false;

		public string tag => null;

		public bool findInPlayer => false;

		public int playerId => 0;

		internal Rewired.CustomController GetCustomController()
		{
			return null;
		}
	}
}
