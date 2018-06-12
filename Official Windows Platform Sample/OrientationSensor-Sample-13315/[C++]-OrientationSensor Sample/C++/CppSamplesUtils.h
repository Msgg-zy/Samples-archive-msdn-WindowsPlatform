#pragma once

#include <string>
#include <sstream>
#include <algorithm>
#include <collection.h>

namespace CppSamplesUtils
{

namespace Details
{
	static Windows::Foundation::Collections::PropertySet^ sessionState = nullptr;
	static Platform::String^ sessionStateFileName = ref new Platform::String(L"_cppSessionState.xml");

	void SerializeSessionState(Windows::Storage::IStorageFile^ file, Windows::Foundation::AsyncActionCompletedHandler^ handler);
	void DeserializeSessionState(Windows::Storage::IStorageFile^ file, Windows::Foundation::AsyncActionCompletedHandler^ handler);
}

class SuspensionManager
{
public:
	static Windows::Foundation::Collections::PropertySet^ SessionState()
	{
		using namespace Windows::Foundation::Collections;
		using namespace Details;

		if (sessionState == nullptr)
		{
			sessionState = ref new PropertySet();
		}
		return sessionState;
	}

	static void StartRestoreAsync(Windows::Foundation::AsyncActionCompletedHandler^ handler)
	{
		using namespace Windows::Foundation;
		using namespace Windows::Storage;
		using namespace Windows::Storage::Streams;
		using namespace Details;

		auto state = SessionState();
		state->Clear();

		auto op = ApplicationData::Current->LocalFolder->CreateFileAsync(sessionStateFileName, CreationCollisionOption::OpenIfExists);
		op->Completed = ref new AsyncOperationCompletedHandler<StorageFile^>(
			[=](IAsyncOperation<StorageFile^>^ op)
			{
				auto file = op->GetResults();
				DeserializeSessionState(file, handler);
			});
		op->Start();
	}

	static void StartSaveAsync(Windows::Foundation::AsyncActionCompletedHandler^ handler)
	{
		using namespace Windows::Foundation;
		using namespace Windows::Storage;
		using namespace Windows::Storage::Streams;
		using namespace Details;

		auto op = ApplicationData::Current->LocalFolder->CreateFileAsync(sessionStateFileName, CreationCollisionOption::ReplaceExisting);
		op->Completed = ref new AsyncOperationCompletedHandler<StorageFile^>(
			[=](IAsyncOperation<StorageFile^>^ op)
			{
				auto file = op->GetResults();
				SerializeSessionState(file, handler);
			});
		op->Start();
	}
};

namespace Details
{
	template <class T>
	inline Platform::String^ ToString(T value)
	{
		std::wstringstream wss;
		wss << value;
		return ref new Platform::String(wss.str().c_str());
	}

	template <class T>
	inline T FromStringTo(Platform::String^ str)
	{
		std::wistringstream wiss(str->Data());
		T value = 0;
		wiss >> value;
		return value;
	}

	template <class T>
	inline T FromHexStringTo(Platform::String^ str)
	{
		std::wistringstream wiss(str->Data());
		T value = 0;
		wiss >> std::hex >> value;
		return value;
	}

	template <>
	inline Platform::Guid FromStringTo<Platform::Guid>(Platform::String^ str)
	{
		using namespace Platform;

		if (str->Length() != 38)
		{
			throw ref new InvalidArgumentException;
		}
		std::wstring ws(str->Data());
		if (ws[0] != L'{' || ws[37] != L'}' || ws[9] != L'-' || ws[14] != L'-' || ws[19] != L'-' || ws[24] != L'-')
		{
			throw ref new InvalidArgumentException;
		}
		ws[0] = ws[37] = ws[9] = ws[14] = ws[19] =ws[24] = L' ';
		std::wistringstream wiss(ws);
		unsigned int a = 0;
		unsigned short b = 0;
		unsigned short c = 0;
		unsigned short d = 0;
		unsigned long long e = 0;
		static_assert(sizeof(d) == sizeof(char) * 2, "sizeof(d) == sizeof(char) * 2");
		static_assert(sizeof(e) == sizeof(char) * 8, "sizeof(e) == sizeof(char) * 8");
		wiss >> std::hex >> a >> b >> c >> d >> e;
		unsigned char *ad = (unsigned char*)(&d);
		unsigned char *ae = (unsigned char*)(&e);
		return Platform::Guid(a, b, c, ad[1], ad[0], ae[5], ae[4], ae[3], ae[2], ae[1], ae[0]);
	}

	inline Platform::Object^ ConvertStringToObject(Windows::Foundation::PropertyType type, Platform::String^ str)
	{
		using namespace Platform;
		using namespace Windows::Foundation;

		if (type == PropertyType::String)
		{
			return PropertyValue::CreateString(str);
		}

		switch(type)
		{
		case PropertyType::UInt8:
			return PropertyValue::CreateUInt8(FromStringTo<unsigned short>(str));
		case PropertyType::UInt16:
			return PropertyValue::CreateUInt16(FromStringTo<unsigned short>(str));
		case PropertyType::UInt32:
			return PropertyValue::CreateUInt32(FromStringTo<unsigned int>(str));
		case PropertyType::UInt64:
			return PropertyValue::CreateUInt64(FromStringTo<unsigned long long>(str));
		case PropertyType::Int16:
			return PropertyValue::CreateInt16(FromStringTo<short>(str));
		case PropertyType::Int32:
			return PropertyValue::CreateInt32(FromStringTo<int>(str));
		case PropertyType::Int64:
			return PropertyValue::CreateInt64(FromStringTo<long long>(str));
		case PropertyType::Single:
			return PropertyValue::CreateSingle(FromStringTo<float>(str));
		case PropertyType::Double:
			return PropertyValue::CreateDouble(FromStringTo<double>(str));
		case PropertyType::Boolean:
			return PropertyValue::CreateBoolean(FromStringTo<bool>(str));
		case PropertyType::Char16:
			return PropertyValue::CreateChar16(str->Data()[0]);
		case PropertyType::Guid:
			return PropertyValue::CreateGuid(FromStringTo<Guid>(str));
		// TODO: implement DateTime
		// TODO: implement TimeSpan
		// TODO: implement Point
		// TODO: implement Rect
		// TODO: implement Size
		default:
			throw ref new Platform::InvalidCastException;
		}
	}

