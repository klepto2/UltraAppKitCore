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

public class Character : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Character(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Character obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Character() {
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
          PInvoke.delete_Character(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Vec4 texcoords {
    set {
      PInvoke.Character_texcoords_set(swigCPtr, Vec4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = PInvoke.Character_texcoords_get(swigCPtr);
      Vec4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vec4(cPtr, false);
      return ret;
    } 
  }

  public int id {
    set {
      PInvoke.Character_id_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.Character_id_get(swigCPtr);
      return ret;
    } 
  }

  public int spacing {
    set {
      PInvoke.Character_spacing_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.Character_spacing_get(swigCPtr);
      return ret;
    } 
  }

  public int x {
    set {
      PInvoke.Character_x_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.Character_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      PInvoke.Character_y_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.Character_y_get(swigCPtr);
      return ret;
    } 
  }

  public int width {
    set {
      PInvoke.Character_width_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.Character_width_get(swigCPtr);
      return ret;
    } 
  }

  public int height {
    set {
      PInvoke.Character_height_set(swigCPtr, value);
    } 
    get {
      int ret = PInvoke.Character_height_get(swigCPtr);
      return ret;
    } 
  }

  public Character() : this(PInvoke.new_Character(), true) {
  }

}

}
