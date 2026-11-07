using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000033")]
	public class IdentityDescription
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _creationDate;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x20")]
		private string _identityId;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _logins;

		[Token(Token = "0x1700005B")]
		public DateTime CreationDate
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x108C618", Offset = "0x108C618", VA = "0x108C618")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x108C658", Offset = "0x108C658", VA = "0x108C658")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x22FF4", Offset = "0x22FF4")]
		public string IdentityId
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x108C70C", Offset = "0x108C70C", VA = "0x108C70C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x108C714", Offset = "0x108C714", VA = "0x108C714")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x108C72C", Offset = "0x108C72C", VA = "0x108C72C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x108C76C", Offset = "0x108C76C", VA = "0x108C76C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public List<string> Logins
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x108C820", Offset = "0x108C820", VA = "0x108C820")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x108C828", Offset = "0x108C828", VA = "0x108C828")]
			set
			{
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x108C6CC", Offset = "0x108C6CC", VA = "0x108C6CC")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x108C71C", Offset = "0x108C71C", VA = "0x108C71C")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x108C7E0", Offset = "0x108C7E0", VA = "0x108C7E0")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x108C830", Offset = "0x108C830", VA = "0x108C830")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x108C888", Offset = "0x108C888", VA = "0x108C888")]
		public IdentityDescription()
		{
		}
	}
}
