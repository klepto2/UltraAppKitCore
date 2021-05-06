namespace std {
template<class Ty> class weak_ptr {
public:
    typedef Ty element_type;

    weak_ptr();
    weak_ptr(const weak_ptr&);
    template<class Other>
        weak_ptr(const weak_ptr<Other>&);
    template<class Other>
        weak_ptr(const shared_ptr<Other>&);

    weak_ptr(const shared_ptr<Ty>&);


    void swap(weak_ptr&);
    void reset();

    long use_count() const;
    bool expired() const;
    shared_ptr<Ty> lock() const;
};
}


%template(AssetWeakPtr) weak_ptr<UltraEngine::Asset>;
%template(PackageWeakPtr) weak_ptr<UltraEngine::Package>;
%template(PixmapWeakPtr) weak_ptr<UltraEngine::Pixmap>;
%template(TimerWeakPtr) weak_ptr<UltraEngine::Timer>;
%template(ObjectWeakPtr) weak_ptr<UltraEngine::Object>;
%template(PluginWeakPtr) weak_ptr<UltraEngine::Plugin>;
%template(WidgetWeakPtr) weak_ptr<UltraEngine::Widget>;
%template(WindowWeakPtr) weak_ptr<UltraEngine::Window>;
//%template(WidgetStdWeakPtr) std::weak_ptr<UltraEngine::Widget>;


%template(WidgetColorArray) std::array<UltraEngine::Vec4,UltraEngine::WIDGETCOLOR_POPUP + 1>;
%template(IntFourArray) std::array<int,4>;
