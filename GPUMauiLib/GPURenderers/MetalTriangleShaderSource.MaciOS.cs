﻿// ---------------------------------------------------------------------------------------
//                                        ILGPU
//                           Copyright (c) 2023 ILGPU Project
//                                    www.ilgpu.net
//
// File: .cs
//
// This file is part of ILGPU and is distributed under the University of Illinois Open
// Source License. See LICENSE.txt for details.
// ---------------------------------------------------------------------------------------

using System;


namespace GPUMauiLib.GPURenderers
{

    public static class MetalTriangleShaderSource
    {
        public const string TriangleShaders = @"#include <metal_stdlib>
#include <simd/simd.h>

using namespace metal;

typedef struct {
    float4 position [[attribute(0)]];
    float4 color [[attribute(1)]];
} VertexInput;

typedef struct {
    float4 position [[position]];
    float4  color;
} ColorInOut;

// Vertex shader function
vertex ColorInOut triangle_vertex(VertexInput in [[ stage_in ]])
{
    ColorInOut out;
   
    out.position = in.position;
    out.color = in.color;
    
    return out;
}

// Fragment shader function
fragment float4 triangle_fragment(ColorInOut in [[stage_in]])
{
    return in.color;
}";
    }


}

