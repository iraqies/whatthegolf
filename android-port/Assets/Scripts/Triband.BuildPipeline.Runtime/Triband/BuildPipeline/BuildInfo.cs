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

		public BuildType buildType => _buildType;

		public VersionInfo versionInfo => _versionInfo;

		public string buildConfigAssetName => _buildConfigAssetName;

		public override string ToString() => $"{_buildConfigAssetName} ({_buildType}) {_versionInfo}";
	}
}
