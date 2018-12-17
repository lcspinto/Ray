﻿namespace Ray.Core.Internal
{
    public class BytesEventTaskSource<K> : EventTaskSource<K>
    {
        public BytesEventTaskSource(IEventBase<K> value, byte[] bytes, string uniqueId = null) : base(value, uniqueId)
        {
            Bytes = bytes;
        }
        public byte[] Bytes { get; set; }
        public bool Result { get; set; }
    }
}
