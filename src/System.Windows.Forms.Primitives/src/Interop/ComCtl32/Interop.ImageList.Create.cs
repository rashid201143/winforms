﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class ComCtl32
    {
        public static partial class ImageList
        {
            [DllImport(Libraries.Comctl32, ExactSpelling = true, EntryPoint = "ImageList_Create")]
            public static extern IntPtr Create(int cx, int cy, ILC flags, int cInitial, int cGrow);
        }
    }
}
