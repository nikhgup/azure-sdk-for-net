// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> The UnknownVariable. </summary>
    internal partial class UnknownVariable : TimeSeriesVariable
    {
        /// <summary> Initializes a new instance of UnknownVariable. </summary>
        /// <param name="kind"> Allowed &quot;kind&quot; values are - &quot;numeric&quot; or &quot;aggregate&quot;. While &quot;numeric&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the &quot;aggregate&quot; kind lets you directly aggregate on the event properties without specifying value. </param>
        /// <param name="filter"> Filter over the events that restricts the number of events being considered for computation. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </param>
        internal UnknownVariable(string kind, TimeSeriesExpression filter) : base(kind, filter)
        {
            Kind = kind ?? "Unknown";
        }
    }
}
