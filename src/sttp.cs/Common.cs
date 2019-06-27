//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace sttp
{


    // Measurement structure uses custom marshaling as an optimization

    // Fundamental data type representing a measurement in STTP
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public unsafe struct Measurement
    {
        // Measurement's globally unique identifier bytes.
        public fixed byte SignalID[16];

        // Instantaneous value of the measurement.
        public double Value;

        // The time, in ticks, that this measurement was taken.
        public long Timestamp;

        // Flags indicating the state of the measurement as reported by the device that took it.
        public MeasurementStateFlags Flags;

        public Measurement(System.Guid signalID, System.DateTime timestamp, double value = double.NaN, MeasurementStateFlags flags = MeasurementStateFlags.Normal)
        {
            Value = value;
            Timestamp = timestamp.Ticks;
            Flags = flags;

            this.SetSignalID(signalID);
        }

        public Measurement(System.Guid signalID, long timestamp, double value = double.NaN, MeasurementStateFlags flags = MeasurementStateFlags.Normal)
        {
            Value = value;
            Timestamp = timestamp;
            Flags = flags;

            this.SetSignalID(signalID);
        }
    }

    public static class MeasurementExtensions
    {
        public static unsafe System.Guid GetSignalID(this ref Measurement measurement)
        {
            fixed (byte* data = measurement.SignalID)
            {
                byte* swap = stackalloc byte[8];
                byte* copy = stackalloc byte[8];

                for (int i = 0; i < 8; i++)
                    copy[i] = data[i];
            
                // The following uint32 and two uint16 values are little-endian encoded in Microsoft implementations,
                // boost follows RFC encoding rules and encodes the bytes as big-endian. For proper Guid interpretation
                // by .NET applications the following bytes must be swapped before deserialization:
                swap[0] = copy[3];
                swap[1] = copy[2];
                swap[2] = copy[1];
                swap[3] = copy[0];

                swap[4] = copy[5];
                swap[5] = copy[4];

                swap[6] = copy[7];
                swap[7] = copy[6];

                return new System.Guid
                (
                    /* a */ *(uint*)swap,           // First 4 bytes of GUID
                    /* b */ *(ushort*)(swap + 4),   // Next 2 bytes of GUID
                    /* c */ *(ushort*)(swap + 6),   // Next 2 bytes of GUID
                    /* d */ data[8],                // Remaining bytes
                    /* e */ data[9],
                    /* f */ data[10],
                    /* g */ data[11],
                    /* h */ data[12],
                    /* i */ data[13],
                    /* j */ data[14],
                    /* k */ data[15]
                );
            }
        }

        public static unsafe void SetSignalID(this ref Measurement measurement, System.Guid value)
        {
            fixed (byte* data = measurement.SignalID)
            {
                byte* copy = stackalloc byte[8];
            
                fixed (byte* source = value.ToByteArray())
                {
                    for (int i = 0; i < 16; i++)
                    {
                        if (i < 8)
                            copy[i] = source[i];
                        else
                            data[i] = source[i];
                    }
                }

                // Convert Microsoft encoding to RFC
                data[0] = copy[3];
                data[1] = copy[2];
                data[3] = copy[0];
                data[2] = copy[1];

                data[4] = copy[5];
                data[5] = copy[4];

                data[6] = copy[7];
                data[7] = copy[6];
            }
        }

        public static System.DateTime GetDateTime(this ref Measurement measurement) => new System.DateTime(measurement.Timestamp);

        public static void SetDateTime(this ref Measurement measurement, System.DateTime value) => measurement.Timestamp = value.Ticks;
     }

    public class SubscriberInstance : SubscriberInstanceBase
    {
        public SubscriberInstance()
        {
            System.Reflection.Assembly assembly = typeof(SubscriberInstance).Assembly;
            System.Reflection.AssemblyName assemblyInfo = assembly.GetName();
            System.DateTime buildDate = System.IO.File.GetLastWriteTime(assembly.Location);

            GetAssemblyInfo(out string source, out string version, out string updatedOn);
            string wrapperAssemblyInfo = $", wrapping {source} version {version} updated on {updatedOn}";
            SetAssemblyInfo(assemblyInfo.Name, $"{assemblyInfo.Version.Major}.{assemblyInfo.Version.Minor}.{assemblyInfo.Version.Build}", $"{buildDate:yyyy-MM-dd HH:mm:ss}{wrapperAssemblyInfo}");
        }

        internal override unsafe void ReceivedNewMeasurements(SimpleMeasurement simpleMeasurementArray, int length)
        {
            Measurement* measurements = (Measurement*)SimpleMeasurement.getCPtr(simpleMeasurementArray).Handle.ToPointer();

            if (measurements == null)
                return;

            ReceivedNewMeasurements(measurements, length);
        }

        public virtual unsafe void ReceivedNewMeasurements(Measurement* measurements, int length)
        {
        }

        public new static readonly string SubscribeAllExpression = SubscriberInstanceBase.SubscribeAllExpression;
        public new static readonly string SubscribeAllNoStatsExpression = SubscriberInstanceBase.SubscribeAllNoStatsExpression;
        public new static readonly string FilterMetadataStatsExpression = SubscriberInstanceBase.FilterMetadataStatsExpression;
    }

public class Common {
  internal unsafe static void GetGuidBytes(guid_t value, byte[] data) {
    fixed ( byte* swig_ptrTo_data = data ) {
    {
      CommonPINVOKE.GetGuidBytes(guid_t.getCPtr(value), (global::System.IntPtr)swig_ptrTo_data);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    }
    }
  }

  public static string GetSubscriberConnectionIPAddress(SubscriberConnection connection) {
    string ret = CommonPINVOKE.GetSubscriberConnectionIPAddress(SubscriberConnection.getCPtr(connection));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal static decimal_t ParseDecimal(string value) {
    decimal_t ret = new decimal_t(CommonPINVOKE.ParseDecimal(value), true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal static string ToString(decimal_t value) {
    string ret = CommonPINVOKE.ToString(decimal_t.getCPtr(value));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal unsafe static guid_t ParseGuid(byte[] data, bool swapEndianness) {
    fixed ( byte* swig_ptrTo_data = data ) {
    {
      guid_t ret = new guid_t(CommonPINVOKE.ParseGuid((global::System.IntPtr)swig_ptrTo_data, swapEndianness), true);
      if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
    }
  }

  internal static datetime_t FromTicks(long ticks) {
    datetime_t ret = new datetime_t(CommonPINVOKE.FromTicks(ticks), true);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal static long ToTicks(datetime_t time) {
    long ret = CommonPINVOKE.ToTicks(datetime_t.getCPtr(time));
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string GetSignalTypeAcronym(SignalKind kind, char phasorType) {
    string ret = CommonPINVOKE.GetSignalTypeAcronym__SWIG_0((int)kind, phasorType);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string GetSignalTypeAcronym(SignalKind kind) {
    string ret = CommonPINVOKE.GetSignalTypeAcronym__SWIG_1((int)kind);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string GetEngineeringUnits(string signalType) {
    string ret = CommonPINVOKE.GetEngineeringUnits(signalType);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string GetProtocolType(string protocolName) {
    string ret = CommonPINVOKE.GetProtocolType(protocolName);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SignalKind ParseSignalKind(string acronym) {
    SignalKind ret = (SignalKind)CommonPINVOKE.ParseSignalKind(acronym);
    if (CommonPINVOKE.SWIGPendingException.Pending) throw CommonPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
