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

public class Loader : Object {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Loader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PInvoke.Loader_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Loader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          PInvoke.delete_Loader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public float dpi {
    set {
      PInvoke.Loader_dpi_set(swigCPtr, value);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = PInvoke.Loader_dpi_get(swigCPtr);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VectorStdWString extensions {
    set {
      PInvoke.Loader_extensions_set(swigCPtr, VectorStdWString.getCPtr(value));
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = PInvoke.Loader_extensions_get(swigCPtr);
      VectorStdWString ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorStdWString(cPtr, false);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mimetype {
    set {
      PInvoke.Loader_mimetype_set(swigCPtr, value);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = PInvoke.Loader_mimetype_get(swigCPtr);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PluginWeakPtr plugin {
    set {
      PInvoke.Loader_plugin_set(swigCPtr, PluginWeakPtr.getCPtr(value));
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = PInvoke.Loader_plugin_get(swigCPtr);
      PluginWeakPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new PluginWeakPtr(cPtr, false);
      if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Loader() : this(PInvoke.new_Loader(), true) {
  }

  public virtual bool Reload(Stream stream, Object o, LoadFlags flags) {
    bool ret = PInvoke.Loader_Reload__SWIG_0(swigCPtr, Stream.getCPtr(stream), Object.getCPtr(o), (int)flags);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Reload(Stream stream, Object o) {
    bool ret = PInvoke.Loader_Reload__SWIG_1(swigCPtr, Stream.getCPtr(stream), Object.getCPtr(o));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Continue(Object o) {
    PInvoke.Loader_Continue(swigCPtr, Object.getCPtr(o));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

}

}
