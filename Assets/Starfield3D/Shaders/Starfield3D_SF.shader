// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.37 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.37;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:30822,y:33296,varname:node_3138,prsc:2|emission-4660-OUT,voffset-3574-OUT;n:type:ShaderForge.SFN_TexCoord,id:9524,x:28492,y:33386,varname:node_9524,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Vector3,id:625,x:28140,y:33696,varname:node_625,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_ViewVector,id:6027,x:27748,y:33953,varname:node_6027,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9534,x:29325,y:33770,varname:node_9534,prsc:2|A-2202-OUT,B-176-R,C-8067-OUT;n:type:ShaderForge.SFN_Cross,id:9535,x:28609,y:33927,varname:node_9535,prsc:2|A-625-OUT,B-4094-OUT;n:type:ShaderForge.SFN_Normalize,id:2202,x:28963,y:33961,varname:node_2202,prsc:2|IN-9535-OUT;n:type:ShaderForge.SFN_Subtract,id:8062,x:28756,y:33575,varname:node_8062,prsc:2|A-9524-UVOUT,B-5908-OUT;n:type:ShaderForge.SFN_Vector1,id:5908,x:28502,y:33648,varname:node_5908,prsc:2,v1:0.5;n:type:ShaderForge.SFN_ComponentMask,id:176,x:28960,y:33575,varname:node_176,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8062-OUT;n:type:ShaderForge.SFN_Cross,id:423,x:28787,y:33769,varname:node_423,prsc:2|A-9535-OUT,B-4094-OUT;n:type:ShaderForge.SFN_Normalize,id:1979,x:28963,y:33769,varname:node_1979,prsc:2|IN-423-OUT;n:type:ShaderForge.SFN_Multiply,id:2402,x:29325,y:33628,varname:node_2402,prsc:2|A-1979-OUT,B-176-G;n:type:ShaderForge.SFN_Add,id:1820,x:29529,y:33696,varname:node_1820,prsc:2|A-2402-OUT,B-9534-OUT;n:type:ShaderForge.SFN_Normalize,id:3810,x:29756,y:33728,varname:node_3810,prsc:2|IN-1820-OUT;n:type:ShaderForge.SFN_Transform,id:46,x:28222,y:33954,varname:node_46,prsc:2,tffrom:0,tfto:1|IN-6027-OUT;n:type:ShaderForge.SFN_Relay,id:4094,x:28413,y:33932,varname:node_4094,prsc:2|IN-46-XYZ;n:type:ShaderForge.SFN_FragmentPosition,id:1104,x:26493,y:34703,varname:node_1104,prsc:2;n:type:ShaderForge.SFN_Subtract,id:5850,x:26738,y:34703,varname:node_5850,prsc:2|A-1104-XYZ,B-3411-XYZ;n:type:ShaderForge.SFN_Vector1,id:8067,x:29119,y:33838,varname:node_8067,prsc:2,v1:-1;n:type:ShaderForge.SFN_Multiply,id:3574,x:30536,y:33961,varname:node_3574,prsc:2|A-5874-OUT,B-467-OUT,C-550-OUT;n:type:ShaderForge.SFN_Vector1,id:467,x:30134,y:34080,varname:node_467,prsc:2,v1:0.003;n:type:ShaderForge.SFN_ViewPosition,id:3411,x:26493,y:34854,varname:node_3411,prsc:2;n:type:ShaderForge.SFN_Length,id:4832,x:26918,y:34703,varname:node_4832,prsc:2|IN-5850-OUT;n:type:ShaderForge.SFN_Log,id:8842,x:27997,y:34816,varname:node_8842,prsc:2,lt:2|IN-5873-OUT;n:type:ShaderForge.SFN_Multiply,id:4364,x:28256,y:34812,varname:node_4364,prsc:2|A-8842-OUT,B-4476-OUT;n:type:ShaderForge.SFN_Vector1,id:4476,x:27997,y:34973,varname:node_4476,prsc:2,v1:5;n:type:ShaderForge.SFN_TexCoord,id:3121,x:27966,y:34448,varname:node_3121,prsc:2,uv:1,uaff:False;n:type:ShaderForge.SFN_Subtract,id:2034,x:28860,y:34470,varname:node_2034,prsc:2|A-8149-OUT,B-2525-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4740,x:29293,y:34650,ptovrint:False,ptlb:Multiplier,ptin:_Multiplier,varname:node_4740,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8244,x:29592,y:34527,varname:node_8244,prsc:2|A-8232-OUT,B-4740-OUT;n:type:ShaderForge.SFN_Multiply,id:5874,x:30134,y:33887,varname:node_5874,prsc:2|A-3810-OUT,B-8244-OUT;n:type:ShaderForge.SFN_Tex2d,id:6552,x:29003,y:33241,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_6552,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9524-UVOUT;n:type:ShaderForge.SFN_Multiply,id:4469,x:29587,y:33244,varname:node_4469,prsc:2|A-3235-RGB,B-6552-R;n:type:ShaderForge.SFN_VertexColor,id:3235,x:29003,y:33417,varname:node_3235,prsc:2;n:type:ShaderForge.SFN_Add,id:4660,x:29831,y:33323,varname:node_4660,prsc:2|A-4469-OUT,B-7898-OUT;n:type:ShaderForge.SFN_Multiply,id:7898,x:29380,y:33409,varname:node_7898,prsc:2|A-6552-G,B-7798-OUT;n:type:ShaderForge.SFN_Vector1,id:7798,x:29212,y:33525,varname:node_7798,prsc:2,v1:10;n:type:ShaderForge.SFN_Subtract,id:3218,x:28211,y:34487,varname:node_3218,prsc:2|A-3121-U,B-2258-OUT;n:type:ShaderForge.SFN_Vector1,id:2258,x:27966,y:34630,varname:node_2258,prsc:2,v1:5;n:type:ShaderForge.SFN_Add,id:2525,x:28581,y:34491,varname:node_2525,prsc:2|A-3218-OUT,B-4364-OUT;n:type:ShaderForge.SFN_Multiply,id:5873,x:27625,y:34741,varname:node_5873,prsc:2|A-1762-OUT,B-2189-OUT;n:type:ShaderForge.SFN_Vector1,id:2189,x:27414,y:34915,varname:node_2189,prsc:2,v1:100;n:type:ShaderForge.SFN_Relay,id:550,x:30193,y:34208,varname:node_550,prsc:2|IN-1762-OUT;n:type:ShaderForge.SFN_Power,id:8232,x:29293,y:34478,varname:node_8232,prsc:2|VAL-6565-OUT,EXP-1220-OUT;n:type:ShaderForge.SFN_Vector1,id:1220,x:29035,y:34663,varname:node_1220,prsc:2,v1:1.5;n:type:ShaderForge.SFN_ConstantClamp,id:6565,x:29061,y:34478,varname:node_6565,prsc:2,min:0,max:1000|IN-2034-OUT;n:type:ShaderForge.SFN_Relay,id:1762,x:27505,y:34703,varname:node_1762,prsc:2|IN-9310-OUT;n:type:ShaderForge.SFN_ObjectScale,id:9719,x:26647,y:34896,varname:node_9719,prsc:2,rcp:False;n:type:ShaderForge.SFN_Add,id:9494,x:26816,y:34918,varname:node_9494,prsc:2|A-9719-X,B-9719-Y,C-9719-Z;n:type:ShaderForge.SFN_Divide,id:1404,x:26995,y:34918,varname:node_1404,prsc:2|A-9494-OUT,B-245-OUT;n:type:ShaderForge.SFN_Vector1,id:245,x:26816,y:35046,varname:node_245,prsc:2,v1:3;n:type:ShaderForge.SFN_Divide,id:9310,x:27226,y:34752,varname:node_9310,prsc:2|A-4832-OUT,B-1404-OUT;n:type:ShaderForge.SFN_Slider,id:8149,x:28424,y:34380,ptovrint:False,ptlb:Slice,ptin:_Slice,varname:node_8149,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:6,max:16;proporder:8149-4740-6552;pass:END;sub:END;*/

