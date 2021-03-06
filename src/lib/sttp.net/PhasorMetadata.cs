//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace sttp {

public class PhasorMetadata : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal PhasorMetadata(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PhasorMetadata obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PhasorMetadata() {
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
          CommonPINVOKE.delete_PhasorMetadata(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string DeviceAcronym {
    set {
      CommonPINVOKE.PhasorMetadata_DeviceAcronym_set(swigCPtr, value);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = CommonPINVOKE.PhasorMetadata_DeviceAcronym_get(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string Label {
    set {
      CommonPINVOKE.PhasorMetadata_Label_set(swigCPtr, value);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = CommonPINVOKE.PhasorMetadata_Label_get(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string Type {
    set {
      CommonPINVOKE.PhasorMetadata_Type_set(swigCPtr, value);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = CommonPINVOKE.PhasorMetadata_Type_get(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string Phase {
    set {
      CommonPINVOKE.PhasorMetadata_Phase_set(swigCPtr, value);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = CommonPINVOKE.PhasorMetadata_Phase_get(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort SourceIndex {
    set {
      CommonPINVOKE.PhasorMetadata_SourceIndex_set(swigCPtr, value);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = CommonPINVOKE.PhasorMetadata_SourceIndex_get(swigCPtr);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public System.DateTime UpdatedOn {
      set {
        datetime_t tempvalue = Common.FromTicks(value.Ticks);
        CommonPINVOKE.PhasorMetadata_UpdatedOn_set(swigCPtr, datetime_t.getCPtr(tempvalue));
        if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      }
    
      get {
        global::System.IntPtr cPtr = CommonPINVOKE.PhasorMetadata_UpdatedOn_get(swigCPtr);
        if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
        using (datetime_t tempDate = (cPtr == global::System.IntPtr.Zero) ? null : new datetime_t(cPtr, false)) {
          return new System.DateTime(Common.ToTicks(tempDate));
        }
      }
    
  }

  public PhasorMetadata() : this(CommonPINVOKE.new_PhasorMetadata(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
