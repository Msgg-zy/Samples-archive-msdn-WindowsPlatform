#include "pch.h"
#include "services\mobile services\TodoCppClient\PushRegister.h"

using namespace AzureMobileHelper;

using namespace web;
using namespace concurrency;

using namespace Windows::Networking::PushNotifications;

void PushRegister::AcquireAndUpdatePushChannel()
{
    typedef concurrency::task_continuation_context ctx;

    create_task(PushNotificationChannelManager::CreatePushNotificationChannelForApplicationAsync()).
    then([] (PushNotificationChannel^ newChannel) 
    {
        auto channel_obj = json::value::object();

        channel_obj[L"channelUri"] = json::value::string(newChannel->Uri->Data());

        auto token = Windows::System::Profile::HardwareIdentification::GetPackageSpecificToken(nullptr);
        auto installationId = Windows::Security::Cryptography::CryptographicBuffer::EncodeToBase64String(token->Id);

        channel_obj[L"installationId"] = json::value::string(installationId->Data());

        azure::mobile::table channels_table(TodoCppClientMobileService::GetClient(), L"channels");
        channels_table.insert(channel_obj).then([](task<json::value> result) 
        { 
            // http://go.microsoft.com/fwlink/?LinkID=290991&clcid=0x409		
            try
            {
                result.wait();
            }
            catch(...)
            {
                HandleExceptionsComingFromTheServer();
            }
        }, ctx::use_current());
    }, ctx::use_current());
}

void PushRegister::HandleExceptionsComingFromTheServer()
{
}
