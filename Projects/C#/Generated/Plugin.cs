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

public class Plugin : Asset {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Plugin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PInvoke.Plugin_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Plugin obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          PInvoke.delete_Plugin(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public WString title {
    get {
      WString ret = new WString(PInvoke.Plugin_title_get(swigCPtr), true);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string description {
    set {
      PInvoke.Plugin_description_set(swigCPtr, value);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = PInvoke.Plugin_description_get(swigCPtr);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public JSONWrapper properties {
    set {
      PInvoke.Plugin_properties_set(swigCPtr, JSONWrapper.getCPtr(value));
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = PInvoke.Plugin_properties_get(swigCPtr);
      JSONWrapper ret = (cPtr == global::System.IntPtr.Zero) ? null : new JSONWrapper(cPtr, false);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Plugin() : this(PInvoke.new_Plugin(), true) {
  }

  public virtual System.IntPtr CreateContext() { 
    System.IntPtr cPtr = PInvoke.Plugin_CreateContext(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return cPtr;
    }

  public virtual void FreeContext(System.IntPtr context) {
    PInvoke.Plugin_FreeContext(swigCPtr, context);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual bool SaveTexture(WString ext, TextureType type, int x, int y, TextureFormat format, VectorPixmap mipchain, int layers, SaveFlags flags) {
    bool ret = PInvoke.Plugin_SaveTexture(swigCPtr, WString.getCPtr(ext), (int)type, x, y, (int)format, VectorPixmap.getCPtr(mipchain), layers, (int)flags);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool ConvertPixmap(Pixmap src, Pixmap dst) {
    bool ret = PInvoke.Plugin_ConvertPixmap__SWIG_0(swigCPtr, Pixmap.getCPtr(src), Pixmap.getCPtr(dst));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Pixmap LoadPixmap(Buffer buffer, string path, int miplevel, int face, float scale) {
    global::System.IntPtr cPtr = PInvoke.Plugin_LoadPixmap(swigCPtr, Buffer.getCPtr(buffer), path, miplevel, face, scale);
    Pixmap ret = (cPtr == global::System.IntPtr.Zero) ? null : new Pixmap(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Pixmap ConvertPixmap(Pixmap src, int dstformat) {
    global::System.IntPtr cPtr = PInvoke.Plugin_ConvertPixmap__SWIG_1(swigCPtr, Pixmap.getCPtr(src), dstformat);
    Pixmap ret = (cPtr == global::System.IntPtr.Zero) ? null : new Pixmap(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new bool Reload(Stream stream, LoadFlags flags) {
    bool ret = PInvoke.Plugin_Reload__SWIG_0(swigCPtr, Stream.getCPtr(stream), (int)flags);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual new bool Reload(Stream stream) {
    bool ret = PInvoke.Plugin_Reload__SWIG_1(swigCPtr, Stream.getCPtr(stream));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Asset Copy() {
    global::System.IntPtr cPtr = PInvoke.Plugin_Copy(swigCPtr);
    Asset ret = (cPtr == global::System.IntPtr.Zero) ? null : new Asset(cPtr, true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual System.IntPtr GetFunction(string name) { 
    System.IntPtr cPtr = PInvoke.Plugin_GetFunction(swigCPtr, name);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return cPtr;
    }

  public virtual new void Reset() {
    PInvoke.Plugin_Reset(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override bool Reload(LoadFlags flags) {
    bool ret = PInvoke.Plugin_Reload__SWIG_2(swigCPtr, (int)flags);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Reload() {
    bool ret = PInvoke.Plugin_Reload__SWIG_3(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
