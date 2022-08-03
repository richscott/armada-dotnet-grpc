// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: pkg/api/submit.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Api {
  public static partial class Submit
  {
    static readonly string __ServiceName = "api.Submit";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.JobSubmitRequest> __Marshaller_api_JobSubmitRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.JobSubmitRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.JobSubmitResponse> __Marshaller_api_JobSubmitResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.JobSubmitResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.JobCancelRequest> __Marshaller_api_JobCancelRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.JobCancelRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.CancellationResult> __Marshaller_api_CancellationResult = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.CancellationResult.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.JobReprioritizeRequest> __Marshaller_api_JobReprioritizeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.JobReprioritizeRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.JobReprioritizeResponse> __Marshaller_api_JobReprioritizeResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.JobReprioritizeResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.Queue> __Marshaller_api_Queue = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.Queue.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.QueueList> __Marshaller_api_QueueList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.QueueList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.BatchQueueCreateResponse> __Marshaller_api_BatchQueueCreateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.BatchQueueCreateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.BatchQueueUpdateResponse> __Marshaller_api_BatchQueueUpdateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.BatchQueueUpdateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.QueueDeleteRequest> __Marshaller_api_QueueDeleteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.QueueDeleteRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.QueueGetRequest> __Marshaller_api_QueueGetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.QueueGetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.QueueInfoRequest> __Marshaller_api_QueueInfoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.QueueInfoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Api.QueueInfo> __Marshaller_api_QueueInfo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Api.QueueInfo.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.JobSubmitRequest, global::Api.JobSubmitResponse> __Method_SubmitJobs = new grpc::Method<global::Api.JobSubmitRequest, global::Api.JobSubmitResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitJobs",
        __Marshaller_api_JobSubmitRequest,
        __Marshaller_api_JobSubmitResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.JobCancelRequest, global::Api.CancellationResult> __Method_CancelJobs = new grpc::Method<global::Api.JobCancelRequest, global::Api.CancellationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CancelJobs",
        __Marshaller_api_JobCancelRequest,
        __Marshaller_api_CancellationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.JobReprioritizeRequest, global::Api.JobReprioritizeResponse> __Method_ReprioritizeJobs = new grpc::Method<global::Api.JobReprioritizeRequest, global::Api.JobReprioritizeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReprioritizeJobs",
        __Marshaller_api_JobReprioritizeRequest,
        __Marshaller_api_JobReprioritizeResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.Queue, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateQueue = new grpc::Method<global::Api.Queue, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateQueue",
        __Marshaller_api_Queue,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.QueueList, global::Api.BatchQueueCreateResponse> __Method_CreateQueues = new grpc::Method<global::Api.QueueList, global::Api.BatchQueueCreateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateQueues",
        __Marshaller_api_QueueList,
        __Marshaller_api_BatchQueueCreateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.Queue, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateQueue = new grpc::Method<global::Api.Queue, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateQueue",
        __Marshaller_api_Queue,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.QueueList, global::Api.BatchQueueUpdateResponse> __Method_UpdateQueues = new grpc::Method<global::Api.QueueList, global::Api.BatchQueueUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateQueues",
        __Marshaller_api_QueueList,
        __Marshaller_api_BatchQueueUpdateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.QueueDeleteRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteQueue = new grpc::Method<global::Api.QueueDeleteRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteQueue",
        __Marshaller_api_QueueDeleteRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.QueueGetRequest, global::Api.Queue> __Method_GetQueue = new grpc::Method<global::Api.QueueGetRequest, global::Api.Queue>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetQueue",
        __Marshaller_api_QueueGetRequest,
        __Marshaller_api_Queue);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Api.QueueInfoRequest, global::Api.QueueInfo> __Method_GetQueueInfo = new grpc::Method<global::Api.QueueInfoRequest, global::Api.QueueInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetQueueInfo",
        __Marshaller_api_QueueInfoRequest,
        __Marshaller_api_QueueInfo);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Api.SubmitReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Submit</summary>
    [grpc::BindServiceMethod(typeof(Submit), "BindService")]
    public abstract partial class SubmitBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.JobSubmitResponse> SubmitJobs(global::Api.JobSubmitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.CancellationResult> CancelJobs(global::Api.JobCancelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.JobReprioritizeResponse> ReprioritizeJobs(global::Api.JobReprioritizeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateQueue(global::Api.Queue request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.BatchQueueCreateResponse> CreateQueues(global::Api.QueueList request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateQueue(global::Api.Queue request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.BatchQueueUpdateResponse> UpdateQueues(global::Api.QueueList request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteQueue(global::Api.QueueDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.Queue> GetQueue(global::Api.QueueGetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Api.QueueInfo> GetQueueInfo(global::Api.QueueInfoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Submit</summary>
    public partial class SubmitClient : grpc::ClientBase<SubmitClient>
    {
      /// <summary>Creates a new client for Submit</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SubmitClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Submit that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SubmitClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SubmitClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SubmitClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.JobSubmitResponse SubmitJobs(global::Api.JobSubmitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitJobs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.JobSubmitResponse SubmitJobs(global::Api.JobSubmitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitJobs, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.JobSubmitResponse> SubmitJobsAsync(global::Api.JobSubmitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitJobsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.JobSubmitResponse> SubmitJobsAsync(global::Api.JobSubmitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitJobs, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.CancellationResult CancelJobs(global::Api.JobCancelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelJobs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.CancellationResult CancelJobs(global::Api.JobCancelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelJobs, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.CancellationResult> CancelJobsAsync(global::Api.JobCancelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelJobsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.CancellationResult> CancelJobsAsync(global::Api.JobCancelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelJobs, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.JobReprioritizeResponse ReprioritizeJobs(global::Api.JobReprioritizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReprioritizeJobs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.JobReprioritizeResponse ReprioritizeJobs(global::Api.JobReprioritizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReprioritizeJobs, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.JobReprioritizeResponse> ReprioritizeJobsAsync(global::Api.JobReprioritizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReprioritizeJobsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.JobReprioritizeResponse> ReprioritizeJobsAsync(global::Api.JobReprioritizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReprioritizeJobs, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CreateQueue(global::Api.Queue request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateQueue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CreateQueue(global::Api.Queue request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CreateQueueAsync(global::Api.Queue request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateQueueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CreateQueueAsync(global::Api.Queue request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.BatchQueueCreateResponse CreateQueues(global::Api.QueueList request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateQueues(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.BatchQueueCreateResponse CreateQueues(global::Api.QueueList request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateQueues, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.BatchQueueCreateResponse> CreateQueuesAsync(global::Api.QueueList request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateQueuesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.BatchQueueCreateResponse> CreateQueuesAsync(global::Api.QueueList request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateQueues, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateQueue(global::Api.Queue request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateQueue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateQueue(global::Api.Queue request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateQueueAsync(global::Api.Queue request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateQueueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateQueueAsync(global::Api.Queue request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.BatchQueueUpdateResponse UpdateQueues(global::Api.QueueList request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateQueues(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.BatchQueueUpdateResponse UpdateQueues(global::Api.QueueList request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateQueues, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.BatchQueueUpdateResponse> UpdateQueuesAsync(global::Api.QueueList request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateQueuesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.BatchQueueUpdateResponse> UpdateQueuesAsync(global::Api.QueueList request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateQueues, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteQueue(global::Api.QueueDeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteQueue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteQueue(global::Api.QueueDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteQueueAsync(global::Api.QueueDeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteQueueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteQueueAsync(global::Api.QueueDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.Queue GetQueue(global::Api.QueueGetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetQueue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.Queue GetQueue(global::Api.QueueGetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.Queue> GetQueueAsync(global::Api.QueueGetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetQueueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.Queue> GetQueueAsync(global::Api.QueueGetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetQueue, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.QueueInfo GetQueueInfo(global::Api.QueueInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetQueueInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Api.QueueInfo GetQueueInfo(global::Api.QueueInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetQueueInfo, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.QueueInfo> GetQueueInfoAsync(global::Api.QueueInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetQueueInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Api.QueueInfo> GetQueueInfoAsync(global::Api.QueueInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetQueueInfo, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SubmitClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SubmitClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SubmitBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SubmitJobs, serviceImpl.SubmitJobs)
          .AddMethod(__Method_CancelJobs, serviceImpl.CancelJobs)
          .AddMethod(__Method_ReprioritizeJobs, serviceImpl.ReprioritizeJobs)
          .AddMethod(__Method_CreateQueue, serviceImpl.CreateQueue)
          .AddMethod(__Method_CreateQueues, serviceImpl.CreateQueues)
          .AddMethod(__Method_UpdateQueue, serviceImpl.UpdateQueue)
          .AddMethod(__Method_UpdateQueues, serviceImpl.UpdateQueues)
          .AddMethod(__Method_DeleteQueue, serviceImpl.DeleteQueue)
          .AddMethod(__Method_GetQueue, serviceImpl.GetQueue)
          .AddMethod(__Method_GetQueueInfo, serviceImpl.GetQueueInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SubmitBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SubmitJobs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.JobSubmitRequest, global::Api.JobSubmitResponse>(serviceImpl.SubmitJobs));
      serviceBinder.AddMethod(__Method_CancelJobs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.JobCancelRequest, global::Api.CancellationResult>(serviceImpl.CancelJobs));
      serviceBinder.AddMethod(__Method_ReprioritizeJobs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.JobReprioritizeRequest, global::Api.JobReprioritizeResponse>(serviceImpl.ReprioritizeJobs));
      serviceBinder.AddMethod(__Method_CreateQueue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.Queue, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateQueue));
      serviceBinder.AddMethod(__Method_CreateQueues, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.QueueList, global::Api.BatchQueueCreateResponse>(serviceImpl.CreateQueues));
      serviceBinder.AddMethod(__Method_UpdateQueue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.Queue, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateQueue));
      serviceBinder.AddMethod(__Method_UpdateQueues, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.QueueList, global::Api.BatchQueueUpdateResponse>(serviceImpl.UpdateQueues));
      serviceBinder.AddMethod(__Method_DeleteQueue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.QueueDeleteRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteQueue));
      serviceBinder.AddMethod(__Method_GetQueue, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.QueueGetRequest, global::Api.Queue>(serviceImpl.GetQueue));
      serviceBinder.AddMethod(__Method_GetQueueInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Api.QueueInfoRequest, global::Api.QueueInfo>(serviceImpl.GetQueueInfo));
    }

  }
}
#endregion
