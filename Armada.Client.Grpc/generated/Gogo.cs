// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: github.com/gogo/protobuf/gogoproto/gogo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Gogoproto {

  /// <summary>Holder for reflection information generated from github.com/gogo/protobuf/gogoproto/gogo.proto</summary>
  public static partial class GogoReflection {

    #region Descriptor
    /// <summary>File descriptor for github.com/gogo/protobuf/gogoproto/gogo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GogoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1naXRodWIuY29tL2dvZ28vcHJvdG9idWYvZ29nb3Byb3RvL2dvZ28ucHJv",
            "dG8SCWdvZ29wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJv",
            "dG86OwoTZ29wcm90b19lbnVtX3ByZWZpeBIcLmdvb2dsZS5wcm90b2J1Zi5F",
            "bnVtT3B0aW9ucxix5AMgASgIOj0KFWdvcHJvdG9fZW51bV9zdHJpbmdlchIc",
            "Lmdvb2dsZS5wcm90b2J1Zi5FbnVtT3B0aW9ucxjF5AMgASgIOjUKDWVudW1f",
            "c3RyaW5nZXISHC5nb29nbGUucHJvdG9idWYuRW51bU9wdGlvbnMYxuQDIAEo",
            "CDo3Cg9lbnVtX2N1c3RvbW5hbWUSHC5nb29nbGUucHJvdG9idWYuRW51bU9w",
            "dGlvbnMYx+QDIAEoCTowCghlbnVtZGVjbBIcLmdvb2dsZS5wcm90b2J1Zi5F",
            "bnVtT3B0aW9ucxjI5AMgASgIOkEKFGVudW12YWx1ZV9jdXN0b21uYW1lEiEu",
            "Z29vZ2xlLnByb3RvYnVmLkVudW1WYWx1ZU9wdGlvbnMY0YMEIAEoCTo7ChNn",
            "b3Byb3RvX2dldHRlcnNfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRp",
            "b25zGJnsAyABKAg6PwoXZ29wcm90b19lbnVtX3ByZWZpeF9hbGwSHC5nb29n",
            "bGUucHJvdG9idWYuRmlsZU9wdGlvbnMYmuwDIAEoCDo8ChRnb3Byb3RvX3N0",
            "cmluZ2VyX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxib7AMg",
            "ASgIOjkKEXZlcmJvc2VfZXF1YWxfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZp",
            "bGVPcHRpb25zGJzsAyABKAg6MAoIZmFjZV9hbGwSHC5nb29nbGUucHJvdG9i",
            "dWYuRmlsZU9wdGlvbnMYnewDIAEoCDo0Cgxnb3N0cmluZ19hbGwSHC5nb29n",
            "bGUucHJvdG9idWYuRmlsZU9wdGlvbnMYnuwDIAEoCDo0Cgxwb3B1bGF0ZV9h",
            "bGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYn+wDIAEoCDo0Cgxz",
            "dHJpbmdlcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYoOwD",
            "IAEoCDozCgtvbmx5b25lX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0",
            "aW9ucxih7AMgASgIOjEKCWVxdWFsX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5G",
            "aWxlT3B0aW9ucxil7AMgASgIOjcKD2Rlc2NyaXB0aW9uX2FsbBIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxim7AMgASgIOjMKC3Rlc3RnZW5fYWxs",
            "EhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGKfsAyABKAg6NAoMYmVu",
            "Y2hnZW5fYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGKjsAyAB",
            "KAg6NQoNbWFyc2hhbGVyX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0",
            "aW9ucxip7AMgASgIOjcKD3VubWFyc2hhbGVyX2FsbBIcLmdvb2dsZS5wcm90",
            "b2J1Zi5GaWxlT3B0aW9ucxiq7AMgASgIOjwKFHN0YWJsZV9tYXJzaGFsZXJf",
            "YWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGKvsAyABKAg6MQoJ",
            "c2l6ZXJfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGKzsAyAB",
            "KAg6QQoZZ29wcm90b19lbnVtX3N0cmluZ2VyX2FsbBIcLmdvb2dsZS5wcm90",
            "b2J1Zi5GaWxlT3B0aW9ucxit7AMgASgIOjkKEWVudW1fc3RyaW5nZXJfYWxs",
            "EhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGK7sAyABKAg6PAoUdW5z",
            "YWZlX21hcnNoYWxlcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlv",
            "bnMYr+wDIAEoCDo+ChZ1bnNhZmVfdW5tYXJzaGFsZXJfYWxsEhwuZ29vZ2xl",
            "LnByb3RvYnVmLkZpbGVPcHRpb25zGLDsAyABKAg6QgoaZ29wcm90b19leHRl",
            "bnNpb25zX21hcF9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMY",
            "sewDIAEoCDpAChhnb3Byb3RvX3VucmVjb2duaXplZF9hbGwSHC5nb29nbGUu",
            "cHJvdG9idWYuRmlsZU9wdGlvbnMYsuwDIAEoCDo4ChBnb2dvcHJvdG9faW1w",
            "b3J0EhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGLPsAyABKAg6NgoO",
            "cHJvdG9zaXplcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMY",
            "tOwDIAEoCDozCgtjb21wYXJlX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxl",
            "T3B0aW9ucxi17AMgASgIOjQKDHR5cGVkZWNsX2FsbBIcLmdvb2dsZS5wcm90",
            "b2J1Zi5GaWxlT3B0aW9ucxi27AMgASgIOjQKDGVudW1kZWNsX2FsbBIcLmdv",
            "b2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxi37AMgASgIOjwKFGdvcHJvdG9f",
            "cmVnaXN0cmF0aW9uEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGLjs",
            "AyABKAg6NwoPbWVzc2FnZW5hbWVfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZp",
            "bGVPcHRpb25zGLnsAyABKAg6PQoVZ29wcm90b19zaXplY2FjaGVfYWxsEhwu",
            "Z29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGLrsAyABKAg6OwoTZ29wcm90",
            "b191bmtleWVkX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxi7",
            "7AMgASgIOjoKD2dvcHJvdG9fZ2V0dGVycxIfLmdvb2dsZS5wcm90b2J1Zi5N",
            "ZXNzYWdlT3B0aW9ucxiB9AMgASgIOjsKEGdvcHJvdG9fc3RyaW5nZXISHy5n",
            "b29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYg/QDIAEoCDo4Cg12ZXJi",
            "b3NlX2VxdWFsEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGIT0",
            "AyABKAg6LwoEZmFjZRIfLmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9u",
            "cxiF9AMgASgIOjMKCGdvc3RyaW5nEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3Nh",
            "Z2VPcHRpb25zGIb0AyABKAg6MwoIcG9wdWxhdGUSHy5nb29nbGUucHJvdG9i",
            "dWYuTWVzc2FnZU9wdGlvbnMYh/QDIAEoCDozCghzdHJpbmdlchIfLmdvb2ds",
            "ZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxjAiwQgASgIOjIKB29ubHlvbmUS",
            "Hy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYifQDIAEoCDowCgVl",
            "cXVhbBIfLmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxiN9AMgASgI",
            "OjYKC2Rlc2NyaXB0aW9uEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRp",
            "b25zGI70AyABKAg6MgoHdGVzdGdlbhIfLmdvb2dsZS5wcm90b2J1Zi5NZXNz",
            "YWdlT3B0aW9ucxiP9AMgASgIOjMKCGJlbmNoZ2VuEh8uZ29vZ2xlLnByb3Rv",
            "YnVmLk1lc3NhZ2VPcHRpb25zGJD0AyABKAg6NAoJbWFyc2hhbGVyEh8uZ29v",
            "Z2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGJH0AyABKAg6NgoLdW5tYXJz",
            "aGFsZXISHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYkvQDIAEo",
            "CDo7ChBzdGFibGVfbWFyc2hhbGVyEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3Nh",
            "Z2VPcHRpb25zGJP0AyABKAg6MAoFc2l6ZXISHy5nb29nbGUucHJvdG9idWYu",
            "TWVzc2FnZU9wdGlvbnMYlPQDIAEoCDo7ChB1bnNhZmVfbWFyc2hhbGVyEh8u",
            "Z29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGJf0AyABKAg6PQoSdW5z",
            "YWZlX3VubWFyc2hhbGVyEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRp",
            "b25zGJj0AyABKAg6QQoWZ29wcm90b19leHRlbnNpb25zX21hcBIfLmdvb2ds",
            "ZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxiZ9AMgASgIOj8KFGdvcHJvdG9f",
            "dW5yZWNvZ25pemVkEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25z",
            "GJr0AyABKAg6NQoKcHJvdG9zaXplchIfLmdvb2dsZS5wcm90b2J1Zi5NZXNz",
            "YWdlT3B0aW9ucxic9AMgASgIOjIKB2NvbXBhcmUSHy5nb29nbGUucHJvdG9i",
            "dWYuTWVzc2FnZU9wdGlvbnMYnfQDIAEoCDozCgh0eXBlZGVjbBIfLmdvb2ds",
            "ZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxie9AMgASgIOjYKC21lc3NhZ2Vu",
            "YW1lEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGKH0AyABKAg6",
            "PAoRZ29wcm90b19zaXplY2FjaGUSHy5nb29nbGUucHJvdG9idWYuTWVzc2Fn",
            "ZU9wdGlvbnMYovQDIAEoCDo6Cg9nb3Byb3RvX3Vua2V5ZWQSHy5nb29nbGUu",
            "cHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYo/QDIAEoCDoxCghudWxsYWJsZRId",
            "Lmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY6fsDIAEoCDouCgVlbWJl",
            "ZBIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY6vsDIAEoCDozCgpj",
            "dXN0b210eXBlEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxjr+wMg",
            "ASgJOjMKCmN1c3RvbW5hbWUSHS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRp",
            "b25zGOz7AyABKAk6MAoHanNvbnRhZxIdLmdvb2dsZS5wcm90b2J1Zi5GaWVs",
            "ZE9wdGlvbnMY7fsDIAEoCToxCghtb3JldGFncxIdLmdvb2dsZS5wcm90b2J1",
            "Zi5GaWVsZE9wdGlvbnMY7vsDIAEoCToxCghjYXN0dHlwZRIdLmdvb2dsZS5w",
            "cm90b2J1Zi5GaWVsZE9wdGlvbnMY7/sDIAEoCTowCgdjYXN0a2V5Eh0uZ29v",
            "Z2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxjw+wMgASgJOjIKCWNhc3R2YWx1",
            "ZRIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY8fsDIAEoCTowCgdz",
            "dGR0aW1lEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxjy+wMgASgI",
            "OjQKC3N0ZGR1cmF0aW9uEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9u",
            "cxjz+wMgASgIOjMKCndrdHBvaW50ZXISHS5nb29nbGUucHJvdG9idWYuRmll",
            "bGRPcHRpb25zGPT7AyABKAhCRQoTY29tLmdvb2dsZS5wcm90b2J1ZkIKR29H",
            "b1Byb3Rvc1oiZ2l0aHViLmNvbS9nb2dvL3Byb3RvYnVmL2dvZ29wcm90bw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { GogoExtensions.GoprotoEnumPrefix, GogoExtensions.GoprotoEnumStringer, GogoExtensions.EnumStringer, GogoExtensions.EnumCustomname, GogoExtensions.Enumdecl, GogoExtensions.EnumvalueCustomname, GogoExtensions.GoprotoGettersAll, GogoExtensions.GoprotoEnumPrefixAll, GogoExtensions.GoprotoStringerAll, GogoExtensions.VerboseEqualAll, GogoExtensions.FaceAll, GogoExtensions.GostringAll, GogoExtensions.PopulateAll, GogoExtensions.StringerAll, GogoExtensions.OnlyoneAll, GogoExtensions.EqualAll, GogoExtensions.DescriptionAll, GogoExtensions.TestgenAll, GogoExtensions.BenchgenAll, GogoExtensions.MarshalerAll, GogoExtensions.UnmarshalerAll, GogoExtensions.StableMarshalerAll, GogoExtensions.SizerAll, GogoExtensions.GoprotoEnumStringerAll, GogoExtensions.EnumStringerAll, GogoExtensions.UnsafeMarshalerAll, GogoExtensions.UnsafeUnmarshalerAll, GogoExtensions.GoprotoExtensionsMapAll, GogoExtensions.GoprotoUnrecognizedAll, GogoExtensions.GogoprotoImport, GogoExtensions.ProtosizerAll, GogoExtensions.CompareAll, GogoExtensions.TypedeclAll, GogoExtensions.EnumdeclAll, GogoExtensions.GoprotoRegistration, GogoExtensions.MessagenameAll, GogoExtensions.GoprotoSizecacheAll, GogoExtensions.GoprotoUnkeyedAll, GogoExtensions.GoprotoGetters, GogoExtensions.GoprotoStringer, GogoExtensions.VerboseEqual, GogoExtensions.Face, GogoExtensions.Gostring, GogoExtensions.Populate, GogoExtensions.Stringer, GogoExtensions.Onlyone, GogoExtensions.Equal, GogoExtensions.Description, GogoExtensions.Testgen, GogoExtensions.Benchgen, GogoExtensions.Marshaler, GogoExtensions.Unmarshaler, GogoExtensions.StableMarshaler, GogoExtensions.Sizer, GogoExtensions.UnsafeMarshaler, GogoExtensions.UnsafeUnmarshaler, GogoExtensions.GoprotoExtensionsMap, GogoExtensions.GoprotoUnrecognized, GogoExtensions.Protosizer, GogoExtensions.Compare, GogoExtensions.Typedecl, GogoExtensions.Messagename, GogoExtensions.GoprotoSizecache, GogoExtensions.GoprotoUnkeyed, GogoExtensions.Nullable, GogoExtensions.Embed, GogoExtensions.Customtype, GogoExtensions.Customname, GogoExtensions.Jsontag, GogoExtensions.Moretags, GogoExtensions.Casttype, GogoExtensions.Castkey, GogoExtensions.Castvalue, GogoExtensions.Stdtime, GogoExtensions.Stdduration, GogoExtensions.Wktpointer }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of github.com/gogo/protobuf/gogoproto/gogo.proto</summary>
  public static partial class GogoExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> GoprotoEnumPrefix =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62001, pb::FieldCodec.ForBool(496008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> GoprotoEnumStringer =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62021, pb::FieldCodec.ForBool(496168, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> EnumStringer =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62022, pb::FieldCodec.ForBool(496176, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, string> EnumCustomname =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, string>(62023, pb::FieldCodec.ForString(496186, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> Enumdecl =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62024, pb::FieldCodec.ForBool(496192, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumValueOptions, string> EnumvalueCustomname =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumValueOptions, string>(66001, pb::FieldCodec.ForString(528010, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoGettersAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63001, pb::FieldCodec.ForBool(504008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoEnumPrefixAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63002, pb::FieldCodec.ForBool(504016, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoStringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63003, pb::FieldCodec.ForBool(504024, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> VerboseEqualAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63004, pb::FieldCodec.ForBool(504032, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> FaceAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63005, pb::FieldCodec.ForBool(504040, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GostringAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63006, pb::FieldCodec.ForBool(504048, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> PopulateAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63007, pb::FieldCodec.ForBool(504056, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> StringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63008, pb::FieldCodec.ForBool(504064, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> OnlyoneAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63009, pb::FieldCodec.ForBool(504072, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> EqualAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63013, pb::FieldCodec.ForBool(504104, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> DescriptionAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63014, pb::FieldCodec.ForBool(504112, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> TestgenAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63015, pb::FieldCodec.ForBool(504120, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> BenchgenAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63016, pb::FieldCodec.ForBool(504128, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> MarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63017, pb::FieldCodec.ForBool(504136, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> UnmarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63018, pb::FieldCodec.ForBool(504144, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> StableMarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63019, pb::FieldCodec.ForBool(504152, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> SizerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63020, pb::FieldCodec.ForBool(504160, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoEnumStringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63021, pb::FieldCodec.ForBool(504168, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> EnumStringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63022, pb::FieldCodec.ForBool(504176, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> UnsafeMarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63023, pb::FieldCodec.ForBool(504184, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> UnsafeUnmarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63024, pb::FieldCodec.ForBool(504192, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoExtensionsMapAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63025, pb::FieldCodec.ForBool(504200, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoUnrecognizedAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63026, pb::FieldCodec.ForBool(504208, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GogoprotoImport =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63027, pb::FieldCodec.ForBool(504216, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> ProtosizerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63028, pb::FieldCodec.ForBool(504224, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> CompareAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63029, pb::FieldCodec.ForBool(504232, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> TypedeclAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63030, pb::FieldCodec.ForBool(504240, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> EnumdeclAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63031, pb::FieldCodec.ForBool(504248, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoRegistration =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63032, pb::FieldCodec.ForBool(504256, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> MessagenameAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63033, pb::FieldCodec.ForBool(504264, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoSizecacheAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63034, pb::FieldCodec.ForBool(504272, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoUnkeyedAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63035, pb::FieldCodec.ForBool(504280, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoGetters =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64001, pb::FieldCodec.ForBool(512008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoStringer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64003, pb::FieldCodec.ForBool(512024, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> VerboseEqual =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64004, pb::FieldCodec.ForBool(512032, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Face =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64005, pb::FieldCodec.ForBool(512040, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Gostring =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64006, pb::FieldCodec.ForBool(512048, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Populate =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64007, pb::FieldCodec.ForBool(512056, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Stringer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(67008, pb::FieldCodec.ForBool(536064, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Onlyone =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64009, pb::FieldCodec.ForBool(512072, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Equal =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64013, pb::FieldCodec.ForBool(512104, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Description =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64014, pb::FieldCodec.ForBool(512112, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Testgen =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64015, pb::FieldCodec.ForBool(512120, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Benchgen =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64016, pb::FieldCodec.ForBool(512128, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Marshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64017, pb::FieldCodec.ForBool(512136, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Unmarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64018, pb::FieldCodec.ForBool(512144, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> StableMarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64019, pb::FieldCodec.ForBool(512152, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Sizer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64020, pb::FieldCodec.ForBool(512160, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> UnsafeMarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64023, pb::FieldCodec.ForBool(512184, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> UnsafeUnmarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64024, pb::FieldCodec.ForBool(512192, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoExtensionsMap =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64025, pb::FieldCodec.ForBool(512200, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoUnrecognized =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64026, pb::FieldCodec.ForBool(512208, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Protosizer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64028, pb::FieldCodec.ForBool(512224, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Compare =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64029, pb::FieldCodec.ForBool(512232, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Typedecl =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64030, pb::FieldCodec.ForBool(512240, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Messagename =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64033, pb::FieldCodec.ForBool(512264, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoSizecache =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64034, pb::FieldCodec.ForBool(512272, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoUnkeyed =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64035, pb::FieldCodec.ForBool(512280, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Nullable =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65001, pb::FieldCodec.ForBool(520008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Embed =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65002, pb::FieldCodec.ForBool(520016, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Customtype =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65003, pb::FieldCodec.ForString(520026, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Customname =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65004, pb::FieldCodec.ForString(520034, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Jsontag =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65005, pb::FieldCodec.ForString(520042, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Moretags =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65006, pb::FieldCodec.ForString(520050, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Casttype =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65007, pb::FieldCodec.ForString(520058, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Castkey =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65008, pb::FieldCodec.ForString(520066, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Castvalue =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65009, pb::FieldCodec.ForString(520074, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Stdtime =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65010, pb::FieldCodec.ForBool(520080, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Stdduration =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65011, pb::FieldCodec.ForBool(520088, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Wktpointer =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65012, pb::FieldCodec.ForBool(520096, false));
  }

}

#endregion Designer generated code
