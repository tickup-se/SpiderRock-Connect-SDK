# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/AutoHedgeSymbol.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n#ClientTrading/AutoHedgeSymbol.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xb3\x06\n\x0f\x41utoHedgeSymbol\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x37\n\x04pkey\x18\x02 \x01(\x0b\x32).spiderrock.protobuf.AutoHedgeSymbol.PKey\x12.\n\x06ticker\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x13\n\x0bticker_desc\x18g \x01(\t\x12\x35\n\rhedge_sec_key\x18j \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x38\n\x0ehedge_sec_type\x18m \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x38\n\x13\x65\x61rly_session_close\x18\x81\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x36\n\x11reg_session_close\x18\x82\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x37\n\x12late_session_close\x18\x83\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x33\n\x0fis_hedge_sec_oK\x18y \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x17\n\x0fhedge_sec_error\x18| \x01(\t\x12\x17\n\x0ehedge_uMid_prc\x18\x80\x01 \x01(\x01\x12-\n\ttimestamp\x18\x7f \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\xba\x01\n\x04PKey\x12\x36\n\x0etarget_sec_key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x39\n\x0ftarget_sec_type\x18\x0b \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12?\n\x11hedge_target_type\x18\x0c \x01(\x0e\x32$.spiderrock.protobuf.HedgeTargetTypeb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.AutoHedgeSymbol_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_AUTOHEDGESYMBOL']._serialized_start=119
  _globals['_AUTOHEDGESYMBOL']._serialized_end=938
  _globals['_AUTOHEDGESYMBOL_PKEY']._serialized_start=752
  _globals['_AUTOHEDGESYMBOL_PKEY']._serialized_end=938
# @@protoc_insertion_point(module_scope)
