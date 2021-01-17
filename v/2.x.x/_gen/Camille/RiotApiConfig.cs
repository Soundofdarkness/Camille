﻿
// This file is automatically generated.
// Do not directly edit.
// Generated on 2021-01-17T02:55:03.863Z
using System;

namespace MingweiSamuel.Camille
{
    public interface IRiotApiConfig
    {
        /// <summary>Riot Games API key.</summary>
        string ApiKey { get; }

        /// <summary>Maximum number of concurrent requests allowed.</summary>
        int MaxConcurrentRequests { get; }

        /// <summary>Multiplier for using concurrent instances. For example, use 0.25 for 4 concurrent instances equally spread.</summary>
        float ConcurrentInstanceFactor { get; }

        /// <summary>Overhead factor to reduce the chance 429s due to network noise.</summary>
        float OverheadFactor { get; }

        /// <summary>Number of times to retry a failed request (zero for no retries).</summary>
        int Retries { get; }

        /// <summary>Factory for creating temporal buckets.</summary>
        Util.TokenBucketFactory TokenBucketFactory { get; }

    }


    public class RiotApiConfig : IRiotApiConfig
    {
        /// <summary>Riot Games API key.</summary>
        public string ApiKey { get; }

        /// <summary>Maximum number of concurrent requests allowed.</summary>
        public int MaxConcurrentRequests { get; }

        /// <summary>Multiplier for using concurrent instances. For example, use 0.25 for 4 concurrent instances equally spread.</summary>
        public float ConcurrentInstanceFactor { get; }

        /// <summary>Overhead factor to reduce the chance 429s due to network noise.</summary>
        public float OverheadFactor { get; }

        /// <summary>Number of times to retry a failed request (zero for no retries).</summary>
        public int Retries { get; }

        /// <summary>Factory for creating temporal buckets.</summary>
        public Util.TokenBucketFactory TokenBucketFactory { get; }

        private RiotApiConfig(string apiKey, int maxConcurrentRequests, float concurrentInstanceFactor, float overheadFactor, int retries, Util.TokenBucketFactory tokenBucketFactory)
        {
            ApiKey = apiKey;
            MaxConcurrentRequests = maxConcurrentRequests;
            ConcurrentInstanceFactor = concurrentInstanceFactor;
            OverheadFactor = overheadFactor;
            Retries = retries;
            TokenBucketFactory = tokenBucketFactory;
        }

        public class Builder
        {
            /// <summary>Riot Games API key.</summary>
            public string ApiKey;

            /// <summary>Maximum number of concurrent requests allowed.</summary>
            public int MaxConcurrentRequests = 1000;

            /// <summary>Multiplier for using concurrent instances. For example, use 0.25 for 4 concurrent instances equally spread.</summary>
            public float ConcurrentInstanceFactor = 1f;

            /// <summary>Overhead factor to reduce the chance 429s due to network noise.</summary>
            public float OverheadFactor = 0.95f;

            /// <summary>Number of times to retry a failed request (zero for no retries).</summary>
            public int Retries = 3;

            /// <summary>Factory for creating temporal buckets.</summary>
            public Util.TokenBucketFactory TokenBucketFactory = (timespan, totalLimit, concurrentInstanceFactor, overheadFactor) => new Util.CircularBufferTokenBucket(timespan, totalLimit, 20, 0.5f, concurrentInstanceFactor* overheadFactor);

            public Builder(string apiKey)
            {
                ApiKey = apiKey ?? throw new ArgumentException($"{nameof(apiKey)} cannot be null.");
            }

            public RiotApiConfig Build()
            {
                return new RiotApiConfig(ApiKey, MaxConcurrentRequests, ConcurrentInstanceFactor, OverheadFactor, Retries, TokenBucketFactory);
            }
        }
    }
}
