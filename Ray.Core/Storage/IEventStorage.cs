﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Ray.Core.Event;

namespace Ray.Core.Storage
{
    public interface IEventStorage<K>
    {
        Task<IList<IEvent<K>>> GetList(K stateId, long latestTimestamp, long startVersion, long endVersion);
        Task<IList<IEvent<K>>> GetListByType(K stateId, string typeCode, long startVersion, int limit);
        Task<bool> Append(IEvent<K> data, byte[] bytes, string uniqueId = null);
        Task Delete(K stateId, long endVersion);
        Task TransactionBatchAppend(List<EventTransmitWrapper<K>> list);
    }
}