//////////////////////////////////////////////////////////////////////////
//
// dllmain.cpp
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
//////////////////////////////////////////////////////////////////////////

#include <initguid.h>
#include "Invert.h"

using namespace Microsoft::WRL;

namespace Microsoft { namespace Samples {
    ActivatableClass(CInvert);
}}

BOOL WINAPI DllMain( __in_opt HINSTANCE hInstance, __in DWORD dwReason, __in_opt LPVOID lpReserved )
{
    if( DLL_PROCESS_ATTACH == dwReason )
    {
        //
        //  Don't need per-thread callbacks
        //
        if( hInstance != NULL )
        {
            DisableThreadLibraryCalls( hInstance );
        }

        Module<InProc>::GetModule().Create();
    }
    else if( DLL_PROCESS_DETACH == dwReason )
    {
        Module<InProc>::GetModule().Terminate();
    }

    return TRUE;
}

HRESULT WINAPI DllGetActivationFactory( __in HSTRING activatibleClassId, __deref_out IActivationFactory** factory )
{
    auto &module = Microsoft::WRL::Module< Microsoft::WRL::InProc >::GetModule();
    return module.GetActivationFactory( activatibleClassId, factory );
}

HRESULT WINAPI DllCanUnloadNow()
{
    auto &module = Microsoft::WRL::Module<Microsoft::WRL::InProc>::GetModule();    
    return (module.Terminate()) ? S_OK : S_FALSE;
}

STDAPI DllGetClassObject( __in REFCLSID rclsid, __in REFIID riid, __deref_out LPVOID FAR* ppv )
{
    auto &module = Microsoft::WRL::Module<Microsoft::WRL::InProc>::GetModule();
    return module.GetClassObject( rclsid, riid, ppv );
}
