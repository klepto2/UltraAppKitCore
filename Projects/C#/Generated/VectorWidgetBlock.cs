//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace UltraEngine {

public class VectorWidgetBlock : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<WidgetBlock>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorWidgetBlock(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorWidgetBlock obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorWidgetBlock() {
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
          PInvoke.delete_VectorWidgetBlock(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorWidgetBlock(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WidgetBlock element in c) {
      this.Add(element);
    }
  }

  public VectorWidgetBlock(global::System.Collections.Generic.IEnumerable<WidgetBlock> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WidgetBlock element in c) {
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

  public WidgetBlock this[int index]  {
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

  public void CopyTo(WidgetBlock[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(WidgetBlock[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, WidgetBlock[] array, int arrayIndex, int count)
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

  public WidgetBlock[] ToArray() {
    WidgetBlock[] array = new WidgetBlock[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<WidgetBlock> global::System.Collections.Generic.IEnumerable<WidgetBlock>.GetEnumerator() {
    return new VectorWidgetBlockEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorWidgetBlockEnumerator(this);
  }

  public VectorWidgetBlockEnumerator GetEnumerator() {
    return new VectorWidgetBlockEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorWidgetBlockEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<WidgetBlock>
  {
    private VectorWidgetBlock collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorWidgetBlockEnumerator(VectorWidgetBlock collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public WidgetBlock Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (WidgetBlock)currentObject;
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
    PInvoke.VectorWidgetBlock_Clear(swigCPtr);
  }

  public void Add(WidgetBlock x) {
    PInvoke.VectorWidgetBlock_Add(swigCPtr, WidgetBlock.getCPtr(x));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = PInvoke.VectorWidgetBlock_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = PInvoke.VectorWidgetBlock_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    PInvoke.VectorWidgetBlock_reserve(swigCPtr, n);
  }

  public VectorWidgetBlock() : this(PInvoke.new_VectorWidgetBlock__SWIG_0(), true) {
  }

  public VectorWidgetBlock(VectorWidgetBlock other) : this(PInvoke.new_VectorWidgetBlock__SWIG_1(VectorWidgetBlock.getCPtr(other)), true) {
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public VectorWidgetBlock(int capacity) : this(PInvoke.new_VectorWidgetBlock__SWIG_2(capacity), true) {
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private WidgetBlock getitemcopy(int index) {
    WidgetBlock ret = new WidgetBlock(PInvoke.VectorWidgetBlock_getitemcopy(swigCPtr, index), true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private WidgetBlock getitem(int index) {
    WidgetBlock ret = new WidgetBlock(PInvoke.VectorWidgetBlock_getitem(swigCPtr, index), false);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, WidgetBlock val) {
    PInvoke.VectorWidgetBlock_setitem(swigCPtr, index, WidgetBlock.getCPtr(val));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorWidgetBlock values) {
    PInvoke.VectorWidgetBlock_AddRange(swigCPtr, VectorWidgetBlock.getCPtr(values));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public VectorWidgetBlock GetRange(int index, int count) {
    global::System.IntPtr cPtr = PInvoke.VectorWidgetBlock_GetRange(swigCPtr, index, count);
    VectorWidgetBlock ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorWidgetBlock(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, WidgetBlock x) {
    PInvoke.VectorWidgetBlock_Insert(swigCPtr, index, WidgetBlock.getCPtr(x));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorWidgetBlock values) {
    PInvoke.VectorWidgetBlock_InsertRange(swigCPtr, index, VectorWidgetBlock.getCPtr(values));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    PInvoke.VectorWidgetBlock_RemoveAt(swigCPtr, index);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    PInvoke.VectorWidgetBlock_RemoveRange(swigCPtr, index, count);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public static VectorWidgetBlock Repeat(WidgetBlock value, int count) {
    global::System.IntPtr cPtr = PInvoke.VectorWidgetBlock_Repeat(WidgetBlock.getCPtr(value), count);
    VectorWidgetBlock ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorWidgetBlock(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    PInvoke.VectorWidgetBlock_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    PInvoke.VectorWidgetBlock_Reverse__SWIG_1(swigCPtr, index, count);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorWidgetBlock values) {
    PInvoke.VectorWidgetBlock_SetRange(swigCPtr, index, VectorWidgetBlock.getCPtr(values));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

}

}
