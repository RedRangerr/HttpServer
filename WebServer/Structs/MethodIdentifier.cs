﻿using System;
using WebServer.Attributes;
using WebServer.Enums;

namespace WebServer.Structs
{
    public struct MethodIdentifier : IEquatable<MethodIdentifier>
    {
        public string Endpoint;
        public HttpMethodType HttpMethodType;

        public bool Equals(MethodIdentifier other)
        {
            return Endpoint == other.Endpoint && HttpMethodType == other.HttpMethodType;
        }

        public override bool Equals(object obj)
        {
            return obj is MethodIdentifier other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Endpoint != null ? Endpoint.GetHashCode() : 0) * 397) ^ (int) HttpMethodType;
            }
        }

        public override string ToString()
        {
            return $"Endpoint: {Endpoint}, MethodType: {HttpMethodType}";
        }
    }
}