	inline Platform::String^ ConvertPropertyValueToString(Windows::Foundation::IPropertyValue^ pv)
	{
		using namespace Platform;
		using namespace Windows::Foundation;

		String^ valueString;

		switch(pv->Type)
		{
		case PropertyType::String:
			valueString = pv->GetString();
			break;

		case PropertyType::UInt8:
		case PropertyType::UInt16:
		case PropertyType::UInt32:
		case PropertyType::UInt64:
			valueString = ToString(pv->GetUInt64());
			break;

		case PropertyType::Int16:
		case PropertyType::Int32:
		case PropertyType::Int64:
			valueString = ToString(pv->GetInt64());
			break;

		case PropertyType::Single:
			valueString = ToString(pv->GetSingle());
			break;

		case PropertyType::Double:
			valueString = ToString(pv->GetDouble());
			break;

		case PropertyType::Boolean:
			valueString = ToString(pv->GetBoolean());
			break;

		case PropertyType::Char16:
			wchar_t buffer[2];
			buffer[0] = pv->GetChar16();
			buffer[1] = 0;
			valueString = ref new String(buffer);
			break;

		case PropertyType::Guid:
			valueString = pv->GetGuid().ToString();
			break;

		// TODO: implement DateTime
		// TODO: implement TimeSpan
		// TODO: implement Point
		// TODO: implement Rect
		// TODO: implement Size

		default:
			throw ref new InvalidCastException;
		}

		return valueString;
	}

	inline Windows::Data::Xml::Dom::XmlElement^ CreateXmlElementFromObject(Windows::Data::Xml::Dom::XmlDocument^ doc, Platform::String^ name, Platform::Object^ value)
	{
		using namespace Platform;
		using namespace Windows::Foundation;
		using namespace Windows::Data::Xml::Dom;

		XmlElement^ element = doc->CreateElement("item");
		element->SetAttribute("name", name);

		IPropertyValue^ pv = (IPropertyValue^)value;
		element->SetAttribute("type", ToString((int)pv->Type));
		element->SetAttribute("value", ConvertPropertyValueToString(pv));

		return element;
	}

	inline void SerializeSessionState(Windows::Storage::IStorageFile^ file, Windows::Foundation::AsyncActionCompletedHandler^ handler)
	{
		using namespace Windows::Data::Xml::Dom;
		using namespace Windows::Foundation;
		namespace WFC = Windows::Foundation::Collections;
		typedef Windows::Foundation::Collections::IKeyValuePair<Platform::String^, Platform::Object^> KVPair;

		XmlDocument^ doc = ref new XmlDocument;
		doc->AppendChild(doc->CreateElement("items"));
		auto sessionState = SuspensionManager::SessionState();

		std::for_each(WFC::begin(sessionState), WFC::end(sessionState), [doc](KVPair^ item) {
			doc->DocumentElement->AppendChild(CreateXmlElementFromObject(doc, item->Key, item->Value));
		});

		auto op = doc->SaveToFileAsync(file);
		op->Completed = ref new AsyncActionCompletedHandler(
			[=](IAsyncAction^ action)
			{
				handler(action);
			});
		op->Start();
	}

	inline Windows::Foundation::PropertyType PropertyTypeFromString(Platform::String^ str)
	{
		int value = FromStringTo<int>(str);
		return (Windows::Foundation::PropertyType)value;
	}

	inline void DeserializeSessionState(Windows::Storage::IStorageFile^ file, Windows::Foundation::AsyncActionCompletedHandler^ handler)
	{
		using namespace Platform;
		using namespace Windows::Foundation;
		using namespace Windows::Data::Xml::Dom;
		namespace WFC = Windows::Foundation::Collections;

		auto op = XmlDocument::LoadFromFileAsync(file);
		op->Completed = ref new AsyncOperationCompletedHandler<XmlDocument^>(
			[=](IAsyncOperation<XmlDocument^>^ operation)
			{
				auto doc = operation->GetResults();
				auto items = doc->SelectNodes("/items/item");
				auto sessionState = SuspensionManager::SessionState();
			
				std::for_each(WFC::begin(items), WFC::end(items), [sessionState](IXmlNode^ node){
					auto element = (IXmlElement^)node;
					String^ name = element->GetAttribute("name");
					String^ value = element->GetAttribute("value");
					PropertyType type = PropertyTypeFromString(element->GetAttribute("type"));

					Object^ valueObject = ConvertStringToObject(type, value);
					sessionState->Insert(name, valueObject);
				});

				handler(nullptr);
			});
		op->Start();
	}

}

} // namespace CppSamplesUtils
