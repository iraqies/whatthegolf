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
		HideImmidiate();
	}

	public override void Initialize()
	{
		HideImmidiate();
	}

	public override void Prepare(string text = null, bool onTheSide = false)
	{
		HideImmidiate();
	}

	public override IEnumerator Show(float transitionInDuration)
	{
		yield break;
	}

	public void HideImmidiate()
	{
		isBusy = false;
		if (_texts != null)
		{
			foreach (var t in _texts)
			{
				if (t != null && t.renderer != null)
					t.renderer.enabled = false;
			}
		}
		foreach (var r in GetComponentsInChildren<Renderer>(true))
		{
			if (r != null) r.enabled = false;
		}
		gameObject.SetActive(false);
	}

	public override IEnumerator Hide(float transitionOutDuration)
	{
		HideImmidiate();
		yield break;
	}
}
