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

public class iVec3 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal iVec3(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(iVec3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~iVec3() {
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
          PInvoke.delete_iVec3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int x {
    set {
      PInvoke.iVec3_x_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.iVec3_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      PInvoke.iVec3_y_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.iVec3_y_get(swigCPtr);
      return ret;
    } 
  }

  public int z {
    set {
      PInvoke.iVec3_z_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.iVec3_z_get(swigCPtr);
      return ret;
    } 
  }

  public iVec3() : this(PInvoke.new_iVec3__SWIG_0(), true) {
  }

  public iVec3(int x, int y, int z) : this(PInvoke.new_iVec3__SWIG_1(x, y, z), true) {
  }

  private iVec3 Minus() {
    iVec3 ret = new iVec3(PInvoke.iVec3_Minus__SWIG_0(swigCPtr), true);
    return ret;
  }

  private iVec3 Plus(iVec3 v) {
    iVec3 ret = new iVec3(PInvoke.iVec3_Plus(swigCPtr, iVec3.getCPtr(v)), true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private iVec3 Minus(iVec3 v) {
    iVec3 ret = new iVec3(PInvoke.iVec3_Minus__SWIG_1(swigCPtr, iVec3.getCPtr(v)), true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private void PlusEqual(iVec3 v) {
    PInvoke.iVec3_PlusEqual(swigCPtr, iVec3.getCPtr(v));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private void MinusEqual(iVec3 v) {
    PInvoke.iVec3_MinusEqual(swigCPtr, iVec3.getCPtr(v));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  private string _ToWString() {
    string ret = PInvoke.iVec3__ToWString(swigCPtr);
    return ret;
  }

  private bool EqualEqual(iVec3 v) {
    bool ret = PInvoke.iVec3_EqualEqual(swigCPtr, iVec3.getCPtr(v));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool NotEqual(iVec3 v) {
    bool ret = PInvoke.iVec3_NotEqual(swigCPtr, iVec3.getCPtr(v));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
