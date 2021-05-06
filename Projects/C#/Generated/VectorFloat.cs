//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VectorFloat : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<float>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorFloat() {
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
          UltraAppKitPINVOKE.delete_VectorFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorFloat(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (float element in c) {
      this.Add(element);
    }
  }

  public VectorFloat(global::System.Collections.Generic.IEnumerable<float> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (float element in c) {
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

  public float this[int index]  {
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

  public void CopyTo(float[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(float[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, float[] array, int arrayIndex, int count)
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

  public float[] ToArray() {
    float[] array = new float[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<float> global::System.Collections.Generic.IEnumerable<float>.GetEnumerator() {
    return new VectorFloatEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorFloatEnumerator(this);
  }

  public VectorFloatEnumerator GetEnumerator() {
    return new VectorFloatEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorFloatEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<float>
  {
    private VectorFloat collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorFloatEnumerator(VectorFloat collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public float Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (float)currentObject;
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
    UltraAppKitPINVOKE.VectorFloat_Clear(swigCPtr);
  }

  public void Add(float x) {
    UltraAppKitPINVOKE.VectorFloat_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = UltraAppKitPINVOKE.VectorFloat_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = UltraAppKitPINVOKE.VectorFloat_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    UltraAppKitPINVOKE.VectorFloat_reserve(swigCPtr, n);
  }

  public VectorFloat() : this(UltraAppKitPINVOKE.new_VectorFloat__SWIG_0(), true) {
  }

  public VectorFloat(VectorFloat other) : this(UltraAppKitPINVOKE.new_VectorFloat__SWIG_1(VectorFloat.getCPtr(other)), true) {
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorFloat(int capacity) : this(UltraAppKitPINVOKE.new_VectorFloat__SWIG_2(capacity), true) {
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  private float getitemcopy(int index) {
    float ret = UltraAppKitPINVOKE.VectorFloat_getitemcopy(swigCPtr, index);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private float getitem(int index) {
    float ret = UltraAppKitPINVOKE.VectorFloat_getitem(swigCPtr, index);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, float val) {
    UltraAppKitPINVOKE.VectorFloat_setitem(swigCPtr, index, val);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorFloat values) {
    UltraAppKitPINVOKE.VectorFloat_AddRange(swigCPtr, VectorFloat.getCPtr(values));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorFloat GetRange(int index, int count) {
    global::System.IntPtr cPtr = UltraAppKitPINVOKE.VectorFloat_GetRange(swigCPtr, index, count);
    VectorFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorFloat(cPtr, true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, float x) {
    UltraAppKitPINVOKE.VectorFloat_Insert(swigCPtr, index, x);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorFloat values) {
    UltraAppKitPINVOKE.VectorFloat_InsertRange(swigCPtr, index, VectorFloat.getCPtr(values));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    UltraAppKitPINVOKE.VectorFloat_RemoveAt(swigCPtr, index);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    UltraAppKitPINVOKE.VectorFloat_RemoveRange(swigCPtr, index, count);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorFloat Repeat(float value, int count) {
    global::System.IntPtr cPtr = UltraAppKitPINVOKE.VectorFloat_Repeat(value, count);
    VectorFloat ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorFloat(cPtr, true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    UltraAppKitPINVOKE.VectorFloat_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    UltraAppKitPINVOKE.VectorFloat_Reverse__SWIG_1(swigCPtr, index, count);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorFloat values) {
    UltraAppKitPINVOKE.VectorFloat_SetRange(swigCPtr, index, VectorFloat.getCPtr(values));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(float value) {
    bool ret = UltraAppKitPINVOKE.VectorFloat_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(float value) {
    int ret = UltraAppKitPINVOKE.VectorFloat_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(float value) {
    int ret = UltraAppKitPINVOKE.VectorFloat_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(float value) {
    bool ret = UltraAppKitPINVOKE.VectorFloat_Remove(swigCPtr, value);
    return ret;
  }

}
