//////////////////////////////////////////////////////
// Copyright (C) Microsoft. 2018. All rights reserved.
//////////////////////////////////////////////////////

using UnrealBuildTool;
using System.Collections.Generic;

public class ExampleProjectEditorTarget : TargetRules
{
    public ExampleProjectEditorTarget(TargetInfo Target) : base(Target)
    {
        bUseUnityBuild = false;
        Type = TargetType.Editor;
        ExtraModuleNames.AddRange(new string[] { "ExampleProject" });
    }
}
