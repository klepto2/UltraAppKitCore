/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 4.0.2
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_Functions_WRAP_H_
#define SWIG_Functions_WRAP_H_

class SwigDirector_Object : public UltraEngine::Object, public Swig::Director {

public:
    SwigDirector_Object();
    virtual ~SwigDirector_Object();
    void swig_connect_director();
    void swig_init_callbacks();
};

class SwigDirector_Widget : public UltraEngine::Widget, public Swig::Director {

public:
    SwigDirector_Widget();
    virtual ~SwigDirector_Widget();
    virtual void Reset();
    virtual void ResetSwigPublic() {
      UltraEngine::Widget::Reset();
    }
    virtual bool OK();
    virtual bool OKSwigPublic() {
      return UltraEngine::Widget::OK();
    }
    virtual bool Cancel();
    virtual bool CancelSwigPublic() {
      return UltraEngine::Widget::Cancel();
    }
    virtual void UpdateColors();
    virtual void UpdateColorsSwigPublic() {
      UltraEngine::Widget::UpdateColors();
    }
    virtual bool Initialize(UltraEngine::WString const &text, int const x, int const y, int const width, int const height, std::shared_ptr< UltraEngine::Widget > parent, int const style);
    virtual bool Initialize(UltraEngine::WString const &text, int const x, int const y, int const width, int const height, std::shared_ptr< UltraEngine::Interface > parent, int const style);
    virtual bool SetParent(std::shared_ptr< UltraEngine::Widget > parent, int const position);
    virtual void SetItemText(int const iten, UltraEngine::WString const &text);
    virtual UltraEngine::WString GetItemText(int const iten);
    virtual void SetItemIcon(int const item, std::shared_ptr< UltraEngine::Icon > icon, float const scale = 1.0);
    virtual void SetItemPixmap(int const item, std::shared_ptr< UltraEngine::Pixmap > pixmap);
    virtual std::shared_ptr< UltraEngine::Widget > AddNode(UltraEngine::WString const &text, std::shared_ptr< UltraEngine::Icon > icon = NULL);
    virtual void SetInteractive(bool const interactive);
    virtual void SelectText(int const position, int const length);
    virtual void SetParent(std::shared_ptr< UltraEngine::Widget > parent);
    virtual bool Reload(nlohmann::json &j3);
    virtual bool Save(nlohmann::json &j3, UltraEngine::SaveFlags const flags);
    virtual void SetRadius(int const radius);
    virtual int GetRadius();
    virtual void SetPointer(UltraEngine::MousePointer const pointer);
    virtual void FilterItems(UltraEngine::WString const &filter);
    virtual std::shared_ptr< UltraEngine::Widget > GetNext();
    virtual std::shared_ptr< UltraEngine::Widget > GetPrev();
    virtual void CursorBlink();
    virtual void ModifyItem(int const index, UltraEngine::WString const &text);
    virtual void WindowDragBegin();
    virtual bool ProcessEvent(UltraEngine::Event const &e);
    virtual void MouseMove(int const x, int const y);
    virtual void MouseEnter(int const x, int const y);
    virtual void MouseLeave(int const x, int const y);
    virtual void MouseDown(UltraEngine::MouseButton const button, int const x, int const y);
    virtual void MouseRepeat(UltraEngine::MouseButton const button, int const x, int const y);
    virtual void MouseUp(UltraEngine::MouseButton const button, int const x, int const y);
    virtual void LoseFocus();
    virtual void DoubleClick(UltraEngine::MouseButton const button, int const x, int const y);
    virtual void TripleClick(UltraEngine::MouseButton const button, int const x, int const y);
    virtual void GainFocus();
    virtual void KeyDown(UltraEngine::KeyCode const key);
    virtual void KeyUp(UltraEngine::KeyCode const key);
    virtual void KeyChar(int const keychar);
    virtual void MouseWheel(int const delta, int const x, int const y);
    virtual void Activate();
    virtual bool FindOK();
    virtual void Paint(int const x, int const y, int const width, int const height);
    virtual void Paint();
    virtual bool FindCancel();
    virtual void SetSensitivity(int const sensitivity);
    virtual void Sort(bool const recursive);
    virtual void Hide();
    virtual void Show();
    virtual void Sort(int64_t order);
    virtual int AddBlock(std::shared_ptr< UltraEngine::Icon > icon, UltraEngine::iVec2 const &position, float const scale = 1.0, UltraEngine::Vec4 const &color = 1.0);
    virtual int AddBlock(std::shared_ptr< UltraEngine::Pixmap > pixmap, UltraEngine::iVec2 const &position, UltraEngine::Vec4 const &color = 1.0);
    virtual int AddBlock(UltraEngine::iVec2 const &position, UltraEngine::iVec2 const &size, UltraEngine::Vec4 const &color0 = UltraEngine::Vec4(0), bool const wireframe = false, float const radius = 0.0, float const gradient = 1.0);
    virtual int AddBlock(UltraEngine::WString const &text, UltraEngine::iVec2 const &position, UltraEngine::iVec2 const &size, UltraEngine::Vec4 const &color, int const alignment = 0);
    virtual void Invalidate(bool const recursive = false);
    virtual void Refresh();
    virtual std::string Debug();
    virtual void SetFontScale(float const scale);
    virtual void SetFontWeight(bool const bold);
    virtual void Lock();
    virtual void Unlock();
    virtual void Expand();
    virtual void Collapse();
    virtual bool Collapsed();
    virtual void SetColor(float const r, float const g, float const b, float const a = 1.0, UltraEngine::WidgetColor const index = UltraEngine::WIDGETCOLOR_BACKGROUND);
    virtual void SetColor(UltraEngine::Vec4 const &color, UltraEngine::WidgetColor const index = UltraEngine::WIDGETCOLOR_BACKGROUND);
    virtual void SetState(UltraEngine::WidgetState const state);
    virtual void SetState(bool const state);
    virtual UltraEngine::WidgetState GetState();
    virtual void SetIcon(std::shared_ptr< UltraEngine::Icon > icon, UltraEngine::PixmapAlignment const alignment = UltraEngine::PIXMAP_CENTER, float const scale = 1.0);
    virtual void SetPixmap(std::shared_ptr< UltraEngine::Pixmap > pixmap, UltraEngine::PixmapAlignment const alignment = UltraEngine::PIXMAP_CENTER, UltraEngine::TextureFilter const filter = UltraEngine::TEXTUREFILTER_LINEAR);
    virtual std::shared_ptr< UltraEngine::Pixmap > GetPixmap();
    virtual void Enable();
    virtual void Disable();
    virtual bool GetDisabled();
    virtual void SetRange(int const x, int const y);
    virtual void SetValue(int const value);
    virtual int GetValue();
    virtual UltraEngine::iVec2 GetRange();
    virtual int GetSelectedItem();
    virtual void SelectItem(int const index);
    virtual int AddItem(UltraEngine::WString const &text, bool const selected = false);
    virtual std::shared_ptr< UltraEngine::Widget > GetParent();
    virtual void SetText(UltraEngine::WString const &text);
    virtual int CountItems();
    virtual void ClearItems();
    virtual void RemoveItem(int const index);
    virtual void SetProgress(double const progress);
    virtual double GetProgress();
    virtual void SetRedrawFrequency(int const frequency);
    virtual void AddText(UltraEngine::WString const &text);
    virtual void Redraw();
    virtual void SetPadding(int const left, int const top, int const right, int const bottom);
    virtual UltraEngine::iVec4 GetPadding();
    virtual UltraEngine::iVec2 GetPosition(bool const global = false);
    virtual UltraEngine::iVec2 GetSize();
    virtual void Cut();
    virtual void Copy();
    virtual void Paste();
    virtual UltraEngine::iVec2 ClientSize();
    virtual std::shared_ptr< UltraEngine::Interface > GetInterface();
    virtual UltraEngine::WString GetText(bool const selected = false);
    virtual void SetLayout(int const left, int const right, int const top, int const bottom);
    virtual void SetShape(int x, int y, int width, int height);
    virtual void SetShape(UltraEngine::iVec2 const &position, UltraEngine::iVec2 const &size);
    virtual bool Hidden(bool const recursive = true);
    virtual std::shared_ptr< UltraEngine::Widget > GetWidgetAtPoint(int const x, int const y);
    virtual void UpdateLayout();
    virtual void Draw(int const x, int const y, int const width, int const height);
    virtual void Draw__(int const x, int const y, int const width, int const height);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)(void *, int, int, int, int, void *, int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback5_t)(void *, int, int, int, int, void *, int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback6_t)(void *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback7_t)(int, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback8_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback9_t)(int, void *, float);
    typedef void (SWIGSTDCALL* SWIG_Callback10_t)(int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback11_t)(int, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback12_t)(void *, void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback13_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback14_t)(unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback15_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback16_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback17_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback18_t)(void *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback19_t)(int);
    typedef int (SWIGSTDCALL* SWIG_Callback20_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback21_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback22_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback23_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback24_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback25_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback26_t)(int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback27_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback28_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback29_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback30_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback31_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback32_t)(int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback33_t)(int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback34_t)(int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback35_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback36_t)(int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback37_t)(int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback38_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback39_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback40_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback41_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback42_t)(int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback43_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback44_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback45_t)(int, int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback46_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback47_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback48_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback49_t)(unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback50_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback51_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback52_t)(long long);
    typedef int (SWIGSTDCALL* SWIG_Callback53_t)(void *, void *, float, void *);
    typedef int (SWIGSTDCALL* SWIG_Callback54_t)(void *, void *, float);
    typedef int (SWIGSTDCALL* SWIG_Callback55_t)(void *, void *);
    typedef int (SWIGSTDCALL* SWIG_Callback56_t)(void *, void *, void *);
    typedef int (SWIGSTDCALL* SWIG_Callback57_t)(void *, void *);
    typedef int (SWIGSTDCALL* SWIG_Callback58_t)(void *, void *, void *, unsigned int, float, float);
    typedef int (SWIGSTDCALL* SWIG_Callback59_t)(void *, void *, void *, unsigned int, float);
    typedef int (SWIGSTDCALL* SWIG_Callback60_t)(void *, void *, void *, unsigned int);
    typedef int (SWIGSTDCALL* SWIG_Callback61_t)(void *, void *, void *);
    typedef int (SWIGSTDCALL* SWIG_Callback62_t)(void *, void *);
    typedef int (SWIGSTDCALL* SWIG_Callback63_t)(void *, void *, void *, void *, int);
    typedef int (SWIGSTDCALL* SWIG_Callback64_t)(void *, void *, void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback65_t)(unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback66_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback67_t)();
    typedef char * (SWIGSTDCALL* SWIG_Callback68_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback69_t)(float);
    typedef void (SWIGSTDCALL* SWIG_Callback70_t)(unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback71_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback72_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback73_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback74_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback75_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback76_t)(float, float, float, float, int);
    typedef void (SWIGSTDCALL* SWIG_Callback77_t)(float, float, float, float);
    typedef void (SWIGSTDCALL* SWIG_Callback78_t)(float, float, float);
    typedef void (SWIGSTDCALL* SWIG_Callback79_t)(void *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback80_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback81_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback82_t)(unsigned int);
    typedef int (SWIGSTDCALL* SWIG_Callback83_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback84_t)(void *, int, float);
    typedef void (SWIGSTDCALL* SWIG_Callback85_t)(void *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback86_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback87_t)(void *, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback88_t)(void *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback89_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback90_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback91_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback92_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback93_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback94_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback95_t)(int);
    typedef int (SWIGSTDCALL* SWIG_Callback96_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback97_t)();
    typedef int (SWIGSTDCALL* SWIG_Callback98_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback99_t)(int);
    typedef int (SWIGSTDCALL* SWIG_Callback100_t)(void *, unsigned int);
    typedef int (SWIGSTDCALL* SWIG_Callback101_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback102_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback103_t)(void *);
    typedef int (SWIGSTDCALL* SWIG_Callback104_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback105_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback106_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback107_t)(double);
    typedef double (SWIGSTDCALL* SWIG_Callback108_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback109_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback110_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback111_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback112_t)(int, int, int, int);
    typedef void * (SWIGSTDCALL* SWIG_Callback113_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback114_t)(unsigned int);
    typedef void * (SWIGSTDCALL* SWIG_Callback115_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback116_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback117_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback118_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback119_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback120_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback121_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback122_t)(unsigned int);
    typedef void * (SWIGSTDCALL* SWIG_Callback123_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback124_t)(int, int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback125_t)(int, int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback126_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback127_t)(unsigned int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback128_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback129_t)(int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback130_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback131_t)(int, int, int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback132_t)(int, int, int, int);
    void swig_connect_director(SWIG_Callback0_t callbackReset, SWIG_Callback1_t callbackOK, SWIG_Callback2_t callbackCancel, SWIG_Callback3_t callbackUpdateColors, SWIG_Callback4_t callbackInitialize__SWIG_0, SWIG_Callback5_t callbackInitialize__SWIG_1, SWIG_Callback6_t callbackSetParent__SWIG_0, SWIG_Callback7_t callbackSetItemText, SWIG_Callback8_t callbackGetItemText, SWIG_Callback9_t callbackSetItemIcon__SWIG_0, SWIG_Callback10_t callbackSetItemIcon__SWIG_1, SWIG_Callback11_t callbackSetItemPixmap, SWIG_Callback12_t callbackAddNode__SWIG_0, SWIG_Callback13_t callbackAddNode__SWIG_1, SWIG_Callback14_t callbackSetInteractive, SWIG_Callback15_t callbackSelectText, SWIG_Callback16_t callbackSetParent__SWIG_1, SWIG_Callback17_t callbackReload, SWIG_Callback18_t callbackSave, SWIG_Callback19_t callbackSetRadius, SWIG_Callback20_t callbackGetRadius, SWIG_Callback21_t callbackSetPointer, SWIG_Callback22_t callbackFilterItems, SWIG_Callback23_t callbackGetNext, SWIG_Callback24_t callbackGetPrev, SWIG_Callback25_t callbackCursorBlink, SWIG_Callback26_t callbackModifyItem, SWIG_Callback27_t callbackWindowDragBegin, SWIG_Callback28_t callbackProcessEvent, SWIG_Callback29_t callbackMouseMove, SWIG_Callback30_t callbackMouseEnter, SWIG_Callback31_t callbackMouseLeave, SWIG_Callback32_t callbackMouseDown, SWIG_Callback33_t callbackMouseRepeat, SWIG_Callback34_t callbackMouseUp, SWIG_Callback35_t callbackLoseFocus, SWIG_Callback36_t callbackDoubleClick, SWIG_Callback37_t callbackTripleClick, SWIG_Callback38_t callbackGainFocus, SWIG_Callback39_t callbackKeyDown, SWIG_Callback40_t callbackKeyUp, SWIG_Callback41_t callbackKeyChar, SWIG_Callback42_t callbackMouseWheel, SWIG_Callback43_t callbackActivate, SWIG_Callback44_t callbackFindOK, SWIG_Callback45_t callbackPaint__SWIG_0, SWIG_Callback46_t callbackPaint__SWIG_1, SWIG_Callback47_t callbackFindCancel, SWIG_Callback48_t callbackSetSensitivity, SWIG_Callback49_t callbackSort__SWIG_0, SWIG_Callback50_t callbackHide, SWIG_Callback51_t callbackShow, SWIG_Callback52_t callbackSort__SWIG_1, SWIG_Callback53_t callbackAddBlock__SWIG_0, SWIG_Callback54_t callbackAddBlock__SWIG_1, SWIG_Callback55_t callbackAddBlock__SWIG_2, SWIG_Callback56_t callbackAddBlock__SWIG_3, SWIG_Callback57_t callbackAddBlock__SWIG_4, SWIG_Callback58_t callbackAddBlock__SWIG_5, SWIG_Callback59_t callbackAddBlock__SWIG_6, SWIG_Callback60_t callbackAddBlock__SWIG_7, SWIG_Callback61_t callbackAddBlock__SWIG_8, SWIG_Callback62_t callbackAddBlock__SWIG_9, SWIG_Callback63_t callbackAddBlock__SWIG_10, SWIG_Callback64_t callbackAddBlock__SWIG_11, SWIG_Callback65_t callbackInvalidate__SWIG_0, SWIG_Callback66_t callbackInvalidate__SWIG_1, SWIG_Callback67_t callbackRefresh, SWIG_Callback68_t callbackDebug, SWIG_Callback69_t callbackSetFontScale, SWIG_Callback70_t callbackSetFontWeight, SWIG_Callback71_t callbackLock, SWIG_Callback72_t callbackUnlock, SWIG_Callback73_t callbackExpand, SWIG_Callback74_t callbackCollapse, SWIG_Callback75_t callbackCollapsed, SWIG_Callback76_t callbackSetColor__SWIG_0, SWIG_Callback77_t callbackSetColor__SWIG_1, SWIG_Callback78_t callbackSetColor__SWIG_2, SWIG_Callback79_t callbackSetColor__SWIG_3, SWIG_Callback80_t callbackSetColor__SWIG_4, SWIG_Callback81_t callbackSetState__SWIG_0, SWIG_Callback82_t callbackSetState__SWIG_1, SWIG_Callback83_t callbackGetState, SWIG_Callback84_t callbackSetIcon__SWIG_0, SWIG_Callback85_t callbackSetIcon__SWIG_1, SWIG_Callback86_t callbackSetIcon__SWIG_2, SWIG_Callback87_t callbackSetPixmap__SWIG_0, SWIG_Callback88_t callbackSetPixmap__SWIG_1, SWIG_Callback89_t callbackSetPixmap__SWIG_2, SWIG_Callback90_t callbackGetPixmap, SWIG_Callback91_t callbackEnable, SWIG_Callback92_t callbackDisable, SWIG_Callback93_t callbackGetDisabled, SWIG_Callback94_t callbackSetRange, SWIG_Callback95_t callbackSetValue, SWIG_Callback96_t callbackGetValue, SWIG_Callback97_t callbackGetRange, SWIG_Callback98_t callbackGetSelectedItem, SWIG_Callback99_t callbackSelectItem, SWIG_Callback100_t callbackAddItem__SWIG_0, SWIG_Callback101_t callbackAddItem__SWIG_1, SWIG_Callback102_t callbackGetParent, SWIG_Callback103_t callbackSetText, SWIG_Callback104_t callbackCountItems, SWIG_Callback105_t callbackClearItems, SWIG_Callback106_t callbackRemoveItem, SWIG_Callback107_t callbackSetProgress, SWIG_Callback108_t callbackGetProgress, SWIG_Callback109_t callbackSetRedrawFrequency, SWIG_Callback110_t callbackAddText, SWIG_Callback111_t callbackRedraw, SWIG_Callback112_t callbackSetPadding, SWIG_Callback113_t callbackGetPadding, SWIG_Callback114_t callbackGetPosition__SWIG_0, SWIG_Callback115_t callbackGetPosition__SWIG_1, SWIG_Callback116_t callbackGetSize, SWIG_Callback117_t callbackCut, SWIG_Callback118_t callbackCopy, SWIG_Callback119_t callbackPaste, SWIG_Callback120_t callbackClientSize, SWIG_Callback121_t callbackGetInterface, SWIG_Callback122_t callbackGetText__SWIG_0, SWIG_Callback123_t callbackGetText__SWIG_1, SWIG_Callback124_t callbackSetLayout, SWIG_Callback125_t callbackSetShape__SWIG_0, SWIG_Callback126_t callbackSetShape__SWIG_1, SWIG_Callback127_t callbackHidden__SWIG_0, SWIG_Callback128_t callbackHidden__SWIG_1, SWIG_Callback129_t callbackGetWidgetAtPoint, SWIG_Callback130_t callbackUpdateLayout, SWIG_Callback131_t callbackDraw, SWIG_Callback132_t callbackDraw__);

