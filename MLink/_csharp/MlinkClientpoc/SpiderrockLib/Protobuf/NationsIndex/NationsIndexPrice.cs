// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/NationsIndex/NationsIndexPrice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Spiderrock.Protobuf {

  /// <summary>Holder for reflection information generated from Protobuf/NationsIndex/NationsIndexPrice.proto</summary>
  public static partial class NationsIndexPriceReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/NationsIndex/NationsIndexPrice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NationsIndexPriceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1Qcm90b2J1Zi9OYXRpb25zSW5kZXgvTmF0aW9uc0luZGV4UHJpY2UucHJv",
            "dG8SE3NwaWRlcnJvY2sucHJvdG9idWYaF3NwaWRlcnJvY2tfY29tbW9uLnBy",
            "b3RvIq8CChFOYXRpb25zSW5kZXhQcmljZRIzCgVfbWV0YRgBIAEoCzIkLnNw",
            "aWRlcnJvY2sucHJvdG9idWYuTWVzc2FnZU1ldGFkYXRhEjkKBHBrZXkYAiAB",
            "KAsyKy5zcGlkZXJyb2NrLnByb3RvYnVmLk5hdGlvbnNJbmRleFByaWNlLlBL",
            "ZXkSEQoJbXJrX3ByaWNlGGQgASgCEiwKBmV4cGlyeRhlIAEoCzIcLnNwaWRl",
            "cnJvY2sucHJvdG9idWYuRGF0ZUtleRIVCg1zcmNfdGltZXN0YW1wGGYgASgD",
            "GlIKBFBLZXkSLgoGdGlja2VyGAogASgLMh4uc3BpZGVycm9jay5wcm90b2J1",
            "Zi5UaWNrZXJLZXkSDAoEbmFtZRgLIAEoCRIMCgRkYXlzGAwgASgFYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Spiderrock.Protobuf.SpiderrockCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.NationsIndexPrice), global::Spiderrock.Protobuf.NationsIndexPrice.Parser, new[]{ "Meta", "Pkey", "MrkPrice", "Expiry", "SrcTimestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey), global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey.Parser, new[]{ "Ticker", "Name", "Days" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///Intraday Nations Index Prices Calculated by SR
  /// </summary>
  public sealed partial class NationsIndexPrice : pb::IMessage<NationsIndexPrice>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NationsIndexPrice> _parser = new pb::MessageParser<NationsIndexPrice>(() => new NationsIndexPrice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NationsIndexPrice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Spiderrock.Protobuf.NationsIndexPriceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NationsIndexPrice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NationsIndexPrice(NationsIndexPrice other) : this() {
      Meta_ = other.Meta_ != null ? other.Meta_.Clone() : null;
      pkey_ = other.pkey_ != null ? other.pkey_.Clone() : null;
      mrkPrice_ = other.mrkPrice_;
      expiry_ = other.expiry_ != null ? other.expiry_.Clone() : null;
      srcTimestamp_ = other.srcTimestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NationsIndexPrice Clone() {
      return new NationsIndexPrice(this);
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
    private global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey pkey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey Pkey {
      get { return pkey_; }
      set {
        pkey_ = value;
      }
    }

    /// <summary>Field number for the "mrk_price" field.</summary>
    public const int MrkPriceFieldNumber = 100;
    private float mrkPrice_;
    /// <summary>
    /// last regular market price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MrkPrice {
      get { return mrkPrice_; }
      set {
        mrkPrice_ = value;
      }
    }

    /// <summary>Field number for the "expiry" field.</summary>
    public const int ExpiryFieldNumber = 101;
    private global::Spiderrock.Protobuf.DateKey expiry_;
    /// <summary>
    /// running expiration date for index
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Spiderrock.Protobuf.DateKey Expiry {
      get { return expiry_; }
      set {
        expiry_ = value;
      }
    }

    /// <summary>Field number for the "src_timestamp" field.</summary>
    public const int SrcTimestampFieldNumber = 102;
    private long srcTimestamp_;
    /// <summary>
    /// OPRA source timestamp (nanoseconds since epoch)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SrcTimestamp {
      get { return srcTimestamp_; }
      set {
        srcTimestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NationsIndexPrice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NationsIndexPrice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Meta, other.Meta)) return false;
      if (!object.Equals(Pkey, other.Pkey)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MrkPrice, other.MrkPrice)) return false;
      if (!object.Equals(Expiry, other.Expiry)) return false;
      if (SrcTimestamp != other.SrcTimestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Meta_ != null) hash ^= Meta.GetHashCode();
      if (pkey_ != null) hash ^= Pkey.GetHashCode();
      if (MrkPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MrkPrice);
      if (expiry_ != null) hash ^= Expiry.GetHashCode();
      if (SrcTimestamp != 0L) hash ^= SrcTimestamp.GetHashCode();
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
      if (MrkPrice != 0F) {
        output.WriteRawTag(165, 6);
        output.WriteFloat(MrkPrice);
      }
      if (expiry_ != null) {
        output.WriteRawTag(170, 6);
        output.WriteMessage(Expiry);
      }
      if (SrcTimestamp != 0L) {
        output.WriteRawTag(176, 6);
        output.WriteInt64(SrcTimestamp);
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
      if (MrkPrice != 0F) {
        output.WriteRawTag(165, 6);
        output.WriteFloat(MrkPrice);
      }
      if (expiry_ != null) {
        output.WriteRawTag(170, 6);
        output.WriteMessage(Expiry);
      }
      if (SrcTimestamp != 0L) {
        output.WriteRawTag(176, 6);
        output.WriteInt64(SrcTimestamp);
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
      if (MrkPrice != 0F) {
        size += 2 + 4;
      }
      if (expiry_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Expiry);
      }
      if (SrcTimestamp != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(SrcTimestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NationsIndexPrice other) {
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
          Pkey = new global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey();
        }
        Pkey.MergeFrom(other.Pkey);
      }
      if (other.MrkPrice != 0F) {
        MrkPrice = other.MrkPrice;
      }
      if (other.expiry_ != null) {
        if (expiry_ == null) {
          Expiry = new global::Spiderrock.Protobuf.DateKey();
        }
        Expiry.MergeFrom(other.Expiry);
      }
      if (other.SrcTimestamp != 0L) {
        SrcTimestamp = other.SrcTimestamp;
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
              Pkey = new global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 805: {
            MrkPrice = input.ReadFloat();
            break;
          }
          case 810: {
            if (expiry_ == null) {
              Expiry = new global::Spiderrock.Protobuf.DateKey();
            }
            input.ReadMessage(Expiry);
            break;
          }
          case 816: {
            SrcTimestamp = input.ReadInt64();
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
              Pkey = new global::Spiderrock.Protobuf.NationsIndexPrice.Types.PKey();
            }
            input.ReadMessage(Pkey);
            break;
          }
          case 805: {
            MrkPrice = input.ReadFloat();
            break;
          }
          case 810: {
            if (expiry_ == null) {
              Expiry = new global::Spiderrock.Protobuf.DateKey();
            }
            input.ReadMessage(Expiry);
            break;
          }
          case 816: {
            SrcTimestamp = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the NationsIndexPrice message type.</summary>
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
          get { return global::Spiderrock.Protobuf.NationsIndexPrice.Descriptor.NestedTypes[0]; }
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
          ticker_ = other.ticker_ != null ? other.ticker_.Clone() : null;
          name_ = other.name_;
          days_ = other.days_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PKey Clone() {
          return new PKey(this);
        }

        /// <summary>Field number for the "ticker" field.</summary>
        public const int TickerFieldNumber = 10;
        private global::Spiderrock.Protobuf.TickerKey ticker_;
        /// <summary>
        /// underlying stock key that this option expiration attaches to
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Spiderrock.Protobuf.TickerKey Ticker {
          get { return ticker_; }
          set {
            ticker_ = value;
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 11;
        private string name_ = "";
        /// <summary>
        /// Nations Index Name
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "days" field.</summary>
        public const int DaysFieldNumber = 12;
        private int days_;
        /// <summary>
        /// calendar days to expiration (actual/365 days per year)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int Days {
          get { return days_; }
          set {
            days_ = value;
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
          if (!object.Equals(Ticker, other.Ticker)) return false;
          if (Name != other.Name) return false;
          if (Days != other.Days) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (ticker_ != null) hash ^= Ticker.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (Days != 0) hash ^= Days.GetHashCode();
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
          if (ticker_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Ticker);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(Name);
          }
          if (Days != 0) {
            output.WriteRawTag(96);
            output.WriteInt32(Days);
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
          if (ticker_ != null) {
            output.WriteRawTag(82);
            output.WriteMessage(Ticker);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(90);
            output.WriteString(Name);
          }
          if (Days != 0) {
            output.WriteRawTag(96);
            output.WriteInt32(Days);
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
          if (ticker_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ticker);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (Days != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Days);
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
          if (other.ticker_ != null) {
            if (ticker_ == null) {
              Ticker = new global::Spiderrock.Protobuf.TickerKey();
            }
            Ticker.MergeFrom(other.Ticker);
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.Days != 0) {
            Days = other.Days;
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
                if (ticker_ == null) {
                  Ticker = new global::Spiderrock.Protobuf.TickerKey();
                }
                input.ReadMessage(Ticker);
                break;
              }
              case 90: {
                Name = input.ReadString();
                break;
              }
              case 96: {
                Days = input.ReadInt32();
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
                if (ticker_ == null) {
                  Ticker = new global::Spiderrock.Protobuf.TickerKey();
                }
                input.ReadMessage(Ticker);
                break;
              }
              case 90: {
                Name = input.ReadString();
                break;
              }
              case 96: {
                Days = input.ReadInt32();
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
