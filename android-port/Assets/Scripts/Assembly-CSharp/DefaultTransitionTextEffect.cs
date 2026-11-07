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

	[SerializeField]
	private TextMeshPro[] _texts;

	private RectTransform rootTransform;

	private bool isBusy;

	private CanvasScaler canvasScaler;

	private Text[] texts;

	public override bool IsBusy => false;

	private void Awake()
	{
	}

	public override void Initialize()
	{
	}

	public override void Prepare(string text = null, bool onTheSide = false)
	{
	}

	public override IEnumerator Show(float transitionInDuration)
	{
		return null;
	}

	public void HideImmidiate()
	{
	}

	public override IEnumerator Hide(float transitionOutDuration)
	{
		return null;
	}
}
