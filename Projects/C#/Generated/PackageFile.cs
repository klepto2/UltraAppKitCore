//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class PackageFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PackageFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PackageFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PackageFile() {
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
          UltraAppKitPINVOKE.delete_PackageFile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public WString path {
    set {
      UltraAppKitPINVOKE.PackageFile_path_set(swigCPtr, WString.getCPtr(value));
      if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      WString ret = new WString(UltraAppKitPINVOKE.PackageFile_path_get(swigCPtr), true);
      if (UltraAppKitPINVOKE.SWIGPendingException.Pending) throw UltraAppKitPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int type {
    set {
      UltraAppKitPINVOKE.PackageFile_type_set(swigCPtr, value);
    } 
    get {
      int ret = UltraAppKitPINVOKE.PackageFile_type_get(swigCPtr);
      return ret;
    } 
  }

  public int index {
    set {
      UltraAppKitPINVOKE.PackageFile_index_set(swigCPtr, value);
    } 
    get {
      int ret = UltraAppKitPINVOKE.PackageFile_index_get(swigCPtr);
      return ret;
    } 
  }

  public ulong size {
    set {
      UltraAppKitPINVOKE.PackageFile_size_set(swigCPtr, value);
    } 
    get {
      ulong ret = UltraAppKitPINVOKE.PackageFile_size_get(swigCPtr);
      return ret;
    } 
  }

  public PackageFile() : this(UltraAppKitPINVOKE.new_PackageFile(), true) {
  }

}