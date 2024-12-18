﻿namespace MtApi
{
    public class MtSession
    {
        public string? Symbol { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public uint Index { get; set; }
        public int MtFromTime { get; set; }
        public DateTime From => MtApiTimeConverter.ConvertFromMtTime(MtFromTime);
        public int MtToTime { get; set; }
        public DateTime To => MtApiTimeConverter.ConvertFromMtTime(MtToTime);
        public bool HasData { get; set; }
        public SessionType Type { get; set; }
    }

    public enum SessionType
    {
        Quote,
        Trade
    }
}
