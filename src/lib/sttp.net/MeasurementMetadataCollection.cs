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

public class MeasurementMetadataCollection : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<MeasurementMetadata>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MeasurementMetadataCollection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MeasurementMetadataCollection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MeasurementMetadataCollection() {
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
          CommonPINVOKE.delete_MeasurementMetadataCollection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public MeasurementMetadataCollection(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MeasurementMetadata element in c) {
      this.Add(element);
    }
  }

  public MeasurementMetadataCollection(global::System.Collections.Generic.IEnumerable<MeasurementMetadata> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MeasurementMetadata element in c) {
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

  public MeasurementMetadata this[int index]  {
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

  public void CopyTo(MeasurementMetadata[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(MeasurementMetadata[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, MeasurementMetadata[] array, int arrayIndex, int count)
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

  public MeasurementMetadata[] ToArray() {
    MeasurementMetadata[] array = new MeasurementMetadata[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<MeasurementMetadata> global::System.Collections.Generic.IEnumerable<MeasurementMetadata>.GetEnumerator() {
    return new MeasurementMetadataCollectionEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new MeasurementMetadataCollectionEnumerator(this);
  }

  public MeasurementMetadataCollectionEnumerator GetEnumerator() {
    return new MeasurementMetadataCollectionEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class MeasurementMetadataCollectionEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<MeasurementMetadata>
  {
    private MeasurementMetadataCollection collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public MeasurementMetadataCollectionEnumerator(MeasurementMetadataCollection collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public MeasurementMetadata Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (MeasurementMetadata)currentObject;
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
    CommonPINVOKE.MeasurementMetadataCollection_Clear(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(MeasurementMetadata x) {
    CommonPINVOKE.MeasurementMetadataCollection_Add(swigCPtr, MeasurementMetadata.getCPtr(x));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = CommonPINVOKE.MeasurementMetadataCollection_size(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = CommonPINVOKE.MeasurementMetadataCollection_capacity(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    CommonPINVOKE.MeasurementMetadataCollection_reserve(swigCPtr, n);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public MeasurementMetadataCollection() : this(CommonPINVOKE.new_MeasurementMetadataCollection__SWIG_0(), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public MeasurementMetadataCollection(MeasurementMetadataCollection other) : this(CommonPINVOKE.new_MeasurementMetadataCollection__SWIG_1(MeasurementMetadataCollection.getCPtr(other)), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public MeasurementMetadataCollection(int capacity) : this(CommonPINVOKE.new_MeasurementMetadataCollection__SWIG_2(capacity), true) {
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  private MeasurementMetadata getitemcopy(int index) {
    global::System.IntPtr cPtr = CommonPINVOKE.MeasurementMetadataCollection_getitemcopy(swigCPtr, index);
    MeasurementMetadata ret = (cPtr == global::System.IntPtr.Zero) ? null : new MeasurementMetadata(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private MeasurementMetadata getitem(int index) {
    global::System.IntPtr cPtr = CommonPINVOKE.MeasurementMetadataCollection_getitem(swigCPtr, index);
    MeasurementMetadata ret = (cPtr == global::System.IntPtr.Zero) ? null : new MeasurementMetadata(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, MeasurementMetadata val) {
    CommonPINVOKE.MeasurementMetadataCollection_setitem(swigCPtr, index, MeasurementMetadata.getCPtr(val));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(MeasurementMetadataCollection values) {
    CommonPINVOKE.MeasurementMetadataCollection_AddRange(swigCPtr, MeasurementMetadataCollection.getCPtr(values));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public MeasurementMetadataCollection GetRange(int index, int count) {
    global::System.IntPtr cPtr = CommonPINVOKE.MeasurementMetadataCollection_GetRange(swigCPtr, index, count);
    MeasurementMetadataCollection ret = (cPtr == global::System.IntPtr.Zero) ? null : new MeasurementMetadataCollection(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, MeasurementMetadata x) {
    CommonPINVOKE.MeasurementMetadataCollection_Insert(swigCPtr, index, MeasurementMetadata.getCPtr(x));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, MeasurementMetadataCollection values) {
    CommonPINVOKE.MeasurementMetadataCollection_InsertRange(swigCPtr, index, MeasurementMetadataCollection.getCPtr(values));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    CommonPINVOKE.MeasurementMetadataCollection_RemoveAt(swigCPtr, index);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    CommonPINVOKE.MeasurementMetadataCollection_RemoveRange(swigCPtr, index, count);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public static MeasurementMetadataCollection Repeat(MeasurementMetadata value, int count) {
    global::System.IntPtr cPtr = CommonPINVOKE.MeasurementMetadataCollection_Repeat(MeasurementMetadata.getCPtr(value), count);
    MeasurementMetadataCollection ret = (cPtr == global::System.IntPtr.Zero) ? null : new MeasurementMetadataCollection(cPtr, true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    CommonPINVOKE.MeasurementMetadataCollection_Reverse__SWIG_0(swigCPtr);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    CommonPINVOKE.MeasurementMetadataCollection_Reverse__SWIG_1(swigCPtr, index, count);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, MeasurementMetadataCollection values) {
    CommonPINVOKE.MeasurementMetadataCollection_SetRange(swigCPtr, index, MeasurementMetadataCollection.getCPtr(values));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
