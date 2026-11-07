using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200002F")]
	public class PushSync
	{
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		private List<string> _applicationArns;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		private string _roleArn;

		[Token(Token = "0x17000050")]
		public List<string> ApplicationArns
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x11A43E0", Offset = "0x11A43E0", VA = "0x11A43E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x11A43E8", Offset = "0x11A43E8", VA = "0x11A43E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24B14", Offset = "0x24B14")]
		public string RoleArn
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x11A4448", Offset = "0x11A4448", VA = "0x11A4448")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x11A4450", Offset = "0x11A4450", VA = "0x11A4450")]
			set
			{
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x11A43F0", Offset = "0x11A43F0", VA = "0x11A43F0")]
		internal bool IsSetApplicationArns()
		{
			return default;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x11A4458", Offset = "0x11A4458", VA = "0x11A4458")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x11A4468", Offset = "0x11A4468", VA = "0x11A4468")]
		public PushSync()
		{
		}
	}
}
