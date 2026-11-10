using System.Collections.Generic;
using UnityEngine;

public class SetMaterialColorToPlayerColor : MonoBehaviour
{
	public enum ModifyMethods
	{
		Materials = 0,
		SpriteColors = 1,
		ParticleSystem = 2
	}

	public enum ColorType
	{
		BaseColor = 0,
		ArrowColor = 1,
		ArrowColorMin = 2,
		StrokeCounterColor = 3,
		IntroBackgroundColor = 4,
		Custom = 5
	}

	[SerializeField]
	private ParticleSystem particleSystem;

	[SerializeField]
	private Renderer renderer;

	[SerializeField]
	private ModifyMethods ModifyMethod;

	[SerializeField]
	private List<int> materialsIndices;

	[SerializeField]
	private ColorType colorType;

	[SerializeField]
	private Color customColor;

	public void UpdateMaterials(PlayerColors.AvatarData avatar)
	{
		Color c = Color.clear;
		switch (colorType)
		{
			case ColorType.BaseColor:
				if (avatar != null) c = avatar.BaseColor;
				break;
			case ColorType.ArrowColor:
				if (avatar != null) c = avatar.ArrowColor + new Color(0f, 0f, 0f, 1f);
				break;
			case ColorType.ArrowColorMin:
				if (avatar != null) c = avatar.ArrowColorMin;
				break;
			case ColorType.StrokeCounterColor:
				if (avatar != null) c = avatar.StrokeCounterColor;
				break;
			case ColorType.IntroBackgroundColor:
				if (avatar != null) c = avatar.IntroBackgroundColor;
				break;
			case ColorType.Custom:
				c = customColor;
				break;
		}

		if (ModifyMethod == ModifyMethods.Materials)
		{
			if (renderer != null && materialsIndices != null)
			{
				Material[] mats = renderer.materials;
				if (mats != null)
				{
					foreach (int idx in materialsIndices)
					{
						if (idx >= 0 && idx < mats.Length && mats[idx] != null)
							mats[idx].color = c;
					}
					renderer.materials = mats;
				}
			}
		}
		else if (ModifyMethod == ModifyMethods.SpriteColors)
		{
			if (renderer is SpriteRenderer sr)
			{
				sr.color = new Color(c.r, c.g, c.b, 1f);
			}
		}
		else if (ModifyMethod == ModifyMethods.ParticleSystem)
		{
			if (particleSystem != null)
			{
				var pr = particleSystem.GetComponent<Renderer>();
				if (pr != null && pr.material != null)
					pr.material.color = c;
			}
		}
	}

	public ModifyMethods GetModifyMethod() => ModifyMethod;

	public Renderer GetRenderer() => renderer;

	public ColorType GetColorType() => colorType;

	public void SetRenderer(Renderer r) => renderer = r;

	public List<int> GetIndices() => materialsIndices;

	public void CreateList()
	{
		materialsIndices = new List<int>();
	}
}
