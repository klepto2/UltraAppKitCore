%template(ListEventListener) std::list<UltraEngine::EventListener>;
%template(ListEvent) std::list<UltraEngine::Event>;
%template(ListPackage) std::list<weak_ptr<UltraEngine::Package>>;
%template(ListPlugin) std::list<weak_ptr<UltraEngine::Plugin>>;
//%template(ListStdWidget) std::list<std::weak_ptr<UltraEngine::Widget>>;
%template(ListWidget) std::list<weak_ptr<UltraEngine::Widget>>;
//std::map<EventID, std::map<std::weak_ptr<Object>, std::list<EventListener>, std::owner_less<std::weak_ptr<Object> > > > eventlisteners;
//%template(MapEventListenerInternal)  std::map<std::weak_ptr<UltraEngine::Object>, std::list<UltraEngine::EventListener>>;
//%template(MapEventListener) std::map<UltraEngine::EventID, std::map<std::weak_ptr<UltraEngine::Object>, std::list<UltraEngine::EventListener>, std::owner_less<std::weak_ptr<UltraEngine::Object>>>>;
%template(MapTimer) std::map<int, weak_ptr<UltraEngine::Timer>>;
%template(MapAsset) std::map<std::wstring, weak_ptr<UltraEngine::Asset>>;
%template(MapWindow) std::map<HWND, weak_ptr<UltraEngine::Window>>;
%template(MapProperties) std::map<std::wstring, std::wstring>;


//std::map<std::wstring, weak_ptr<Pixmap> >
//std::map<float, std::map<std::wstring, weak_ptr<Pixmap> > > cachedpixmaps;
%template(MapPixmap) std::map<std::wstring, weak_ptr<UltraEngine::Pixmap>>;
%template(MapCachedPixmaps) std::map<float, std::map<std::wstring, weak_ptr<UltraEngine::Pixmap>>>;

