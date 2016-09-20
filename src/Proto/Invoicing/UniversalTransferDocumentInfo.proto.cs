//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Invoicing/UniversalTransferDocumentInfo.proto
// Note: requires additional types generated from: Invoicing/InvoiceInfo.proto
// Note: requires additional types generated from: Invoicing/ExtendedSigner.proto
// Note: requires additional types generated from: Invoicing/ExtendedOrganizationInfo.proto
namespace Diadoc.Api.Proto.Invoicing
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UniversalTransferDocumentSellerTitleInfo")]
  public partial class UniversalTransferDocumentSellerTitleInfo : global::ProtoBuf.IExtensible
  {
    public UniversalTransferDocumentSellerTitleInfo() {}
    
    private Diadoc.Api.Proto.Invoicing.FunctionType _Function;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Function", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Invoicing.FunctionType Function
    {
      get { return _Function; }
      set { _Function = value; }
    }

    private string _DocumentName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DocumentName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentName
    {
      get { return _DocumentName; }
      set { _DocumentName = value; }
    }
    private string _DocumentDate;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentDate
    {
      get { return _DocumentDate; }
      set { _DocumentDate = value; }
    }
    private string _DocumentNumber;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentNumber
    {
      get { return _DocumentNumber; }
      set { _DocumentNumber = value; }
    }
    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Seller;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Seller", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Seller
    {
      get { return _Seller; }
      set { _Seller = value; }
    }
    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Buyer;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Buyer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Buyer
    {
      get { return _Buyer; }
      set { _Buyer = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Shipper _Shipper = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Shipper", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Shipper Shipper
    {
      get { return _Shipper; }
      set { _Shipper = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Consignee = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Consignee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Consignee
    {
      get { return _Consignee; }
      set { _Consignee = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> _Signers = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner>();
    [global::ProtoBuf.ProtoMember(9, Name=@"Signers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> Signers
    {
      get { return _Signers; }
    }
  
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.PaymentDocumentInfo> _PaymentDocuments = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.PaymentDocumentInfo>();
    [global::ProtoBuf.ProtoMember(10, Name=@"PaymentDocuments", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.PaymentDocumentInfo> PaymentDocuments
    {
      get { return _PaymentDocuments; }
    }
  

    private Diadoc.Api.Proto.Invoicing.InvoiceTable _InvoiceTable = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"InvoiceTable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.InvoiceTable InvoiceTable
    {
      get { return _InvoiceTable; }
      set { _InvoiceTable = value; }
    }
    private string _Currency;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }

    private string _CurrencyRate = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CurrencyRate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CurrencyRate
    {
      get { return _CurrencyRate; }
      set { _CurrencyRate = value; }
    }

    private string _RevisionDate = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RevisionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionDate
    {
      get { return _RevisionDate; }
      set { _RevisionDate = value; }
    }

    private string _RevisionNumber = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"RevisionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionNumber
    {
      get { return _RevisionNumber; }
      set { _RevisionNumber = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }

    private Diadoc.Api.Proto.Invoicing.TransferInfo _TransferInfo = null;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"TransferInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.TransferInfo TransferInfo
    {
      get { return _TransferInfo; }
      set { _TransferInfo = value; }
    }
    private string _DocumentCreator;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"DocumentCreator", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentCreator
    {
      get { return _DocumentCreator; }
      set { _DocumentCreator = value; }
    }

    private string _DocumentCreatorBase = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DocumentCreatorBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentCreatorBase
    {
      get { return _DocumentCreatorBase; }
      set { _DocumentCreatorBase = value; }
    }

    private string _GovermentContractInfo = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"GovermentContractInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string GovermentContractInfo
    {
      get { return _GovermentContractInfo; }
      set { _GovermentContractInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Shipper")]
  public partial class Shipper : global::ProtoBuf.IExtensible
  {
    public Shipper() {}
    

    private bool _SameAsSeller = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SameAsSeller", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool SameAsSeller
    {
      get { return _SameAsSeller; }
      set { _SameAsSeller = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _OrgInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OrgInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo OrgInfo
    {
      get { return _OrgInfo; }
      set { _OrgInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceTable")]
  public partial class InvoiceTable : global::ProtoBuf.IExtensible
  {
    public InvoiceTable() {}
    
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.ExtendedInvoiceItem> _Items = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.ExtendedInvoiceItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.ExtendedInvoiceItem> Items
    {
      get { return _Items; }
    }
  

    private string _TotalWithVatExcluded = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TotalWithVatExcluded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalWithVatExcluded
    {
      get { return _TotalWithVatExcluded; }
      set { _TotalWithVatExcluded = value; }
    }
    private string _Vat;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _TotalNet = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TotalNet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalNet
    {
      get { return _TotalNet; }
      set { _TotalNet = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExtendedInvoiceItem")]
  public partial class ExtendedInvoiceItem : global::ProtoBuf.IExtensible
  {
    public ExtendedInvoiceItem() {}
    
    private string _Product;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Product", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Product
    {
      get { return _Product; }
      set { _Product = value; }
    }

    private string _Unit = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Unit
    {
      get { return _Unit; }
      set { _Unit = value; }
    }

    private string _UnitName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UnitName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UnitName
    {
      get { return _UnitName; }
      set { _UnitName = value; }
    }

    private string _Quantity = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Quantity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Quantity
    {
      get { return _Quantity; }
      set { _Quantity = value; }
    }

    private string _Price = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Price", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    private string _Excise = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Excise", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Excise
    {
      get { return _Excise; }
      set { _Excise = value; }
    }
    private Diadoc.Api.Proto.Invoicing.TaxRate _TaxRate;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"TaxRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Invoicing.TaxRate TaxRate
    {
      get { return _TaxRate; }
      set { _TaxRate = value; }
    }

    private string _SubtotalWithVatExcluded = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SubtotalWithVatExcluded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SubtotalWithVatExcluded
    {
      get { return _SubtotalWithVatExcluded; }
      set { _SubtotalWithVatExcluded = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }
    private string _Subtotal;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Subtotal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Subtotal
    {
      get { return _Subtotal; }
      set { _Subtotal = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.CustomsDeclaration> _CustomsDeclarations = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.CustomsDeclaration>();
    [global::ProtoBuf.ProtoMember(11, Name=@"CustomsDeclarations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.CustomsDeclaration> CustomsDeclarations
    {
      get { return _CustomsDeclarations; }
    }
  

    private Diadoc.Api.Proto.Invoicing.ItemMark _ItemMark = Diadoc.Api.Proto.Invoicing.ItemMark.NotSpecified;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ItemMark", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Invoicing.ItemMark.NotSpecified)]
    public Diadoc.Api.Proto.Invoicing.ItemMark ItemMark
    {
      get { return _ItemMark; }
      set { _ItemMark = value; }
    }

    private string _AdditionalProperty = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"AdditionalProperty", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string AdditionalProperty
    {
      get { return _AdditionalProperty; }
      set { _AdditionalProperty = value; }
    }

    private string _ItemVendorCode = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ItemVendorCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemVendorCode
    {
      get { return _ItemVendorCode; }
      set { _ItemVendorCode = value; }
    }

    private string _ItemToRelease = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ItemToRelease", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemToRelease
    {
      get { return _ItemToRelease; }
      set { _ItemToRelease = value; }
    }

    private string _ItemAccountDebit = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ItemAccountDebit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemAccountDebit
    {
      get { return _ItemAccountDebit; }
      set { _ItemAccountDebit = value; }
    }

    private string _ItemAccountCredit = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ItemAccountCredit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemAccountCredit
    {
      get { return _ItemAccountCredit; }
      set { _ItemAccountCredit = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> _AdditionalInfo = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo>();
    [global::ProtoBuf.ProtoMember(18, Name=@"AdditionalInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> AdditionalInfo
    {
      get { return _AdditionalInfo; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TransferInfo")]
  public partial class TransferInfo : global::ProtoBuf.IExtensible
  {
    public TransferInfo() {}
    
    private string _OperationInfo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"OperationInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationInfo
    {
      get { return _OperationInfo; }
      set { _OperationInfo = value; }
    }

    private string _OperationType = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OperationType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationType
    {
      get { return _OperationType; }
      set { _OperationType = value; }
    }

    private string _TransferDate = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TransferDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferDate
    {
      get { return _TransferDate; }
      set { _TransferDate = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.TransferBase> _TransferBase = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.TransferBase>();
    [global::ProtoBuf.ProtoMember(4, Name=@"TransferBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.TransferBase> TransferBase
    {
      get { return _TransferBase; }
    }
  

    private string _TransferTextInfo = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TransferTextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferTextInfo
    {
      get { return _TransferTextInfo; }
      set { _TransferTextInfo = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Waybill> _Waybill = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Waybill>();
    [global::ProtoBuf.ProtoMember(6, Name=@"Waybill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Waybill> Waybill
    {
      get { return _Waybill; }
    }
  

    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Carrier = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Carrier", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Carrier
    {
      get { return _Carrier; }
      set { _Carrier = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Employee _Employee = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Employee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Employee Employee
    {
      get { return _Employee; }
      set { _Employee = value; }
    }

    private Diadoc.Api.Proto.Invoicing.OtherIssuer _OtherIssuer = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"OtherIssuer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.OtherIssuer OtherIssuer
    {
      get { return _OtherIssuer; }
      set { _OtherIssuer = value; }
    }

    private string _CreatedThingTransferDate = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CreatedThingTransferDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CreatedThingTransferDate
    {
      get { return _CreatedThingTransferDate; }
      set { _CreatedThingTransferDate = value; }
    }

    private string _CreatedThingInfo = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CreatedThingInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CreatedThingInfo
    {
      get { return _CreatedThingInfo; }
      set { _CreatedThingInfo = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TransferBase")]
  public partial class TransferBase : global::ProtoBuf.IExtensible
  {
    public TransferBase() {}
    
    private string _BaseDocumentName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"BaseDocumentName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BaseDocumentName
    {
      get { return _BaseDocumentName; }
      set { _BaseDocumentName = value; }
    }

    private string _BaseDocumentNumber = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BaseDocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BaseDocumentNumber
    {
      get { return _BaseDocumentNumber; }
      set { _BaseDocumentNumber = value; }
    }

    private string _BaseDocumentDate = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"BaseDocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BaseDocumentDate
    {
      get { return _BaseDocumentDate; }
      set { _BaseDocumentDate = value; }
    }

    private string _BaseDocumentInfo = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"BaseDocumentInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BaseDocumentInfo
    {
      get { return _BaseDocumentInfo; }
      set { _BaseDocumentInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Waybill")]
  public partial class Waybill : global::ProtoBuf.IExtensible
  {
    public Waybill() {}
    
    private string _TransferDocumentNumber;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"TransferDocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TransferDocumentNumber
    {
      get { return _TransferDocumentNumber; }
      set { _TransferDocumentNumber = value; }
    }
    private string _TransferDocumentDate;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"TransferDocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TransferDocumentDate
    {
      get { return _TransferDocumentDate; }
      set { _TransferDocumentDate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Employee")]
  public partial class Employee : global::ProtoBuf.IExtensible
  {
    public Employee() {}
    
    private string _EmployeePosition;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"EmployeePosition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EmployeePosition
    {
      get { return _EmployeePosition; }
      set { _EmployeePosition = value; }
    }

    private string _EmployeeInfo = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"EmployeeInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string EmployeeInfo
    {
      get { return _EmployeeInfo; }
      set { _EmployeeInfo = value; }
    }

    private string _EmployeeBase = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"EmployeeBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string EmployeeBase
    {
      get { return _EmployeeBase; }
      set { _EmployeeBase = value; }
    }
    private string _TransferSurname;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"TransferSurname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TransferSurname
    {
      get { return _TransferSurname; }
      set { _TransferSurname = value; }
    }
    private string _TransferFirstName;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"TransferFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TransferFirstName
    {
      get { return _TransferFirstName; }
      set { _TransferFirstName = value; }
    }

    private string _TransferPatronymic = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"TransferPatronymic", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferPatronymic
    {
      get { return _TransferPatronymic; }
      set { _TransferPatronymic = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OtherIssuer")]
  public partial class OtherIssuer : global::ProtoBuf.IExtensible
  {
    public OtherIssuer() {}
    

    private string _TransferEmployeePosition = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TransferEmployeePosition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferEmployeePosition
    {
      get { return _TransferEmployeePosition; }
      set { _TransferEmployeePosition = value; }
    }

    private string _TransferEmployeeInfo = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TransferEmployeeInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferEmployeeInfo
    {
      get { return _TransferEmployeeInfo; }
      set { _TransferEmployeeInfo = value; }
    }

    private string _TransferOrganizationName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TransferOrganizationName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferOrganizationName
    {
      get { return _TransferOrganizationName; }
      set { _TransferOrganizationName = value; }
    }

    private string _TransferOrganizationBase = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"TransferOrganizationBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferOrganizationBase
    {
      get { return _TransferOrganizationBase; }
      set { _TransferOrganizationBase = value; }
    }

    private string _TransferEmployeeBase = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TransferEmployeeBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferEmployeeBase
    {
      get { return _TransferEmployeeBase; }
      set { _TransferEmployeeBase = value; }
    }
    private string _TransferSurname;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"TransferSurname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TransferSurname
    {
      get { return _TransferSurname; }
      set { _TransferSurname = value; }
    }
    private string _TransferFirstName;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"TransferFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TransferFirstName
    {
      get { return _TransferFirstName; }
      set { _TransferFirstName = value; }
    }

    private string _TransferPatronymic = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TransferPatronymic", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferPatronymic
    {
      get { return _TransferPatronymic; }
      set { _TransferPatronymic = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdditionalInfoId")]
  public partial class AdditionalInfoId : global::ProtoBuf.IExtensible
  {
    public AdditionalInfoId() {}
    

    private string _InfoFileId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"InfoFileId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string InfoFileId
    {
      get { return _InfoFileId; }
      set { _InfoFileId = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> _AdditionalInfo = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"AdditionalInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> AdditionalInfo
    {
      get { return _AdditionalInfo; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UniversalTransferDocumentBuyerTitleInfo")]
  public partial class UniversalTransferDocumentBuyerTitleInfo : global::ProtoBuf.IExtensible
  {
    public UniversalTransferDocumentBuyerTitleInfo() {}
    
    private string _DocumentCreator;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DocumentCreator", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentCreator
    {
      get { return _DocumentCreator; }
      set { _DocumentCreator = value; }
    }

    private string _DocumentCreatorBase = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DocumentCreatorBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentCreatorBase
    {
      get { return _DocumentCreatorBase; }
      set { _DocumentCreatorBase = value; }
    }

    private string _OperationCode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"OperationCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationCode
    {
      get { return _OperationCode; }
      set { _OperationCode = value; }
    }
    private string _OperationContent;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OperationContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationContent
    {
      get { return _OperationContent; }
      set { _OperationContent = value; }
    }

    private string _AcceptanceDate = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AcceptanceDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string AcceptanceDate
    {
      get { return _AcceptanceDate; }
      set { _AcceptanceDate = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Employee _Employee = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Employee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Employee Employee
    {
      get { return _Employee; }
      set { _Employee = value; }
    }

    private Diadoc.Api.Proto.Invoicing.OtherIssuer _OtherIssuer = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"OtherIssuer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.OtherIssuer OtherIssuer
    {
      get { return _OtherIssuer; }
      set { _OtherIssuer = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> _Signers = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner>();
    [global::ProtoBuf.ProtoMember(9, Name=@"Signers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> Signers
    {
      get { return _Signers; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"FunctionType")]
    public enum FunctionType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Invoice", Value=0)]
      Invoice = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Basic", Value=1)]
      Basic = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InvoiceAndBasic", Value=2)]
      InvoiceAndBasic = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ItemMark")]
    public enum ItemMark
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NotSpecified", Value=0)]
      NotSpecified = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Property", Value=1)]
      Property = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Job", Value=2)]
      Job = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Service", Value=3)]
      Service = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PropertyRights", Value=4)]
      PropertyRights = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Other", Value=5)]
      Other = 5
    }
  
}