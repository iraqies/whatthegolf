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
	}

	public ModifyMethods GetModifyMethod()
	{
		return ModifyMethods.Materials;
	}

	public Renderer GetRenderer()
	{
		return null;
	}

	public ColorType GetColorType()
	{
		return ColorType.BaseColor;
	}

	public void SetRenderer(Renderer r)
	{
	}

	public List<int> GetIndices()
	{
		return null;
	}

	public void CreateList()
	{
	}
}
