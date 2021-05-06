//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PluginWeakPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PluginWeakPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PluginWeakPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PluginWeakPtr() {
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
          UltraAppKitPINVOKE.delete_PluginWeakPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PluginWeakPtr() : this(UltraAppKitPINVOKE.new_PluginWeakPtr__SWIG_0(), true) {
  }

  public PluginWeakPtr(PluginWeakPtr arg0) : this(UltraAppKitPINVOKE.new_PluginWeakPtr__SWIG_1(PluginWeakPtr.getCPtr(arg0)), true) {
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public PluginWeakPtr(Plugin arg0) : this(UltraAppKitPINVOKE.new_PluginWeakPtr__SWIG_2(Plugin.getCPtr(arg0)), true) {
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(PluginWeakPtr arg0) {
    UltraAppKitPINVOKE.PluginWeakPtr_swap(swigCPtr, PluginWeakPtr.getCPtr(arg0));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    UltraAppKitPINVOKE.PluginWeakPtr_reset(swigCPtr);
  }

  public int use_count() {
    int ret = UltraAppKitPINVOKE.PluginWeakPtr_use_count(swigCPtr);
    return ret;
  }

  public bool expired() {
    bool ret = UltraAppKitPINVOKE.PluginWeakPtr_expired(swigCPtr);
    return ret;
  }

  public Plugin lock_() {
    global::System.IntPtr cPtr = UltraAppKitPINVOKE.PluginWeakPtr_lock_(swigCPtr);
    Plugin ret = (cPtr == global::System.IntPtr.Zero) ? null : new Plugin(cPtr, true);
    return ret;
  }

}
