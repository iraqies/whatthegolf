public class LeaderboardEntry
{
	public string name;

	public bool isPlayer;

	public int score;

	public int position;

	public override string ToString()
	{
		return string.Concat(position.ToString(), ". ", name, " : ", score.ToString(), " isPlayer: ", isPlayer.ToString());
	}
}
