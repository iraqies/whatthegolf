using System;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	public struct VersionInfo
	{
		[SerializeField]
		private string _bundleVersion;

		[SerializeField]
		private string _buildNumber;

		[SerializeField]
		private int _buildNumberInteger;

		[SerializeField]
		private string _branchName;

		[SerializeField]
		private string _commit;

		public override string ToString() => $"{_bundleVersion} ({_buildNumber})";
	}
}
