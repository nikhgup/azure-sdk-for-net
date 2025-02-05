// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Routing.Models
{
    /// <summary> Groups a sequence of instruction elements which are related to each other. The sequence range is constrained with firstInstructionIndex and lastInstructionIndex. When human-readable text messages are requested for guidance (instructionType=text or tagged), then the instructionGroup has a summary message returned when available. </summary>
    public partial class RouteInstructionGroup
    {
        /// <summary> Initializes a new instance of RouteInstructionGroup. </summary>
        internal RouteInstructionGroup()
        {
        }

        /// <summary> Initializes a new instance of RouteInstructionGroup. </summary>
        /// <param name="firstInstructionIndex"> Index of the first instruction in the instructions and belonging to this group. </param>
        /// <param name="lastInstructionIndex"> Index of the last instruction in the instructions and belonging to this group. </param>
        /// <param name="groupLengthInMeters"> Length of the group. </param>
        /// <param name="groupMessage"> Summary message when human-readable text messages are requested for guidance (instructionType=text or tagged). </param>
        internal RouteInstructionGroup(int? firstInstructionIndex, int? lastInstructionIndex, int? groupLengthInMeters, string groupMessage)
        {
            FirstInstructionIndex = firstInstructionIndex;
            LastInstructionIndex = lastInstructionIndex;
            GroupLengthInMeters = groupLengthInMeters;
            GroupMessage = groupMessage;
        }

        /// <summary> Index of the first instruction in the instructions and belonging to this group. </summary>
        public int? FirstInstructionIndex { get; }
        /// <summary> Index of the last instruction in the instructions and belonging to this group. </summary>
        public int? LastInstructionIndex { get; }
        /// <summary> Length of the group. </summary>
        public int? GroupLengthInMeters { get; }
        /// <summary> Summary message when human-readable text messages are requested for guidance (instructionType=text or tagged). </summary>
        public string GroupMessage { get; }
    }
}
