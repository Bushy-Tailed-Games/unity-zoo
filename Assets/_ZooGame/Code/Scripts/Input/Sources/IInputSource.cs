// Copyright 2019 Niantic, Inc. All Rights Reserved.

using System;
using System.Collections.Generic;

internal interface IInputSource {
    List<InputEvent> Events { get; }

    void CollectInput ();
}