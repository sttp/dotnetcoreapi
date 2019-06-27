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

public class PhasorReference : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal PhasorReference(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PhasorReference obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PhasorReference() {
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
          CommonPINVOKE.delete_PhasorReference(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PhasorMetadata Phasor {
    set {
      CommonPINVOKE.PhasorReference_Phasor_set(swigCPtr, PhasorMetadata.getCPtr(value));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CommonPINVOKE.PhasorReference_Phasor_get(swigCPtr);
      PhasorMetadata ret = (cPtr == global::System.IntPtr.Zero) ? null : new PhasorMetadata(cPtr, true);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MeasurementMetadata Angle {
    set {
      CommonPINVOKE.PhasorReference_Angle_set(swigCPtr, MeasurementMetadata.getCPtr(value));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CommonPINVOKE.PhasorReference_Angle_get(swigCPtr);
      MeasurementMetadata ret = (cPtr == global::System.IntPtr.Zero) ? null : new MeasurementMetadata(cPtr, true);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MeasurementMetadata Magnitude {
    set {
      CommonPINVOKE.PhasorReference_Magnitude_set(swigCPtr, MeasurementMetadata.getCPtr(value));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CommonPINVOKE.PhasorReference_Magnitude_get(swigCPtr);
      MeasurementMetadata ret = (cPtr == global::System.IntPtr.Zero) ? null : new MeasurementMetadata(cPtr, true);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PhasorReference() : this(CommonPINVOKE.new_PhasorReference(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

}

}