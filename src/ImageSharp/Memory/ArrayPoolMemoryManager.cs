﻿using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SixLabors.ImageSharp.Memory
{
    /// <summary>
    /// Implements <see cref="MemoryManager"/> by allocating memory from <see cref="ArrayPool{T}"/>.
    /// </summary>
    public partial class ArrayPoolMemoryManager : MemoryManager
    {
        /// <summary>
        /// Defines the default maximum size of pooled arrays.
        /// Currently set to a value equivalent to 16 MegaPixels of an <see cref="Rgba32"/> image.
        /// </summary>
        public const int DefaultMaxSizeInBytes = 4096 * 4096 * 4;

        private readonly ArrayPool<byte> pool;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayPoolMemoryManager"/> class.
        /// </summary>
        public ArrayPoolMemoryManager()
            : this(DefaultMaxSizeInBytes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayPoolMemoryManager"/> class.
        /// </summary>
        /// <param name="maxPoolSizeInBytes">The maximum size of pooled arrays. Arrays over the thershold are gonna be always allocated.</param>
        public ArrayPoolMemoryManager(int maxPoolSizeInBytes)
        {
            Guard.MustBeGreaterThan(maxPoolSizeInBytes, 0, nameof(maxPoolSizeInBytes));

            this.pool = ArrayPool<byte>.Create(maxPoolSizeInBytes, 50);
        }

        /// <inheritdoc />
        internal override IBuffer<T> Allocate<T>(int length, bool clear)
        {
            int itemSizeBytes = Unsafe.SizeOf<T>();
            int bufferSizeInBytes = length * itemSizeBytes;

            byte[] byteBuffer = this.pool.Rent(bufferSizeInBytes);
            var buffer = new Buffer<T>(byteBuffer, length, this);
            if (clear)
            {
                buffer.Clear();
            }

            return buffer;
        }

        internal override IManagedByteBuffer AllocateManagedByteBuffer(int length, bool clear)
        {
            byte[] array = this.pool.Rent(length);
            var buffer = new ManagedByteBuffer(array, length, this);
            if (clear)
            {
                buffer.Clear();
            }

            return buffer;
        }
    }
}