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

public class Slider : Widget {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Slider(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PInvoke.Slider_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Slider obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          PInvoke.delete_Slider(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Slider() : this(PInvoke.new_Slider(), true) {
  }

  public override void SetValue(int value) {
    PInvoke.Slider_SetValue(swigCPtr, value);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseMove(int x, int y) {
    PInvoke.Slider_MouseMove(swigCPtr, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseDown(MouseButton button, int x, int y) {
    PInvoke.Slider_MouseDown(swigCPtr, (int)button, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseRepeat(MouseButton button, int x, int y) {
    PInvoke.Slider_MouseRepeat(swigCPtr, (int)button, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseUp(MouseButton button, int x, int y) {
    PInvoke.Slider_MouseUp(swigCPtr, (int)button, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void KeyDown(KeyCode key) {
    PInvoke.Slider_KeyDown(swigCPtr, (int)key);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseWheel(int delta, int x, int y) {
    PInvoke.Slider_MouseWheel(swigCPtr, delta, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseLeave(int x, int y) {
    PInvoke.Slider_MouseLeave(swigCPtr, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public virtual int GetValueAtPosition(int x) {
    int ret = PInvoke.Slider_GetValueAtPosition(swigCPtr, x);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Draw(int x, int y, int width, int height) {
    PInvoke.Slider_Draw(swigCPtr, x, y, width, height);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

}

}
