// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/ClientControl/PositionHedgeTrigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/ClientControl/PositionHedgeTrigger.proto</summary>
  public static partial class PositionHedgeTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/ClientControl/PositionHedgeTrigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PositionHedgeTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFQcm90b2J1Zi9DbGllbnRDb250cm9sL1Bvc2l0aW9uSGVkZ2VUcmlnZ2Vy",
            "LnByb3RvEhNzcGlkZXJyb2NrLnByb3RvYnVmGhdzcGlkZXJyb2NrX2NvbW1v",
            "bi5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKaBAoU",
            "UG9zaXRpb25IZWRnZVRyaWdnZXISMwoFX21ldGEYASABKAsyJC5zcGlkZXJy",
            "b2NrLnByb3RvYnVmLk1lc3NhZ2VNZXRhZGF0YRI8CgRwa2V5GAIgASgLMi4u",
            "c3BpZGVycm9jay5wcm90b2J1Zi5Qb3NpdGlvbkhlZGdlVHJpZ2dlci5QS2V5",
            "EhkKEXN5bV9oZWRnZV9iYW5kX2REGGQgASgCEhkKEXN5bV9oZWRnZV9iYW5k",
            "X2dSGGUgASgCEjMKD2JhbGFuY2Vfc3ltYm9scxhmIAEoDjIaLnNwaWRlcnJv",
            "Y2sucHJvdG9idWYuWWVzTm8SMgoKaGVkZ2VfYWxnbxhnIAEoDjIeLnNwaWRl",
            "cnJvY2sucHJvdG9idWYuSGVkZ2VBbGdvEhYKDmV4ZWNfYnJrcl9jb2RlGGgg",
            "ASgJEhYKDmV4ZWNfYnJrcl9hbGdvGGkgASgJEhYKDmV4ZWNfYmtrcl90YWdz",
            "GGogASgJEhMKC21vZGlmaWVkX2J5GGsgASgJEjgKC21vZGlmaWVkX2luGGwg",
            "ASgOMiMuc3BpZGVycm9jay5wcm90b2J1Zi5TeXNFbnZpcm9ubWVudBItCgl0",
            "aW1lc3RhbXAYbSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wGioK",
            "BFBLZXkSDQoFYWNjbnQYCiABKAkSEwoLY2xpZW50X2Zpcm0YCyABKAliBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.PositionHedgeTrigger), global::Spiderrock.Protobuf.PositionHedgeTrigger.Parser, new[]{ "Meta", "Pkey", "SymHedgeBandDD", "SymHedgeBandGR", "BalanceSymbols", "HedgeAlgo", "ExecBrkrCode", "ExecBrkrAlgo", "ExecBkkrTags", "ModifiedBy", "ModifiedIn", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey), global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey.Parser, new[]{ "Accnt", "ClientFirm" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PositionHedgeTrigger : pb::IMessage<PositionHedgeTrigger>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PositionHedgeTrigger> _parser = new pb::MessageParser<PositionHedgeTrigger>(() => new PositionHedgeTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PositionHedgeTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.PositionHedgeTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PositionHedgeTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PositionHedgeTrigger(PositionHedgeTrigger other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      symHedgeBandDD_ = other.symHedgeBandDD_;
      symHedgeBandGR_ = other.symHedgeBandGR_;
      balanceSymbols_ = other.balanceSymbols_;
      hedgeAlgo_ = other.hedgeAlgo_;
      execBrkrCode_ = other.execBrkrCode_;
      execBrkrAlgo_ = other.execBrkrAlgo_;
      execBkkrTags_ = other.execBkkrTags_;
      modifiedBy_ = other.modifiedBy_;
      modifiedIn_ = other.modifiedIn_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PositionHedgeTrigger Clone() {
      return new PositionHedgeTrigger(this);
    }

    /// <summary>Field number for the "_meta" field.</summary>
    public const int MetaFieldNumber = 1;
    private global::Spiderrock.Protobuf.MessageMetadata Meta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.MessageMetadata Meta {
      get { return Meta_; }
      set {
        Meta_ = value;
      }
    }

    /// <summary>Field number for the "pkey" field.</summary>
    public const int PkeyFieldNumber = 2;
    private global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "sym_hedge_band_dD" field.</summary>
    public const int SymHedgeBandDDFieldNumber = 100;
    private float symHedgeBandDD_;
    /// <summary>
    /// individual symbol hedge band ($delta)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float SymHedgeBandDD {
      get { return symHedgeBandDD_; }
      set {
        symHedgeBandDD_ = value;
      }
    }

    /// <summary>Field number for the "sym_hedge_band_gR" field.</summary>
    public const int SymHedgeBandGRFieldNumber = 101;
    private float symHedgeBandGR_;
    /// <summary>
    /// individual symbol hedge band (gamma ratio)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float SymHedgeBandGR {
      get { return symHedgeBandGR_; }
      set {
        symHedgeBandGR_ = value;
      }
    }

    /// <summary>Field number for the "balance_symbols" field.</summary>
    public const int BalanceSymbolsFieldNumber = 102;
    private global::Spiderrock.Protobuf.YesNo balanceSymbols_ = global::Spiderrock.Protobuf.YesNo.Unspecified;
    /// <summary>
    /// target net delta symbol balance
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.YesNo BalanceSymbols {
      get { return balanceSymbols_; }
      set {
        balanceSymbols_ = value;
      }
    }

    /// <summary>Field number for the "hedge_algo" field.</summary>
    public const int HedgeAlgoFieldNumber = 103;
    private global::Spiderrock.Protobuf.HedgeAlgo hedgeAlgo_ = global::Spiderrock.Protobuf.HedgeAlgo.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.HedgeAlgo HedgeAlgo {
      get { return hedgeAlgo_; }
      set {
        hedgeAlgo_ = value;
      }
    }

    /// <summary>Field number for the "exec_brkr_code" field.</summary>
    public const int ExecBrkrCodeFieldNumber = 104;
    private string execBrkrCode_ = "";
    /// <summary>
    /// required if ALT_BROKER
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExecBrkrCode {
      get { return execBrkrCode_; }
      set {
        execBrkrCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exec_brkr_algo" field.</summary>
    public const int ExecBrkrAlgoFieldNumber = 105;
    private string execBrkrAlgo_ = "";
    /// <summary>
    /// display name of exec broker algo (should not have spaces)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExecBrkrAlgo {
      get { return execBrkrAlgo_; }
      set {
        execBrkrAlgo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exec_bkkr_tags" field.</summary>
    public const int ExecBkkrTagsFieldNumber = 106;
    private string execBkkrTags_ = "";
    /// <summary>
    /// key/value set of algo tags that get forwarded to exec broker on order
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ExecBkkrTags {
      get { return execBkkrTags_; }
      set {
        execBkkrTags_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modified_by" field.</summary>
    public const int ModifiedByFieldNumber = 107;
    private string modifiedBy_ = "";
    /// <summary>
    /// user who last modified this record
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ModifiedBy {
      get { return modifiedBy_; }
      set {
        modifiedBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modified_in" field.</summary>
    public const int ModifiedInFieldNumber = 108;
    private global::Spiderrock.Protobuf.SysEnvironment modifiedIn_ = global::Spiderrock.Protobuf.SysEnvironment.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.SysEnvironment ModifiedIn {
      get { return modifiedIn_; }
      set {
        modifiedIn_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 109;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// timestamp of last modification
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PositionHedgeTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PositionHedgeTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SymHedgeBandDD, other.SymHedgeBandDD)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SymHedgeBandGR, other.SymHedgeBandGR)) return false;
      if (BalanceSymbols != other.BalanceSymbols) return false;
      if (HedgeAlgo != other.HedgeAlgo) return false;
      if (ExecBrkrCode != other.ExecBrkrCode) return false;
      if (ExecBrkrAlgo != other.ExecBrkrAlgo) return false;
      if (ExecBkkrTags != other.ExecBkkrTags) return false;
      if (ModifiedBy != other.ModifiedBy) return false;
      if (ModifiedIn != other.ModifiedIn) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (SymHedgeBandDD != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SymHedgeBandDD);
      if (SymHedgeBandGR != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SymHedgeBandGR);
      if (BalanceSymbols != global::Spiderrock.Protobuf.YesNo.Unspecified) hash ^= BalanceSymbols.GetHashCode();
      if (HedgeAlgo != global::Spiderrock.Protobuf.HedgeAlgo.Unspecified) hash ^= HedgeAlgo.GetHashCode();
      if (ExecBrkrCode.Length != 0) hash ^= ExecBrkrCode.GetHashCode();
      if (ExecBrkrAlgo.Length != 0) hash ^= ExecBrkrAlgo.GetHashCode();
      if (ExecBkkrTags.Length != 0) hash ^= ExecBkkrTags.GetHashCode();
      if (ModifiedBy.Length != 0) hash ^= ModifiedBy.GetHashCode();
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) hash ^= ModifiedIn.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (pkey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pkey);
      }
      if (SymHedgeBandDD != 0F) {
        output.WriteRawTag(165, 6);
        output.WriteFloat(SymHedgeBandDD);
      }
      if (SymHedgeBandGR != 0F) {
        output.WriteRawTag(173, 6);
        output.WriteFloat(SymHedgeBandGR);
      }
      if (BalanceSymbols != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(176, 6);
        output.WriteEnum((int) BalanceSymbols);
      }
      if (HedgeAlgo != global::Spiderrock.Protobuf.HedgeAlgo.Unspecified) {
        output.WriteRawTag(184, 6);
        output.WriteEnum((int) HedgeAlgo);
      }
      if (ExecBrkrCode.Length != 0) {
        output.WriteRawTag(194, 6);
        output.WriteString(ExecBrkrCode);
      }
      if (ExecBrkrAlgo.Length != 0) {
        output.WriteRawTag(202, 6);
        output.WriteString(ExecBrkrAlgo);
      }
      if (ExecBkkrTags.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(ExecBkkrTags);
      }
      if (ModifiedBy.Length != 0) {
        output.WriteRawTag(218, 6);
        output.WriteString(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(224, 6);
        output.WriteEnum((int) ModifiedIn);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(234, 6);
        output.WriteMessage(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Meta_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Meta);
      }
      if (pkey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pkey);
      }
      if (SymHedgeBandDD != 0F) {
        output.WriteRawTag(165, 6);
        output.WriteFloat(SymHedgeBandDD);
      }
      if (SymHedgeBandGR != 0F) {
        output.WriteRawTag(173, 6);
        output.WriteFloat(SymHedgeBandGR);
      }
      if (BalanceSymbols != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(176, 6);
        output.WriteEnum((int) BalanceSymbols);
      }
      if (HedgeAlgo != global::Spiderrock.Protobuf.HedgeAlgo.Unspecified) {
        output.WriteRawTag(184, 6);
        output.WriteEnum((int) HedgeAlgo);
      }
      if (ExecBrkrCode.Length != 0) {
        output.WriteRawTag(194, 6);
        output.WriteString(ExecBrkrCode);
      }
      if (ExecBrkrAlgo.Length != 0) {
        output.WriteRawTag(202, 6);
        output.WriteString(ExecBrkrAlgo);
      }
      if (ExecBkkrTags.Length != 0) {
        output.WriteRawTag(210, 6);
        output.WriteString(ExecBkkrTags);
      }
      if (ModifiedBy.Length != 0) {
        output.WriteRawTag(218, 6);
        output.WriteString(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        output.WriteRawTag(224, 6);
        output.WriteEnum((int) ModifiedIn);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(234, 6);
        output.WriteMessage(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Meta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Meta);
      }
      if (pkey_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pkey);
      }
      if (SymHedgeBandDD != 0F) {
        size += 2 + 4;
      }
      if (SymHedgeBandGR != 0F) {
        size += 2 + 4;
      }
      if (BalanceSymbols != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) BalanceSymbols);
      }
      if (HedgeAlgo != global::Spiderrock.Protobuf.HedgeAlgo.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) HedgeAlgo);
      }
      if (ExecBrkrCode.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExecBrkrCode);
      }
      if (ExecBrkrAlgo.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExecBrkrAlgo);
      }
      if (ExecBkkrTags.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExecBkkrTags);
      }
      if (ModifiedBy.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ModifiedBy);
      }
      if (ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ModifiedIn);
      }
      if (timestamp_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PositionHedgeTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.pkey_ != null) {
        if (pkey_ == null) {
          Pkey = new global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.SymHedgeBandDD != 0F) {
        SymHedgeBandDD = other.SymHedgeBandDD;
      }
      if (other.SymHedgeBandGR != 0F) {
        SymHedgeBandGR = other.SymHedgeBandGR;
      }
      if (other.BalanceSymbols != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        BalanceSymbols = other.BalanceSymbols;
      }
      if (other.HedgeAlgo != global::Spiderrock.Protobuf.HedgeAlgo.Unspecified) {
        HedgeAlgo = other.HedgeAlgo;
      }
      if (other.ExecBrkrCode.Length != 0) {
        ExecBrkrCode = other.ExecBrkrCode;
      }
      if (other.ExecBrkrAlgo.Length != 0) {
        ExecBrkrAlgo = other.ExecBrkrAlgo;
      }
      if (other.ExecBkkrTags.Length != 0) {
        ExecBkkrTags = other.ExecBkkrTags;
      }
      if (other.ModifiedBy.Length != 0) {
        ModifiedBy = other.ModifiedBy;
      }
      if (other.ModifiedIn != global::Spiderrock.Protobuf.SysEnvironment.Unspecified) {
        ModifiedIn = other.ModifiedIn;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 18: {
            if (pkey_ == null) {
              Pkey = new global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 805: {
            SymHedgeBandDD = input.ReadFloat();
            break;
          }
          case 813: {
            SymHedgeBandGR = input.ReadFloat();
            break;
          }
          case 816: {
            BalanceSymbols = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 824: {
            HedgeAlgo = (global::Spiderrock.Protobuf.HedgeAlgo) input.ReadEnum();
            break;
          }
          case 834: {
            ExecBrkrCode = input.ReadString();
            break;
          }
          case 842: {
            ExecBrkrAlgo = input.ReadString();
            break;
          }
          case 850: {
            ExecBkkrTags = input.ReadString();
            break;
          }
          case 858: {
            ModifiedBy = input.ReadString();
            break;
          }
          case 864: {
            ModifiedIn = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
            break;
          }
          case 874: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (Meta_ == null) {
              Meta = new global::Spiderrock.Protobuf.MessageMetadata();
            }
            input.ReadMessage(Meta);
            break;
          }
          case 18: {
            if (pkey_ == null) {
              Pkey = new global::Spiderrock.Protobuf.PositionHedgeTrigger.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 805: {
            SymHedgeBandDD = input.ReadFloat();
            break;
          }
          case 813: {
            SymHedgeBandGR = input.ReadFloat();
            break;
          }
          case 816: {
            BalanceSymbols = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 824: {
            HedgeAlgo = (global::Spiderrock.Protobuf.HedgeAlgo) input.ReadEnum();
            break;
          }
          case 834: {
            ExecBrkrCode = input.ReadString();
            break;
          }
          case 842: {
            ExecBrkrAlgo = input.ReadString();
            break;
          }
          case 850: {
            ExecBkkrTags = input.ReadString();
            break;
          }
          case 858: {
            ModifiedBy = input.ReadString();
            break;
          }
          case 864: {
            ModifiedIn = (global::Spiderrock.Protobuf.SysEnvironment) input.ReadEnum();
            break;
          }
          case 874: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PositionHedgeTrigger message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class PKey : pb::IMessage<PKey>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PKey> _parser = new pb::MessageParser<PKey>(() => new PKey());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PKey> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Spiderrock.Protobuf.PositionHedgeTrigger.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey(PKey other) : this() {
          accnt_ = other.accnt_;
          clientFirm_ = other.clientFirm_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "accnt" field.</summary>
        public const int AccntFieldNumber = 10;
        private string accnt_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Accnt {
          get { return accnt_; }
          set {
            accnt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "client_firm" field.</summary>
        public const int ClientFirmFieldNumber = 11;
        private string clientFirm_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ClientFirm {
          get { return clientFirm_; }
          set {
            clientFirm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PKey);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PKey other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Accnt != other.Accnt) return false;
          if (ClientFirm != other.ClientFirm) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Accnt.Length != 0) hash ^= Accnt.GetHashCode();
          if (ClientFirm.Length != 0) hash ^= ClientFirm.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (Accnt.Length != 0) {
            output.WriteRawTag(82);
            output.WriteString(Accnt);
          }
          if (ClientFirm.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(ClientFirm);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (Accnt.Length != 0) {
            output.WriteRawTag(82);
            output.WriteString(Accnt);
          }
          if (ClientFirm.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(ClientFirm);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (Accnt.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Accnt);
          }
          if (ClientFirm.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientFirm);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PKey other) {
          if (other == null) {
            return;
          }
          if (other.Accnt.Length != 0) {
            Accnt = other.Accnt;
          }
          if (other.ClientFirm.Length != 0) {
            ClientFirm = other.ClientFirm;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 82: {
                Accnt = input.ReadString();
                break;
              }
              case 90: {
                ClientFirm = input.ReadString();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 82: {
                Accnt = input.ReadString();
                break;
              }
              case 90: {
                ClientFirm = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
