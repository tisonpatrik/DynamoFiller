﻿namespace PublicApi.RecordReaders;

public interface IRecordsReader<T>
{
    public Task<IEnumerable<T>> CreateRecordsAsync(string rawInstrumentPath, CancellationToken cancellationToken = default);
}
