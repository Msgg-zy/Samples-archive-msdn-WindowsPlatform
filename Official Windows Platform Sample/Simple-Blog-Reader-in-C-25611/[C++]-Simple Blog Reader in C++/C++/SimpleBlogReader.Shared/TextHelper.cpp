#include "pch.h"
#include "TextHelper.h"

using namespace std;
using namespace SimpleBlogReader;
using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;

using namespace Windows::Data::Html;
using namespace Windows::UI::Xaml::Documents;


/// <summary>
/// Note that in this example we don't map all the possible HTML entities. Feel free to improve this.
/// Also note that we initialize the map like this because VS2013 Udpate 3 does not support list
/// initializers in a member declaration.
/// </summary>
TextHelper::TextHelper() : entities(
    {
        { L"&#60;", L"<" }, { L"&#62;", L">" }, { L"&#38;", L"&" }, { L"&#162;", L"¢" }, 
        { L"&#163;", L"£" }, { L"&#165;", L"¥" }, { L"&#8364;", L"€" }, { L"&#8364;", L"©" },
        { L"&#174;", L"®" }, { L"&#8220;", L"“" }, { L"&#8221;", L"”" }, { L"&#8216;", L"‘" },
        { L"&#8217;", L"’" }, { L"&#187;", L"»" }, { L"&#171;", L"«" }, { L"&#8249;", L"‹" },
        { L"&#8250;", L"›" }, { L"&#8226;", L"•" }, { L"&#176;", L"°" }, { L"&#8230;", L"…" },
        { L"&#160;", L" " }, { L"&quot;", LR"(")" }, { L"&apos;", L"'" }, { L"&lt;", L"<" },
        { L"&gt;", L">" }, { L"&rsquo;", L"’" }, { L"&nbsp;", L" " }, { L"&amp;", L"&" }
    })
{
  
}
///<summary>
/// Accepts the Content property from a Feed and returns rich text
/// paragraphs that can be passed to a RichTextBlock.
///</summary>
String^ TextHelper::UnescapeText(String^ inStr)
{
    wstring input(inStr->Data());
    wstring result = UnescapeText(input);
    return ref new Platform::String(result.c_str());
}

///<summary>
/// Create a RichText block from the text retrieved by the HtmlUtilies object. 
/// For a more full-featured app, you could parse the content argument yourself and
/// add the page's images to the inlines collection.
///</summary>
IVector<Paragraph^>^ TextHelper::CreateRichText(String^ content,
    TypedEventHandler<Hyperlink^, HyperlinkClickEventArgs^>^ context)
{
    std::vector<Paragraph^> blocks; 

    auto text = HtmlUtilities::ConvertToText(content);
    auto parts = SplitContentIntoParagraphs(wstring(text->Data()), LR"(\r\n)");

    // Add the link at the top. Don't set the NavigateUri property because 
    // that causes the link to open in IE even if the Click event is handled. 
    auto hlink = ref new Hyperlink();
    hlink->Click += context;
    auto linkText = ref new Run();
    linkText->Foreground = 
        ref new Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::DarkRed);
    linkText->Text = "Link";
    hlink->Inlines->Append(linkText);
    auto linkPara = ref new Paragraph();
    linkPara->Inlines->Append(hlink);
    blocks.push_back(linkPara);

    for (auto part : parts)
    {
        auto p = ref new Paragraph();
        p->TextIndent = 10;
        p->Margin = (10, 10, 10, 10);
        auto r = ref new Run();
        r->Text = ref new String(part.c_str());
        p->Inlines->Append(r);
        blocks.push_back(p);
    }

    return ref new Vector<Paragraph^>(blocks);
}

///<summary>
/// Split an input string which has been created by HtmlUtilities::ConvertToText
/// into paragraphs. The rgx string we use here is LR("\r\n") . If we ever use
/// other means to grab the raw text from a feed, then the rgx will have to recognize
/// other possible new line formats. 
///</summary>
vector<wstring> TextHelper::SplitContentIntoParagraphs(const wstring& s, const wstring& rgx)
{    
    const wregex r(rgx);
    vector<wstring> result;

    // the -1 argument indicates that the text after this match until the next match
    // is the "capture group". In other words, this is how we match on what is between the tokens.
    for (wsregex_token_iterator rit(s.begin(), s.end(), r, -1), end; rit != end; ++rit)
    {
        if (rit->length() > 0)
        {
            result.push_back(*rit);
        }
    }
    return result;  
}

///<summary>
/// This is used to unescape html entities that occur in titles, subtitles, etc.
//  entities is a map<wstring, wstring> with key-values like this: { L"&#60;", L"<" },
/// CAUTION: we must not unescape any content that gets sent to the webView.
///</summary>
wstring TextHelper::UnescapeText(const wstring& input)
{
    wsmatch match;

    // match L"&#60;" as well as "&nbsp;"
    const wregex rgx(LR"(&#?\w*?;)");
    wstring result;

    // itrEnd needs to be visible outside the loop
    wsregex_iterator itrEnd, itrRemainingText;

    // Iterate over input and build up result as we go along
    // by first appending what comes before the match, then the 
    // unescaped replacement for the HTML entity which is the match,
    // then once at the end appending what comes after the last match.

    for (wsregex_iterator itr(input.cbegin(), input.cend(), rgx); itr != itrEnd; ++itr)    
    {
        wstring entity = itr->str();
        map<wstring, wstring>::const_iterator mit = entities.find(entity);
        if (mit != end(entities))
        {
            result.append(itr->prefix());
            result.append(mit->second); // mit->second is the replacement text
            itrRemainingText = itr;
        }
        else 
        {
            // we found an entity that we don't explitly map yet so just 
            // render it in raw form. Exercise for the user: add
            // all legal entities to the entities map.   
            result.append(entity);
            continue; 
        }        
    }

    // If we didn't find any entities to escape
    // then (a) don't try to dereference itrRemainingText
    // and (b) return input because result is empty!
    if (itrRemainingText == itrEnd)
    {
        return input;
    }
    else
    {
        // Add any text between the last match and end of input string.
        result.append(itrRemainingText->suffix());
        return result;
    }
}