﻿/*
    IOExtensions 
    Copyright (c) 2024 Alastair Lundy

    This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.Collections.Generic;

namespace Resyslib.IO.Directories;

public interface IDirectoryRemover
{ 
    event EventHandler<string> DirectoryDeleted; 
    
    bool TryDeleteDirectory(string directory, bool deleteEmptyDirectory, bool deleteParentDirectory);
    
    void DeleteDirectory(string directory, bool deleteEmptyDirectory, bool deleteParentDirectory);

    void DeleteParentDirectory(string directory, bool deleteEmptyDirectory);

    void DeleteDirectories(IEnumerable<string> directories, bool deleteEmptyDirectory,
        bool deleteParentDirectory);
}