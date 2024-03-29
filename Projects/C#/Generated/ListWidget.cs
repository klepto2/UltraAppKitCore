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

public class ListWidget : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<WidgetWeakPtr>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ListWidget(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ListWidget obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ListWidget() {
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
          PInvoke.delete_ListWidget(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ListWidget(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WidgetWeakPtr element in c) {
      this.AddLast(element);
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public ListWidgetNode First {
    get {
      if (Count == 0)
        return null;
      return new ListWidgetNode(getFirstIter(), this);
    }
  }

  public ListWidgetNode Last {
    get {
      if (Count == 0)
        return null;
      return new ListWidgetNode(getLastIter(), this);
    }
  }

  public ListWidgetNode AddFirst(WidgetWeakPtr value) {
    push_front(value);
    return new ListWidgetNode(getFirstIter(), this);
  }

  public void AddFirst(ListWidgetNode newNode) {
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      push_front(newNode.csharpvalue);
      newNode.iter = getFirstIter();
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListWidgetNode AddLast(WidgetWeakPtr value) {
    push_back(value);
    return new ListWidgetNode(getLastIter(), this);
  }

  public void AddLast(ListWidgetNode newNode) {
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      push_back(newNode.csharpvalue);
      newNode.iter = getLastIter();
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListWidgetNode AddBefore(ListWidgetNode node, WidgetWeakPtr value) {
    return new ListWidgetNode(insertNode(node.iter, value), this);
  }

  public void AddBefore(ListWidgetNode node, ListWidgetNode newNode) {
    ValidateNode(node);
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      newNode.iter = insertNode(node.iter, newNode.csharpvalue);
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListWidgetNode AddAfter(ListWidgetNode node, WidgetWeakPtr value) {
    node = node.Next;
    return new ListWidgetNode(insertNode(node.iter, value), this);
  }

  public void AddAfter(ListWidgetNode node, ListWidgetNode newNode) {
    ValidateNode(node);
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      if (node == this.Last)
        AddLast(newNode);
      else
      {
        node = node.Next;
        newNode.iter = insertNode(node.iter, newNode.csharpvalue);
        newNode.inlist = true;
      }
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public void Add(WidgetWeakPtr value) {
    AddLast(value);
  }

  public void Remove(ListWidgetNode node) {
    ValidateNode(node);
    eraseIter(node.iter);
  }

  public void CopyTo(WidgetWeakPtr[] array, int index) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0 || index > array.Length)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    ListWidgetNode node = this.First;
    if (node != null) {
      do {
        array[index++] = node.Value;
        node = node.Next;
      } while (node != null);
    }
  }

  internal void ValidateNode(ListWidgetNode node) {
    if (node == null) {
      throw new System.ArgumentNullException("node");
    }
    if (!node.inlist || node.list != this) {
      throw new System.InvalidOperationException("node");
    }
  }

  internal void ValidateNewNode(ListWidgetNode node) {
    if (node == null) {
      throw new System.ArgumentNullException("node");
    }
  }

  global::System.Collections.Generic.IEnumerator<WidgetWeakPtr> global::System.Collections.Generic.IEnumerable<WidgetWeakPtr>.GetEnumerator() {
    return new ListWidgetEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ListWidgetEnumerator(this);
  }

  public ListWidgetEnumerator GetEnumerator() {
    return new ListWidgetEnumerator(this);
  }

  public sealed class ListWidgetEnumerator : global::System.Collections.IEnumerator,
    global::System.Collections.Generic.IEnumerator<WidgetWeakPtr>
  {
    private ListWidget collectionRef;
    private ListWidgetNode currentNode;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ListWidgetEnumerator(ListWidget collection) {
      collectionRef = collection;
      currentNode = collection.First;
      currentIndex = 0;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public WidgetWeakPtr Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (WidgetWeakPtr)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      if (currentNode == null) {
        currentIndex = collectionRef.Count + 1;
        return false;
      }
      ++currentIndex;
      currentObject = currentNode.Value;
      currentNode = currentNode.Next;
      return true;
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

  public sealed class ListWidgetNode {
    internal ListWidget list;
    internal System.IntPtr iter;
    internal WidgetWeakPtr csharpvalue;
    internal bool inlist;

    public ListWidgetNode(WidgetWeakPtr value) {
      csharpvalue = value;
      inlist = false;
    }

    internal ListWidgetNode(System.IntPtr iter, ListWidget list) {
      this.list = list;
      this.iter = iter;
      inlist = true;
    }

    public ListWidget List {
      get {
        return this.list;
      }
    }

    public ListWidgetNode Next {
      get {
        if (list.getNextIter(iter) == System.IntPtr.Zero)
          return null;
        return new ListWidgetNode(list.getNextIter(iter), list);
      }
    }

    public ListWidgetNode Previous {
      get {
        if (list.getPrevIter(iter) == System.IntPtr.Zero)
          return null;
        return new ListWidgetNode(list.getPrevIter(iter), list);
      }
    }

    public WidgetWeakPtr Value {
      get {
        return list.getItem(this.iter);
      }
      set {
        list.setItem(this.iter, value);
      }
    }

    public static bool operator==(ListWidgetNode node1, ListWidgetNode node2) {
      if (object.ReferenceEquals(node1, null) && object.ReferenceEquals(node2, null))
        return true;
      if (object.ReferenceEquals(node1, null) || object.ReferenceEquals(node2, null))
        return false;
      return node1.Equals(node2);
    }

    public static bool operator!=(ListWidgetNode node1, ListWidgetNode node2) {
      if (node1 == null && node2 == null)
        return false;
      if (node1 == null || node2 == null)
        return true;
      return !node1.Equals(node2);
    }

    public bool Equals(ListWidgetNode node) {
      if (node == null)
        return false;
      if (!node.inlist || !this.inlist)
        return object.ReferenceEquals(this, node);
      return list.equals(this.iter, node.iter);
    }

    public override bool Equals(object node) {
      return Equals((ListWidgetNode)node);
    }

    public override int GetHashCode() {
      int hash = 13;
      if (inlist) {
        hash = (hash * 7) + this.list.GetHashCode();
        hash = (hash * 7) + this.Value.GetHashCode();
        hash = (hash * 7) + this.list.getNextIter(this.iter).GetHashCode();
        hash = (hash * 7) + this.list.getPrevIter(this.iter).GetHashCode();
      } else {
        hash = (hash * 7) + this.csharpvalue.GetHashCode();
      }
      return hash;
    }

    public void Dispose() {
      list.deleteIter(this.iter);
    }
  }

  private void push_front(WidgetWeakPtr x) {
    PInvoke.ListWidget_push_front(swigCPtr, WidgetWeakPtr.getCPtr(x));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private void push_back(WidgetWeakPtr x) {
    PInvoke.ListWidget_push_back(swigCPtr, WidgetWeakPtr.getCPtr(x));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void RemoveFirst() {
    PInvoke.ListWidget_RemoveFirst(swigCPtr);
  }

  public void RemoveLast() {
    PInvoke.ListWidget_RemoveLast(swigCPtr);
  }

  private uint size() {
    uint ret = PInvoke.ListWidget_size(swigCPtr);
    return ret;
  }

  public void Clear() {
    PInvoke.ListWidget_Clear(swigCPtr);
  }

  private WidgetWeakPtr getItem(global::System.IntPtr iter) {
    WidgetWeakPtr ret = new WidgetWeakPtr(PInvoke.ListWidget_getItem(swigCPtr, iter), false);
    return ret;
  }

  private void setItem(global::System.IntPtr iter, WidgetWeakPtr val) {
    PInvoke.ListWidget_setItem(swigCPtr, iter, WidgetWeakPtr.getCPtr(val));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private global::System.IntPtr getFirstIter() {
    global::System.IntPtr ret = PInvoke.ListWidget_getFirstIter(swigCPtr);
    return ret;
  }

  private global::System.IntPtr getLastIter() {
    global::System.IntPtr ret = PInvoke.ListWidget_getLastIter(swigCPtr);
    return ret;
  }

  private global::System.IntPtr getNextIter(global::System.IntPtr iter) {
    global::System.IntPtr ret = PInvoke.ListWidget_getNextIter(swigCPtr, iter);
    return ret;
  }

  private global::System.IntPtr getPrevIter(global::System.IntPtr iter) {
    global::System.IntPtr ret = PInvoke.ListWidget_getPrevIter(swigCPtr, iter);
    return ret;
  }

  public global::System.IntPtr insertNode(global::System.IntPtr iter, WidgetWeakPtr value) {
    global::System.IntPtr ret = PInvoke.ListWidget_insertNode(swigCPtr, iter, WidgetWeakPtr.getCPtr(value));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public void eraseIter(global::System.IntPtr iter) {
    PInvoke.ListWidget_eraseIter(swigCPtr, iter);
  }

  private void deleteIter(global::System.IntPtr iter) {
    PInvoke.ListWidget_deleteIter(swigCPtr, iter);
  }

  public bool equals(global::System.IntPtr iter1, global::System.IntPtr iter2) {
    bool ret = PInvoke.ListWidget_equals(swigCPtr, iter1, iter2);
    return ret;
  }

  public ListWidget() : this(PInvoke.new_ListWidget(), true) {
  }

}

}
