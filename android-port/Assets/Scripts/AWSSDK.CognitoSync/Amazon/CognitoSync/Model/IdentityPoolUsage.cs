using System;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000020")]
	public class IdentityPoolUsage
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		private long? _dataStorage;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x20")]
		private string _identityPoolId;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x38")]
		private long? _syncSessionsCount;

		[Token(Token = "0x1700002A")]
		public long DataStorage
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x119CCA4", Offset = "0x119CCA4", VA = "0x119CCA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x119CCE4", Offset = "0x119CCE4", VA = "0x119CCE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x248AC", Offset = "0x248AC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x119CD98", Offset = "0x119CD98", VA = "0x119CD98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x119CDA0", Offset = "0x119CDA0", VA = "0x119CDA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x119CDB8", Offset = "0x119CDB8", VA = "0x119CDB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x119CDF8", Offset = "0x119CDF8", VA = "0x119CDF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public long SyncSessionsCount
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x119CEAC", Offset = "0x119CEAC", VA = "0x119CEAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x119CEEC", Offset = "0x119CEEC", VA = "0x119CEEC")]
			set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x119CD58", Offset = "0x119CD58", VA = "0x119CD58")]
		internal bool IsSetDataStorage()
		{
			return default;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x119CDA8", Offset = "0x119CDA8", VA = "0x119CDA8")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x119CE6C", Offset = "0x119CE6C", VA = "0x119CE6C")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x119CF60", Offset = "0x119CF60", VA = "0x119CF60")]
		internal bool IsSetSyncSessionsCount()
		{
			return default;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x119CFA0", Offset = "0x119CFA0", VA = "0x119CFA0")]
		public IdentityPoolUsage()
		{
		}
	}
}
