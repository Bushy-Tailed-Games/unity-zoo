// Copyright 2019 Niantic, Inc. All Rights Reserved.

using System;
using System.Collections.Generic;

/// <inheritdoc />
internal class ScreenSpaceInputLayer : IInputLayer {
    private readonly List<IScreenInputGesture> _gestures = new ();

    /// <inheritdoc />
    public void ProcessEvents (List<InputEvent> events) {
        foreach (var gesture in _gestures) {
            foreach (var inputEvent in events) {
                if (inputEvent.ConsumedBy == null) {
                    gesture.ProcessEvent (inputEvent);
                }
            }

            gesture.PostProcessInput ();
        }
    }

    public void Register (IScreenInputGesture gesture) {
        _gestures.Add (gesture);
    }
}