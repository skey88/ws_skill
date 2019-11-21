// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:0,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34778,y:32721,varname:node_3138,prsc:2|emission-2020-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:33901,y:32976,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:0.5;n:type:ShaderForge.SFN_VertexColor,id:7932,x:32846,y:32770,varname:node_7932,prsc:2;n:type:ShaderForge.SFN_ComponentMask,id:4300,x:32807,y:32546,varname:node_4300,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7932-RGB;n:type:ShaderForge.SFN_Add,id:786,x:32984,y:32509,varname:node_786,prsc:2|A-1926-UVOUT,B-4300-OUT;n:type:ShaderForge.SFN_TexCoord,id:1926,x:32836,y:32403,varname:node_1926,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:2005,x:33176,y:32492,ptovrint:False,ptlb:SwingTex,ptin:_SwingTex,varname:_SwingTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-786-OUT;n:type:ShaderForge.SFN_Add,id:5830,x:33406,y:32617,varname:node_5830,prsc:2|A-2005-RGB,B-5933-OUT;n:type:ShaderForge.SFN_Vector1,id:5933,x:33199,y:32651,varname:node_5933,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Multiply,id:7228,x:33567,y:32721,varname:node_7228,prsc:2|A-5830-OUT,B-875-OUT;n:type:ShaderForge.SFN_Multiply,id:875,x:33406,y:32745,varname:node_875,prsc:2|A-7932-B,B-9042-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9042,x:33249,y:32797,ptovrint:False,ptlb:SwingPower,ptin:_SwingPower,varname:_SwingPower,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ComponentMask,id:5075,x:33733,y:32721,varname:node_5075,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7228-OUT;n:type:ShaderForge.SFN_Add,id:1686,x:33901,y:32652,varname:node_1686,prsc:2|A-8637-UVOUT,B-5075-OUT;n:type:ShaderForge.SFN_TexCoord,id:8637,x:33713,y:32557,varname:node_8637,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:3747,x:34075,y:32635,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1686-OUT;n:type:ShaderForge.SFN_Multiply,id:1101,x:34271,y:32763,varname:node_1101,prsc:2|A-3747-RGB,B-5179-OUT;n:type:ShaderForge.SFN_Multiply,id:5179,x:34093,y:32819,varname:node_5179,prsc:2|A-7241-RGB,B-5991-OUT;n:type:ShaderForge.SFN_Vector1,id:5991,x:33901,y:32863,varname:node_5991,prsc:2,v1:2;n:type:ShaderForge.SFN_Multiply,id:9194,x:34131,y:33027,varname:node_9194,prsc:2|A-5991-OUT,B-7241-A;n:type:ShaderForge.SFN_Multiply,id:742,x:34291,y:32947,varname:node_742,prsc:2|A-7932-A,B-9194-OUT;n:type:ShaderForge.SFN_Multiply,id:8125,x:34452,y:32830,varname:node_8125,prsc:2|A-1101-OUT,B-742-OUT,C-3747-A;n:type:ShaderForge.SFN_Tex2d,id:9608,x:34046,y:33199,ptovrint:False,ptlb:AlphaChange,ptin:_AlphaChange,varname:_AlphaChange,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Subtract,id:2020,x:34498,y:33175,varname:node_2020,prsc:2|A-8125-OUT,B-4151-OUT;n:type:ShaderForge.SFN_Multiply,id:4151,x:34300,y:33370,varname:node_4151,prsc:2|A-9608-RGB,B-2873-OUT,C-3900-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2873,x:34072,y:33466,ptovrint:False,ptlb:FadePower,ptin:_FadePower,varname:_FadePower,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_OneMinus,id:3900,x:33659,y:33381,varname:node_3900,prsc:2|IN-7932-A;proporder:7241-3747-2005-9042-9608-2873;pass:END;sub:END;*/

Shader "Shader Forge/UVswingAddFade" {
    Properties {
        _Color ("Color", Color) = (0.5,0.5,0.5,0.5)
        _MainTex ("MainTex", 2D) = "white" {}
        _SwingTex ("SwingTex", 2D) = "white" {}
        _SwingPower ("SwingPower", Float ) = 1
        _AlphaChange ("AlphaChange", 2D) = "black" {}
        _FadePower ("FadePower", Float ) = 10
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
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _Color;
            uniform sampler2D _SwingTex; uniform float4 _SwingTex_ST;
            uniform float _SwingPower;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _AlphaChange; uniform float4 _AlphaChange_ST;
            uniform float _FadePower;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float2 node_786 = (i.uv0+i.vertexColor.rgb.rg);
                float4 _SwingTex_var = tex2D(_SwingTex,TRANSFORM_TEX(node_786, _SwingTex));
                float2 node_1686 = (i.uv0+((_SwingTex_var.rgb+(-0.5))*(i.vertexColor.b*_SwingPower)).rg);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_1686, _MainTex));
                float node_5991 = 2.0;
                float4 _AlphaChange_var = tex2D(_AlphaChange,TRANSFORM_TEX(i.uv0, _AlphaChange));
                float3 emissive = (((_MainTex_var.rgb*(_Color.rgb*node_5991))*(i.vertexColor.a*(node_5991*_Color.a))*_MainTex_var.a)-(_AlphaChange_var.rgb*_FadePower*(1.0 - i.vertexColor.a)));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
