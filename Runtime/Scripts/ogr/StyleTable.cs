//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.OGR {

using global::System;
using global::System.Runtime.InteropServices;

public class StyleTable : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public StyleTable(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(StyleTable obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(StyleTable obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(StyleTable obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~StyleTable() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrPINVOKE.delete_StyleTable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public StyleTable() : this(OgrPINVOKE.new_StyleTable(), true, null) {
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddStyle(string pszName, string pszStyleString) {
    int ret = OgrPINVOKE.StyleTable_AddStyle(swigCPtr, pszName, pszStyleString);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadStyleTable(string utf8_path) {
    int ret = OgrPINVOKE.StyleTable_LoadStyleTable(swigCPtr, Ogr.StringToUtf8Bytes(utf8_path));
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SaveStyleTable(string utf8_path) {
    int ret = OgrPINVOKE.StyleTable_SaveStyleTable(swigCPtr, Ogr.StringToUtf8Bytes(utf8_path));
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string Find(string pszName) {
    string ret = OgrPINVOKE.StyleTable_Find(swigCPtr, pszName);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ResetStyleStringReading() {
    OgrPINVOKE.StyleTable_ResetStyleStringReading(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetNextStyle() {
    string ret = OgrPINVOKE.StyleTable_GetNextStyle(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetLastStyleName() {
    string ret = OgrPINVOKE.StyleTable_GetLastStyleName(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
