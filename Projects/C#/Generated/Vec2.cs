//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Vec2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vec2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vec2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vec2() {
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
          UltraAppKitPINVOKE.delete_Vec2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public float x {
    set {
      UltraAppKitPINVOKE.Vec2_x_set(swigCPtr, value);
    } 
    get {
      float ret = UltraAppKitPINVOKE.Vec2_x_get(swigCPtr);
      return ret;
    } 
  }

  public float r {
    set {
      UltraAppKitPINVOKE.Vec2_r_set(swigCPtr, value);
    } 
    get {
      float ret = UltraAppKitPINVOKE.Vec2_r_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      UltraAppKitPINVOKE.Vec2_y_set(swigCPtr, value);
    } 
    get {
      float ret = UltraAppKitPINVOKE.Vec2_y_get(swigCPtr);
      return ret;
    } 
  }

  public float g {
    set {
      UltraAppKitPINVOKE.Vec2_g_set(swigCPtr, value);
    } 
    get {
      float ret = UltraAppKitPINVOKE.Vec2_g_get(swigCPtr);
      return ret;
    } 
  }

  public Vec2() : this(UltraAppKitPINVOKE.new_Vec2__SWIG_0(), true) {
  }

  public Vec2(float x) : this(UltraAppKitPINVOKE.new_Vec2__SWIG_1(x), true) {
  }

  public Vec2(float x, float y) : this(UltraAppKitPINVOKE.new_Vec2__SWIG_2(x, y), true) {
  }

  public bool EqualEqual(Vec2 v) {
    bool ret = UltraAppKitPINVOKE.Vec2_EqualEqual(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool LessThan(Vec2 v) {
    bool ret = UltraAppKitPINVOKE.Vec2_LessThan(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void PlusEqual(Vec2 v) {
    UltraAppKitPINVOKE.Vec2_PlusEqual(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MinusEqual(Vec2 v) {
    UltraAppKitPINVOKE.Vec2_MinusEqual(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DivideEqual(Vec2 v) {
    UltraAppKitPINVOKE.Vec2_DivideEqual(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MultiplyEqual(Vec2 v) {
    UltraAppKitPINVOKE.Vec2_MultiplyEqual(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_float IndexInto(uint n) {
    SWIGTYPE_p_float ret = new SWIGTYPE_p_float(UltraAppKitPINVOKE.Vec2_IndexInto(swigCPtr, n), false);
    return ret;
  }

  public Vec2 Multiply(Vec2 v) {
    Vec2 ret = new Vec2(UltraAppKitPINVOKE.Vec2_Multiply(swigCPtr, Vec2.getCPtr(v)), true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vec2 Divide(Vec2 v) {
    Vec2 ret = new Vec2(UltraAppKitPINVOKE.Vec2_Divide(swigCPtr, Vec2.getCPtr(v)), true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vec2 Plus(Vec2 v) {
    Vec2 ret = new Vec2(UltraAppKitPINVOKE.Vec2_Plus(swigCPtr, Vec2.getCPtr(v)), true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vec2 Minus(Vec2 v) {
    Vec2 ret = new Vec2(UltraAppKitPINVOKE.Vec2_Minus__SWIG_0(swigCPtr, Vec2.getCPtr(v)), true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vec2 Minus() {
    Vec2 ret = new Vec2(UltraAppKitPINVOKE.Vec2_Minus__SWIG_1(swigCPtr), true);
    return ret;
  }

  public float Percent(Vec2 v) {
    float ret = UltraAppKitPINVOKE.Vec2_Percent(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Dot(Vec2 v) {
    float ret = UltraAppKitPINVOKE.Vec2_Dot(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vec2 Normalize() {
    Vec2 ret = new Vec2(UltraAppKitPINVOKE.Vec2_Normalize(swigCPtr), true);
    return ret;
  }

  public float Length() {
    float ret = UltraAppKitPINVOKE.Vec2_Length(swigCPtr);
    return ret;
  }

  public float DistanceToPoint(Vec2 v) {
    float ret = UltraAppKitPINVOKE.Vec2_DistanceToPoint(swigCPtr, Vec2.getCPtr(v));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
