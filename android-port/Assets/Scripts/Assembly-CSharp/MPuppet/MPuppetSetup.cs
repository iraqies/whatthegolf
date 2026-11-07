using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MPuppet
{
	[Token(Token = "0x20011DD")]
	public class MPuppetSetup : MonoBehaviour
	{
		[Token(Token = "0x4005FD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private JointDriveSettings balanceJointDriveSettings;

		[Token(Token = "0x4005FD7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private JointDriveSettings unbalanceJointDriveSettings;

		[Token(Token = "0x4005FD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject Root;

		[Token(Token = "0x4005FD9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject Body;

		[Token(Token = "0x4005FDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject Head;

		[Token(Token = "0x4005FDB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject UpperLeftArm;

		[Token(Token = "0x4005FDC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject LowerLeftArm;

		[Token(Token = "0x4005FDD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject LeftHand;

		[Token(Token = "0x4005FDE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject UpperRightArm;

		[Token(Token = "0x4005FDF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject LowerRightArm;

		[Token(Token = "0x4005FE0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject RightHand;

		[Token(Token = "0x4005FE1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject UpperLeftLeg;

		[Token(Token = "0x4005FE2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject LowerLeftLeg;

		[Token(Token = "0x4005FE3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject LeftFoot;

		[Token(Token = "0x4005FE4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject UpperRightLeg;

		[Token(Token = "0x4005FE5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject LowerRightLeg;

		[Token(Token = "0x4005FE6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject RightFoot;

		[Token(Token = "0x4005FE7")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject[] limbGameObjects;

		[Token(Token = "0x4005FE8")]
		[FieldOffset(Offset = "0xB0")]
		private List<Rigidbody> m_rigidbodies;

		[Token(Token = "0x4005FE9")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5767C", Offset = "0x5767C")]
		private List<ConfigJoint> Joints__BackingField;

		[Token(Token = "0x4005FEA")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5768C", Offset = "0x5768C")]
		private ConfigJoint RootJoint__BackingField;

		[Token(Token = "0x4005FEB")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5769C", Offset = "0x5769C")]
		private ConfigJoint BodyJoint__BackingField;

		[Token(Token = "0x4005FEC")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x576AC", Offset = "0x576AC")]
		private ConfigJoint HeadJoint__BackingField;

		[Token(Token = "0x4005FED")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x576BC", Offset = "0x576BC")]
		private ConfigJoint UpperLeftArmJoint__BackingField;

		[Token(Token = "0x4005FEE")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x576CC", Offset = "0x576CC")]
		private ConfigJoint LowerLeftArmJoint__BackingField;

		[Token(Token = "0x4005FEF")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x576DC", Offset = "0x576DC")]
		private ConfigJoint LeftHandJoint__BackingField;

		[Token(Token = "0x4005FF0")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x576EC", Offset = "0x576EC")]
		private ConfigJoint UpperRightArmJoint__BackingField;

		[Token(Token = "0x4005FF1")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x576FC", Offset = "0x576FC")]
		private ConfigJoint LowerRightArmJoint__BackingField;

		[Token(Token = "0x4005FF2")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5770C", Offset = "0x5770C")]
		private ConfigJoint RightHandJoint__BackingField;

		[Token(Token = "0x4005FF3")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5771C", Offset = "0x5771C")]
		private ConfigJoint UpperLeftLegJoint__BackingField;

		[Token(Token = "0x4005FF4")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5772C", Offset = "0x5772C")]
		private ConfigJoint LowerLeftLegJoint__BackingField;

		[Token(Token = "0x4005FF5")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5773C", Offset = "0x5773C")]
		private ConfigJoint LeftFootJoint__BackingField;

		[Token(Token = "0x4005FF6")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5774C", Offset = "0x5774C")]
		private ConfigJoint UpperRightLegJoint__BackingField;

		[Token(Token = "0x4005FF7")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5775C", Offset = "0x5775C")]
		private ConfigJoint LowerRightLegJoint__BackingField;

		[Token(Token = "0x4005FF8")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5776C", Offset = "0x5776C")]
		private ConfigJoint RightFootJoint__BackingField;

		[Token(Token = "0x4005FF9")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5777C", Offset = "0x5777C")]
		private Dictionary<LimbPosition, ConfigJoint> RightLeg__BackingField;

		[Token(Token = "0x4005FFA")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5778C", Offset = "0x5778C")]
		private Dictionary<LimbPosition, ConfigJoint> LeftLeg__BackingField;

		[Token(Token = "0x4005FFB")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5779C", Offset = "0x5779C")]
		private Dictionary<LimbPosition, ConfigJoint> RightArm__BackingField;

		[Token(Token = "0x4005FFC")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x577AC", Offset = "0x577AC")]
		private Dictionary<LimbPosition, ConfigJoint> LeftArm__BackingField;

		[Token(Token = "0x4005FFD")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x577BC", Offset = "0x577BC")]
		private bool isInitialized__BackingField;

		[Token(Token = "0x170008C1")]
		public GameObject[] LimbGameObjects
		{
			[Token(Token = "0x6005193")]
			[Address(RVA = "0x1551350", Offset = "0x1551350", VA = "0x1551350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C2")]
		public List<Rigidbody> Rigidbodies
		{
			[Token(Token = "0x6005194")]
			[Address(RVA = "0x15500E0", Offset = "0x15500E0", VA = "0x15500E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C3")]
		public List<ConfigJoint> Joints
		{
			[Token(Token = "0x6005195")]
			[Address(RVA = "0x155166C", Offset = "0x155166C", VA = "0x155166C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70378", Offset = "0x70378")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005196")]
			[Address(RVA = "0x1551674", Offset = "0x1551674", VA = "0x1551674")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70388", Offset = "0x70388")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C4")]
		public ConfigJoint RootJoint
		{
			[Token(Token = "0x6005197")]
			[Address(RVA = "0x155167C", Offset = "0x155167C", VA = "0x155167C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70398", Offset = "0x70398")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005198")]
			[Address(RVA = "0x1551684", Offset = "0x1551684", VA = "0x1551684")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x703A8", Offset = "0x703A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C5")]
		public ConfigJoint BodyJoint
		{
			[Token(Token = "0x6005199")]
			[Address(RVA = "0x155168C", Offset = "0x155168C", VA = "0x155168C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x703B8", Offset = "0x703B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600519A")]
			[Address(RVA = "0x1551694", Offset = "0x1551694", VA = "0x1551694")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x703C8", Offset = "0x703C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C6")]
		public ConfigJoint HeadJoint
		{
			[Token(Token = "0x600519B")]
			[Address(RVA = "0x155169C", Offset = "0x155169C", VA = "0x155169C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x703D8", Offset = "0x703D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600519C")]
			[Address(RVA = "0x15516A4", Offset = "0x15516A4", VA = "0x15516A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x703E8", Offset = "0x703E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C7")]
		public ConfigJoint UpperLeftArmJoint
		{
			[Token(Token = "0x600519D")]
			[Address(RVA = "0x15516AC", Offset = "0x15516AC", VA = "0x15516AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x703F8", Offset = "0x703F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600519E")]
			[Address(RVA = "0x15516B4", Offset = "0x15516B4", VA = "0x15516B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70408", Offset = "0x70408")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C8")]
		public ConfigJoint LowerLeftArmJoint
		{
			[Token(Token = "0x600519F")]
			[Address(RVA = "0x15516BC", Offset = "0x15516BC", VA = "0x15516BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70418", Offset = "0x70418")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051A0")]
			[Address(RVA = "0x15516C4", Offset = "0x15516C4", VA = "0x15516C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70428", Offset = "0x70428")]
			private set
			{
			}
		}

		[Token(Token = "0x170008C9")]
		public ConfigJoint LeftHandJoint
		{
			[Token(Token = "0x60051A1")]
			[Address(RVA = "0x15516CC", Offset = "0x15516CC", VA = "0x15516CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70438", Offset = "0x70438")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051A2")]
			[Address(RVA = "0x15516D4", Offset = "0x15516D4", VA = "0x15516D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70448", Offset = "0x70448")]
			private set
			{
			}
		}

		[Token(Token = "0x170008CA")]
		public ConfigJoint UpperRightArmJoint
		{
			[Token(Token = "0x60051A3")]
			[Address(RVA = "0x15516DC", Offset = "0x15516DC", VA = "0x15516DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70458", Offset = "0x70458")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051A4")]
			[Address(RVA = "0x15516E4", Offset = "0x15516E4", VA = "0x15516E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70468", Offset = "0x70468")]
			private set
			{
			}
		}

		[Token(Token = "0x170008CB")]
		public ConfigJoint LowerRightArmJoint
		{
			[Token(Token = "0x60051A5")]
			[Address(RVA = "0x15516EC", Offset = "0x15516EC", VA = "0x15516EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70478", Offset = "0x70478")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051A6")]
			[Address(RVA = "0x15516F4", Offset = "0x15516F4", VA = "0x15516F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70488", Offset = "0x70488")]
			private set
			{
			}
		}

		[Token(Token = "0x170008CC")]
		public ConfigJoint RightHandJoint
		{
			[Token(Token = "0x60051A7")]
			[Address(RVA = "0x15516FC", Offset = "0x15516FC", VA = "0x15516FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70498", Offset = "0x70498")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051A8")]
			[Address(RVA = "0x1551704", Offset = "0x1551704", VA = "0x1551704")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x704A8", Offset = "0x704A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008CD")]
		public ConfigJoint UpperLeftLegJoint
		{
			[Token(Token = "0x60051A9")]
			[Address(RVA = "0x155170C", Offset = "0x155170C", VA = "0x155170C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x704B8", Offset = "0x704B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051AA")]
			[Address(RVA = "0x1551714", Offset = "0x1551714", VA = "0x1551714")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x704C8", Offset = "0x704C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008CE")]
		public ConfigJoint LowerLeftLegJoint
		{
			[Token(Token = "0x60051AB")]
			[Address(RVA = "0x155171C", Offset = "0x155171C", VA = "0x155171C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x704D8", Offset = "0x704D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051AC")]
			[Address(RVA = "0x1551724", Offset = "0x1551724", VA = "0x1551724")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x704E8", Offset = "0x704E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008CF")]
		public ConfigJoint LeftFootJoint
		{
			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x155172C", Offset = "0x155172C", VA = "0x155172C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x704F8", Offset = "0x704F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051AE")]
			[Address(RVA = "0x1551734", Offset = "0x1551734", VA = "0x1551734")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70508", Offset = "0x70508")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D0")]
		public ConfigJoint UpperRightLegJoint
		{
			[Token(Token = "0x60051AF")]
			[Address(RVA = "0x155173C", Offset = "0x155173C", VA = "0x155173C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70518", Offset = "0x70518")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B0")]
			[Address(RVA = "0x1551744", Offset = "0x1551744", VA = "0x1551744")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70528", Offset = "0x70528")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D1")]
		public ConfigJoint LowerRightLegJoint
		{
			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x155174C", Offset = "0x155174C", VA = "0x155174C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70538", Offset = "0x70538")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B2")]
			[Address(RVA = "0x1551754", Offset = "0x1551754", VA = "0x1551754")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70548", Offset = "0x70548")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D2")]
		public ConfigJoint RightFootJoint
		{
			[Token(Token = "0x60051B3")]
			[Address(RVA = "0x155175C", Offset = "0x155175C", VA = "0x155175C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70558", Offset = "0x70558")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B4")]
			[Address(RVA = "0x1551764", Offset = "0x1551764", VA = "0x1551764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70568", Offset = "0x70568")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D3")]
		public Dictionary<LimbPosition, ConfigJoint> RightLeg
		{
			[Token(Token = "0x60051B5")]
			[Address(RVA = "0x155176C", Offset = "0x155176C", VA = "0x155176C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70578", Offset = "0x70578")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B6")]
			[Address(RVA = "0x1551774", Offset = "0x1551774", VA = "0x1551774")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70588", Offset = "0x70588")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D4")]
		public Dictionary<LimbPosition, ConfigJoint> LeftLeg
		{
			[Token(Token = "0x60051B7")]
			[Address(RVA = "0x155177C", Offset = "0x155177C", VA = "0x155177C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70598", Offset = "0x70598")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051B8")]
			[Address(RVA = "0x1551784", Offset = "0x1551784", VA = "0x1551784")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x705A8", Offset = "0x705A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D5")]
		public Dictionary<LimbPosition, ConfigJoint> RightArm
		{
			[Token(Token = "0x60051B9")]
			[Address(RVA = "0x155178C", Offset = "0x155178C", VA = "0x155178C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x705B8", Offset = "0x705B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051BA")]
			[Address(RVA = "0x1551794", Offset = "0x1551794", VA = "0x1551794")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x705C8", Offset = "0x705C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D6")]
		public Dictionary<LimbPosition, ConfigJoint> LeftArm
		{
			[Token(Token = "0x60051BB")]
			[Address(RVA = "0x155179C", Offset = "0x155179C", VA = "0x155179C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x705D8", Offset = "0x705D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051BC")]
			[Address(RVA = "0x15517A4", Offset = "0x15517A4", VA = "0x15517A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x705E8", Offset = "0x705E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008D7")]
		public JointDrive BalanceJointDrive
		{
			[Token(Token = "0x60051BE")]
			[Address(RVA = "0x15517B4", Offset = "0x15517B4", VA = "0x15517B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008D8")]
		public JointDrive UnbalanceJointDrive
		{
			[Token(Token = "0x60051BF")]
			[Address(RVA = "0x154F0E0", Offset = "0x154F0E0", VA = "0x154F0E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008D9")]
		public bool isInitialized
		{
			[Token(Token = "0x60051C0")]
			[Address(RVA = "0x155187C", Offset = "0x155187C", VA = "0x155187C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x705F8", Offset = "0x705F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051C1")]
			[Address(RVA = "0x1551884", Offset = "0x1551884", VA = "0x1551884")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70608", Offset = "0x70608")]
			private set
			{
			}
		}

		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x15517AC", Offset = "0x15517AC", VA = "0x15517AC")]
		public GameObject GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x155188C", Offset = "0x155188C", VA = "0x155188C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x1551890", Offset = "0x1551890", VA = "0x1551890")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x1551818", Offset = "0x1551818", VA = "0x1551818")]
		private JointDrive InitializeJointDrive(JointDriveSettings settings)
		{
			return default;
		}

		[Token(Token = "0x60051C5")]
		[Address(RVA = "0x1551CB8", Offset = "0x1551CB8", VA = "0x1551CB8")]
		public Vector3 GetCenterOfMass()
		{
			return default;
		}

		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x1551ED8", Offset = "0x1551ED8", VA = "0x1551ED8")]
		public MPuppetSetup()
		{
		}
	}
}
