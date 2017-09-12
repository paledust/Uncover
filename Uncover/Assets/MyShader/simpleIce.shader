// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33212,y:32888,varname:node_3138,prsc:2|emission-135-OUT,alpha-5547-OUT,refract-2918-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32170,y:32603,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Fresnel,id:3007,x:31599,y:33012,varname:node_3007,prsc:2|EXP-5370-OUT;n:type:ShaderForge.SFN_Multiply,id:5838,x:32330,y:32917,varname:node_5838,prsc:2|A-6711-RGB,B-7145-OUT,C-7774-OUT;n:type:ShaderForge.SFN_Color,id:6711,x:32053,y:32824,ptovrint:False,ptlb:Rim Color,ptin:_RimColor,varname:node_6711,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Add,id:135,x:32561,y:32762,varname:node_135,prsc:2|A-7241-RGB,B-5838-OUT;n:type:ShaderForge.SFN_Slider,id:7774,x:31907,y:33282,ptovrint:False,ptlb:Rim Strength,ptin:_RimStrength,varname:node_7774,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:5370,x:31179,y:33017,ptovrint:False,ptlb:Rim Position,ptin:_RimPosition,varname:node_5370,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.733351,max:4;n:type:ShaderForge.SFN_Exp,id:8836,x:31573,y:33260,varname:node_8836,prsc:2,et:1|IN-8827-OUT;n:type:ShaderForge.SFN_Multiply,id:7145,x:31863,y:33063,varname:node_7145,prsc:2|A-3007-OUT,B-8836-OUT;n:type:ShaderForge.SFN_Slider,id:8827,x:31144,y:33303,ptovrint:False,ptlb:Rim Falloff,ptin:_RimFalloff,varname:node_8827,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:3;n:type:ShaderForge.SFN_Slider,id:5547,x:32561,y:33031,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_5547,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3041893,max:1;n:type:ShaderForge.SFN_Slider,id:1550,x:32484,y:33396,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:node_1550,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1939257,max:1;n:type:ShaderForge.SFN_TexCoord,id:6606,x:32484,y:33227,varname:node_6606,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:2918,x:32870,y:33270,varname:node_2918,prsc:2|A-6606-UVOUT,B-1550-OUT;proporder:7241-6711-7774-5370-8827-5547-1550;pass:END;sub:END;*/

Shader "Shader Forge/simpleIce" {
    Properties {
        _Color ("Color", Color) = (0.07843138,0.3921569,0.7843137,1)
        _RimColor ("Rim Color", Color) = (1,0,0,1)
        _RimStrength ("Rim Strength", Range(0, 1)) = 1
        _RimPosition ("Rim Position", Range(0, 4)) = 2.733351
        _RimFalloff ("Rim Falloff", Range(0, 3)) = 0
        _Opacity ("Opacity", Range(0, 1)) = 0.3041893
        _Refraction ("Refraction", Range(0, 1)) = 0.1939257
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _Color;
            uniform float4 _RimColor;
            uniform float _RimStrength;
            uniform float _RimPosition;
            uniform float _RimFalloff;
            uniform float _Opacity;
            uniform float _Refraction;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 screenPos : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos(v.vertex );
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + (i.uv0*_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
////// Lighting:
////// Emissive:
                float3 node_5838 = (_RimColor.rgb*(pow(1.0-max(0,dot(normalDirection, viewDirection)),_RimPosition)*exp2(_RimFalloff))*_RimStrength);
                float3 emissive = (_Color.rgb+node_5838);
                float3 finalColor = emissive;
                return fixed4(lerp(sceneColor.rgb, finalColor,_Opacity),1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
