/*
    Resyslib
    Copyright (c) 2024 Alastair Lundy

    This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System.Threading.Tasks;

using Resyslib.Runtime.Specifics;

namespace Resyslib.Runtime.Providers
{
    public class AndroidPlatformProvider : IAndroidPlatformProvider
    {
        public Task<Platform> GetCurrentPlatformAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AndroidPlatform> GetCurrentAndroidPlatformAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}