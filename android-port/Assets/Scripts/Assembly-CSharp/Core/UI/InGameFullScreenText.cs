using System.Collections;
using TMPro;
using UnityEngine;

namespace Core.UI
{
	public class InGameFullScreenText : MonoBehaviour
	{
		private struct Text
		{
			public TextMeshPro textMeshPro;

			public Renderer renderer;

			public RectTransform rectTransform;

			public Color initialTextColor;

			public Color initialTextOutlineColor;
		}

		[SerializeField]
		private TextMeshPro[] _texts;

		private Text[] texts;

		private Coroutine _autoHide;

		public void Init()
		{
		}

		public void Prepare(string text = null)
		{
		}

		public void Show(float showDuration = 0f)
		{
		}

		public void HideInstantly()
		{
		}

		private IEnumerator Hide(float delay)
		{
			return null;
		}
	}
}
