using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000135")]
	public class UpdateUserAttributesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x28")]
		private List<CodeDeliveryDetailsType> _codeDeliveryDetailsList;

		[Token(Token = "0x1700026E")]
		public List<CodeDeliveryDetailsType> CodeDeliveryDetailsList
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x1168568", Offset = "0x1168568", VA = "0x1168568")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x1168570", Offset = "0x1168570", VA = "0x1168570")]
			set
			{
			}
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x1168578", Offset = "0x1168578", VA = "0x1168578")]
		internal bool IsSetCodeDeliveryDetailsList()
		{
			return default;
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x11685D0", Offset = "0x11685D0", VA = "0x11685D0")]
		public UpdateUserAttributesResponse()
		{
		}
	}
}