private:
    SWIG_Callback0_t swig_callbackReset;
    SWIG_Callback1_t swig_callbackOK;
    SWIG_Callback2_t swig_callbackCancel;
    SWIG_Callback3_t swig_callbackUpdateColors;
    SWIG_Callback4_t swig_callbackInitialize__SWIG_0;
    SWIG_Callback5_t swig_callbackInitialize__SWIG_1;
    SWIG_Callback6_t swig_callbackSetParent__SWIG_0;
    SWIG_Callback7_t swig_callbackSetItemText;
    SWIG_Callback8_t swig_callbackGetItemText;
    SWIG_Callback9_t swig_callbackSetItemIcon__SWIG_0;
    SWIG_Callback10_t swig_callbackSetItemIcon__SWIG_1;
    SWIG_Callback11_t swig_callbackSetItemPixmap;
    SWIG_Callback12_t swig_callbackAddNode__SWIG_0;
    SWIG_Callback13_t swig_callbackAddNode__SWIG_1;
    SWIG_Callback14_t swig_callbackSetInteractive;
    SWIG_Callback15_t swig_callbackSelectText;
    SWIG_Callback16_t swig_callbackSetParent__SWIG_1;
    SWIG_Callback17_t swig_callbackReload;
    SWIG_Callback18_t swig_callbackSave;
    SWIG_Callback19_t swig_callbackSetRadius;
    SWIG_Callback20_t swig_callbackGetRadius;
    SWIG_Callback21_t swig_callbackSetPointer;
    SWIG_Callback22_t swig_callbackFilterItems;
    SWIG_Callback23_t swig_callbackGetNext;
    SWIG_Callback24_t swig_callbackGetPrev;
    SWIG_Callback25_t swig_callbackCursorBlink;
    SWIG_Callback26_t swig_callbackModifyItem;
    SWIG_Callback27_t swig_callbackWindowDragBegin;
    SWIG_Callback28_t swig_callbackProcessEvent;
    SWIG_Callback29_t swig_callbackMouseMove;
    SWIG_Callback30_t swig_callbackMouseEnter;
    SWIG_Callback31_t swig_callbackMouseLeave;
    SWIG_Callback32_t swig_callbackMouseDown;
    SWIG_Callback33_t swig_callbackMouseRepeat;
    SWIG_Callback34_t swig_callbackMouseUp;
    SWIG_Callback35_t swig_callbackLoseFocus;
    SWIG_Callback36_t swig_callbackDoubleClick;
    SWIG_Callback37_t swig_callbackTripleClick;
    SWIG_Callback38_t swig_callbackGainFocus;
    SWIG_Callback39_t swig_callbackKeyDown;
    SWIG_Callback40_t swig_callbackKeyUp;
    SWIG_Callback41_t swig_callbackKeyChar;
    SWIG_Callback42_t swig_callbackMouseWheel;
    SWIG_Callback43_t swig_callbackActivate;
    SWIG_Callback44_t swig_callbackFindOK;
    SWIG_Callback45_t swig_callbackPaint__SWIG_0;
    SWIG_Callback46_t swig_callbackPaint__SWIG_1;
    SWIG_Callback47_t swig_callbackFindCancel;
    SWIG_Callback48_t swig_callbackSetSensitivity;
    SWIG_Callback49_t swig_callbackSort__SWIG_0;
    SWIG_Callback50_t swig_callbackHide;
    SWIG_Callback51_t swig_callbackShow;
    SWIG_Callback52_t swig_callbackSort__SWIG_1;
    SWIG_Callback53_t swig_callbackAddBlock__SWIG_0;
    SWIG_Callback54_t swig_callbackAddBlock__SWIG_1;
    SWIG_Callback55_t swig_callbackAddBlock__SWIG_2;
    SWIG_Callback56_t swig_callbackAddBlock__SWIG_3;
    SWIG_Callback57_t swig_callbackAddBlock__SWIG_4;
    SWIG_Callback58_t swig_callbackAddBlock__SWIG_5;
    SWIG_Callback59_t swig_callbackAddBlock__SWIG_6;
    SWIG_Callback60_t swig_callbackAddBlock__SWIG_7;
    SWIG_Callback61_t swig_callbackAddBlock__SWIG_8;
    SWIG_Callback62_t swig_callbackAddBlock__SWIG_9;
    SWIG_Callback63_t swig_callbackAddBlock__SWIG_10;
    SWIG_Callback64_t swig_callbackAddBlock__SWIG_11;
    SWIG_Callback65_t swig_callbackInvalidate__SWIG_0;
    SWIG_Callback66_t swig_callbackInvalidate__SWIG_1;
    SWIG_Callback67_t swig_callbackRefresh;
    SWIG_Callback68_t swig_callbackDebug;
    SWIG_Callback69_t swig_callbackSetFontScale;
    SWIG_Callback70_t swig_callbackSetFontWeight;
    SWIG_Callback71_t swig_callbackLock;
    SWIG_Callback72_t swig_callbackUnlock;
    SWIG_Callback73_t swig_callbackExpand;
    SWIG_Callback74_t swig_callbackCollapse;
    SWIG_Callback75_t swig_callbackCollapsed;
    SWIG_Callback76_t swig_callbackSetColor__SWIG_0;
    SWIG_Callback77_t swig_callbackSetColor__SWIG_1;
    SWIG_Callback78_t swig_callbackSetColor__SWIG_2;
    SWIG_Callback79_t swig_callbackSetColor__SWIG_3;
    SWIG_Callback80_t swig_callbackSetColor__SWIG_4;
    SWIG_Callback81_t swig_callbackSetState__SWIG_0;
    SWIG_Callback82_t swig_callbackSetState__SWIG_1;
    SWIG_Callback83_t swig_callbackGetState;
    SWIG_Callback84_t swig_callbackSetIcon__SWIG_0;
    SWIG_Callback85_t swig_callbackSetIcon__SWIG_1;
    SWIG_Callback86_t swig_callbackSetIcon__SWIG_2;
    SWIG_Callback87_t swig_callbackSetPixmap__SWIG_0;
    SWIG_Callback88_t swig_callbackSetPixmap__SWIG_1;
    SWIG_Callback89_t swig_callbackSetPixmap__SWIG_2;
    SWIG_Callback90_t swig_callbackGetPixmap;
    SWIG_Callback91_t swig_callbackEnable;
    SWIG_Callback92_t swig_callbackDisable;
    SWIG_Callback93_t swig_callbackGetDisabled;
    SWIG_Callback94_t swig_callbackSetRange;
    SWIG_Callback95_t swig_callbackSetValue;
    SWIG_Callback96_t swig_callbackGetValue;
    SWIG_Callback97_t swig_callbackGetRange;
    SWIG_Callback98_t swig_callbackGetSelectedItem;
    SWIG_Callback99_t swig_callbackSelectItem;
    SWIG_Callback100_t swig_callbackAddItem__SWIG_0;
    SWIG_Callback101_t swig_callbackAddItem__SWIG_1;
    SWIG_Callback102_t swig_callbackGetParent;
    SWIG_Callback103_t swig_callbackSetText;
    SWIG_Callback104_t swig_callbackCountItems;
    SWIG_Callback105_t swig_callbackClearItems;
    SWIG_Callback106_t swig_callbackRemoveItem;
    SWIG_Callback107_t swig_callbackSetProgress;
    SWIG_Callback108_t swig_callbackGetProgress;
    SWIG_Callback109_t swig_callbackSetRedrawFrequency;
    SWIG_Callback110_t swig_callbackAddText;
    SWIG_Callback111_t swig_callbackRedraw;
    SWIG_Callback112_t swig_callbackSetPadding;
    SWIG_Callback113_t swig_callbackGetPadding;
    SWIG_Callback114_t swig_callbackGetPosition__SWIG_0;
    SWIG_Callback115_t swig_callbackGetPosition__SWIG_1;
    SWIG_Callback116_t swig_callbackGetSize;
    SWIG_Callback117_t swig_callbackCut;
    SWIG_Callback118_t swig_callbackCopy;
    SWIG_Callback119_t swig_callbackPaste;
    SWIG_Callback120_t swig_callbackClientSize;
    SWIG_Callback121_t swig_callbackGetInterface;
    SWIG_Callback122_t swig_callbackGetText__SWIG_0;
    SWIG_Callback123_t swig_callbackGetText__SWIG_1;
    SWIG_Callback124_t swig_callbackSetLayout;
    SWIG_Callback125_t swig_callbackSetShape__SWIG_0;
    SWIG_Callback126_t swig_callbackSetShape__SWIG_1;
    SWIG_Callback127_t swig_callbackHidden__SWIG_0;
    SWIG_Callback128_t swig_callbackHidden__SWIG_1;
    SWIG_Callback129_t swig_callbackGetWidgetAtPoint;
    SWIG_Callback130_t swig_callbackUpdateLayout;
    SWIG_Callback131_t swig_callbackDraw;
    SWIG_Callback132_t swig_callbackDraw__;
    void swig_init_callbacks();
};

