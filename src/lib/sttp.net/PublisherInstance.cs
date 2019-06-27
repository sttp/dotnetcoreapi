//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace sttp {

public class PublisherInstance : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal PublisherInstance(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PublisherInstance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PublisherInstance() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          CommonPINVOKE.delete_PublisherInstance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  protected virtual void StatusMessage(string message) {
    if (SwigDerivedClassHasMethod("StatusMessage", swigMethodTypes0)) CommonPINVOKE.PublisherInstance_StatusMessageSwigExplicitPublisherInstance(swigCPtr, message); else CommonPINVOKE.PublisherInstance_StatusMessage(swigCPtr, message);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void ErrorMessage(string message) {
    if (SwigDerivedClassHasMethod("ErrorMessage", swigMethodTypes1)) CommonPINVOKE.PublisherInstance_ErrorMessageSwigExplicitPublisherInstance(swigCPtr, message); else CommonPINVOKE.PublisherInstance_ErrorMessage(swigCPtr, message);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void ClientConnected(SubscriberConnection connection) {
    if (SwigDerivedClassHasMethod("ClientConnected", swigMethodTypes2)) CommonPINVOKE.PublisherInstance_ClientConnectedSwigExplicitPublisherInstance(swigCPtr, SubscriberConnection.getCPtr(connection)); else CommonPINVOKE.PublisherInstance_ClientConnected(swigCPtr, SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void ClientDisconnected(SubscriberConnection connection) {
    if (SwigDerivedClassHasMethod("ClientDisconnected", swigMethodTypes3)) CommonPINVOKE.PublisherInstance_ClientDisconnectedSwigExplicitPublisherInstance(swigCPtr, SubscriberConnection.getCPtr(connection)); else CommonPINVOKE.PublisherInstance_ClientDisconnected(swigCPtr, SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void ProcessingIntervalChangeRequested(SubscriberConnection connection) {
    if (SwigDerivedClassHasMethod("ProcessingIntervalChangeRequested", swigMethodTypes4)) CommonPINVOKE.PublisherInstance_ProcessingIntervalChangeRequestedSwigExplicitPublisherInstance(swigCPtr, SubscriberConnection.getCPtr(connection)); else CommonPINVOKE.PublisherInstance_ProcessingIntervalChangeRequested(swigCPtr, SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void TemporalSubscriptionRequested(SubscriberConnection connection) {
    if (SwigDerivedClassHasMethod("TemporalSubscriptionRequested", swigMethodTypes5)) CommonPINVOKE.PublisherInstance_TemporalSubscriptionRequestedSwigExplicitPublisherInstance(swigCPtr, SubscriberConnection.getCPtr(connection)); else CommonPINVOKE.PublisherInstance_TemporalSubscriptionRequested(swigCPtr, SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void TemporalSubscriptionCanceled(SubscriberConnection connection) {
    if (SwigDerivedClassHasMethod("TemporalSubscriptionCanceled", swigMethodTypes6)) CommonPINVOKE.PublisherInstance_TemporalSubscriptionCanceledSwigExplicitPublisherInstance(swigCPtr, SubscriberConnection.getCPtr(connection)); else CommonPINVOKE.PublisherInstance_TemporalSubscriptionCanceled(swigCPtr, SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void HandleUserCommand(SubscriberConnection connection, uint command, ByteBuffer buffer) {
    if (SwigDerivedClassHasMethod("HandleUserCommand", swigMethodTypes7)) CommonPINVOKE.PublisherInstance_HandleUserCommandSwigExplicitPublisherInstance(swigCPtr, SubscriberConnection.getCPtr(connection), command, ByteBuffer.getCPtr(buffer)); else CommonPINVOKE.PublisherInstance_HandleUserCommand(swigCPtr, SubscriberConnection.getCPtr(connection), command, ByteBuffer.getCPtr(buffer));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  protected PublisherInstance() : this(CommonPINVOKE.new_PublisherInstance(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public void DefineMetadata(DeviceMetadataCollection deviceMetadata, MeasurementMetadataCollection measurementMetadata, PhasorMetadataCollection phasorMetadata, int versionNumber) {
    CommonPINVOKE.PublisherInstance_DefineMetadata__SWIG_0(swigCPtr, DeviceMetadataCollection.getCPtr(deviceMetadata), MeasurementMetadataCollection.getCPtr(measurementMetadata), PhasorMetadataCollection.getCPtr(phasorMetadata), versionNumber);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DefineMetadata(DeviceMetadataCollection deviceMetadata, MeasurementMetadataCollection measurementMetadata, PhasorMetadataCollection phasorMetadata) {
    CommonPINVOKE.PublisherInstance_DefineMetadata__SWIG_1(swigCPtr, DeviceMetadataCollection.getCPtr(deviceMetadata), MeasurementMetadataCollection.getCPtr(measurementMetadata), PhasorMetadataCollection.getCPtr(phasorMetadata));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DefineMetadata(DataSet metadata) {
    CommonPINVOKE.PublisherInstance_DefineMetadata__SWIG_2(swigCPtr, DataSet.getCPtr(metadata));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public DataSet GetMetadata() {
    global::System.IntPtr cPtr = CommonPINVOKE.PublisherInstance_GetMetadata(swigCPtr);
    DataSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataSet(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DataSet GetFilteringMetadata() {
    global::System.IntPtr cPtr = CommonPINVOKE.PublisherInstance_GetFilteringMetadata(swigCPtr);
    DataSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataSet(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MeasurementMetadataCollection FilterMetadata(string filterExpression) {
    MeasurementMetadataCollection ret = new MeasurementMetadataCollection(CommonPINVOKE.PublisherInstance_FilterMetadata(swigCPtr, filterExpression), true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Start(ushort port, bool ipV6) {
    bool ret = (SwigDerivedClassHasMethod("Start", swigMethodTypes8) ? CommonPINVOKE.PublisherInstance_StartSwigExplicitPublisherInstance__SWIG_0(swigCPtr, port, ipV6) : CommonPINVOKE.PublisherInstance_Start__SWIG_0(swigCPtr, port, ipV6));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Start(ushort port) {
    bool ret = (SwigDerivedClassHasMethod("Start", swigMethodTypes9) ? CommonPINVOKE.PublisherInstance_StartSwigExplicitPublisherInstance__SWIG_1(swigCPtr, port) : CommonPINVOKE.PublisherInstance_Start__SWIG_1(swigCPtr, port));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Start(string networkInterfaceIP, ushort port) {
    bool ret = (SwigDerivedClassHasMethod("Start", swigMethodTypes10) ? CommonPINVOKE.PublisherInstance_StartSwigExplicitPublisherInstance__SWIG_2(swigCPtr, networkInterfaceIP, port) : CommonPINVOKE.PublisherInstance_Start__SWIG_2(swigCPtr, networkInterfaceIP, port));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Stop() {
    if (SwigDerivedClassHasMethod("Stop", swigMethodTypes11)) CommonPINVOKE.PublisherInstance_StopSwigExplicitPublisherInstance(swigCPtr); else CommonPINVOKE.PublisherInstance_Stop(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsStarted() {
    bool ret = CommonPINVOKE.PublisherInstance_IsStarted(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void PublishMeasurements(SimpleMeasurement measurements, int count) {
    CommonPINVOKE.PublisherInstance_PublishMeasurements(swigCPtr, SimpleMeasurement.getCPtr(measurements), count);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private System.Guid GetNodeID() {
      global::System.IntPtr cPtr = CommonPINVOKE.PublisherInstance_GetNodeID(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (guid_t tempGuid = (cPtr == global::System.IntPtr.Zero) ? null : new guid_t(cPtr, false)) {
        byte[] data = new byte[16];
        Common.GetGuidBytes(tempGuid, data);
        return new System.Guid(data);
      }
    }

  private void SetNodeID(System.Guid nodeID) {
    guid_t tempnodeID = Common.ParseGuid(nodeID.ToByteArray(), true);
    {
      CommonPINVOKE.PublisherInstance_SetNodeID(swigCPtr, guid_t.getCPtr(tempnodeID));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    }
  }

  private SecurityMode GetSecurityMode() {
    SecurityMode ret = (SecurityMode)CommonPINVOKE.PublisherInstance_GetSecurityMode(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetSecurityMode(SecurityMode securityMode) {
    CommonPINVOKE.PublisherInstance_SetSecurityMode(swigCPtr, (int)securityMode);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private int GetMaximumAllowedConnections() {
    int ret = CommonPINVOKE.PublisherInstance_GetMaximumAllowedConnections(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetMaximumAllowedConnections(int value) {
    CommonPINVOKE.PublisherInstance_SetMaximumAllowedConnections(swigCPtr, value);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private bool IsMetadataRefreshAllowed() {
    bool ret = CommonPINVOKE.PublisherInstance_IsMetadataRefreshAllowed(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetMetadataRefreshAllowed(bool allowed) {
    CommonPINVOKE.PublisherInstance_SetMetadataRefreshAllowed(swigCPtr, allowed);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private bool IsNaNValueFilterAllowed() {
    bool ret = CommonPINVOKE.PublisherInstance_IsNaNValueFilterAllowed(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetNaNValueFilterAllowed(bool allowed) {
    CommonPINVOKE.PublisherInstance_SetNaNValueFilterAllowed(swigCPtr, allowed);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private bool IsNaNValueFilterForced() {
    bool ret = CommonPINVOKE.PublisherInstance_IsNaNValueFilterForced(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetNaNValueFilterForced(bool forced) {
    CommonPINVOKE.PublisherInstance_SetNaNValueFilterForced(swigCPtr, forced);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private bool GetSupportsTemporalSubscriptions() {
    bool ret = CommonPINVOKE.PublisherInstance_GetSupportsTemporalSubscriptions(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetSupportsTemporalSubscriptions(bool value) {
    CommonPINVOKE.PublisherInstance_SetSupportsTemporalSubscriptions(swigCPtr, value);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint GetCipherKeyRotationPeriod() {
    uint ret = CommonPINVOKE.PublisherInstance_GetCipherKeyRotationPeriod(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SetCipherKeyRotationPeriod(uint period) {
    CommonPINVOKE.PublisherInstance_SetCipherKeyRotationPeriod(swigCPtr, period);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort GetPort() {
    ushort ret = CommonPINVOKE.PublisherInstance_GetPort(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsIPv6() {
    bool ret = CommonPINVOKE.PublisherInstance_IsIPv6(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalCommandChannelBytesSent() {
    ulong ret = CommonPINVOKE.PublisherInstance_GetTotalCommandChannelBytesSent(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalDataChannelBytesSent() {
    ulong ret = CommonPINVOKE.PublisherInstance_GetTotalDataChannelBytesSent(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalMeasurementsSent() {
    ulong ret = CommonPINVOKE.PublisherInstance_GetTotalMeasurementsSent(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool TryGetSubscriberConnections(SubscriberConnectionCollection subscriberConnections) {
    bool ret = CommonPINVOKE.PublisherInstance_TryGetSubscriberConnections(swigCPtr, SubscriberConnectionCollection.getCPtr(subscriberConnections));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DisconnectSubscriber(SubscriberConnection connection) {
    CommonPINVOKE.PublisherInstance_DisconnectSubscriber__SWIG_0(swigCPtr, SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DisconnectSubscriber(System.Guid instanceID) {
    guid_t tempinstanceID = Common.ParseGuid(instanceID.ToByteArray(), true);
    {
      CommonPINVOKE.PublisherInstance_DisconnectSubscriber__SWIG_1(swigCPtr, guid_t.getCPtr(tempinstanceID));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    }
  }

        // Gets or sets node ID that defines a unique identification for the publisher
        // instance that gets included in published metadata so that clients can easily
        // distinguish the source of the measurements
        public System.Guid NodeID
        {
            get => GetNodeID();
            set => SetNodeID(value);
        }

        public SecurityMode SecurityMode
        {
            get => GetSecurityMode();
            set => SetSecurityMode(value);
        }

        public int MaximumAllowedConnections
        {
            get => GetMaximumAllowedConnections();
            set => SetMaximumAllowedConnections(value);
        }

        public bool MetadataRefreshAllowed
        {
            get => IsMetadataRefreshAllowed();
            set => SetMetadataRefreshAllowed(value);
        }

        public bool NaNValueFilterAllowed
        {
            get => IsNaNValueFilterAllowed();
            set => SetNaNValueFilterAllowed(value);
        }

        public bool NaNValueFilterForced
        {
            get => IsNaNValueFilterForced();
            set => SetNaNValueFilterForced(value);
        }

        public bool SupportsTemporalSubscriptions
        {
            get => GetSupportsTemporalSubscriptions();
            set => SetSupportsTemporalSubscriptions(value);
        }

        public uint CipherKeyRotationPeriod
        {
            get => GetCipherKeyRotationPeriod();
            set => SetCipherKeyRotationPeriod(value);
        }

        [System.Runtime.InteropServices.DllImport("sttp.net.lib.dll", EntryPoint="CSharp_sttp_PublisherInstance_PublishMeasurements")]
        private static extern unsafe void InvokePublishMeasurements(System.Runtime.InteropServices.HandleRef publisherInstancePtr, Measurement* measurements, int length);

        public unsafe void PublishMeasurements(Measurement[] measurements)
        {
            fixed (Measurement* measurementsPtr = measurements)
                InvokePublishMeasurements(swigCPtr, measurementsPtr, measurements.Length);

            if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
        }

        public void PublishMeasurements(System.Collections.Generic.IEnumerable<Measurement> measurements) => PublishMeasurements(System.Linq.Enumerable.ToArray(measurements));
    
  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("StatusMessage", swigMethodTypes0))
      swigDelegate0 = new SwigDelegatePublisherInstance_0(SwigDirectorMethodStatusMessage);
    if (SwigDerivedClassHasMethod("ErrorMessage", swigMethodTypes1))
      swigDelegate1 = new SwigDelegatePublisherInstance_1(SwigDirectorMethodErrorMessage);
    if (SwigDerivedClassHasMethod("ClientConnected", swigMethodTypes2))
      swigDelegate2 = new SwigDelegatePublisherInstance_2(SwigDirectorMethodClientConnected);
    if (SwigDerivedClassHasMethod("ClientDisconnected", swigMethodTypes3))
      swigDelegate3 = new SwigDelegatePublisherInstance_3(SwigDirectorMethodClientDisconnected);
    if (SwigDerivedClassHasMethod("ProcessingIntervalChangeRequested", swigMethodTypes4))
      swigDelegate4 = new SwigDelegatePublisherInstance_4(SwigDirectorMethodProcessingIntervalChangeRequested);
    if (SwigDerivedClassHasMethod("TemporalSubscriptionRequested", swigMethodTypes5))
      swigDelegate5 = new SwigDelegatePublisherInstance_5(SwigDirectorMethodTemporalSubscriptionRequested);
    if (SwigDerivedClassHasMethod("TemporalSubscriptionCanceled", swigMethodTypes6))
      swigDelegate6 = new SwigDelegatePublisherInstance_6(SwigDirectorMethodTemporalSubscriptionCanceled);
    if (SwigDerivedClassHasMethod("HandleUserCommand", swigMethodTypes7))
      swigDelegate7 = new SwigDelegatePublisherInstance_7(SwigDirectorMethodHandleUserCommand);
    if (SwigDerivedClassHasMethod("Start", swigMethodTypes8))
      swigDelegate8 = new SwigDelegatePublisherInstance_8(SwigDirectorMethodStart__SWIG_0);
    if (SwigDerivedClassHasMethod("Start", swigMethodTypes9))
      swigDelegate9 = new SwigDelegatePublisherInstance_9(SwigDirectorMethodStart__SWIG_1);
    if (SwigDerivedClassHasMethod("Start", swigMethodTypes10))
      swigDelegate10 = new SwigDelegatePublisherInstance_10(SwigDirectorMethodStart__SWIG_2);
    if (SwigDerivedClassHasMethod("Stop", swigMethodTypes11))
      swigDelegate11 = new SwigDelegatePublisherInstance_11(SwigDirectorMethodStop);
    CommonPINVOKE.PublisherInstance_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(PublisherInstance));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodStatusMessage(string message) {
    StatusMessage(message);
  }

  private void SwigDirectorMethodErrorMessage(string message) {
    ErrorMessage(message);
  }

  private void SwigDirectorMethodClientConnected(global::System.IntPtr connection) {
    ClientConnected((connection == global::System.IntPtr.Zero) ? null : new SubscriberConnection(connection, true));
  }

  private void SwigDirectorMethodClientDisconnected(global::System.IntPtr connection) {
    ClientDisconnected((connection == global::System.IntPtr.Zero) ? null : new SubscriberConnection(connection, true));
  }

  private void SwigDirectorMethodProcessingIntervalChangeRequested(global::System.IntPtr connection) {
    ProcessingIntervalChangeRequested((connection == global::System.IntPtr.Zero) ? null : new SubscriberConnection(connection, true));
  }

  private void SwigDirectorMethodTemporalSubscriptionRequested(global::System.IntPtr connection) {
    TemporalSubscriptionRequested((connection == global::System.IntPtr.Zero) ? null : new SubscriberConnection(connection, true));
  }

  private void SwigDirectorMethodTemporalSubscriptionCanceled(global::System.IntPtr connection) {
    TemporalSubscriptionCanceled((connection == global::System.IntPtr.Zero) ? null : new SubscriberConnection(connection, true));
  }

  private void SwigDirectorMethodHandleUserCommand(global::System.IntPtr connection, uint command, global::System.IntPtr buffer) {
    HandleUserCommand((connection == global::System.IntPtr.Zero) ? null : new SubscriberConnection(connection, true), command, new ByteBuffer(buffer, false));
  }

  private bool SwigDirectorMethodStart__SWIG_0(ushort port, bool ipV6) {
    return Start(port, ipV6);
  }

  private bool SwigDirectorMethodStart__SWIG_1(ushort port) {
    return Start(port);
  }

  private bool SwigDirectorMethodStart__SWIG_2(string networkInterfaceIP, ushort port) {
    return Start(networkInterfaceIP, port);
  }

  private void SwigDirectorMethodStop() {
    Stop();
  }

  public delegate void SwigDelegatePublisherInstance_0(string message);
  public delegate void SwigDelegatePublisherInstance_1(string message);
  public delegate void SwigDelegatePublisherInstance_2(global::System.IntPtr connection);
  public delegate void SwigDelegatePublisherInstance_3(global::System.IntPtr connection);
  public delegate void SwigDelegatePublisherInstance_4(global::System.IntPtr connection);
  public delegate void SwigDelegatePublisherInstance_5(global::System.IntPtr connection);
  public delegate void SwigDelegatePublisherInstance_6(global::System.IntPtr connection);
  public delegate void SwigDelegatePublisherInstance_7(global::System.IntPtr connection, uint command, global::System.IntPtr buffer);
  public delegate bool SwigDelegatePublisherInstance_8(ushort port, bool ipV6);
  public delegate bool SwigDelegatePublisherInstance_9(ushort port);
  public delegate bool SwigDelegatePublisherInstance_10(string networkInterfaceIP, ushort port);
  public delegate void SwigDelegatePublisherInstance_11();

  private SwigDelegatePublisherInstance_0 swigDelegate0;
  private SwigDelegatePublisherInstance_1 swigDelegate1;
  private SwigDelegatePublisherInstance_2 swigDelegate2;
  private SwigDelegatePublisherInstance_3 swigDelegate3;
  private SwigDelegatePublisherInstance_4 swigDelegate4;
  private SwigDelegatePublisherInstance_5 swigDelegate5;
  private SwigDelegatePublisherInstance_6 swigDelegate6;
  private SwigDelegatePublisherInstance_7 swigDelegate7;
  private SwigDelegatePublisherInstance_8 swigDelegate8;
  private SwigDelegatePublisherInstance_9 swigDelegate9;
  private SwigDelegatePublisherInstance_10 swigDelegate10;
  private SwigDelegatePublisherInstance_11 swigDelegate11;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(SubscriberConnection) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(SubscriberConnection) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(SubscriberConnection) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(SubscriberConnection) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(SubscriberConnection) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(SubscriberConnection), typeof(uint), typeof(ByteBuffer) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(ushort), typeof(bool) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(ushort) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(string), typeof(ushort) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] {  };
}

}