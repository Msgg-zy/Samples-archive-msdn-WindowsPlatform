/* 
    Copyright (c) 2012 - 2013 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://code.msdn.microsoft.com/wpapps
  
*/
using System;

namespace sdkBasicLensWP8CS.Models.Workflows
{
    abstract class WorkflowBase
    {
        public event Action Complete;
        public bool IsComplete { get; set; }
        protected abstract void DoWork();
        protected CameraController cameraController;
        protected ICameraEngineEvents callback;

        public WorkflowBase(ICameraEngineEvents callback, CameraController cameraController)
        {
            this.callback = callback;
            this.cameraController = cameraController;
        }

        public void Begin(object ususedState)
        {
            this.DoWork();
        }

        protected void OnComplete()
        {
            this.IsComplete = true;
            Complete();
        }
    }
}
