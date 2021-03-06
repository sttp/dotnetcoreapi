﻿//******************************************************************************************************
//  SubscriberHandler.cs - Gbtc
//
//  Copyright © 2019, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/23/2019 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using sttp;
using System;
using System.Text;

namespace Subscriber
{
    public class SubscriberHandler : SubscriberInstance
    {
        private readonly string m_name;
        private ulong m_processCount;

        private static readonly object s_consoleLock = new object();

        public SubscriberHandler(string name) => m_name = name;

        // TODO: Modify subscription info properties as desired...
        //protected override SubscriptionInfo CreateSubscriptionInfo()
        //{
        //    SubscriptionInfo info = base.CreateSubscriptionInfo();
        //
        //    // Other example properties (see SubscriptionInfo class in DataSubscriber.h for all properties)
        //    //info.Throttled = false;
        //    //info.IncludeTime = true;
        //    //info.UseMillisecondResolution = true;
        //
        //    return info;
        //}

        // TODO: Modify connector properties as desired...
        //protected override void SetupSubscriberConnector(SubscriberConnector connector)
        //{
        //    base.SetupSubscriberConnector(connector);
        //
        //    //connector.SetMaxRetries(-1);
        //}

        protected override void StatusMessage(string message)
        {
            // TODO: Make sure these messages get logged to an appropriate location

            // Calls can come from multiple threads, so we impose a simple lock before write to console
            lock (s_consoleLock)
                Console.WriteLine($"[{m_name}] {message}\n");
        }

        protected override void ErrorMessage(string message)
        {
            // TODO: Make sure these messages get logged to an appropriate location

            // Calls can come from multiple threads, so we impose a simple lock before write to console
            lock (s_consoleLock)
                Console.Error.WriteLine($"[{m_name}] {message}\n");
        }

        // This reports timestamp of very first received measurement (if useful)
        protected override void DataStartTime(DateTime startTime) => 
            StatusMessage($"Received first measurement at timestamp {startTime:yyyy-MM-dd HH:mm:ss.fff}");

        protected override void ReceivedMetadata(ByteBuffer payload)
        {
            StatusMessage($"Received {payload.Count} bytes of metadata, parsing...");
            base.ReceivedMetadata(payload);
        }

        protected override void ParsedMetadata() => 
            StatusMessage("Metadata successfully parsed.");

        public override void SubscriptionUpdated(SignalIndexCache signalIndexCache) => 
            StatusMessage($"Publisher provided {signalIndexCache.Count} measurements in response to subscription.");

        public override unsafe void ReceivedNewMeasurements(Measurement* measurements, int length)
        {
            // TODO: The following code could be used to generate frame based output, e.g., for IEEE C37.118
            // Start processing measurements
            //for (int i = 0; i < length; i++)
            //{
            //    Measurement measurement = measurements[i];

            //    // Get adjusted value
            //    double value = measurement.Value;

            //    // Get timestamp
            //    DateTime timestamp = measurement.GetDateTime();

            //    // Get signal ID
            //    Guid signalID = measurement.GetSignalID();

            //    // Handle per measurement quality flags
            //    MeasurementStateFlags qualityFlags = measurement.Flags;

            //    MeasurementMetadata measurementMetadata;

            //    // Find associated configuration for measurement
            //    if (TryFindTargetConfigurationFrame(signalID, out ConfigurationFrame configurationFrame))
            //    {
            //        // Lookup measurement metadata - it's faster to find metadata from within configuration frame
            //        if (TryGetMeasurementMetdataFromConfigurationFrame(signalID, configurationFrame, out measurementMetadata))
            //        {
            //            SignalReference reference = measurementMetadata.Reference;

            //            // reference.Acronym	<< target device acronym 
            //            // reference.Kind		<< kind of signal (see SignalKind in "Types.h"), like Frequency, Angle, etc
            //            // reference.Index    << for Phasors, Analogs and Digitals - this is the ordered "index"

            //            // TODO: Handle measurement processing here...
            //        }
            //    }
            //    else if (TryGetMeasurementMetdata(signalID, out measurementMetadata))
            //    {
            //        // Received measurement is not part of a defined configuration frame, e.g., a statistic
            //        SignalReference reference = measurementMetadata.Reference;
            //    }
            //}

            // TODO: *** Temporary Testing Code Below *** -- REMOVE BEFORE USE
            const ulong interval = 10 * 60;
            ulong measurementCount = (ulong)length;
            bool showMessage = m_processCount + measurementCount >= (m_processCount / interval + 1) * interval;

            m_processCount += measurementCount;

            // Only display messages every few seconds
            if (showMessage)
            {
                StringBuilder message = new StringBuilder();

                message.AppendLine($"{GetTotalMeasurementsReceived()} measurements received so far...");
                message.AppendLine(measurements[0].GetDateTime().ToString("yyyy-MM-dd HH:mm:ss.fff"));
                message.AppendLine($"Signal ID: {measurements[0].GetSignalID()}");
                message.AppendLine("\tPoint\t\t\t\t\tValue");

                for (int i = 0; i < length; i++)
                {
                    Measurement measurement = measurements[i];
                    message.AppendLine($"\t{measurement.GetSignalID()}\t{measurement.Value}");
                }

                StatusMessage(message.ToString());
            }
        }

        protected override void ConfigurationChanged() => 
            StatusMessage("Configuration change detected. Metadata refresh requested.");

        protected override void HistoricalReadComplete() => 
            StatusMessage("Historical data read complete.");

        protected override void ConnectionEstablished() => 
            StatusMessage("Connection established.");

        protected override void ConnectionTerminated() => 
            StatusMessage("Connection terminated.");
    }
}
