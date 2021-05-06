SWIG_STD_VECTOR_ENHANCED(float)
%template(VectorFloat) std::vector<float>;
SWIG_STD_VECTOR_ENHANCED(std::shared_ptr<UltraEngine::Display>)
%template(VectorDisplay) std::vector<std::shared_ptr<UltraEngine::Display>>;
SWIG_STD_VECTOR_ENHANCED(std::shared_ptr<UltraEngine::Pixmap>)
%template(VectorPixmap) std::vector<std::shared_ptr<UltraEngine::Pixmap>>;
SWIG_STD_VECTOR_ENHANCED(std::shared_ptr<UltraEngine::TreeViewNode>)
%template(VectorTreeViewNode) std::vector<std::shared_ptr<UltraEngine::TreeViewNode>>;
SWIG_STD_VECTOR_ENHANCED(std::shared_ptr<UltraEngine::Loader>)
%template(VectorLoader) std::vector<std::shared_ptr<UltraEngine::Loader>>;
SWIG_STD_VECTOR_ENHANCED(std::shared_ptr<UltraEngine::Widget>)
%template(VectorWidget) std::vector<std::shared_ptr<UltraEngine::Widget>>;
SWIG_STD_VECTOR_ENHANCED(std::shared_ptr<UltraEngine::Window>)
%template(VectorWindow) std::vector<std::shared_ptr<UltraEngine::Window>>;

SWIG_STD_VECTOR_ENHANCED(std::string)
%template(VectorStdString) std::vector<std::string>;
SWIG_STD_VECTOR_ENHANCED(std::wstring)
%template(VectorStdWString) std::vector<std::wstring>;

SWIG_STD_VECTOR_ENHANCED(UltraEngine::iVec2)
%template(VectorIVec2) std::vector<UltraEngine::iVec2>;
SWIG_STD_VECTOR_ENHANCED(UltraEngine::String)
%template(VectorString) std::vector<UltraEngine::String>;
SWIG_STD_VECTOR_ENHANCED(UltraEngine::WString)
%template(VectorWString) std::vector<UltraEngine::WString>;

%template(VectorWidgetBlock) std::vector<UltraEngine::WidgetBlock>;
%template(VectorWidgetItem) std::vector<UltraEngine::WidgetItem>;
