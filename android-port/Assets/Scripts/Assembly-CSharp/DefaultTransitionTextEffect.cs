using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DefaultTransitionTextEffect : TransitionTextEffect
{
	private class Text
	{
		public TextMeshPro textMeshPro;
		public Renderer renderer;
		public RectTransform rectTransform;
		public Color initialTextColor;
		public Color initialTextOutlineColor;
	}

	[SerializeField] private TextMeshPro[] _texts;
	private RectTransform rootTransform;
	private bool isBusy;
	private CanvasScaler canvasScaler;
	private Text[] texts;

	public override bool IsBusy => isBusy;

	private void Awake()
	{
	}

	public override void Initialize()
	{
		if (_texts == null) return;
		texts = new Text[_texts.Length];
		for (int i = 0; i < _texts.Length; i++)
		{
			var tmp = _texts[i];
			var item = new Text();
			item.textMeshPro = tmp;
			if (tmp != null)
			{
				item.rectTransform = tmp.rectTransform;
				item.renderer = tmp.renderer;
				item.initialTextColor = tmp.color;
				item.initialTextOutlineColor = tmp.outlineColor;
				if (item.renderer != null)
					item.renderer.enabled = false;
			}
			texts[i] = item;
		}
		rootTransform = transform as RectTransform;
		canvasScaler = GetComponentInParent<CanvasScaler>();
		if (canvasScaler != null && texts != null)
		{
			float refY = canvasScaler.referenceResolution.y;
			float factor = 1.2f;
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i] != null && texts[i].rectTransform != null)
					texts[i].rectTransform.sizeDelta = new Vector2(refY * factor, refY);
			}
		}
	}

	public override void Prepare(string text = null, bool onTheSide = false)
	{
		if (texts == null) Initialize();
		if (texts != null)
		{
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i] != null && texts[i].textMeshPro != null)
					texts[i].textMeshPro.text = text ?? string.Empty;
			}
		}
		if (rootTransform != null)
		{
			rootTransform.localScale = Vector3.zero;
			rootTransform.rotation = Quaternion.Euler(0f, 0f, onTheSide ? -90f : 0f);
		}
	}

	public override IEnumerator Show(float transitionInDuration)
	{
		if (texts == null) Initialize();
		isBusy = true;
		gameObject.SetActive(true);
		if (rootTransform != null)
			rootTransform.localScale = Vector3.one;
		if (texts != null)
		{
			for (int i = 0; i < texts.Length; i++)
			{
				var t = texts[i];
				if (t == null) continue;
				if (t.renderer != null)
					t.renderer.enabled = true;
				if (t.textMeshPro != null)
				{
					t.textMeshPro.color = t.initialTextColor;
					t.textMeshPro.outlineColor = t.initialTextOutlineColor;
				}
			}
		}
		isBusy = false;
		yield return null;
	}

	public void HideImmidiate()
	{
		if (texts == null) Initialize();
		if (texts != null)
		{
			for (int i = 0; i < texts.Length; i++)
			{
				if (texts[i] != null && texts[i].renderer != null)
					texts[i].renderer.enabled = false;
			}
		}
		isBusy = false;
	}

	public override IEnumerator Hide(float transitionOutDuration)
	{
		if (texts == null) Initialize();
		isBusy = true;
		float dur = Mathf.Max(0.05f, transitionOutDuration * 0.5f);
		yield return StartCoroutine(pTween.ToRealTime(dur, t =>
		{
			float alpha = Mathf.Lerp(1f, 0f, t);
			if (texts != null)
			{
				for (int i = 0; i < texts.Length; i++)
				{
					var item = texts[i];
					if (item == null || item.textMeshPro == null) continue;
					Color c = item.initialTextColor;
					c.a = alpha;
					item.textMeshPro.color = c;
					Color oc = item.initialTextOutlineColor;
					oc.a = alpha;
					item.textMeshPro.outlineColor = oc;
				}
			}
			if (rootTransform != null)
				rootTransform.localScale = Vector3.one * Mathf.Lerp(1f, 3f, t);
		}));
		HideImmidiate();
	}
}
