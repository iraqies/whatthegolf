namespace ThirdParty.BouncyCastle.Utilities.IO.Pem
{
	public interface PemObjectParser
	{
		object ParseObject(PemObject obj);
	}
}
