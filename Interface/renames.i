%rename(TranslateW) UltraEngine::Language::Translate(std::wstring const &);
%rename(GetTextWidthW) UltraEngine::Font::GetTextWidth(std::wstring const &,int const);
%rename(JSONWrapper) nlohmann::json;

//Ignoring all Function-Pointer for UltraEngine::Plugin until i have found a usable way to implement them
%rename("$ignore", regextarget=1, fullname=1) "UltraEngine::Plugin::FP_*";