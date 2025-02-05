﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The ContinuousDtmfRecognitionStopped event.
    /// </summary>

    [CodeGenModel("ContinuousDtmfRecognitionStopped", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class ContinuousDtmfRecognitionStoppedEventData : CallAutomationEventData
    {
        /// <summary>
        /// Deserialize <see cref="ContinuousDtmfRecognitionStoppedEventData"/> event.
        /// </summary>
        /// <param name="content">The json content.</param>
        /// <returns>The new <see cref="ContinuousDtmfRecognitionStoppedEventData"/> object.</returns>
        public static ContinuousDtmfRecognitionStoppedEventData Deserialize(string content)
        {
            using var document = JsonDocument.Parse(content);
            JsonElement element = document.RootElement;

            return DeserializeContinuousDtmfRecognitionStoppedEventData(element);
        }
    }
}
