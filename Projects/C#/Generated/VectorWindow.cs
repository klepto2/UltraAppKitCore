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

public class VectorWindow : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<Window>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorWindow(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorWindow obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorWindow() {
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
          PInvoke.delete_VectorWindow(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorWindow(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Window element in c) {
      this.Add(element);
    }
  }

  public VectorWindow(global::System.Collections.Generic.IEnumerable<Window> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Window element in c) {
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

  public Window this[int index]  {
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

  public void CopyTo(Window[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Window[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Window[] array, int arrayIndex, int count)
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

  public Window[] ToArray() {
    Window[] array = new Window[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<Window> global::System.Collections.Generic.IEnumerable<Window>.GetEnumerator() {
    return new VectorWindowEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorWindowEnumerator(this);
  }

  public VectorWindowEnumerator GetEnumerator() {
    return new VectorWindowEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorWindowEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Window>
  {
    private VectorWindow collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorWindowEnumerator(VectorWindow collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Window Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Window)currentObject;
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
    PInvoke.VectorWindow_Clear(swigCPtr);
  }

  public void Add(Window x) {
    PInvoke.VectorWindow_Add(swigCPtr, Window.getCPtr(x));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = PInvoke.VectorWindow_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = PInvoke.VectorWindow_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    PInvoke.VectorWindow_reserve(swigCPtr, n);
  }

  public VectorWindow() : this(PInvoke.new_VectorWindow__SWIG_0(), true) {
  }

  public VectorWindow(VectorWindow other) : this(PInvoke.new_VectorWindow__SWIG_1(VectorWindow.getCPtr(other)), true) {
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public VectorWindow(int capacity) : this(PInvoke.new_VectorWindow__SWIG_2(capacity), true) {
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private Window getitemcopy(int index) {
    global::System.IntPtr cPtr = PInvoke.VectorWindow_getitemcopy(swigCPtr, index);
    Window ret = (cPtr == global::System.IntPtr.Zero) ? null : new Window(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private Window getitem(int index) {
    global::System.IntPtr cPtr = PInvoke.VectorWindow_getitem(swigCPtr, index);
    Window ret = (cPtr == global::System.IntPtr.Zero) ? null : new Window(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Window val) {
    PInvoke.VectorWindow_setitem(swigCPtr, index, Window.getCPtr(val));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorWindow values) {
    PInvoke.VectorWindow_AddRange(swigCPtr, VectorWindow.getCPtr(values));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public VectorWindow GetRange(int index, int count) {
    global::System.IntPtr cPtr = PInvoke.VectorWindow_GetRange(swigCPtr, index, count);
    VectorWindow ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorWindow(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Window x) {
    PInvoke.VectorWindow_Insert(swigCPtr, index, Window.getCPtr(x));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorWindow values) {
    PInvoke.VectorWindow_InsertRange(swigCPtr, index, VectorWindow.getCPtr(values));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    PInvoke.VectorWindow_RemoveAt(swigCPtr, index);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    PInvoke.VectorWindow_RemoveRange(swigCPtr, index, count);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public static VectorWindow Repeat(Window value, int count) {
    global::System.IntPtr cPtr = PInvoke.VectorWindow_Repeat(Window.getCPtr(value), count);
    VectorWindow ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorWindow(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    PInvoke.VectorWindow_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    PInvoke.VectorWindow_Reverse__SWIG_1(swigCPtr, index, count);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorWindow values) {
    PInvoke.VectorWindow_SetRange(swigCPtr, index, VectorWindow.getCPtr(values));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public bool Contains(Window value) {
    bool ret = PInvoke.VectorWindow_Contains(swigCPtr, Window.getCPtr(value));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(Window value) {
    int ret = PInvoke.VectorWindow_IndexOf(swigCPtr, Window.getCPtr(value));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(Window value) {
    int ret = PInvoke.VectorWindow_LastIndexOf(swigCPtr, Window.getCPtr(value));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(Window value) {
    bool ret = PInvoke.VectorWindow_Remove(swigCPtr, Window.getCPtr(value));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
