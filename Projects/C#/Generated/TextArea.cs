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

public class TextArea : Widget {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal TextArea(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PInvoke.TextArea_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextArea obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          PInvoke.delete_TextArea(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TextArea() : this(PInvoke.new_TextArea(), true) {
  }

  public override void AddText(WString text) {
    PInvoke.TextArea_AddText(swigCPtr, WString.getCPtr(text));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void UpdateLayout() {
    PInvoke.TextArea_UpdateLayout(swigCPtr);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void SetShape(int x, int y, int width, int height) {
    PInvoke.TextArea_SetShape(swigCPtr, x, y, width, height);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void SetText(WString text) {
    PInvoke.TextArea_SetText(swigCPtr, WString.getCPtr(text));
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void KeyDown(KeyCode key) {
    PInvoke.TextArea_KeyDown(swigCPtr, (int)key);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void Draw(int x, int y, int width, int height) {
    PInvoke.TextArea_Draw(swigCPtr, x, y, width, height);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

  public override void MouseWheel(int delta, int x, int y) {
    PInvoke.TextArea_MouseWheel(swigCPtr, delta, x, y);
    if (PInvoke.SWIGPendingException.Pending) throw PInvoke.SWIGPendingException.Retrieve();
  }

}

}
