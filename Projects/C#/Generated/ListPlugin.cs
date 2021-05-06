//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ListPlugin : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<PluginWeakPtr>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ListPlugin(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ListPlugin obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ListPlugin() {
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
          UltraAppKitPINVOKE.delete_ListPlugin(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ListPlugin(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (PluginWeakPtr element in c) {
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

  public ListPluginNode First {
    get {
      if (Count == 0)
        return null;
      return new ListPluginNode(getFirstIter(), this);
    }
  }

  public ListPluginNode Last {
    get {
      if (Count == 0)
        return null;
      return new ListPluginNode(getLastIter(), this);
    }
  }

  public ListPluginNode AddFirst(PluginWeakPtr value) {
    push_front(value);
    return new ListPluginNode(getFirstIter(), this);
  }

  public void AddFirst(ListPluginNode newNode) {
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      push_front(newNode.csharpvalue);
      newNode.iter = getFirstIter();
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListPluginNode AddLast(PluginWeakPtr value) {
    push_back(value);
    return new ListPluginNode(getLastIter(), this);
  }

  public void AddLast(ListPluginNode newNode) {
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      push_back(newNode.csharpvalue);
      newNode.iter = getLastIter();
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListPluginNode AddBefore(ListPluginNode node, PluginWeakPtr value) {
    return new ListPluginNode(insertNode(node.iter, value), this);
  }

  public void AddBefore(ListPluginNode node, ListPluginNode newNode) {
    ValidateNode(node);
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      newNode.iter = insertNode(node.iter, newNode.csharpvalue);
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListPluginNode AddAfter(ListPluginNode node, PluginWeakPtr value) {
    node = node.Next;
    return new ListPluginNode(insertNode(node.iter, value), this);
  }

  public void AddAfter(ListPluginNode node, ListPluginNode newNode) {
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

  public void Add(PluginWeakPtr value) {
    AddLast(value);
  }

  public void Remove(ListPluginNode node) {
    ValidateNode(node);
    eraseIter(node.iter);
  }

  public void CopyTo(PluginWeakPtr[] array, int index) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0 || index > array.Length)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    ListPluginNode node = this.First;
    if (node != null) {
      do {
        array[index++] = node.Value;
        node = node.Next;
      } while (node != null);
    }
  }

  internal void ValidateNode(ListPluginNode node) {
    if (node == null) {
      throw new System.ArgumentNullException("node");
    }
    if (!node.inlist || node.list != this) {
      throw new System.InvalidOperationException("node");
    }
  }

  internal void ValidateNewNode(ListPluginNode node) {
    if (node == null) {
      throw new System.ArgumentNullException("node");
    }
  }

  global::System.Collections.Generic.IEnumerator<PluginWeakPtr> global::System.Collections.Generic.IEnumerable<PluginWeakPtr>.GetEnumerator() {
    return new ListPluginEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ListPluginEnumerator(this);
  }

  public ListPluginEnumerator GetEnumerator() {
    return new ListPluginEnumerator(this);
  }

  public sealed class ListPluginEnumerator : global::System.Collections.IEnumerator,
    global::System.Collections.Generic.IEnumerator<PluginWeakPtr>
  {
    private ListPlugin collectionRef;
    private ListPluginNode currentNode;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ListPluginEnumerator(ListPlugin collection) {
      collectionRef = collection;
      currentNode = collection.First;
      currentIndex = 0;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public PluginWeakPtr Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (PluginWeakPtr)currentObject;
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

  public sealed class ListPluginNode {
    internal ListPlugin list;
    internal System.IntPtr iter;
    internal PluginWeakPtr csharpvalue;
    internal bool inlist;

    public ListPluginNode(PluginWeakPtr value) {
      csharpvalue = value;
      inlist = false;
    }

    internal ListPluginNode(System.IntPtr iter, ListPlugin list) {
      this.list = list;
      this.iter = iter;
      inlist = true;
    }

    public ListPlugin List {
      get {
        return this.list;
      }
    }

    public ListPluginNode Next {
      get {
        if (list.getNextIter(iter) == System.IntPtr.Zero)
          return null;
        return new ListPluginNode(list.getNextIter(iter), list);
      }
    }

    public ListPluginNode Previous {
      get {
        if (list.getPrevIter(iter) == System.IntPtr.Zero)
          return null;
        return new ListPluginNode(list.getPrevIter(iter), list);
      }
    }

    public PluginWeakPtr Value {
      get {
        return list.getItem(this.iter);
      }
      set {
        list.setItem(this.iter, value);
      }
    }

    public static bool operator==(ListPluginNode node1, ListPluginNode node2) {
      if (object.ReferenceEquals(node1, null) && object.ReferenceEquals(node2, null))
        return true;
      if (object.ReferenceEquals(node1, null) || object.ReferenceEquals(node2, null))
        return false;
      return node1.Equals(node2);
    }

    public static bool operator!=(ListPluginNode node1, ListPluginNode node2) {
      if (node1 == null && node2 == null)
        return false;
      if (node1 == null || node2 == null)
        return true;
      return !node1.Equals(node2);
    }

    public bool Equals(ListPluginNode node) {
      if (node == null)
        return false;
      if (!node.inlist || !this.inlist)
        return object.ReferenceEquals(this, node);
      return list.equals(this.iter, node.iter);
    }

    public override bool Equals(object node) {
      return Equals((ListPluginNode)node);
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

  private void push_front(PluginWeakPtr x) {
    UltraAppKitPINVOKE.ListPlugin_push_front(swigCPtr, PluginWeakPtr.getCPtr(x));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  private void push_back(PluginWeakPtr x) {
    UltraAppKitPINVOKE.ListPlugin_push_back(swigCPtr, PluginWeakPtr.getCPtr(x));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveFirst() {
    UltraAppKitPINVOKE.ListPlugin_RemoveFirst(swigCPtr);
  }

  public void RemoveLast() {
    UltraAppKitPINVOKE.ListPlugin_RemoveLast(swigCPtr);
  }

  private uint size() {
    uint ret = UltraAppKitPINVOKE.ListPlugin_size(swigCPtr);
    return ret;
  }

  public void Clear() {
    UltraAppKitPINVOKE.ListPlugin_Clear(swigCPtr);
  }

  private PluginWeakPtr getItem(global::System.IntPtr iter) {
    PluginWeakPtr ret = new PluginWeakPtr(UltraAppKitPINVOKE.ListPlugin_getItem(swigCPtr, iter), false);
    return ret;
  }

  private void setItem(global::System.IntPtr iter, PluginWeakPtr val) {
    UltraAppKitPINVOKE.ListPlugin_setItem(swigCPtr, iter, PluginWeakPtr.getCPtr(val));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  private global::System.IntPtr getFirstIter() {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPlugin_getFirstIter(swigCPtr);
    return ret;
  }

  private global::System.IntPtr getLastIter() {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPlugin_getLastIter(swigCPtr);
    return ret;
  }

  private global::System.IntPtr getNextIter(global::System.IntPtr iter) {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPlugin_getNextIter(swigCPtr, iter);
    return ret;
  }

  private global::System.IntPtr getPrevIter(global::System.IntPtr iter) {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPlugin_getPrevIter(swigCPtr, iter);
    return ret;
  }

  public global::System.IntPtr insertNode(global::System.IntPtr iter, PluginWeakPtr value) {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPlugin_insertNode(swigCPtr, iter, PluginWeakPtr.getCPtr(value));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void eraseIter(global::System.IntPtr iter) {
    UltraAppKitPINVOKE.ListPlugin_eraseIter(swigCPtr, iter);
  }

  private void deleteIter(global::System.IntPtr iter) {
    UltraAppKitPINVOKE.ListPlugin_deleteIter(swigCPtr, iter);
  }

  public bool equals(global::System.IntPtr iter1, global::System.IntPtr iter2) {
    bool ret = UltraAppKitPINVOKE.ListPlugin_equals(swigCPtr, iter1, iter2);
    return ret;
  }

  public ListPlugin() : this(UltraAppKitPINVOKE.new_ListPlugin(), true) {
  }

}
