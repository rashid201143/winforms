﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class GdiPlus
    {
        [DllImport(Libraries.Gdiplus, ExactSpelling = true)]
        internal unsafe static extern GpStatus GdipCreateSolidFill(int color, IntPtr* brush);
    }
}
