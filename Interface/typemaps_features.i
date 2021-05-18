#define CALLBACK __stdcall
%apply unsigned char {BYTE,CHAR};
typedef unsigned long long uint64_t;
typedef long long          int64_t;

// input only arrays
CSHARP_ARRAYS(char *, string)
%typemap(imtype, inattributes="[global::System.Runtime.InteropServices.In, global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray, SizeParamIndex=0, ArraySubType=global::System.Runtime.InteropServices.UnmanagedType.LPStr)]") char *INPUT[] "string[]"

%apply char *INPUT[]  { char *argv[] }

%cs_struct(LRESULT,  System.IntPtr);
%cs_struct(HWND, System.IntPtr);
%cs_struct(HDC,  System.IntPtr);
%cs_struct(HINSTANCE,  System.IntPtr);
%cs_struct(WNDCLASSW,  System.IntPtr);
%cs_struct(HMONITOR,  System.IntPtr);
%cs_struct(WPARAM,  int);
%cs_struct(LPARAM,  int);
%cs_struct(LRESULT,  System.IntPtr);

%typemap(csattributes) enum UltraEngine::WindowStyles "[System.Flags]"
%typemap(csattributes) enum UltraEngine::LabelStyle "[System.Flags]"
%typemap(csattributes) enum UltraEngine::ButtonStyle "[System.Flags]"
%typemap(csattributes) enum UltraEngine::EntityBounds "[System.Flags]"
%typemap(csattributes) enum UltraEngine::LoadFlags "[System.Flags]"
%typemap(csattributes) enum UltraEngine::RenderLayer "[System.Flags]"
%typemap(csattributes) enum UltraEngine::SliderStyle "[System.Flags]"
%typemap(csattributes) enum UltraEngine::TextAlignment "[System.Flags]"
%typemap(csattributes) enum UltraEngine::TextFieldStyle "[System.Flags]"
%typemap(csattributes) enum UltraEngine::TextureFlags "[System.Flags]"
%typemap(csattributes) enum UltraEngine::TreeViewStyle "[System.Flags]"


//experimental Inheritance support
%feature(director) Object;
%feature(director) Widget;
%feature(director) Asset;
%feature(director) FunctionDelegate;


%cs_callback(ProcessEventHandler, ProcessEventHandlerDelegate)
%cs_callback(EntryPointHandler, EntryPointHandlerDelegate)