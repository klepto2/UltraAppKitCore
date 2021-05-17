%ignore debug; 

//Ignoreing the following as they are defined in the Header but not exposed in the lib
%ignore UltraEngine::GameEngine::eventlisteners;
%ignore UltraEngine::GamePadConnected;
%ignore UltraEngine::GamePadButtonDown;
%ignore UltraEngine::GamePadButtonHit;
%ignore UltraEngine::GamePadAxisPosition;
%ignore UltraEngine::GamePadRumble;
%ignore UltraEngine::FixPath(const std::string& path);
%ignore UltraEngine::CasedFileName(const std::string& path, const std::string& file, const bool isroot);
%ignore UltraEngine::CreateButton(const WString& text, const int x, const int y, const int width, const int height, shared_ptr<Interface> ui, const ButtonStyle style = BUTTON_DEFAULT);
%ignore UltraEngine::CreateTextField(const int x, const int y, const int width, const int height, shared_ptr<Interface> ui, const TextFieldStyle style = TEXTFIELD_DEFAULT);
%ignore UltraEngine::CreateTextArea(const int x, const int y, const int width, const int height, shared_ptr<Interface> ui, const TextAreaStyle style = TEXTAREA_DEFAULT);

//Ignored currently due to no support by SWIG (need to find a way to use them)
%ignore UltraEngine::Widget::it; //iterator not supported
%ignore UltraEngine::Widget::edgedistance; //iterator not supported
%ignore UltraEngine::Widget::edgemode; //iterator not supported
%ignore UltraEngine::ListenEvent; //function ptr are difficult and will be added later
%ignore UltraEngine::EventListener; //function ptr are difficult and will be added later
%ignore UltraEngine::CreateThread; //function ptr are difficult and will be added later
%ignore UltraEngine::DDS_HEADER; //wrong Array conversion will be fixed later
%ignore UltraEngine::Interface::refreshedwidgets; //std::set not ready to use with SWIG (maybe in later Version)
%ignore UltraEngine::LabelStyle; // ignored because redefined in the interface
%ignore UltraEngine::Interface::spritelayer; // Canvas not exposed by Lib

%ignore UltraEngine::Vec2::operator[](unsigned idx); // Index not supported
%ignore UltraEngine::Vec3::operator[](unsigned idx); // Index not supported
%ignore UltraEngine::Vec4::operator[](unsigned idx); // Index not supported
%ignore UltraEngine::iVec2::operator[](unsigned idx); // Index not supported
%ignore UltraEngine::iVec3::operator[](unsigned idx); // Index not supported
%ignore UltraEngine::iVec4::operator[](unsigned idx); // Index not supported
%ignore UltraEngine::Interface::spritelayer; // Canvas not exposed by Lib
%ignore FunctionHandler; // internal
//Ignoring all Function-Pointer for UltraEngine::Plugin until i have found a usable way to implement them
%rename("$ignore", regextarget=1, fullname=1) "UltraEngine::Plugin::FP_*";
