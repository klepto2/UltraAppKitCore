%module(directors=1, imclassname="PInvoke") Functions
%{
%}

%begin %{
#include "UltraEngine.h"
%}

using namespace::std;

%include "enums.swg"
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

%include "typemaps_features.i"
%include "renames.i"
%include "ultraengine_helper.i"
%include "ignore.i"
%include "operators.i"
%include "shared.i"
%include "vectors.i"
%include "weakptr.i"
%include "maps.i"
%include "extensions.i"
%include "includes.i"
%include "inline_additions.i"








