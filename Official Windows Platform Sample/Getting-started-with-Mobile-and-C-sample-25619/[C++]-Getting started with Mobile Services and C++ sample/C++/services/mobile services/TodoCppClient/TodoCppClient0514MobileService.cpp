#include "pch.h"
#include "services\mobile services\TodoCppClient0514\TodoCppClient0514MobileService.h"

using namespace AzureMobileHelper;

/// <summary>
/// Returns the client instance representing the associated mobile service account.
/// </summary>
/// <returns>A non-const reference to the client instance.</returns>
azure::mobile::client& TodoCppClient0514MobileService::GetClient()
{
    static azure::mobile::client c(L"https://todocppclient0514.azure-mobile.net/", 
                                   L"XlqXqzekKsAwIeZdvnwlNOvzEUNzES15");
    return c;
}
