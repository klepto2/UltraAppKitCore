%module(directors=1, imclassname="PInvoke") Functions
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

%pragma(csharp) moduleclassmodifiers="public partial class"

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

//experimental Inheritance support
%feature(director) Object;
%feature(director) Widget;
%feature(director) Asset;
%feature(director) FunctionDelegate;

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

%rename(JSONWrapper) nlohmann::json;

namespace nlohmann
{  
    class json
    {
        public:
           std::string dump();
    };
}

%cs_callback(ProcessEventHandler, ProcessEventHandlerDelegate)
%cs_callback(EntryPointHandler, EntryPointHandlerDelegate)

%include "Ignore.i"
%include "Operators.i"
%include "Shared.i"
%include "Vectors.i"
%include "WeakPtr.i"
%include "Maps.i"
%include "ObjectExtensions.i"
%include "includes.i"


%rename("%s") UltraEngine::ListenEvent;
%rename("%s") UltraEngine::CreateThread;

%inline %{
typedef bool (__stdcall* ProcessEventHandler)(const UltraEngine::Event&, shared_ptr<UltraEngine::Object>);
typedef shared_ptr<UltraEngine::Object> (__stdcall* EntryPointHandler)(shared_ptr<UltraEngine::Object> o);

class FunctionDelegate
{
public:
	virtual void Execute() = 0;
};

class FunctionHandler
{
private:
	FunctionDelegate* delegate_;
public:
	FunctionHandler(FunctionDelegate* d)
	{
		delegate_ = d;
	}

	void operator()() const
	{
		delegate_->Execute();
	}
};


void ListenEvent(const UltraEngine::EventID id, shared_ptr<UltraEngine::Object> source, FunctionDelegate* callback)
{
	UltraEngine::ListenEvent(id, source, FunctionHandler(callback));
}


void ListenEvent_Internal(const UltraEngine::EventID id, shared_ptr<UltraEngine::Object> source, ProcessEventHandler callback, shared_ptr<UltraEngine::Object> extra = NULL)
{
	UltraEngine::ListenEvent(id, source, callback, extra);
}

shared_ptr<UltraEngine::Thread> CreateThread_Internal(EntryPointHandler entryPoint, shared_ptr<UltraEngine::Object> o = nullptr, const bool start = false)
{
	return UltraEngine::CreateThread(entryPoint, o, start);
}

shared_ptr<UltraEngine::Thread> CreateThread(FunctionDelegate* instruction, const bool start = false)
{
	return UltraEngine::CreateThread(FunctionHandler(instruction), start);
}
%}






