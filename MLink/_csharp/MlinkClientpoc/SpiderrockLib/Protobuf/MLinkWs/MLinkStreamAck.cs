// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/MLinkWs/MLinkStreamAck.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/MLinkWs/MLinkStreamAck.proto</summary>
  public static partial class MLinkStreamAckReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/MLinkWs/MLinkStreamAck.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MLinkStreamAckReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQcm90b2J1Zi9NTGlua1dzL01MaW5rU3RyZWFtQWNrLnByb3RvEhNzcGlk",
            "ZXJyb2NrLnByb3RvYnVmGhdzcGlkZXJyb2NrX2NvbW1vbi5wcm90byKaAgoO",
            "TUxpbmtTdHJlYW1BY2sSMwoFX21ldGEYASABKAsyJC5zcGlkZXJyb2NrLnBy",
            "b3RvYnVmLk1lc3NhZ2VNZXRhZGF0YRISCgpzZXNzaW9uX2lEGGQgASgFEhAK",
            "CHF1ZXJ5X2lEGGcgASgDEhUKDXF1ZXJ5X3NlbmRfdHMYaiABKAMSEwoLcXVl",
            "cnlfbGFiZWwYbSABKAkSLwoLdW5zdWJzY3JpYmUYcCABKA4yGi5zcGlkZXJy",
            "b2NrLnByb3RvYnVmLlllc05vEhAKCG1zZ19uYW1lGHMgASgJEi4KBnJlc3Vs",
            "dBh2IAEoDjIeLnNwaWRlcnJvY2sucHJvdG9idWYuQWNrUmVzdWx0Eg4KBmRl",
            "dGFpbBh6IAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.MLinkStreamAck), global::Spiderrock.Protobuf.MLinkStreamAck.Parser, new[]{ "Meta", "SessionID", "QueryID", "QuerySendTs", "QueryLabel", "Unsubscribe", "MsgName", "Result", "Detail" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MLinkStreamAck : pb::IMessage<MLinkStreamAck>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MLinkStreamAck> _parser = new pb::MessageParser<MLinkStreamAck>(() => new MLinkStreamAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MLinkStreamAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.MLinkStreamAckReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkStreamAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkStreamAck(MLinkStreamAck other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      sessionID_ = other.sessionID_;
      queryID_ = other.queryID_;
      querySendTs_ = other.querySendTs_;
      queryLabel_ = other.queryLabel_;
      unsubscribe_ = other.unsubscribe_;
      msgName_ = other.msgName_;
      result_ = other.result_;
      detail_ = other.detail_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MLinkStreamAck Clone() {
      return new MLinkStreamAck(this);
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

    /// <summary>Field number for the "session_iD" field.</summary>
    public const int SessionIDFieldNumber = 100;
    private int sessionID_;
    /// <summary>
    /// from MLinkStream.sessionID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SessionID {
      get { return sessionID_; }
      set {
        sessionID_ = value;
      }
    }

    /// <summary>Field number for the "query_iD" field.</summary>
    public const int QueryIDFieldNumber = 103;
    private long queryID_;
    /// <summary>
    /// from MLinkStream.queryID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long QueryID {
      get { return queryID_; }
      set {
        queryID_ = value;
      }
    }

    /// <summary>Field number for the "query_send_ts" field.</summary>
    public const int QuerySendTsFieldNumber = 106;
    private long querySendTs_;
    /// <summary>
    /// MLinkStream.header.sentTs (should be unique)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long QuerySendTs {
      get { return querySendTs_; }
      set {
        querySendTs_ = value;
      }
    }

    /// <summary>Field number for the "query_label" field.</summary>
    public const int QueryLabelFieldNumber = 109;
    private string queryLabel_ = "";
    /// <summary>
    /// from MLinkStream.queryLabel
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string QueryLabel {
      get { return queryLabel_; }
      set {
        queryLabel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unsubscribe" field.</summary>
    public const int UnsubscribeFieldNumber = 112;
    private global::Spiderrock.Protobuf.YesNo unsubscribe_ = global::Spiderrock.Protobuf.YesNo.Unspecified;
    /// <summary>
    /// from MLinkStream.unsubscribe
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.YesNo Unsubscribe {
      get { return unsubscribe_; }
      set {
        unsubscribe_ = value;
      }
    }

    /// <summary>Field number for the "msg_name" field.</summary>
    public const int MsgNameFieldNumber = 115;
    private string msgName_ = "";
    /// <summary>
    /// (required) a SpiderRock message name (topic channel) (can be string name or protobuf message number)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MsgName {
      get { return msgName_; }
      set {
        msgName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 118;
    private global::Spiderrock.Protobuf.AckResult result_ = global::Spiderrock.Protobuf.AckResult.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.AckResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "detail" field.</summary>
    public const int DetailFieldNumber = 122;
    private string detail_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Detail {
      get { return detail_; }
      set {
        detail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MLinkStreamAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MLinkStreamAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (SessionID != other.SessionID) return false;
      if (QueryID != other.QueryID) return false;
      if (QuerySendTs != other.QuerySendTs) return false;
      if (QueryLabel != other.QueryLabel) return false;
      if (Unsubscribe != other.Unsubscribe) return false;
      if (MsgName != other.MsgName) return false;
      if (Result != other.Result) return false;
      if (Detail != other.Detail) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (SessionID != 0) hash ^= SessionID.GetHashCode();
      if (QueryID != 0L) hash ^= QueryID.GetHashCode();
      if (QuerySendTs != 0L) hash ^= QuerySendTs.GetHashCode();
      if (QueryLabel.Length != 0) hash ^= QueryLabel.GetHashCode();
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) hash ^= Unsubscribe.GetHashCode();
      if (MsgName.Length != 0) hash ^= MsgName.GetHashCode();
      if (Result != global::Spiderrock.Protobuf.AckResult.Unspecified) hash ^= Result.GetHashCode();
      if (Detail.Length != 0) hash ^= Detail.GetHashCode();
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
      if (SessionID != 0) {
        output.WriteRawTag(160, 6);
        output.WriteInt32(SessionID);
      }
      if (QueryID != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(QueryID);
      }
      if (QuerySendTs != 0L) {
        output.WriteRawTag(208, 6);
        output.WriteInt64(QuerySendTs);
      }
      if (QueryLabel.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(QueryLabel);
      }
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(128, 7);
        output.WriteEnum((int) Unsubscribe);
      }
      if (MsgName.Length != 0) {
        output.WriteRawTag(154, 7);
        output.WriteString(MsgName);
      }
      if (Result != global::Spiderrock.Protobuf.AckResult.Unspecified) {
        output.WriteRawTag(176, 7);
        output.WriteEnum((int) Result);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(210, 7);
        output.WriteString(Detail);
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
      if (SessionID != 0) {
        output.WriteRawTag(160, 6);
        output.WriteInt32(SessionID);
      }
      if (QueryID != 0L) {
        output.WriteRawTag(184, 6);
        output.WriteInt64(QueryID);
      }
      if (QuerySendTs != 0L) {
        output.WriteRawTag(208, 6);
        output.WriteInt64(QuerySendTs);
      }
      if (QueryLabel.Length != 0) {
        output.WriteRawTag(234, 6);
        output.WriteString(QueryLabel);
      }
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        output.WriteRawTag(128, 7);
        output.WriteEnum((int) Unsubscribe);
      }
      if (MsgName.Length != 0) {
        output.WriteRawTag(154, 7);
        output.WriteString(MsgName);
      }
      if (Result != global::Spiderrock.Protobuf.AckResult.Unspecified) {
        output.WriteRawTag(176, 7);
        output.WriteEnum((int) Result);
      }
      if (Detail.Length != 0) {
        output.WriteRawTag(210, 7);
        output.WriteString(Detail);
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
      if (SessionID != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(SessionID);
      }
      if (QueryID != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(QueryID);
      }
      if (QuerySendTs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(QuerySendTs);
      }
      if (QueryLabel.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(QueryLabel);
      }
      if (Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Unsubscribe);
      }
      if (MsgName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(MsgName);
      }
      if (Result != global::Spiderrock.Protobuf.AckResult.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (Detail.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Detail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MLinkStreamAck other) {
      if (other == null) {
        return;
      }
      if (other.Meta_ != null) {
        if (Meta_ == null) {
          Meta = new global::Spiderrock.Protobuf.MessageMetadata();
        }
        Meta.MergeFrom(other.Meta);
      }
      if (other.SessionID != 0) {
        SessionID = other.SessionID;
      }
      if (other.QueryID != 0L) {
        QueryID = other.QueryID;
      }
      if (other.QuerySendTs != 0L) {
        QuerySendTs = other.QuerySendTs;
      }
      if (other.QueryLabel.Length != 0) {
        QueryLabel = other.QueryLabel;
      }
      if (other.Unsubscribe != global::Spiderrock.Protobuf.YesNo.Unspecified) {
        Unsubscribe = other.Unsubscribe;
      }
      if (other.MsgName.Length != 0) {
        MsgName = other.MsgName;
      }
      if (other.Result != global::Spiderrock.Protobuf.AckResult.Unspecified) {
        Result = other.Result;
      }
      if (other.Detail.Length != 0) {
        Detail = other.Detail;
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
          case 800: {
            SessionID = input.ReadInt32();
            break;
          }
          case 824: {
            QueryID = input.ReadInt64();
            break;
          }
          case 848: {
            QuerySendTs = input.ReadInt64();
            break;
          }
          case 874: {
            QueryLabel = input.ReadString();
            break;
          }
          case 896: {
            Unsubscribe = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 922: {
            MsgName = input.ReadString();
            break;
          }
          case 944: {
            Result = (global::Spiderrock.Protobuf.AckResult) input.ReadEnum();
            break;
          }
          case 978: {
            Detail = input.ReadString();
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
          case 800: {
            SessionID = input.ReadInt32();
            break;
          }
          case 824: {
            QueryID = input.ReadInt64();
            break;
          }
          case 848: {
            QuerySendTs = input.ReadInt64();
            break;
          }
          case 874: {
            QueryLabel = input.ReadString();
            break;
          }
          case 896: {
            Unsubscribe = (global::Spiderrock.Protobuf.YesNo) input.ReadEnum();
            break;
          }
          case 922: {
            MsgName = input.ReadString();
            break;
          }
          case 944: {
            Result = (global::Spiderrock.Protobuf.AckResult) input.ReadEnum();
            break;
          }
          case 978: {
            Detail = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
