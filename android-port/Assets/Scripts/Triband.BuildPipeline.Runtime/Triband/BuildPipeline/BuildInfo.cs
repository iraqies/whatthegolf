using System;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	public class BuildInfo
	{
		[SerializeField]
		private BuildType _buildType;

		[SerializeField]
		private VersionInfo _versionInfo;

		[SerializeField]
		private string _buildConfigAssetName;

		public BuildType buildType => BuildType.Unknown;

		public VersionInfo versionInfo => default;

		public string buildConfigAssetName => null;

		public override string ToString()
		{
			return null;
		}
	}
}
