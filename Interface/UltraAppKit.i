%module(directors=1) UltraAppKit
%{
%}

%begin %{
#include "UltraEngine.h"
%}

using namespace::std;

%include "common.i"
%include "typemaps.i"
%include "windows.i"
%include "std_string.i"
%include "std_wstring.i"
%include "std_shared_ptr.i"
%include "std_array.i"
%include "arrays_csharp.i"
%include "std_map.i"
%include "std_vector.i"
%include "std_list.i"
%include "carrays.i"

#define CALLBACK __stdcall
%apply unsigned char {BYTE,CHAR};
typedef unsigned long long uint64_t;
typedef long long          int64_t;

%cs_struct(LRESULT,  System.IntPtr);
%cs_struct(HWND, System.IntPtr);
%cs_struct(HDC,  System.IntPtr);
%cs_struct(HINSTANCE,  System.IntPtr);
%cs_struct(WNDCLASSW,  System.IntPtr);
%cs_struct(HMONITOR,  System.IntPtr);
%cs_struct(WPARAM,  int);
%cs_struct(LPARAM,  int);
%cs_struct(LRESULT,  System.IntPtr);

//experimental Inheritance support
%feature(director) Widget;
%feature(director) Asset;

%cs_callback(ProcessEvent, ProcessEventDelegate)
typedef bool (__stdcall *ProcessEvent)(const UltraEngine::Event&, shared_ptr<UltraEngine::Object>);

namespace UltraEngine
{  
    enum LabelStyle
    {
            LABEL_LEFT = 0,
            LABEL_DEFAULT = LABEL_LEFT,
            LABEL_RIGHT = 2,
            LABEL_CENTER = 1,
            LABEL_TOP = 0,
            LABEL_BOTTOM = 64,
            LABEL_MIDDLE = 4,
            LABEL_BORDER = 128
    };
}

%include "Ignore.i"
%include "Operators.i"
%include "Shared.i"
%include "Vectors.i"
%include "WeakPtr.i"
%include "Maps.i"
%include "ObjectExtension.i"
%include "includes.i"


