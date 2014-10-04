﻿using System;
using System.Collections.Generic;

namespace Simple.OData.Client
{
    public interface IODataAdapter
    {
        AdapterVersion AdapterVersion { get; }
        ODataPayloadFormat DefaultPayloadFormat { get; }
        string ProtocolVersion { get; set; }
        object Model { get; set; }

        string GetODataVersionString();
        string ConvertValueToUriLiteral(object value);
        string ConvertKeyToUriLiteral(IDictionary<string, object> key);

        IMetadata GetMetadata();
        IResponseReader GetResponseReader();
        IRequestWriter GetRequestWriter(Lazy<IBatchWriter> deferredBatchWriter);
        IBatchWriter GetBatchWriter();
    }
}