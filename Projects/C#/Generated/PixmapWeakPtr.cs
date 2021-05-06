//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PixmapWeakPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PixmapWeakPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PixmapWeakPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PixmapWeakPtr() {
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
          UltraAppKitPINVOKE.delete_PixmapWeakPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PixmapWeakPtr() : this(UltraAppKitPINVOKE.new_PixmapWeakPtr__SWIG_0(), true) {
  }

  public PixmapWeakPtr(PixmapWeakPtr arg0) : this(UltraAppKitPINVOKE.new_PixmapWeakPtr__SWIG_1(PixmapWeakPtr.getCPtr(arg0)), true) {
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public PixmapWeakPtr(Pixmap arg0) : this(UltraAppKitPINVOKE.new_PixmapWeakPtr__SWIG_2(Pixmap.getCPtr(arg0)), true) {
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(PixmapWeakPtr arg0) {
    UltraAppKitPINVOKE.PixmapWeakPtr_swap(swigCPtr, PixmapWeakPtr.getCPtr(arg0));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    UltraAppKitPINVOKE.PixmapWeakPtr_reset(swigCPtr);
  }

  public int use_count() {
    int ret = UltraAppKitPINVOKE.PixmapWeakPtr_use_count(swigCPtr);
    return ret;
  }

  public bool expired() {
    bool ret = UltraAppKitPINVOKE.PixmapWeakPtr_expired(swigCPtr);
    return ret;
  }

  public Pixmap lock_() {
    global::System.IntPtr cPtr = UltraAppKitPINVOKE.PixmapWeakPtr_lock_(swigCPtr);
    Pixmap ret = (cPtr == global::System.IntPtr.Zero) ? null : new Pixmap(cPtr, true);
    return ret;
  }

}