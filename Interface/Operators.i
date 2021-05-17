%rename(Equal) operator =;
%rename(PlusEqual) operator +=;
%rename(MinusEqual) operator -=;
%rename(MultiplyEqual) operator *=;
%rename(DivideEqual) operator /=;
%rename(PercentEqual) operator %=;
%rename(Plus) operator +;
%rename(Minus) operator -;
%rename(Multiply) operator *;
%rename(Divide) operator /;
%rename(Percent) operator %;
%rename(Not) operator !;
%rename(IndexIntoConst) operator[](unsigned idx) const;
%rename(IndexInto) operator[](unsigned idx);
%rename(Functor) operator ();
%rename(EqualEqual) operator ==;
%rename(NotEqual) operator !=;
%rename(LessThan) operator <;
%rename(LessThanEqual) operator <=;
%rename(GreaterThan) operator >;
%rename(GreaterThanEqual) operator >=;
%rename(And) operator &&;
%rename(Or) operator ||;
%rename(PlusPlusPrefix) operator++();
%rename(PlusPlusPostfix) operator++(int);
%rename(MinusMinusPrefix) operator--();
%rename(MinusMinusPostfix) operator--(int);
%rename(BinaryOR) operator |; 
%rename(BinaryNot) operator ~; 
%rename(BinaryAnd) operator &; 
%rename(IndexInto) *::operator[](unsigned idx); // some languages have a %rename *::operator[] already in place, which seems to takes precedence over the above %rename operator[].
%rename(_ToWString) operator std::wstring() const;

%csmethodmodifiers operator = "private";
%csmethodmodifiers operator += "private";
%csmethodmodifiers operator -= "private";
%csmethodmodifiers operator *= "private";
%csmethodmodifiers operator /= "private";
%csmethodmodifiers operator %= "private";
%csmethodmodifiers operator + "private";
%csmethodmodifiers operator - "private";
%csmethodmodifiers operator * "private";
%csmethodmodifiers operator / "private";
%csmethodmodifiers operator % "private";
%csmethodmodifiers operator ! "private";
%csmethodmodifiers operator[](unsigned idx) const "private";
%csmethodmodifiers operator[](unsigned idx) "private";
%csmethodmodifiers operator () "private";
%csmethodmodifiers operator == "private";
%csmethodmodifiers operator != "private";
%csmethodmodifiers operator < "private";
%csmethodmodifiers operator <= "private";
%csmethodmodifiers operator > "private";
%csmethodmodifiers operator >= "private";
%csmethodmodifiers operator && "private";
%csmethodmodifiers operator || "private";
%csmethodmodifiers operator++() "private";
%csmethodmodifiers operator++(int) "private";
%csmethodmodifiers operator--() "private";
%csmethodmodifiers operator--(int) "private";
%csmethodmodifiers operator | "private"; 
%csmethodmodifiers operator ~ "private"; 
%csmethodmodifiers operator & "private"; 
%csmethodmodifiers *::operator[](unsigned idx) "private";
%csmethodmodifiers operator std::wstring() const "private";

%define %cs_operator(CTYPE,CSTYPE)

%typemap(cscode) CTYPE %{
    public static CSTYPE operator+(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Plus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Minus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1) {
        return arg1.Minus();
    }

    public static CSTYPE operator/(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Divide(arg2);
    }

    public static CSTYPE operator*(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Multiply(arg2);
    }

    public static float operator%(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Percent(arg2);
    }

     public static bool operator==(CSTYPE arg1, CSTYPE arg2) {
         if ((object)arg1 == null)
            return (object)arg2 == null;

        if ((object)arg2 == null)
            return (object)arg1 == null;

        return arg1.EqualEqual(arg2);
    }

    public static bool operator!=(CSTYPE arg1, CSTYPE arg2) {
        return !(arg1 == arg2);
    }

    public static bool operator<(CSTYPE arg1, CSTYPE arg2) {
        return arg1.LessThan(arg2);
    }

    public static bool operator>(CSTYPE arg1, CSTYPE arg2) {
        return !arg1.LessThan(arg2) && !arg1.EqualEqual(arg2);
    }

    public override string ToString() {
        return _ToWString();
    }
%}
%enddef

%define %cs_operator_i(CTYPE,CSTYPE)

%typemap(cscode) CTYPE %{
    public static CSTYPE operator+(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Plus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Minus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1) {
        return arg1.Minus();
    }

     public static bool operator==(CSTYPE arg1, CSTYPE arg2) {
         if ((object)arg1 == null)
            return (object)arg2 == null;

        if ((object)arg2 == null)
            return (object)arg1 == null;

        return arg1.EqualEqual(arg2);
    }

    public static bool operator!=(CSTYPE arg1, CSTYPE arg2) {
        return !(arg1 == arg2);
    }

    public static bool operator<(CSTYPE arg1, CSTYPE arg2) {
        return arg1.LessThan(arg2);
    }

    public static bool operator>(CSTYPE arg1, CSTYPE arg2) {
        return !arg1.LessThan(arg2) && !arg1.EqualEqual(arg2);
    }

    public override string ToString() {
        return _ToWString();
    }
%}
%enddef

%define %cs_operator_i4(CTYPE,CSTYPE)

%typemap(cscode) CTYPE %{
    public static CSTYPE operator+(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Plus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Minus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1) {
        return arg1.Minus();
    }

    public override string ToString() {
        return _ToWString();
    }
%}
%enddef

%define %cs_operator_4(CTYPE,CSTYPE)

%typemap(cscode) CTYPE %{
     public static CSTYPE operator+(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Plus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Minus(arg2);
    }

    public static CSTYPE operator-(CSTYPE arg1) {
        return arg1.Minus();
    }

    public static CSTYPE operator/(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Divide(arg2);
    }

    public static CSTYPE operator*(CSTYPE arg1, CSTYPE arg2) {
        return arg1.Multiply(arg2);
    }

    public static bool operator==(CSTYPE arg1, CSTYPE arg2) {
         if ((object)arg1 == null)
            return (object)arg2 == null;

        if ((object)arg2 == null)
            return (object)arg1 == null;

        return arg1.EqualEqual(arg2);
    }

    public static bool operator!=(CSTYPE arg1, CSTYPE arg2) {
        return !(arg1 == arg2);
    }

    public static bool operator<(CSTYPE arg1, CSTYPE arg2) {
        return arg1.LessThan(arg2);
    }

    public static bool operator>(CSTYPE arg1, CSTYPE arg2) {
        return !arg1.LessThan(arg2) && !arg1.EqualEqual(arg2);
    }

    public override string ToString() {
        return _ToWString();
    }
%}
%enddef

%cs_operator(UltraEngine::Vec2,Vec2);
%cs_operator(UltraEngine::Vec3,Vec3);
%cs_operator_4(UltraEngine::Vec4,Vec4);
%cs_operator_i(UltraEngine::iVec2,iVec2);
%cs_operator_1(UltraEngine::iVec3,iVec3);
%cs_operator_i4(UltraEngine::iVec4,iVec4);


