// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34955,y:32485,varname:node_3138,prsc:2|emission-6211-OUT,alpha-552-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:34268,y:32345,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.295452,c2:0.441802,c3:0.522,c4:0.5019608;n:type:ShaderForge.SFN_FragmentPosition,id:9663,x:32542,y:32750,varname:node_9663,prsc:2;n:type:ShaderForge.SFN_Transform,id:310,x:32884,y:32828,varname:node_310,prsc:2,tffrom:0,tfto:1|IN-8047-OUT;n:type:ShaderForge.SFN_ObjectPosition,id:8137,x:32542,y:32890,varname:node_8137,prsc:2;n:type:ShaderForge.SFN_Subtract,id:8047,x:32719,y:32845,varname:node_8047,prsc:2|A-9663-XYZ,B-8137-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:1550,x:33223,y:32774,cmnt:z,varname:node_1550,prsc:2,cc1:0,cc2:1,cc3:2,cc4:-1|IN-4934-OUT;n:type:ShaderForge.SFN_Add,id:5609,x:34172,y:32816,varname:node_5609,prsc:2|A-7241-A,B-2769-OUT,C-8728-OUT;n:type:ShaderForge.SFN_Tex2d,id:2174,x:33729,y:32773,ptovrint:False,ptlb:grid,ptin:_grid,varname:_grid,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7dc57cc6ddc69954a8c83105b926fa94,ntxv:2,isnm:False|UVIN-6330-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9444,x:32862,y:32774,ptovrint:False,ptlb:gridUVScal,ptin:_gridUVScal,varname:_gridUVScal,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Multiply,id:4934,x:33053,y:32774,varname:node_4934,prsc:2|A-9444-OUT,B-310-XYZ;n:type:ShaderForge.SFN_Append,id:6330,x:33483,y:32808,varname:node_6330,prsc:2|A-6015-OUT,B-1550-B;n:type:ShaderForge.SFN_Add,id:6015,x:33406,y:32651,varname:node_6015,prsc:2|A-1550-R,B-1550-G;n:type:ShaderForge.SFN_Power,id:2769,x:33915,y:32825,varname:node_2769,prsc:2|VAL-2174-R,EXP-6817-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6817,x:33713,y:32991,ptovrint:False,ptlb:gridPower,ptin:_gridPower,varname:_gridPower,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Abs,id:7513,x:33428,y:32519,varname:node_7513,prsc:2|IN-1550-B;n:type:ShaderForge.SFN_Multiply,id:950,x:34542,y:32668,varname:node_950,prsc:2|A-2002-OUT,B-5609-OUT,C-7896-OUT;n:type:ShaderForge.SFN_Clamp01,id:1707,x:34017,y:32507,varname:node_1707,prsc:2|IN-6919-OUT;n:type:ShaderForge.SFN_OneMinus,id:2002,x:34250,y:32507,varname:node_2002,prsc:2|IN-1707-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1302,x:33712,y:32664,ptovrint:False,ptlb:growValue,ptin:_growValue,varname:_growValue,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Add,id:6211,x:34589,y:32418,varname:node_6211,prsc:2|A-7241-RGB,B-6660-OUT,C-579-OUT,D-8728-OUT;n:type:ShaderForge.SFN_Multiply,id:6660,x:34191,y:32687,varname:node_6660,prsc:2|A-2769-OUT,B-140-OUT;n:type:ShaderForge.SFN_ValueProperty,id:140,x:33901,y:32714,ptovrint:False,ptlb:LineLight,ptin:_LineLight,varname:_LineLight,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Subtract,id:6919,x:33801,y:32507,varname:node_6919,prsc:2|A-4677-OUT,B-1302-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8379,x:34203,y:32972,ptovrint:False,ptlb:ScaneLight,ptin:_ScaneLight,varname:_ScaneLight,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:579,x:34478,y:32848,varname:node_579,prsc:2|A-2002-OUT,B-1707-OUT,C-8379-OUT;n:type:ShaderForge.SFN_Add,id:552,x:34728,y:32772,varname:node_552,prsc:2|A-950-OUT,B-579-OUT;n:type:ShaderForge.SFN_Multiply,id:4677,x:33603,y:32538,varname:node_4677,prsc:2|A-7513-OUT,B-5287-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5287,x:33559,y:32705,ptovrint:False,ptlb:ScaneGloss,ptin:_ScaneGloss,varname:_ScaneGloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Fresnel,id:1797,x:33967,y:33090,varname:node_1797,prsc:2|EXP-224-OUT;n:type:ShaderForge.SFN_Multiply,id:8728,x:34174,y:33130,varname:node_8728,prsc:2|A-1797-OUT,B-8531-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8531,x:33946,y:33301,ptovrint:False,ptlb:RimLight,ptin:_RimLight,varname:_RimLight,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:224,x:33745,y:33186,ptovrint:False,ptlb:exp,ptin:_exp,varname:_exp,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:7896,x:34489,y:33109,ptovrint:False,ptlb:alpha,ptin:_alpha,varname:_alpha,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;proporder:7241-2174-9444-6817-1302-140-8379-5287-8531-224-7896;pass:END;sub:END;*/

Shader "_Game/Effect/BornShipEffect2" {
    Properties {
        _Color ("Color", Color) = (0.295452,0.441802,0.522,0.5019608)
        _grid ("grid", 2D) = "black" {}
        _gridUVScal ("gridUVScal", Float ) = 2
        _gridPower ("gridPower", Float ) = 2
        _growValue ("growValue", Float ) = 4
        _LineLight ("LineLight", Float ) = 1
        _ScaneLight ("ScaneLight", Float ) = 1
        _ScaneGloss ("ScaneGloss", Float ) = 1
        _RimLight ("RimLight", Float ) = 1
        _exp ("exp", Float ) = 1
        _alpha ("alpha", Float ) = 0.3
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 2.0
            uniform float4 _Color;
            uniform sampler2D _grid; uniform float4 _grid_ST;
            uniform float _gridUVScal;
            uniform float _gridPower;
            uniform float _growValue;
            uniform float _LineLight;
            uniform float _ScaneLight;
            uniform float _ScaneGloss;
            uniform float _RimLight;
            uniform float _exp;
            uniform float _alpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos(v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float3 node_1550 = (_gridUVScal*mul( unity_WorldToObject, float4((i.posWorld.rgb-objPos.rgb),0) ).xyz.rgb).rgb; // z
                float2 node_6330 = float2((node_1550.r+node_1550.g),node_1550.b);
                float4 _grid_var = tex2D(_grid,TRANSFORM_TEX(node_6330, _grid));
                float node_2769 = pow(_grid_var.r,_gridPower);
                float node_1707 = saturate(((abs(node_1550.b)*_ScaneGloss)-_growValue));
                float node_2002 = (1.0 - node_1707);
                float node_579 = (node_2002*node_1707*_ScaneLight);
                float node_8728 = (pow(1.0-max(0,dot(normalDirection, viewDirection)),_exp)*_RimLight);
                float3 emissive = (_Color.rgb+(node_2769*_LineLight)+node_579+node_8728);
                float3 finalColor = emissive;
                return fixed4(finalColor,((node_2002*(_Color.a+node_2769+node_8728)*_alpha)+node_579));
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
