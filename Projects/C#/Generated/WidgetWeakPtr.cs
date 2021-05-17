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

public class WidgetWeakPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WidgetWeakPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WidgetWeakPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~WidgetWeakPtr() {
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
          PInvoke.delete_WidgetWeakPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public WidgetWeakPtr() : this(PInvoke.new_WidgetWeakPtr__SWIG_0(), true) {
  }

  public WidgetWeakPtr(WidgetWeakPtr arg0) : this(PInvoke.new_WidgetWeakPtr__SWIG_1(WidgetWeakPtr.getCPtr(arg0)), true) {
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public WidgetWeakPtr(Widget arg0) : this(PInvoke.new_WidgetWeakPtr__SWIG_2(Widget.getCPtr(arg0)), true) {
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void swap(WidgetWeakPtr arg0) {
    PInvoke.WidgetWeakPtr_swap(swigCPtr, WidgetWeakPtr.getCPtr(arg0));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public void reset() {
    PInvoke.WidgetWeakPtr_reset(swigCPtr);
  }

  public int use_count() {
    int ret = PInvoke.WidgetWeakPtr_use_count(swigCPtr);
    return ret;
  }

  public bool expired() {
    bool ret = PInvoke.WidgetWeakPtr_expired(swigCPtr);
    return ret;
  }

  public Widget lock_() {
    global::System.IntPtr cPtr = PInvoke.WidgetWeakPtr_lock_(swigCPtr);
    Widget ret = (cPtr == global::System.IntPtr.Zero) ? null : new Widget(cPtr, true);
    return ret;
  }

}

}
