// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </summary>
    public readonly partial struct RedisSkuFamily : IEquatable<RedisSkuFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisSkuFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisSkuFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CValue = "C";
        private const string PValue = "P";

        /// <summary> C. </summary>
        public static RedisSkuFamily C { get; } = new RedisSkuFamily(CValue);
        /// <summary> P. </summary>
        public static RedisSkuFamily P { get; } = new RedisSkuFamily(PValue);
        /// <summary> Determines if two <see cref="RedisSkuFamily"/> values are the same. </summary>
        public static bool operator ==(RedisSkuFamily left, RedisSkuFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisSkuFamily"/> values are not the same. </summary>
        public static bool operator !=(RedisSkuFamily left, RedisSkuFamily right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisSkuFamily"/>. </summary>
        public static implicit operator RedisSkuFamily(string value) => new RedisSkuFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisSkuFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisSkuFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
