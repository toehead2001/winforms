﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>
///  This type is provided for binary compatibility with .NET Framework and is not intended to be used directly from your code.
/// </summary>
[Obsolete(
    Obsoletions.ToolBarMessage,
    error: false,
    DiagnosticId = Obsoletions.UnsupportedControlsDiagnosticId,
    UrlFormat = Obsoletions.SharedUrlFormat)]
[EditorBrowsable(EditorBrowsableState.Never)]
[Browsable(false)]
public enum ToolBarButtonStyle
{
    PushButton = 1,
    ToggleButton = 2,
    Separator = 3,
    DropDownButton = 4,
}
