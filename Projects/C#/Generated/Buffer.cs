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

public class Buffer : Object {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Buffer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PInvoke.Buffer_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Buffer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          PInvoke.delete_Buffer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Buffer() : this(PInvoke.new_Buffer__SWIG_0(), true) {
  }

  public Buffer(ulong size, bool isstatic) : this(PInvoke.new_Buffer__SWIG_1(size, isstatic), true) {
  }

  public virtual string Data() {
    string ret = PInvoke.Buffer_Data(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Clear() {
    PInvoke.Buffer_Clear(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual ulong GetSize() {
    ulong ret = PInvoke.Buffer_GetSize(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Resize(ulong size, bool padding) {
    bool ret = PInvoke.Buffer_Resize__SWIG_0(swigCPtr, size, padding);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Resize(ulong size) {
    bool ret = PInvoke.Buffer_Resize__SWIG_1(swigCPtr, size);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void PokeByte(ulong pos, byte c) {
    PInvoke.Buffer_PokeByte(swigCPtr, pos, c);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual void PokeShort(ulong pos, ushort i) {
    PInvoke.Buffer_PokeShort(swigCPtr, pos, i);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual void PokeInt(ulong pos, int i) {
    PInvoke.Buffer_PokeInt(swigCPtr, pos, i);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual void PokeFloat(ulong pos, float f) {
    PInvoke.Buffer_PokeFloat(swigCPtr, pos, f);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual void PokeDouble(ulong pos, double f) {
    PInvoke.Buffer_PokeDouble(swigCPtr, pos, f);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual void PokeString(ulong pos, String s) {
    PInvoke.Buffer_PokeString(swigCPtr, pos, String.getCPtr(s));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual void PokeWString(ulong pos, WString s) {
    PInvoke.Buffer_PokeWString(swigCPtr, pos, WString.getCPtr(s));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual byte PeekByte(ulong pos) {
    byte ret = PInvoke.Buffer_PeekByte(swigCPtr, pos);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort PeekShort(ulong pos) {
    ushort ret = PInvoke.Buffer_PeekShort(swigCPtr, pos);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int PeekInt(ulong pos) {
    int ret = PInvoke.Buffer_PeekInt(swigCPtr, pos);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float PeekFloat(ulong pos) {
    float ret = PInvoke.Buffer_PeekFloat(swigCPtr, pos);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double PeekDouble(ulong pos) {
    double ret = PInvoke.Buffer_PeekDouble(swigCPtr, pos);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual String PeekString(ulong pos) {
    String ret = new String(PInvoke.Buffer_PeekString(swigCPtr, pos), true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WString PeekWString(ulong pos) {
    WString ret = new WString(PInvoke.Buffer_PeekWString(swigCPtr, pos), true);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Copy(ulong srcoffset, Buffer dst, ulong dstoffset, ulong size) {
    PInvoke.Buffer_Copy(swigCPtr, srcoffset, Buffer.getCPtr(dst), dstoffset, size);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual bool Save(WString path) {
    bool ret = PInvoke.Buffer_Save(swigCPtr, WString.getCPtr(path));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
