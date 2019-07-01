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

public class GuidCollection : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<System.Guid>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GuidCollection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GuidCollection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GuidCollection() {
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
          CommonPINVOKE.delete_GuidCollection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public GuidCollection(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (System.Guid element in c) {
      this.Add(element);
    }
  }

  public GuidCollection(global::System.Collections.Generic.IEnumerable<System.Guid> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (System.Guid element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public System.Guid this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(System.Guid[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(System.Guid[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, System.Guid[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public System.Guid[] ToArray() {
    System.Guid[] array = new System.Guid[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<System.Guid> global::System.Collections.Generic.IEnumerable<System.Guid>.GetEnumerator() {
    return new GuidCollectionEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new GuidCollectionEnumerator(this);
  }

  public GuidCollectionEnumerator GetEnumerator() {
    return new GuidCollectionEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class GuidCollectionEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<System.Guid>
  {
    private GuidCollection collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public GuidCollectionEnumerator(GuidCollection collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public System.Guid Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (System.Guid)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    CommonPINVOKE.GuidCollection_Clear(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(System.Guid x) {
    guid_t tempx = Common.ParseGuid(x.ToByteArray(), true);
    {
      CommonPINVOKE.GuidCollection_Add(swigCPtr, guid_t.getCPtr(tempx));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    }
  }

  private uint size() {
    uint ret = CommonPINVOKE.GuidCollection_size(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = CommonPINVOKE.GuidCollection_capacity(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    CommonPINVOKE.GuidCollection_reserve(swigCPtr, n);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuidCollection() : this(CommonPINVOKE.new_GuidCollection__SWIG_0(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuidCollection(GuidCollection other) : this(CommonPINVOKE.new_GuidCollection__SWIG_1(GuidCollection.getCPtr(other)), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuidCollection(int capacity) : this(CommonPINVOKE.new_GuidCollection__SWIG_2(capacity), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private System.Guid getitemcopy(int index) {
      global::System.IntPtr cPtr = CommonPINVOKE.GuidCollection_getitemcopy(swigCPtr, index);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (guid_t tempGuid = (cPtr == global::System.IntPtr.Zero) ? null : new guid_t(cPtr, false)) {
        byte[] data = new byte[16];
        Common.GetGuidBytes(tempGuid, data);
        return new System.Guid(data);
      }
    }

  private System.Guid getitem(int index) {
      global::System.IntPtr cPtr = CommonPINVOKE.GuidCollection_getitem(swigCPtr, index);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      using (guid_t tempGuid = (cPtr == global::System.IntPtr.Zero) ? null : new guid_t(cPtr, false)) {
        byte[] data = new byte[16];
        Common.GetGuidBytes(tempGuid, data);
        return new System.Guid(data);
      }
    }

  private void setitem(int index, System.Guid val) {
    guid_t tempval = Common.ParseGuid(val.ToByteArray(), true);
    {
      CommonPINVOKE.GuidCollection_setitem(swigCPtr, index, guid_t.getCPtr(tempval));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    }
  }

  public void AddRange(GuidCollection values) {
    CommonPINVOKE.GuidCollection_AddRange(swigCPtr, GuidCollection.getCPtr(values));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public GuidCollection GetRange(int index, int count) {
    global::System.IntPtr cPtr = CommonPINVOKE.GuidCollection_GetRange(swigCPtr, index, count);
    GuidCollection ret = (cPtr == global::System.IntPtr.Zero) ? null : new GuidCollection(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, System.Guid x) {
    guid_t tempx = Common.ParseGuid(x.ToByteArray(), true);
    {
      CommonPINVOKE.GuidCollection_Insert(swigCPtr, index, guid_t.getCPtr(tempx));
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    }
  }

  public void InsertRange(int index, GuidCollection values) {
    CommonPINVOKE.GuidCollection_InsertRange(swigCPtr, index, GuidCollection.getCPtr(values));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    CommonPINVOKE.GuidCollection_RemoveAt(swigCPtr, index);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    CommonPINVOKE.GuidCollection_RemoveRange(swigCPtr, index, count);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GuidCollection Repeat(System.Guid value, int count) {
    guid_t tempvalue = Common.ParseGuid(value.ToByteArray(), true);
    {
      global::System.IntPtr cPtr = CommonPINVOKE.GuidCollection_Repeat(guid_t.getCPtr(tempvalue), count);
      GuidCollection ret = (cPtr == global::System.IntPtr.Zero) ? null : new GuidCollection(cPtr, true);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  }

  public void Reverse() {
    CommonPINVOKE.GuidCollection_Reverse__SWIG_0(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    CommonPINVOKE.GuidCollection_Reverse__SWIG_1(swigCPtr, index, count);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, GuidCollection values) {
    CommonPINVOKE.GuidCollection_SetRange(swigCPtr, index, GuidCollection.getCPtr(values));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
