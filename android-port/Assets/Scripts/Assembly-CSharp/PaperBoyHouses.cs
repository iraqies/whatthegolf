using UnityEngine;

public class PaperBoyHouses : MonoBehaviour
{
	private PaperBoyHouse[] houses;

	private bool[] papersDelivered;

	public Animator FlagController;

	private void Awake()
	{
		houses = GetComponentsInChildren<PaperBoyHouse>();
		if (houses != null)
		{
			papersDelivered = new bool[houses.Length];
		}
	}

	public void DeliverMail(PaperBoyHouse house)
	{
		if (houses == null || papersDelivered == null)
		{
			return;
		}
		for (int i = 0; i < houses.Length; i++)
		{
			if (houses[i] == house && !papersDelivered[i])
			{
				papersDelivered[i] = true;
				houses[i].PlayEffects();
			}
		}
		for (int i = 0; i < papersDelivered.Length; i++)
		{
			if (!papersDelivered[i])
			{
				return;
			}
		}
		if (FlagController != null)
		{
			FlagController.SetTrigger("Raise");
		}
	}
}
