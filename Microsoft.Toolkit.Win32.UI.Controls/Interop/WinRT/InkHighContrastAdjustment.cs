// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using windows = Windows;

namespace Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT
{
    /// <summary>
    /// <see cref="windows.UI.Input.Inking.InkHighContrastAdjustment"/>
    /// </summary>
    public enum InkHighContrastAdjustment
    {
        UseSystemColorsWhenNecessary = 0,
        UseSystemColors = 1,
        UseOriginalColors = 2,
    }
}