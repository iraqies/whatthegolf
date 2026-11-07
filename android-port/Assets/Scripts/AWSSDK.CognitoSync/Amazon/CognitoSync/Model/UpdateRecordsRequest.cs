using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200003F")]
	public class UpdateRecordsRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x30")]
		private string _clientContext;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x38")]
		private string _datasetName;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x40")]
		private string _deviceId;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x48")]
		private string _identityId;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x50")]
		private string _identityPoolId;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x58")]
		private List<RecordPatch> _recordPatches;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x60")]
		private string _syncSessionToken;

		[Token(Token = "0x17000072")]
		public string ClientContext
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x11ACC4C", Offset = "0x11ACC4C", VA = "0x11ACC4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x11ACC54", Offset = "0x11ACC54", VA = "0x11ACC54")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x251C4", Offset = "0x251C4")]
		public string DatasetName
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x11ACC6C", Offset = "0x11ACC6C", VA = "0x11ACC6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x11ACC74", Offset = "0x11ACC74", VA = "0x11ACC74")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x25214", Offset = "0x25214")]
		public string DeviceId
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x11ACC8C", Offset = "0x11ACC8C", VA = "0x11ACC8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x11ACC94", Offset = "0x11ACC94", VA = "0x11ACC94")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2525C", Offset = "0x2525C")]
		public string IdentityId
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x11ACCAC", Offset = "0x11ACCAC", VA = "0x11ACCAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x11ACCB4", Offset = "0x11ACCB4", VA = "0x11ACCB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x252AC", Offset = "0x252AC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x11ACCCC", Offset = "0x11ACCCC", VA = "0x11ACCCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x11ACCD4", Offset = "0x11ACCD4", VA = "0x11ACCD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public List<RecordPatch> RecordPatches
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x11ACCEC", Offset = "0x11ACCEC", VA = "0x11ACCEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x11ACCF4", Offset = "0x11ACCF4", VA = "0x11ACCF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x252FC", Offset = "0x252FC")]
		public string SyncSessionToken
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x11ACD54", Offset = "0x11ACD54", VA = "0x11ACD54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x11ACD5C", Offset = "0x11ACD5C", VA = "0x11ACD5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x11ACC5C", Offset = "0x11ACC5C", VA = "0x11ACC5C")]
		internal bool IsSetClientContext()
		{
			return default;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x11ACC7C", Offset = "0x11ACC7C", VA = "0x11ACC7C")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x11ACC9C", Offset = "0x11ACC9C", VA = "0x11ACC9C")]
		internal bool IsSetDeviceId()
		{
			return default;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x11ACCBC", Offset = "0x11ACCBC", VA = "0x11ACCBC")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x11ACCDC", Offset = "0x11ACCDC", VA = "0x11ACCDC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x11ACCFC", Offset = "0x11ACCFC", VA = "0x11ACCFC")]
		internal bool IsSetRecordPatches()
		{
			return default;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x11ACD64", Offset = "0x11ACD64", VA = "0x11ACD64")]
		internal bool IsSetSyncSessionToken()
		{
			return default;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x11ACD74", Offset = "0x11ACD74", VA = "0x11ACD74")]
		public UpdateRecordsRequest()
		{
		}
	}
}
