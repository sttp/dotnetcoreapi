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

internal class NullableString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NullableString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NullableString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NullableString() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CommonPINVOKE.delete_NullableString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public NullableString() : this(CommonPINVOKE.new_NullableString__SWIG_0(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public NullableString(string value) : this(CommonPINVOKE.new_NullableString__SWIG_1(value), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasValue() {
    bool ret = CommonPINVOKE.NullableString_HasValue(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetValueOrDefault() {
    string ret = CommonPINVOKE.NullableString_GetValueOrDefault(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
