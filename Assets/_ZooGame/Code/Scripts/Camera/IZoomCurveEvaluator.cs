// Copyright 2019 Niantic, Inc. All Rights Reserved.

using System;

internal interface IZoomCurveEvaluator {
    float GetAngleFromDistance (float distanceMeters);
    float GetElevationFromDistance (float distance);
    float GetDistanceFromZoomFraction (float zoomFraction);
}