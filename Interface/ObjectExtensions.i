//Extends UltraEngine::Object to add:
//1. support for Up-/Down Casting
//2. Comparison of objects (the internal c reference ptr is different due the use of shared_ptrs)

%define ObjectExtendAs(name, T)
%extend UltraEngine::Object {
    shared_ptr<T> name() {
    return (self)->As<T>();
    }
 }
%enddef

ObjectExtendAs(AsAsset,UltraEngine::Asset);
ObjectExtendAs(AsBuffer,UltraEngine::Buffer);
ObjectExtendAs(AsClock,UltraEngine::Clock);
ObjectExtendAs(AsDisplay,UltraEngine::Display);
ObjectExtendAs(AsFileSystemWatcher,UltraEngine::FileSystemWatcher);
ObjectExtendAs(AsGameEngine,UltraEngine::GameEngine);
ObjectExtendAs(AsIDSystem,UltraEngine::IDSystem);
ObjectExtendAs(AsInterface,UltraEngine::Interface);
ObjectExtendAs(AsLanguage,UltraEngine::Language);
ObjectExtendAs(AsLoader,UltraEngine::Loader);
ObjectExtendAs(AsMutex,UltraEngine::Mutex);
ObjectExtendAs(AsProcess,UltraEngine::Process);
ObjectExtendAs(AsStream,UltraEngine::Stream);
ObjectExtendAs(AsString,UltraEngine::String);
ObjectExtendAs(AsThread,UltraEngine::Thread);
ObjectExtendAs(AsTimer,UltraEngine::Timer);
ObjectExtendAs(AsWString,UltraEngine::WString);
ObjectExtendAs(AsWidget,UltraEngine::Widget);
ObjectExtendAs(AsWidgetItem,UltraEngine::WidgetItem);
ObjectExtendAs(AsWindow,UltraEngine::Window);
ObjectExtendAs(AsBufferStream,UltraEngine::BufferStream);
ObjectExtendAs(AsButton,UltraEngine::Button);
ObjectExtendAs(AsComboBox,UltraEngine::ComboBox);
ObjectExtendAs(AsDDSTextureLoader,UltraEngine::DDSTextureLoader);
ObjectExtendAs(AsFont,UltraEngine::Font);
ObjectExtendAs(AsIcon,UltraEngine::Icon);
ObjectExtendAs(AsLabel,UltraEngine::Label);
ObjectExtendAs(AsListBox,UltraEngine::ListBox);
ObjectExtendAs(AsMenu,UltraEngine::Menu);
ObjectExtendAs(AsMenuPanel,UltraEngine::MenuPanel);
ObjectExtendAs(AsPackage,UltraEngine::Package);
ObjectExtendAs(AsPanel,UltraEngine::Panel);
ObjectExtendAs(AsPipeStream,UltraEngine::PipeStream);
ObjectExtendAs(AsPixmap,UltraEngine::Pixmap);
ObjectExtendAs(AsPlugin,UltraEngine::Plugin);
ObjectExtendAs(AsProgressBar,UltraEngine::ProgressBar);
ObjectExtendAs(AsSlider,UltraEngine::Slider);
ObjectExtendAs(AsStreamBuffer,UltraEngine::StreamBuffer);
ObjectExtendAs(AsTabber,UltraEngine::Tabber);
ObjectExtendAs(AsTextArea,UltraEngine::TextArea);
ObjectExtendAs(AsTextField,UltraEngine::TextField);
ObjectExtendAs(AsTreeView,UltraEngine::TreeView);
ObjectExtendAs(AsTreeViewNode,UltraEngine::TreeViewNode);
ObjectExtendAs(AsObject,UltraEngine::Object);

%extend UltraEngine::Object {
bool CompareWith(UltraEngine::Object *a)
{
    if(a == self) return true;
    return &a == &self;
}}

%typemap(cscode) UltraEngine::Object %{
    public static bool operator == (Object a, Object b)
    {
        if ((object)a == null)
            return (object)b == null;

        if ((object)b == null)
            return (object)a == null;

        return  a.CompareWith(b);
    }

    public static bool operator !=(Object a, Object b) => !(a==b);
%}