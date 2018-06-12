/* 
    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using System;
using System.Net;
using System.Windows;

namespace sdkMulticastCS
{
    /// <summary>
    /// The information about each player. 
    /// </summary>
    public class PlayerInfo
    {
        public PlayerInfo(string playerName, IPEndPoint endPoint)
        {
            PlayerEndPoint = endPoint;
            PlayerName = playerName;
        }

        public PlayerInfo(string playerName)
        {
            PlayerEndPoint = null;
            PlayerName = playerName;
        }


        public IPEndPoint PlayerEndPoint { get; set; }
        public string PlayerName { get; set; }
    }
}
