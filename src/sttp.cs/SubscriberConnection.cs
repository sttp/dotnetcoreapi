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

public class SubscriberConnection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal SubscriberConnection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SubscriberConnection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SubscriberConnection() {
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
          CommonPINVOKE.delete_SubscriberConnection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.Guid GetSubscriberID() {
      global::System.IntPtr cPtr = CommonPINVOKE.SubscriberConnection_GetSubscriberID(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (guid_t tempGuid = (cPtr == global::System.IntPtr.Zero) ? null : new guid_t(cPtr, false)) {
        byte[] data = new byte[16];
        Common.GetGuidBytes(tempGuid, data);
        return new System.Guid(data);
      }
    }

  public System.Guid GetInstanceID() {
      global::System.IntPtr cPtr = CommonPINVOKE.SubscriberConnection_GetInstanceID(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (guid_t tempGuid = (cPtr == global::System.IntPtr.Zero) ? null : new guid_t(cPtr, false)) {
        byte[] data = new byte[16];
        Common.GetGuidBytes(tempGuid, data);
        return new System.Guid(data);
      }
    }

  public string GetConnectionID() {
    string ret = CommonPINVOKE.SubscriberConnection_GetConnectionID(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetHostName() {
    string ret = CommonPINVOKE.SubscriberConnection_GetHostName(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetOperationalModes() {
    uint ret = CommonPINVOKE.SubscriberConnection_GetOperationalModes(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetEncoding() {
    uint ret = CommonPINVOKE.SubscriberConnection_GetEncoding(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIsTemporalSubscription() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetIsTemporalSubscription(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public System.DateTime GetStartTimeConstraint() {
      global::System.IntPtr cPtr = CommonPINVOKE.SubscriberConnection_GetStartTimeConstraint(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (datetime_t tempDate = (cPtr == global::System.IntPtr.Zero) ? null : new datetime_t(cPtr, false)) {
        return new System.DateTime(Common.ToTicks(tempDate));
      }
    }

  public System.DateTime GetStopTimeConstraint() {
      global::System.IntPtr cPtr = CommonPINVOKE.SubscriberConnection_GetStopTimeConstraint(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (datetime_t tempDate = (cPtr == global::System.IntPtr.Zero) ? null : new datetime_t(cPtr, false)) {
        return new System.DateTime(Common.ToTicks(tempDate));
      }
    }

  public int GetProcessingInterval() {
    int ret = CommonPINVOKE.SubscriberConnection_GetProcessingInterval(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetUsingPayloadCompression() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetUsingPayloadCompression(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetUsingCompactMeasurementFormat() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetUsingCompactMeasurementFormat(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIncludeTime() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetIncludeTime(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetUseLocalClockAsRealTime() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetUseLocalClockAsRealTime(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetLagTime() {
    double ret = CommonPINVOKE.SubscriberConnection_GetLagTime(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetLeadTime() {
    double ret = CommonPINVOKE.SubscriberConnection_GetLeadTime(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetPublishInterval() {
    double ret = CommonPINVOKE.SubscriberConnection_GetPublishInterval(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetUseMillisecondResolution() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetUseMillisecondResolution(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTrackLatestMeasurements() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetTrackLatestMeasurements(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIsNaNFiltered() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetIsNaNFiltered(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIsSubscribed() {
    bool ret = CommonPINVOKE.SubscriberConnection_GetIsSubscribed(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetSubscriptionInfo() {
    string ret = CommonPINVOKE.SubscriberConnection_GetSubscriptionInfo(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SignalIndexCache GetSignalIndexCache() {
    global::System.IntPtr cPtr = CommonPINVOKE.SubscriberConnection_GetSignalIndexCache(swigCPtr);
    SignalIndexCache ret = (cPtr == global::System.IntPtr.Zero) ? null : new SignalIndexCache(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalCommandChannelBytesSent() {
    ulong ret = CommonPINVOKE.SubscriberConnection_GetTotalCommandChannelBytesSent(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalDataChannelBytesSent() {
    ulong ret = CommonPINVOKE.SubscriberConnection_GetTotalDataChannelBytesSent(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalMeasurementsSent() {
    ulong ret = CommonPINVOKE.SubscriberConnection_GetTotalMeasurementsSent(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CipherKeysDefined() {
    bool ret = CommonPINVOKE.SubscriberConnection_CipherKeysDefined(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ByteBuffer Keys(int cipherIndex) {
    ByteBuffer ret = new ByteBuffer(CommonPINVOKE.SubscriberConnection_Keys(swigCPtr, cipherIndex), true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ByteBuffer IVs(int cipherIndex) {
    ByteBuffer ret = new ByteBuffer(CommonPINVOKE.SubscriberConnection_IVs(swigCPtr, cipherIndex), true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Start(bool connectionAccepted) {
    CommonPINVOKE.SubscriberConnection_Start__SWIG_0(swigCPtr, connectionAccepted);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Start() {
    CommonPINVOKE.SubscriberConnection_Start__SWIG_1(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Stop(bool shutdownSocket) {
    CommonPINVOKE.SubscriberConnection_Stop__SWIG_0(swigCPtr, shutdownSocket);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Stop() {
    CommonPINVOKE.SubscriberConnection_Stop__SWIG_1(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void PublishMeasurements(MeasurementCollection measurements) {
    CommonPINVOKE.SubscriberConnection_PublishMeasurements(swigCPtr, MeasurementCollection.getCPtr(measurements));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CancelTemporalSubscription() {
    CommonPINVOKE.SubscriberConnection_CancelTemporalSubscription(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool SendResponse(byte responseCode, byte commandCode) {
    bool ret = CommonPINVOKE.SubscriberConnection_SendResponse__SWIG_0(swigCPtr, responseCode, commandCode);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SendResponse(byte responseCode, byte commandCode, string message) {
    bool ret = CommonPINVOKE.SubscriberConnection_SendResponse__SWIG_1(swigCPtr, responseCode, commandCode, message);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SendResponse(byte responseCode, byte commandCode, ByteBuffer data) {
    bool ret = CommonPINVOKE.SubscriberConnection_SendResponse__SWIG_2(swigCPtr, responseCode, commandCode, ByteBuffer.getCPtr(data));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

        // Gets subscriber remote IP address
        public string GetIPAddress() => Common.GetSubscriberConnectionIPAddress(this);
    
  public SubscriberConnection() : this(CommonPINVOKE.new_SubscriberConnection(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
