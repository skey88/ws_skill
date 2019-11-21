// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:32724,y:32693,varname:node_4795,prsc:2|emission-6328-OUT,alpha-7314-OUT;n:type:ShaderForge.SFN_Multiply,id:6328,x:32538,y:32783,varname:node_6328,prsc:2|A-8300-RGB,B-4901-OUT;n:type:ShaderForge.SFN_Multiply,id:7314,x:32538,y:32957,varname:node_7314,prsc:2|A-695-OUT,B-4311-OUT;n:type:ShaderForge.SFN_Tex2d,id:8300,x:32263,y:32733,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_8300,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-4436-OUT;n:type:ShaderForge.SFN_Multiply,id:695,x:32232,y:32945,varname:node_695,prsc:2|A-8300-A,B-1516-A;n:type:ShaderForge.SFN_Multiply,id:4901,x:32269,y:33079,varname:node_4901,prsc:2|A-7800-RGB,B-383-OUT;n:type:ShaderForge.SFN_Multiply,id:4311,x:32242,y:33242,varname:node_4311,prsc:2|A-383-OUT,B-7800-A;n:type:ShaderForge.SFN_Color,id:7800,x:32052,y:33091,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7800,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:0.5;n:type:ShaderForge.SFN_VertexColor,id:1516,x:31053,y:32905,varname:node_1516,prsc:2;n:type:ShaderForge.SFN_Add,id:4436,x:32074,y:32733,varname:node_4436,prsc:2|A-7141-UVOUT,B-9061-OUT;n:type:ShaderForge.SFN_TexCoord,id:7141,x:31901,y:32634,varname:node_7141,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:9061,x:31901,y:32799,varname:node_9061,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-2431-OUT;n:type:ShaderForge.SFN_Multiply,id:2431,x:31739,y:32799,varname:node_2431,prsc:2|A-7493-OUT,B-1112-OUT;n:type:ShaderForge.SFN_Multiply,id:1112,x:31559,y:32818,varname:node_1112,prsc:2|A-4148-OUT,B-1516-B;n:type:ShaderForge.SFN_ValueProperty,id:4148,x:31366,y:32893,ptovrint:False,ptlb:SwingPower,ptin:_SwingPower,varname:node_4148,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Add,id:7493,x:31559,y:32689,varname:node_7493,prsc:2|A-6507-RGB,B-6626-OUT;n:type:ShaderForge.SFN_Vector1,id:6626,x:31366,y:32734,varname:node_6626,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Tex2d,id:6507,x:31388,y:32554,ptovrint:False,ptlb:SwingTex,ptin:_SwingTex,varname:node_6507,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-8085-OUT;n:type:ShaderForge.SFN_Add,id:8085,x:31206,y:32554,varname:node_8085,prsc:2|A-9849-UVOUT,B-1210-OUT;n:type:ShaderForge.SFN_TexCoord,id:9849,x:31008,y:32544,varname:node_9849,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:1210,x:31121,y:32734,varname:node_1210,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-1516-RGB;n:type:ShaderForge.SFN_Vector1,id:383,x:32064,y:33286,varname:node_383,prsc:2,v1:2;proporder:7800-8300-6507-4148;pass:END;sub:END;*/

Shader "Shader Forge/UVSwingBlend" {
    Properties {
        _Color ("Color", Color) = (0.5,0.5,0.5,0.5)
        _MainTex ("MainTex", 2D) = "white" {}
        _SwingTex ("SwingTex", 2D) = "white" {}
        _SwingPower ("SwingPower", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
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
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 2.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            uniform float _SwingPower;
            uniform sampler2D _SwingTex; uniform float4 _SwingTex_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float2 node_8085 = (i.uv0+i.vertexColor.rgb.rg);
                float4 _SwingTex_var = tex2D(_SwingTex,TRANSFORM_TEX(node_8085, _SwingTex));
                float2 node_4436 = (i.uv0+((_SwingTex_var.rgb+(-0.5))*(_SwingPower*i.vertexColor.b)).rg);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_4436, _MainTex));
                float node_383 = 2.0;
                float3 emissive = (_MainTex_var.rgb*(_Color.rgb*node_383));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,((_MainTex_var.a*i.vertexColor.a)*(node_383*_Color.a)));
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0,0,0,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
