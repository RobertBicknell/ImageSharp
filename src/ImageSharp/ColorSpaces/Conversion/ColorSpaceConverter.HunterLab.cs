﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SixLabors.ImageSharp.ColorSpaces.Conversion
{
    /// <content>
    /// Allows conversion to <see cref="HunterLab"/>.
    /// </content>
    public partial class ColorSpaceConverter
    {
        /// <summary>
        /// Converts a <see cref="CieLab"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in CieLab color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLab"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<CieLab> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLab sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLab sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieLch"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in CieLch color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLch"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<CieLch> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLch sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLch sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieLchuv"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in CieLchuv color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLchuv"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<CieLchuv> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLchuv sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLchuv sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieLuv"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in CieLuv color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLuv"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<CieLuv> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLuv sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLuv sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieXyy"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in CieXyy color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieXyy"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<CieXyy> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieXyy sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieXyy sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieXyz"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in CieXyz color)
        {
            // Adaptation
            CieXyz adapted = this.Adapt(color, this.whitePoint, this.targetHunterLabWhitePoint);

            // Conversion
            return this.cieXyzToHunterLabConverter.Convert(adapted);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieXyz"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<CieXyz> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieXyz sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieXyz sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Cmyk"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in Cmyk color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Cmyk"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<Cmyk> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Cmyk sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Cmyk sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Hsl"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in Hsl color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Hsl"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<Hsl> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Hsl sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Hsl sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Hsv"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in Hsv color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Hsl"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<Hsv> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Hsv sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Hsv sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="LinearRgb"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in LinearRgb color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="LinearRgb"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<LinearRgb> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref LinearRgb sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref LinearRgb sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Lms"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in Lms color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Lms"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<Lms> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Lms sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Lms sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Rgb"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in Rgb color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Rgb"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<Rgb> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Rgb sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Rgb sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="YCbCr"/> into a <see cref="HunterLab"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="HunterLab"/></returns>
        public HunterLab ToHunterLab(in YCbCr color)
        {
            var xyzColor = this.ToCieXyz(color);
            return this.ToHunterLab(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="YCbCr"/> into <see cref="HunterLab"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(ReadOnlySpan<YCbCr> source, Span<HunterLab> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref YCbCr sourceRef = ref MemoryMarshal.GetReference(source);
            ref HunterLab destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref YCbCr sp = ref Unsafe.Add(ref sourceRef, i);
                ref HunterLab dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHunterLab(sp);
            }
        }
    }
}