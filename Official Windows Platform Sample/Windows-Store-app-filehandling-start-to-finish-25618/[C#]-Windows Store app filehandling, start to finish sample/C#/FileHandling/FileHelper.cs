//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace FileHandling
{
    class FileHelper
    {
        /// <summary>
        /// Generic function that retrieves all files from the specified library (StorageFolder)
        /// </summary>
        /// <param name="folder">The folder to be searched.</param>
        /// <returns>An IReadOnlyList collection containing the file objects.</returns>
        public static async Task<System.Collections.Generic.IReadOnlyList<StorageFile>> GetLibraryFilesAsync(StorageFolder folder)
        {
            var query = folder.CreateFileQuery();
            return await query.GetFilesAsync();
        }
    }
}
