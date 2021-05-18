namespace nlohmann
{  
    class json
    {
        public:
           std::string dump();
    };
}

namespace UltraEngine
{  
    enum LabelStyle
    {
            LABEL_LEFT = 0,
            LABEL_DEFAULT = LABEL_LEFT,
            LABEL_RIGHT = 2,
            LABEL_CENTER = 1,
            LABEL_TOP = 0,
            LABEL_BOTTOM = 64,
            LABEL_MIDDLE = 4,
            LABEL_BORDER = 128
    };
}