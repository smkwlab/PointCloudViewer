// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Resolvers
{
    using System;

    public class GeneratedResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new GeneratedResolver();

        private GeneratedResolver()
        {
        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        private static class FormatterCache<T>
        {
            internal static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    Formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        private static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(5)
            {
                { typeof(global::Share.IdentifiedPoint[]), 0 },
                { typeof(global::Share.PackedMessage.IPackedMessage), 1 },
                { typeof(global::Share.IdentifiedPoint), 2 },
                { typeof(global::Share.PackedMessage.DevicePose), 3 },
                { typeof(global::Share.PackedMessage.IdentifiedPointArray), 4 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MessagePack.Formatters.ArrayFormatter<global::Share.IdentifiedPoint>();
                case 1: return new MessagePack.Formatters.Share.IPackedMessageFormatter();
                case 2: return new MessagePack.Formatters.Share.IdentifiedPointFormatter();
                case 3: return new MessagePack.Formatters.Share.PackedMessage_DevicePoseFormatter();
                case 4: return new MessagePack.Formatters.Share.PackedMessage_IdentifiedPointArrayFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1649 // File name should match first type name



// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Share
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;
    using MessagePack;

    public sealed class IPackedMessageFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Share.PackedMessage.IPackedMessage>
    {
        private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
        private readonly Dictionary<int, int> keyToJumpMap;

        public IPackedMessageFormatter()
        {
            this.typeToKeyAndJumpMap = new Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>(2, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
            {
                { typeof(global::Share.PackedMessage.IdentifiedPointArray).TypeHandle, new KeyValuePair<int, int>(0, 0) },
                { typeof(global::Share.PackedMessage.DevicePose).TypeHandle, new KeyValuePair<int, int>(1, 1) },
            };
            this.keyToJumpMap = new Dictionary<int, int>(2)
            {
                { 0, 0 },
                { 1, 1 },
            };
        }

        public void Serialize(ref MessagePackWriter writer, global::Share.PackedMessage.IPackedMessage value, global::MessagePack.MessagePackSerializerOptions options)
        {
            KeyValuePair<int, int> keyValuePair;
            if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
            {
                writer.WriteArrayHeader(2);
                writer.WriteInt32(keyValuePair.Key);
                switch (keyValuePair.Value)
                {
                    case 0:
                        options.Resolver.GetFormatterWithVerify<global::Share.PackedMessage.IdentifiedPointArray>().Serialize(ref writer, (global::Share.PackedMessage.IdentifiedPointArray)value, options);
                        break;
                    case 1:
                        options.Resolver.GetFormatterWithVerify<global::Share.PackedMessage.DevicePose>().Serialize(ref writer, (global::Share.PackedMessage.DevicePose)value, options);
                        break;
                    default:
                        break;
                }

                return;
            }

            writer.WriteNil();
        }

        public global::Share.PackedMessage.IPackedMessage Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            if (reader.ReadArrayHeader() != 2)
            {
                throw new InvalidOperationException("Invalid Union data was detected. Type:global::Share.PackedMessage.IPackedMessage");
            }

            options.Security.DepthStep(ref reader);
            var key = reader.ReadInt32();

            if (!this.keyToJumpMap.TryGetValue(key, out key))
            {
                key = -1;
            }

            global::Share.PackedMessage.IPackedMessage result = null;
            switch (key)
            {
                case 0:
                    result = (global::Share.PackedMessage.IPackedMessage)options.Resolver.GetFormatterWithVerify<global::Share.PackedMessage.IdentifiedPointArray>().Deserialize(ref reader, options);
                    break;
                case 1:
                    result = (global::Share.PackedMessage.IPackedMessage)options.Resolver.GetFormatterWithVerify<global::Share.PackedMessage.DevicePose>().Deserialize(ref reader, options);
                    break;
                default:
                    reader.Skip();
                    break;
            }

            reader.Depth--;
            return result;
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name


// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Share
{
    using System;
    using System.Buffers;
    using MessagePack;

    public sealed class IdentifiedPointFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Share.IdentifiedPoint>
    {

        public void Serialize(ref MessagePackWriter writer, global::Share.IdentifiedPoint value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(6);
            writer.Write(value.Identify);
            formatterResolver.GetFormatterWithVerify<UnityEngine.Vector3>().Serialize(ref writer, value.Position, options);
            writer.Write(value.Confidence);
            writer.WriteNil();
            formatterResolver.GetFormatterWithVerify<UnityEngine.Vector3>().Serialize(ref writer, value.CameraPosition, options);
            formatterResolver.GetFormatterWithVerify<UnityEngine.Quaternion>().Serialize(ref writer, value.CameraRotation, options);
        }

        public global::Share.IdentifiedPoint Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __Identify__ = default(ulong);
            var __Position__ = default(UnityEngine.Vector3);
            var __Confidence__ = default(float);
            var __CameraPosition__ = default(UnityEngine.Vector3);
            var __CameraRotation__ = default(UnityEngine.Quaternion);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __Identify__ = reader.ReadUInt64();
                        break;
                    case 1:
                        __Position__ = formatterResolver.GetFormatterWithVerify<UnityEngine.Vector3>().Deserialize(ref reader, options);
                        break;
                    case 2:
                        __Confidence__ = reader.ReadSingle();
                        break;
                    case 4:
                        __CameraPosition__ = formatterResolver.GetFormatterWithVerify<UnityEngine.Vector3>().Deserialize(ref reader, options);
                        break;
                    case 5:
                        __CameraRotation__ = formatterResolver.GetFormatterWithVerify<UnityEngine.Quaternion>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::Share.IdentifiedPoint();
            ____result.Identify = __Identify__;
            ____result.Position = __Position__;
            ____result.Confidence = __Confidence__;
            ____result.CameraPosition = __CameraPosition__;
            ____result.CameraRotation = __CameraRotation__;
            reader.Depth--;
            return ____result;
        }
    }

    public sealed class PackedMessage_DevicePoseFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Share.PackedMessage.DevicePose>
    {

        public void Serialize(ref MessagePackWriter writer, global::Share.PackedMessage.DevicePose value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(2);
            formatterResolver.GetFormatterWithVerify<UnityEngine.Vector3>().Serialize(ref writer, value.Position, options);
            formatterResolver.GetFormatterWithVerify<UnityEngine.Quaternion>().Serialize(ref writer, value.Rotation, options);
        }

        public global::Share.PackedMessage.DevicePose Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __Position__ = default(UnityEngine.Vector3);
            var __Rotation__ = default(UnityEngine.Quaternion);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __Position__ = formatterResolver.GetFormatterWithVerify<UnityEngine.Vector3>().Deserialize(ref reader, options);
                        break;
                    case 1:
                        __Rotation__ = formatterResolver.GetFormatterWithVerify<UnityEngine.Quaternion>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::Share.PackedMessage.DevicePose();
            ____result.Position = __Position__;
            ____result.Rotation = __Rotation__;
            reader.Depth--;
            return ____result;
        }
    }

    public sealed class PackedMessage_IdentifiedPointArrayFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Share.PackedMessage.IdentifiedPointArray>
    {

        public void Serialize(ref MessagePackWriter writer, global::Share.PackedMessage.IdentifiedPointArray value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(2);
            formatterResolver.GetFormatterWithVerify<global::Share.IdentifiedPoint[]>().Serialize(ref writer, value.Array, options);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.Time, options);
        }

        public global::Share.PackedMessage.IdentifiedPointArray Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __Array__ = default(global::Share.IdentifiedPoint[]);
            var __Time__ = default(global::System.DateTimeOffset);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __Array__ = formatterResolver.GetFormatterWithVerify<global::Share.IdentifiedPoint[]>().Deserialize(ref reader, options);
                        break;
                    case 1:
                        __Time__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::Share.PackedMessage.IdentifiedPointArray();
            ____result.Array = __Array__;
            ____result.Time = __Time__;
            reader.Depth--;
            return ____result;
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

