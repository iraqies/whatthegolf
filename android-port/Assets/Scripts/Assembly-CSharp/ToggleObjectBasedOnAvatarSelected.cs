using Core;
using UnityEngine;

public class ToggleObjectBasedOnAvatarSelected : MonoBehaviour
{
	public PlayerColors.AvatarIDs AllowedAvatar;

	public void CheckCurrentAvatar(MultiplayerConfiguration.PlayerInfo player)
	{
		if (player != null && player.Avatar != null)
		{
			gameObject.SetActive(AllowedAvatar == player.Avatar.AvatarID);
		}
	}
}
