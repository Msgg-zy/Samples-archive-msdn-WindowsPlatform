#pragma once

#include <azuremobile.h>

namespace AzureMobileHelper
{
    /// <summary>
    /// TodoCppClient0514MobileService contains support for contacting an associated mobile service.
    /// </summary>
    class TodoCppClient0514MobileService
    {
    public:
        static azure::mobile::client& GetClient();
    };
}
