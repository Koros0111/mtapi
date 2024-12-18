﻿using MtApi5.MtProtocol;

namespace MtApi5
{
    public class MqlTick
    {
        public MqlTick(DateTime time, double bid, double ask, double last, ulong volume)
        {
            MtTime = Mt5TimeConverter.ConvertToMtTime(time);
            this.bid = bid;
            this.ask = ask;
            this.last = last;
            this.volume = volume;
        }

        public MqlTick()
        {
        }

        internal MqlTick(MtTick? tick)
        {
            if (tick != null)
            {
                MtTime = tick.Time;
                bid = tick.Bid;
                ask = tick.Ask;
                last = tick.Last;
                volume = tick.Volume;
                volume_real = tick.VolumeReal;
            }
        }

        public long MtTime { get; set; }          // Time of the last prices update

        public double bid { get; set; }           // Current Bid price
        public double ask { get; set; }           // Current Ask price
        public double last { get; set; }          // Price of the last deal (Last)
        public ulong volume { get; set; }         // Volume for the current Last price
        public double volume_real { get; set; }   // Volume for the current Last price with greater accuracy 

        public DateTime time => Mt5TimeConverter.ConvertFromMtTime(MtTime);
    }
}
