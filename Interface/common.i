%define %cs_struct2_shared_part(TYPE, CTYPE, CSTYPE)
        %ignore TYPE;
        %typemap(ctype)                 TYPE*, TYPE&  %{ TYPE* %}
        %typemap(in)                    TYPE*, TYPE&  %{ $1 = $input; %}

        %typemap(varin)                 TYPE*, TYPE&  %{ $1 = $input; %}
        %typemap(memberin)              TYPE*, TYPE&  %{ $1 = $input; %}
        %typemap(out, null="NULL")      TYPE*, TYPE&  %{ $result = $1;
%}
        %typemap(imtype, out="System.IntPtr")  TYPE*, TYPE&  %{ ref CSTYPE %}
        %typemap(imtype)                TYPE* OUTPUT, TYPE& OUTPUT
                %{ out CSTYPE %}
        %typemap(cstype, out="CSTYPE")  TYPE*, TYPE&  %{ ref CSTYPE %}
        %typemap(cstype, out="CSTYPE")  TYPE* OUTPUT, TYPE& OUTPUT
                %{ out CSTYPE %}
        %typemap(cstype)                const TYPE*, const TYPE&
                %{ CSTYPE %}
        %typemap(csin)                  TYPE*, TYPE&  %{ ref $csinput %}
        %typemap(csin)                  TYPE* OUTPUT, TYPE& OUTPUT
                %{ out $csinput %}
        %typemap(csin)                  const TYPE*, const TYPE&
                %{ ref $csinput %}
        %typemap(csout, excode=SWIGEXCODE) TYPE*, TYPE& {
                System.IntPtr ptr = $imcall;$excode
                CSTYPE ret = (CSTYPE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr,
typeof(CSTYPE));
                return ret;
        }
        %typemap(csvarout, excode=SWIGEXCODE2) TYPE*, TYPE&
        %{
                get {
                        System.IntPtr ptr = $imcall;$excode
                        CSTYPE ret = (CSTYPE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(ptr,
typeof(CSTYPE));
                        return ret;
                }
        %}
        %apply TYPE* OUTPUT { TYPE* result };
        %apply TYPE& OUTPUT { TYPE& result };
%enddef
%define %cs_struct2(TYPE, CTYPE, CSTYPE)
        %cs_struct2_shared_part(TYPE, CTYPE, CSTYPE)
        %typemap(ctype)                 TYPE          %{ CTYPE %}
        %typemap(in)                    TYPE
                %{ $1 = *(TYPE*)&$input; %}
        %typemap(varin)                 TYPE
                %{ $1 = *(TYPE*)&$input; %}
        %typemap(memberin)              TYPE
                %{ $1 = *(TYPE*)&$input; %}
        %typemap(out, null=#CTYPE "()") TYPE
                %{ $result = *(CTYPE*)&$1; %}
        %typemap(imtype)                TYPE          %{ CSTYPE %}
        %typemap(cstype)                TYPE          %{ CSTYPE %}
        %typemap(csin)                  TYPE          %{ $csinput %}
        %typemap(csout, excode=SWIGEXCODE) TYPE {
                CSTYPE ret = $imcall;$excode
                return ret;
        }
        %typemap(csvarout, excode=SWIGEXCODE2) TYPE
        %{
                get {
                        CSTYPE ret = $imcall;$excode
                        return ret;
                }
        %}
%enddef
%define %cs_struct(TYPE, CSTYPE)
        %cs_struct2(TYPE, TYPE, CSTYPE)
%enddef


%typemap(ctype)  void* "void *"
%typemap(imtype) void* "System.IntPtr"
%typemap(cstype) void* "System.IntPtr"
%typemap(csin)   void* "$csinput"
%typemap(in)     void* %{ $1 = $input; %}
%typemap(out)    void* %{ $result = $1; %}
%typemap(csout, excode=SWIGEXCODE)  void* { 
    System.IntPtr cPtr = $imcall;$excode
    return cPtr;
    }
%typemap(csvarout, excode=SWIGEXCODE2) void* %{ 
    get {
        System.IntPtr cPtr = $imcall;$excode 
        return cPtr; 
   } 
%} 

%define %cs_callback(TYPE, CSTYPE)
	%typemap(ctype) TYPE, TYPE& "void*"
	%typemap(in) TYPE  %{ $1 = ($1_type)$input; %}
	%typemap(in) TYPE& %{ $1 = ($1_type)&$input; %}
	%typemap(imtype, out="System.IntPtr") TYPE, TYPE& "CSTYPE"
	%typemap(cstype, out="System.IntPtr") TYPE, TYPE& "CSTYPE"
	%typemap(csin) TYPE, TYPE& "$csinput"
%enddef