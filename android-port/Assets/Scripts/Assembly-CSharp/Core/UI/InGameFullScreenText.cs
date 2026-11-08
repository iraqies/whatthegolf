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

		private void Awake()
		{
			Init();
		}

		public void Init()
		{
			if (_texts == null || _texts.Length == 0)
				_texts = GetComponentsInChildren<TextMeshPro>(true);
			if (_texts == null) return;
			texts = new Text[_texts.Length];
			for (int i = 0; i < _texts.Length; i++)
			{
				TextMeshPro tmp = _texts[i];
				if (tmp == null) continue;
				Renderer r = tmp.renderer != null ? tmp.renderer : tmp.GetComponent<Renderer>();
				texts[i] = new Text
				{
					textMeshPro = tmp,
					renderer = r,
					rectTransform = tmp.rectTransform,
					initialTextColor = tmp.color,
					initialTextOutlineColor = tmp.outlineColor
				};
				if (r != null)
					r.enabled = false;
			}
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i].renderer != null)
					texts[i].renderer.enabled = false;
			}
		}

		public void Prepare(string text = null)
		{
			if (texts == null) Init();
			if (texts == null) return;
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i].textMeshPro != null)
					texts[i].textMeshPro.text = text ?? string.Empty;
			}
		}

		public void Show(float showDuration = 0f)
		{
			if (texts == null) Init();
			if (texts == null) return;
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i].renderer != null)
					texts[i].renderer.enabled = true;
				if (texts[i].textMeshPro != null)
				{
					texts[i].textMeshPro.color = texts[i].initialTextColor;
					texts[i].textMeshPro.outlineColor = texts[i].initialTextOutlineColor;
				}
			}
			if (showDuration > 0f)
			{
				if (_autoHide != null)
					StopCoroutine(_autoHide);
				if (gameObject.activeInHierarchy)
					_autoHide = StartCoroutine(Hide(showDuration));
			}
		}

		public void HideInstantly()
		{
			if (texts == null) Init();
			if (texts == null) return;
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i].renderer != null)
					texts[i].renderer.enabled = false;
			}
		}

		private IEnumerator Hide(float delay)
		{
			yield return new WaitForSecondsRealtime(delay);
			HideInstantly();
		}
	}
}
