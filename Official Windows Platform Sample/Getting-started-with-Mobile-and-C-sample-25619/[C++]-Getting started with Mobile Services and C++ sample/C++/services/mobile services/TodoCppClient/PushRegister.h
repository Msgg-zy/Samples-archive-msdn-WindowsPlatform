#pragma once

#include <azuremobile.h>
#include "services\mobile services\TodoCppClient\TodoCppClientMobileService.h"

namespace AzureMobileHelper
{
    class PushRegister
    {
    public:
        static void AcquireAndUpdatePushChannel();
    private:
        static void HandleExceptionsComingFromTheServer();
    };
}
