//DateConverter.h

#pragma once
#include <string> //for wcscmp
#include <regex>

namespace SimpleBlogReader
{
    // Economize on keystrokes.
    namespace WGDTF = Windows::Globalization::DateTimeFormatting;
    
    /// <summary>
    /// Implements IValueConverter so that we can convert the numeric date
    /// representation to a set of strings.
    /// </summary>
    public ref class DateConverter sealed : 
        public Windows::UI::Xaml::Data::IValueConverter
    {
    public:
        virtual Platform::Object^ Convert(Platform::Object^ value,
            Windows::UI::Xaml::Interop::TypeName targetType,
            Platform::Object^ parameter,
            Platform::String^ language)
        {
            if (value == nullptr)
            {
                throw ref new Platform::InvalidArgumentException();
            }
            auto dt = safe_cast<Windows::Foundation::DateTime>(value);
            auto param = safe_cast<Platform::String^>(parameter);
            Platform::String^ result;
            if (param == nullptr)
            {
                auto dtf = WGDTF::DateTimeFormatter::ShortDate::get();
                result = dtf->Format(dt);
            }
            else if (wcscmp(param->Data(), L"month") == 0)
            {
                auto formatter =
                    ref new WGDTF::DateTimeFormatter("{month.abbreviated(3)}");
                result = formatter->Format(dt);
            }
            else if (wcscmp(param->Data(), L"day") == 0)
            {
                auto formatter =
                    ref new WGDTF::DateTimeFormatter("{day.integer(2)}");
                result = formatter->Format(dt);
            }
            else if (wcscmp(param->Data(), L"year") == 0)
            {
                auto formatter =
                    ref new WGDTF::DateTimeFormatter("{year.full}");
                auto tempResult = formatter->Format(dt); //e.g. "2014"

                // Insert a hard return after second digit to get the rendering 
                // effect we want.
                std::wregex r(L"(\\d\\d)(\\d\\d)");
                result = ref new Platform::String(
                    std::regex_replace(tempResult->Data(), r, L"$1\n$2").c_str());
            }
            else
            {
                // We don't handle other format types currently.
                throw ref new Platform::InvalidArgumentException();
            }

            return result;
        }

        /// <summary>
        /// Not needed in SimpleBlogReader. Left as an exercise.
        /// </summary>
        virtual Platform::Object^ ConvertBack(Platform::Object^ value,
            Windows::UI::Xaml::Interop::TypeName targetType,
            Platform::Object^ parameter,
            Platform::String^ language)
        {
           
            throw ref new Platform::NotImplementedException();
        }
    };
}