Shader "Starfield3D/Starfield3D_SF" {
    Properties {
        _Slice ("Slice", Range(0, 16)) = 6
        _Multiplier ("Multiplier", Float ) = 1
        _Texture ("Texture", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform float _Multiplier;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _Slice;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.vertexColor = v.vertexColor;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - mul(unity_ObjectToWorld, v.vertex).xyz);
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                float3 node_4094 = mul( unity_WorldToObject, float4(viewDirection,0) ).xyz.rgb;
                float3 node_9535 = cross(float3(0,1,0),node_4094);
                float2 node_176 = (o.uv0-0.5).rg;
                float node_1762 = (length((mul(unity_ObjectToWorld, v.vertex).rgb-_WorldSpaceCameraPos))/((objScale.r+objScale.g+objScale.b)/3.0));
                v.vertex.xyz += ((normalize(((normalize(cross(node_9535,node_4094))*node_176.g)+(normalize(node_9535)*node_176.r*(-1.0))))*(pow(clamp((_Slice-((o.uv1.r-5.0)+(log10((node_1762*100.0))*5.0))),0,1000),1.5)*_Multiplier))*0.003*node_1762);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
////// Lighting:
////// Emissive:
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(i.uv0, _Texture));
                float3 emissive = ((i.vertexColor.rgb*_Texture_var.r)+(_Texture_var.g*10.0));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform float _Multiplier;
            uniform float _Slice;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - mul(unity_ObjectToWorld, v.vertex).xyz);
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                float3 node_4094 = mul( unity_WorldToObject, float4(viewDirection,0) ).xyz.rgb;
                float3 node_9535 = cross(float3(0,1,0),node_4094);
                float2 node_176 = (o.uv0-0.5).rg;
                float node_1762 = (length((mul(unity_ObjectToWorld, v.vertex).rgb-_WorldSpaceCameraPos))/((objScale.r+objScale.g+objScale.b)/3.0));
                v.vertex.xyz += ((normalize(((normalize(cross(node_9535,node_4094))*node_176.g)+(normalize(node_9535)*node_176.r*(-1.0))))*(pow(clamp((_Slice-((o.uv1.r-5.0)+(log10((node_1762*100.0))*5.0))),0,1000),1.5)*_Multiplier))*0.003*node_1762);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
