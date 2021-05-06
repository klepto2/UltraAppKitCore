//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Asset : Object {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Asset(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UltraAppKitPINVOKE.Asset_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Asset obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          UltraAppKitPINVOKE.delete_Asset(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  protected virtual void Reset() {
    UltraAppKitPINVOKE.Asset_Reset(swigCPtr);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual void Destroy() {
    if (SwigDerivedClassHasMethod("Destroy", swigMethodTypes1)) UltraAppKitPINVOKE.Asset_DestroySwigExplicitAsset(swigCPtr); else UltraAppKitPINVOKE.Asset_Destroy(swigCPtr);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
  }

  protected virtual bool Reload(Stream stream, LoadFlags flags) {
    bool ret = UltraAppKitPINVOKE.Asset_Reload__SWIG_0(swigCPtr, Stream.getCPtr(stream), (int)flags);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  protected virtual bool Reload(Stream stream) {
    bool ret = UltraAppKitPINVOKE.Asset_Reload__SWIG_1(swigCPtr, Stream.getCPtr(stream));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public WString path {
    get {
      WString ret = new WString(UltraAppKitPINVOKE.Asset_path_get(swigCPtr), true);
      if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Asset() : this(UltraAppKitPINVOKE.new_Asset(), true) {
    SwigDirectorConnect();
  }

  public virtual WString GetPath() {
    WString ret = new WString((SwigDerivedClassHasMethod("GetPath", swigMethodTypes4) ? UltraAppKitPINVOKE.Asset_GetPathSwigExplicitAsset(swigCPtr) : UltraAppKitPINVOKE.Asset_GetPath(swigCPtr)), true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Reload(LoadFlags flags) {
    bool ret = UltraAppKitPINVOKE.Asset_Reload__SWIG_2(swigCPtr, (int)flags);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Reload() {
    bool ret = UltraAppKitPINVOKE.Asset_Reload__SWIG_3(swigCPtr);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Asset Copy() {
    global::System.IntPtr cPtr = UltraAppKitPINVOKE.Asset_Copy(swigCPtr);
    Asset ret = (cPtr == global::System.IntPtr.Zero) ? null : new Asset(cPtr, true);
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Save(WString path, SaveFlags flags) {
    bool ret = (SwigDerivedClassHasMethod("Save", swigMethodTypes8) ? UltraAppKitPINVOKE.Asset_SaveSwigExplicitAsset__SWIG_0(swigCPtr, WString.getCPtr(path), (int)flags) : UltraAppKitPINVOKE.Asset_Save__SWIG_0(swigCPtr, WString.getCPtr(path), (int)flags));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Save(WString path) {
    bool ret = (SwigDerivedClassHasMethod("Save", swigMethodTypes9) ? UltraAppKitPINVOKE.Asset_SaveSwigExplicitAsset__SWIG_1(swigCPtr, WString.getCPtr(path)) : UltraAppKitPINVOKE.Asset_Save__SWIG_1(swigCPtr, WString.getCPtr(path)));
    if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Reset", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateAsset_0(SwigDirectorMethodReset);
    if (SwigDerivedClassHasMethod("Destroy", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateAsset_1(SwigDirectorMethodDestroy);
    if (SwigDerivedClassHasMethod("Reload", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateAsset_2(SwigDirectorMethodReload__SWIG_0);
    if (SwigDerivedClassHasMethod("Reload", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateAsset_3(SwigDirectorMethodReload__SWIG_1);
    if (SwigDerivedClassHasMethod("GetPath", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateAsset_4(SwigDirectorMethodGetPath);
    if (SwigDerivedClassHasMethod("Reload", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateAsset_5(SwigDirectorMethodReload__SWIG_2);
    if (SwigDerivedClassHasMethod("Reload", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateAsset_6(SwigDirectorMethodReload__SWIG_3);
    if (SwigDerivedClassHasMethod("Copy", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateAsset_7(SwigDirectorMethodCopy);
    if (SwigDerivedClassHasMethod("Save", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateAsset_8(SwigDirectorMethodSave__SWIG_0);
    if (SwigDerivedClassHasMethod("Save", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateAsset_9(SwigDirectorMethodSave__SWIG_1);
    UltraAppKitPINVOKE.Asset_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Asset));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodReset() {
    Reset();
  }

  private void SwigDirectorMethodDestroy() {
    Destroy();
  }

  private bool SwigDirectorMethodReload__SWIG_0(global::System.IntPtr stream, int flags) {
    return Reload((stream == global::System.IntPtr.Zero) ? null : new Stream(stream, true), (LoadFlags)flags);
  }

  private bool SwigDirectorMethodReload__SWIG_1(global::System.IntPtr stream) {
    return Reload((stream == global::System.IntPtr.Zero) ? null : new Stream(stream, true));
  }

  private global::System.IntPtr SwigDirectorMethodGetPath() {
    return WString.getCPtr(GetPath()).Handle;
  }

  private bool SwigDirectorMethodReload__SWIG_2(int flags) {
    return Reload((LoadFlags)flags);
  }

  private bool SwigDirectorMethodReload__SWIG_3() {
    return Reload();
  }

  private global::System.IntPtr SwigDirectorMethodCopy() {
    return Asset.getCPtr(Copy()).Handle;
  }

  private bool SwigDirectorMethodSave__SWIG_0(global::System.IntPtr path, int flags) {
    return Save((path == global::System.IntPtr.Zero) ? null : new WString(path, true), (SaveFlags)flags);
  }

  private bool SwigDirectorMethodSave__SWIG_1(global::System.IntPtr path) {
    return Save((path == global::System.IntPtr.Zero) ? null : new WString(path, true));
  }

  public delegate void SwigDelegateAsset_0();
  public delegate void SwigDelegateAsset_1();
  public delegate bool SwigDelegateAsset_2(global::System.IntPtr stream, int flags);
  public delegate bool SwigDelegateAsset_3(global::System.IntPtr stream);
  public delegate global::System.IntPtr SwigDelegateAsset_4();
  public delegate bool SwigDelegateAsset_5(int flags);
  public delegate bool SwigDelegateAsset_6();
  public delegate global::System.IntPtr SwigDelegateAsset_7();
  public delegate bool SwigDelegateAsset_8(global::System.IntPtr path, int flags);
  public delegate bool SwigDelegateAsset_9(global::System.IntPtr path);

  private SwigDelegateAsset_0 swigDelegate0;
  private SwigDelegateAsset_1 swigDelegate1;
  private SwigDelegateAsset_2 swigDelegate2;
  private SwigDelegateAsset_3 swigDelegate3;
  private SwigDelegateAsset_4 swigDelegate4;
  private SwigDelegateAsset_5 swigDelegate5;
  private SwigDelegateAsset_6 swigDelegate6;
  private SwigDelegateAsset_7 swigDelegate7;
  private SwigDelegateAsset_8 swigDelegate8;
  private SwigDelegateAsset_9 swigDelegate9;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(Stream), typeof(LoadFlags) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(Stream) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(LoadFlags) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(WString), typeof(SaveFlags) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(WString) };
}
