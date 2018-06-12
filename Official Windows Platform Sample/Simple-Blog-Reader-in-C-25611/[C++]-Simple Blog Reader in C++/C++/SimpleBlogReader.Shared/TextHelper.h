#pragma once

namespace SimpleBlogReader
{
    // Windows namespaces get long. Use aliases to improve readability
    // and keep line lengths in check.
    namespace WFC = Windows::Foundation::Collections;
    namespace WF = Windows::Foundation;
    namespace WUIXD = Windows::UI::Xaml::Documents;

    public ref class TextHelper sealed
    {
    public:
        TextHelper();
        WFC::IVector<WUIXD::Paragraph^>^ CreateRichText(
            Platform::String^ fi,
            WF::TypedEventHandler < WUIXD::Hyperlink^,
            WUIXD::HyperlinkClickEventArgs^ > ^ context);

        Platform::String^ UnescapeText(Platform::String^ inStr);

    private:
        // std types are fine with private or internal accessibility
        std::vector<std::wstring> SplitContentIntoParagraphs(const std::wstring& s, 
            const std::wstring& rgx);
        std::wstring UnescapeText(const std::wstring& input);

        // Maps some HTML entities that we'll use to replace the escape sequences
        // in the call to UnescapeText when we create feed titles and render text. 
        std::map<std::wstring, std::wstring> entities;
        
    };
}