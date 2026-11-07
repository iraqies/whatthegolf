using UnityEngine;

namespace Triband.Splines
{
	internal sealed class SplineSpawnerEditorSettings : ScriptableObject
	{
		[SerializeField]
		private bool m_AutomaticUpdate;

		internal bool automaticUpdate => false;
	}
}
