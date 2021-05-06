//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ListPackage : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<PackageWeakPtr>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ListPackage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ListPackage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ListPackage() {
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
          UltraAppKitPINVOKE.delete_ListPackage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ListPackage(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (PackageWeakPtr element in c) {
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

  public ListPackageNode First {
    get {
      if (Count == 0)
        return null;
      return new ListPackageNode(getFirstIter(), this);
    }
  }

  public ListPackageNode Last {
    get {
      if (Count == 0)
        return null;
      return new ListPackageNode(getLastIter(), this);
    }
  }

  public ListPackageNode AddFirst(PackageWeakPtr value) {
    push_front(value);
    return new ListPackageNode(getFirstIter(), this);
  }

  public void AddFirst(ListPackageNode newNode) {
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      push_front(newNode.csharpvalue);
      newNode.iter = getFirstIter();
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListPackageNode AddLast(PackageWeakPtr value) {
    push_back(value);
    return new ListPackageNode(getLastIter(), this);
  }

  public void AddLast(ListPackageNode newNode) {
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      push_back(newNode.csharpvalue);
      newNode.iter = getLastIter();
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListPackageNode AddBefore(ListPackageNode node, PackageWeakPtr value) {
    return new ListPackageNode(insertNode(node.iter, value), this);
  }

  public void AddBefore(ListPackageNode node, ListPackageNode newNode) {
    ValidateNode(node);
    ValidateNewNode(newNode);
    if (!newNode.inlist) {
      newNode.iter = insertNode(node.iter, newNode.csharpvalue);
      newNode.inlist = true;
    } else {
      throw new global::System.InvalidOperationException("The " + newNode.GetType().Name + " node already belongs to a " + this.GetType().Name);
    }
  }

  public ListPackageNode AddAfter(ListPackageNode node, PackageWeakPtr value) {
    node = node.Next;
    return new ListPackageNode(insertNode(node.iter, value), this);
  }

  public void AddAfter(ListPackageNode node, ListPackageNode newNode) {
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

  public void Add(PackageWeakPtr value) {
    AddLast(value);
  }

  public void Remove(ListPackageNode node) {
    ValidateNode(node);
    eraseIter(node.iter);
  }

  public void CopyTo(PackageWeakPtr[] array, int index) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0 || index > array.Length)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    ListPackageNode node = this.First;
    if (node != null) {
      do {
        array[index++] = node.Value;
        node = node.Next;
      } while (node != null);
    }
  }

  internal void ValidateNode(ListPackageNode node) {
    if (node == null) {
      throw new System.ArgumentNullException("node");
    }
    if (!node.inlist || node.list != this) {
      throw new System.InvalidOperationException("node");
    }
  }

  internal void ValidateNewNode(ListPackageNode node) {
    if (node == null) {
      throw new System.ArgumentNullException("node");
    }
  }

  global::System.Collections.Generic.IEnumerator<PackageWeakPtr> global::System.Collections.Generic.IEnumerable<PackageWeakPtr>.GetEnumerator() {
    return new ListPackageEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ListPackageEnumerator(this);
  }

  public ListPackageEnumerator GetEnumerator() {
    return new ListPackageEnumerator(this);
  }

  public sealed class ListPackageEnumerator : global::System.Collections.IEnumerator,
    global::System.Collections.Generic.IEnumerator<PackageWeakPtr>
  {
    private ListPackage collectionRef;
    private ListPackageNode currentNode;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ListPackageEnumerator(ListPackage collection) {
      collectionRef = collection;
      currentNode = collection.First;
      currentIndex = 0;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public PackageWeakPtr Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (PackageWeakPtr)currentObject;
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

  public sealed class ListPackageNode {
    internal ListPackage list;
    internal System.IntPtr iter;
    internal PackageWeakPtr csharpvalue;
    internal bool inlist;

    public ListPackageNode(PackageWeakPtr value) {
      csharpvalue = value;
      inlist = false;
    }

    internal ListPackageNode(System.IntPtr iter, ListPackage list) {
      this.list = list;
      this.iter = iter;
      inlist = true;
    }

    public ListPackage List {
      get {
        return this.list;
      }
    }

    public ListPackageNode Next {
      get {
        if (list.getNextIter(iter) == System.IntPtr.Zero)
          return null;
        return new ListPackageNode(list.getNextIter(iter), list);
      }
    }

    public ListPackageNode Previous {
      get {
        if (list.getPrevIter(iter) == System.IntPtr.Zero)
          return null;
        return new ListPackageNode(list.getPrevIter(iter), list);
      }
    }

    public PackageWeakPtr Value {
      get {
        return list.getItem(this.iter);
      }
      set {
        list.setItem(this.iter, value);
      }
    }

    public static bool operator==(ListPackageNode node1, ListPackageNode node2) {
      if (object.ReferenceEquals(node1, null) && object.ReferenceEquals(node2, null))
        return true;
      if (object.ReferenceEquals(node1, null) || object.ReferenceEquals(node2, null))
        return false;
      return node1.Equals(node2);
    }

    public static bool operator!=(ListPackageNode node1, ListPackageNode node2) {
      if (node1 == null && node2 == null)
        return false;
      if (node1 == null || node2 == null)
        return true;
      return !node1.Equals(node2);
    }

    public bool Equals(ListPackageNode node) {
      if (node == null)
        return false;
      if (!node.inlist || !this.inlist)
        return object.ReferenceEquals(this, node);
      return list.equals(this.iter, node.iter);
    }

    public override bool Equals(object node) {
      return Equals((ListPackageNode)node);
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

  private void push_front(PackageWeakPtr x) {
    UltraAppKitPINVOKE.ListPackage_push_front(swigCPtr, PackageWeakPtr.getCPtr(x));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  private void push_back(PackageWeakPtr x) {
    UltraAppKitPINVOKE.ListPackage_push_back(swigCPtr, PackageWeakPtr.getCPtr(x));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveFirst() {
    UltraAppKitPINVOKE.ListPackage_RemoveFirst(swigCPtr);
  }

  public void RemoveLast() {
    UltraAppKitPINVOKE.ListPackage_RemoveLast(swigCPtr);
  }

  private uint size() {
    uint ret = UltraAppKitPINVOKE.ListPackage_size(swigCPtr);
    return ret;
  }

  public void Clear() {
    UltraAppKitPINVOKE.ListPackage_Clear(swigCPtr);
  }

  private PackageWeakPtr getItem(global::System.IntPtr iter) {
    PackageWeakPtr ret = new PackageWeakPtr(UltraAppKitPINVOKE.ListPackage_getItem(swigCPtr, iter), false);
    return ret;
  }

  private void setItem(global::System.IntPtr iter, PackageWeakPtr val) {
    UltraAppKitPINVOKE.ListPackage_setItem(swigCPtr, iter, PackageWeakPtr.getCPtr(val));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  private global::System.IntPtr getFirstIter() {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPackage_getFirstIter(swigCPtr);
    return ret;
  }

  private global::System.IntPtr getLastIter() {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPackage_getLastIter(swigCPtr);
    return ret;
  }

  private global::System.IntPtr getNextIter(global::System.IntPtr iter) {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPackage_getNextIter(swigCPtr, iter);
    return ret;
  }

  private global::System.IntPtr getPrevIter(global::System.IntPtr iter) {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPackage_getPrevIter(swigCPtr, iter);
    return ret;
  }

  public global::System.IntPtr insertNode(global::System.IntPtr iter, PackageWeakPtr value) {
    global::System.IntPtr ret = UltraAppKitPINVOKE.ListPackage_insertNode(swigCPtr, iter, PackageWeakPtr.getCPtr(value));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void eraseIter(global::System.IntPtr iter) {
    UltraAppKitPINVOKE.ListPackage_eraseIter(swigCPtr, iter);
  }

  private void deleteIter(global::System.IntPtr iter) {
    UltraAppKitPINVOKE.ListPackage_deleteIter(swigCPtr, iter);
  }

  public bool equals(global::System.IntPtr iter1, global::System.IntPtr iter2) {
    bool ret = UltraAppKitPINVOKE.ListPackage_equals(swigCPtr, iter1, iter2);
    return ret;
  }

  public ListPackage() : this(UltraAppKitPINVOKE.new_ListPackage(), true) {
  }

}