class SwigDirector_Asset : public UltraEngine::Asset, public Swig::Director {

public:
    SwigDirector_Asset();
    virtual ~SwigDirector_Asset();
    virtual void Reset();
    virtual void Destroy();
    virtual void DestroySwigPublic() {
      UltraEngine::Asset::Destroy();
    }
    virtual bool Reload(std::shared_ptr< UltraEngine::Stream > stream, UltraEngine::LoadFlags const flags = UltraEngine::LOAD_DEFAULT);
    virtual UltraEngine::WString GetPath();
    virtual bool Reload(UltraEngine::LoadFlags const flags = UltraEngine::LOAD_DEFAULT);
    virtual std::shared_ptr< UltraEngine::Asset > Copy();
    virtual bool Save(UltraEngine::WString const &path, UltraEngine::SaveFlags const flags = UltraEngine::SAVE_DEFAULT);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback2_t)(void *, int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback4_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback5_t)(int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback6_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback7_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback8_t)(void *, int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback9_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackReset, SWIG_Callback1_t callbackDestroy, SWIG_Callback2_t callbackReload__SWIG_0, SWIG_Callback3_t callbackReload__SWIG_1, SWIG_Callback4_t callbackGetPath, SWIG_Callback5_t callbackReload__SWIG_2, SWIG_Callback6_t callbackReload__SWIG_3, SWIG_Callback7_t callbackCopy, SWIG_Callback8_t callbackSave__SWIG_0, SWIG_Callback9_t callbackSave__SWIG_1);

private:
    SWIG_Callback0_t swig_callbackReset;
    SWIG_Callback1_t swig_callbackDestroy;
    SWIG_Callback2_t swig_callbackReload__SWIG_0;
    SWIG_Callback3_t swig_callbackReload__SWIG_1;
    SWIG_Callback4_t swig_callbackGetPath;
    SWIG_Callback5_t swig_callbackReload__SWIG_2;
    SWIG_Callback6_t swig_callbackReload__SWIG_3;
    SWIG_Callback7_t swig_callbackCopy;
    SWIG_Callback8_t swig_callbackSave__SWIG_0;
    SWIG_Callback9_t swig_callbackSave__SWIG_1;
    void swig_init_callbacks();
};

class SwigDirector_FunctionDelegate : public FunctionDelegate, public Swig::Director {

public:
    SwigDirector_FunctionDelegate();
    virtual void Execute();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    void swig_connect_director(SWIG_Callback0_t callbackExecute);

private:
    SWIG_Callback0_t swig_callbackExecute;
    void swig_init_callbacks();
};


#endif
