//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxDocumentInfo : FbxObject {
  internal FbxDocumentInfo(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxDocumentInfo Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxDocumentInfo_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxDocumentInfo Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxDocumentInfo_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyString LastSavedUrl {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_LastSavedUrl_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString Url {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_Url_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxProperty Original {
    get {
      FbxProperty ret = new FbxProperty(NativeMethods.FbxDocumentInfo_Original_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString Original_ApplicationVendor {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_Original_ApplicationVendor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString Original_ApplicationName {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_Original_ApplicationName_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString Original_ApplicationVersion {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_Original_ApplicationVersion_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString Original_FileName {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_Original_FileName_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxProperty LastSaved {
    get {
      FbxProperty ret = new FbxProperty(NativeMethods.FbxDocumentInfo_LastSaved_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString LastSaved_ApplicationVendor {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_LastSaved_ApplicationVendor_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString LastSaved_ApplicationName {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_LastSaved_ApplicationName_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString LastSaved_ApplicationVersion {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_LastSaved_ApplicationVersion_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyString EmbeddedUrl {
    get {
      FbxPropertyString ret = new FbxPropertyString(NativeMethods.FbxDocumentInfo_EmbeddedUrl_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mTitle {
    set {
      NativeMethods.FbxDocumentInfo_mTitle_set(swigCPtr, value);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NativeMethods.FbxDocumentInfo_mTitle_get(swigCPtr);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mSubject {
    set {
      NativeMethods.FbxDocumentInfo_mSubject_set(swigCPtr, value);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NativeMethods.FbxDocumentInfo_mSubject_get(swigCPtr);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mAuthor {
    set {
      NativeMethods.FbxDocumentInfo_mAuthor_set(swigCPtr, value);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NativeMethods.FbxDocumentInfo_mAuthor_get(swigCPtr);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mKeywords {
    set {
      NativeMethods.FbxDocumentInfo_mKeywords_set(swigCPtr, value);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NativeMethods.FbxDocumentInfo_mKeywords_get(swigCPtr);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mRevision {
    set {
      NativeMethods.FbxDocumentInfo_mRevision_set(swigCPtr, value);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NativeMethods.FbxDocumentInfo_mRevision_get(swigCPtr);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mComment {
    set {
      NativeMethods.FbxDocumentInfo_mComment_set(swigCPtr, value);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NativeMethods.FbxDocumentInfo_mComment_get(swigCPtr);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void Clear() {
    NativeMethods.FbxDocumentInfo_Clear(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxDocumentInfo other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxDocumentInfo;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxDocumentInfo).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxDocumentInfo a, FbxDocumentInfo b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxDocumentInfo a, FbxDocumentInfo b) {
    return !(a == b);
  }

}

}
